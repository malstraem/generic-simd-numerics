namespace System.Numerics;

// called in right cases
// both 128 and 256 are not optimal asm
// check Vec2{T}.DISGUSTING_CARGO_CULT.cs for more
internal static class ReinterpretateVec3
{
    extension<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> As128() => Vector128<T>.Indices
            .WithElement(0, v.X)
            .WithElement(1, v.Y)
            .WithElement(2, v.Z);

        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> As256() => Vector256<T>.Indices
            .WithElement(0, v.X)
            .WithElement(1, v.Y)
            .WithElement(2, v.Z);
    }

    extension<T>(Vector128<T> xmm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec3<T> Vec3() => new(xmm.GetElement(0), xmm.GetElement(1), xmm.GetElement(2));
    }

    extension<T>(Vector256<T> ymm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec3<T> Vec3() => new(ymm.GetElement(0), ymm.GetElement(1), ymm.GetElement(2));
    }
}
