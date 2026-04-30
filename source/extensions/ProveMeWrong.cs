using System.Diagnostics.CodeAnalysis;

namespace System.Numerics;

// why doesn't this just exist at System.Numerics with JIT fallback to naive?
internal static class ProveMeWrong
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
                => Vector128.Shuffle(v.AsInt32(), Vector128.Create(e0, e1, e2, e3)).As<int, T>();

        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> Permute16(
            [ConstantExpected] byte e0, [ConstantExpected] byte e1, [ConstantExpected] byte e2, [ConstantExpected] byte e3,
            [ConstantExpected] byte e4, [ConstantExpected] byte e5, [ConstantExpected] byte e6, [ConstantExpected] byte e7)
                => Vector128.Shuffle(v.AsInt16(), Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7)).As<short, T>();
    }

    extension<T>(Vector256<T> v)
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> Permute64(
            [ConstantExpected] byte e0, [ConstantExpected] byte e1, [ConstantExpected] byte e2, [ConstantExpected] byte e3)
                => Vector256.Shuffle(v.AsInt64(), Vector256.Create(e0, e1, e2, e3)).As<long, T>();

        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> Permute32(
            [ConstantExpected] byte e0, [ConstantExpected] byte e1, [ConstantExpected] byte e2, [ConstantExpected] byte e3,
            [ConstantExpected] byte e4, [ConstantExpected] byte e5, [ConstantExpected] byte e6, [ConstantExpected] byte e7)
                => Vector256.Shuffle(v.AsInt32(), Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7)).As<int, T>();
    }
}
