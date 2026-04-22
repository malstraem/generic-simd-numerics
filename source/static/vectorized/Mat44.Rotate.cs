namespace System.Numerics;

public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    internal static unsafe Mat44<T> Rotate128F<T>(Quat<T> r, Mat44<T> m)
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

        x *= w; // yx, zy, xz, ww
        y *= z; // zw, xw, yw, ww
        w *= w; // xx, yy, zz, ww

        var n = x + y; // yx + zw, zy + xw, xz + yw, 2ww
        z = x - y; // yx - zw, zy - xw, xz - yw, 0

        w += w.Permute32(1, 2, 0, 3); // xx + yy, yy + zz, zz + xx, 2ww

        n += n; // 2(yx + zw), 2(zy + xw), 2(xz + yw), 4ww
        z += z; // 2(yx - zw), 2(zy - xw), 2(xz - yw), 0
        w += w; // 2(xx + yy), 2(yy + zz), 2(zz + xx), 4ww
        w = -w;
        w += Vector128<T>.One; // 1 - 2(xx + yy), 1 - 2(yy + zz), 1 - 2(zz + xx), 1 - 4ww

        x = z.WithElement(0, w[1]).WithElement(1, n[0]); // 1 - 2(yy + zz), 2(yx + zw)    , 2(xz - yw)    , 0
        y = z.WithElement(1, w[2]).WithElement(2, n[1]); // 2(yx - zw)    , 1 - 2(zz + xx), 2(zy + xw)    , 0
        z = z.WithElement(0, n[2]).WithElement(2, w[0]); // 2(xz + yw)    , 2(zy - xw)    , 1 - 2(xx + yy), 0 

        Mat44<T> res;

        var xx = Vector128.Create(row1[0]) * x;
        xx = Vector128.Create(row1[1]).MultiplyAdd(y, xx);
        xx = Vector128.Create(row1[2]).MultiplyAdd(z, xx);

        var yy = Vector128.Create(row2[0]) * x;
        yy = Vector128.Create(row2[1]).MultiplyAdd(y, yy);
        yy = Vector128.Create(row2[2]).MultiplyAdd(z, yy);

        var zz = Vector128.Create(row3[0]) * x;
        zz = Vector128.Create(row3[1]).MultiplyAdd(y, zz);
        zz = Vector128.Create(row3[2]).MultiplyAdd(z, zz);

        var ww = Vector128.Create(row4[0]) * x;
        ww = Vector128.Create(row4[1]).MultiplyAdd(y, ww);
        ww = Vector128.Create(row4[2]).MultiplyAdd(z, ww);

        xx.WithElement(3, row1[3]).Store((T*)&res);
        yy.WithElement(3, row2[3]).Store(&res.Y.X);
        zz.WithElement(3, row3[3]).Store(&res.Z.X);
        ww.WithElement(3, row4[3]).Store(&res.W.X);

        //xx.WithElement(3, *(ptr + 3)).Store((T*)&m);
        //yy.WithElement(3, *(ptr + 7)).Store(&m.Y.X);
        //zz.WithElement(3, *(ptr + 11)).Store(&m.Z.X);
        //ww.WithElement(3, *(ptr + 15)).Store(&m.W.X);

        return res;
    }
}
