namespace System.Numerics;

public static class Vec4Signed
{
    extension<T>(Vec4<T>)
        where T : unmanaged, INumber<T>, ISignedNumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        public static Vec4<T> operator +(Vec4<T> v)
        {
            if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
                return (+v.As128()).Vec4();

            if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
                return (+v.As256()).Vec4();

            return new(+v.X, +v.Y, +v.Z, +v.W);
        }

        [MethodImpl(AggressiveInlining)]
        public static Vec4<T> operator -(Vec4<T> v)
        {
            if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
                return (-v.As128()).Vec4();

            if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
                return (-v.As256()).Vec4();

            return new(-v.X, -v.Y, -v.Z, -v.W);
        }
    }

    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, ISignedNumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        public Vec4<T> Abs()
        {
            if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
                return Vector128.Abs(v.As128()).Vec4();

            if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
                return Vector256.Abs(v.As256()).Vec4();

            return new(T.Abs(v.X), T.Abs(v.Y), T.Abs(v.Z), T.Abs(v.W));
        }
    }
}
