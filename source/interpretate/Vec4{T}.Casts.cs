using System.Runtime.Intrinsics;

namespace System.Numerics;

public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<T> As128() => Unsafe.BitCast<Vec4<T>, Vector128<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector256<T> As256() => Unsafe.BitCast<Vec4<T>, Vector256<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<float> As128F() => Unsafe.BitCast<Vec4<T>, Vector128<float>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector256<double> As256D() => Unsafe.BitCast<Vec4<T>, Vector256<double>>(this);

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> From128(Vector128<T> vec) => Unsafe.BitCast<Vector128<T>, Vec4<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> From256(Vector256<T> vec) => Unsafe.BitCast<Vector256<T>, Vec4<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> From128(Vector128<float> vec) => Unsafe.BitCast<Vector128<float>, Vec4<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> From256(Vector256<double> vec) => Unsafe.BitCast<Vector256<double>, Vec4<T>>(vec);
}
