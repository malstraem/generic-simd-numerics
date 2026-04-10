namespace System.Numerics;

internal static class ReinterpretateVec2
{
    /* ???

    besides bitcast this CARGO CULT SHIT tries to mirror Vector2 handy asm to produce scalar moves as expected in call cases

    `vmovs{scalar size}` to xmm -> right ops -> `vmovs{scalar size} to ptr` -> feels good

    slower in stress cause JIT can't prove offsets on ptrs and use regs

    pls let me know JIT or ME is DUMB IDIOT */

    extension<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> As128() => BitCast<Vec2<T>, Vector128<T>>(v);

        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> As32()
        {
            unsafe
            {
                return Vector128.CreateScalar(*(int*)&v).As<int, T>();
            }
        }

        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> As64()
        {
            unsafe
            {
                return Vector128.CreateScalar(*(long*)&v).As<long, T>();
            }
        }
    }

    extension<T>(Vector128<T> xmm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec2<T> Vec2()
        {
            Vec2<T> v;
            unsafe { xmm.Store((T*)&v); }
            return v;
        }

        [MethodImpl(AggressiveInlining)]
        internal Vec2<T> Vec2S32()
        {
            Vec2<T> v;
            unsafe { *(int*)&v = Vector128.As<T, int>(xmm).ToScalar(); }
            return v;
        }

        [MethodImpl(AggressiveInlining)]
        internal Vec2<T> Vec2S64()
        {
            Vec2<T> v;
            unsafe { *(long*)&v = Vector128.As<T, long>(xmm).ToScalar(); }
            return v;
        }
    }
}
