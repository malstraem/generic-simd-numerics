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
    public static Vec3<T> Multiply(T value, Vec3<T> right) => right * value;

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
    public static T Length<TRoot>(Vec3<T> vec)
        where TRoot : IRootFunctions<TRoot>
            => vec.Length<TRoot>();

    [MethodImpl(AggressiveInlining)]
    public static T Distance<TRoot>(Vec3<T> left, Vec3<T> right)
        where TRoot : IRootFunctions<TRoot>
            => left.Distance<TRoot>(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Normalize<TRoot>(Vec3<T> vec)
        where TRoot : IRootFunctions<TRoot>
            => vec.Normalize<TRoot>();

    public static Vec3<T> SquareRoot<TRoot>(Vec3<T> vec)
        where TRoot : IRootFunctions<TRoot>
            => vec.SquareRoot<TRoot>();

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
