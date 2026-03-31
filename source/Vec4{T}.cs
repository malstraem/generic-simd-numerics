namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Vec4<T>(T x, T y, T z, T w) :
    IVector<Vec4<T>>,
    IVectorOperators<Vec4<T>>,
    IVectorScalarOperators<Vec4<T>, T>
        // vector works with all types and root behavior is exposed only where needed
        where T : unmanaged, INumber<T>
{
    public T X = x, Y = y, Z = z, W = w;

    public Vec4(T num) : this(num, num, num, num) { }

    public static Vec4<T> Zero { get; } = new(T.Zero);

    public static Vec4<T> One { get; } = new(T.One, T.One, T.One, T.One);

    public static Vec4<T> UnitX { get; } = new(T.One, T.Zero, T.Zero, T.Zero);

    public static Vec4<T> UnitY { get; } = new(T.Zero, T.One, T.Zero, T.Zero);

    public static Vec4<T> UnitZ { get; } = new(T.Zero, T.Zero, T.One, T.Zero);

    public static Vec4<T> UnitW { get; } = new(T.Zero, T.Zero, T.Zero, T.One);

    static Vec4<T> IAdditiveIdentity<Vec4<T>, Vec4<T>>.AdditiveIdentity => Zero;

    static Vec4<T> IMultiplicativeIdentity<Vec4<T>, Vec4<T>>.MultiplicativeIdentity => One;

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> vec)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(+vec.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(+vec.As256());

        return new(+vec.X, +vec.Y, +vec.Z, +vec.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> vec)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(-vec.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(-vec.As256());

        return new(-vec.X, -vec.Y, -vec.Z, -vec.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> vec, T num)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(vec.As128() + Vector128.Create(num));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(vec.As256() + Vector256.Create(num));

        return new(vec.X + num, vec.Y + num, vec.Z + num, vec.W + num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> vec, T num)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(vec.As128() - Vector128.Create(num));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(vec.As256() - Vector256.Create(num));

        return new(vec.X - num, vec.Y - num, vec.Z - num, vec.W - num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> vec, T num)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(vec.As128() * num);

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(vec.As256() * num);

        return new(vec.X * num, vec.Y * num, vec.Z * num, vec.W * num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> vec, T num)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(vec.As128() / num);

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(vec.As256() / num);

        return new(vec.X / num, vec.Y / num, vec.Z / num, vec.W / num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> left, Vec4<T> right)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(left.As128() + right.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(left.As256() + right.As256());

        return new(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> left, Vec4<T> right)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(left.As128() - right.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(left.As256() - right.As256());

        return new(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> left, Vec4<T> right)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(left.As128() * right.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(left.As256() * right.As256());

        return new(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> left, Vec4<T> right)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(left.As128() / right.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(left.As256() / right.As256());

        return new(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec4<T> left, Vec4<T> right)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return left.As128() == right.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return left.As256() == right.As256();

        return left.X == right.X
            && left.Y == right.Y
            && left.Z == right.Z
            && left.W == right.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec4<T> left, Vec4<T> right)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return left.As128() != right.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return left.As256() != right.As256();

        return left.X != right.X
            && left.Y != right.Y
            && left.Z != right.Z
            && left.W != right.W;
    }
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly T Sum()
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.Sum(As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.Sum(As256());

        return X + Y + Z + W;
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Abs()
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(Vector128.Abs(As128()));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(Vector256.Abs(As256()));

        return new(T.Abs(X), T.Abs(Y), T.Abs(Z), T.Abs(W));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Min(Vec4<T> vec)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(Vector128.Min(As128(), vec.As128()));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(Vector256.Min(As256(), vec.As256()));

        return new(T.Min(X, vec.X),
                   T.Min(Y, vec.Y),
                   T.Min(Z, vec.Z),
                   T.Min(W, vec.W));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Max(Vec4<T> vec)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(Vector128.Max(As128(), vec.As128()));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(Vector256.Max(As256(), vec.As256()));

        return new(T.Max(X, vec.X),
                   T.Max(Y, vec.Y),
                   T.Max(Z, vec.Z),
                   T.Max(W, vec.W));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Clamp(Vec4<T> min, Vec4<T> max)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(Vector128.Clamp(As128(), min.As128(), max.As128()));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(Vector256.Clamp(As256(), min.As256(), max.As256()));

        return max.Min(Max(min));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Lerp(Vec4<T> vec, T amount)
    {
        // intrinsic Lerp<T> should exist

        return (this * (T.One - amount))
             + (vec * amount);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Transform(Mat44<T> mat)
    {
        // intrinsic MultiplyAdd<T> should exist
        var vec = mat.X * X;

        vec += mat.Y * Y;
        vec += mat.Z * Z;
        vec += mat.W * W;

        return vec;
    }

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Vec4<T> vec) => (this * vec).Sum();

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
    public readonly T DistanceSquared(Vec4<T> vec)
        => (this - vec).LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public readonly R DistanceSaturating<R>(Vec4<T> vec)
        where R : IRootFunctions<R>
            => R.Sqrt(R.CreateSaturating(DistanceSquared(vec)));

    [MethodImpl(AggressiveInlining)]
    public readonly R DistanceTruncating<R>(Vec4<T> vec)
        where R : IRootFunctions<R>
            => R.CreateTruncating(DistanceSquared(vec));

    [MethodImpl(AggressiveInlining)]
    public readonly T Distance<R>(Vec4<T> vec)
        where R : IRootFunctions<R>
            => T.CreateTruncating(DistanceSaturating<R>(vec));

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Normalize<R>()
        where R : IRootFunctions<R>
            => this / Distance<R>(Zero);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> SquareRoot<R>() where R : IRootFunctions<R>
    {
        // looks like intrinsics works with integers
        // but maybe it would be better to make VecN<T>.SquareRoot<R> return VecN<R>?

        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return From128(Vector128.Sqrt(As128()));

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return From256(Vector256.Sqrt(As256()));

        return new(T.CreateTruncating(R.Sqrt(R.CreateSaturating(X))),
                   T.CreateTruncating(R.Sqrt(R.CreateSaturating(Y))),
                   T.CreateTruncating(R.Sqrt(R.CreateSaturating(Z))),
                   T.CreateTruncating(R.Sqrt(R.CreateSaturating(W))));
    }

    public override readonly string ToString() => $"({X}, {Y}, {Z}, {W})";

    public override readonly bool Equals(object? obj) => (obj is Vec4<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Vec4<T> other) => this == other;
}
