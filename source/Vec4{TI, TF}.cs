using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Numerics;

// proposal to expose floating behavior for Length and Distance
[StructLayout(LayoutKind.Sequential)]
public partial struct Vec4<TI, TF>(TI x, TI y, TI z, TI w)
    where TI : unmanaged, INumber<TI>
    where TF : unmanaged, IFloatingPoint<TF>
{
    public TI X = x, Y = y, Z = z, W = w;

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> operator +(Vec4<TI, TF> left, Vec4<TI, TF> right)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var add = Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref left) + Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref right);

                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref add);
            }
            else if (sizeof(TI) == 4)
            {
                var add = Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref left) + Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref right);

                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref add);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> operator -(Vec4<TI, TF> left, Vec4<TI, TF> right)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var sub = Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref left) - Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref right);

                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref sub);
            }
            else if (sizeof(TI) == 4)
            {
                var sub = Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref left) - Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref right);

                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref sub);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> operator -(Vec4<TI, TF> value)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var neg = -Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref value);

                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref neg);
            }
            else if (sizeof(TI) == 4)
            {
                var neg = -Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref value);

                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref neg);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> operator *(Vec4<TI, TF> left, Vec4<TI, TF> right)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var mul = Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref left) * Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref right);

                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref mul);
            }
            else if (sizeof(TI) == 4)
            {
                var mul = Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref left) * Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref right);

                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref mul);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> operator *(Vec4<TI, TF> left, TI value)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var mul = Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref left) * value;

                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref mul);
            }
            else if (sizeof(TI) == 4)
            {
                var mul = Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref left) * value;

                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref mul);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> operator /(Vec4<TI, TF> left, Vec4<TI, TF> right)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var div = Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref left) / Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref right);

                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref div);
            }
            else if (sizeof(TI) == 4)
            {
                var div = Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref left) / Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref right);

                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref div);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> operator /(Vec4<TI, TF> left, TI value)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var div = Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref left) / value;

                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref div);
            }
            else if (sizeof(TI) == 4)
            {
                var div = Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref left) / value;

                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref div);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> operator *(TI value, Vec4<TI, TF> right) => right * value;

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec4<TI, TF> left, Vec4<TI, TF> right)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                return Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref left) == Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref right);
            }
            else if (sizeof(TI) == 4)
            {
                return Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref left) == Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref right);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec4<TI, TF> left, Vec4<TI, TF> right)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                return Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref left) != Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref right);
            }
            else if (sizeof(TI) == 4)
            {
                return Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref left) != Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref right);
            }
        }
        throw new NotSupportedException();
    }
    #endregion

    public static Vec4<TI, TF> Zero { get; } = new();

    public static Vec4<TI, TF> One { get; } = new(TI.One, TI.One, TI.One, TI.One);

    public static Vec4<TI, TF> UnitX { get; } = new(TI.One, TI.Zero, TI.Zero, TI.Zero);

    public static Vec4<TI, TF> UnitY { get; } = new(TI.Zero, TI.One, TI.Zero, TI.Zero);

    public static Vec4<TI, TF> UnitZ { get; } = new(TI.Zero, TI.Zero, TI.One, TI.Zero);

    public static Vec4<TI, TF> UnitW { get; } = new(TI.Zero, TI.Zero, TI.Zero, TI.One);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Add(Vec4<TI, TF> left, Vec4<TI, TF> right) => left + right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Subtract(Vec4<TI, TF> left, Vec4<TI, TF> right) => left - right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Multiply(Vec4<TI, TF> left, Vec4<TI, TF> right) => left * right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Multiply(Vec4<TI, TF> left, TI value) => left * value;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Multiply(TI value, Vec4<TI, TF> right) => right * value;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Divide(Vec4<TI, TF> left, Vec4<TI, TF> right) => left / right;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Divide(Vec4<TI, TF> left, TI divisor) => left / divisor;

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Negate(Vec4<TI, TF> vec) => -vec;

    /* Thinking...
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4<TI, TF> Normalize(Vector4<TI, TF> vec) => vec / Distance(vec, Zero);*/

    [MethodImpl(AggressiveInlining)]
    public static TI Dot(Vec4<TI, TF> vec1, Vec4<TI, TF> vec2) => Sum(vec1 * vec2);

    [MethodImpl(AggressiveInlining)]
    public static TF Distance(Vec4<TI, TF> vec1, Vec4<TI, TF> vec2)
    {
        unsafe
        {
            if (sizeof(TF) == 8)
            {
                return Vector64.Sqrt(Vector64.Create(TF.CreateTruncating(DistanceSquared(vec1, vec2)))).ToScalar();
            }
            else if (sizeof(TF) == 4)
            {
                return Vector64.Sqrt(Vector64.Create(TF.CreateTruncating(DistanceSquared(vec1, vec2)))).ToScalar();
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static TI DistanceSquared(Vec4<TI, TF> vec1, Vec4<TI, TF> vec2)
    {
        var sub = vec2 - vec1;
        return Dot(sub, sub);
    }

    [MethodImpl(AggressiveInlining)]
    public readonly TI LengthSquared() => Dot(this, this);

    [MethodImpl(AggressiveInlining)]
    public readonly TF Length()
    {
        unsafe
        {
            if (sizeof(TF) == 8)
            {
                return Vector64.Sqrt(Vector64.Create(TF.CreateTruncating(LengthSquared()))).ToScalar();
            }
            else if (sizeof(TF) == 4)
            {
                return Vector64.Sqrt(Vector64.Create(TF.CreateTruncating(LengthSquared()))).ToScalar();
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Abs(Vec4<TI, TF> vec)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var abs = Vector256.Abs(Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref vec));

                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref abs);
            }
            else if (sizeof(TI) == 4)
            {
                var abs = Vector128.Abs(Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref vec));

                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref abs);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static TI Sum(Vec4<TI, TF> vec)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                return Vector256.Sum(Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref vec));
            }
            else if (sizeof(TI) == 4)
            {
                return Vector128.Sum(Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref vec));
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Clamp(Vec4<TI, TF> vec, Vec4<TI, TF> min, Vec4<TI, TF> max)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var result = Vector256.Clamp
                (
                    Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref vec),
                    Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref min),
                    Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref max)
                );
                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref result);
            }
            else if (sizeof(TI) == 4)
            {
                var result = Vector128.Clamp
                (
                    Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref vec),
                    Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref min),
                    Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref max)
                );
                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref result);
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
    public static Vec4<TI, TF> Max(Vec4<TI, TF> vec1, Vec4<TI, TF> vec2)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var min = Vector256.Max
                (
                    Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref vec1),
                    Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref vec2)
                );
                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref min);
            }
            else if (sizeof(TI) == 4)
            {
                var min = Vector128.Max
                (
                    Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref vec1),
                    Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref vec2)
                );
                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref min);
            }
        }
        throw new NotSupportedException();
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TI, TF> Min(Vec4<TI, TF> vec1, Vec4<TI, TF> vec2)
    {
        unsafe
        {
            if (sizeof(TI) == 8)
            {
                var min = Vector256.Min
                (
                    Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref vec1),
                    Unsafe.As<Vec4<TI, TF>, Vector256<TI>>(ref vec2)
                );
                return Unsafe.As<Vector256<TI>, Vec4<TI, TF>>(ref min);
            }
            else if (sizeof(TI) == 4)
            {
                var min = Vector128.Min
                (
                    Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref vec1),
                    Unsafe.As<Vec4<TI, TF>, Vector128<TI>>(ref vec2)
                );
                return Unsafe.As<Vector128<TI>, Vec4<TI, TF>>(ref min);
            }
        }
        throw new NotSupportedException();
    }

    public override readonly string ToString() => $"{X};{Y};{Z};{W}";

    public override readonly bool Equals(object? obj) => (obj is Vec4<TI, TF> other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Vec4<TI, TF> other) => this == other;
}
