namespace System.Numerics;

public partial struct Quat<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    private static readonly T two = T.One + T.One,
                              half = T.One / two;

    internal Vec4<T> vec;

    public readonly T X => vec.X;

    public readonly T Y => vec.Y;

    public readonly T Z => vec.Z;

    public readonly T W => vec.W;

    public Quat(T x, T y, T z, T w) => vec = new(x, y, z, w);

    public Quat(Vec3<T> vec, T w) => this.vec = new(vec.X, vec.Y, vec.Z, w);

    internal Quat(Vec4<T> vec) => this.vec = vec;

    public static Quat<T> Identity => new(Vec3<T>.Zero, T.One);

    public readonly bool IsIdentity => this == Identity;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator +(Quat<T> left, Quat<T> right)
        => new(left.vec + right.vec);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator /(Quat<T> left, Quat<T> right)
        => left * Quat<T>.Inverse(right);

    public static bool operator ==(Quat<T> left, Quat<T> right)
        => left.vec == right.vec;

    public static bool operator !=(Quat<T> left, Quat<T> right)
        => left.vec != right.vec;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> operator *(Quat<T> left, Quat<T> right)
    {
        if (typeof(T) == typeof(float))
        {
            unsafe
            {
                var rVec = right.As128F();

                Broadcast128F(left, out var xx, out var yy, out var zz, out var ww);

                var result = rVec * ww;
                result = Vector128.MultiplyAddEstimate(Vector128.Shuffle(rVec * Vector128.Create(-1, 1, -1, 1f), Vector128.Create(3, 2, 1, 0)), xx, result);
                result = Vector128.MultiplyAddEstimate(Vector128.Shuffle(rVec * Vector128.Create(-1, -1, 1, 1f), Vector128.Create(2, 3, 0, 1)), yy, result);
                result = Vector128.MultiplyAddEstimate(Vector128.Shuffle(rVec * Vector128.Create(1, -1, -1, 1f), Vector128.Create(1, 0, 3, 2)), zz, result);

                Vector128.Store(result.As<float, T>(), (T*)&right);
                return right;
            }
        }

        if (typeof(T) == typeof(double))
        {
            unsafe
            {
                var rVec = right.As256D();

                Broadcast256D(left, out var xx, out var yy, out var zz, out var ww);

                var result = rVec * ww;
                result = Vector256.MultiplyAddEstimate(Vector256.Shuffle(rVec * Vector256.Create(-1, 1, -1, 1f), Vector256.Create(3, 2, 1, 0)), xx, result);
                result = Vector256.MultiplyAddEstimate(Vector256.Shuffle(rVec * Vector256.Create(-1, -1, 1, 1f), Vector256.Create(2, 3, 0, 1)), yy, result);
                result = Vector256.MultiplyAddEstimate(Vector256.Shuffle(rVec * Vector256.Create(1, -1, -1, 1f), Vector256.Create(1, 0, 3, 2)), zz, result);

                Vector256.Store(result.As<double, T>(), (T*)&right);
                return right;
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

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Add(Quat<T> left, Quat<T> right) => left + right;

    public static Quat<T> Conjugate(Quat<T> value) => new(-value.X, -value.Y, -value.Z, value.W);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> CreateFromAxisAngle(Vec3<T> axis, T angle)
    {
        var (s, c) = T.SinCos(angle / two);
        return new(axis * s, c);
    }

    [Obsolete("vectorize?")]
    public static Quat<T> CreateFromRotationMatrix(Mat44<T> matrix)
    {
        var trace = matrix.X.X + matrix.Y.Y + matrix.Z.Z;

        T root, c;

        if (trace > T.Zero)
        {
            root = T.Sqrt(trace + T.One);
            c = half / root;

            return new(
                (matrix.Y.Z - matrix.Z.Y) * c,
                (matrix.Z.X - matrix.X.Z) * c,
                (matrix.X.Y - matrix.Y.X) * c,
                root * half);
        }

        if (matrix.X.X >= matrix.Y.Y && matrix.X.X >= matrix.Z.Z)
        {
            root = T.Sqrt(T.One + matrix.X.X - matrix.Y.Y - matrix.Z.Z);
            c = half / root;

            return new(
                root * half,
                (matrix.X.Y + matrix.Y.X) * c,
                (matrix.X.Z + matrix.Z.X) * c,
                (matrix.Y.Z - matrix.Z.Y) * c);
        }

        if (matrix.Y.Y >= matrix.Z.Z)
        {
            root = T.Sqrt(T.One + matrix.Y.Y - matrix.X.X - matrix.Z.Z);
            c = half / root;

            return new(
                (matrix.Y.X + matrix.X.Y) * c,
                root * half,
                (matrix.Z.Y + matrix.Y.Z) * c,
                (matrix.Z.X - matrix.X.Z) * c);
        }

        root = T.Sqrt(T.One + matrix.Z.Z - matrix.X.X - matrix.Y.Y);
        c = half / root;

        return new(
            (matrix.Z.X + matrix.X.Z) * c,
            (matrix.Z.Y + matrix.Y.Z) * c,
            root * half,
            (matrix.X.Y - matrix.Y.Z) * c);
    }

    public static Quat<T> CreateFromYawPitchRoll(T yaw, T pitch, T roll)
    {
        var (sr, cr) = T.SinCos(roll * half);
        var (sp, cp) = T.SinCos(pitch * half);
        var (sy, cy) = T.SinCos(yaw * half);

        return new(
            cy * sp * cr + sy * cp * sr,
            sy * cp * cr - cy * sp * sr,
            cy * cp * sr - sy * sp * cr,
            cy * cp * cr + sy * sp * sr);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Divide(Quat<T> left, Quat<T> right) => left / right;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static T Dot(Quat<T> left, Quat<T> right) => Vec4<T>.Dot(left.vec, right.vec);

    //  -1   (       a              -v       )
    // q   = ( -------------   ------------- )
    //       (  a^2 + |v|^2  ,  a^2 + |v|^2  )
    public static Quat<T> Inverse(Quat<T> value)
        => new(Quat<T>.Conjugate(value).vec / value.LengthSquared());

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

    public static Quat<T> Normalize(Quat<T> value) => new(value.vec.Normalize());

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Subtract(Quat<T> left, Quat<T> right) => left - right;

    public override readonly bool Equals(object? obj) => (obj is Quat<T> other) && Equals(other);

    public readonly bool Equals(Quat<T> other) => this == other;

    public override readonly int GetHashCode() => vec.GetHashCode();

    public readonly T Length() => vec.Length();

    public readonly T LengthSquared() => vec.LengthSquared();

    public override readonly string ToString() => vec.ToString();
}
