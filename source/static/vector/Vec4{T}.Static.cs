namespace System.Numerics;

public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add(Vec4<T> left, Vec4<T> right) => left + right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Subtract(Vec4<T> left, Vec4<T> right) => left - right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply(Vec4<T> vec, T num) => vec * num;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide(Vec4<T> vec, T num) => vec / num;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply(Vec4<T> left, Vec4<T> right) => left * right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide(Vec4<T> left, Vec4<T> right) => left / right;

    [MethodImpl(AggressiveInlining)]
    public static T Sum(Vec4<T> vec) => vec.Sum();

    [MethodImpl(AggressiveInlining)]
    public static T Dot(Vec4<T> left, Vec4<T> right) => left.Dot(right);

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared(Vec4<T> vec) => vec.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared(Vec4<T> left, Vec4<T> right) => left.DistanceSquared(right);

    [MethodImpl(AggressiveInlining)]
    public static T Length<R>(Vec4<T> vec)
        where R : IRootFunctions<R>
            => vec.Length<R>();

    [MethodImpl(AggressiveInlining)]
    public static T Distance<R>(Vec4<T> left, Vec4<T> right)
        where R : IRootFunctions<R>
            => left.Distance<R>(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Normalize<R>(Vec4<T> vec)
        where R : IRootFunctions<R>
            => vec.Normalize<R>();

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> SquareRoot<R>(Vec4<T> vec)
        where R : IRootFunctions<R>
            => vec.SquareRoot<R>();

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Abs(Vec4<T> vec) => vec.Abs();

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Min(Vec4<T> left, Vec4<T> right) => left.Min(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Max(Vec4<T> left, Vec4<T> right) => left.Max(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Clamp(Vec4<T> vec, Vec4<T> min, Vec4<T> max) => vec.Clamp(min, max);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Lerp(Vec4<T> left, Vec4<T> right, T amount) => left.Lerp(right, amount);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Transform(Vec4<T> vec, Mat44<T> mat) => vec.Transform(mat);
}
