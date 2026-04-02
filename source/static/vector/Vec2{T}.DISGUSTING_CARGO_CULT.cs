namespace System.Numerics;

public partial struct Vec2<T>
{
    /* ???

    this CARGO CULT SHIT tries to mirror Vector2 handy asm to produce scalar moves as expected in call cases

    `vmovs{scalar size}` to xmm -> right ops -> `vmovs{scalar size} to ptr` -> feels good

    slower in stress cause JIT can't prove offsets on ptrs and use regs

    pls let me know JIT or ME is DUMB IDIOT */

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
            Vec2<T> vec;
            *(S*)&vec = Vector128.As<T, S>(xmm).ToScalar();
            return vec;
        }
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Vec2<T> operator +(Vec2<T> left, Vec2<T> right)
    {
        if (Vector128<T>.IsSupported)
        {
            if (SizeOf<T>() == 8)
                return From128(left.As128() + right.As128());

            /* ???
            float <-> 32-bit word
            double <-> 64-bit word

            && Vector128<size x2 type>.IsSupported is pointless? */

            if (typeof(T) == typeof(short) /*&& Vector128<float>.IsSupported*/)
                return From128S<float>(left.As128S<float>() + right.As128S<float>());

            if (typeof(T) == typeof(ushort))
                return From128S<float>(left.As128S<float>() + right.As128S<float>());

            if (typeof(T) == typeof(int))
                return From128S<double>(left.As128S<double>() + right.As128S<double>());

            if (typeof(T) == typeof(uint))
                return From128S<double>(left.As128S<double>() + right.As128S<double>());

            if (typeof(T) == typeof(float))
                return From128S<double>(left.As128S<double>() + right.As128S<double>());
        }
        return new(left.X + right.X, left.Y + right.Y);
    }
}
