namespace System.Numerics;

public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    internal static Mat44<T> Rotate128F<T>(Mat44<T> m, Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> res;

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

        var row = Vector128.Create(m.X.X).AsSingle() * x.AsSingle();
        row = Vector128.MultiplyAddEstimate(Vector128.Create(m.X.Y).AsSingle(), y.AsSingle(), row);
        row = Vector128.MultiplyAddEstimate(Vector128.Create(m.X.Z).AsSingle(), z.AsSingle(), row);

        unsafe { row.As<float, T>().WithElement(3, m.X.W).Store((T*)&res); }

        row = Vector128.Create(m.Y.X).AsSingle() * x.AsSingle();
        row = Vector128.MultiplyAddEstimate(Vector128.Create(m.Y.Y).AsSingle(), y.AsSingle(), row);
        row = Vector128.MultiplyAddEstimate(Vector128.Create(m.Y.Z).AsSingle(), z.AsSingle(), row);

        unsafe { row.As<float, T>().WithElement(3, m.Y.W).Store((T*)&res.Y); }

        row = Vector128.Create(m.Z.X).AsSingle() * x.AsSingle();
        row = Vector128.MultiplyAddEstimate(Vector128.Create(m.Z.Y).AsSingle(), y.AsSingle(), row);
        row = Vector128.MultiplyAddEstimate(Vector128.Create(m.Z.Z).AsSingle(), z.AsSingle(), row);

        unsafe { row.As<float, T>().WithElement(3, m.Z.W).Store((T*)&res.Z); }

        row = Vector128.Create(m.W.X).AsSingle() * x.AsSingle();
        row = Vector128.MultiplyAddEstimate(Vector128.Create(m.W.Y).AsSingle(), y.AsSingle(), row);
        row = Vector128.MultiplyAddEstimate(Vector128.Create(m.W.Z).AsSingle(), z.AsSingle(), row);

        unsafe { row.As<float, T>().WithElement(3, m.W.W).Store((T*)&res.W); }

        return res;
    }
}
