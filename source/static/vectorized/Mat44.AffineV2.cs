namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007, IDE0047

public static partial class Mat44
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    internal static unsafe Mat44<T> Affine128FV2<T>(Quat<T> r, Vec3<T>* s, Vec3<T>* t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        var m = Rotation128F(r);

        var tp = (T*)t; var sp = (T*)s;

        m.X *= *sp; // s->X is bad, idk why :(
        m.Y *= *(sp + 1);
        m.Z *= *(sp + 2);
        m.W = Vector128<T>.One.AsDouble().WithElement(0, *(double*)tp).As<double, T>().WithElement(2, *(tp + 2)).Vec4();

        // this is not recognized by JIT to produce vmovsd
        // m.W = Vector128<T>.One.WithElement(0, *tp).WithElement(1, *(tp + 1)).WithElement(2, *(tp + 2));

        return m;
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    internal static unsafe Mat44<T> Affine256DV2<T>(Quat<T> r, Vec3<T>* s, Vec3<T>* t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        var m = Rotation256D(r);

        var tp = (T*)t; var sp = (T*)s;

        m.X *= *sp;
        m.Y *= *(sp + 1);
        m.Z *= *(sp + 2);
        m.W = Vector256<T>.One.WithElement(0, *tp).WithElement(1, *(tp + 1)).WithElement(2, *(tp + 2)).Vec4();

        return m;
    }
}
