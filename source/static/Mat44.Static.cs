namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007
public static class Mat44
{
    // called in right case
    // I believe asm could be more performant and there is place for 256
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Affine128<T>(Vec3<T> t, Quat<T> r, Vec3<T> s)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m;

        var xmm0 = r.Vec4().As128().As<T, float>(); // X, Y, Z, W

        var xmm1 = Vector128.Shuffle(xmm0, Vector128.Create(0, 1, 2, 2)); // X, Y, Z, Z
        var xmm2 = Vector128.Shuffle(xmm0, Vector128.Create(3, 2, 0, 1)); // W, Z, X, Y
        var xmm3 = Vector128.Shuffle(xmm0, Vector128.Create(1, 0, 0, 0)); // Y, X, X, X for X * Y

        xmm1 *= xmm0;
        xmm2 *= xmm0;
        xmm3 *= xmm0;

        var x = xmm2.WithElement(3, xmm3[0]).WithElement(0, 0);
        var z = xmm2.WithElement(1, xmm1[3]).WithElement(2, 0);

        x = Vector128.Shuffle(x, Vector128.Create(2, 3, 1, 0));
        z = Vector128.Shuffle(z, Vector128.Create(3, 1, 0, 2));

        xmm1 = xmm1.WithElement(3, 0);

        var y = Vector128.Shuffle(xmm1, Vector128.Create(2, 2, 0, 3));
        var w = Vector128.Shuffle(xmm1, Vector128.Create(1, 0, 1, 3));

        xmm0 = x + z;
        xmm1 = y + w;
        xmm2 = x - z;

        xmm0 += xmm0;
        xmm2 += xmm2;
        xmm1 += xmm1;
        xmm1 = Vector128.Create(1f) - xmm1;

        x = Vector128.Create(xmm1[0], xmm0[1], xmm2[0], 0f);
        y = Vector128.Create(xmm2[1], xmm1[1], xmm0[2], 0f);
        z = Vector128.Create(xmm0[0], xmm2[2], xmm1[2], 0f);
        // this should be previously loaded to xmm with vmovsd + vinsertps for Z, its not now
        w = Vector128.Create((float)(object)t.X, (float)(object)t.Y, (float)(object)t.Z, 1f);

