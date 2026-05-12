using System.Diagnostics.CodeAnalysis;

namespace System.Numerics;

// unworthy - reduce performance :(
internal static class Vectorize
{
    [MethodImpl(AggressiveInlining)]
    internal static bool Is128<T>([ConstantExpected] int size)
        => SizeOf<T>() == size && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated;

    [MethodImpl(AggressiveInlining)]
    internal static bool Is256<T>([ConstantExpected] int size)
        => SizeOf<T>() == size && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated;
}
