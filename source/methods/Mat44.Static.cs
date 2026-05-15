namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007

// T.Two should exist

public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Add<T>(Mat44<T> a, Mat44<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() + b.As256()).Mat44();

        if (Vector512<T>.IsSupported && Vector512.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 4)
                return (a.As512() + b.As512()).Mat44();

            if (SizeOf<T>() == 8)
            {
                a.As512(out var axy, out var azw);
                b.As512(out var bxy, out var bzw);
                axy += bxy;
                azw += bzw;
                return axy.Mat44(azw);
            }
        }
        return new(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Subtract<T>(Mat44<T> a, Mat44<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() - b.As256()).Mat44();

        if (Vector512<T>.IsSupported && Vector512.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 4)
                return (a.As512() - b.As512()).Mat44();

            if (SizeOf<T>() == 8)
            {
                a.As512(out var axy, out var azw);
                b.As512(out var bxy, out var bzw);
                axy -= bxy;
                azw -= bzw;
                return axy.Mat44(azw);
            }
        }
        return new(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Multiply<T>(Mat44<T> m, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (m.As256() * n).Mat44();

        if (Vector512<T>.IsSupported && Vector512.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 4)
                return (m.As512() * n).Mat44();

            if (SizeOf<T>() == 8)
            {
                m.As512(out var xy, out var zw);
                xy *= n;
                zw *= n;
                return xy.Mat44(zw);
            }
        }
        return new(m.X * n, m.Y * n, m.Z * n, m.W * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Multiply<T>(Mat44<T> a, Mat44<T> b)
        where T : unmanaged, INumber<T>
    {
        // both "hand" and "transform" vectorized ways are non-optimal currently
        // asm is different from System.Numerics - performance is close, but should be better

        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Mat44<T>.Multiply128(a, b);

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Mat44<T>.Multiply256(a, b);

        a.X = a.X.Transform(b);
        a.Y = a.Y.Transform(b);
        a.Z = a.Z.Transform(b);
        a.W = a.W.Transform(b);

        return a;
    }

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Transpose<T>(Mat44<T> m)
        where T : unmanaged, INumber<T> => new
    (
        m.X.X, m.Y.X, m.Z.X, m.W.X,
        m.X.Y, m.Y.Y, m.Z.Y, m.W.Y,
        m.X.Z, m.Y.Z, m.Z.Z, m.W.Z,
        m.X.W, m.Y.W, m.Z.W, m.W.W
    );

    /**<summary>
    Creates a matrix with the rotation, scale and translation components.
    </summary>
    <param name="rotation">Rotation value specified by quaternion.</param>
    <param name="scale">Scale factors specified by 3-dimensional vector.</param>
    <param name="translation">Translation specified by 3-dimensional vector.</param>
    <returns>Affine matrix (also known as a model matrix).</returns>*/
    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Affine<T>(Quat<T> rotation, Vec3<T> scale, Vec3<T> translation)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Affine(rotation.Vec4(), in scale, translation);
        }

        var q = rotation; var s = scale; var t = translation;

        T d = T.One + T.One, xx = q.X * q.X, yy = q.Y * q.Y, zz = q.Z * q.Z,

        xy = q.X * q.Y, xw = q.X * q.W,
        xz = q.X * q.Z, yw = q.Y * q.W,
        yz = q.Y * q.Z, zw = q.Z * q.W,

        q11 = T.One - (d * (yy + zz)), q12 = d * (xy + zw),           q13 = d * (xz - yw),
        q21 = d * (xy - zw),           q22 = T.One - (d * (xx + zz)), q23 = d * (yz + xw),
        q31 = d * (xz + yw),           q32 = d * (yz - xw),           q33 = T.One - (d * (xx + yy));

        return new(q11 * s.X, q12 * s.X, q13 * s.X, T.Zero,
                   q21 * s.Y, q22 * s.Y, q23 * s.Y, T.Zero,
                   q31 * s.Z, q32 * s.Z, q33 * s.Z, T.Zero,
                   t.X,       t.Y,       t.Z,       T.One);
    }

    /**<summary>
    Creates a matrix from the quaternion.
    </summary>
    <param name="rotation">Rotation value specified by quaternion.</param>
    <returns>Rotation matrix.</returns>*/
    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Rotation<T>(Quat<T> rotation)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Rotation(rotation.Vec4());
        }

        var q = rotation;

        T d = T.One + T.One, xx = q.X * q.X, yy = q.Y * q.Y, zz = q.Z * q.Z,

        xy = q.X * q.Y, xw = q.X * q.W,
        xz = q.X * q.Z, yw = q.Y * q.W,
        yz = q.Y * q.Z, zw = q.Z * q.W,

        q11 = T.One - (d * (yy + zz)), q12 = d * (xy + zw),           q13 = d * (xz - yw),
        q21 = d * (xy - zw),           q22 = T.One - (d * (xx + zz)), q23 = d * (yz + xw),
        q31 = d * (xz + yw),           q32 = d * (yz - xw),           q33 = T.One - (d * (xx + yy));

        return new(q11,    q12,    q13,    T.Zero,
                   q21,    q22,    q23,    T.Zero,
                   q31,    q32,    q33,    T.Zero,
                   T.Zero, T.Zero, T.Zero, T.One);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Rotate<T>(Mat44<T> m, Quat<T> rotation)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Rotate(m, rotation.Vec4());
        }

        var q = rotation;

        T
        xx = q.X + q.X, yy = q.Y + q.Y, zz = q.Z + q.Z,

        xy = q.X * yy, xw = xx * q.W,
        xz = q.Z * xx, yw = yy * q.W,
        yz = q.Y * zz, zw = zz * q.W;

        xx = q.X * xx; yy = q.Y * yy; zz = q.Z * zz;

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
    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Scale<T>(T s) where T : unmanaged, INumber<T> => new(
        s,      T.Zero, T.Zero, T.Zero,
        T.Zero, s,      T.Zero, T.Zero,
        T.Zero, T.Zero, s,      T.Zero,
        T.Zero, T.Zero, T.Zero, T.One);

    [Obsolete("vectorize, todo 'Scale' with input matrix")]
    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Scale<T>(Vec3<T> s) where T : unmanaged, INumber<T> => new(
        s.X,    T.Zero, T.Zero, T.Zero,
        T.Zero, s.Y,    T.Zero, T.Zero,
        T.Zero, T.Zero, s.Z,    T.Zero,
        T.Zero, T.Zero, T.Zero, T.One);

    [Obsolete("vectorize, todo 'Translate' with input matrix")]
    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Translation<T>(Vec3<T> t) where T : unmanaged, INumber<T> => new(
        T.One,  T.Zero, T.Zero, T.Zero,
        T.Zero, T.One,  T.Zero, T.Zero,
        T.Zero, T.Zero, T.One,  T.Zero,
        t.X,    t.Y,    t.Z,    T.One);
}
