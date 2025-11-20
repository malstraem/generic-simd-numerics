namespace System.Numerics;

public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add(Vec4<T> left, Vec4<T> right) => left + right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Subtract(Vec4<T> left, Vec4<T> right) => left - right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply(Vec4<T> left, Vec4<T> right) => left * right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply(Vec4<T> left, T value) => left * value;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply(T value, Vec4<T> right) => right * value;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide(Vec4<T> left, Vec4<T> right) => left / right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide(Vec4<T> left, T divisor) => left / divisor;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Negate(Vec4<T> vec) => -vec;

    [MethodImpl(AggressiveInlining)]
    public static T Sum(Vec4<T> vec) => vec.Sum();

    [MethodImpl(AggressiveInlining)]
    public static T Dot(Vec4<T> left, Vec4<T> right) => left.Dot(right);

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared(Vec4<T> vec) => vec.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared(Vec4<T> left, Vec4<T> right) => left.DistanceSquared(right);

    /*[MethodImpl(AggressiveInlining)]
    public static T Length(Vec4<T> vec) => vec.Length();

    [MethodImpl(AggressiveInlining)]
    public static T Distance(Vec4<T> left, Vec4<T> right) => left.Distance(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Normalize(Vec4<T> vec) => vec.Normalize();*/

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
