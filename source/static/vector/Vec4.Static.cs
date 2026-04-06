namespace System.Numerics;

public static class Vec4
{
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
            => v + n;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Substract<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
            => v - n;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
            => a + b;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Substract<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
            => a - b;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
            => v * n;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
            => v / n;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
            => a * b;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
            => a / b;

    [MethodImpl(AggressiveInlining)]
    public static T Sum<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
            => v.Sum();

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
            => a.Dot(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Abs<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
            => v.Abs();

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Min<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
            => a.Min(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Max<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
            => a.Max(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Clamp<T>(Vec4<T> v, Vec4<T> min, Vec4<T> max)
        where T : unmanaged, INumber<T>
            => v.Clamp(min, max);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Lerp<T>(Vec4<T> a, Vec4<T> b, T am)
        where T : unmanaged, INumber<T>
            => a.Lerp(b, am);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Transform<T>(Vec4<T> v, Mat44<T> m)
        where T : unmanaged, INumber<T>
            => v.Transform(m);

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
            => v.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
            => a.DistanceSquared(b);

    [MethodImpl(AggressiveInlining)]
    public static T Length<T, R>(Vec4<T> v)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => v.Length<R>();

    [MethodImpl(AggressiveInlining)]
    public static T Distance<T, R>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => a.Distance<R>(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Normalize<T, R>(Vec4<T> v)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => v.Normalize<R>();

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> SquareRoot<T, R>(Vec4<T> v)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => v.SquareRoot<R>();
}
