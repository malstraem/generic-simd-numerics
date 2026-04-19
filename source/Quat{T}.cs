namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Quat<T>(T x, T y, T z, T w) :
    IAdditiveIdentity<Quat<T>, Quat<T>>,
    IMultiplicativeIdentity<Quat<T>, Quat<T>>,

    IMultiplyOperators<Quat<T>, Quat<T>, Quat<T>>,
    IDivisionOperators<Quat<T>, Quat<T>, Quat<T>>,
    IAdditionOperators<Quat<T>, Quat<T>, Quat<T>>,
    ISubtractionOperators<Quat<T>, Quat<T>, Quat<T>>,

    IEqualityOperators<Quat<T>, Quat<T>, bool>
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    public T X = x, Y = y, Z = z, W = w;

    public Quat(Vec3<T> v, T w) : this(v.X, v.Y, v.Z, w) { }

    public static Quat<T> Identity => new(Vec3<T>.Zero, T.One);

    public readonly bool IsIdentity => this == Identity;

    static Quat<T> IAdditiveIdentity<Quat<T>, Quat<T>>.AdditiveIdentity => Identity;

    static Quat<T> IMultiplicativeIdentity<Quat<T>, Quat<T>>.MultiplicativeIdentity => Identity;

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator *(Quat<T> q, T n) => (q.Vec4() * n).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator +(Quat<T> a, Quat<T> b) => (a.Vec4() + b.Vec4()).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator -(Quat<T> a, Quat<T> b) => (a.Vec4() - b.Vec4()).Quat();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator *(Quat<T> a, Quat<T> b)
    {
        if (typeof(T) == typeof(float) && Vector128<T>.IsSupported)
            return Multiply128(a, b);

        if (typeof(T) == typeof(double) && Vector256<T>.IsSupported)
            return Multiply256(a, b);

        return new((a.W * b.X) + (a.X * b.W) + (a.Y * b.Z) - (a.Z * b.Y),
                   (a.W * b.Y) - (a.X * b.Z) + (a.Y * b.W) + (a.Z * b.X),
                   (a.W * b.Z) + (a.X * b.Y) - (a.Y * b.X) + (a.Z * b.W),
                   (a.W * b.W) - (a.X * b.X) - (a.Y * b.Y) - (a.Z * b.Z));
    }

    [Obsolete("vectorize with permute")]
    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator /(Quat<T> a, Quat<T> b)
    {
        //T w = a.W;

        //a.W = T.Zero;

        b *= T.One / b.LengthSquared();
        b = b.Conjugate();

        return a * b;

        //T dot = a.Vec4() * b.Vec4(),
        //  x = (a.Y * b.Z) - (a.Z * b.Y),
        //  y = (a.Z * b.X) - (a.X * b.Z),
        //  z = (a.X * b.Y) - (a.Y * b.X);

        //a.W = w;
        //a *= b.W;

        //a.X += (b.X * w) + x;
        //a.Y += (b.Y * w) + y;
        //a.Z += (b.Z * w) + z;
        //a.W -= dot;

        //return a;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Quat<T> a, Quat<T> b) => a.Vec4() == b.Vec4();

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Quat<T> a, Quat<T> b) => a.Vec4() != b.Vec4();

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Quat<T> q) => this.Vec4() * q.Vec4();

    [MethodImpl(AggressiveInlining)]
    public readonly T Length() => this.Vec4().Length();

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => this.Vec4().LengthSquared();

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Conjugate() => new(-X, -Y, -Z, W);

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Normalize() => this.Vec4().Normalize().Quat();

    [Obsolete("vectorize with permute (and reciprocal)?")]
    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Inverse() => (this.Vec4() * (T.One / LengthSquared())).Quat().Conjugate();

    [Obsolete("more clear?")]
    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Lerp(Quat<T> q, T am)
    {
        if (Dot(q) >= T.Zero)
            return this.Vec4().Lerp(q.Vec4(), am).Normalize().Quat();

        return ((this.Vec4() * (T.One - am)) - (q.Vec4() * am)).Normalize().Quat();
    }

    public readonly bool Equals(Quat<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Quat<T> other) && Equals(other);

    public override readonly int GetHashCode() => this.Vec4().GetHashCode();

    public override readonly string ToString() => this.Vec4().ToString();
}
