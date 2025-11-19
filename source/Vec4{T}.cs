using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Numerics;

[DebuggerDisplay("{X};{Y};{Z};{W}")]
[StructLayout(LayoutKind.Sequential)]
public partial struct Vec4<T>(T x, T y, T z, T w) :
    IVector<Vec4<T>>,
    IAdditionOperators<Vec4<T>, Vec4<T>, Vec4<T>>,
    ISubtractionOperators<Vec4<T>, Vec4<T>, Vec4<T>>,
    IMultiplyOperators<Vec4<T>, Vec4<T>, Vec4<T>>,
    IDivisionOperators<Vec4<T>, Vec4<T>, Vec4<T>>,
    IMultiplyOperators<Vec4<T>, T, Vec4<T>>,
    IDivisionOperators<Vec4<T>, T, Vec4<T>>,
    IUnaryNegationOperators<Vec4<T>, Vec4<T>>,
    IUnaryPlusOperators<Vec4<T>, Vec4<T>>
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
{
    public T X = x, Y = y, Z = z, W = w;

    public Vec4(T value) : this(value, value, value, value) { }

    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<T> AsVec128() => Unsafe.BitCast<Vec4<T>, Vector128<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector256<T> AsVec256() => Unsafe.BitCast<Vec4<T>, Vector256<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<float> AsVec128F() => Unsafe.BitCast<Vec4<T>, Vector128<float>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector256<double> AsVec256D() => Unsafe.BitCast<Vec4<T>, Vector256<double>>(this);

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> From128(Vector128<T> vec) => Unsafe.BitCast<Vector128<T>, Vec4<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> From256(Vector256<T> vec) => Unsafe.BitCast<Vector256<T>, Vec4<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> From128(Vector128<float> vec) => Unsafe.BitCast<Vector128<float>, Vec4<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> From256(Vector256<double> vec) => Unsafe.BitCast<Vector256<double>, Vec4<T>>(vec);

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> vec)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(+vec.AsVec128());

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(+vec.AsVec256());

        return SoftPlus(vec);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> vec)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(-vec.AsVec128());

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(-vec.AsVec256());

        return SoftNegate(vec);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> vec, T value)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(vec.AsVec128() * value);

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(vec.AsVec256() * value);

        return SoftMultiply(vec, value);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> vec, T value)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(vec.AsVec128() / value);

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(vec.AsVec256() / value);

        return SoftDivide(vec, value);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> left, Vec4<T> right)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(left.AsVec128() + right.AsVec128());

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(left.AsVec256() + right.AsVec256());

        return SoftAdd(left, right);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> left, Vec4<T> right)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(left.AsVec128() - right.AsVec128());

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(left.AsVec256() - right.AsVec256());

        return SoftSubstract(left, right);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> left, Vec4<T> right)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(left.AsVec128() * right.AsVec128());

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(left.AsVec256() * right.AsVec256());

        return SoftMultiply(left, right);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> left, Vec4<T> right)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(left.AsVec128() / right.AsVec128());

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(left.AsVec256() / right.AsVec256());

        return SoftMultiply(left, right);
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec4<T> left, Vec4<T> right)
    {
        if (typeof(T) == typeof(float))
            return left.AsVec128() == right.AsVec128();

        if (typeof(T) == typeof(double))
            return left.AsVec256() == right.AsVec256();

        return SoftEqual(left, right);
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec4<T> left, Vec4<T> right)
    {
        if (typeof(T) == typeof(float))
            return left.AsVec128() == right.AsVec128();

        if (typeof(T) == typeof(double))
            return left.AsVec256() == right.AsVec256();

        return SoftNotEqual(left, right);
    }
    #endregion

    public static Vec4<T> Zero { get; } = new(T.Zero);

    public static Vec4<T> One { get; } = new(T.One, T.One, T.One, T.One);

    public static Vec4<T> UnitX { get; } = new(T.One, T.Zero, T.Zero, T.Zero);

    public static Vec4<T> UnitY { get; } = new(T.Zero, T.One, T.Zero, T.Zero);

    public static Vec4<T> UnitZ { get; } = new(T.Zero, T.Zero, T.One, T.Zero);

    public static Vec4<T> UnitW { get; } = new(T.Zero, T.Zero, T.Zero, T.One);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add(Vec4<T> left, Vec4<T> right) => left + right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Subtract(Vec4<T> left, Vec4<T> right) => left - right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply(Vec4<T> left, Vec4<T> right) => left * right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply(Vec4<T> left, T value) => left * value;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply(T value, Vec4<T> right) => right * value;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide(Vec4<T> left, Vec4<T> right) => left / right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide(Vec4<T> left, T divisor) => left / divisor;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Negate(Vec4<T> vec) => -vec;

    [MethodImpl(AggressiveInlining)]
    public readonly T Sum()
    {
        if (typeof(T) == typeof(float))
            return Vector128.Sum(AsVec128());

        if (typeof(T) == typeof(double))
            return Vector256.Sum(AsVec256());

        return SoftSum(this);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Vec4<T> vec) => (this * vec).Sum();

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Dot(this);

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec4<T> vec) => (this - vec).LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public readonly T Length() => T.Sqrt(LengthSquared());

    [MethodImpl(AggressiveInlining)]
    public readonly T Distance(Vec4<T> vec) => T.Sqrt(DistanceSquared(vec));

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Normalize() => this / Distance(Zero);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Abs()
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(Vector128.Abs(AsVec128()));

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(Vector256.Abs(AsVec256()));

        return SoftAbs(this);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Min(Vec4<T> vec)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(Vector128.Min(AsVec128(), vec.AsVec128()));

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(Vector256.Min(AsVec256(), vec.AsVec256()));

        return SoftMin(this, vec);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Max(Vec4<T> vec)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(Vector128.Max(AsVec128(), vec.AsVec128()));

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(Vector256.Max(AsVec256(), vec.AsVec256()));

        return SoftMax(this, vec);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Clamp(Vec4<T> min, Vec4<T> max)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(Vector128.Clamp(AsVec128(), min.AsVec128(), max.AsVec128()));

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(Vector256.Clamp(AsVec256(), min.AsVec256(), max.AsVec256()));

        return SoftClamp(this, min, max);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Lerp(Vec4<T> vec, T amount)
    {
        if (typeof(T) == typeof(float))
        {
            return Vec4<T>.From128(Vector128.Lerp // maybe Lerp<T> (and including integers)?
            (
                AsVec128F(),
                vec.AsVec128F(),
                Vector128.Create((float)(object)amount)
            ));
        }
        if (typeof(T) == typeof(double))
        {
            return Vec4<T>.From256(Vector256.Lerp
            (
                AsVec256D(),
                vec.AsVec256D(),
                Vector256.Create((double)(object)amount)
            ));
        }
        return SoftLerp(this, vec, amount);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> MultiplyAdd(Vec4<T> vec, Vec4<T> add)
    {
        if (typeof(T) == typeof(float))
            return Vec4<T>.From128(Vector128.FusedMultiplyAdd(AsVec128F(), vec.AsVec128F(), add.AsVec128F()));

        if (typeof(T) == typeof(double))
            return Vec4<T>.From256(Vector256.FusedMultiplyAdd(AsVec256D(), vec.AsVec256D(), add.AsVec256D()));

        return SoftMultiplyAdd(this, vec, add);
    }

    /*[MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Transform(Mat44<T> mat)
    {
        var result = mat.X * X;

        result = mat.Y.MultiplyAdd(new(Y), result);
        result = mat.Z.MultiplyAdd(new(Z), result);
        result = mat.W.MultiplyAdd(new(W), result);

        return result;
    }*/

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Transform(Mat44<T> mat)
    {
        if (typeof(T) == typeof(float))
        {
            var result = (mat.X * X).AsVec128F();

            result = Vector128.MultiplyAddEstimate(mat.Y.AsVec128F(), Vector128.Create((float)(object)Y), result);
            result = Vector128.MultiplyAddEstimate(mat.Z.AsVec128F(), Vector128.Create((float)(object)Z), result);
            result = Vector128.MultiplyAddEstimate(mat.W.AsVec128F(), Vector128.Create((float)(object)W), result);

            return Vec4<T>.From128(result);
        }
        else if (typeof(T) == typeof(double))
        {
            var result = (mat.X * X).AsVec256D();

            result = Vector256.MultiplyAddEstimate(mat.Y.AsVec256D(), Vector256.Create((double)(object)Y), result);
            result = Vector256.MultiplyAddEstimate(mat.Z.AsVec256D(), Vector256.Create((double)(object)Z), result);
            result = Vector256.MultiplyAddEstimate(mat.W.AsVec256D(), Vector256.Create((double)(object)W), result);

            return Vec4<T>.From256(result);
        }
        else
        {
            var result = mat.X * X;

            result = SoftMultiplyAdd(mat.Y, new(Y), result);
            result = SoftMultiplyAdd(mat.Z, new(Z), result);
            result = SoftMultiplyAdd(mat.W, new(W), result);

            return result;
        }
    }

    [Obsolete("TODO")]
    public override readonly string ToString() => $"{X};{Y};{Z};{W}";

    public override readonly bool Equals(object? obj) => (obj is Vec4<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Vec4<T> other) => this == other;
}
