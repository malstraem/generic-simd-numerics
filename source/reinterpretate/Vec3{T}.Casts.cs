namespace System.Numerics;

public partial struct Vec3<T>
{
    // called in right cases

    [MethodImpl(AggressiveInlining)]
    internal readonly Vector128<T> As128()
    {
        // something smarter? both variants are not optimal asm

        return Vector128<T>.One
            .WithElement(0, X)
            .WithElement(1, Y)
            .WithElement(2, Z);
    }

    [MethodImpl(AggressiveInlining)]
    internal readonly Vector256<T> As256()
    {
        return Vector256<T>.One
            .WithElement(0, X)
            .WithElement(1, Y)
            .WithElement(2, Z);
    }

    [MethodImpl(AggressiveInlining)]
    internal static Vec3<T> From128(Vector128<T> xmm) => As<Vector128<T>, Vec3<T>>(ref xmm);

    [MethodImpl(AggressiveInlining)]
    internal static Vec3<T> From256(Vector256<T> ymm) => As<Vector256<T>, Vec3<T>>(ref ymm);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec3<TOther> As<TOther>() where TOther : unmanaged, INumber<TOther>
        => new(TOther.CreateTruncating(X), TOther.CreateTruncating(Y), TOther.CreateTruncating(Z));
}
