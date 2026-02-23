namespace System.Numerics;

public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    internal readonly Vector128<T> As128() => BitCast<Vec4<T>, Vector128<T>>(this);

    [MethodImpl(AggressiveInlining)]
    internal readonly Vector256<T> As256() => BitCast<Vec4<T>, Vector256<T>>(this);

    [MethodImpl(AggressiveInlining)]
    internal static Vec4<T> From128(Vector128<T> vec) => BitCast<Vector128<T>, Vec4<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    internal static Vec4<T> From256(Vector256<T> vec) => BitCast<Vector256<T>, Vec4<T>>(vec);
}
