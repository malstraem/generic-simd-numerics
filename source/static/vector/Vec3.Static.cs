namespace System.Numerics;

public static class Vec3
{
    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Add<T>(Vec3<T> v, T n)
        where T : unmanaged, INumber<T>
            => v + n;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Subtract<T>(Vec3<T> v, T n)
        where T : unmanaged, INumber<T>
            => v - n;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Add<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a + b;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Subtract<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a - b;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Multiply<T>(Vec3<T> v, T n)
        where T : unmanaged, INumber<T>
            => v * n;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Divide<T>(Vec3<T> v, T n)
        where T : unmanaged, INumber<T>
            => v / n;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> ElementMultiply<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a.ElementMultiply(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> ElementDivide<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a.ElementDivide(b);

    [MethodImpl(AggressiveInlining)]
    public static T Sum<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>
            => v.Sum();

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a * b;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Abs<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>
            => v.Abs();

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Min<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a.Min(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Max<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a.Max(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Clamp<T>(Vec3<T> v, Vec3<T> min, Vec3<T> max)
        where T : unmanaged, INumber<T>
            => v.Clamp(min, max);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Lerp<T>(Vec3<T> a, Vec3<T> b, T am)
        where T : unmanaged, INumber<T>
            => a.Lerp(b, am);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Cross<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a.Cross(b);

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>
            => v.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a.DistanceSquared(b);

    [MethodImpl(AggressiveInlining)]
    public static T Length<T, R>(Vec3<T> v)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => v.Length<R>();

    [MethodImpl(AggressiveInlining)]
    public static T Distance<T, R>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => a.Distance<R>(b);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Normalize<T, R>(Vec3<T> v)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => v.Normalize<R>();

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> SquareRoot<T, R>(Vec3<T> v)
        where T : unmanaged, INumber<T>
        where R : IRootFunctions<R>
            => v.SquareRoot<R>();
}
