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
            {
                return Fma.MultiplyAdd(vec.AsSingle(), b.AsSingle(), c.AsSingle()).As<float, T>();
            }
            else if (typeof(T) == typeof(double) && Fma.IsSupported)
            {
                return Fma.MultiplyAdd(vec.AsDouble(), b.AsDouble(), c.AsDouble()).As<double, T>();
            }
            else
            {
                return (vec * b) + c;
            }
        }
    }

    extension(Vector256)
    {
        // should exist in System.Numerics
        [MethodImpl(AggressiveInlining | AggressiveOptimization)]
        public static Vector256<T> Shuffle<T>(Vector256<T> b, Vector256<long> c)
        {
            if (typeof(T) == typeof(double))
            {
                return Vector256.ShuffleNative(b.AsDouble(), c).As<double, T>();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
