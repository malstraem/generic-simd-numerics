namespace System.Numerics;

public partial struct Vec2<T>
{
    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Add(Vec2<T> left, Vec2<T> right) => left + right;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Subtract(Vec2<T> left, Vec2<T> right) => left - right;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Multiply(Vec2<T> vec, T num) => vec * num;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Divide(Vec2<T> vec, T num) => vec / num;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Multiply(Vec2<T> left, Vec2<T> right) => left * right;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Divide(Vec2<T> left, Vec2<T> right) => left / right;

    [MethodImpl(AggressiveInlining)]
    public static T Sum(Vec2<T> vec) => vec.Sum();

    [MethodImpl(AggressiveInlining)]
    public static T Dot(Vec2<T> left, Vec2<T> right) => left.Dot(right);

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared(Vec2<T> vec) => vec.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared(Vec2<T> left, Vec2<T> right) => left.DistanceSquared(right);

    [MethodImpl(AggressiveInlining)]
    public static T Length<R>(Vec2<T> vec)
        where R : IRootFunctions<R>
            => vec.Length<R>();

    [MethodImpl(AggressiveInlining)]
    public static T Distance<R>(Vec2<T> left, Vec2<T> right)
        where R : IRootFunctions<R>
            => left.Distance<R>(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Normalize<R>(Vec2<T> vec)
        where R : IRootFunctions<R>
            => vec.Normalize<R>();

    public static Vec2<T> SquareRoot<R>(Vec2<T> vec)
        where R : IRootFunctions<R>
            => vec.SquareRoot<R>();

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Abs(Vec2<T> vec) => vec.Abs();

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Min(Vec2<T> left, Vec2<T> right) => left.Min(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Max(Vec2<T> left, Vec2<T> right) => left.Max(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Clamp(Vec2<T> vec, Vec2<T> min, Vec2<T> max) => vec.Clamp(min, max);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Lerp(Vec2<T> left, Vec2<T> right, T amount) => left.Lerp(right, amount);

    /*[MethodImpl(AggressiveInlining)]
    public static Vec2<T> Transform(Vec2<T> vec, Mat44<T> mat) => vec.Transform(mat);*/
}
