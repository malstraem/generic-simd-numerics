using static System.Runtime.Intrinsics.X86.Avx;
using static System.Runtime.Intrinsics.X86.Fma;

namespace System.Numerics;

public partial struct Mat44<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Broadcast(Vector256<double> row,
        out Vector256<double> b0, out Vector256<double> b1, out Vector256<double> b2, out Vector256<double> b3)
    {
        b0 = BroadcastScalarToVector256((double*)&row);
        b1 = BroadcastScalarToVector256((double*)&row + 1);
        b2 = BroadcastScalarToVector256((double*)&row + 2);
        b3 = BroadcastScalarToVector256((double*)&row + 3);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Accumulate(
        Vector256<double> x, Vector256<double> y, Vector256<double> z, Vector256<double> w,
        Vector256<double> b0, Vector256<double> b1, Vector256<double> b2, Vector256<double> b3,
        double* dst)
        => Vector256.Store(MultiplyAdd(b1, y, b0 *= x) + MultiplyAdd(b3, w, b2 *= z), dst);

    // almost optimal double impl, but need more clear asm (and shuffle?)
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe Mat44<T> Multiply_F64_AVX_FMA_2(Mat44<T> left, Mat44<T> right)
    {
        var x = right.X.As256D();
        var y = right.Y.As256D();
        var z = right.Z.As256D();
        var w = right.W.As256D();

        Broadcast(left.X.As256D(), out var b0, out var b1, out var b2, out var b3);
        Accumulate(x, y, z, w, b0, b1, b2, b3, (double*)&right.X.X);

        Broadcast(left.Y.As256D(), out b0, out b1, out b2, out b3);
        Accumulate(x, y, z, w, b0, b1, b2, b3, (double*)&right.Y.X);

        Broadcast(left.Z.As256D(), out b0, out b1, out b2, out b3);
        Accumulate(x, y, z, w, b0, b1, b2, b3, (double*)&right.Z.X);

        Broadcast(left.W.As256D(), out b0, out b1, out b2, out b3);
        Accumulate(x, y, z, w, b0, b1, b2, b3, (double*)&right.W.X);

        return right;
    }
}
