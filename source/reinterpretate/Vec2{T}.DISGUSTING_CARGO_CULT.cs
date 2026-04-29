namespace System.Numerics;

/*
???

this SHIT CARGO CULT mirror System.Numerics.Vector2 handy asm to produce scalar moves as expected in call cases

actually it's AVX `vmovs{scalar size}` to xmm -> right ops -> `vmovs{scalar size} to ptr` -> feels good

slower in stress then naive cause JIT can't prove offsets and use regs instead, pls let me know JIT or ME is DUMMY
*/

public partial struct Vec2<T>
{
    [MethodImpl(AggressiveInlining)]
    private static unsafe Vector128<T> FromScalar<S>(S* v)
        where S : unmanaged, INumber<S> => Vector128.CreateScalar(*v).As<S, T>();

    [MethodImpl(AggressiveInlining)]
    private static S ToScalar<S>(Vector128<T> xmm)
        where S : unmanaged, INumber<S> => Vector128.As<T, S>(xmm).ToScalar();

    [MethodImpl(AggressiveInlining)]
    public static Vec2<T> operator +(Vec2<T> a, Vec2<T> b)
    {
        /* ???
        check generated asm

        float <-> 32-bit word
        double <-> 64-bit word

        && Vector128<size x2 type>.IsSupported is pointless? */

        if (Vector128<T>.IsSupported)
        {
            //return (a.As128() + b.As128()).Vec2(); // this way use WithElement call

            unsafe { AddUnsafe(&a, &b, &a); }
        }
        else
        {
            a.X += b.X;
            a.Y += b.Y;
        }
        return a;
    }

    [MethodImpl(AggressiveInlining)]
    public static unsafe void AddUnsafe(Vec2<T>* a, Vec2<T>* b, Vec2<T>* add)
    {
        if (SizeOf<T>() == 2)
        {
            AddUnsafe16(a, b, add);
            return;
        }
        if (SizeOf<T>() == 4)
        {
            AddUnsafe32(a, b, add);
            return;
        }
        // todo 64 for double/long/ulong
        add->X = a->X + b->X;
        add->Y = a->Y + b->Y;
    }

    [MethodImpl(AggressiveInlining)]
    public static unsafe void AddUnsafe16(Vec2<T>* a, Vec2<T>* b, Vec2<T>* add)
        => *(float*)add = ToScalar<float>(FromScalar((float*)a) + FromScalar((float*)b));

    [MethodImpl(AggressiveInlining)]
    public static unsafe void AddUnsafe32(Vec2<T>* a, Vec2<T>* b, Vec2<T>* add)
        => *(double*)add = ToScalar<double>(FromScalar((double*)a) + FromScalar((double*)b));
}
