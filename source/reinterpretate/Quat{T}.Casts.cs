namespace System.Numerics;

// called in right cases
public partial struct Quat<T>
{
    [MethodImpl(AggressiveInlining)]
    private readonly Vec4<T> Vec4() => BitCast<Quat<T>, Vec4<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<float> As128F() => BitCast<Quat<T>, Vector128<float>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector256<double> As256D() => BitCast<Quat<T>, Vector256<double>>(this);
}
