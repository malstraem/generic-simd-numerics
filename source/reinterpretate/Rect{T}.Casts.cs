namespace System.Numerics;

// called in right cases
// reversed bitcasts are pessimized by JIT compilation, so the Store is now used
internal static class ReinterpretateRect
{
    extension<T>(Rect<T> r)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> As128() => BitCast<Rect<T>, Vector128<T>>(r);

        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> As256() => BitCast<Rect<T>, Vector256<T>>(r);

        [MethodImpl(AggressiveInlining)]
        internal Vec4<T> Vec4() => BitCast<Rect<T>, Vec4<T>>(r);
    }

    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Rect<T> Rect() => BitCast<Vec4<T>, Rect<T>>(v);
    }

    extension<T>(Vector128<T> xmm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Rect<T> Rect()
        {
            Rect<T> r;
            unsafe { xmm.Store((T*)&r); }
            return r;
        }
    }

    extension<T>(Vector256<T> ymm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Rect<T> Rect()
        {
            Rect<T> r;
            unsafe { ymm.Store((T*)&r); }
            return r;
        }
    }
}
