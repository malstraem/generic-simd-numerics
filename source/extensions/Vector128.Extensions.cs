using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

internal static class Vector128Extensions
{
    extension<T>(Vector128<T> a)
    {
        // should exist in System.Numerics
        [MethodImpl(AggressiveInlining | AggressiveOptimization)]
        internal Vector128<T> MultiplyAdd(Vector128<T> b, Vector128<T> c)
        {
            if (typeof(T) == typeof(float) && Fma.IsSupported)
                return Fma.MultiplyAdd(a.AsSingle(), b.AsSingle(), c.AsSingle()).As<float, T>();

            return (a * b) + c;
        }
    }
}
