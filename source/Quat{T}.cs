namespace System.Numerics;

public partial struct Quat<T>(Vec4<T> vec)
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    internal Vec4<T> vec = vec;

    public readonly T X => vec.X;

    public readonly T Y => vec.Y;

    public readonly T Z => vec.Z;

    public readonly T W => vec.W;

    public Quat(T x, T y, T z, T w) : this(new(x, y, z, w)) { }

    public Quat(Vec3<T> vec, T w) : this(new(vec.X, vec.Y, vec.Z, w)) { }

    public static Quat<T> Identity => new(Vec3<T>.Zero, T.One);

    public readonly bool IsIdentity => this == Identity;

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator -(Quat<T> quat) => new(-quat.vec);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator *(Quat<T> quat, T n) => new(quat.vec * n);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator +(Quat<T> a, Quat<T> b) => new(a.vec + b.vec);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator -(Quat<T> a, Quat<T> b) => new(a.vec - b.vec);

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
    public static bool operator ==(Quat<T> a, Quat<T> b) => a.vec == b.vec;

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Quat<T> a, Quat<T> b) => a.vec != b.vec;

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> operator /(Quat<T> a, Quat<T> b) => a * b.Inverse();

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Quat<T> q) => vec * q.vec;

    [MethodImpl(AggressiveInlining)]
    public readonly T Length() => vec.Length();

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => vec.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Conjugate() => new(-X, -Y, -Z, W);

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Normalize()
    {
        //return new(vec.Normalize());

        var dot = vec * vec;

        var c = Vec4<T>.One / T.Sqrt(dot);

        return new(vec.ElementMultiply(c));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Quat<T> Inverse() => new(Conjugate().vec / LengthSquared());

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public readonly Quat<T> Lerp(Quat<T> quat, T am)
    {
        if (Dot(quat) >= T.Zero)
            return new(vec.Lerp(quat.vec, am).Normalize());

        return new(((vec * (T.One - am)) - (quat.vec * am)).Normalize());
    }

    public override readonly bool Equals(object? obj) => (obj is Quat<T> other) && Equals(other);

    public readonly bool Equals(Quat<T> other) => this == other;

    public override readonly int GetHashCode() => vec.GetHashCode();

    public override readonly string ToString() => vec.ToString();
}
