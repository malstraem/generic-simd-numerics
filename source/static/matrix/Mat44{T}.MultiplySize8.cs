using static System.Runtime.Intrinsics.X86.Fma;

namespace System.Numerics;

public partial struct Mat44<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Broadcast(Vec4<T> row,
        out Vector256<T> b0, out Vector256<T> b1, out Vector256<T> b2, out Vector256<T> b3)
    {
        /*var ymm = row.As256();

        b0 = Vector256.Create(*(T*)&ymm);
        b1 = Vector256.Create(*((T*)&ymm + 1));
        b2 = Vector256.Create(*((T*)&ymm + 2));
        b3 = Vector256.Create(*((T*)&ymm + 3));*/

        b0 = Vector256.Create(*(T*)&row);
        b1 = Vector256.Create(*((T*)&row + 1));
        b2 = Vector256.Create(*((T*)&row + 2));
        b3 = Vector256.Create(*((T*)&row + 3));

        // take offset from ymm -> pessimized, investigate :(
        // now JIT produce 16 scalar movs to xmm and it's better on 7800x
        // 128 bit version works as expected
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Accumulate(
        Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w,
        Vector256<T> b0, Vector256<T> b1, Vector256<T> b2, Vector256<T> b3,
        T* dst)
    {
        y *= b1; w *= b3;

        // Vector256.MultiplyAdd<T> exist
        if (typeof(T) == typeof(double) && IsSupported)
        {
            x = (MultiplyAdd(x.AsDouble(), b0.AsDouble(), y.AsDouble())
               + MultiplyAdd(z.AsDouble(), b2.AsDouble(), w.AsDouble())).As<double, T>();
        }
        else
        {
            x = (x * b0) + y + (z * b2) + w;
        }
        Vector256.Store(x, dst);
    }

    // need little bit less asm
    // Shuffle<T>?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> MultiplySize8(Mat44<T> left, Mat44<T> right)
    {
        var x = right.X.As256();
        var y = right.Y.As256();
        var z = right.Z.As256();
        var w = right.W.As256();

        unsafe
        {
            Broadcast(left.X, out Vector256<T> b0, out var b1, out var b2, out var b3);
            Accumulate(x, y, z, w, b0, b1, b2, b3, &right.X.X);

            Broadcast(left.Y, out b0, out b1, out b2, out b3);
            Accumulate(x, y, z, w, b0, b1, b2, b3, &right.Y.X);

            Broadcast(left.Z, out b0, out b1, out b2, out b3);
            Accumulate(x, y, z, w, b0, b1, b2, b3, &right.Z.X);

            Broadcast(left.W, out b0, out b1, out b2, out b3);
            Accumulate(x, y, z, w, b0, b1, b2, b3, &right.W.X);
        }
        return right;
    }
}
