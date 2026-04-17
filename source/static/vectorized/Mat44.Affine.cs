namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007

// called in right case

// I believe shuffle/permute can be generalized to Permute<T> with only int indices, isn't?

// permutation should return non-generic "VectorNNN bit word" struct to juggle bits as it's now

// non generic vector should be able to be operand

// Vector128<T> some = ...
// Vector128 perm = some.Permute(1, 0) / (3, 2, 1, 0) etc overloads that JIT process/fallback to naive
public static partial class Mat44
{
    // any way to mix with 256? only 256 way?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe Mat44<T> Affine128<T>(Vec3<T> t, Quat<T> r, Vec3<T> s)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m;

        var w = r.Vec4().As128().As<T, float>();                    // x, y, z, w

        var x = Vector128.Shuffle(w, Vector128.Create(1, 2, 0, 3)); // y, z, x, w
        var y = Vector128.Shuffle(w, Vector128.Create(3, 3, 3, 3)); // w, w, w, w
        var z = Vector128.Shuffle(w, Vector128.Create(2, 0, 1, 3)); // z, x, y, w

        x *= w; // yx, yz, zx, ww
        y *= z; // zw, xw, yw, ww
        w *= w; // xx, yy, zz, ww

        //var n = -y;

        var n = x + y;                                           // 2(xy + zw), 2(yz + xw), 2(zx + yw), no mean 2ww
        z = x - y;
        w += Vector128.Shuffle(w, Vector128.Create(1, 2, 0, 3)); // xx + yy,    yy + zz,    zz + xx,    no mean 2ww

        w += w;                                                  // 2(xx + yy), 2(yy + zz), 2(zz + xx), no mean 4ww


        n += n;                                                  // 2(xy + zw), 2(yz + xw), 2(zx + yw), no mean 2ww
        z += z;                                                  // 2(xy - zw), 2(yz - xw), 2(zx - yw), 0

        w = Vector128.Create(1f) - w;                            // 1 - 2(xx + yy), 1 - 2(yy + zz), 1 - 2(zz + xx), no mean 1 - 4ww

        x = z.WithElement(0, w[1]).WithElement(1, n[0]);
        y = z.WithElement(1, w[2]).WithElement(2, n[1]);

        z = z.WithElement(0, n[2]).WithElement(2, w[0]);

        // should be previously loaded to xmm with vmovsd + vinsertps for Z, its not now
        w = Vector128.Create((float)(object)t.X, (float)(object)t.Y, (float)(object)t.Z, 1f);

        (x.As<float, T>() * s.X).Store((T*)&m);
        (y.As<float, T>() * s.Y).Store((T*)&m.Y);
        (z.As<float, T>() * s.Z).Store((T*)&m.Z);
         w.As<float, T>()       .Store((T*)&m.W);

        return m;
    }

    // any way to mix with 512? only 512 way?
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
