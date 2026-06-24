namespace System.Numerics;

#pragma warning disable IDE0022

public static class Vec3
{
    [Obsolete("add overload with target eps")]
    [MethodImpl(AggressiveInlining)]
    public static bool Equal<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return a.As128() == b.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return a.As256() == b.As256();*/

        return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    }

    [Obsolete("add overload with target eps")]
    [MethodImpl(AggressiveInlining)]
    public static bool NotEqual<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return a.As128() != b.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return a.As256() != b.As256();*/

        return a.X != b.X && a.Y != b.Y && a.Z != b.Z;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool LessOrEqual<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.LessThanOrEqualAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.LessThanOrEqualAll(a.As256(), b.As256());*/

        return a.X <= b.X && a.Y <= b.Y && a.Z <= b.Z;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool GreaterOrEqual<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.GreaterThanOrEqualAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.GreaterThanOrEqualAll(a.As256(), b.As256());*/

        return a.X >= b.X && a.Y >= b.Y && a.Z >= b.Z;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool Greater<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.GreaterThanAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.GreaterThanAll(a.As256(), b.As256());*/

        return a.X > b.X && a.Y > b.Y && a.Z > b.Z;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool Less<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.LessThanAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.LessThanAll(a.As256(), b.As256());*/

        return a.X < b.X && a.Y < b.Y && a.Z < b.Z;
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Add<T>(Vec3<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() + Vector128.Create(n)).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() + Vector256.Create(n)).Vec3();*/

        return new(v.X + n, v.Y + n, v.Z + n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Subtract<T>(Vec3<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() - Vector128.Create(n)).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() - Vector256.Create(n)).Vec3();*/

        return new(v.X - n, v.Y - n, v.Z - n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Add<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() + b.As128()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() + b.As256()).Vec3();*/

        return new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Subtract<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() - b.As128()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() - b.As256()).Vec3();*/

        return new(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Multiply<T>(Vec3<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() * n).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() * n).Vec3();*/

        return new(v.X * n, v.Y * n, v.Z * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Divide<T>(Vec3<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() / n).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() / n).Vec3();*/

        return new(v.X / n, v.Y / n, v.Z / n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Multiply<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() * b.As128()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() * b.As256()).Vec3();*/

        return new(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Divide<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() / b.As128One()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() / b.As256One()).Vec3();*/

        return new(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static T Sum<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Sum(v.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Sum(v.As256());*/

        return v.X + v.Y + v.Z;
    }

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Dot(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Dot(a.As256(), b.As256());*/

        return Sum(a * b);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Min<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Min(a.As128(), b.As128()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Min(a.As256(), b.As256()).Vec3();*/

        return new(T.Min(a.X, b.X), T.Min(a.Y, b.Y), T.Min(a.Z, b.Z));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Max<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Max(a.As128(), b.As128()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Max(a.As256(), b.As256()).Vec3();*/

        return new(T.Max(a.X, b.X), T.Max(a.Y, b.Y), T.Max(a.Z, b.Z));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Clamp<T>(Vec3<T> v, Vec3<T> min, Vec3<T> max)
        where T : unmanaged, INumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Clamp(v.As128(), min.As128(), max.As128()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Clamp(v.As256(), min.As256(), max.As256()).Vec3();*/

        return Min(max, Max(v, min));
    }

    // VectorNNN.Lerp<T> should exist, isn't?
    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Lerp<T>(Vec3<T> a, Vec3<T> b, T am)
        where T : unmanaged, INumber<T>
            => (a * (T.One - am)) + (b * am);

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>
            => Dot(v, v);

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => LengthSquared(a - b);

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

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Cross<T>(Vec3<T> a, Vec3<T> b)
        where T : unmanaged, INumber<T>
            => new((a.Y * b.Z) - (a.Z * b.Y), (a.Z * b.X) - (a.X * b.Z), (a.X * b.Y) - (a.Y * b.X));

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> SquareRoot<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Sqrt(v.As128()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Sqrt(v.As256()).Vec3();*/

        return new(T.Sqrt(v.X), T.Sqrt(v.Y), T.Sqrt(v.Z));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> Abs<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, ISignedNumber<T>
    {
        /*if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Abs(v.As128()).Vec3();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Abs(v.As256()).Vec3();*/

        return new(T.Abs(v.X), T.Abs(v.Y), T.Abs(v.Z));
    }
}
