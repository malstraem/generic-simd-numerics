using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

using static System.Runtime.CompilerServices.MethodImplOptions;

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
        where T : unmanaged, IFloatingPoint<T>
{
    public T X = x, Y = y, Z = z, W = w;

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
    public static Vec4<T> operator +(Vec4<T> value)
    {
        if (IsNotHardware())
            return SoftPlus(value);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(+value.AsVec64()), // any vector instructions for IEEE's binary16?
                4 => Vec4<T>.From128(+value.AsVec128()),
                8 => Vec4<T>.From256(+value.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> value)
    {
        if (IsNotHardware())
            return SoftNegate(value);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(-value.AsVec64()),
                4 => Vec4<T>.From128(-value.AsVec128()),
                8 => Vec4<T>.From256(-value.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> vec, T value)
    {
        if (IsNotHardware())
            return SoftMultiply(vec, value);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(vec.AsVec64() * value),
                4 => Vec4<T>.From128(vec.AsVec128() * value),
                8 => Vec4<T>.From256(vec.AsVec256() * value),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> vec, T value)
    {
        if (IsNotHardware())
            return SoftDivide(vec, value);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(vec.AsVec64() / value),
                4 => Vec4<T>.From128(vec.AsVec128() / value),
                8 => Vec4<T>.From256(vec.AsVec256() / value),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Vec4<T> operator +(Vec4<T> left, Vec4<T> right)
    {
        if (IsNotHardware())
            return SoftAdd(left, right);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(left.AsVec64() + right.AsVec64()),
                4 => Vec4<T>.From128(left.AsVec128() + right.AsVec128()),
                8 => Vec4<T>.From256(left.AsVec256() + right.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> left, Vec4<T> right)
    {
        if (IsNotHardware())
            return SoftSubtract(left, right);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(left.AsVec64() - right.AsVec64()),
                4 => Vec4<T>.From128(left.AsVec128() - right.AsVec128()),
                8 => Vec4<T>.From256(left.AsVec256() - right.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> left, Vec4<T> right)
    {
        if (IsNotHardware())
            return SoftMultiply(left, right);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(left.AsVec64() * right.AsVec64()),
                4 => Vec4<T>.From128(left.AsVec128() * right.AsVec128()),
                8 => Vec4<T>.From256(left.AsVec256() * right.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> left, Vec4<T> right)
    {
        if (IsNotHardware())
            return SoftMultiply(left, right);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(left.AsVec64() / right.AsVec64()),
                4 => Vec4<T>.From128(left.AsVec128() / right.AsVec128()),
                8 => Vec4<T>.From256(left.AsVec256() / right.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec4<T> left, Vec4<T> right)
    {
        if (IsNotHardware())
            return SoftEqual(left, right);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => left.AsVec64() == right.AsVec64(),
                4 => left.AsVec128() == right.AsVec128(),
                8 => left.AsVec256() == right.AsVec256(),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec4<T> left, Vec4<T> right)
    {
        if (IsNotHardware())
            return SoftNotEqual(left, right);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => left.AsVec64() != right.AsVec64(),
                4 => left.AsVec128() != right.AsVec128(),
                8 => left.AsVec256() != right.AsVec256(),
                _ => throw new NotSupportedException()
            };
        }
    }
    #endregion

    public static Vec4<T> Zero { get; } = new(T.Zero, T.Zero, T.Zero, T.Zero);

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
    public readonly T Sum(Vec4<T> vec)
    {
        if (IsNotHardware())
            return SoftSum(vec);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vector64.Sum(vec.AsVec64()),
                4 => Vector128.Sum(vec.AsVec128()),
                8 => Vector256.Sum(vec.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Normalize(Vec4<T> vec) => vec / Distance(vec, Zero);

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Vec4<T> vec) => Sum(this * vec);

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Dot(this);

    [MethodImpl(AggressiveInlining)]
    public readonly T DistanceSquared(Vec4<T> vec) => (this - vec).LengthSquared();

    // too hard...
    // no meaning for integer cases
    [MethodImpl(AggressiveInlining)]
    public readonly T Length()
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                return Vector64.Sqrt(Vector64.Create(LengthSquared())).ToScalar();
            }
        }
        throw new NotSupportedException();
    }

    // too hard...
    // no meaning for integer cases
    [MethodImpl(AggressiveInlining)]
    public static T Distance(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                return Vector64.Sqrt(Vector64.Create(left.DistanceSquared(right))).ToScalar();
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Abs(Vec4<T> vec)
    {
        if (IsNotHardware())
            return SoftAbs(vec);

        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(Vector64.Abs(vec.AsVec64())),
                4 => Vec4<T>.From128(Vector128.Abs(vec.AsVec128())),
                8 => Vec4<T>.From256(Vector256.Abs(vec.AsVec256())),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Clamp(Vec4<T> vec, Vec4<T> min, Vec4<T> max)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(Vector64.Clamp(vec.AsVec64(), min.AsVec64(), max.AsVec64())),
                4 => Vec4<T>.From128(Vector128.Clamp(vec.AsVec128(), min.AsVec128(), max.AsVec128())),
                8 => Vec4<T>.From256(Vector256.Clamp(vec.AsVec256(), min.AsVec256(), max.AsVec256())),
                _ => throw new NotSupportedException()
            };
        }
    }

    /* no Vector256.Lerp()<T>...

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Lerp(Vector4<T> vec1, Vector4<T> vec2, T amount)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                return Vector256.Lerp()
                (
                    Unsafe.As<Vector4<T>, Vector256<T>>(ref vec1),
                    Unsafe.As<Vector4<T>, Vector256<T>>(ref vec2),
                    Vector256.Create(amount)
                );
            }
            else if (sizeof(T) == 4)
            {
                return Vector256.Lerp()
                (
                    Unsafe.As<Vector4<T>, Vector128<T>>(ref vec1),
                    Unsafe.As<Vector4<T>, Vector128<T>>(ref vec2),
                    Vector128.Create(amount)
                );
            }
        }
        throw new NotSupportedException();
    }*/

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Max(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(Vector64.Max(left.AsVec64(), right.AsVec64())),
                4 => Vec4<T>.From128(Vector128.Max(left.AsVec128(), right.AsVec128())),
                8 => Vec4<T>.From256(Vector256.Max(left.AsVec256(), right.AsVec256())),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Min(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                //2 => Vec4<T>.From64(Vector64.Max(left.AsVec64(), right.AsVec64())),
                4 => Vec4<T>.From128(Vector128.Max(left.AsVec128(), right.AsVec128())),
                8 => Vec4<T>.From256(Vector256.Max(left.AsVec256(), right.AsVec256())),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> MultiplyAddEstimate(Vec4<T> left, Vec4<T> right, Vec4<T> add)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                4 => Vec4<T>.From128(Vector128.FusedMultiplyAdd(left.AsVec128F(), right.AsVec128F(), add.AsVec128F())),
                8 => Vec4<T>.From256(Vector256.FusedMultiplyAdd(left.AsVec256D(), right.AsVec256D(), add.AsVec256D())),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Vec4<T> Transform(Vec4<T> vec, Mat44<T> mat)
    {
        unsafe
        {
            if (sizeof(T) == 4)
            {
                var result = (mat.X * vec.X).AsVec128F();

                result = Vector128.MultiplyAddEstimate(mat.Y.AsVec128F(), Vector128.Create(vec.Y).AsSingle(), result);
                result = Vector128.MultiplyAddEstimate(mat.Z.AsVec128F(), Vector128.Create(vec.Z).AsSingle(), result);
                result = Vector128.MultiplyAddEstimate(mat.W.AsVec128F(), Vector128.Create(vec.W).AsSingle(), result);

                return Vec4<T>.From128(result);
            }
            else if (sizeof(T) == 8)
            {
                var result = (mat.X * vec.X).AsVec256D();

                result = Vector256.MultiplyAddEstimate(mat.Y.AsVec256D(), Vector256.Create(vec.Y).AsDouble(), result);
                result = Vector256.MultiplyAddEstimate(mat.Z.AsVec256D(), Vector256.Create(vec.Z).AsDouble(), result);
                result = Vector256.MultiplyAddEstimate(mat.W.AsVec256D(), Vector256.Create(vec.W).AsDouble(), result);

                return Vec4<T>.From256(result);
            }
        }
        throw new NotSupportedException();
    }

    public override readonly string ToString() => $"{X};{Y};{Z};{W}";

    public override readonly bool Equals(object? obj) => (obj is Vec4<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Vec4<T> other) => this == other;
}
