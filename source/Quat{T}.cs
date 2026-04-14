namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Quat<T>(T x, T y, T z, T w)
    where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    public T X = x, Y = y, Z = z, W = w;

    public Quat(Vec3<T> v, T w) : this(v.X, v.Y, v.Z, w) { }

    public static Quat<T> Identity => new(Vec3<T>.Zero, T.One);

    public readonly bool IsIdentity => this == Identity;

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator -(Quat<T> q) => (-q.Vec4()).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator *(Quat<T> q, T n) => (q.Vec4() * n).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator +(Quat<T> a, Quat<T> b) => (a.Vec4() + b.Vec4()).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator -(Quat<T> a, Quat<T> b) => (a.Vec4() - b.Vec4()).Quat();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator *(Quat<T> a, Quat<T> b)
    {
        if (typeof(T) == typeof(float))
            return Multiply128(a, b);

        if (typeof(T) == typeof(double))
            return Multiply256(a, b);

        return new((a.W * b.X) + (a.X * b.W) + (a.Y * b.Z) - (a.Z * b.Y),
                   (a.W * b.Y) - (a.X * b.Z) + (a.Y * b.W) + (a.Z * b.X),
                   (a.W * b.Z) + (a.X * b.Y) - (a.Y * b.X) + (a.Z * b.W),
                   (a.W * b.W) - (a.X * b.X) - (a.Y * b.Y) - (a.Z * b.Z));
    }

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator /(Quat<T> a, Quat<T> b) => a * b.Inverse();

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Quat<T> a, Quat<T> b) => a.Vec4() == b.Vec4();

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Quat<T> a, Quat<T> b) => a.Vec4() != b.Vec4();

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Quat<T> q) => Vec4() * q.Vec4();

    [MethodImpl(AggressiveInlining)]
    public readonly T Length() => Vec4().Length();

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Vec4().LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Conjugate() => new(-X, -Y, -Z, W);

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Normalize()
    {
        //return Vec4().Normalize().Quat();

        var v = Vec4();

        var dot = v * v;

        var c = Vec4<T>.One / T.Sqrt(dot);

        return v.ElementMultiply(c).Quat();
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Inverse() => (Conjugate().Vec4() / LengthSquared()).Quat();

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Lerp(Quat<T> q, T am)
    {
        if (Dot(q) >= T.Zero)
            return Vec4().Lerp(q.Vec4(), am).Normalize().Quat();

        return ((Vec4() * (T.One - am)) - (q.Vec4() * am)).Normalize().Quat();
    }

    public readonly bool Equals(Quat<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Quat<T> other) && Equals(other);

    public override readonly int GetHashCode() => Vec4().GetHashCode();

    public override readonly string ToString() => Vec4().ToString();
}
