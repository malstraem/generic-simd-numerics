using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

public static class Vector128Extensions
{
    extension<T>(Vector128<T> vec)
    {
        // should exist in System.Numerics
        [MethodImpl(AggressiveInlining | AggressiveOptimization)]
        public Vector128<T> MultiplyAdd(Vector128<T> b, Vector128<T> c)
        {
            if (typeof(T) == typeof(float) && Fma.IsSupported)
                return Fma.MultiplyAdd(vec.AsSingle(), b.AsSingle(), c.AsSingle()).As<float, T>();

            return (vec * b) + c;
        }
    }
}
