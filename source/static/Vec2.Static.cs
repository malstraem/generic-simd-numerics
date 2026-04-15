namespace System.Numerics;

public static class Vec2
{
    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Add<T>(Vec2<T> v, T n)
        where T : unmanaged, INumber<T>
            => v + n;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Subtract<T>(Vec2<T> v, T n)
        where T : unmanaged, INumber<T>
            => v - n;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Add<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
            => a + b;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Subtract<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
            => a - b;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Multiply<T>(Vec2<T> v, T n)
        where T : unmanaged, INumber<T>
            => v * n;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Divide<T>(Vec2<T> v, T n)
        where T : unmanaged, INumber<T>
            => v / n;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> ElementMultiply<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
            => a.ElementMultiply(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> ElementDivide<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
            => a.ElementDivide(b);

    [MethodImpl(AggressiveInlining)]
    public static T Sum<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>
            => v.Sum();

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
            => a * b;

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Abs<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>
            => v.Abs();

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Min<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
            => a.Min(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Max<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
            => a.Max(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Clamp<T>(Vec2<T> v, Vec2<T> min, Vec2<T> max)
        where T : unmanaged, INumber<T>
            => v.Clamp(min, max);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Lerp<T>(Vec2<T> a, Vec2<T> b, T am)
        where T : unmanaged, INumber<T>
            => a.Lerp(b, am);

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>
            => v.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
            => a.DistanceSquared(b);

    [MethodImpl(AggressiveInlining)]
    public static T Length<T, R>(Vec2<T> v)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => v.Length<R>();

    [MethodImpl(AggressiveInlining)]
    public static T Distance<T, R>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => a.Distance<R>(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Normalize<T, R>(Vec2<T> v)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => v.Normalize<R>();

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> SquareRoot<T, R>(Vec2<T> v)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => v.SquareRoot<R>();
}
