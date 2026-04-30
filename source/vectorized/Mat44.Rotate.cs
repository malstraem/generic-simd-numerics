namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007, IDE0047

// call in right cases
public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    internal static Mat44<T> Rotate128<T>(Mat44<T> m, Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Vector128<T> mx = m.X.As128(), my = m.Y.As128(),
                     mz = m.Z.As128(), mw = m.W.As128(),

        z = r.As128(),               // x, y, z, w

        x = z.Permute32(1, 2, 0, 3), // y, z, x, w
        y = z.Permute32(3, 3, 3, 3), // w, w, w, w
        k = z.Permute32(2, 0, 1, 3), // z, x, y, w
        w = x * x;                   // yy, zz, xx, ww

        x *= z; // xy, yz, xz, ww
        y *= k; // zw, xw, yw, ww

        var n = x + y; // xy + zw, yz + xw, xz + yw, 2ww
            k = x - y; // xy - zw, yz - xw, xz - yw, 0

        n = n.Permute32(2, 0, 1, 3);
        w += w.Permute32(1, 2, 0, 3);   // yy + zz        | zz + xx        | xx + yy        | 2ww, no mean

        n += n;                         // 2(xz + yw)     | 2(xy + zw)     | 2(yz + xw)     | 4ww, no mean     || (q31, q12, q23
        k += k;                         // 2(xy - zw)     | 2(yz - xw)     | 2(xz - yw)     | 0                || (q21, q32, q13
        w = Vector128<T>.One - (w + w); // 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 2(xx + yy) | 1 - 4ww, no mean || (q11, q22, q33)

        x = mx * w;                                     // mx(x, y, z, w) * (q11, q22, q33, -)
        x = mx.Permute32(1, 2, 0, 3).MultiplyAdd(k, x); // mx(y, z, x, w) * (q21, q32, q13, -) + ...
        x = mx.Permute32(2, 0, 1, 3).MultiplyAdd(n, x); // mx(z, x, y, w) * (q31, q12, q23, -) + ...

        y = my * w;                                     // my(x, y, z, w) * (q11, q22, q33, -)
        y = my.Permute32(1, 2, 0, 3).MultiplyAdd(k, y); // my(y, z, x, w) * (q21, q32, q13, -) + ...
        y = my.Permute32(2, 0, 1, 3).MultiplyAdd(n, y); // my(z, x, y, w) * (q31, q12, q23, -) + ...

        z = mz * w;                                     // mz(x, y, z, w) * (q11, q22, q33, -)
        z = mz.Permute32(1, 2, 0, 3).MultiplyAdd(k, z); // mz(y, z, x, w) * (q21, q32, q13, -) + ...
        z = mz.Permute32(2, 0, 1, 3).MultiplyAdd(n, z); // mz(z, x, y, w) * (q31, q12, q23, -) + ...

        w = mw * w;                                     // mw(x, y, z, w) * (q11, q22, q33, -)
        w = mw.Permute32(1, 2, 0, 3).MultiplyAdd(k, w); // mw(y, z, x, w) * (q21, q32, q13, -) + ...
        w = mw.Permute32(2, 0, 1, 3).MultiplyAdd(n, w); // mw(z, x, y, w) * (q31, q12, q23, -) + ...

        m.X = x.WithElement(3, mx[3]).Vec4();
        m.Y = y.WithElement(3, my[3]).Vec4();
        m.Z = z.WithElement(3, mz[3]).Vec4();
        m.W = w.WithElement(3, mw[3]).Vec4();

        return m;
    }

    [MethodImpl(AggressiveInlining)]
    internal static Mat44<T> Rotate256<T>(Mat44<T> m, Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Vector256<T> mx = m.X.As256(), my = m.Y.As256(),
                     mz = m.Z.As256(), mw = m.W.As256(),

        z = r.As256(),               // x, y, z, w

        x = z.Permute64(1, 2, 0, 3), // y, z, x, w
        y = z.Permute64(3, 3, 3, 3), // w, w, w, w
        k = z.Permute64(2, 0, 1, 3), // z, x, y, w
        w = x * x;                   // yy, zz, xx, ww

        x *= z; // xy, yz, xz, ww
        y *= k; // zw, xw, yw, ww

        var n = x + y; // xy + zw, yz + xw, xz + yw, 2ww
            k = x - y; // xy - zw, yz - xw, xz - yw, 0

        n = n.Permute64(2, 0, 1, 3);
        w += w.Permute64(1, 2, 0, 3);   // yy + zz        | zz + xx        | xx + yy        | 2ww, no mean

        n += n;                         // 2(xz + yw)     | 2(xy + zw)     | 2(yz + xw)     | 4ww, no mean     || (q31, q12, q23
        k += k;                         // 2(xy - zw)     | 2(yz - xw)     | 2(xz - yw)     | 0                || (q21, q32, q13
        w = Vector256<T>.One - (w + w); // 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 2(xx + yy) | 1 - 4ww, no mean || (q11, q22, q33)

        x = mx * w;                                     // mx(x, y, z, w) * (q11, q22, q33, -)
        x = mx.Permute64(1, 2, 0, 3).MultiplyAdd(k, x); // mx(y, z, x, w) * (q21, q32, q13, -) + ...
        x = mx.Permute64(2, 0, 1, 3).MultiplyAdd(n, x); // mx(z, x, y, w) * (q31, q12, q23, -) + ...

        y = my * w;                                     // my(x, y, z, w) * (q11, q22, q33, -)
        y = my.Permute64(1, 2, 0, 3).MultiplyAdd(k, y); // my(y, z, x, w) * (q21, q32, q13, -) + ...
        y = my.Permute64(2, 0, 1, 3).MultiplyAdd(n, y); // my(z, x, y, w) * (q31, q12, q23, -) + ...

        z = mz * w;                                     // mz(x, y, z, w) * (q11, q22, q33, -)
        z = mz.Permute64(1, 2, 0, 3).MultiplyAdd(k, z); // mz(y, z, x, w) * (q21, q32, q13, -) + ...
        z = mz.Permute64(2, 0, 1, 3).MultiplyAdd(n, z); // mz(z, x, y, w) * (q31, q12, q23, -) + ...

        w = mw * w;                                     // mw(x, y, z, w) * (q11, q22, q33, -)
        w = mw.Permute64(1, 2, 0, 3).MultiplyAdd(k, w); // mw(y, z, x, w) * (q21, q32, q13, -) + ...
        w = mw.Permute64(2, 0, 1, 3).MultiplyAdd(n, w); // mw(z, x, y, w) * (q31, q12, q23, -) + ...

        m.X = x.WithElement(3, mx[3]).Vec4();
        m.Y = y.WithElement(3, my[3]).Vec4();
        m.Z = z.WithElement(3, mz[3]).Vec4();
        m.W = w.WithElement(3, mw[3]).Vec4();

        return m;
    }
}
