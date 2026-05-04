namespace System.Numerics;

// calls in right cases
// reversed bitcasts are pessimized by JIT compilation, so the Store is now used
internal static class ReinterpretateQuat
{
    extension<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> As128() => BitCast<Quat<T>, Vector128<T>>(q);

        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> As256() => BitCast<Quat<T>, Vector256<T>>(q);

        [MethodImpl(AggressiveInlining)]
        internal Vec4<T> Vec4() => BitCast<Quat<T>, Vec4<T>>(q);
    }

    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Quat<T> Quat() => BitCast<Vec4<T>, Quat<T>>(v);
    }

    extension<T>(Vector128<T> xmm)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Quat<T> Quat()
        {
            Quat<T> q;
            unsafe { xmm.Store((T*)&q); }
            return q;
        }
    }

    extension<T>(Vector256<T> ymm)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Quat<T> Quat()
        {
            Quat<T> q;
            unsafe { ymm.Store((T*)&q); }
            return q;
        }
    }
}
