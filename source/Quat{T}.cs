namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Quat<T>(T x, T y, T z, T w) :
    IMultiplicativeIdentity<Quat<T>, Quat<T>>,

    IMultiplyOperators<Quat<T>, Quat<T>, Quat<T>>,
    IDivisionOperators<Quat<T>, Quat<T>, Quat<T>>,
    IAdditionOperators<Quat<T>, Quat<T>, Quat<T>>,
    ISubtractionOperators<Quat<T>, Quat<T>, Quat<T>>,

    IEqualityOperators<Quat<T>, Quat<T>, bool>,
    IEquatable<Quat<T>>
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    public T X = x, Y = y, Z = z, W = w;

    public Quat(Vec3<T> v, T w) : this(v.X, v.Y, v.Z, w) { }

    public static Quat<T> Zero { get; } = new(Vec3<T>.Zero, T.Zero);

    public static Quat<T> Identity { get; } = new(Vec3<T>.Zero, T.One);

    public readonly bool IsIdentity => this == Identity;

    static Quat<T> IMultiplicativeIdentity<Quat<T>, Quat<T>>.MultiplicativeIdentity => Identity;

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Quat<T> a, Quat<T> b) => Quat.Equal(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Quat<T> a, Quat<T> b) => Quat.NotEqual(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator -(Quat<T> q) => (-q.Vec4()).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator +(Quat<T> a, Quat<T> b) => Quat.Add(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator -(Quat<T> a, Quat<T> b) => Quat.Subtract(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator *(Quat<T> q, T n) => Quat.Multiply(q, n);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator /(Quat<T> q, T n) => Quat.Divide(q, n);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator *(Quat<T> a, Quat<T> b) => Quat.Multiply(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator /(Quat<T> a, Quat<T> b) => Quat.Divide(a, b);
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Quat<T> q) => Quat.Dot(this, q);

    [MethodImpl(AggressiveInlining)]
    public readonly T Length() => Quat.Length(this);

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Quat.LengthSquared(this);

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Conjugate() => Quat.Conjugate(this);

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Normalize() => Quat.Normalize(this);

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Inverse() => Quat.Inverse(this);

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Lerp(Quat<T> q, T am) => Quat.Lerp(this, q, am);

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Slerp(Quat<T> q, T am) => Quat.Slerp(this, q, am);

    public readonly Quat<TOther> As<TOther>()
        where TOther : unmanaged, IFloatingPoint<TOther>, IRootFunctions<TOther>, ITrigonometricFunctions<TOther>
            => Quat.As<T, TOther>(this);

    public readonly bool Equals(Quat<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Quat<T> other) && this == other;

    public override readonly int GetHashCode() => this.Vec4().GetHashCode();

    public override readonly string ToString() => this.Vec4().ToString();
}
