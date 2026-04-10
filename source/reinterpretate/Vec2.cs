namespace System.Numerics;

public partial struct Vec2<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Vec2<T> operator +(Vec2<T> a, Vec2<T> b)
    {
        if (Vector128<T>.IsSupported)
        {
            if (SizeOf<T>() == 8)
                return (a.As128() + b.As128()).Vec2();

            /* ???
            float <-> 32-bit word
            double <-> 64-bit word

            && Vector128<size x2 type>.IsSupported is pointless? */

            if (typeof(T) == typeof(short) /*&& Vector128<float>.IsSupported*/)
                return (a.As32() + b.As32()).Vec2S32();

            if (typeof(T) == typeof(ushort))
                return (a.As32() + b.As32()).Vec2S32();

            if (typeof(T) == typeof(int))
                return (a.As64() + b.As64()).Vec2S64();

            if (typeof(T) == typeof(uint))
                return (a.As64() + b.As64()).Vec2S64();

            if (typeof(T) == typeof(float))
                return (a.As64() + b.As64()).Vec2S64();
        }
        return new(a.X + b.X, a.Y + b.Y);
    }
}
