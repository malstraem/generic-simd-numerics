using System.Runtime.CompilerServices;

namespace System.Numerics;

public partial struct Vec4<T>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool IsNotHardware() => !(typeof(T) == typeof(double) || typeof(T) == typeof(float));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftPlus(Vec4<T> vec) => new(+vec.X, +vec.Y, +vec.Z, +vec.W);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftNegate(Vec4<T> vec) => new(-vec.X, -vec.Y, -vec.Z, -vec.W);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftAdd(Vec4<T> vec, T value) => new
    (
        vec.X + value,
        vec.Y + value,
        vec.Z + value,
        vec.W + value
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftAdd(Vec4<T> left, Vec4<T> right) => new
    (
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftSubtract(Vec4<T> vec, T value) => new
    (
        vec.X - value,
        vec.Y - value,
        vec.Z - value,
        vec.W - value
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftSubtract(Vec4<T> left, Vec4<T> right) => new
    (
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftMultiply(Vec4<T> vec, T value) => new
    (
        vec.X * value,
        vec.Y * value,
        vec.Z * value,
        vec.W * value
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftMultiply(Vec4<T> left, Vec4<T> right) => new
    (
        left.X * right.X,
        left.Y * right.Y,
        left.Z * right.Z,
        left.W * right.W
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftDivide(Vec4<T> vec, T value) => new
    (
        vec.X / value,
        vec.Y / value,
        vec.Z / value,
        vec.W / value
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftDivide(Vec4<T> left, Vec4<T> right) => new
    (
        left.X / right.X,
        left.Y / right.Y,
        left.Z / right.Z,
        left.W / right.W
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool SoftEqual(Vec4<T> left, Vec4<T> right) => left.X == right.X
                                                               && left.Y == right.Y
                                                               && left.Z == right.Z
                                                               && left.W == right.W;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool SoftNotEqual(Vec4<T> left, Vec4<T> right) => left.X != right.X
                                                                  && left.Y != right.Y
                                                                  && left.Z != right.Z
                                                                  && left.W != right.W;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vec4<T> SoftAbs(Vec4<T> vec) => new(T.Abs(vec.X), T.Abs(vec.Y), T.Abs(vec.Z), T.Abs(vec.W));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static T SoftSum(Vec4<T> vec) => vec.X + vec.Y + vec.Z + vec.W;
}
