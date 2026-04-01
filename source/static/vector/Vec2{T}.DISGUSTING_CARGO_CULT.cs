namespace System.Numerics;

public partial struct Vec2<T>
{
    /* ???

    this CARGO CULT SHIT tries tp mirror Vector2 hand asm to produce scalar movs as expected in call cases

    `vmovs{true size} -> right ops -> vmovs{true size}` -> feels good

    but whole code slower in stress cause JIT cant proof offsets

    pls let me know JIT or me is DUMB IDIOT */

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
}
