namespace System.Numerics;

public partial struct Vec2<T>
{
    // called in right cases

    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<T> As128() => BitCast<Vec2<T>, Vector128<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private static Vec2<T> From128(Vector128<T> ymm) => BitCast<Vector128<T>, Vec2<T>>(ymm);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec2<TOther> As<TOther>() where TOther : unmanaged, INumber<TOther>
        => new(TOther.CreateTruncating(X), TOther.CreateTruncating(Y));
}
