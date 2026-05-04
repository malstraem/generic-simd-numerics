using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

internal static class Vector128Extensions
{
    extension<T>(Vector128<T> a)
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> Estimate(Vector128<T> b, Vector128<T> c)
        {
            if (typeof(T) == typeof(float) && Fma.IsSupported)
                return Fma.MultiplyAdd(a.AsSingle(), b.AsSingle(), c.AsSingle()).As<float, T>();

            if (typeof(T) == typeof(double) && Fma.IsSupported)
                return Fma.MultiplyAdd(a.AsDouble(), b.AsDouble(), c.AsDouble()).As<double, T>();

            return (a * b) + c;
        }
    }
}
