namespace System.Numerics;

public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftPlus(Vec4<T> vec) => new(+vec.X, +vec.Y, +vec.Z, +vec.W);

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftNegate(Vec4<T> vec) => new(-vec.X, -vec.Y, -vec.Z, -vec.W);

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftAdd(Vec4<T> vec, T value) => new
    (
        vec.X + value,
        vec.Y + value,
        vec.Z + value,
        vec.W + value
    );

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftAdd(Vec4<T> left, Vec4<T> right) => new
    (
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W
    );

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftSubtract(Vec4<T> vec, T value) => new
    (
        vec.X - value,
        vec.Y - value,
        vec.Z - value,
        vec.W - value
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
    private static Vec4<T> SoftMultiply(Vec4<T> vec, T value) => new
    (
        vec.X * value,
        vec.Y * value,
        vec.Z * value,
        vec.W * value
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
    private static Vec4<T> SoftDivide(Vec4<T> vec, T value) => new
    (
        vec.X / value,
        vec.Y / value,
        vec.Z / value,
        vec.W / value
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
    private static T SoftSum(Vec4<T> vec) => vec.X + vec.Y + vec.Z + vec.W;

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> SoftAbs(Vec4<T> vec) => new(T.Abs(vec.X), T.Abs(vec.Y), T.Abs(vec.Z), T.Abs(vec.W));

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

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> SoftClamp(Vec4<T> vec, Vec4<T> min, Vec4<T> max) => max.Min(vec.Max(min));

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> SoftLerp(Vec4<T> left, Vec4<T> right, T amount) => (left * (T.One - amount)) + (right * amount);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> SoftMultiplyAdd(Vec4<T> left, Vec4<T> right, Vec4<T> add) => (left * right) + add;
}
