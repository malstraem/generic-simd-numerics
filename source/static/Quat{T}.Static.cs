namespace System.Numerics;

public partial struct Quat<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Broadcast256(Vec4<T> row,
        out Vector256<double> b0, out Vector256<double> b1, out Vector256<double> b2, out Vector256<double> b3)
    {
        var xmm = row.As256D();

        b0 = (Vector256.Create(*(double*)&xmm));
        b1 = (Vector256.Create(*((double*)&xmm + 1)));
        b2 = (Vector256.Create(*((double*)&xmm + 2)));
        b3 = (Vector256.Create(*((double*)&xmm + 3)));
    }
}
