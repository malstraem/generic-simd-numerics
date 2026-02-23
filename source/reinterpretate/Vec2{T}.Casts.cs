namespace System.Numerics;

public partial struct Vec2<T>
{
    [MethodImpl(AggressiveInlining)]
    private readonly Vector64<T> As64() => BitCast<Vec2<T>, Vector64<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<T> As128() => BitCast<Vec2<T>, Vector128<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private static Vec2<T> From64(Vector64<T> vec) => BitCast<Vector64<T>, Vec2<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    private static Vec2<T> From128(Vector128<T> vec) => BitCast<Vector128<T>, Vec2<T>>(vec);
}
