namespace System.Numerics;

// proof of concept of a fully generalized permutation
// that must exist at System.Numerics with JIT fallback to naive
internal static class ProveMeWrong
{
    extension<T>(Vector128<T> v)
    {
        // why doesn't this just exist?

        [MethodImpl(AggressiveInlining | AggressiveOptimization)]
        internal Vector128<T> Permute64(byte e0, byte e1)
            => Vector128.Shuffle(v.AsInt64(), Vector128.Create(e0, e1)).As<long, T>();

        [MethodImpl(AggressiveInlining | AggressiveOptimization)]
        internal Vector128<T> Permute32(byte e0, byte e1, byte e2, byte e3)
            => Vector128.Shuffle(v.AsInt32(), Vector128.Create(e0, e1, e2, e3)).As<int, T>();

        [MethodImpl(AggressiveInlining | AggressiveOptimization)]
        internal Vector128<T> Permute16(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7)
            => Vector128.Shuffle(v.AsInt16(), Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7)).As<short, T>();
    }

    extension<T>(Vector256<T> v)
    {
        // why doesn't this just exist?

        [MethodImpl(AggressiveInlining | AggressiveOptimization)]
        internal Vector256<T> Permute64(byte e0, byte e1, byte e2, byte e3)
            => Vector256.Shuffle(v.AsInt64(), Vector256.Create(e0, e1, e2, e3)).As<long, T>();

        [MethodImpl(AggressiveInlining | AggressiveOptimization)]
        internal Vector256<T> Permute32(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7)
            => Vector256.Shuffle(v.AsInt32(), Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7)).As<int, T>();
    }
}
