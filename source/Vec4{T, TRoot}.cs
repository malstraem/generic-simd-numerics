using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Numerics;

// proposal to expose sqaure root behavior on type level
[StructLayout(LayoutKind.Sequential)]
public partial struct Vec4<T, TRoot>(T x, T y, T z, T w)
    where T : unmanaged, INumber<T>
    where TRoot : unmanaged, IRootFunctions<TRoot>
{
    public T X = x, Y = y, Z = z, W = w;

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> operator +(Vec4<T, TRoot> left, Vec4<T, TRoot> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var add = Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref left) + Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref right);

                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref add);
            }
            else if (sizeof(T) == 4)
            {
                var add = Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref left) + Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref right);

                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref add);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> operator -(Vec4<T, TRoot> left, Vec4<T, TRoot> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var sub = Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref left) - Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref right);

                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref sub);
            }
            else if (sizeof(T) == 4)
            {
                var sub = Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref left) - Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref right);

                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref sub);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> operator -(Vec4<T, TRoot> value)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var neg = -Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref value);

                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref neg);
            }
            else if (sizeof(T) == 4)
            {
                var neg = -Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref value);

                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref neg);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> operator *(Vec4<T, TRoot> left, Vec4<T, TRoot> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var mul = Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref left) * Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref right);

                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref mul);
            }
            else if (sizeof(T) == 4)
            {
                var mul = Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref left) * Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref right);

                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref mul);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> operator *(Vec4<T, TRoot> left, T value)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var mul = Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref left) * value;

                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref mul);
            }
            else if (sizeof(T) == 4)
            {
                var mul = Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref left) * value;

                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref mul);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> operator /(Vec4<T, TRoot> left, Vec4<T, TRoot> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var div = Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref left) / Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref right);

                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref div);
            }
            else if (sizeof(T) == 4)
            {
                var div = Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref left) / Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref right);

                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref div);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> operator /(Vec4<T, TRoot> left, T value)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var div = Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref left) / value;

                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref div);
            }
            else if (sizeof(T) == 4)
            {
                var div = Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref left) / value;

                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref div);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> operator *(T value, Vec4<T, TRoot> right) => right * value;

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec4<T, TRoot> left, Vec4<T, TRoot> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                return Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref left) == Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref right);
            }
            else if (sizeof(T) == 4)
            {
                return Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref left) == Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref right);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec4<T, TRoot> left, Vec4<T, TRoot> right)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                return Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref left) != Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref right);
            }
            else if (sizeof(T) == 4)
            {
                return Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref left) != Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref right);
            }
        }
        throw new NotSupportedException();
    }
    #endregion

    public static Vec4<T, TRoot> Zero { get; } = new();

    public static Vec4<T, TRoot> One { get; } = new(T.One, T.One, T.One, T.One);

    public static Vec4<T, TRoot> UnitX { get; } = new(T.One, T.Zero, T.Zero, T.Zero);

    public static Vec4<T, TRoot> UnitY { get; } = new(T.Zero, T.One, T.Zero, T.Zero);

    public static Vec4<T, TRoot> UnitZ { get; } = new(T.Zero, T.Zero, T.One, T.Zero);

    public static Vec4<T, TRoot> UnitW { get; } = new(T.Zero, T.Zero, T.Zero, T.One);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Add(Vec4<T, TRoot> left, Vec4<T, TRoot> right) => left + right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Subtract(Vec4<T, TRoot> left, Vec4<T, TRoot> right) => left - right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Multiply(Vec4<T, TRoot> left, Vec4<T, TRoot> right) => left * right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Multiply(Vec4<T, TRoot> left, T value) => left * value;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Multiply(T value, Vec4<T, TRoot> right) => right * value;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Divide(Vec4<T, TRoot> left, Vec4<T, TRoot> right) => left / right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Divide(Vec4<T, TRoot> left, T divisor) => left / divisor;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Negate(Vec4<T, TRoot> vec) => -vec;

    /* Thinking...
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<TI, TF> Normalize(Vector4<TI, TF> vec) => vec / Distance(vec, Zero);*/

    [MethodImpl(AggressiveInlining)]
    public static T Dot(Vec4<T, TRoot> vec1, Vec4<T, TRoot> vec2) => Sum(vec1 * vec2);

    [MethodImpl(AggressiveInlining)]
    public static TRoot Distance(Vec4<T, TRoot> vec1, Vec4<T, TRoot> vec2)
    {
        unsafe
        {
            if (sizeof(TRoot) == 8)
            {
                return Vector64.Sqrt(Vector64.Create(TRoot.CreateTruncating(DistanceSquared(vec1, vec2)))).ToScalar();
            }
            else if (sizeof(TRoot) == 4)
            {
                return Vector64.Sqrt(Vector64.Create(TRoot.CreateTruncating(DistanceSquared(vec1, vec2)))).ToScalar();
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared(Vec4<T, TRoot> vec1, Vec4<T, TRoot> vec2)
    {
        var sub = vec2 - vec1;
        return Dot(sub, sub);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly T LengthSquared() => Dot(this, this);

    [MethodImpl(AggressiveInlining)]
    public readonly TRoot Length()
    {
        unsafe
        {
            if (sizeof(TRoot) == 8)
            {
                return Vector64.Sqrt(Vector64.Create(TRoot.CreateTruncating(LengthSquared()))).ToScalar();
            }
            else if (sizeof(TRoot) == 4)
            {
                return Vector64.Sqrt(Vector64.Create(TRoot.CreateTruncating(LengthSquared()))).ToScalar();
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Abs(Vec4<T, TRoot> vec)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var abs = Vector256.Abs(Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref vec));

                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref abs);
            }
            else if (sizeof(T) == 4)
            {
                var abs = Vector128.Abs(Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref vec));

                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref abs);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static T Sum(Vec4<T, TRoot> vec)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                return Vector256.Sum(Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref vec));
            }
            else if (sizeof(T) == 4)
            {
                return Vector128.Sum(Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref vec));
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Clamp(Vec4<T, TRoot> vec, Vec4<T, TRoot> min, Vec4<T, TRoot> max)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var result = Vector256.Clamp
                (
                    Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref vec),
                    Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref min),
                    Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref max)
                );
                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref result);
            }
            else if (sizeof(T) == 4)
            {
                var result = Vector128.Clamp
                (
                    Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref vec),
                    Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref min),
                    Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref max)
                );
                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref result);
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

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Max(Vec4<T, TRoot> vec1, Vec4<T, TRoot> vec2)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var min = Vector256.Max
                (
                    Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref vec1),
                    Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref vec2)
                );
                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref min);
            }
            else if (sizeof(T) == 4)
            {
                var min = Vector128.Max
                (
                    Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref vec1),
                    Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref vec2)
                );
                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref min);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T, TRoot> Min(Vec4<T, TRoot> vec1, Vec4<T, TRoot> vec2)
    {
        unsafe
        {
            if (sizeof(T) == 8)
            {
                var min = Vector256.Min
                (
                    Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref vec1),
                    Unsafe.As<Vec4<T, TRoot>, Vector256<T>>(ref vec2)
                );
                return Unsafe.As<Vector256<T>, Vec4<T, TRoot>>(ref min);
            }
            else if (sizeof(T) == 4)
            {
                var min = Vector128.Min
                (
                    Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref vec1),
                    Unsafe.As<Vec4<T, TRoot>, Vector128<T>>(ref vec2)
                );
                return Unsafe.As<Vector128<T>, Vec4<T, TRoot>>(ref min);
            }
        }
        throw new NotSupportedException();
    }

    public override readonly string ToString() => $"{X};{Y};{Z};{W}";

    public override readonly bool Equals(object? obj) => (obj is Vec4<T, TRoot> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Vec4<T, TRoot> other) => this == other;
}
