using static System.Runtime.Intrinsics.X86.Fma;

namespace System.Numerics;

public partial struct Mat44<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Broadcast(Vec4<T> row,
        out Vector128<T> b0, out Vector128<T> b1, out Vector128<T> b2, out Vector128<T> b3)
    {
        var xmm = row.As128();

        b0 = Vector128.Create(*(T*)&xmm);
        b1 = Vector128.Create(*((T*)&xmm + 1));
        b2 = Vector128.Create(*((T*)&xmm + 2));
        b3 = Vector128.Create(*((T*)&xmm + 3));
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Accumulate(
        Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w,
        Vector128<T> b0, Vector128<T> b1, Vector128<T> b2, Vector128<T> b3,
        T* dst)
    {
        y *= b1; w *= b3;

        // Vector128.MultiplyAdd<T> should exist
        if (typeof(T) == typeof(float) && IsSupported)
        {
            x = (MultiplyAdd(x.AsSingle(), b0.AsSingle(), y.AsSingle())
               + MultiplyAdd(z.AsSingle(), b2.AsSingle(), w.AsSingle())).As<float, T>();
        }
        else
        {
            x = (x * b0) + y + (z * b2) + w;
        }
        Vector128.Store(x, dst);
    }

    // need little bit less asm
    // Shuffle<T>?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> MultiplySize4(Mat44<T> left, Mat44<T> right)
    {
        var x = right.X.As128();
        var y = right.Y.As128();
        var z = right.Z.As128();
        var w = right.W.As128();

        unsafe
        {
            Broadcast(left.X, out Vector128<T> b0, out var b1, out var b2, out var b3);
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
