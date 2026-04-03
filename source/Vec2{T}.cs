namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Vec2<T>(T x, T y) :
    IVector<Vec2<T>>,
    IVectorOperators<Vec2<T>>,
    IVectorScalarOperators<Vec2<T>, T>
        // vector works with all types and root behavior is exposed only where needed
        where T : unmanaged, INumber<T>
{
    public T X = x, Y = y;

    public Vec2(T num) : this(num, num) { }

    public static Vec2<T> Zero { get; } = new(T.Zero);

    public static Vec2<T> One { get; } = new(T.One, T.One);

    public static Vec2<T> UnitX { get; } = new(T.One, T.Zero);

    public static Vec2<T> UnitY { get; } = new(T.Zero, T.One);

    static Vec2<T> IAdditiveIdentity<Vec2<T>, Vec2<T>>.AdditiveIdentity => Zero;

    static Vec2<T> IMultiplicativeIdentity<Vec2<T>, Vec2<T>>.MultiplicativeIdentity => One;

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator +(Vec2<T> vec)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(+vec.As128());

        return new(+vec.X, +vec.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> vec)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(-vec.As128());

        return new(-vec.X, -vec.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator +(Vec2<T> vec, T num)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(vec.As128() + Vector128.Create(num));

        return new(vec.X + num, vec.Y + num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> vec, T num)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(vec.As128() - Vector128.Create(num));

        return new(vec.X - num, vec.Y - num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator *(Vec2<T> vec, T num)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(vec.As128() * num);

        return new(vec.X * num, vec.Y * num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator /(Vec2<T> vec, T num)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(vec.As128() / num);

        return new(vec.X / num, vec.Y / num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(left.As128() - right.As128());

        return new(left.X - right.X, left.Y - right.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator *(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(left.As128() * right.As128());

        return new(left.X * right.X, left.Y * right.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator /(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(left.As128() / right.As128());

        return new(left.X / right.X, left.Y / right.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return left.As128() == right.As128();

        return left.X == right.X && left.Y == right.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return left.As128() != right.As128();

        return left.X != right.X && left.Y != right.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator <=(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.LessThanOrEqualAll(left.As128(), right.As128());

        return left.X <= right.X && left.Y <= right.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator >=(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.GreaterThanOrEqualAll(left.As128(), right.As128());

        return left.X >= right.X && left.Y >= right.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator >(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.GreaterThanAll(left.As128(), right.As128());

        return left.X > right.X && left.Y > right.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator <(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.LessThanAll(left.As128(), right.As128());

        return left.X < right.X && left.Y < right.Y;
    }
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly T Sum()
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.Sum(As128());

        return X + Y;
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Abs()
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(Vector128.Abs(As128()));

        return new(T.Abs(X), T.Abs(Y));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Min(Vec2<T> vec)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(Vector128.Min(As128(), vec.As128()));

        return new(T.Min(X, vec.X), T.Min(Y, vec.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Max(Vec2<T> vec)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(Vector128.Max(As128(), vec.As128()));

        return new(T.Max(X, vec.X), T.Max(Y, vec.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Clamp(Vec2<T> min, Vec2<T> max)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(Vector128.Clamp(As128(), min.As128(), max.As128()));

        return max.Min(Max(min));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Lerp(Vec2<T> vec, T amount)
    {
        // intrinsic Lerp<T> should exist

        return (this * (T.One - amount))
             + (vec * amount);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Vec2<T> vec) => (this * vec).Sum();

    // not sure about the next one, but looks good?
    // float and double are sealed using extensions

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Dot(this);

    [MethodImpl(AggressiveInlining)]
    public readonly R LengthSaturating<R>()
        where R : IRootFunctions<R>
            => R.Sqrt(R.CreateSaturating(LengthSquared()));

    [MethodImpl(AggressiveInlining)]
    public readonly R LengthTruncating<R>()
        where R : IRootFunctions<R>
            => R.Sqrt(R.CreateTruncating(LengthSquared()));

    [MethodImpl(AggressiveInlining)]
    public readonly T Length<R>()
        where R : IRootFunctions<R>
            => T.CreateTruncating(LengthSaturating<R>());

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec2<T> vec)
        => (this - vec).LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public readonly R DistanceSaturating<R>(Vec2<T> vec)
        where R : IRootFunctions<R>
            => R.Sqrt(R.CreateSaturating(DistanceSquared(vec)));

    [MethodImpl(AggressiveInlining)]
    public readonly R DistanceTruncating<R>(Vec2<T> vec)
        where R : IRootFunctions<R>
            => R.CreateTruncating(DistanceSquared(vec));

    [MethodImpl(AggressiveInlining)]
    public readonly T Distance<R>(Vec2<T> vec)
        where R : IRootFunctions<R>
            => T.CreateTruncating(DistanceSaturating<R>(vec));

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Normalize<R>()
        where R : IRootFunctions<R>
            => this / Distance<R>(Zero);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> SquareRoot<R>() where R : IRootFunctions<R>
    {
        // looks like intrinsics works with integers
        // but maybe it would be better to make Vec{N}<T>.SquareRoot<R> return Vec{N}<R>?

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(Vector128.Sqrt(As128()));

        return new
        (
            T.CreateTruncating(R.Sqrt(R.CreateSaturating(X))),
            T.CreateTruncating(R.Sqrt(R.CreateSaturating(Y)))
        );
    }

    public override readonly string ToString() => $"({X}, {Y})";

    public override readonly bool Equals(object? obj) => (obj is Vec2<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y);

    public readonly bool Equals(Vec2<T> other) => this == other;
}
