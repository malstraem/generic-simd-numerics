namespace System.Numerics;

public partial struct Mat44<T>
{
    // need lilbit less asm
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> MultiplySize4(Mat44<T> left, Mat44<T> right)
    {
        var x = right.X.As128();
        var y = right.Y.As128();
        var z = right.Z.As128();
        var w = right.W.As128();

        unsafe
        {
            Broadcast128(left.X, out var b0, out var b1, out var b2, out var b3);
            Accumulate(&right.X.X, x, y, z, w, b0, b1, b2, b3);

            Broadcast128(left.Y, out b0, out b1, out b2, out b3);
            Accumulate(&right.Y.X, x, y, z, w, b0, b1, b2, b3);

            Broadcast128(left.Z, out b0, out b1, out b2, out b3);
            Accumulate(&right.Z.X, x, y, z, w, b0, b1, b2, b3);

            Broadcast128(left.W, out b0, out b1, out b2, out b3);
            Accumulate(&right.W.X, x, y, z, w, b0, b1, b2, b3);
        }
        return right;
    }
}
