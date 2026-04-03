namespace System.Numerics;

public partial struct Quat<T>(Vec4<T> vec)
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    private static readonly T two = T.One + T.One;

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
    public static Quat<T> operator +(Quat<T> left, Quat<T> right)
        => new(left.vec + right.vec);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator /(Quat<T> left, Quat<T> right)
        => left * Quat<T>.Inverse(right);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static bool operator ==(Quat<T> left, Quat<T> right)
        => left.vec == right.vec;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static bool operator !=(Quat<T> left, Quat<T> right)
        => left.vec != right.vec;

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

        return new(
            left.W * right.X + left.X * right.W + left.Y * right.Z - left.Z * right.Y,
            left.W * right.Y - left.X * right.Z + left.Y * right.W + left.Z * right.X,
            left.W * right.Z + left.X * right.Y - left.Y * right.X + left.Z * right.W,
            left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator *(Quat<T> quat, T value)
        => new(quat.vec * value);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator -(Quat<T> left, Quat<T> right)
        => new(left.vec - right.vec);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator -(Quat<T> value) => new(-value.vec);

    public readonly T Length() => vec.Length();

    public readonly T LengthSquared() => vec.LengthSquared();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Add(Quat<T> left, Quat<T> right) => left + right;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Conjugate(Quat<T> value) => new(-value.X, -value.Y, -value.Z, value.W);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> CreateFromAxisAngle(Vec3<T> axis, T angle)
    {
        var (s, c) = T.SinCos(angle / two);
        return new(axis * s, c);
    }

    [Obsolete("vectorize?")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> CreateFromRotationMatrix(Mat44<T> m)
    {
        T root, c, trace = m.X.X + m.Y.Y + m.Z.Z;

        if (trace > T.Zero)
        {
            root = T.Sqrt(trace + T.One);
            c = T.One / (two * root);

            return new((m.Y.Z - m.Z.Y) * c,
                       (m.Z.X - m.X.Z) * c,
                       (m.X.Y - m.Y.X) * c,
                        root / two);
        }

        if (m.X.X >= m.Y.Y && m.X.X >= m.Z.Z)
        {
            root = T.Sqrt(T.One + m.X.X - m.Y.Y - m.Z.Z);
            c = T.One / (two * root);

            return new(
                root / two,
                (m.X.Y + m.Y.X) * c,
                (m.X.Z + m.Z.X) * c,
                (m.Y.Z - m.Z.Y) * c);
        }

        if (m.Y.Y >= m.Z.Z)
        {
            root = T.Sqrt(T.One + m.Y.Y - m.X.X - m.Z.Z);
            c = T.One / (two * root);

            return new(
                (m.Y.X + m.X.Y) * c,
                root / two,
                (m.Z.Y + m.Y.Z) * c,
                (m.Z.X - m.X.Z) * c);
        }

        root = T.Sqrt(T.One + m.Z.Z - m.X.X - m.Y.Y);
        c = T.One / (two * root);

        return new(
            (m.Z.X + m.X.Z) * c,
            (m.Z.Y + m.Y.Z) * c,
            root / two,
            (m.X.Y - m.Y.Z) * c);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> CreateFromYawPitchRoll(T yaw, T pitch, T roll)
    {
        var (sr, cr) = T.SinCos(roll / two);
        var (sp, cp) = T.SinCos(pitch / two);
        var (sy, cy) = T.SinCos(yaw / two);

        return new(cy * sp * cr + sy * cp * sr,
                   sy * cp * cr - cy * sp * sr,
                   cy * cp * sr - sy * sp * cr,
                   cy * cp * cr + sy * sp * sr);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Divide(Quat<T> left, Quat<T> right) => left / right;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static T Dot(Quat<T> left, Quat<T> right) => Vec4<T>.Dot(left.vec, right.vec);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Inverse(Quat<T> value)
        => new(Quat<T>.Conjugate(value).vec / value.LengthSquared());

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Lerp(Quat<T> left, Quat<T> right, T amount)
    {
        if (Quat<T>.Dot(left, right) >= T.Zero)
            return new(Vec4<T>.Lerp(left.vec, right.vec, amount).Normalize());

        return new((left.vec * (T.One - amount) - right.vec * amount).Normalize());
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Multiply(Quat<T> left, Quat<T> right) => left * right;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Multiply(Quat<T> left, T right) => left * right;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Negate(Quat<T> value) => -value;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Normalize(Quat<T> value) => new(value.vec.Normalize());

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Subtract(Quat<T> left, Quat<T> right) => left - right;

    public override readonly bool Equals(object? obj) => (obj is Quat<T> other) && Equals(other);

    public readonly bool Equals(Quat<T> other) => this == other;

    public override readonly int GetHashCode() => vec.GetHashCode();

    public override readonly string ToString() => vec.ToString();
}
