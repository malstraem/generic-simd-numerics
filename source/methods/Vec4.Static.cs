namespace System.Numerics;

public static class Vec4
{
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() + Vector128.Create(n)).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() + Vector256.Create(n)).Vec4();

        return new(v.X + n, v.Y + n, v.Z + n, v.W + n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Subtract<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() - Vector128.Create(n)).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() - Vector256.Create(n)).Vec4();

        return new(v.X - n, v.Y - n, v.Z - n, v.W - n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() + b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() + b.As256()).Vec4();

        return new(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Subtract<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() - b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() - b.As256()).Vec4();

        return new(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() * n).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() * n).Vec4();

        return new(v.X * n, v.Y * n, v.Z * n, v.W * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() / n).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() / n).Vec4();

        return new(v.X / n, v.Y / n, v.Z / n, v.W / n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() * b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() * b.As256()).Vec4();

        return new(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() / b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() / b.As256()).Vec4();

        return new(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static T Sum<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Sum(v.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Sum(v.As256());

        return v.X + v.Y + v.Z + v.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Dot(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Dot(a.As256(), b.As256());

        return (a * b).Sum();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Min<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Min(a.As128(), b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Min(a.As256(), b.As256()).Vec4();

        return new(T.Min(a.X, b.X), T.Min(a.Y, b.Y), T.Min(a.Z, b.Z), T.Min(a.W, b.W));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Max<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Max(a.As128(), b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Max(a.As256(), b.As256()).Vec4();

        return new(T.Max(a.X, b.X), T.Max(a.Y, b.Y), T.Max(a.Z, b.Z), T.Max(a.W, b.W));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Clamp<T>(Vec4<T> v, Vec4<T> min, Vec4<T> max)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Clamp(v.As128(), min.As128(), max.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Clamp(v.As256(), min.As256(), max.As256()).Vec4();

        return Min(max, Max(v, min));
    }

    // VectorNNN.Lerp<T> should exist, isn't?
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Lerp<T>(Vec4<T> a, Vec4<T> b, T am)
        where T : unmanaged, INumber<T>
            => (a * (T.One - am)) + (b * am);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Transform<T>(Vec4<T> v, Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        var t = m.X * v.X;

        t = m.Y.Estimate(v.Y, t);
        t = m.Z.Estimate(v.Z, t);
        t = m.W.Estimate(v.W, t);

        return t;
    }

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
            => Dot(v, v);

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
            => LengthSquared(a - b);

    [MethodImpl(AggressiveInlining)]
    public static T Length<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => T.Sqrt(LengthSquared(v));

    [MethodImpl(AggressiveInlining)]
    public static T Distance<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => T.Sqrt(DistanceSquared(a, b));

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Normalize<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => v / Length(v);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> SquareRoot<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Sqrt(v.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Sqrt(v.As256()).Vec4();

        return new(T.Sqrt(v.X), T.Sqrt(v.Y), T.Sqrt(v.Z), T.Sqrt(v.W));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Abs<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, ISignedNumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Abs(v.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Abs(v.As256()).Vec4();

        return new(T.Abs(v.X), T.Abs(v.Y), T.Abs(v.Z), T.Abs(v.W));
    }
}
