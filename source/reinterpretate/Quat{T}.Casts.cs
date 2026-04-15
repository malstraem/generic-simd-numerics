namespace System.Numerics;

// called in right cases
internal static class ReinterpretateQuat
{
    extension<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec4<T> Vec4() => BitCast<Quat<T>, Vec4<T>>(q);
    }

    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Quat<T> Quat() => BitCast<Vec4<T>, Quat<T>>(v);
    }
}
