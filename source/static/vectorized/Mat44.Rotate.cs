namespace System.Numerics;

public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    internal static unsafe Mat44<T> Rotate128F<T>(Quat<T> r, Mat44<T>* m)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> res;

        var ptr = (T*)m;

        var w = r.As128(); // x, y, z, w

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

        var row = Vector128.Create(*ptr) * x;
        row = Vector128.Create(*(ptr + 1)).MultiplyAdd(y, row);
        row = Vector128.Create(*(ptr + 2)).MultiplyAdd(z, row);

        row.WithElement(3, *(ptr + 3)).Store((T*)&res);

        row = Vector128.Create(*(ptr + 4)) * x;
        row = Vector128.Create(*(ptr + 5)).MultiplyAdd(y, row);
        row = Vector128.Create(*(ptr + 6)).MultiplyAdd(z, row);

        row.WithElement(3, *(ptr + 7)).Store((T*)&res.Y);

        row = Vector128.Create(*(ptr + 8)) * x;
        row = Vector128.Create(*(ptr + 9)).MultiplyAdd(y, row);
        row = Vector128.Create(*(ptr + 10)).MultiplyAdd(z, row);

        row.WithElement(3, *(ptr + 11)).Store((T*)&res.Z);

        row = Vector128.Create(*(ptr + 12)) * x;
        row = Vector128.Create(*(ptr + 13)).MultiplyAdd(y, row);
        row = Vector128.Create(*(ptr + 14)).MultiplyAdd(z, row);

        row.WithElement(3, *(ptr + 15)).Store((T*)&res.W);

        return res;
    }
}
