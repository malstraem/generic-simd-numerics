namespace System.Numerics;

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
        {
            unsafe
            {
                SkipInit<Quat<T>>(out var value);

                var rVec = b.As128F();

                Broadcast128F(a, out var xx, out var yy, out var zz, out var ww);

                var result = rVec * ww;
                result = Vector128.MultiplyAddEstimate(Vector128.Shuffle(rVec * Vector128.Create(-1, 1, -1, 1f), Vector128.Create(3, 2, 1, 0)), xx, result);
                result = Vector128.MultiplyAddEstimate(Vector128.Shuffle(rVec * Vector128.Create(-1, -1, 1, 1f), Vector128.Create(2, 3, 0, 1)), yy, result);
                result = Vector128.MultiplyAddEstimate(Vector128.Shuffle(rVec * Vector128.Create(1, -1, -1, 1f), Vector128.Create(1, 0, 3, 2)), zz, result);

                Vector128.Store(result.As<float, T>(), (T*)&value);
                return value;
            }
        }

        if (typeof(T) == typeof(double))
        {
            unsafe
            {
                SkipInit<Quat<T>>(out var value);

                var rVec = b.As256D();

                Broadcast256D(a, out var xx, out var yy, out var zz, out var ww);

                var result = rVec * ww;
                result = Vector256.MultiplyAddEstimate(Vector256.Shuffle(rVec * Vector256.Create(-1, 1, -1, 1f), Vector256.Create(3, 2, 1, 0)), xx, result);
                result = Vector256.MultiplyAddEstimate(Vector256.Shuffle(rVec * Vector256.Create(-1, -1, 1, 1f), Vector256.Create(2, 3, 0, 1)), yy, result);
                result = Vector256.MultiplyAddEstimate(Vector256.Shuffle(rVec * Vector256.Create(1, -1, -1, 1f), Vector256.Create(1, 0, 3, 2)), zz, result);

                Vector256.Store(result.As<double, T>(), (T*)&value);
                return value;
            }
        }
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
