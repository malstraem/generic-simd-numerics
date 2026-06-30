using System.Diagnostics.CodeAnalysis;

namespace System.Numerics;

internal static class ConstantPermutations
{
    extension<T>(Vector128<T> v)
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> Permute64(
            [ConstantExpected] byte e0, [ConstantExpected] byte e1)
                => Vector128.Shuffle(v.AsInt64(), Vector128.Create(e0, e1)).As<long, T>();

        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> Permute32(
            [ConstantExpected] byte e0, [ConstantExpected] byte e1, [ConstantExpected] byte e2, [ConstantExpected] byte e3)
                => Vector128.Shuffle(v.AsSingle(), Vector128.Create(e0, e1, e2, e3)).As<float, T>();
    }

    extension<T>(Vector256<T> v)
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> Permute64(
            [ConstantExpected] byte e0, [ConstantExpected] byte e1, [ConstantExpected] byte e2, [ConstantExpected] byte e3)
                => Vector256.Shuffle(v.AsInt64(), Vector256.Create(e0, e1, e2, e3)).As<long, T>();
    }
}
