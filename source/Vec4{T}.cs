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
    public static bool operator ==(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return a.As128() == b.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return a.As256() == b.As256();

        return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return a.As128() != b.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return a.As256() != b.As256();

        return a.X != b.X && a.Y != b.Y && a.Z != b.Z && a.W != b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator <=(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.LessThanOrEqualAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.LessThanOrEqualAll(a.As256(), b.As256());

        return a.X <= b.X && a.Y <= b.Y && a.Z <= b.Z && a.W <= b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator >=(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.GreaterThanOrEqualAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.GreaterThanOrEqualAll(a.As256(), b.As256());

        return a.X >= b.X && a.Y >= b.Y && a.Z >= b.Z && a.W >= b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator >(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.GreaterThanAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.GreaterThanAll(a.As256(), b.As256());

        return a.X > b.X && a.Y > b.Y && a.Z > b.Z && a.W > b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator <(Vec4<T> a, Vec4<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vector128.LessThanAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vector256.LessThanAll(a.As256(), b.As256());

        return a.X < b.X && a.Y < b.Y && a.Z < b.Z && a.W < b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> v, T n) => Vec4.Add(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> v, T n) => Vec4.Subtract(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> v, T n) => Vec4.Multiply(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> v, T n) => Vec4.Divide(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> a, Vec4<T> b) => Vec4.Add(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> a, Vec4<T> b) => Vec4.Subtract(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> a, Vec4<T> b) => Vec4.Multiply(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> a, Vec4<T> b) => Vec4.Divide(a, b);
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly T Sum() => Vec4.Sum(this);

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Vec4<T> v) => Vec4.Dot(this, v);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Min(Vec4<T> v) => Vec4.Min(this, v);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Max(Vec4<T> v) => Vec4.Max(this, v);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Clamp(Vec4<T> min, Vec4<T> max) => Vec4.Clamp(this, min, max);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Lerp(Vec4<T> v, T am) => (this * (T.One - am)) + (v * am);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Transform(Mat44<T> m) => Vec4.Transform(this, m);

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Vec4.LengthSquared(this);

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec4<T> v) => Vec4.DistanceSquared(this, v);

    public readonly bool Equals(Vec4<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Vec4<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public override readonly string ToString() => $"({X}, {Y}, {Z}, {W})";
}
