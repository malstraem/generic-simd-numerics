namespace System.Numerics;

public partial struct Mat44<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Accumulate(
        T* dst,
        Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w,
        Vector128<T> b0, Vector128<T> b1, Vector128<T> b2, Vector128<T> b3)
            => (x.MultiplyAdd(b0, y * b1) + z.MultiplyAdd(b2, w * b3)).Store(dst);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Accumulate(
        T* dst,
        Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w,
        Vector256<T> b0, Vector256<T> b1, Vector256<T> b2, Vector256<T> b3)
            => (x.MultiplyAdd(b0, y * b1) + z.MultiplyAdd(b2, w * b3)).Store(dst);
}
