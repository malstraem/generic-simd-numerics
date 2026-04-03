namespace System.Numerics;

public partial struct Vec4<T>
{
    // called in right cases

    [MethodImpl(AggressiveInlining)]
    internal readonly Vector128<T> As128() => BitCast<Vec4<T>, Vector128<T>>(this);

    [MethodImpl(AggressiveInlining)]
    internal readonly Vector256<T> As256() => BitCast<Vec4<T>, Vector256<T>>(this);

    [MethodImpl(AggressiveInlining)]
    internal static Vec4<T> From128(Vector128<T> xmm) => BitCast<Vector128<T>, Vec4<T>>(xmm);

    [MethodImpl(AggressiveInlining)]
    internal static Vec4<T> From256(Vector256<T> ymm) => BitCast<Vector256<T>, Vec4<T>>(ymm);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<TOther> As<TOther>() where TOther : unmanaged, INumber<TOther>
        => new(TOther.CreateTruncating(X), TOther.CreateTruncating(Y), TOther.CreateTruncating(Z), TOther.CreateTruncating(W));
}
