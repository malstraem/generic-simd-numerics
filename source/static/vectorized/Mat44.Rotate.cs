namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007, IDE0047

public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    internal static Mat44<T> Rotate128F<T>(Mat44<T> m, Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Vector128<T> mx = m.X.As128(), my = m.Y.As128(),
                     mz = m.Z.As128(), mw = m.W.As128(),

        z = r.As128(),               // x, y, z, w

        x = z.Permute32(1, 2, 0, 3), // y, z, x, w
        y = z.Permute32(3, 3, 3, 3), // w, w, w, w
        k = z.Permute32(2, 0, 1, 3), // z, x, y, w
        w = x * x;                   // yy, zz, xx, ww

        x *= z; // yx, zy, xz, ww
        y *= k; // zw, xw, yw, ww

        var n = x + y; // yx + zw, zy + xw, xz + yw, 2ww
            k = x - y; // yx - zw, zy - xw, xz - yw, 0

        n = n.Permute32(2, 0, 1, 3);
        w += w.Permute32(1, 2, 0, 3);   // yy + zz        | zz + xx        | xx + yy        | 2ww, no mean

        n += n;                         // 2(xz + yw)     | 2(yx + zw)     | 2(zy + xw)     | 4ww, no mean
        k += k;                         // 2(yx - zw)     | 2(zy - xw)     | 2(xz - yw)     | 0
        w = Vector128<T>.One - (w + w); // 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 2(xx + yy) | 1 - 4ww, no mean

        x = mx * w;
        x = mx.Permute32(1, 2, 0, 3).MultiplyAdd(k, x);
        x = mx.Permute32(2, 0, 1, 3).MultiplyAdd(n, x);

        y = my * w;
        y = my.Permute32(1, 2, 0, 3).MultiplyAdd(k, y);
        y = my.Permute32(2, 0, 1, 3).MultiplyAdd(n, y);

        z = mz * w;
        z = mz.Permute32(1, 2, 0, 3).MultiplyAdd(k, z);
        z = mz.Permute32(2, 0, 1, 3).MultiplyAdd(n, z);

        w = mw * w;
        w = mw.Permute32(1, 2, 0, 3).MultiplyAdd(k, w);
        w = mw.Permute32(2, 0, 1, 3).MultiplyAdd(n, w);

        m.X = x.WithElement(3, mx[3]).Vec4();
        m.Y = y.WithElement(3, my[3]).Vec4();
        m.Z = z.WithElement(3, mz[3]).Vec4();
        m.W = w.WithElement(3, mw[3]).Vec4();

        return m;
    }
}
