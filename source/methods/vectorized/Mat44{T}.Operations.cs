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
        Vec4<T> lower, Vec4<T> upper,
        [ConstantExpected] byte x, [ConstantExpected] byte y, [ConstantExpected] byte z, [ConstantExpected] byte w)
            where T : unmanaged, IFloatingPoint<T>
    {
#pragma warning disable CA1857
        if (SizeOf<T>() == 4)
            return Sse.Shuffle(lower.As128().As<T, float>(), upper.As128().As<T, float>(), (byte)((w << 6) | (z << 4) | (y << 2) | x)).As<float, T>().Vec4();

        var low = Vector256.Shuffle(lower.As256().As<T, double>(), Vector256.Create(x, y, 0, 0));

        var up = Vector256.Shuffle(upper.As256().As<T, double>(), Vector256.Create(z, w, 0, 0));

        return Vector256.ConcatLowerLower(low, up).As<double, T>().Vec4();
#pragma warning restore CA1857
    }

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> Transpose8<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        if (Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
        {
            return m.As128().Permute8(0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15).Mat44();
        }
        return new(
            m.X.X, m.Y.X, m.Z.X, m.W.X,
            m.X.Y, m.Y.Y, m.Z.Y, m.W.Y,
            m.X.Z, m.Y.Z, m.Z.Z, m.W.Z,
            m.X.W, m.Y.W, m.Z.W, m.W.W);
    }

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> Transpose16<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        if (Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
        {
            return m.As256().Permute16(0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15).Mat44();
        }
        return new(
            m.X.X, m.Y.X, m.Z.X, m.W.X,
            m.X.Y, m.Y.Y, m.Z.Y, m.W.Y,
            m.X.Z, m.Y.Z, m.Z.Z, m.W.Z,
            m.X.W, m.Y.W, m.Z.W, m.W.W);
    }

    [MethodImpl(AggressiveInlining)]
    private static unsafe Mat44<T> Transpose32<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        if (Vector512<T>.IsSupported && Vector512.IsHardwareAccelerated)
        {
            return m.As512().Permute32(0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15).Mat44();
        }
        if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
        {
            var p = (T*)&m;

            Vector256<T>
            xy = Vector256.Load(p).Permute32(0, 4, 1, 5, 2, 6, 3, 7),
            zw = Vector256.Load(p + 8).Permute32(0, 4, 1, 5, 2, 6, 3, 7);

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
        return new(
            m.X.X, m.Y.X, m.Z.X, m.W.X,
            m.X.Y, m.Y.Y, m.Z.Y, m.W.Y,
            m.X.Z, m.Y.Z, m.Z.Z, m.W.Z,
            m.X.W, m.Y.W, m.Z.W, m.W.W);
    }

    [MethodImpl(AggressiveInlining)]
    private static unsafe Mat44<T> Transpose64<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        if (Vector512<T>.IsSupported && Vector512.IsHardwareAccelerated)
        {
            var p = (T*)&m;

            Vector512<T>
            xy = Vector512.Load(p).Permute64(0, 4, 1, 5, 2, 6, 3, 7),
            zw = Vector512.Load(p + 8).Permute64(0, 4, 1, 5, 2, 6, 3, 7);

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
        return new(
            m.X.X, m.Y.X, m.Z.X, m.W.X,
            m.X.Y, m.Y.Y, m.Z.Y, m.W.Y,
            m.X.Z, m.Y.Z, m.Z.Z, m.W.Z,
            m.X.W, m.Y.W, m.Z.W, m.W.W);
    }

    [MethodImpl(AggressiveInlining)]
    private static bool Invert32<T>(Mat44<T> m, out Mat44<T> inv)
        where T : unmanaged, IFloatingPoint<T>
    {
        SkipInit(out inv);

        //m = Transpose(m);

        Vec4<T>
        xzb = m.X.ZipLower(m.Z),
        ywb = m.Y.ZipLower(m.W),
        xzt = m.X.ZipUpper(m.Z),
        ywt = m.Y.ZipUpper(m.W),

        x = xzb.ZipLower(ywb),
        y = xzb.ZipUpper(ywb),
        z = xzt.ZipLower(ywt),
        w = xzt.ZipUpper(ywt),

        c0, c1, c2, c3, c4, c5, c6, c7, v03, v13,

        v00 = z.XXYY(),
        v10 = w.ZWZW(),
        v01 = x.XXYY(),
        v11 = y.ZWZW(),

        v02 = z.UnzipEven(x),
        v12 = w.UnzipOdd(y),

        d0 = v00 * v10,
        d1 = v01 * v11,
        d2 = v02 * v12;

        v00 = z.ZWZW();
        v10 = w.XXYY();
        v01 = x.ZWZW();
        v11 = y.XXYY();

        v02 = z.UnzipOdd(x);
        v12 = w.UnzipEven(y);

        d0 = v00.Estimate(-v10, d0);
        d1 = v01.Estimate(-v11, d1);
        d2 = v02.Estimate(-v12, d2);

        v11 = Permute(d0, d2, 1, 3, 1, 1);
        v13 = Permute(d1, d2, 1, 3, 3, 3);
        v10 = Permute(v11, d0, 2, 0, 3, 0);
        v11 = Permute(v11, d0, 1, 2, 1, 2);
        v12 = Permute(v13, d1, 2, 0, 3, 0);
        v13 = Permute(v13, d1, 1, 2, 1, 2);

        v00 = y.YZXY();
        v01 = x.ZXYX();
        v02 = w.YZXY();
        v03 = z.ZXYX();

        c0 = v00 * v10;
        c2 = v01 * v11;
        c4 = v02 * v12;
        c6 = v03 * v13;

        v11 = Permute(d0, d2, 0, 1, 0, 0);
        v13 = Permute(d1, d2, 0, 1, 2, 2);
        v10 = Permute(d0, v11, 3, 0, 1, 2);
        v11 = Permute(d0, v11, 2, 1, 2, 0);
        v12 = Permute(d1, v13, 3, 0, 1, 2);
        v13 = Permute(d1, v13, 2, 1, 2, 0);

        v00 = y.ZWYZ();
        v01 = x.WZWY();
        v02 = w.ZWYZ();
        v03 = z.WZWY();

        c0 = v00.Estimate(-v10, c0);
        c2 = v01.Estimate(-v11, c2);
        c4 = v02.Estimate(-v12, c4);
        c6 = v03.Estimate(-v13, c6);

        v10 = Permute(d0, d2, 2, 2, 0, 1).XWZX();
        v11 = Permute(d0, d2, 0, 3, 0, 1).WXYZ();
        v12 = Permute(d1, d2, 2, 2, 2, 3).XWZX();
        v13 = Permute(d1, d2, 0, 3, 2, 3).WXYZ();

        v00 = y.WXWX();
        v01 = x.YWXZ();
        v02 = w.WXWX();
        v03 = z.YWXZ();

        v00 *= v10;
        v01 *= v11;
        v02 *= v12;
        v03 *= v13;

        c1 = c0 - v00; c0 += v00;
        c3 = c2 + v01; c2 -= v01;
        c5 = c4 - v02; c4 += v02;
        c7 = c6 + v03; c6 -= v03;

        c0 = Permute(c0, c1, 0, 2, 1, 3).XZYW();
        c2 = Permute(c2, c3, 0, 2, 1, 3).XZYW();
        c4 = Permute(c4, c5, 0, 2, 1, 3).XZYW();
        c6 = Permute(c6, c7, 0, 2, 1, 3).XZYW();

        T det = Vec4.Dot(c0, x);

        T eps = typeof(T) == typeof(float) ? T.CreateTruncating(float.Epsilon) : T.CreateTruncating(double.Epsilon);

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
