using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Numerics;

[DebuggerDisplay("{X};{Y};{Z};{W}")]
[StructLayout(LayoutKind.Sequential)]
public partial struct Vector4<T>(T x, T y, T z, T w) where T : unmanaged, IBinaryNumber<T>
{
    public T X = x, Y = y, Z = z, W = w;

    #region Operators
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> operator +(Vector4<T> left, Vector4<T> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var add = Unsafe.As<Vector4<T>, Vector256<T>>(ref left) + Unsafe.As<Vector4<T>, Vector256<T>>(ref right);

                return Unsafe.As<Vector256<T>, Vector4<T>>(ref add);
            }
            else if (sizeof(T) == 4)
            {
                var add = Unsafe.As<Vector4<T>, Vector128<T>>(ref left) + Unsafe.As<Vector4<T>, Vector128<T>>(ref right);

                return Unsafe.As<Vector128<T>, Vector4<T>>(ref add);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> operator -(Vector4<T> left, Vector4<T> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var sub = Unsafe.As<Vector4<T>, Vector256<T>>(ref left) - Unsafe.As<Vector4<T>, Vector256<T>>(ref right);

                return Unsafe.As<Vector256<T>, Vector4<T>>(ref sub);
            }
            else if (sizeof(T) == 4)
            {
                var sub = Unsafe.As<Vector4<T>, Vector128<T>>(ref left) - Unsafe.As<Vector4<T>, Vector128<T>>(ref right);

                return Unsafe.As<Vector128<T>, Vector4<T>>(ref sub);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> operator -(Vector4<T> value)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var neg = -Unsafe.As<Vector4<T>, Vector256<T>>(ref value);

                return Unsafe.As<Vector256<T>, Vector4<T>>(ref neg);
            }
            else if (sizeof(T) == 4)
            {
                var neg = -Unsafe.As<Vector4<T>, Vector128<T>>(ref value);

                return Unsafe.As<Vector128<T>, Vector4<T>>(ref neg);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> operator *(Vector4<T> left, Vector4<T> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var mul = Unsafe.As<Vector4<T>, Vector256<T>>(ref left) * Unsafe.As<Vector4<T>, Vector256<T>>(ref right);

                return Unsafe.As<Vector256<T>, Vector4<T>>(ref mul);
            }
            else if (sizeof(T) == 4)
            {
                var mul = Unsafe.As<Vector4<T>, Vector128<T>>(ref left) * Unsafe.As<Vector4<T>, Vector128<T>>(ref right);

                return Unsafe.As<Vector128<T>, Vector4<T>>(ref mul);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> operator *(Vector4<T> left, T value)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var mul = Unsafe.As<Vector4<T>, Vector256<T>>(ref left) * value;

                return Unsafe.As<Vector256<T>, Vector4<T>>(ref mul);
            }
            else if (sizeof(T) == 4)
            {
                var mul = Unsafe.As<Vector4<T>, Vector128<T>>(ref left) * value;

                return Unsafe.As<Vector128<T>, Vector4<T>>(ref mul);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> operator /(Vector4<T> left, Vector4<T> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var div = Unsafe.As<Vector4<T>, Vector256<T>>(ref left) / Unsafe.As<Vector4<T>, Vector256<T>>(ref right);

                return Unsafe.As<Vector256<T>, Vector4<T>>(ref div);
            }
            else if (sizeof(T) == 4)
            {
                var div = Unsafe.As<Vector4<T>, Vector128<T>>(ref left) / Unsafe.As<Vector4<T>, Vector128<T>>(ref right);

                return Unsafe.As<Vector128<T>, Vector4<T>>(ref div);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> operator /(Vector4<T> left, T value)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var div = Unsafe.As<Vector4<T>, Vector256<T>>(ref left) / value;

                return Unsafe.As<Vector256<T>, Vector4<T>>(ref div);
            }
            else if (sizeof(T) == 4)
            {
                var div = Unsafe.As<Vector4<T>, Vector128<T>>(ref left) / value;

                return Unsafe.As<Vector128<T>, Vector4<T>>(ref div);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> operator *(T value, Vector4<T> right) => right * value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Vector4<T> left, Vector4<T> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                return Unsafe.As<Vector4<T>, Vector256<T>>(ref left) == Unsafe.As<Vector4<T>, Vector256<T>>(ref right);
            }
            else if (sizeof(T) == 4)
            {
                return Unsafe.As<Vector4<T>, Vector128<T>>(ref left) == Unsafe.As<Vector4<T>, Vector128<T>>(ref right);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Vector4<T> left, Vector4<T> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                return Unsafe.As<Vector4<T>, Vector256<T>>(ref left) != Unsafe.As<Vector4<T>, Vector256<T>>(ref right);
            }
            else if (sizeof(T) == 4)
            {
                return Unsafe.As<Vector4<T>, Vector128<T>>(ref left) != Unsafe.As<Vector4<T>, Vector128<T>>(ref right);
            }
        }
        throw new NotSupportedException();
    }
    #endregion
    public static Vector4<T> Zero { get; } = new();

    public static Vector4<T> One { get; } = new(T.One, T.One, T.One, T.One);

    public static Vector4<T> UnitX { get; } = new(T.One, T.Zero, T.Zero, T.Zero);

    public static Vector4<T> UnitY { get; } = new(T.Zero, T.One, T.Zero, T.Zero);

    public static Vector4<T> UnitZ { get; } = new(T.Zero, T.Zero, T.One, T.Zero);

    public static Vector4<T> UnitW { get; } = new(T.Zero, T.Zero, T.Zero, T.One);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Add(Vector4<T> left, Vector4<T> right) => left + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Subtract(Vector4<T> left, Vector4<T> right) => left - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Multiply(Vector4<T> left, Vector4<T> right) => left * right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Multiply(Vector4<T> left, T value) => left * value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Multiply(T value, Vector4<T> right) => right * value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Divide(Vector4<T> left, Vector4<T> right) => left / right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Divide(Vector4<T> left, T divisor) => left / divisor;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Negate(Vector4<T> vec) => -vec;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Normalize(Vector4<T> vec) => vec / Distance(vec, Zero);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Dot(Vector4<T> vec1, Vector4<T> vec2) => Sum(vec1 * vec2);

    // too hard...
    // no meaning for integer cases
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Distance(Vector4<T> vec1, Vector4<T> vec2)
    {
        unsafe
        {
            if (sizeof(T) <= 8)
            {
                return Vector64.Sqrt(Vector64.Create(DistanceSquared(vec1, vec2))).ToScalar();
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T DistanceSquared(Vector4<T> vec1, Vector4<T> vec2)
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
            if (sizeof(T) <= 8)
            {
                return Vector64.Sqrt(Vector64.Create(LengthSquared())).ToScalar();
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Abs(Vector4<T> vec)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var abs = Vector256.Abs(Unsafe.As<Vector4<T>, Vector256<T>>(ref vec));

                return Unsafe.As<Vector256<T>, Vector4<T>>(ref abs);
            }
            else if (sizeof(T) == 4)
            {
                var abs = Vector128.Abs(Unsafe.As<Vector4<T>, Vector128<T>>(ref vec));

                return Unsafe.As<Vector128<T>, Vector4<T>>(ref abs);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Sum(Vector4<T> vec)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                return Vector256.Sum(Unsafe.As<Vector4<T>, Vector256<T>>(ref vec));
            }
            else if (sizeof(T) == 4)
            {
                return Vector128.Sum(Unsafe.As<Vector4<T>, Vector128<T>>(ref vec));
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Clamp(Vector4<T> vec, Vector4<T> min, Vector4<T> max)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var result = Vector256.Clamp
                (
                    Unsafe.As<Vector4<T>, Vector256<T>>(ref vec),
                    Unsafe.As<Vector4<T>, Vector256<T>>(ref min),
                    Unsafe.As<Vector4<T>, Vector256<T>>(ref max)
                );
                return Unsafe.As<Vector256<T>, Vector4<T>>(ref result);
            }
            else if (sizeof(T) == 4)
            {
                var result = Vector128.Clamp
                (
                    Unsafe.As<Vector4<T>, Vector128<T>>(ref vec),
                    Unsafe.As<Vector4<T>, Vector128<T>>(ref min),
                    Unsafe.As<Vector4<T>, Vector128<T>>(ref max)
                );
                return Unsafe.As<Vector128<T>, Vector4<T>>(ref result);
            }
        }
        throw new NotSupportedException();
    }

    /* Vector256.Lerp()<T> is missed...

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
    public static Vector4<T> Max(Vector4<T> vec1, Vector4<T> vec2)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var min = Vector256.Max
                (
                    Unsafe.As<Vector4<T>, Vector256<T>>(ref vec1),
                    Unsafe.As<Vector4<T>, Vector256<T>>(ref vec2)
                );
                return Unsafe.As<Vector256<T>, Vector4<T>>(ref min);
            }
            else if (sizeof(T) == 4)
            {
                var min = Vector128.Max
                (
                    Unsafe.As<Vector4<T>, Vector128<T>>(ref vec1),
                    Unsafe.As<Vector4<T>, Vector128<T>>(ref vec2)
                );
                return Unsafe.As<Vector128<T>, Vector4<T>>(ref min);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<T> Min(Vector4<T> vec1, Vector4<T> vec2)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var min = Vector256.Min
                (
                    Unsafe.As<Vector4<T>, Vector256<T>>(ref vec1),
                    Unsafe.As<Vector4<T>, Vector256<T>>(ref vec2)
                );
                return Unsafe.As<Vector256<T>, Vector4<T>>(ref min);
            }
            else if (sizeof(T) == 4)
            {
                var min = Vector128.Min
                (
                    Unsafe.As<Vector4<T>, Vector128<T>>(ref vec1),
                    Unsafe.As<Vector4<T>, Vector128<T>>(ref vec2)
                );
                return Unsafe.As<Vector128<T>, Vector4<T>>(ref min);
            }
        }
        throw new NotSupportedException();
    }

    public override readonly string ToString() => $"{X};{Y};{Z};{W}";

    public override readonly bool Equals(object? obj) => (obj is Vector4<T> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Vector4<T> other) => this == other;
}
