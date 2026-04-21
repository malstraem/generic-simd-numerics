namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Quat<T>(T x, T y, T z, T w) :
    IMultiplicativeIdentity<Quat<T>, Quat<T>>,

    IMultiplyOperators<Quat<T>, Quat<T>, Quat<T>>,
    IDivisionOperators<Quat<T>, Quat<T>, Quat<T>>,
    IAdditionOperators<Quat<T>, Quat<T>, Quat<T>>,
    ISubtractionOperators<Quat<T>, Quat<T>, Quat<T>>,

    IEqualityOperators<Quat<T>, Quat<T>, bool>
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    public T X = x, Y = y, Z = z, W = w;

    [Obsolete("vectorize")]
    public Quat(Vec3<T> v, T w) : this(v.X, v.Y, v.Z, w) { }

    public static Quat<T> Identity => new(Vec3<T>.Zero, T.One);

    public readonly bool IsIdentity => this == Identity;

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

        var c = b * a.W;
        var d = b * a.X;
        var e = b * a.Y;
        var f = b * a.Z;

        return new(c.X + d.W + e.Z - f.Y,
                   c.Y - d.Z + e.W + f.X,
                   c.Z + d.Y - e.X + f.W,
                   c.W - d.X - e.Y - f.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator /(Quat<T> a, Quat<T> b) => a * b.Inverse();

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

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Conjugate()
    {
        if (typeof(T) == typeof(float) && Vector128<T>.IsSupported)
        {
            var xmm = this.Vec4().As128();
            xmm *= Vector128.Create(-1f, -1f, -1f, 1f).As<float, T>();
            return xmm.Vec4().Quat();
        }

        if (typeof(T) == typeof(double) && Vector256<T>.IsSupported)
        {
            var ymm = this.Vec4().As256();
            ymm *= Vector256.Create(-1d, -1d, -1d, 1d).As<double, T>();
            return ymm.Vec4().Quat();
        }
        return new(-X, -Y, -Z, W);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Normalize() => this.Vec4().Normalize().Quat();

    [Obsolete("reciprocal?")]
    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Inverse()
    {
        var ls = LengthSquared();

        if (typeof(T) == typeof(float) && Vector128<T>.IsSupported)
        {
            var lsv = Vector128.Create(ls);

            var compare = Vector128.LessThanOrEqual(lsv, Vector128.Create(T.CreateChecked(1.192092896e-7f)));

            return Vector128.AndNot(Conjugate().Vec4().As128() / lsv, compare).Vec4().Quat();
        }

        // todo 256 way with epsilon

        return (Conjugate().Vec4() / ls).Quat();
    }

    [Obsolete("not sure")]
    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Lerp(Quat<T> q, T am)
    {
        var v = Dot(q) >= T.Zero ? this.Vec4().Lerp(q.Vec4(), am)
                               : ((this.Vec4() * (T.One - am)) - (q.Vec4() * am));

        return v.Normalize().Quat();
    }

    public readonly bool Equals(Quat<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Quat<T> other) && Equals(other);

    public override readonly int GetHashCode() => this.Vec4().GetHashCode();

    public override readonly string ToString() => this.Vec4().ToString();
}
