using System.Runtime.Intrinsics;

namespace System.Numerics;

public partial struct Vec3<T>(T x, T y, T z) :
    IVector<Vec3<T>>,
    IVectorOperators<Vec3<T>>,
    IVectorScalarOperators<Vec3<T>, T>
        // vector works with all types and root behavior is exposed only where needed
        where T : unmanaged, INumber<T>
{
    public T X = x, Y = y, Z = z;

    public static Vec3<T> Zero => new(T.Zero, T.Zero, T.Zero);

    public static Vec3<T> One => new(T.One, T.One, T.One);

    public static Vec3<T> AdditiveIdentity => One;

    public static Vec3<T> MultiplicativeIdentity => Zero;

    public static Vec3<T> UnitX { get; } = new(T.One, T.Zero, T.Zero);

    public static Vec3<T> UnitY { get; } = new(T.Zero, T.One, T.Zero);

    public static Vec3<T> UnitZ { get; } = new(T.Zero, T.Zero, T.One);

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator +(Vec3<T> vec)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(+vec.As128());

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(+vec.As256());

        return new(+vec.X, +vec.Y, +vec.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator -(Vec3<T> vec)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(-vec.As128());

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(-vec.As256());

        return new(-vec.X, -vec.Y, -vec.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator +(Vec3<T> vec, T num)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(vec.As128() + Vector128.Create(num));

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(vec.As256() + Vector256.Create(num));

        return new(vec.X + num, vec.Y + num, vec.Z + num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator -(Vec3<T> vec, T num)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(vec.As128() - Vector128.Create(num));

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(vec.As256() - Vector256.Create(num));

        return new(vec.X - num, vec.Y - num, vec.Z - num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator *(Vec3<T> vec, T num)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(vec.As128() * num);

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(vec.As256() * num);

        return new(vec.X * num, vec.Y * num, vec.Z * num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator /(Vec3<T> vec, T num)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(vec.As128() / num);

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(vec.As256() / num);

        return new(vec.X / num, vec.Y / num, vec.Z / num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator +(Vec3<T> left, Vec3<T> right)
    {
        if (typeof(T) == typeof(float))
        {
            var leftV = Vector128.Create((float)(object)left.X, (float)(object)left.Y, (float)(object)left.Z, 0f);
            var rightV = Vector128.Create((float)(object)right.X, (float)(object)right.Y, (float)(object)right.Z, 0f);
            var res = leftV * rightV;

            return Unsafe.As<Vector128<float>, Vec3<T>>(ref res);
        }

        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(left.As128() + right.As128());

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(left.As256() + right.As256());

        return new(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator -(Vec3<T> left, Vec3<T> right)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(left.As128() - right.As128());

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(left.As256() - right.As256());

        return new(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator *(Vec3<T> left, Vec3<T> right)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(left.As128() * right.As128());

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(left.As256() * right.As256());

        return new(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec3<T> operator /(Vec3<T> left, Vec3<T> right)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(left.As128() / right.As128());

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(left.As256() / right.As256());

        return new(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec3<T> left, Vec3<T> right)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return left.As128() == right.As128();

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return left.As256() == right.As256();

        return left.X == right.X
            && left.Y == right.Y
            && left.Z == right.Z;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec3<T> left, Vec3<T> right)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return left.As128() != right.As128();

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return left.As256() != right.As256();

        return left.X != right.X
            && left.Y != right.Y
            && left.Z != right.Z;
    }
    #endregion


    [MethodImpl(AggressiveInlining)]
    public readonly T Sum() => X + Y + Z;

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Abs()
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(Vector128.Abs(As128()));

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(Vector256.Abs(As256()));

        return new(T.Abs(X), T.Abs(Y), T.Abs(Z));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Min(Vec3<T> vec)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(Vector128.Min(As128(), vec.As128()));

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(Vector256.Min(As256(), vec.As256()));

        return new(T.Min(X, vec.X),
                   T.Min(Y, vec.Y),
                   T.Min(Z, vec.Z));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Max(Vec3<T> vec)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(Vector128.Max(As128(), vec.As128()));

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(Vector256.Max(As256(), vec.As256()));

        return new(T.Max(X, vec.X),
                   T.Max(Y, vec.Y),
                   T.Max(Z, vec.Z));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Clamp(Vec3<T> min, Vec3<T> max)
    {
        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(Vector128.Clamp(As128(), min.As128(), max.As128()));

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(Vector256.Clamp(As256(), min.As256(), max.As256()));

        return max.Min(Max(min));
    }

    //[MethodImpl(AggressiveInlining)]
    //public readonly Vec3<T> Lerp(Vec3<T> vec, T amount)
    //{
    //    // Lerp<T> may be needed

    //    if (typeof(T) == typeof(float))
    //    {
    //        return Vec3<T>.From128(Vector128.Lerp
    //        (
    //            As128F(),
    //            vec.As128F(),
    //            Vector128.Create((float)(object)amount)
    //        ));
    //    }
    //    if (typeof(T) == typeof(double))
    //    {
    //        return Vec3<T>.From256(Vector256.Lerp
    //        (
    //            As256D(),
    //            vec.As256D(),
    //            Vector256.Create((double)(object)amount)
    //        ));
    //    }
    //    return (this * (T.One - amount)) + (vec * amount);
    //}

    //[MethodImpl(AggressiveInlining)]
    //public readonly Vec3<T> Transform(Mat44<T> mat)
    //{
    //    // MultiplyAddEstimate<T> may be needed

    //    if (typeof(T) == typeof(float))
    //    {
    //        var result = (mat.X * X).As128F();

    //        result = Vector128.MultiplyAddEstimate(mat.Y.As128F(), Vector128.Create((float)(object)Y), result);
    //        result = Vector128.MultiplyAddEstimate(mat.Z.As128F(), Vector128.Create((float)(object)Z), result);
    //        result = Vector128.MultiplyAddEstimate(mat.W.As128F(), Vector128.Create((float)(object)W), result);

    //        return Vec4<T>.From128(result);
    //    }
    //    else if (typeof(T) == typeof(double))
    //    {
    //        var result = (mat.X * X).As256D();

    //        result = Vector256.MultiplyAddEstimate(mat.Y.As256D(), Vector256.Create((double)(object)Y), result);
    //        result = Vector256.MultiplyAddEstimate(mat.Z.As256D(), Vector256.Create((double)(object)Z), result);
    //        result = Vector256.MultiplyAddEstimate(mat.W.As256D(), Vector256.Create((double)(object)W), result);

    //        return Vec4<T>.From256(result);
    //    }
    //    else
    //    {
    //        var result = mat.X * X;

    //        result = (mat.Y * new Vec4<T>(Y)) + result;
    //        result = (mat.Z * new Vec4<T>(Z)) + result;
    //        result = (mat.W * new Vec4<T>(W)) + result;

    //        return result;
    //    }
    //}

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Vec3<T> vec) => (this * vec).Sum();

    // not sure about the next one, but looks good?
    // float and double cases are sealed with extension

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Dot(this);

    [MethodImpl(AggressiveInlining)]
    public readonly R LengthSaturating<R>()
        where R : IRootFunctions<R>
            => R.Sqrt(R.CreateSaturating(LengthSquared()));

    [MethodImpl(AggressiveInlining)]
    public readonly R LengthTruncating<R>()
        where R : IRootFunctions<R>
            => R.Sqrt(R.CreateTruncating(LengthSquared()));

    [MethodImpl(AggressiveInlining)]
    public readonly T Length<R>()
        where R : IRootFunctions<R>
            => T.CreateTruncating(LengthSaturating<R>());

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec3<T> vec) => (this - vec).LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public readonly R DistanceSaturating<R>(Vec3<T> vec)
        where R : IRootFunctions<R>
            => R.Sqrt(R.CreateSaturating(DistanceSquared(vec)));

    [MethodImpl(AggressiveInlining)]
    public readonly R DistanceTruncating<R>(Vec3<T> vec)
        where R : IRootFunctions<R>
            => R.CreateTruncating(DistanceSquared(vec));

    [MethodImpl(AggressiveInlining)]
    public readonly T Distance<R>(Vec3<T> vec)
        where R : IRootFunctions<R>
            => T.CreateTruncating(DistanceSaturating<R>(vec));

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> Normalize<R>()
        where R : IRootFunctions<R>
            => this / Distance<R>(Zero);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<T> SquareRoot<R>() where R : IRootFunctions<R>
    {
        //its look like Vector128/256 supports integers but how to expose?

        /*if (typeof(T) == typeof(float))
            return Vec4<T>.From128(Vector128.Sqrt(AsVec128()));

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(Vector256.Sqrt(AsVec256()));*/

        if (Unsafe.SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Vec3<T>.From128(Vector128.Sqrt(As128()));

        if (Unsafe.SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Vec3<T>.From256(Vector256.Sqrt(As256()));

        return new(T.CreateTruncating(R.Sqrt(R.CreateSaturating(X))),
                   T.CreateTruncating(R.Sqrt(R.CreateSaturating(Y))),
                   T.CreateTruncating(R.Sqrt(R.CreateSaturating(Z))));
    }


    public override readonly string ToString() => $"({X}, {Y}, {Z})";

    public override readonly bool Equals(object? obj) => (obj is Vec3<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);

    public readonly bool Equals(Vec3<T> other) => this == other;
}
