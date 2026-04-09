namespace System.Numerics;

public partial struct Quat<T>
{
    [MethodImpl(AggressiveInlining)]
    private readonly Vec4<T> Vec4() => BitCast<Quat<T>, Vec4<T>>(this);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Broadcast128F(Quat<T> row,
        out Vector128<float> b0, out Vector128<float> b1, out Vector128<float> b2, out Vector128<float> b3)
    {
        var xmm = row.As128F();

        b0 = Vector128.Create(*(float*)&xmm);
        b1 = Vector128.Create(*((float*)&xmm + 1));
        b2 = Vector128.Create(*((float*)&xmm + 2));
        b3 = Vector128.Create(*((float*)&xmm + 3));
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Broadcast256D(Quat<T> row,
        out Vector256<double> b0, out Vector256<double> b1, out Vector256<double> b2, out Vector256<double> b3)
    {
        b0 = Vector256.Create(row.X).AsDouble();
        b1 = Vector256.Create(row.Y).AsDouble();
        b2 = Vector256.Create(row.Z).AsDouble();
        b3 = Vector256.Create(row.W).AsDouble();

        /*var xmm = row.As256D();

        b0 = Vector256.Create(*(double*)&xmm);
        b1 = Vector256.Create(*((double*)&xmm + 1));
        b2 = Vector256.Create(*((double*)&xmm + 2));
        b3 = Vector256.Create(*((double*)&xmm + 3));*/
    }

    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<float> As128F() => BitCast<Quat<T>, Vector128<float>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector256<double> As256D() => BitCast<Quat<T>, Vector256<double>>(this);
}