        unsafe
        {
            (x.As<float, T>() * s.X).Store((T*)&m);
            (y.As<float, T>() * s.Y).Store((T*)&m.Y);
            (z.As<float, T>() * s.Z).Store((T*)&m.Z);
            w.As<float, T>().Store((T*)&m.W);
        }
        return m;
    }

    // called in right case
    // I believe asm could be more performant and there is place for 512
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Affine256<T>(Vec3<T> t, Quat<T> r, Vec3<T> s)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m;

        var ymm0 = r.Vec4().As256().As<T, double>(); // X, Y, Z, W

        var ymm1 = Vector256.Shuffle(ymm0, Vector256.Create(0, 1, 2, 2)); // X, Y, Z, Z
        var ymm2 = Vector256.Shuffle(ymm0, Vector256.Create(3, 2, 0, 1)); // W, Z, X, Y
        var ymm3 = Vector256.Shuffle(ymm0, Vector256.Create(1, 0, 0, 0)); // Y, X, X, X for X * Y

        ymm1 *= ymm0;
        ymm2 *= ymm0;
        ymm3 *= ymm0;

        var x = ymm2.WithElement(3, ymm3[0]).WithElement(0, 0);
        var z = ymm2.WithElement(1, ymm1[3]).WithElement(2, 0);

        ymm1 = ymm1.WithElement(3, 0);

        x = Vector256.Shuffle(x, Vector256.Create(2, 3, 1, 0));
        z = Vector256.Shuffle(z, Vector256.Create(3, 1, 0, 2));

        var y = Vector256.Shuffle(ymm1, Vector256.Create(2, 2, 0, 3));
        var w = Vector256.Shuffle(ymm1, Vector256.Create(1, 0, 1, 3));

        ymm0 = x + z;
        ymm1 = y + w;
        ymm2 = x - z;

        ymm0 += ymm0;
        ymm1 += ymm1;
        ymm1 = Vector256.Create(1d) - ymm1;
        ymm2 += ymm2;

        x = Vector256.Create(ymm1[0], ymm0[1], ymm2[0], 0f);
        y = Vector256.Create(ymm2[1], ymm1[1], ymm0[2], 0f);
        z = Vector256.Create(ymm0[0], ymm2[2], ymm1[2], 0f);

        // this should be previously loaded to low xmm[n] of ymm[n] with something like vmovapd, then insert Z, its not now
        w = Vector256.Create((double)(object)t.X, (double)(object)t.Y, (double)(object)t.Z, 1f);

        unsafe
        {
            (x.As<double, T>() * s.X).Store((T*)&m);
            (y.As<double, T>() * s.Y).Store((T*)&m.Y);
            (z.As<double, T>() * s.Z).Store((T*)&m.Z);
            w.As<double, T>().Store((T*)&m.W);
        }
        return m;
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Affine<T>(Vec3<T> t, Quat<T> r, Vec3<T> s)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if (typeof(T) == typeof(float) && Vector128<float>.IsSupported)
            return Affine128(t, r, s);

        if (typeof(T) == typeof(double) && Vector256<double>.IsSupported)
            return Affine256(t, r, s);

        T d = T.One + T.One, // T.Two should exist

        xx = r.X * r.X,
        yy = r.Y * r.Y,
        zz = r.Z * r.Z,
        xy = r.X * r.Y,
        zw = r.Z * r.W,
        zx = r.Z * r.X,
        yw = r.Y * r.W,
        yz = r.Y * r.Z,
        xw = r.X * r.W;

        return new(s.X * (T.One - (d * (yy + zz))), s.X * d * (xy + zw),             s.X * d * (zx - yw),             T.Zero,
                   s.Y * d * (xy - zw),             s.Y * (T.One - (d * (zz + xx))), s.Y * d * (yz + xw),             T.Zero,
                   s.Z * d * (zx + yw),             s.Z * d * (yz - xw),             s.Z * (T.One - (d * (yy + xx))), T.Zero,
                   t.X,                             t.Y,                             t.Z,                             T.One);
    }

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Transform<T>(Mat44<T> m, Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        T
        xx = q.X + q.X,
        yy = q.Y + q.Y,
        zz = q.Z + q.Z,

        wx = q.W * xx,
        wy = q.W * yy,
        wz = q.W * zz,
        xy = q.X * yy,
        xz = q.X * zz,
        yz = q.Y * zz;

        xx = q.X * xx;
        yy = q.Y * yy;
        zz = q.Z * zz;

        T
        q11 = T.One - yy - zz,
        q21 = xy - wz,
        q31 = xz + wy,

        q12 = xy + wz,
        q22 = T.One - xx - zz,
        q32 = yz - wx,

        q13 = xz - wy,
        q23 = yz + wx,
        q33 = T.One - xx - yy;

        // bruh...
        return new(
            (m.X.X * q11) + (m.X.Y * q21) + (m.X.Z * q31),
                (m.X.X * q12) + (m.X.Y * q22) + (m.X.Z * q32),
                    (m.X.X * q13) + (m.X.Y * q23) + (m.X.Z * q33),
                        m.X.W,

            (m.Y.X * q11) + (m.Y.Y * q21) + (m.Y.Z * q31),
                (m.Y.X * q12) + (m.Y.Y * q22) + (m.Y.Z * q32),
                    (m.Y.X * q13) + (m.Y.Y * q23) + (m.Y.Z * q33),
                        m.Y.W,

            (m.Z.X * q11) + (m.Z.Y * q21) + (m.Z.Z * q31),
                (m.Z.X * q12) + (m.Z.Y * q22) + (m.Z.Z * q32),
                    (m.Z.X * q13) + (m.Z.Y * q23) + (m.Z.Z * q33),
                        m.Z.W,

            (m.W.X * q11) + (m.W.Y * q21) + (m.W.Z * q31),
                (m.W.X * q12) + (m.W.Y * q22) + (m.W.Z * q32),
                    (m.W.X * q13) + (m.W.Y * q23) + (m.W.Z * q33),
                        m.W.W);
    }

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Scale<T>(T s)
        where T : unmanaged, INumber<T>
            => new(s,      T.Zero, T.Zero, T.Zero,
                   T.Zero, s,      T.Zero, T.Zero,
                   T.Zero, T.Zero, s,      T.Zero,
                   T.Zero, T.Zero, T.Zero, T.One);

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Scale<T>(Vec3<T> s)
        where T : unmanaged, INumber<T>
            => new(s.X,    T.Zero, T.Zero, T.Zero,
                   T.Zero, s.Y,    T.Zero, T.Zero,
                   T.Zero, T.Zero, s.Z,    T.Zero,
                   T.Zero, T.Zero, T.Zero, T.One);

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Translation<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => new(T.One,  T.Zero, T.Zero, T.Zero,
                   T.Zero, T.One,  T.Zero, T.Zero,
                   T.Zero, T.Zero, T.One,  T.Zero,
                   v.X,    v.Y,    v.Z,    T.One);

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Rotation<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        T d = T.One + T.One;

        T xx = q.X * q.X,
          yy = q.Y * q.Y,
          zz = q.Z * q.Z,
          xy = q.X * q.Y,
          zw = q.Z * q.W,
          zx = q.Z * q.X,
          yw = q.Y * q.W,
          yz = q.Y * q.Z,
          xw = q.X * q.W;

        return new(T.One - (d * (yy + zz)), d * (xy + zw),         d * (zx - yw),         T.Zero,
                   d * (xy - zw),         T.One - (d * (zz + xx)), d * (yz + xw),         T.Zero,
                   d * (zx + yw),         d * (yz - xw),         T.One - (d * (yy + xx)), T.Zero,
                   T.Zero,                T.Zero,                T.Zero,                T.One);
    }
}
