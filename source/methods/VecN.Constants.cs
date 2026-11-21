namespace System.Numerics;

public static class VecNConstants
{
    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IFloatingPointConstants<T>
    {
        public Vec4<T> E
        {
            [MethodImpl(AggressiveInlining)]
            get
            {
                if (Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated && typeof(T) == typeof(float))
                    return Vector128<float>.E.As<float, T>().Vec4();

                if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated && typeof(T) == typeof(double))
                    return Vector256<double>.E.As<double, T>().Vec4();

                return new(T.E);
            }
        }

        public Vec4<T> Pi
        {
            [MethodImpl(AggressiveInlining)]
            get
            {
                if (Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated && typeof(T) == typeof(float))
                    return Vector128<float>.Pi.As<float, T>().Vec4();

                if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated && typeof(T) == typeof(double))
                    return Vector256<double>.Pi.As<double, T>().Vec4();

                return new(T.Pi);
            }
        }

        public Vec4<T> Tau
        {
            [MethodImpl(AggressiveInlining)]
            get
            {
                if (Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated && typeof(T) == typeof(float))
                    return Vector128<float>.Tau.As<float, T>().Vec4();

                if (Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated && typeof(T) == typeof(double))
                    return Vector256<double>.Tau.As<double, T>().Vec4();

                return new(T.Tau);
            }
        }
    }

    extension<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, IFloatingPointConstants<T>
    {
        public Vec3<T> E
        {
            [MethodImpl(AggressiveInlining)]
            get => new(T.E);
        }

        public Vec3<T> Pi
        {
            [MethodImpl(AggressiveInlining)]
            get => new(T.Pi);
        }

        public Vec3<T> Tau
        {
            [MethodImpl(AggressiveInlining)]
            get => new(T.Tau);
        }
    }

    extension<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>, IFloatingPointConstants<T>
    {
        public Vec2<T> E
        {
            [MethodImpl(AggressiveInlining)]
            get => new(T.E);
        }

        public Vec2<T> Pi
        {
            [MethodImpl(AggressiveInlining)]
            get => new(T.Pi);
        }

        public Vec2<T> Tau
        {
            [MethodImpl(AggressiveInlining)]
            get => new(T.Tau);
        }
    }
}
