using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

using static System.Runtime.CompilerServices.Unsafe;

namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Vec2<T>(T x, T y) :
    IVector<Vec2<T>>,
    IVectorOperators<Vec2<T>>,
    IVectorScalarOperators<Vec2<T>, T>
        // vector works with all types and root behavior is exposed only where needed
        where T : unmanaged, INumber<T>
{
    public T X = x, Y = y;

    public Vec2(T num) : this(num, num) { }

    public static Vec2<T> Zero { get; } = new(T.Zero);

    public static Vec2<T> One { get; } = new(T.One, T.One);

    static Vec2<T> IAdditiveIdentity<Vec2<T>, Vec2<T>>.AdditiveIdentity => Zero;

    static Vec2<T> IMultiplicativeIdentity<Vec2<T>, Vec2<T>>.MultiplicativeIdentity => One;

    public static Vec2<T> UnitX { get; } = new(T.One, T.Zero);

    public static Vec2<T> UnitY { get; } = new(T.Zero, T.One);

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator +(Vec2<T> vec)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(+vec.As64());

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(+vec.As128());

        return new(+vec.X, +vec.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> vec)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(-vec.As64());

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(-vec.As128());

        return new(-vec.X, -vec.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator +(Vec2<T> vec, T num)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(vec.As64() + Vector64.Create(num));

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(vec.As128() + Vector128.Create(num));

        return new(vec.X + num, vec.Y + num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> vec, T num)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(vec.As64() - Vector64.Create(num));

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(vec.As128() - Vector128.Create(num));

        return new(vec.X - num, vec.Y - num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator *(Vec2<T> vec, T num)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(vec.As64() * num);

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(vec.As128() * num);

        return new(vec.X * num, vec.Y * num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator /(Vec2<T> vec, T num)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(vec.As64() / num);

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(vec.As128() / num);

        return new(vec.X / num, vec.Y / num);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator +(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(left.As64() + right.As64());

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(left.As128() + right.As128());

        return new(left.X + right.X, left.Y + right.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator -(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(left.As64() - right.As64());

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(left.As128() - right.As128());

        return new(left.X - right.X, left.Y - right.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator *(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(left.As64() * right.As64());

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(left.As128() * right.As128());

        return new(left.X * right.X, left.Y * right.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator /(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(left.As64() / right.As64());

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(left.As128() / right.As128());

        return new(left.X / right.X, left.Y / right.Y);
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return left.As64() == right.As64();

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return left.As128() == right.As128();

        return left.X == right.X && left.Y == right.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec2<T> left, Vec2<T> right)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return left.As64() != right.As64();

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return left.As128() != right.As128();

        return left.X != right.X && left.Y != right.Y;
    }
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly T Sum()
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return Vector64.Sum(As64());

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return Vector128.Sum(As128());

        return X + Y;
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Abs()
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(Vector64.Abs(As64()));

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(Vector128.Abs(As128()));

        return new(T.Abs(X), T.Abs(Y));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Min(Vec2<T> vec)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(Vector64.Min(As64(), vec.As64()));

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(Vector128.Min(As128(), vec.As128()));

        return new(T.Min(X, vec.X), T.Min(Y, vec.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Max(Vec2<T> vec)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(Vector64.Max(As64(), vec.As64()));

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(Vector128.Max(As128(), vec.As128()));

        return new(T.Max(X, vec.X), T.Max(Y, vec.Y));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Clamp(Vec2<T> min, Vec2<T> max)
    {
        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(Vector64.Clamp(As64(), min.As64(), max.As64()));

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(Vector128.Clamp(As128(), min.As128(), max.As128()));

        return max.Min(Max(min));
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Lerp(Vec2<T> vec, T amount)
    {
        // Lerp<T> may be needed

        /*if (typeof(T) == typeof(float))
        {
            return From64(Vector64.Lerp
            (
                As64F(),
                vec.As64F(),
                Vector64.Create((float)(object)amount)
            ));
        }
        if (typeof(T) == typeof(double))
        {
            return From128(Vector128.Lerp
            (
                As128D(),
                vec.As128D(),
                Vector128.Create((double)(object)amount)
            ));
        }*/
        return (this * (T.One - amount))
             + (vec * amount);
    }

    /*[MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Transform(Mat44<T> mat)
    {
        // MultiplyAddEstimate<T> may be needed

        if (typeof(T) == typeof(float))
        {
            var result = (mat.X * X).As128F();

            result = Vector128.MultiplyAddEstimate(mat.Y.As128F(), Vector128.Create((float)(object)Y), result);
            result = Vector128.MultiplyAddEstimate(mat.Z.As128F(), Vector128.Create((float)(object)Z), result);
            result = Vector128.MultiplyAddEstimate(mat.W.As128F(), Vector128.Create((float)(object)W), result);

            return Vec2<T>.From64(result);
        }
        else if (typeof(T) == typeof(double))
        {
            var result = (mat.X * X).As256D();

            result = Vector256.MultiplyAddEstimate(mat.Y.As256D(), Vector256.Create((double)(object)Y), result);
            result = Vector256.MultiplyAddEstimate(mat.Z.As256D(), Vector256.Create((double)(object)Z), result);
            result = Vector256.MultiplyAddEstimate(mat.W.As256D(), Vector256.Create((double)(object)W), result);

            return Vec2<T>.From64(result);
        }
        else
        {
            var result = mat.X * X;

            result = (mat.Y * new Vec2<T>(Y)) + result;
            result = (mat.Z * new Vec2<T>(Z)) + result;
            result = (mat.W * new Vec2<T>(W)) + result;

            return result;
        }
    }*/

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Vec2<T> vec) => (this * vec).Sum();

    // not sure about the next one, but looks good?
    // float and double cases are sealed with extension

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Dot(this);

    [MethodImpl(AggressiveInlining)]
    public readonly TRoot LengthSaturating<TRoot>()
        where TRoot : IRootFunctions<TRoot>
            => TRoot.Sqrt(TRoot.CreateSaturating(LengthSquared()));

    [MethodImpl(AggressiveInlining)]
    public readonly TRoot LengthTruncating<TRoot>()
        where TRoot : IRootFunctions<TRoot>
            => TRoot.Sqrt(TRoot.CreateTruncating(LengthSquared()));

    [MethodImpl(AggressiveInlining)]
    public readonly T Length<TRoot>()
        where TRoot : IRootFunctions<TRoot>
            => T.CreateTruncating(LengthSaturating<TRoot>());

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec2<T> vec) => (this - vec).LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public readonly TRoot DistanceSaturating<TRoot>(Vec2<T> vec)
        where TRoot : IRootFunctions<TRoot>
            => TRoot.Sqrt(TRoot.CreateSaturating(DistanceSquared(vec)));

    [MethodImpl(AggressiveInlining)]
    public readonly TRoot DistanceTruncating<TRoot>(Vec2<T> vec)
        where TRoot : IRootFunctions<TRoot>
            => TRoot.CreateTruncating(DistanceSquared(vec));

    [MethodImpl(AggressiveInlining)]
    public readonly T Distance<TRoot>(Vec2<T> vec)
        where TRoot : IRootFunctions<TRoot>
            => T.CreateTruncating(DistanceSaturating<TRoot>(vec));

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> Normalize<TRoot>()
        where TRoot : IRootFunctions<TRoot>
            => this / Distance<TRoot>(Zero);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<T> SquareRoot<TRoot>() where TRoot : IRootFunctions<TRoot>
    {
        //its look like Vector128/256 supports integers but how to expose?

        /*if (typeof(T) == typeof(float))
            return Vec2<T>.From64(Vector128.Sqrt(AsVec128()));

        if (typeof(T) == typeof(double))
            return Vec2<T>.From128(Vector256.Sqrt(AsVec256()));*/

        if (SizeOf<T>() == 4 && Vector64<T>.IsSupported)
            return From64(Vector64.Sqrt(As64()));

        if (SizeOf<T>() == 8 && Vector128<T>.IsSupported)
            return From128(Vector128.Sqrt(As128()));

        return new
        (
            T.CreateTruncating(TRoot.Sqrt(TRoot.CreateSaturating(X))),
            T.CreateTruncating(TRoot.Sqrt(TRoot.CreateSaturating(Y)))
        );
    }

    public override readonly string ToString() => $"({X}, {Y})";

    public override readonly bool Equals(object? obj) => (obj is Vec2<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y);

    public readonly bool Equals(Vec2<T> other) => this == other;
}
