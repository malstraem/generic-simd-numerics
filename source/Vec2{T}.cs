namespace System.Numerics;

#pragma warning disable IDE0022, IDE0024

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
    public static bool operator ==(Vec2<T> a, Vec2<T> b) => Vec2.Equal(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec2<T> a, Vec2<T> b) => Vec2.NotEqual(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator >=(Vec2<T> a, Vec2<T> b) => Vec2.GreaterOrEqual(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator <=(Vec2<T> a, Vec2<T> b) => Vec2.LessOrEqual(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator >(Vec2<T> a, Vec2<T> b) => Vec2.Greater(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator <(Vec2<T> a, Vec2<T> b) => Vec2.Less(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator +(Vec2<T> v, T n) => Vec2.Add(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> v, T n) => Vec2.Subtract(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator *(Vec2<T> v, T n) => Vec2.Multiply(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator /(Vec2<T> v, T n) => Vec2.Divide(v, n);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> a, Vec2<T> b) => Vec2.Subtract(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator *(Vec2<T> a, Vec2<T> b) => Vec2.Multiply(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator /(Vec2<T> a, Vec2<T> b) => Vec2.Divide(a, b);
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly T Sum() => Vec2.Sum(this);

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Vec2<T> v) => Vec2.Dot(this, v);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Min(Vec2<T> v) => Vec2.Min(this, v);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Max(Vec2<T> v) => Vec2.Max(this, v);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Clamp(Vec2<T> min, Vec2<T> max) => Vec2.Clamp(this, min, max);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Lerp(Vec2<T> v, T am) => Vec2.Lerp(this, v, am);

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Vec2.LengthSquared(this);

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec2<T> v) => Vec2.DistanceSquared(this, v);

    public readonly bool Equals(Vec2<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Vec2<T> other) && this == other;

    public override readonly int GetHashCode() => HashCode.Combine(X, Y);

    public override readonly string ToString() => $"({X}, {Y})";
}
