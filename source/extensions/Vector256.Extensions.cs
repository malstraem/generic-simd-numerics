using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

public static class Vector256Extensions
{
    extension<T>(Vector256<T> vec)
    {
        // should exist in System.Numerics
        [MethodImpl(AggressiveInlining | AggressiveOptimization)]
        public Vector256<T> MultiplyAdd(Vector256<T> b, Vector256<T> c)
        {
            if (typeof(T) == typeof(float) && Fma.IsSupported)
                return Fma.MultiplyAdd(vec.AsSingle(), b.AsSingle(), c.AsSingle()).As<float, T>();

            if (typeof(T) == typeof(double) && Fma.IsSupported)
                return Fma.MultiplyAdd(vec.AsDouble(), b.AsDouble(), c.AsDouble()).As<double, T>();

            return (vec * b) + c;
        }
    }
}
