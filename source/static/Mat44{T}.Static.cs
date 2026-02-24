namespace System.Numerics;

public partial struct Mat44<T>
{
    // something smarter?
    // Shuffle<T> & Permute<T> for transposed multiply?

    // this is totally pessimistic of JIT, 4 transforms are now better
    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> MultiplySize2(Mat44<T> left, Mat44<T> right)
    {
        var mul = Vector256.Create(
                    Vector128.Create((right.X * left.X.X).As64(), (right.X * left.Y.X).As64()),
                    Vector128.Create((right.X * left.Z.X).As64(), (right.X * left.W.X).As64()));

        var a1 = Vector256.Create(
                    Vector128.Create(Vector64.Create(left.X.Y), Vector64.Create(left.Y.Y)),
                    Vector128.Create(Vector64.Create(left.Z.Y), Vector64.Create(left.W.Y)));

        var a2 = Vector256.Create(
                    Vector128.Create(Vector64.Create(left.X.Z), Vector64.Create(left.Y.Z)),
                    Vector128.Create(Vector64.Create(left.Z.Z), Vector64.Create(left.W.Z)));

        var a3 = Vector256.Create(
                    Vector128.Create(Vector64.Create(left.X.W), Vector64.Create(left.Y.W)),
                    Vector128.Create(Vector64.Create(left.Z.W), Vector64.Create(left.W.W)));

        mul += Vector256.Create(right.Y.As64()) * a1;
        mul += Vector256.Create(right.Z.As64()) * a2;
        mul += Vector256.Create(right.W.As64()) * a3;

        return From256(mul);
    }

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> MultiplySize4(Mat44<T> left, Mat44<T> right)
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

        return From512(mul);
    }
}
