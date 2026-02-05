using System.Runtime.Intrinsics;

namespace System.Numerics;

public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    internal readonly Vector128<T> As128()
    {
        var vec = this;
        return Unsafe.As<Vec4<T>, Vector128<T>>(ref vec);
    }

    [MethodImpl(AggressiveInlining)]
    internal readonly Vector256<T> As256() => Unsafe.BitCast<Vec4<T>, Vector256<T>>(this);

    [MethodImpl(AggressiveInlining)]
    internal readonly Vector128<float> As128F() => Unsafe.BitCast<Vec4<T>, Vector128<float>>(this);

    [MethodImpl(AggressiveInlining)]
    internal readonly Vector256<double> As256D() => Unsafe.BitCast<Vec4<T>, Vector256<double>>(this);

    [MethodImpl(AggressiveInlining)]
    internal static Vec4<T> From128(Vector128<T> vec) => Unsafe.BitCast<Vector128<T>, Vec4<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    internal static Vec4<T> From256(Vector256<T> vec) => Unsafe.BitCast<Vector256<T>, Vec4<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    internal static Vec4<T> From128(Vector128<float> vec) => Unsafe.BitCast<Vector128<float>, Vec4<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    internal static Vec4<T> From256(Vector256<double> vec) => Unsafe.BitCast<Vector256<double>, Vec4<T>>(vec);
}
