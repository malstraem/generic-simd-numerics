namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007
public static partial class Mat44
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Affine<T>(Quat<T> r, Vec3<T> s, Vec3<T> t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if (typeof(T) == typeof(float) && Vector128<float>.IsSupported)
            unsafe { return Affine128(r, &s, &t); }

        if (typeof(T) == typeof(double) && Vector256<double>.IsSupported)
            unsafe { return Affine256(r, &s, &t); }

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
    public static Mat44<T> Rotation<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        T d = T.One + T.One; // T.Two should exist

        T xx = q.X * q.X,
          yy = q.Y * q.Y,
          zz = q.Z * q.Z,
          xy = q.X * q.Y,
          zw = q.Z * q.W,
          zx = q.Z * q.X,
          yw = q.Y * q.W,
          yz = q.Y * q.Z,
          xw = q.X * q.W;

        return new(T.One - (d * (yy + zz)), d * (xy + zw),           d * (zx - yw),           T.Zero,
                   d * (xy - zw),           T.One - (d * (zz + xx)), d * (yz + xw),           T.Zero,
                   d * (zx + yw),           d * (yz - xw),           T.One - (d * (yy + xx)), T.Zero,
                   T.Zero,                  T.Zero,                  T.Zero,                  T.One);
    }

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Rotate<T>(Mat44<T> m, Quat<T> q)
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
    public static Mat44<T> Translation<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => new(T.One,  T.Zero, T.Zero, T.Zero,
                   T.Zero, T.One,  T.Zero, T.Zero,
                   T.Zero, T.Zero, T.One,  T.Zero,
                   v.X,    v.Y,    v.Z,    T.One);
}
