using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

internal static class Vector256Extensions
{
    extension<T>(Vector256<T> a)
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> Estimate(Vector256<T> b, Vector256<T> c)
        {
            if (typeof(T) == typeof(float) && Fma.IsSupported)
                return Fma.MultiplyAdd(a.AsSingle(), b.AsSingle(), c.AsSingle()).As<float, T>();

            if (typeof(T) == typeof(double) && Fma.IsSupported)
                return Fma.MultiplyAdd(a.AsDouble(), b.AsDouble(), c.AsDouble()).As<double, T>();

            return (a * b) + c;
        }
    }
}
