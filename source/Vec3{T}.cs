namespace System.Numerics;

public partial struct Vec3<T>(T x, T y, T z) :
    IVector<Vec3<T>, T>,
    IVectorScalarOperators<Vec3<T>, T>
        // vector works with all types and root behavior is exposed only where needed
        where T : unmanaged, INumber<T>
{
    public T X = x, Y = y, Z = z;

    public Vec3(T n) : this(n, n, n) { }

    public static Vec3<T> One => new(T.One);

    public static Vec3<T> Zero => new(T.Zero);

    public static Vec3<T> UnitX { get; } = new(T.One, T.Zero, T.Zero);

    public static Vec3<T> UnitY { get; } = new(T.Zero, T.One, T.Zero);

    public static Vec3<T> UnitZ { get; } = new(T.Zero, T.Zero, T.One);

    static Vec3<T> IAdditiveIdentity<Vec3<T>, Vec3<T>>.AdditiveIdentity => Zero;

    static Vec3<T> IMultiplicativeIdentity<Vec3<T>, Vec3<T>>.MultiplicativeIdentity => One;

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator +(Vec3<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(+v.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(+v.As256());

        return new(+v.X, +v.Y, +v.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator -(Vec3<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(-v.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(-v.As256());

        return new(-v.X, -v.Y, -v.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator +(Vec3<T> v, T n)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(v.As128() + Vector128.Create(n));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(v.As256() + Vector256.Create(n));

        return new(v.X + n, v.Y + n, v.Z + n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator -(Vec3<T> v, T n)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(v.As128() - Vector128.Create(n));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(v.As256() - Vector256.Create(n));

        return new(v.X - n, v.Y - n, v.Z - n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator *(Vec3<T> v, T n)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(v.As128() * n);

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(v.As256() * n);

        return new(v.X * n, v.Y * n, v.Z * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator /(Vec3<T> v, T n)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(v.As128() / n);

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(v.As256() / n);

        return new(v.X / n, v.Y / n, v.Z / n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator +(Vec3<T> a, Vec3<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(a.As128() + b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(a.As256() + b.As256());

        return new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator -(Vec3<T> a, Vec3<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(a.As128() - b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(a.As256() - b.As256());

        return new(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static T operator *(Vec3<T> a, Vec3<T> b) => a.ElementMultiply(b).Sum();

    /*[MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator *(Vec3<T> a, Vec3<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(a.As128() * b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(a.As256() * b.As256());

        return new(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator /(Vec3<T> a, Vec3<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(a.As128() / b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(a.As256() / b.As256());

        return new(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
    }*/

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec3<T> a, Vec3<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return a.As128() == b.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return a.As256() == b.As256();

        return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec3<T> a, Vec3<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return a.As128() != b.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return a.As256() != b.As256();

        return a.X != b.X && a.Y != b.Y && a.Z != b.Z;
    }
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> ElementMultiply(Vec3<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(As128() * v.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(As256() * v.As256());

        return new(X * v.X, Y * v.Y, Z * v.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> ElementDivide(Vec3<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(As128() / v.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(As256() / v.As256());

        return new(X / v.X, Y / v.Y, Z / v.Z);
    }

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining)]
    public readonly T Sum() => X + Y + Z;

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Abs()
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(Vector128.Abs(As128()));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(Vector256.Abs(As256()));

        return new(T.Abs(X), T.Abs(Y), T.Abs(Z));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Min(Vec3<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(Vector128.Min(As128(), v.As128()));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(Vector256.Min(As256(), v.As256()));

        return new(T.Min(X, v.X), T.Min(Y, v.Y), T.Min(Z, v.Z));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Max(Vec3<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(Vector128.Max(As128(), v.As128()));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(Vector256.Max(As256(), v.As256()));

        return new(T.Max(X, v.X), T.Max(Y, v.Y), T.Max(Z, v.Z));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Clamp(Vec3<T> min, Vec3<T> max)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(Vector128.Clamp(As128(), min.As128(), max.As128()));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(Vector256.Clamp(As256(), min.As256(), max.As256()));

        return max.Min(Max(min));
    }

    // intrinsic Lerp<T> should exist
    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Lerp(Vec3<T> v, T am) => (this * (T.One - am)) + (v * am);

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Cross(Vec3<T> v) => new((Y * v.Z) - (Z * v.Y),
                                                    (Z * v.X) - (X * v.Z),
                                                    (X * v.Y) - (Y * v.X));

    // not sure about the next one, but looks good?
    // float and double are sealed using extensions

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => this * this;

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec3<T> v) => (this - v).LengthSquared();

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
    public readonly R DistanceSaturating<R>(Vec3<T> v)
        where R : IRootFunctions<R>
            => R.Sqrt(R.CreateSaturating(DistanceSquared(v)));

    [MethodImpl(AggressiveInlining)]
    public readonly R DistanceTruncating<R>(Vec3<T> v)
        where R : IRootFunctions<R>
            => R.CreateTruncating(DistanceSquared(v));

    [MethodImpl(AggressiveInlining)]
    public readonly T Distance<R>(Vec3<T> v)
        where R : IRootFunctions<R>
            => T.CreateTruncating(DistanceSaturating<R>(v));

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Normalize<R>()
        where R : IRootFunctions<R>
            => this / Length<R>();

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> SquareRoot<R>() where R : IRootFunctions<R>
    {
        // looks like intrinsics works with integers
        // but maybe it would be better to make Vec{N}<T>.SquareRoot<R> return Vec{N}<R>?

        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(Vector128.Sqrt(As128()));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(Vector256.Sqrt(As256()));

        return new(T.CreateTruncating(R.Sqrt(R.CreateSaturating(X))),
                   T.CreateTruncating(R.Sqrt(R.CreateSaturating(Y))),
                   T.CreateTruncating(R.Sqrt(R.CreateSaturating(Z))));
    }

    public override readonly string ToString() => $"({X}, {Y}, {Z})";

    public override readonly bool Equals(object? obj) => (obj is Vec3<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

    public readonly bool Equals(Vec3<T> other) => this == other;
}
