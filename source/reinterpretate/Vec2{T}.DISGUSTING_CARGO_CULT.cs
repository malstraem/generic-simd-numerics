namespace System.Numerics;

/*
???

this SHIT CARGO CULT mirror System.Numerics.Vector2 handy asm to produce scalar moves as expected in call cases

actually it's AVX `vmovs{scalar size}` to xmm -> right ops -> `vmovs{scalar size} to ptr` -> feels good

slower in stress then naive cause JIT can't prove offsets and use regs instead, pls let me know JIT or ME is DUMMY

this scalar moves should be generalized on Numerics or/and JIT level
to implement fully vectorized Vec2/3/4 and fallback to naive when ISA is not support that
*/

public partial struct Vec2<T>
{
    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<T> As128S<S>()
        where S : unmanaged, INumber<S>
    {
        unsafe
        {
            fixed (T* p = &X)
                return Vector128.CreateScalar(*(S*)p).As<S, T>();
        }
    }

    [MethodImpl(AggressiveInlining)]
    private static Vec2<T> From128S<S>(Vector128<T> xmm)
        where S : unmanaged, INumber<S>
    {
        unsafe
        {
            Vec2<T> v;
            *(S*)&v = Vector128.As<T, S>(xmm).ToScalar();
            return v;
        }
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Vec2<T> operator +(Vec2<T> a, Vec2<T> b)
    {
        //if (Vector128<T>.IsSupported)
        //    return (a.As128() + b.As128()).Vec2(); // this way use WithElement call

        if (Vector128<T>.IsSupported)
        {
            /* ???
            check generated asm

            float <-> 32-bit word
            double <-> 64-bit word

            && Vector128<size x2 type>.IsSupported is pointless? */

            if (typeof(T) == typeof(short) || (typeof(T) == typeof(ushort) /*&& Vector128<float>.IsSupported*/))
                return From128S<float>(a.As128S<float>() + b.As128S<float>());

            if (typeof(T) == typeof(int) || typeof(T) == typeof(uint) || typeof(T) == typeof(float))
                return From128S<double>(a.As128S<double>() + b.As128S<double>());
        }
        return new(a.X + b.X, a.Y + b.Y);
    }
}
