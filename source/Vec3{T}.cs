namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public struct Vec3<T>(T x, T y, T z) :
    IVector<Vec3<T>, T>,
    IVectorScalarOperators<Vec3<T>, T>
        where T : unmanaged, INumber<T> // real number behavior is exposed only where needed
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
    public static bool operator ==(Vec3<T> a, Vec3<T> b) => Vec3.Equal(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec3<T> a, Vec3<T> b) => Vec3.NotEqual(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator >=(Vec3<T> a, Vec3<T> b) => Vec3.GreaterOrEqual(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator <=(Vec3<T> a, Vec3<T> b) => Vec3.LessOrEqual(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator >(Vec3<T> a, Vec3<T> b) => Vec3.Greater(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator <(Vec3<T> a, Vec3<T> b) => Vec3.Less(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator +(Vec3<T> v, T n) => Vec3.Add(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator -(Vec3<T> v, T n) => Vec3.Subtract(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator *(Vec3<T> v, T n) => Vec3.Multiply(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator /(Vec3<T> v, T n) => Vec3.Divide(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator +(Vec3<T> a, Vec3<T> b) => Vec3.Add(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator -(Vec3<T> a, Vec3<T> b) => Vec3.Subtract(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator *(Vec3<T> a, Vec3<T> b) => Vec3.Multiply(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator /(Vec3<T> a, Vec3<T> b) => Vec3.Divide(a, b);
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly T Sum() => Vec3.Sum(this);

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Vec3<T> v) => Vec3.Dot(this, v);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Min(Vec3<T> v) => Vec3.Min(this, v);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Max(Vec3<T> v) => Vec3.Max(this, v);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Clamp(Vec3<T> min, Vec3<T> max) => Vec3.Clamp(this, min, max);

    // VectorNNN.Lerp<T> should exist, isn't?
    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Lerp(Vec3<T> v, T am) => Vec3.Lerp(this, v, am);

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Vec3.LengthSquared(this);

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec3<T> v) => Vec3.DistanceSquared(this, v);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Cross(Vec3<T> v) => Vec3.Cross(this, v);

    public readonly Vec3<TOther> As<TOther>()
        where TOther : unmanaged, INumber<TOther>
            => Vec3.As<T, TOther>(this);

    public readonly bool Equals(Vec3<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Vec3<T> other) && this == other;

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

    public override readonly string ToString() => $"({X}, {Y}, {Z})";
}
