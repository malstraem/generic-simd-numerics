namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007

// T.Two should exist

public static partial class Mat44
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Affine<T>(Quat<T> r, Vec3<T> s, Vec3<T> t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            unsafe { return Affine128(r, &s, &t); }

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            unsafe { return Affine256(r, &s, &t); }

        T d = T.One + T.One, xx = r.X * r.X, yy = r.Y * r.Y, zz = r.Z * r.Z,

        xy = r.X * r.Y, xw = r.X * r.W,
        xz = r.X * r.Z, yw = r.Y * r.W,
        yz = r.Y * r.Z, zw = r.Z * r.W,

        q11 = T.One - (d * (yy + zz)), q12 = d * (xy + zw),           q13 = d * (xz - yw),
        q21 = d * (xy - zw),           q22 = T.One - (d * (xx + zz)), q23 = d * (yz + xw),
        q31 = d * (xz + yw),           q32 = d * (yz - xw),           q33 = T.One - (d * (xx + yy));

        return new(q11 * s.X, q12 * s.X, q13 * s.X, T.Zero,
                   q21 * s.Y, q22 * s.Y, q23 * s.Y, T.Zero,
                   q31 * s.Z, q32 * s.Z, q33 * s.Z, T.Zero,
                   t.X,       t.Y,       t.Z,       T.One);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Rotation<T>(Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Rotation128(r);

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Rotation256(r);

        T d = T.One + T.One, xx = r.X * r.X, yy = r.Y * r.Y, zz = r.Z * r.Z,

        xy = r.X * r.Y, xw = r.X * r.W,
        xz = r.X * r.Z, yw = r.Y * r.W,
        yz = r.Y * r.Z, zw = r.Z * r.W,

        q11 = T.One - (d * (yy + zz)), q12 = d * (xy + zw),           q13 = d * (xz - yw),
        q21 = d * (xy - zw),           q22 = T.One - (d * (xx + zz)), q23 = d * (yz + xw),
        q31 = d * (xz + yw),           q32 = d * (yz - xw),           q33 = T.One - (d * (xx + yy));

        return new(q11,    q12,    q13,    T.Zero,
                   q21,    q22,    q23,    T.Zero,
                   q31,    q32,    q33,    T.Zero,
                   T.Zero, T.Zero, T.Zero, T.One);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Rotate<T>(Mat44<T> m, Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Rotate128(m, r);

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Rotate256(m, r);

        T
        xx = r.X + r.X, yy = r.Y + r.Y, zz = r.Z + r.Z,

        xy = r.X * yy, xw = xx * r.W,
        xz = r.Z * xx, yw = yy * r.W,
        yz = r.Y * zz, zw = zz * r.W;

        xx = r.X * xx; yy = r.Y * yy; zz = r.Z * zz;

        T
        q11 = T.One - yy - zz, q12 = xy + zw,         q13 = xz - yw,
        q21 = xy - zw,         q22 = T.One - xx - zz, q23 = yz + xw,
        q31 = xz + yw,         q32 = yz - xw,         q33 = T.One - xx - yy;

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

    [Obsolete("vectorize, todo 'Scale' with input matrix")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Scale<T>(T s)
        where T : unmanaged, INumber<T>
            => new(s,      T.Zero, T.Zero, T.Zero,
                   T.Zero, s,      T.Zero, T.Zero,
                   T.Zero, T.Zero, s,      T.Zero,
                   T.Zero, T.Zero, T.Zero, T.One);

    [Obsolete("vectorize, todo 'Scale' with input matrix")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Scale<T>(Vec3<T> s)
        where T : unmanaged, INumber<T>
            => new(s.X,    T.Zero, T.Zero, T.Zero,
                   T.Zero, s.Y,    T.Zero, T.Zero,
                   T.Zero, T.Zero, s.Z,    T.Zero,
                   T.Zero, T.Zero, T.Zero, T.One);

    [Obsolete("vectorize, todo 'Translate' with input matrix")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Translation<T>(Vec3<T> t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => new(T.One,  T.Zero, T.Zero, T.Zero,
                   T.Zero, T.One,  T.Zero, T.Zero,
                   T.Zero, T.Zero, T.One,  T.Zero,
                   t.X,    t.Y,    t.Z,    T.One);
}
