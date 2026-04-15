namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Vec2<T>(T x, T y) :
    IVector<Vec2<T>, T>,
    IVectorScalarOperators<Vec2<T>, T>
        where T : unmanaged, INumber<T> // real number behavior is exposed only where needed
{
    public T X = x, Y = y;

    public Vec2(T n) : this(n, n) { }

    public static Vec2<T> One { get; } = new(T.One);

    public static Vec2<T> Zero { get; } = new(T.Zero);

    public static Vec2<T> UnitX { get; } = new(T.One, T.Zero);

    public static Vec2<T> UnitY { get; } = new(T.Zero, T.One);

    static Vec2<T> IAdditiveIdentity<Vec2<T>, Vec2<T>>.AdditiveIdentity => Zero;

    static Vec2<T> IMultiplicativeIdentity<Vec2<T>, Vec2<T>>.MultiplicativeIdentity => One;

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator +(Vec2<T> v)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return (+v.As128()).Vec2();*/

        return new(+v.X, +v.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> v)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return (-v.As128()).Vec2();*/

        return new(-v.X, -v.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator +(Vec2<T> v, T n)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return (v.As128() + Vector128.Create(n)).Vec2();*/

        return new(v.X + n, v.Y + n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> v, T n)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return (v.As128() - Vector128.Create(n)).Vec2();*/

        return new(v.X - n, v.Y - n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator *(Vec2<T> v, T n)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return (v.As128() * n).Vec2();*/

        return new(v.X * n, v.Y * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator /(Vec2<T> v, T n)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return (v.As128() / n).Vec2();*/

        return new(v.X / n, v.Y / n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> a, Vec2<T> b)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return (a.As128() - b.As128()).Vec2();*/

        return new(a.X - b.X, a.Y - b.Y);
    }

    // use dot product instead element wise is personal choice
    [MethodImpl(AggressiveInlining)]
    public static T operator *(Vec2<T> a, Vec2<T> b) => a.ElementMultiply(b).Sum();

    /*[MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator *(Vec2<T> a, Vec2<T> b)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(a.As128() * b.As128());

        return new(a.X * b.X, a.Y * b.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator /(Vec2<T> a, Vec2<T> b)
    {
        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(a.As128() / b.As128());

        return new(a.X / b.X, a.Y / b.Y);
    }*/

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec2<T> a, Vec2<T> b)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return a.As128() == b.As128();*/

        return a.X == b.X && a.Y == b.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec2<T> a, Vec2<T> b)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return a.As128() != b.As128();*/

        return a.X != b.X && a.Y != b.Y;
    }
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> ElementMultiply(Vec2<T> v)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return (this.As128() * v.As128()).Vec2();*/

        return new(X * v.X, Y * v.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> ElementDivide(Vec2<T> v)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return (this.As128() / v.As128()).Vec2();*/

        return new(X / v.X, Y / v.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly T Sum()
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.Sum(this.As128());*/

        return X + Y;
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Abs()
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.Abs(this.As128()).Vec2();*/

        return new(T.Abs(X), T.Abs(Y));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Min(Vec2<T> v)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.Min(this.As128(), v.As128()).Vec2();*/

        return new(T.Min(X, v.X), T.Min(Y, v.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Max(Vec2<T> v)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.Max(this.As128(), v.As128()).Vec2();*/

        return new(T.Max(X, v.X), T.Max(Y, v.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Clamp(Vec2<T> min, Vec2<T> max)
    {
        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.Clamp(this.As128(), min.As128(), max.As128()).Vec2();*/

        return max.Min(Max(min));
    }

    // intrinsic Lerp<T> should exist
    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Lerp(Vec2<T> v, T am) => (this * (T.One - am)) + (v * am);

    // not sure about the next one, but looks good?
    // float and double are sealed using extensions

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => this * this;

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec2<T> v) => (this - v).LengthSquared();

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
    public readonly R DistanceSaturating<R>(Vec2<T> v)
        where R : IRootFunctions<R>
            => R.Sqrt(R.CreateSaturating(DistanceSquared(v)));

    [MethodImpl(AggressiveInlining)]
    public readonly R DistanceTruncating<R>(Vec2<T> v)
        where R : IRootFunctions<R>
            => R.CreateTruncating(DistanceSquared(v));

    [MethodImpl(AggressiveInlining)]
    public readonly T Distance<R>(Vec2<T> v)
        where R : IRootFunctions<R>
            => T.CreateTruncating(DistanceSaturating<R>(v));

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Normalize<R>()
        where R : IRootFunctions<R>
            => this / Length<R>();

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> SquareRoot<R>() where R : IRootFunctions<R>
    {
        // looks like intrinsics works with integers
        // but maybe it would be better to make Vec{N}<T>.SquareRoot<R> return Vec{N}<R>?

        /*if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.Sqrt(this.As128()).Vec2();*/

        return new
        (
            T.CreateTruncating(R.Sqrt(R.CreateSaturating(X))),
            T.CreateTruncating(R.Sqrt(R.CreateSaturating(Y)))
        );
    }

    public override readonly string ToString() => $"({X}, {Y})";

    public readonly bool Equals(Vec2<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Vec2<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y);
}
