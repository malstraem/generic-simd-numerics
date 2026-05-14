namespace System.Numerics;

// calls in right cases
// both 128 and 256 are not optimal asm
// check Vec2{T}.DISGUSTING_CARGO_CULT.cs for more
internal static class ReinterpretateVec3
{
    extension<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> As256() => Vector256<T>.Zero
            .WithElement(0, v.X)
            .WithElement(1, v.Y)
            .WithElement(2, v.Z);

        [MethodImpl(AggressiveInlining | AggressiveOptimization)]
        internal Vector128<T> As128()
        {
            unsafe
            {
                return Vector128<T>.Zero
                    .WithElement(0, *&v.X)
                    .WithElement(1, *(&v.X + 1))
                    .WithElement(2, *(&v.X + 2));
            }
        }

        [MethodImpl(AggressiveInlining)]
        internal Vector128<T> As128One() => Vector128<T>.One
            .WithElement(0, v.X)
            .WithElement(1, v.Y)
            .WithElement(2, v.Z);

        [MethodImpl(AggressiveInlining)]
        internal Vector256<T> As256One() => Vector256<T>.One
            .WithElement(0, v.X)
            .WithElement(1, v.Y)
            .WithElement(2, v.Z);
    }

    extension<T>(Vector128<T> xmm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec3<T> Vec3()
        {
            Vec3<T> v;
            v.X = xmm[0]; v.Y = xmm[1]; v.Z = xmm[2];
            return v;
        }
    }

    extension<T>(Vector256<T> ymm)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec3<T> Vec3() => new(ymm[0], ymm[1], ymm[2]);
    }
}
