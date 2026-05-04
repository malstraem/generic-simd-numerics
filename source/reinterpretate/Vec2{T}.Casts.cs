namespace System.Numerics;

// calls in right cases
// not optimal asm
// check Vec2{T}.DISGUSTING_CARGO_CULT.cs for more
internal static class ReinterpretateVec2
{
    extension<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> As128() => Vector128<T>.Indices
            .WithElement(0, v.X)
            .WithElement(1, v.Y);
    }

    extension<T>(Vector128<T> xmm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec2<T> Vec2()
        {
            Vec2<T> v;
            v.X = xmm[0];
            v.Y = xmm[1];
            return v;
        }
    }
}
