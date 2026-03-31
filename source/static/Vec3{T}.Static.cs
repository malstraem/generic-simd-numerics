namespace System.Numerics;

public partial struct Vec3<T>
{
    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Add(Vec3<T> left, Vec3<T> right) => left + right;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Subtract(Vec3<T> left, Vec3<T> right) => left - right;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Multiply(Vec3<T> vec, T num) => vec * num;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Divide(Vec3<T> vec, T num) => vec / num;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Multiply(Vec3<T> left, Vec3<T> right) => left * right;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Divide(Vec3<T> left, Vec3<T> right) => left / right;

    [MethodImpl(AggressiveInlining)]
    public static T Sum(Vec3<T> vec) => vec.Sum();

    [MethodImpl(AggressiveInlining)]
    public static T Dot(Vec3<T> left, Vec3<T> right) => left.Dot(right);

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared(Vec3<T> vec) => vec.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared(Vec3<T> left, Vec3<T> right) => left.DistanceSquared(right);

    [MethodImpl(AggressiveInlining)]
    public static T Length<R>(Vec3<T> vec)
        where R : IRootFunctions<R>
            => vec.Length<R>();

    [MethodImpl(AggressiveInlining)]
    public static T Distance<R>(Vec3<T> left, Vec3<T> right)
        where R : IRootFunctions<R>
            => left.Distance<R>(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Normalize<R>(Vec3<T> vec)
        where R : IRootFunctions<R>
            => vec.Normalize<R>();

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> SquareRoot<R>(Vec3<T> vec)
        where R : IRootFunctions<R>
            => vec.SquareRoot<R>();

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Abs(Vec3<T> vec) => vec.Abs();

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Min(Vec3<T> left, Vec3<T> right) => left.Min(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Max(Vec3<T> left, Vec3<T> right) => left.Max(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Clamp(Vec3<T> vec, Vec3<T> min, Vec3<T> max) => vec.Clamp(min, max);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Lerp(Vec3<T> left, Vec3<T> right, T amount) => left.Lerp(right, amount);
}
