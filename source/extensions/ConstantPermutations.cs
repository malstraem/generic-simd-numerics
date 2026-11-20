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
                => Vector128.Shuffle(v.AsInt32(), Vector128.Create(e0, e1, e2, e3)).As<int, T>();

        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> Permute8(
            [ConstantExpected] byte e0, [ConstantExpected] byte e1, [ConstantExpected] byte e2, [ConstantExpected] byte e3,
            [ConstantExpected] byte e4, [ConstantExpected] byte e5, [ConstantExpected] byte e6, [ConstantExpected] byte e7,
            [ConstantExpected] byte e8, [ConstantExpected] byte e9, [ConstantExpected] byte e10, [ConstantExpected] byte e11,
            [ConstantExpected] byte e12, [ConstantExpected] byte e13, [ConstantExpected] byte e14, [ConstantExpected] byte e15)
                => Vector128.Shuffle(v.AsByte(), Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15)).As<byte, T>();
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

        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> Permute16(
            [ConstantExpected] short e0, [ConstantExpected] short e1, [ConstantExpected] short e2, [ConstantExpected] short e3,
            [ConstantExpected] short e4, [ConstantExpected] short e5, [ConstantExpected] short e6, [ConstantExpected] short e7,
            [ConstantExpected] short e8, [ConstantExpected] short e9, [ConstantExpected] short e10, [ConstantExpected] short e11,
            [ConstantExpected] short e12, [ConstantExpected] short e13, [ConstantExpected] short e14, [ConstantExpected] short e15)
                => Vector256.Shuffle(v.AsInt16(), Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15)).As<short, T>();
    }

    extension<T>(Vector512<T> v)
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector512<T> Permute64(
            [ConstantExpected] byte e0, [ConstantExpected] byte e1, [ConstantExpected] byte e2, [ConstantExpected] byte e3,
            [ConstantExpected] byte e4, [ConstantExpected] byte e5, [ConstantExpected] byte e6, [ConstantExpected] byte e7)
                => Vector512.Shuffle(v.AsInt64(), Vector512.Create(e0, e1, e2, e3, e4, e5, e6, e7)).As<long, T>();

        [MethodImpl(AggressiveInlining)]
        internal Vector512<T> Permute32(
            [ConstantExpected] byte e0, [ConstantExpected] byte e1, [ConstantExpected] byte e2, [ConstantExpected] byte e3,
            [ConstantExpected] byte e4, [ConstantExpected] byte e5, [ConstantExpected] byte e6, [ConstantExpected] byte e7,
            [ConstantExpected] byte e8, [ConstantExpected] byte e9, [ConstantExpected] byte e10, [ConstantExpected] byte e11,
            [ConstantExpected] byte e12, [ConstantExpected] byte e13, [ConstantExpected] byte e14, [ConstantExpected] byte e15)
                => Vector512.Shuffle(v.AsInt32(), Vector512.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15)).As<int, T>();
    }
}
