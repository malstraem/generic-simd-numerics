using System.Runtime.Intrinsics;

namespace System.Numerics;

public partial struct Mat44<T>
{
    // better naming?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> MultiplyFloat(Mat44<T> left, Mat44<T> right)
    {
        var mul = Vector512.Create(
                    Vector256.Create((right.X * left.X.X).As128(), (right.X * left.Y.X).As128()),
                    Vector256.Create((right.X * left.Z.X).As128(), (right.X * left.W.X).As128()));

        var a1 = Vector512.Create(
                    Vector256.Create(Vector128.Create(left.X.Y), Vector128.Create(left.Y.Y)),
                    Vector256.Create(Vector128.Create(left.Z.Y), Vector128.Create(left.W.Y)));

        var a2 = Vector512.Create(
                    Vector256.Create(Vector128.Create(left.X.Z), Vector128.Create(left.Y.Z)),
                    Vector256.Create(Vector128.Create(left.Z.Z), Vector128.Create(left.W.Z)));

        var a3 = Vector512.Create(
                    Vector256.Create(Vector128.Create(left.X.W), Vector128.Create(left.Y.W)),
                    Vector256.Create(Vector128.Create(left.Z.W), Vector128.Create(left.W.W)));

        mul += Vector512.Create(right.Y.As128()) * a1;
        mul += Vector512.Create(right.Z.As128()) * a2;
        mul += Vector512.Create(right.W.As128()) * a3;

        return Unsafe.BitCast<Vector512<T>, Mat44<T>>(mul);
    }
}
