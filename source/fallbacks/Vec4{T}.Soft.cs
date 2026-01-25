namespace System.Numerics;

public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftAdd(Vec4<T> left, Vec4<T> right) => new
    (
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W
    );

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftSubstract(Vec4<T> left, Vec4<T> right) => new
    (
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W
    );

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftMultiply(Vec4<T> left, Vec4<T> right) => new
    (
        left.X * right.X,
        left.Y * right.Y,
        left.Z * right.Z,
        left.W * right.W
    );

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftDivide(Vec4<T> left, Vec4<T> right) => new
    (
        left.X / right.X,
        left.Y / right.Y,
        left.Z / right.Z,
        left.W / right.W
    );

    [MethodImpl(AggressiveInlining)]
    private static bool SoftEqual(Vec4<T> left, Vec4<T> right) => left.X == right.X
                                                               && left.Y == right.Y
                                                               && left.Z == right.Z
                                                               && left.W == right.W;

    [MethodImpl(AggressiveInlining)]
    private static bool SoftNotEqual(Vec4<T> left, Vec4<T> right) => left.X != right.X
                                                                  && left.Y != right.Y
                                                                  && left.Z != right.Z
                                                                  && left.W != right.W;

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftMin(Vec4<T> left, Vec4<T> right) => new
    (
        T.Min(left.X, right.X),
        T.Min(left.Y, right.Y),
        T.Min(left.Z, right.Z),
        T.Min(left.W, right.W)
    );

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftMax(Vec4<T> left, Vec4<T> right) => new
    (
        T.Max(left.X, right.X),
        T.Max(left.Y, right.Y),
        T.Max(left.Z, right.Z),
        T.Max(left.W, right.W)
    );
}
