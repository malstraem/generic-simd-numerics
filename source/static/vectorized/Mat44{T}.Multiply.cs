namespace System.Numerics;

// called in right cases
// result is quite good, but asm could be lighter
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

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Multiply128(Mat44<T> a, Mat44<T> b)
    {
        var x = b.X.As128();
        var y = b.Y.As128();
        var z = b.Z.As128();
        var w = b.W.As128();

        unsafe
        {
            a.X.Broadcast128(out var b0, out var b1, out var b2, out var b3);
            Accumulate(&b.X.X, x, y, z, w, b0, b1, b2, b3);

            a.Y.Broadcast128(out b0, out b1, out b2, out b3);
            Accumulate(&b.Y.X, x, y, z, w, b0, b1, b2, b3);

            a.Z.Broadcast128(out b0, out b1, out b2, out b3);
            Accumulate(&b.Z.X, x, y, z, w, b0, b1, b2, b3);

            a.W.Broadcast128(out b0, out b1, out b2, out b3);
            Accumulate(&b.W.X, x, y, z, w, b0, b1, b2, b3);
        }
        return b;
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Multiply256(Mat44<T> a, Mat44<T> b)
    {
        var x = b.X.As256();
        var y = b.Y.As256();
        var z = b.Z.As256();
        var w = b.W.As256();

        unsafe
        {
            a.X.Broadcast256(out var b0, out var b1, out var b2, out var b3);
            Accumulate(&b.X.X, x, y, z, w, b0, b1, b2, b3);

            a.Y.Broadcast256(out b0, out b1, out b2, out b3);
            Accumulate(&b.Y.X, x, y, z, w, b0, b1, b2, b3);

            a.Z.Broadcast256(out b0, out b1, out b2, out b3);
            Accumulate(&b.Z.X, x, y, z, w, b0, b1, b2, b3);

            a.W.Broadcast256(out b0, out b1, out b2, out b3);
            Accumulate(&b.W.X, x, y, z, w, b0, b1, b2, b3);
        }
        return b;
    }
}
