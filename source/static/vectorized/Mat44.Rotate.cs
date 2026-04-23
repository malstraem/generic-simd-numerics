namespace System.Numerics;

public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    internal static unsafe Mat44<T> Rotate128F<T>(Mat44<T> m, Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Vector128<T>
            row1 = m.X.As128(),
            row2 = m.Y.As128(),
            row3 = m.Z.As128(),
            row4 = m.W.As128(),
            z = r.As128(); // x, y, z, w

        var x = z.Permute32(1, 2, 0, 3); // y, z, x, w
        var y = z.Permute32(3, 3, 3, 3); // w, w, w, w
        var k = z.Permute32(2, 0, 1, 3); // z, x, y, w

        var w = x * x; // yy, zz, xx, ww
        x *= z; // yx, zy, xz, ww
        y *= k; // zw, xw, yw, ww

        var n = x + y; // yx + zw, zy + xw, xz + yw, 2ww
        k = x - y; // yx - zw, zy - xw, xz - yw, 0

        n = n.Permute32(2, 0, 1, 3);
        w += w.Permute32(1, 2, 0, 3); // yy + zz, zz + xx, xx + yy, 2ww

        n += n; // 2(xz + yw), 2(yx + zw), 2(zy + xw), 4ww
        k += k; // 2(yx - zw), 2(zy - xw), 2(xz - yw), 0
        w += w; // 2(yy + zz), 2(zz + xx), 2(xx + yy), 4ww
        w = -w;
        w += Vector128<T>.One; // 1 - 2(yy + zz), 1 - 2(zz + xx), 1 - 2(xx + yy), 1 - 4ww

        x = row1 * w;
        x = row1.Permute32(1, 2, 0, 3).MultiplyAdd(k, x);
        x = row1.Permute32(2, 0, 1, 3).MultiplyAdd(n, x);

        y = row2 * w;
        y = row2.Permute32(1, 2, 0, 3).MultiplyAdd(k, y);
        y = row2.Permute32(2, 0, 1, 3).MultiplyAdd(n, y);

        z = row3 * w;
        z = row3.Permute32(1, 2, 0, 3).MultiplyAdd(k, z);
        z = row3.Permute32(2, 0, 1, 3).MultiplyAdd(n, z);

        w = row4 * w;
        w = row4.Permute32(1, 2, 0, 3).MultiplyAdd(k, w);
        w = row4.Permute32(2, 0, 1, 3).MultiplyAdd(n, w);

        x.WithElement(3, row1[3]).Store((T*)&m);
        y.WithElement(3, row2[3]).Store(&m.Y.X);
        z.WithElement(3, row3[3]).Store(&m.Z.X);
        w.WithElement(3, row4[3]).Store(&m.W.X);

        return m;
    }
}
