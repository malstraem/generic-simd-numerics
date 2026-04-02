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
            {
                return Fma.MultiplyAdd(vec.AsSingle(), b.AsSingle(), c.AsSingle()).As<float, T>();
            }
            else
            {
                return (vec * b) + c;
            }
        }
    }

    //extension(Vector128)
    //{

    //    // should exist in System.Numerics
    //    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    //    public static Vector128<T> Shuffle<T>(Vector128<T> b, Vector128<int> c)
    //    {
    //        if (typeof(T) == typeof(float))
    //        {
    //            return Vector128.Shuffle(b.AsSingle(), c).As<float, T>();
    //        }
    //        else
    //        {
    //            return Vector128.Create([b[c[0]], b[c[1]], b[c[2]], b[c[3]]]);
    //        }
    //    }
    //}
}
