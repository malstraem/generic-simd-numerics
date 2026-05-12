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
    public static Vec3<T> Multiply<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a * b;

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Divide<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a / b;

    [MethodImpl(AggressiveInlining)]
    public static T Sum<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>
            => v.Sum();

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => a.Dot(b);

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
    public static T Length<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => T.Sqrt(LengthSquared(v));

    [MethodImpl(AggressiveInlining)]
    public static T Distance<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => T.Sqrt(DistanceSquared(a, b));

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Normalize<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => v / Length(v);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> SquareRoot<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Sqrt(v.As128()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Sqrt(v.As256()).Vec3();

        return new(T.Sqrt(v.X), T.Sqrt(v.Y), T.Sqrt(v.Z));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Abs<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, ISignedNumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Abs(v.As128()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Abs(v.As256()).Vec3();

        return new(T.Abs(v.X), T.Abs(v.Y), T.Abs(v.Z));
    }
}
