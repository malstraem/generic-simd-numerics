using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007

// T.Two should exist

public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    public static bool Equal<T>(Mat44<T> a, Mat44<T> b)
        where T : unmanaged, INumber<T>
    {
        if (Vector512<T>.IsSupported && Vector512.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 4)
                return a.As512() == b.As512();

            if (SizeOf<T>() == 8)
            {
                a.As512(out var axy, out var azw);
                b.As512(out var bxy, out var bzw);

                return axy == bxy && azw == bzw;
            }
        }

        if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 2)
                return a.As256() == b.As256();

            if (SizeOf<T>() == 4)
            {
                a.As256(out var axy, out var azw);
                b.As256(out var bxy, out var bzw);

                return axy == bxy && azw == bzw;
            }
        }

        if (SizeOf<T>() == 1 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return a.As128() == b.As128();

        return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool Equal<T>(Mat44<T> a, Mat44<T> b, T eps)
        where T : unmanaged, IFloatingPoint<T>
    {
        if (Vector512<T>.IsSupported && Vector512.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 4)
                return Vector512.LessThanOrEqualAll(Vector512.Abs(a.As512() - b.As512()), Vector512.Create(eps));

            if (SizeOf<T>() == 8)
            {
                a.As512(out var axy, out var azw);
                b.As512(out var bxy, out var bzw);

                var veps = Vector512.Create(eps);

                return Vector512.LessThanOrEqualAll(Vector512.Abs(axy - bxy), veps)
                    && Vector512.LessThanOrEqualAll(Vector512.Abs(azw - bzw), veps);
            }
        }

        if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 2)
                return Vector256.LessThanOrEqualAll(Vector256.Abs(a.As256() - b.As256()), Vector256.Create(eps));

            if (SizeOf<T>() == 4)
            {
                a.As256(out var axy, out var azw);
                b.As256(out var bxy, out var bzw);

                var veps = Vector256.Create(eps);

                return Vector256.LessThanOrEqualAll(Vector256.Abs(axy - bxy), veps)
                    && Vector256.LessThanOrEqualAll(Vector256.Abs(azw - bzw), veps);
            }
        }
        return Vec4.Equal(a.X, b.X, eps) && Vec4.Equal(a.Y, b.Y, eps) && Vec4.Equal(a.Z, b.Z, eps) && Vec4.Equal(a.W, b.W, eps);
    }

    [MethodImpl(AggressiveInlining)]
    public static bool NotEqual<T>(Mat44<T> a, Mat44<T> b)
        where T : unmanaged, INumber<T>
    {
        if (Vector512<T>.IsSupported && Vector512.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 4)
                return a.As512() != b.As512();

            if (SizeOf<T>() == 8)
            {
                a.As512(out var axy, out var azw);
                b.As512(out var bxy, out var bzw);

                return axy != bxy || azw != bzw;
            }
        }

        if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 2)
                return a.As256() != b.As256();

            if (SizeOf<T>() == 4)
            {
                a.As256(out var axy, out var azw);
                b.As256(out var bxy, out var bzw);

                return axy != bxy || azw != bzw;
            }
        }

        if (SizeOf<T>() == 1 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return a.As128() != b.As128();

        return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Add<T>(Mat44<T> a, Mat44<T> b)
        where T : unmanaged, INumber<T>
    {
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

        if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 2)
                return (a.As256() + b.As256()).Mat44();

            if (SizeOf<T>() == 4)
            {
                a.As256(out var axy, out var azw);
                b.As256(out var bxy, out var bzw);
                axy += bxy;
                azw += bzw;

                return axy.Mat44(azw);
            }
        }

        if (SizeOf<T>() == 1 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() + b.As128()).Mat44();

        return new(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Subtract<T>(Mat44<T> a, Mat44<T> b)
        where T : unmanaged, INumber<T>
    {
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

        if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 2)
                return (a.As256() - b.As256()).Mat44();

            if (SizeOf<T>() == 4)
            {
                a.As256(out var axy, out var azw);
                b.As256(out var bxy, out var bzw);
                axy -= bxy;
                azw -= bzw;

                return axy.Mat44(azw);
            }
        }

        if (SizeOf<T>() == 1 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() - b.As128()).Mat44();

        return new(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Multiply<T>(Mat44<T> m, T n)
        where T : unmanaged, INumber<T>
    {
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

        if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
        {
            if (SizeOf<T>() == 2)
                return (m.As256() * n).Mat44();

            if (SizeOf<T>() == 4)
            {
                m.As256(out var xy, out var zw);
                xy *= n;
                zw *= n;

                return xy.Mat44(zw);
            }
        }

        if (SizeOf<T>() == 1 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (m.As128() * n).Mat44();

        return new(m.X * n, m.Y * n, m.Z * n, m.W * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Multiply<T>(Mat44<T> a, Mat44<T> b)
        where T : unmanaged, INumber<T>
    {
        Mat44<T> m;
        m.X = Vec4.Transform(a.X, b);
        m.Y = Vec4.Transform(a.Y, b);
        m.Z = Vec4.Transform(a.Z, b);
        m.W = Vec4.Transform(a.W, b);
        return m;
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Transpose<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 1 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Transpose8(m);

        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Transpose16(m);

        if (SizeOf<T>() == 4)
            return Transpose32(m);

        if (SizeOf<T>() == 8)
            return Transpose64(m);

        return TransposeSoft(m);
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

    public static T Determinant<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Determinant(m.X, m.Y, m.Z, m.W);
        }
        T xx = m.X.X, xy = m.X.Y, xz = m.X.Z, xw = m.X.W,
          yx = m.Y.X, yy = m.Y.Y, yz = m.Y.Z, yw = m.Y.W,
          zx = m.Z.X, zy = m.Z.Y, zz = m.Z.Z, zw = m.Z.W,
          wx = m.W.X, wy = m.W.Y, wz = m.W.Z, ww = m.W.W;

        return (((xx * yy) - (xy * yx)) * ((zz * ww) - (zw * wz)))
             - (((xx * yz) - (xz * yx)) * ((zy * ww) - (zw * wy)))
             + (((xx * yw) - (xw * yx)) * ((zy * wz) - (zz * wy)))
             + (((xy * yz) - (xz * yy)) * ((zx * ww) - (zw * wx)))
             - (((xy * yw) - (xw * yy)) * ((zx * wz) - (zz * wx)))
             + (((xz * yw) - (xw * yz)) * ((zx * wy) - (zy * wx)));
    }

    [MethodImpl(AggressiveInlining)]
    public static bool TryInvert<T>(Mat44<T> m, out Mat44<T> inv)
        where T : unmanaged, IFloatingPoint<T>
    {
        T eps = typeof(T) == typeof(float)
            ? T.CreateChecked(MathF.BitIncrement(1f / float.MaxValue)) // bit increment should be generalized
            : T.CreateTruncating(Math.BitIncrement(1d / double.MaxValue));

        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Sse.IsSupported) // uses SSE specific shuffle
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)) // slower than scalar way currently
        {
            return Invert(m, eps, out inv);
        }
        SkipInit(out inv);

        T
        xx = m.X.X, xy = m.X.Y, xz = m.X.Z, xw = m.X.W,
        yx = m.Y.X, yy = m.Y.Y, yz = m.Y.Z, yw = m.Y.W,
        zx = m.Z.X, zy = m.Z.Y, zz = m.Z.Z, zw = m.Z.W,
        wx = m.W.X, wy = m.W.Y, wz = m.W.Z, ww = m.W.W,
        
        c0 = (zz * ww) - (zw * wz),
        c1 = (zy * ww) - (zw * wy),
        c2 = (zy * wz) - (zz * wy),
        c3 = (zx * ww) - (zw * wx),
        c4 = (zx * wz) - (zz * wx),
        c5 = (zx * wy) - (zy * wx);

        inv.X.X =   (yy * c0) - (yz * c1) + (yw * c2);
        inv.Y.X = -((yx * c0) - (yz * c3) + (yw * c4));
        inv.Z.X =   (yx * c1) - (yy * c3) + (yw * c5);
        inv.W.X = -((yx * c2) - (yy * c4) + (yz * c5));

        T det = (xx * inv.X.X) + (xy * inv.Y.X) + (xz * inv.Z.X) + (xw * inv.W.X);

        if (T.Abs(det) <= eps) // do we really need a NaN insertions as as is done in Matrix4x4?
            return false;

        inv.X.Y = -((xy * c0) - (xz * c1) + (xw * c2));
        inv.Y.Y =   (xx * c0) - (xz * c3) + (xw * c4);
        inv.Z.Y = -((xx * c1) - (xy * c3) + (xw * c5));
        inv.W.Y =   (xx * c2) - (xy * c4) + (xz * c5);

        c0 = (yz * ww) - (yw * wz);
        c1 = (yy * ww) - (yw * wy);
        c2 = (yy * wz) - (yz * wy);
        c3 = (yx * ww) - (yw * wx);
        c4 = (yx * wz) - (yz * wx);
        c5 = (yx * wy) - (yy * wx);

        inv.X.Z =   (xy * c0) - (xz * c1) + (xw * c2);
        inv.Y.Z = -((xx * c0) - (xz * c3) + (xw * c4));
        inv.Z.Z =   (xx * c1) - (xy * c3) + (xw * c5);
        inv.W.Z = -((xx * c2) - (xy * c4) + (xz * c5));

        c0 = (yz * zw) - (yw * zz);
        c1 = (yy * zw) - (yw * zy);
        c2 = (yy * zz) - (yz * zy);
        c3 = (yx * zw) - (yw * zx);
        c4 = (yx * zz) - (yz * zx);
        c5 = (yx * zy) - (yy * zx);

        inv.X.W = -((xy * c0) - (xz * c1) + (xw * c2));
        inv.Y.W =   (xx * c0) - (xz * c3) + (xw * c4);
        inv.Z.W = -((xx * c1) - (xy * c3) + (xw * c5));
        inv.W.W =   (xx * c2) - (xy * c4) + (xz * c5);

        inv *= T.One / det;

        return true;
    }

    /**<summary>
    Creates a matrix with the rotation, scale and translation components.
    </summary>
    <param name="rotation">Rotation value specified by quaternion.</param>
    <param name="scale">Scale factors specified by 3-dimensional vector.</param>
    <param name="translation">Translation specified by 3-dimensional vector.</param>
    <returns>Affine matrix (also known as a model matrix).</returns>*/
    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Affine<T>(Quat<T> rotation, Vec3<T> scale, Vec3<T> translation)
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Affine(rotation.Vec4(), scale, translation);
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
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
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
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
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

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T2> As<T, T2>(Mat44<T> m)
        where T : unmanaged, INumber<T>
        where T2 : unmanaged, INumber<T2>
    {
        if (SizeOf<T>() == 4)
            return Mat44<T>.Convert32<T2>(m);

        if (SizeOf<T>() == 8)
            return Mat44<T>.Convert64<T2>(m);

        return Mat44<T>.ByRows<T2>(m);
    }
}
