namespace System.Numerics;

#pragma warning disable IDE0022

public static class Vec2
{
    [MethodImpl(AggressiveInlining)]
    public static bool LessOrEqual<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.LessThanOrEqualAll(a.As128(), b.As128());

        return a.X <= b.X && a.Y <= b.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool GreaterOrEqual<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.GreaterThanOrEqualAll(a.As128(), b.As128());

        return a.X >= b.X && a.Y >= b.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool Less<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.LessThanAll(a.As128(), b.As128());

        return a.X < b.X && a.Y < b.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool Greater<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.GreaterThanAll(a.As128(), b.As128());

        return a.X > b.X && a.Y > b.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool Equal<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return a.As128() == b.As128();

        return a.X == b.X && a.Y == b.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool Equal<T>(Vec2<T> a, Vec2<T> b, T eps)
        where T : unmanaged, IFloatingPoint<T>
    {
        return T.Abs(a.X - b.X) <= eps && T.Abs(a.Y - b.Y) <= eps;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool NotEqual<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return a.As128() != b.As128();

        return a.X != b.X && a.Y != b.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Add<T>(Vec2<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() + Vector128.Create(n)).Vec2();

        return new(v.X + n, v.Y + n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Subtract<T>(Vec2<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() - Vector128.Create(n)).Vec2();

        return new(v.X - n, v.Y - n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Add<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() + b.As128()).Vec2();

        return a + b;
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Subtract<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() - b.As128()).Vec2();

        return new(a.X - b.X, a.Y - b.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Multiply<T>(Vec2<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() * n).Vec2();

        return new(v.X * n, v.Y * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Divide<T>(Vec2<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() / n).Vec2();

        return new(v.X / n, v.Y / n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Multiply<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() * b.As128()).Vec2();

        return new(a.X * b.X, a.Y * b.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Divide<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() / b.As128()).Vec2();

        return new(a.X / b.X, a.Y / b.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static T Sum<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Sum(v.As128());

        return v.X + v.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Dot(a.As128(), b.As128());

        return Sum(a * b);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Min<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Min(a.As128(), b.As128()).Vec2();

        return new(T.Min(a.X, b.X), T.Min(a.Y, b.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Max<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Max(a.As128(), b.As128()).Vec2();

        return new(T.Max(a.X, b.X), T.Max(a.Y, b.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Clamp<T>(Vec2<T> v, Vec2<T> min, Vec2<T> max)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Clamp(v.As128(), min.As128(), max.As128()).Vec2();

        return Min(max, Max(v, min));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Lerp<T>(Vec2<T> a, Vec2<T> b, T am)
        where T : unmanaged, INumber<T>
            => (a * (T.One - am)) + (b * am);

    [MethodImpl(AggressiveInlining)]
    public static T Cross<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
            => (a.X * b.Y) - (a.Y * b.X);

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>
            => Dot(v, v);

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>
            => LengthSquared(a - b);

    [MethodImpl(AggressiveInlining)]
    public static T Length<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => T.Sqrt(LengthSquared(v));

    [MethodImpl(AggressiveInlining)]
    public static T Distance<T>(Vec2<T> a, Vec2<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => T.Sqrt(DistanceSquared(a, b));

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Normalize<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => v / Length(v);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> SquareRoot<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Sqrt(v.As128()).Vec2();

        return new(T.Sqrt(v.X), T.Sqrt(v.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Sin<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>, ITrigonometricFunctions<T>
    {
        //if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
        //    return Vector128.Sin(v.As128()).Vec2(); it should be like this

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated && typeof(T) == typeof(float))
            return Vector128.Sin(v.As128().As<T, float>()).As<float, T>().Vec2();

        return new(T.Sin(v.X), T.Sin(v.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Cos<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>, ITrigonometricFunctions<T>
    {
        //if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
        //    return Vector128.Cos(v.As128()).Vec2(); it should be like this

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated && typeof(T) == typeof(float))
            return Vector128.Cos(v.As128().As<T, float>()).As<float, T>().Vec2();

        return new(T.Cos(v.X), T.Cos(v.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> Abs<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>, ISignedNumber<T>
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Abs(v.As128()).Vec2();

        return new(T.Abs(v.X), T.Abs(v.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T2> As<T, T2>(Vec2<T> v)
        where T : unmanaged, INumber<T>
        where T2 : unmanaged, INumber<T2>
    {
        return new Vec2<T2>(
            T2.CreateTruncating(v.X),
            T2.CreateTruncating(v.Y));
    }
}
