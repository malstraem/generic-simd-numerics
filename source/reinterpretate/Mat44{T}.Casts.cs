namespace System.Numerics;

public partial struct Mat44<T>
{
    // called in right cases

    [MethodImpl(AggressiveInlining)]
    private readonly Vector256<T> As256() => BitCast<Mat44<T>, Vector256<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector512<T> As512() => BitCast<Mat44<T>, Vector512<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> From256(Vector256<T> vec) => BitCast<Vector256<T>, Mat44<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> From512(Vector512<T> vec) => BitCast<Vector512<T>, Mat44<T>>(vec);
}
