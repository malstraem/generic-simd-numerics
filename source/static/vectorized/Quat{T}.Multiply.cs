namespace System.Numerics;

// called in right cases
public partial struct Quat<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Multiply128(Quat<T> a, Quat<T> b)
    {
        BitCast<Quat<T>, Vec4<float>>(a).Broadcast128(out var c, out var d, out var e, out var f);

        var q = BitCast<Quat<T>, Vector128<float>>(b);

        c *= Vector128.Shuffle(q, Vector128.Create(3, 2, 1, 0));
        d *= Vector128.Shuffle(q, Vector128.Create(2, 3, 0, 1));
        e *= Vector128.Shuffle(q, Vector128.Create(1, 0, 3, 2));

        q *= f;

        q = c.MultiplyAdd(Vector128.Create(+1, -1, +1, -1f), q);
        q = d.MultiplyAdd(Vector128.Create(+1, +1, -1, -1f), q);
        q = e.MultiplyAdd(Vector128.Create(-1, +1, +1, -1f), q);

        return BitCast<Vector128<float>, Quat<T>>(q);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Multiply256(Quat<T> a, Quat<T> b)
    {
        BitCast<Quat<T>, Vec4<double>>(a).Broadcast256(out var c, out var d, out var e, out var f);

        var q = BitCast<Quat<T>, Vector256<double>>(b);

        c *= Vector256.Shuffle(q, Vector256.Create(3, 2, 1, 0));
        d *= Vector256.Shuffle(q, Vector256.Create(2, 3, 0, 1));
        e *= Vector256.Shuffle(q, Vector256.Create(1, 0, 3, 2));

        q *= f;

        q = c.MultiplyAdd(Vector256.Create(+1, -1, +1, -1f), q);
        q = d.MultiplyAdd(Vector256.Create(+1, +1, -1, -1f), q);
        q = e.MultiplyAdd(Vector256.Create(-1, +1, +1, -1f), q);

        return BitCast<Vector256<double>, Quat<T>>(q);
    }
}
