using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

public static class Vec4Extensions
{
    extension<T>(Vec4<T> a)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec4<T> Estimate(Vec4<T> b, Vec4<T> c)
        {
            if (typeof(T) == typeof(float) && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated && Fma.IsSupported)
                return Fma.MultiplyAdd(a.As128().AsSingle(), b.As128().AsSingle(), c.As128().AsSingle()).As<float, T>().Vec4();

            if (typeof(T) == typeof(double) && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated && Fma.IsSupported)
                return Fma.MultiplyAdd(a.As256().AsDouble(), b.As256().AsDouble(), c.As256().AsDouble()).As<double, T>().Vec4();

            return (a * b) + c;
        }
    }
}
