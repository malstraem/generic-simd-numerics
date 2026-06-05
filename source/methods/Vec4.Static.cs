using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

public static class Vec4
{
    [Obsolete("add overload with target eps")]
    [MethodImpl(AggressiveInlining)]
    public static bool Equal<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return a.As128() == b.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return a.As256() == b.As256();

        return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
    }

    [Obsolete("add overload with target eps")]
    [MethodImpl(AggressiveInlining)]
    public static bool NotEqual<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return a.As128() != b.As128();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return a.As256() != b.As256();

        return a.X != b.X && a.Y != b.Y && a.Z != b.Z && a.W != b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool LessOrEqual<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.LessThanOrEqualAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.LessThanOrEqualAll(a.As256(), b.As256());

        return a.X <= b.X && a.Y <= b.Y && a.Z <= b.Z && a.W <= b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool GreaterOrEqual<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.GreaterThanOrEqualAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.GreaterThanOrEqualAll(a.As256(), b.As256());

        return a.X >= b.X && a.Y >= b.Y && a.Z >= b.Z && a.W >= b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool Greater<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.GreaterThanAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.GreaterThanAll(a.As256(), b.As256());

        return a.X > b.X && a.Y > b.Y && a.Z > b.Z && a.W > b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool Less<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.LessThanAll(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.LessThanAll(a.As256(), b.As256());

        return a.X < b.X && a.Y < b.Y && a.Z < b.Z && a.W < b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() + Vector128.Create(n)).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() + Vector256.Create(n)).Vec4();

        return new(v.X + n, v.Y + n, v.Z + n, v.W + n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Subtract<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() - Vector128.Create(n)).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() - Vector256.Create(n)).Vec4();

        return new(v.X - n, v.Y - n, v.Z - n, v.W - n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Add<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() + b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() + b.As256()).Vec4();

        return new(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Subtract<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() - b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() - b.As256()).Vec4();

        return new(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() * n).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() * n).Vec4();

        return new(v.X * n, v.Y * n, v.Z * n, v.W * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide<T>(Vec4<T> v, T n)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (v.As128() / n).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (v.As256() / n).Vec4();

        return new(v.X / n, v.Y / n, v.Z / n, v.W / n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Multiply<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() * b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() * b.As256()).Vec4();

        return new(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Divide<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return (a.As128() / b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return (a.As256() / b.As256()).Vec4();

        return new(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static T Sum<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Sum(v.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Sum(v.As256());

        return v.X + v.Y + v.Z + v.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Dot(a.As128(), b.As128());

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Dot(a.As256(), b.As256());

        return Sum(a * b);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Min<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Min(a.As128(), b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Min(a.As256(), b.As256()).Vec4();

        return new(T.Min(a.X, b.X), T.Min(a.Y, b.Y), T.Min(a.Z, b.Z), T.Min(a.W, b.W));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Max<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Max(a.As128(), b.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Max(a.As256(), b.As256()).Vec4();

        return new(T.Max(a.X, b.X), T.Max(a.Y, b.Y), T.Max(a.Z, b.Z), T.Max(a.W, b.W));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Clamp<T>(Vec4<T> v, Vec4<T> min, Vec4<T> max)
        where T : unmanaged, INumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Clamp(v.As128(), min.As128(), max.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Clamp(v.As256(), min.As256(), max.As256()).Vec4();

        return Min(max, Max(v, min));
    }

    // VectorNNN.Lerp<T> should exist, isn't?
    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Lerp<T>(Vec4<T> a, Vec4<T> b, T am)
        where T : unmanaged, INumber<T>
            => (a * (T.One - am)) + (b * am);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Transform<T>(Vec4<T> v, Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        Vec4<T> t;

        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            v.Broadcast(out var x, out var y, out var z, out var w);

            t = m.X * x;

            t = m.Y.Estimate(y, t);
            t = m.Z.Estimate(z, t);
            t = m.W.Estimate(w, t);
        }
        else
        {
            t = m.X * v.X;

            t += m.Y * v.Y;
            t += m.Z * v.Z;
            t += m.W * v.W;
        }
        return t;
    }

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
            => Dot(v, v);

    [MethodImpl(AggressiveInlining)]
    public static T DistanceSquared<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>
            => LengthSquared(a - b);

    [MethodImpl(AggressiveInlining)]
    public static T Length<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => T.Sqrt(LengthSquared(v));

    [MethodImpl(AggressiveInlining)]
    public static T Distance<T>(Vec4<T> a, Vec4<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => T.Sqrt(DistanceSquared(a, b));

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Normalize<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
            => v / Length(v);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> SquareRoot<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Sqrt(v.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Sqrt(v.As256()).Vec4();

        return new(T.Sqrt(v.X), T.Sqrt(v.Y), T.Sqrt(v.Z), T.Sqrt(v.W));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> Abs<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, ISignedNumber<T>
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
            return Vector128.Abs(v.As128()).Vec4();

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
            return Vector256.Abs(v.As256()).Vec4();

        return new(T.Abs(v.X), T.Abs(v.Y), T.Abs(v.Z), T.Abs(v.W));
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<TOther> As<T, TOther>(Vec4<T> v)
        where T : unmanaged, INumber<T>
        where TOther : unmanaged, INumber<TOther>
    {
        if (Avx.IsSupported)
        {
            if (typeof(T) == typeof(int))
            {
                if (typeof(TOther) == typeof(float))
                    return Avx.ConvertToVector128Single(v.As128().AsInt32()).As<float, TOther>().Vec4();

                if (typeof(TOther) == typeof(double))
                    return Avx.ConvertToVector256Double(v.As128().AsInt32()).As<double, TOther>().Vec4();
            }

            if (typeof(T) == typeof(float))
            {
                if (typeof(TOther) == typeof(int))
                    return Avx.ConvertToVector128Int32(v.As128().AsSingle()).As<int, TOther>().Vec4();

                if (typeof(TOther) == typeof(double))
                    return Avx.ConvertToVector256Double(v.As128().AsSingle()).As<double, TOther>().Vec4();
            }

            if (typeof(T) == typeof(double))
            {
                if (typeof(TOther) == typeof(int))
                    return Avx.ConvertToVector128Int32(v.As256().AsDouble()).As<int, TOther>().Vec4();

                if (typeof(TOther) == typeof(float))
                    return Avx.ConvertToVector128Single(v.As256().AsDouble()).As<float, TOther>().Vec4();
            }
        }
        return new Vec4<TOther>(
            TOther.CreateTruncating(v.X),
            TOther.CreateTruncating(v.Y),
            TOther.CreateTruncating(v.Z),
            TOther.CreateTruncating(v.W)
        );
    }
}
