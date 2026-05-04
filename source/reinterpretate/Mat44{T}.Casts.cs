namespace System.Numerics;

// calls in right cases
// reversed bitcasts are pessimized by JIT compilation, so the Store is now used
internal static class ReinterpretateMat44
{
    extension<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> As256() => BitCast<Mat44<T>, Vector256<T>>(m);

        [MethodImpl(AggressiveInlining)]
        internal Vector512<T> As512() => BitCast<Mat44<T>, Vector512<T>>(m);

        [MethodImpl(AggressiveInlining)]
        internal void As512(out Vector512<T> xy, out Vector512<T> zw)
        {
            unsafe
            {
                xy = Vector512.Load(&m.X.X);
                zw = Vector512.Load(&m.Z.X);
            }
        }
    }

    extension<T>(Vector256<T> ymm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Mat44<T> Mat44()
        {
            Mat44<T> m;
            unsafe { ymm.Store((T*)&m); }
            return m;
        }
    }

    extension<T>(Vector512<T> zmm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Mat44<T> Mat44()
        {
            Mat44<T> m;
            unsafe { zmm.Store((T*)&m); }
            return m;
        }

        [MethodImpl(AggressiveInlining)]
        internal Mat44<T> Mat44(Vector512<T> zw)
        {
            Mat44<T> m;
            unsafe
            {
                var p = (T*)&m;

                zmm.Store(p);
                zw.Store(p + 8);
            }
            return m;
        }
    }
}
