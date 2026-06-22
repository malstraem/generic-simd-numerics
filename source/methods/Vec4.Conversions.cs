using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

// dummy

public static partial class Vec4
{
    [MethodImpl(AggressiveInlining)]
    private static Vec4<T2> Scalar<T, T2>(Vec4<T> v)
        where T : unmanaged, INumber<T>
        where T2 : unmanaged, INumber<T2> => new(
            T2.CreateTruncating(v.X),
            T2.CreateTruncating(v.Y),
            T2.CreateTruncating(v.Z),
            T2.CreateTruncating(v.W));

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T2> Convert32<T, T2>(Vec4<T> v)
        where T : unmanaged, INumber<T>
        where T2 : unmanaged, INumber<T2>
    {
        if (SizeOf<T2>() == 4 && Vector128<T>.IsSupported && Vector128<T2>.IsSupported && Vector128.IsHardwareAccelerated)
        {
            if (typeof(T) == typeof(int) && typeof(T2) == typeof(float))
                return Vector128.ConvertToSingle(v.As128().AsInt32()).As<float, T2>().Vec4();

            if (typeof(T) == typeof(float) && typeof(T2) == typeof(int))
                return Vector128.ConvertToInt32(v.As128().AsSingle()).As<int, T2>().Vec4();
            // ...
            // another type cases
        }

        if (SizeOf<T2>() == 8)
        {
            if (typeof(T) == typeof(float) && typeof(T2) == typeof(double))
            {
                if (Avx.IsSupported)
                    return Avx.ConvertToVector256Double(v.As128().AsSingle()).As<double, T2>().Vec4();
                // ...
                // another ISA
            }

            if (typeof(T) == typeof(int) && typeof(T2) == typeof(double))
            {
                if (Avx.IsSupported)
                    return Avx.ConvertToVector256Double(v.As128().AsInt32()).As<double, T2>().Vec4();
                // ...
                // another ISA
            }
            // ...
            // another type cases
        }
        return Scalar<T, T2>(v);
    }

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T2> Convert64<T, T2>(Vec4<T> v)
        where T : unmanaged, INumber<T>
        where T2 : unmanaged, INumber<T2>
    {
        if (SizeOf<T2>() == 8 && Vector256<T>.IsSupported && Vector256<T2>.IsSupported && Vector256.IsHardwareAccelerated)
        {
            if (typeof(T) == typeof(long) && typeof(T2) == typeof(double))
                return Vector256.ConvertToDouble(v.As256().AsInt64()).As<double, T2>().Vec4();

            if (typeof(T) == typeof(double) && typeof(T2) == typeof(long))
                return Vector256.ConvertToInt64(v.As256().AsDouble()).As<long, T2>().Vec4();
            // ...
            // another type cases
        }

        if (SizeOf<T2>() == 4)
        {
            if (typeof(T) == typeof(double) && typeof(T2) == typeof(float))
            {
                if (Avx.IsSupported)
                    return Avx.ConvertToVector128Single(v.As256().AsDouble()).As<float, T2>().Vec4();
                // ...
                // another ISA
            }

            if (typeof(T) == typeof(double) && typeof(T2) == typeof(int))
            {
                if (Avx.IsSupported)
                    return Avx.ConvertToVector128Int32(v.As256().AsDouble()).As<int, T2>().Vec4();
                // ...
                // another ISA
            }
            // ...
            // another type cases
        }
        return Scalar<T, T2>(v);
    }

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T2> As<T, T2>(Vec4<T> v)
        where T : unmanaged, INumber<T>
        where T2 : unmanaged, INumber<T2>
    {
        if (SizeOf<T>() == 4)
            return Convert32<T, T2>(v);

        if (SizeOf<T>() == 8)
            return Convert64<T, T2>(v);

        return new Vec4<T2>(
            T2.CreateTruncating(v.X),
            T2.CreateTruncating(v.Y),
            T2.CreateTruncating(v.Z),
            T2.CreateTruncating(v.W)
        );
    }
}
