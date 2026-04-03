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

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator -(Quat<T> quat) => new(-quat.vec);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator +(Quat<T> left, Quat<T> right)
        => new(left.vec + right.vec);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator -(Quat<T> left, Quat<T> right)
        => new(left.vec - right.vec);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator *(Quat<T> quat, T num)
        => new(quat.vec * num);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator *(Quat<T> left, Quat<T> right)
    {
        if (typeof(T) == typeof(float))
        {
            unsafe
            {
                SkipInit<Quat<T>>(out var value);

                var rVec = right.As128F();

                Broadcast128F(left, out var xx, out var yy, out var zz, out var ww);

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

                var rVec = right.As256D();

                Broadcast256D(left, out var xx, out var yy, out var zz, out var ww);

                var result = rVec * ww;
                result = Vector256.MultiplyAddEstimate(Vector256.Shuffle(rVec * Vector256.Create(-1, 1, -1, 1f), Vector256.Create(3, 2, 1, 0)), xx, result);
                result = Vector256.MultiplyAddEstimate(Vector256.Shuffle(rVec * Vector256.Create(-1, -1, 1, 1f), Vector256.Create(2, 3, 0, 1)), yy, result);
                result = Vector256.MultiplyAddEstimate(Vector256.Shuffle(rVec * Vector256.Create(1, -1, -1, 1f), Vector256.Create(1, 0, 3, 2)), zz, result);

                Vector256.Store(result.As<double, T>(), (T*)&value);
                return value;
            }
        }
        return new((left.W * right.X) + (left.X * right.W) + (left.Y * right.Z) - (left.Z * right.Y),
                   (left.W * right.Y) - (left.X * right.Z) + (left.Y * right.W) + (left.Z * right.X),
                   (left.W * right.Z) + (left.X * right.Y) - (left.Y * right.X) + (left.Z * right.W),
                   (left.W * right.W) - (left.X * right.X) - (left.Y * right.Y) - (left.Z * right.Z));
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static bool operator ==(Quat<T> left, Quat<T> right)
        => left.vec == right.vec;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static bool operator !=(Quat<T> left, Quat<T> right)
        => left.vec != right.vec;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator /(Quat<T> left, Quat<T> right)
        => left * right.Inverse();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public readonly T Dot(Quat<T> q) => vec.Dot(q.vec);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public readonly T Length() => vec.Length();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public readonly T LengthSquared() => vec.LengthSquared();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public readonly Quat<T> Conjugate() => new(-X, -Y, -Z, W);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public readonly Quat<T> Normalize() => new(vec.Normalize());

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public readonly Quat<T> Inverse() => new(Conjugate().vec / LengthSquared());

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public readonly Quat<T> Lerp(Quat<T> quat, T amount)
    {
        if (Dot(quat) >= T.Zero)
            return new(vec.Lerp(quat.vec, amount).Normalize());

        return new(((vec * (T.One - amount)) - (quat.vec * amount)).Normalize());
    }

    public override readonly bool Equals(object? obj) => (obj is Quat<T> other) && Equals(other);

    public readonly bool Equals(Quat<T> other) => this == other;

    public override readonly int GetHashCode() => vec.GetHashCode();

    public override readonly string ToString() => vec.ToString();
}
