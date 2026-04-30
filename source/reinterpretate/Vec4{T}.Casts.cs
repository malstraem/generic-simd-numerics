namespace System.Numerics;

// called in right cases
// reversed bitcasts are pessimized by JIT compilation, so the Store is now used
internal static class ReinterpretateVec4
{
    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> As128() => BitCast<Vec4<T>, Vector128<T>>(v);

        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> As256() => BitCast<Vec4<T>, Vector256<T>>(v);
    }

    extension<T>(Vector128<T> xmm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec4<T> Vec4()
        {
            Vec4<T> v;
            unsafe { xmm.Store((T*)&v); }
            return v;
        }
    }

    extension<T>(Vector256<T> ymm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec4<T> Vec4()
        {
            Vec4<T> v;
            unsafe { ymm.Store((T*)&v); }
            return v;
        }
    }
}
