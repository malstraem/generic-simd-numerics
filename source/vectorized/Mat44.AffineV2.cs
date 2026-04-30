namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007, IDE0047

// call in right cases
// this version combines 128 and 256 ways into one
public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    internal static unsafe Mat44<T> AffineV2<T>(Quat<T> r, Vec3<T>* s, Vec3<T>* t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        var tp = (T*)t; var sp = (T*)s;

        var m = RotationV2(r);

        m.X *= *sp;
        m.Y *= *(sp + 1);
        m.Z *= *(sp + 2);

        // todo
        m.W = SizeOf<T>() == 4
            ? Vector128<T>.One.AsDouble().WithElement(0, *(double*)tp).As<double, T>().WithElement(2, *(tp + 2)).Vec4()
            : Vector256<T>.One.WithElement(0, *tp).WithElement(1, *(tp + 1)).WithElement(2, *(tp + 2)).Vec4();

        return m;
    }

    [MethodImpl(AggressiveInlining)]
    internal static Mat44<T> RotationV2<T>(Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        var w = r.Vec4();

        var z = w.Permute(2, 0, 1, 3);                 // z,  x,  y,  w
        var x = w.Permute(1, 2, 0, 3).MultiplyWise(w); // xy, yz, xz, ww
        var y = w.Permute(3, 3, 3, 3).MultiplyWise(z); // xx, yy, zz, ww

        w = w.MultiplyWise(w);                         // xx, yy, zz, ww

        var n = x + y; // xy + zw    | yz + xw    | xz + yw    | 2ww, no mean
            z = x - y; // xy - zw    | yz - xw    | xz - yw    | 0

        n += n;        // 2(xy + zw) | 2(yz + xw) | 2(xz + yw) | 4ww, no mean
        z += z;        // 2(xy - zw) | 2(yz - xw) | 2(xz - yw) | 0

        w += w.Permute(1, 2, 0, 3); // xx + yy    | yy + zz    | zz + xx   | 4ww, no mean
        
        w = SizeOf<T>() == 4        // 1 - 2(xx + yy) | 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 4ww, no mean
            ? Vector128<T>.One.Vec4() - (w + w)
            : Vector256<T>.One.Vec4() - (w + w);
        // Vec4<T>.One provokes unnecessary transfers currently

        Mat44<T> m;

        m.X = z.Insert(0, 1, w).Insert(1, 0, n); // 1 - 2(yy + zz) | 2(xy + zw)     | 2(xz - yw)     | 0
        m.Y = z.Insert(1, 2, w).Insert(2, 1, n); // 2(xy - zw)     | 1 - 2(zz + xx) | 2(yz + xw)     | 0
        m.Z = z.Insert(0, 2, n).Insert(2, 0, w); // 2(xz + yw)     | 2(yz - xw)     | 1 - 2(xx + yy) | 0

        m.W = SizeOf<T>() == 4
            ? Vec4<T>.UnitW.As128().Vec4()
            : Vec4<T>.UnitW.As256().Vec4();
        // bitcast eliminates unnecessary transfers
        return m;
    }
}
