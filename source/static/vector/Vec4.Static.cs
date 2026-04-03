namespace System.Numerics;

public static class Vec4
{
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add<T>(Vec4<T> vec, T num)
        where T : unmanaged, INumber<T>
            => vec + num;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Substract<T>(Vec4<T> vec, T num)
        where T : unmanaged, INumber<T>
            => vec - num;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add<T>(Vec4<T> left, Vec4<T> right)
        where T : unmanaged, INumber<T>
            => left + right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Substract<T>(Vec4<T> left, Vec4<T> right)
        where T : unmanaged, INumber<T>
            => left - right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply<T>(Vec4<T> vec, T num)
        where T : unmanaged, INumber<T>
            => vec * num;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide<T>(Vec4<T> vec, T num)
        where T : unmanaged, INumber<T>
            => vec / num;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply<T>(Vec4<T> left, Vec4<T> right)
        where T : unmanaged, INumber<T>
            => left * right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide<T>(Vec4<T> left, Vec4<T> right)
        where T : unmanaged, INumber<T>
            => left / right;

    [MethodImpl(AggressiveInlining)]
    public static T Sum<T>(Vec4<T> vec)
        where T : unmanaged, INumber<T>
            => vec.Sum();

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Vec4<T> left, Vec4<T> right)
        where T : unmanaged, INumber<T>
            => left.Dot(right);

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Vec4<T> vec)
        where T : unmanaged, INumber<T>
            => vec.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared<T>(Vec4<T> left, Vec4<T> right)
        where T : unmanaged, INumber<T>
            => left.DistanceSquared(right);

    [MethodImpl(AggressiveInlining)]
    public static T Length<R, T>(Vec4<T> vec)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => vec.Length<R>();

    /*[MethodImpl(AggressiveInlining)]
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
            => vec.SquareRoot<R>();*/

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Abs<T>(Vec4<T> vec)
        where T : unmanaged, INumber<T>
            => vec.Abs();

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Min<T>(Vec4<T> left, Vec4<T> right)
        where T : unmanaged, INumber<T>
            => left.Min(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Max<T>(Vec4<T> left, Vec4<T> right)
        where T : unmanaged, INumber<T>
            => left.Max(right);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Clamp<T>(Vec4<T> vec, Vec4<T> min, Vec4<T> max)
        where T : unmanaged, INumber<T>
            => vec.Clamp(min, max);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Lerp<T>(Vec4<T> left, Vec4<T> right, T amount)
        where T : unmanaged, INumber<T>
            => left.Lerp(right, amount);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Transform<T>(Vec4<T> vec, Mat44<T> mat)
        where T : unmanaged, INumber<T>
            => vec.Transform(mat);
}
