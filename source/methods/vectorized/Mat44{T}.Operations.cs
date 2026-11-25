using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007, IDE0047

// calls in right cases
// 128 and 256 ways are combined into one
public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> Permute<T>(
        Vec4<T> a, Vec4<T> b,
        [ConstantExpected] byte x, [ConstantExpected] byte y, [ConstantExpected] byte z, [ConstantExpected] byte w)
            where T : unmanaged, INumber<T>
    {
#pragma warning disable CA1857
        if (SizeOf<T>() == 4)
        {
            return Sse.Shuffle(a.As128().As<T, float>(), b.As128().As<T, float>(), (byte)((w << 6) | (z << 4) | (y << 2) | x)).As<float, T>().Vec4();
        }
        return Vector256.ConcatLowerLower(
            Vector256.Shuffle(a.As256().As<T, double>(), Vector256.Create(x, y, 0, 0)).As<double, T>(),
            Vector256.Shuffle(b.As256().As<T, double>(), Vector256.Create(z, w, 0, 0)).As<double, T>()
        ).Vec4();
#pragma warning restore CA1857
    }

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> TransposeSoft<T>(Mat44<T> m)
        where T : unmanaged, INumber<T> => new(
            m.X.X, m.Y.X, m.Z.X, m.W.X,
            m.X.Y, m.Y.Y, m.Z.Y, m.W.Y,
            m.X.Z, m.Y.Z, m.Z.Z, m.W.Z,
            m.X.W, m.Y.W, m.Z.W, m.W.W);

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> Transpose8<T>(Mat44<T> m)
        where T : unmanaged, INumber<T> => m.As128().Permute8(0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15).Mat44();

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> Transpose16<T>(Mat44<T> m)
        where T : unmanaged, INumber<T> => m.As256().Permute16(0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15).Mat44();

    [MethodImpl(AggressiveInlining)]
    private static unsafe Mat44<T> Transpose32<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        if (Vector512<T>.IsSupported && Vector512.IsHardwareAccelerated)
            return m.As512().Permute32(0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15).Mat44();

        if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
        {
            var p = (T*)&m;

            var xy = Vector256.Load(p    ).Permute32(0, 4, 1, 5, 2, 6, 3, 7);
            var zw = Vector256.Load(p + 8).Permute32(0, 4, 1, 5, 2, 6, 3, 7);

            Vector256.ZipLower(xy, zw).Permute32(0, 2, 1, 3, 4, 6, 5, 7).Store(p);
            Vector256.ZipUpper(xy, zw).Permute32(0, 2, 1, 3, 4, 6, 5, 7).Store(p + 8);

            return m;
        }

        if (Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
        {
            Vec4<T>
            xzb = m.X.ZipLower(m.Z),
            ywb = m.Y.ZipLower(m.W),
            xzt = m.X.ZipUpper(m.Z),
            ywt = m.Y.ZipUpper(m.W);

            m.X = xzb.ZipLower(ywb);
            m.Y = xzb.ZipUpper(ywb);
            m.Z = xzt.ZipLower(ywt);
            m.W = xzt.ZipUpper(ywt);

            return m;
        }
        return TransposeSoft(m);
    }

    [MethodImpl(AggressiveInlining)]
    private static unsafe Mat44<T> Transpose64<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        if (Vector512<T>.IsSupported && Vector512.IsHardwareAccelerated)
        {
            var p = (T*)&m;

            var xy = Vector512.Load(p    ).Permute64(0, 4, 1, 5, 2, 6, 3, 7);
            var zw = Vector512.Load(p + 8).Permute64(0, 4, 1, 5, 2, 6, 3, 7);

            Vector512.ZipLower(xy, zw).Permute64(0, 2, 1, 3, 4, 6, 5, 7).Store(p);
            Vector512.ZipUpper(xy, zw).Permute64(0, 2, 1, 3, 4, 6, 5, 7).Store(p + 8);

            return m;
        }

        if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
        {
            Vec4<T>
            xzb = m.X.ZipLower(m.Z),
            ywb = m.Y.ZipLower(m.W),
            xzt = m.X.ZipUpper(m.Z),
            ywt = m.Y.ZipUpper(m.W);

            m.X = xzb.ZipLower(ywb);
            m.Y = xzb.ZipUpper(ywb);
            m.Z = xzt.ZipLower(ywt);
            m.W = xzt.ZipUpper(ywt);

            return m;
        }
        return TransposeSoft(m);
    }

    [MethodImpl(AggressiveInlining)]
    public static T Determinant<T>(Vec4<T> x, Vec4<T> y, Vec4<T> z, Vec4<T> w)
        where T : unmanaged, INumber<T>
    {
        y = y.ZWXY();
        w = w.ZWXY();

        var a = (z * w).YXWZ();

        var b = a.ZWXY() - a;

        var c = y * b;

        a = y * z;

        a = a.YXWZ();
        b = a - a.ZWXY();

        c = w.Estimate(b, c);

        a = y.ZWXY() * w;
        a = a.YXWZ();
        z = z.ZWXY();

        b = a - a.ZWXY();

        c = z.Estimate(b, c);

        return (x * c).Sum();
    }

    [Obsolete("rewrite")]
    [MethodImpl(AggressiveInlining)]
    private static bool Invert<T>(Mat44<T> m, T eps, out Mat44<T> inv)
        where T : unmanaged, IFloatingPoint<T>
    {
        SkipInit(out inv);

        Vec4<T>
        xzb = m.X.ZipLower(m.Z),
        ywb = m.Y.ZipLower(m.W),
        xzt = m.X.ZipUpper(m.Z),
        ywt = m.Y.ZipUpper(m.W),

        x = xzb.ZipLower(ywb),
        y = xzb.ZipUpper(ywb),
        z = xzt.ZipLower(ywt),
        w = xzt.ZipUpper(ywt),

        v0 = z.XXYY(), v1 = w.ZWZW(),
        v2 = x.XXYY(), v3 = y.ZWZW(),

        v4 = z.UnzipEven(x),
        v5 = w.UnzipOdd(y),

        v6, v7,

        d0 = v0 * v1,
        d1 = v2 * v3,
        d2 = v4 * v5,

        c0, c1, c2, c3, c4, c5, c6, c7;

        v0 = z.ZWZW(); v1 = w.XXYY();
        v2 = x.ZWZW(); v3 = y.XXYY();

        v4 = z.UnzipOdd(x);
        v5 = w.UnzipEven(y);

        d0 = v0.Estimate(-v1, d0);
        d1 = v2.Estimate(-v3, d1);
        d2 = v4.Estimate(-v5, d2);

        v3 = Permute(d0, d2, 1, 3, 1, 1);
        v7 = Permute(d1, d2, 1, 3, 3, 3);
        v1 = Permute(v3, d0, 2, 0, 3, 0);
        v3 = Permute(v3, d0, 1, 2, 1, 2);
        v5 = Permute(v7, d1, 2, 0, 3, 0);
        v7 = Permute(v7, d1, 1, 2, 1, 2);

        v0 = y.YZXY(); v2 = x.ZXYX();
        v4 = w.YZXY(); v6 = z.ZXYX();

        c0 = v0 * v1; c2 = v2 * v3;
        c4 = v4 * v5; c6 = v6 * v7;

        v3 = Permute(d0, d2, 0, 1, 0, 0);
        v7 = Permute(d1, d2, 0, 1, 2, 2);
        v1 = Permute(d0, v3, 3, 0, 1, 2);
        v3 = Permute(d0, v3, 2, 1, 2, 0);
        v5 = Permute(d1, v7, 3, 0, 1, 2);
        v7 = Permute(d1, v7, 2, 1, 2, 0);

        v0 = y.ZWYZ(); v2 = x.WZWY();
        v4 = w.ZWYZ(); v6 = z.WZWY();

        c0 = v0.Estimate(-v1, c0);
        c2 = v2.Estimate(-v3, c2);
        c4 = v4.Estimate(-v5, c4);
        c6 = v6.Estimate(-v7, c6);

        v1 = Permute(d0, d2, 2, 2, 0, 1).XWZX();
        v3 = Permute(d0, d2, 0, 3, 0, 1).WXYZ();
        v5 = Permute(d1, d2, 2, 2, 2, 3).XWZX();
        v7 = Permute(d1, d2, 0, 3, 2, 3).WXYZ();

        v0 = y.WXWX(); v2 = x.YWXZ();
        v4 = w.WXWX(); v6 = z.YWXZ();

        v0 *= v1; v2 *= v3;
        v4 *= v5; v6 *= v7;

        c1 = c0 - v0; c0 += v0;
        c3 = c2 + v2; c2 -= v2;
        c5 = c4 - v4; c4 += v4;
        c7 = c6 + v6; c6 -= v6;

        c0 = Permute(c0, c1, 0, 2, 1, 3).XZYW();
        c2 = Permute(c2, c3, 0, 2, 1, 3).XZYW();
        c4 = Permute(c4, c5, 0, 2, 1, 3).XZYW();
        c6 = Permute(c6, c7, 0, 2, 1, 3).XZYW();

        T det = Vec4.Dot(c0, x);

        if (T.Abs(det) <= eps)
            return false;

        var invDet = Vec4<T>.One / det;

        inv.X = c0 * invDet;
        inv.Y = c2 * invDet;
        inv.Z = c4 * invDet;
        inv.W = c6 * invDet;

        return true;
    }

    /// <inheritdoc cref="Rotation{T}(Quat{T})"/>
    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> Rotation<T>(Vec4<T> w)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        SkipInit(out Mat44<T> m);

        m = Rotation(m, w);

        m.W = Vec4<T>.UnitW; // Vec4<T>.UnitW currently provokes unnecessary asm

        return m;
    }

     /// <inheritdoc cref="Rotation{T}(Quat{T})"/>
    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> Rotation<T>(Mat44<T> m, Vec4<T> w)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Vec4<T> z = w.ZXYW(),

        x = w.YZXW() * w, // xy, yz, xz, ww
        y = w.WWWW() * z; // zw, xw, yw, ww
        w *= w;           // xx, yy, zz, ww

        (x, z) = (x + y, x - y); // xy +/- zw  | yz +/- xw  | xz +/- yw  |... / 0

        x += x;                  // 2(xy + zw) | 2(yz + xw) | 2(xz + yw) |...
        z += z;                  // 2(xy - zw) | 2(yz - xw) | 2(xz - yw) | 0
        w += w.YZXW();           // xx + yy    | yy + zz    | zz + xx    |...

        w = Vec4<T>.One - (w + w);
        // Vec4<T>.One currently provokes unnecessary asm
        m.X = z.Insert(0, 1, w).Insert(1, 0, x); // 1 - 2(yy + zz) | 2(xy + zw)     | 2(xz - yw)     | 0
        m.Y = z.Insert(1, 2, w).Insert(2, 1, x); // 2(xy - zw)     | 1 - 2(zz + xx) | 2(yz + xw)     | 0
        m.Z = z.Insert(0, 2, x).Insert(2, 0, w); // 2(xz + yw)     | 2(yz - xw)     | 1 - 2(xx + yy) | 0

        return m;
    }

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> Rotate<T>(Mat44<T> m, Vec4<T> w)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Vec4<T> x = w.YZXW(), y = w.WWWW(), c = w.ZXYW(), d,

        z = x * x; // yy, zz, xx, ww
        x = w * x; // xy, yz, xz, ww
        y = c * y; // zw, xw, yw, ww

        (d, c) = (x + y, x - y);     // xy +/- zw      | yz +/- xw      | xz +/- yw      |... / 0

        d = d.ZXYW(); z += z.YZXW();

        d += d;                      // 2(xz + yw)     | 2(xy + zw)     | 2(yz + xw)     |...|| q31, q12, q23
        c += c;                      // 2(xy - zw)     | 2(yz - xw)     | 2(xz - yw)     | 0 || q21, q32, q13
        z = Vec4<T>.One - (z + z);   // 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 2(xx + yy) |...|| q11, q22, q33
        // Vec4<T>.One currently provokes unnecessary asm

        x = m.X * z;                   // mx(x, y, z, w) * (q11, q22, q33, -)
        x = m.X.YZXW().Estimate(c, x); // mx(y, z, x, w) * (q21, q32, q13, -) + ...
        x = m.X.ZXYW().Estimate(d, x); // mx(z, x, y, w) * (q31, q12, q23, -) + ...

        y = m.Y * z;                   // my(x, y, z, w) * (q11, q22, q33, -)
        y = m.Y.YZXW().Estimate(c, y); // my(y, z, x, w) * (q21, q32, q13, -) + ...
        y = m.Y.ZXYW().Estimate(d, y); // my(z, x, y, w) * (q31, q12, q23, -) + ...

        z = m.Z * z;                   // mz(x, y, z, w) * (q11, q22, q33, -)
        z = m.Z.YZXW().Estimate(c, z); // mz(y, z, x, w) * (q21, q32, q13, -) + ...
        z = m.Z.ZXYW().Estimate(d, z); // mz(z, x, y, w) * (q31, q12, q23, -) + ...

        w = m.W * z;                   // mw(x, y, z, w) * (q11, q22, q33, -)
        w = m.W.YZXW().Estimate(c, w); // mw(y, z, x, w) * (q21, q32, q13, -) + ...
        w = m.W.ZXYW().Estimate(d, w); // mw(z, x, y, w) * (q31, q12, q23, -) + ...

        m.X = x.Insert(3, 3, m.X);
        m.Y = y.Insert(3, 3, m.Y);
        m.Z = z.Insert(3, 3, m.Z);
        m.W = w.Insert(3, 3, m.W);

        return m;
    }

    /// <inheritdoc cref="Affine{T}(Quat{T}, Vec3{T}, Vec3{T})"/>
    [MethodImpl(AggressiveInlining)]
    private static unsafe Mat44<T> Affine<T>(Vec4<T> r, Vec3<T> s, Vec3<T> t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        SkipInit(out Mat44<T> m);

        m = Rotation(m, r);

        T* p = (T*)&s;

        m.X *= *p;
        m.Y *= *(p + 1);
        m.Z *= *(p + 2);

        m.W.X = t.X;
        m.W.Y = t.Y;
        m.W.Z = t.Z;
        m.W.W = T.One;

        return m;
    }
}
