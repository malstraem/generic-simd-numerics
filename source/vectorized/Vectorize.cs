using System.Diagnostics.CodeAnalysis;

namespace System.Numerics;

// unworthy - reduce performance :(
internal static class Vectorize<T>
{
    [MethodImpl(AggressiveInlining)]
    internal static bool Is128([ConstantExpected] int size)
        => SizeOf<T>() == size && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated;

    [MethodImpl(AggressiveInlining)]
    internal static bool Is256([ConstantExpected] int size)
        => SizeOf<T>() == size && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated;
}
