using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Numerics;

[DebuggerDisplay("{X};{Y};{Z};{W}")]
[StructLayout(LayoutKind.Sequential)]
public partial struct Vec4<T>(T x, T y, T z, T w) :
    IVector<Vec4<T>>,
    IMultiplyOperators<Vec4<T>, Vec4<T>, Vec4<T>>
    where T : unmanaged, IBinaryNumber<T>
{
    public T X = x, Y = y, Z = z, W = w;

    [UnscopedRef]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private Vector64<T> AsVec64() => Unsafe.As<Vec4<T>, Vector64<T>>(ref this);

    [UnscopedRef]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private Vector128<T> AsVec128() => Unsafe.As<Vec4<T>, Vector128<T>>(ref this);

    [UnscopedRef]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private Vector256<T> AsVec256() => Unsafe.As<Vec4<T>, Vector256<T>>(ref this);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private Vector128<float> AsVec128F() => Unsafe.As<Vec4<T>, Vector128<float>>(ref this);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private Vector256<double> AsVec256D() => Unsafe.As<Vec4<T>, Vector256<double>>(ref this);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static Vec4<T> From64(Vector64<T> vec) => Unsafe.As<Vector64<T>, Vec4<T>>(ref vec);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static Vec4<T> From128(Vector128<T> vec) => Unsafe.As<Vector128<T>, Vec4<T>>(ref vec);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static Vec4<T> From256(Vector256<T> vec) => Unsafe.As<Vector256<T>, Vec4<T>>(ref vec);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static Vec4<T> From128F(Vector128<float> vec) => Unsafe.As<Vector128<float>, Vec4<T>>(ref vec);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static Vec4<T> From256D(Vector256<double> vec) => Unsafe.As<Vector256<double>, Vec4<T>>(ref vec);

    #region Operators
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Vec4<T> operator +(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            if (sizeof(T) == 2)
            {
                return Vec4<T>.From64(left.AsVec64() + right.AsVec64());
            }
            else if (sizeof(T) == 4)
            {
                return Vec4<T>.From128(left.AsVec128() + right.AsVec128());
            }
            // I have no idea at this point...

            // any meaning?
            // any way to store unaligned data to vector register?

            // maybe we need to load using general registers? Or using special instruction (if exist)
            // performance trade off is a question
            else if (sizeof(T) < 8)
            {
                throw new NotSupportedException();
            }
            else if (sizeof(T) == 8)
            {
                return Vec4<T>.From256(left.AsVec256() + right.AsVec256());
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => Vec4<T>.From64(left.AsVec64() - right.AsVec64()),
                4 => Vec4<T>.From128(left.AsVec128() - right.AsVec128()),
                8 => Vec4<T>.From256(left.AsVec256() - right.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> value)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => Vec4<T>.From64(-value.AsVec64()),
                4 => Vec4<T>.From128(-value.AsVec128()),
                8 => Vec4<T>.From256(-value.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Vec4<T> operator *(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            if (sizeof(T) == 2)
            {
                return Vec4<T>.From64(left.AsVec64() * right.AsVec64());
            }
            else if (sizeof(T) == 4)
            {
                return Vec4<T>.From128(left.AsVec128() * right.AsVec128());
            }
            else if (sizeof(T) == 8)
            {
                return Vec4<T>.From256(left.AsVec256() * right.AsVec256());
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Vec4<T> operator *(Vec4<T> vec, T value)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => Vec4<T>.From64(vec.AsVec64() * value),
                4 => Vec4<T>.From128(vec.AsVec128() * value),
                8 => Vec4<T>.From256(vec.AsVec256() * value),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => Vec4<T>.From64(left.AsVec64() / right.AsVec64()),
                4 => Vec4<T>.From128(left.AsVec128() / right.AsVec128()),
                8 => Vec4<T>.From256(left.AsVec256() / right.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> vec, T value)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => Vec4<T>.From64(vec.AsVec64() / value),
                4 => Vec4<T>.From128(vec.AsVec128() / value),
                8 => Vec4<T>.From256(vec.AsVec256() / value),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => left.AsVec64() == right.AsVec64(),
                4 => left.AsVec128() == right.AsVec128(),
                8 => left.AsVec256() == right.AsVec256(),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => left.AsVec64() != right.AsVec64(),
                4 => left.AsVec128() != right.AsVec128(),
                8 => left.AsVec256() != right.AsVec256(),
                _ => throw new NotSupportedException()
            };
        }
    }
    #endregion

    public static Vec4<T> Zero { get; } = new();

    public static Vec4<T> One { get; } = new(T.One, T.One, T.One, T.One);

    public static Vec4<T> UnitX { get; } = new(T.One, T.Zero, T.Zero, T.Zero);

    public static Vec4<T> UnitY { get; } = new(T.Zero, T.One, T.Zero, T.Zero);

    public static Vec4<T> UnitZ { get; } = new(T.Zero, T.Zero, T.One, T.Zero);

    public static Vec4<T> UnitW { get; } = new(T.Zero, T.Zero, T.Zero, T.One);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Add(Vec4<T> left, Vec4<T> right) => left + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Subtract(Vec4<T> left, Vec4<T> right) => left - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Multiply(Vec4<T> left, Vec4<T> right) => left * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Multiply(Vec4<T> left, T value) => left * value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Multiply(T value, Vec4<T> right) => right * value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Divide(Vec4<T> left, Vec4<T> right) => left / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Divide(Vec4<T> left, T divisor) => left / divisor;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Negate(Vec4<T> vec) => -vec;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Normalize(Vec4<T> vec) => vec / Distance(vec, Zero);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Dot(Vec4<T> vec1, Vec4<T> vec2) => Sum(vec1 * vec2);

    // too hard...
    // no meaning for integer cases
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Distance(Vec4<T> vec1, Vec4<T> vec2)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                return Vector64.Sqrt(Vector64.Create(DistanceSquared(vec1, vec2))).ToScalar();
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T DistanceSquared(Vec4<T> vec1, Vec4<T> vec2)
    {
        var sub = vec2 - vec1;
        return Dot(sub, sub);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly T LengthSquared() => Dot(this, this);

    // too hard...
    // no meaning for integer cases
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Abs(Vec4<T> vec)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => Vec4<T>.From64(Vector64.Abs(vec.AsVec64())),
                4 => Vec4<T>.From128(Vector128.Abs(vec.AsVec128())),
                8 => Vec4<T>.From256(Vector256.Abs(vec.AsVec256())),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Sum(Vec4<T> vec)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => Vector64.Sum(vec.AsVec64()),
                4 => Vector128.Sum(vec.AsVec128()),
                8 => Vector256.Sum(vec.AsVec256()),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Clamp(Vec4<T> vec, Vec4<T> min, Vec4<T> max)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => Vec4<T>.From64(Vector64.Clamp(vec.AsVec64(), min.AsVec64(), max.AsVec64())),
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Max(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => Vec4<T>.From64(Vector64.Max(left.AsVec64(), right.AsVec64())),
                4 => Vec4<T>.From128(Vector128.Max(left.AsVec128(), right.AsVec128())),
                8 => Vec4<T>.From256(Vector256.Max(left.AsVec256(), right.AsVec256())),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Min(Vec4<T> left, Vec4<T> right)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                2 => Vec4<T>.From64(Vector64.Max(left.AsVec64(), right.AsVec64())),
                4 => Vec4<T>.From128(Vector128.Max(left.AsVec128(), right.AsVec128())),
                8 => Vec4<T>.From256(Vector256.Max(left.AsVec256(), right.AsVec256())),
                _ => throw new NotSupportedException()
            };
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> MultiplyAddEstimate(Vec4<T> left, Vec4<T> right, Vec4<T> add)
    {
        unsafe
        {
            return sizeof(T) switch
            {
                4 => Vec4<T>.From128F(Vector128.FusedMultiplyAdd(left.AsVec128F(), right.AsVec128F(), add.AsVec128F())),
                8 => Vec4<T>.From256D(Vector256.FusedMultiplyAdd(left.AsVec256D(), right.AsVec256D(), add.AsVec256D())),
                _ => throw new NotSupportedException()
            };
            /*return sizeof(T) switch
            {
                4 => left * right + add,
                8 => left * right + add,
                _ => throw new NotSupportedException()
            };*/
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<T> Transform(Vec4<T> vec, Mat44<T> mat)
    {
        /*result += mat.Y * vec.Y;
        result += mat.Z * vec.Z;
        result += mat.W * vec.W;

        return result;*/
        unsafe
        {
            if (sizeof(T) == 4)
            {
                var result = (mat.X * vec.X).AsVec128F();

                var estY = Vector128.Create(vec.Y);
                var estZ = Vector128.Create(vec.Z);
                var estW = Vector128.Create(vec.W);

                result = Vector128.FusedMultiplyAdd(mat.Y.AsVec128F(), estY.AsSingle(), result);
                result = Vector128.FusedMultiplyAdd(mat.Z.AsVec128F(), estZ.AsSingle(), result);
                result = Vector128.FusedMultiplyAdd(mat.W.AsVec128F(), estW.AsSingle(), result);

                return Vec4<T>.From128F(result);
            }
            else if (sizeof(T) == 8)
            {
                var result = (mat.X * vec.X).AsVec256D();

                var estY = Vector256.Create(vec.Y);
                var estZ = Vector256.Create(vec.Z);
                var estW = Vector256.Create(vec.W);

                result = Vector256.FusedMultiplyAdd(mat.Y.AsVec256D(), estY.AsDouble(), result);
                result = Vector256.FusedMultiplyAdd(mat.Z.AsVec256D(), estZ.AsDouble(), result);
                result = Vector256.FusedMultiplyAdd(mat.W.AsVec256D(), estW.AsDouble(), result);

                return Vec4<T>.From256D(result);
            }
        }
        throw new NotSupportedException();
    }

    public override readonly string ToString() => $"{X};{Y};{Z};{W}";

    public override readonly bool Equals(object? obj) => (obj is Vec4<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Vec4<T> other) => this == other;
}
