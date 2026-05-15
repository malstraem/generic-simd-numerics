namespace System.Numerics;

public static class Vec4Extensions
{
    extension<T>(Vec4<T> a)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec4<T> Estimate(T b, Vec4<T> c)
        {
            if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
                return a.As128().Estimate(Vector128.Create(b), c.As128()).Vec4();

            if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
                return a.As256().Estimate(Vector256.Create(b), c.As256()).Vec4();

            return (a * b) + c;
        }

        [MethodImpl(AggressiveInlining)]
        internal Vec4<T> Estimate(Vec4<T> b, Vec4<T> c)
        {
            if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
                return a.As128().Estimate(b.As128(), c.As128()).Vec4();

            if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
                return a.As256().Estimate(b.As256(), c.As256()).Vec4();

            return (a * b) + c;
        }
    }
}
