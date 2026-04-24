namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Vec4<T>(T x, T y, T z, T w) :
    IVector<Vec4<T>, T>,
    IVectorScalarOperators<Vec4<T>, T>
        where T : unmanaged, INumber<T> // real number behavior is exposed only where needed
{
    public T X = x, Y = y, Z = z, W = w;

    public Vec4(T n) : this(n, n, n, n) { }

    public static Vec4<T> One { get; } = new(T.One);

    public static Vec4<T> Zero { get; } = new(T.Zero);

    public static Vec4<T> UnitX { get; } = new(T.One, T.Zero, T.Zero, T.Zero);

    public static Vec4<T> UnitY { get; } = new(T.Zero, T.One, T.Zero, T.Zero);

    public static Vec4<T> UnitZ { get; } = new(T.Zero, T.Zero, T.One, T.Zero);

    public static Vec4<T> UnitW { get; } = new(T.Zero, T.Zero, T.Zero, T.One);

    static Vec4<T> IAdditiveIdentity<Vec4<T>, Vec4<T>>.AdditiveIdentity => Zero;

    static Vec4<T> IMultiplicativeIdentity<Vec4<T>, Vec4<T>>.MultiplicativeIdentity => One;

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return (+v.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return (+v.As256()).Vec4();

        return new(+v.X, +v.Y, +v.Z, +v.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return (-v.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return (-v.As256()).Vec4();

        return new(-v.X, -v.Y, -v.Z, -v.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> v, T n)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return (v.As128() + Vector128.Create(n)).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return (v.As256() + Vector256.Create(n)).Vec4();

        return new(v.X + n, v.Y + n, v.Z + n, v.W + n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> v, T n)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return (v.As128() - Vector128.Create(n)).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return (v.As256() - Vector256.Create(n)).Vec4();

        return new(v.X - n, v.Y - n, v.Z - n, v.W - n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> v, T n)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return (v.As128() * n).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return (v.As256() * n).Vec4();

        return new(v.X * n, v.Y * n, v.Z * n, v.W * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> v, T n)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return (v.As128() / n).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return (v.As256() / n).Vec4();

        return new(v.X / n, v.Y / n, v.Z / n, v.W / n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return (a.As128() + b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return (a.As256() + b.As256()).Vec4();

        return new(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return (a.As128() - b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return (a.As256() - b.As256()).Vec4();

        return new(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
    }

    // use dot product instead element wise is personal choice
    [MethodImpl(AggressiveInlining)]
    public static T operator *(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.Dot(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.Dot(a.As256(), b.As256());

        return a.ElementMultiply(b).Sum();
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return a.As128() == b.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return a.As256() == b.As256();

        return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return a.As128() != b.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return a.As256() != b.As256();

        return a.X != b.X && a.Y != b.Y && a.Z != b.Z && a.W != b.W;
    }
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> ElementMultiply(Vec4<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return (this.As128() * v.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return (this.As256() * v.As256()).Vec4();

        return new(X * v.X, Y * v.Y, Z * v.Z, W * v.W);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> ElementDivide(Vec4<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return (this.As128() / v.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return (this.As256() / v.As256()).Vec4();

        return new(X / v.X, Y / v.Y, Z / v.Z, W / v.W);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly T Sum()
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.Sum(this.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.Sum(this.As256());

        return X + Y + Z + W;
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Abs()
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.Abs(this.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.Abs(this.As256()).Vec4();

        return new(T.Abs(X), T.Abs(Y), T.Abs(Z), T.Abs(W));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Min(Vec4<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.Min(this.As128(), v.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.Min(this.As256(), v.As256()).Vec4();

        return new(T.Min(X, v.X), T.Min(Y, v.Y), T.Min(Z, v.Z), T.Min(W, v.W));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Max(Vec4<T> v)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.Max(this.As128(), v.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.Max(this.As256(), v.As256()).Vec4();

        return new(T.Max(X, v.X), T.Max(Y, v.Y), T.Max(Z, v.Z), T.Max(W, v.W));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Clamp(Vec4<T> min, Vec4<T> max)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.Clamp(this.As128(), min.As128(), max.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.Clamp(this.As256(), min.As256(), max.As256()).Vec4();

        return max.Min(Max(min));
    }

    // intrinsic Lerp<T> should exist, isn't?
    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Lerp(Vec4<T> v, T am) => (this * (T.One - am)) + (v * am);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Transform(Mat44<T> m)
    {
        var v = m.X * X;

        v = m.Y.MultiplyAdd(Y, v);
        v = m.Z.MultiplyAdd(Z, v);
        v = m.W.MultiplyAdd(W, v);

        return v;
    }

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => this * this;

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec4<T> v) => (this - v).LengthSquared();

    // not sure about the truncate/saturate
    // float and double are sealed using extensions

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
    public readonly R DistanceSaturating<R>(Vec4<T> v)
        where R : IRootFunctions<R>
            => R.Sqrt(R.CreateSaturating(DistanceSquared(v)));

    [MethodImpl(AggressiveInlining)]
    public readonly R DistanceTruncating<R>(Vec4<T> v)
        where R : IRootFunctions<R>
            => R.CreateTruncating(DistanceSquared(v));

    [MethodImpl(AggressiveInlining)]
    public readonly T Distance<R>(Vec4<T> v)
        where R : IRootFunctions<R>
            => T.CreateTruncating(DistanceSaturating<R>(v));

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Normalize<R>()
        where R : INumber<R>, IRootFunctions<R>
            => this / Length<R>();

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> SquareRoot<R>() where R : IRootFunctions<R>
    {
        // looks like intrinsics works with integers
        // but maybe it would be better to make Vec{N}<T>.SquareRoot<R> return Vec{N}<R>?

        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.Sqrt(this.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.Sqrt(this.As256()).Vec4();

        return new(T.CreateTruncating(R.Sqrt(R.CreateTruncating(X))),
                   T.CreateTruncating(R.Sqrt(R.CreateTruncating(Y))),
                   T.CreateTruncating(R.Sqrt(R.CreateTruncating(Z))),
                   T.CreateTruncating(R.Sqrt(R.CreateTruncating(W))));
    }

    public readonly bool Equals(Vec4<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Vec4<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public override readonly string ToString() => $"({X}, {Y}, {Z}, {W})";
}
