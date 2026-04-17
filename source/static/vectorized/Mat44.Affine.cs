namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007

// called in right case
// shuffle/permute can be generalized to Permute<T> with only int indices, isn't?
// I believe asm could be more performant and there is more optimal way
// scalar x2 ops can be used for XY of translation and XY of scale and maybe for some insertions in calculus
public static partial class Mat44
{
    // any way to mix with 256?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe Mat44<T> Affine128<T>(Vec3<T> t, Quat<T> r, Vec3<T> s)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m;

        var w = r.Vec4().As128().As<T, float>(); // X, Y, Z, W

        var a = Vector128.Shuffle(w, Vector128.Create(1, 2, 0, 3)); // y, z, x, w
        var b = Vector128.Shuffle(w, Vector128.Create(3, 3, 3, 3)); // w, w, w, w
        var c = Vector128.Shuffle(w, Vector128.Create(2, 0, 1, 3)); // z, x, y, w

        a *= w; // yx, yz, zx, ww
        b *= c; // zw, xw, yw, ww
        w *= w; // xx, yy, zz, ww

        var sum = a + b;
        sum += sum; // 2(xy + zw), 2(yz + xw), 2(zx + yw), 2ww

        var dif = a - b;
        dif += dif; // 2(xy - zw), 2(yz - xw), 2(zx - yw), 0

        w += Vector128.Shuffle(w, Vector128.Create(1, 2, 0, 3)); //xx + yy, yy + zz, zz + xx, 2ww

        w += w; // 2(xx + yy), 2(yy + zz), 2(zz + xx), 4ww

        w = Vector128.Create(1f) - w; // 1 - 2(xx + yy), 1 - 2(yy + zz), 1 - 2(zz + xx), 1 - 4ww

        var x = Vector128.Create(w[1], sum[0], dif[2], 0f);
        var y = Vector128.Create(dif[0], w[2], sum[1], 0f);
        w = Vector128.Create(sum[2], dif[1], w[0], 0f);

        // should be previously loaded to xmm with vmovsd + vinsertps for Z, its not now
        var z = Vector128.Create((float)(object)t.X, (float)(object)t.Y, (float)(object)t.Z, 1f);

        (x.As<float, T>() * s.X).Store((T*)&m);
        (y.As<float, T>() * s.Y).Store((T*)&m.Y);
        (w.As<float, T>() * s.Z).Store((T*)&m.Z);
        z.As<float, T>().Store((T*)&m.W);

        return m;
    }

    // any way to mix with 512?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Affine256<T>(Vec3<T> t, Quat<T> r, Vec3<T> s)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m;

        var ymm0 = r.Vec4().As256().As<T, double>(); // X, Y, Z, W

        var ymm1 = Vector256.Shuffle(ymm0, Vector256.Create(0L, 1L, 2L, 2L)); // X, Y, Z, Z
        var ymm2 = Vector256.Shuffle(ymm0, Vector256.Create(3L, 2L, 0L, 1L)); // W, Z, X, Y
        var ymm3 = Vector256.Shuffle(ymm0, Vector256.Create(1L, 0L, 0L, 0L)); // Y, X, X, X

        ymm1 *= ymm0;
        ymm2 *= ymm0;
        ymm3 *= ymm0;

        var x = ymm2.WithElement(3, ymm3[0]).WithElement(0, 0d);
        var z = ymm2.WithElement(1, ymm1[3]).WithElement(2, 0d);

        ymm1 = ymm1.WithElement(3, 0d);

        x = Vector256.Shuffle(x, Vector256.Create(2L, 3L, 1L, 0L));
        z = Vector256.Shuffle(z, Vector256.Create(3L, 1L, 0L, 2L));

        var y = Vector256.Shuffle(ymm1, Vector256.Create(2L, 2L, 0L, 3L));
        var w = Vector256.Shuffle(ymm1, Vector256.Create(1L, 0L, 1L, 3L));

        ymm0 = x + z;
        ymm1 = y + w;
        ymm2 = x - z;

        ymm0 += ymm0;
        ymm2 += ymm2;
        ymm1 += ymm1;
        ymm1 = Vector256.Create(1d) - ymm1;

        x = Vector256.Create(ymm1[0], ymm0[1], ymm2[0], 0d);
        y = Vector256.Create(ymm2[1], ymm1[1], ymm0[2], 0d);
        z = Vector256.Create(ymm0[0], ymm2[2], ymm1[2], 0d);

        // should be previously loaded to low xmm[n] of ymm[n] with something like vmovapd, then insert Z, its not now
        w = Vector256.Create((double)(object)t.X, (double)(object)t.Y, (double)(object)t.Z, 1d);

        unsafe
        {
            (x.As<double, T>() * s.X).Store((T*)&m);
            (y.As<double, T>() * s.Y).Store((T*)&m.Y);
            (z.As<double, T>() * s.Z).Store((T*)&m.Z);
             w.As<double, T>()       .Store((T*)&m.W);
        }
        return m;
    }
}
