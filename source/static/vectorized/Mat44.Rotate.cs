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
            w = r.As128(); // x, y, z, w

        var x = w.Permute32(1, 2, 0, 3); // y, z, x, w
        var y = w.Permute32(3, 3, 3, 3); // w, w, w, w
        var z = w.Permute32(2, 0, 1, 3); // z, x, y, w

        x *= w; // xy, yz, zx, ww
        y *= z; // zw, xw, yw, ww
        w *= w; // xx, yy, zz, ww

        var n = x + y; // yx + zw        | zy + xw        | xz + yw        | 2ww, no mean
            z = x - y; // yx - zw        | zy - xw        | xz - yw        | 0

        n += n;        // 2(xy + zw)     | 2(yz + xw)     | 2(zx + yw)     | 4ww, no mean
        z += z;        // 2(xy - zw)     | 2(yz - xw)     | 2(zx - yw)     | 0

        w += w.Permute32(1, 2, 0, 3);   // xx + yy        | yy + zz        | zz + xx        | 4ww, no mean
        w = Vector128<T>.One - (w + w); // 1 - 2(xx + yy) | 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 4ww, no mean

        x = z.WithElement(0, w[1]).WithElement(1, n[0]); // 1 - 2(yy + zz) | 2(yx + zw)     | 2(xz - yw)     | 0
        y = z.WithElement(1, w[2]).WithElement(2, n[1]); // 2(yx - zw)     | 1 - 2(zz + xx) | 2(zy + xw)     | 0
        z = z.WithElement(0, n[2]).WithElement(2, w[0]); // 2(xz + yw)     | 2(zy - xw)     | 1 - 2(xx + yy) | 0

        var xx = x * row1[0];
        var yy = x * row2[0];
        var zz = x * row3[0];
        var ww = x * row4[0];

        xx = Vector128.Create(row1[1]).MultiplyAdd(y, xx);
        xx = Vector128.Create(row1[2]).MultiplyAdd(z, xx);

        yy = Vector128.Create(row2[1]).MultiplyAdd(y, yy);
        yy = Vector128.Create(row2[2]).MultiplyAdd(z, yy);

        zz = Vector128.Create(row3[1]).MultiplyAdd(y, zz);
        zz = Vector128.Create(row3[2]).MultiplyAdd(z, zz);

        ww = Vector128.Create(row4[1]).MultiplyAdd(y, ww);
        ww = Vector128.Create(row4[2]).MultiplyAdd(z, ww);

        //xx = (z * row1[2]) + xx;
        //xx = (y * row1[1]) + xx;

        //yy = (z * row2[2]) + yy;
        //yy = (y * row2[1]) + yy;

        //zz = (z * row3[2]) + zz;
        //zz = (y * row3[1]) + zz;

        //ww = (z * row4[2]) + ww;
        //ww = (y * row4[1]) + ww;

        xx.WithElement(3, row1[3]).Store((T*)&m);
        yy.WithElement(3, row2[3]).Store(&m.Y.X);
        zz.WithElement(3, row3[3]).Store(&m.Z.X);
        ww.WithElement(3, row4[3]).Store(&m.W.X);

        return m;
    }
}
