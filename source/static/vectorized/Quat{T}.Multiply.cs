namespace System.Numerics;

// called in right cases
// todo non FMA way
// shuffle/permute can be generalized to Permute<T> with only byte indices, isn't?
public partial struct Quat<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Multiply128(Quat<T> a, Quat<T> b)
    {
        var xmm = BitCast<Quat<T>, Vector128<float>>(b);

        BitCast<Quat<T>, Vec4<float>>(a).Broadcast128(out var xx, out var yy, out var zz, out var ww);

        var q = xmm * ww;

        q = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(-1f, 1f, -1f, 1f), Vector128.Create(3, 2, 1, 0)), xx, q);
        q = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(-1f, -1f, 1f, 1f), Vector128.Create(2, 3, 0, 1)), yy, q);
        q = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(1f, -1f, -1f, 1f), Vector128.Create(1, 0, 3, 2)), zz, q);

        unsafe { Vector128.Store(q.As<float, T>(), (T*)&a); }
        return a;
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Multiply256(Quat<T> a, Quat<T> b)
    {
        var ymm = BitCast<Quat<T>, Vector256<double>>(b);

        BitCast<Quat<T>, Vec4<double>>(a).Broadcast256(out var xx, out var yy, out var zz, out var ww);

        var q = ymm * ww;
        q = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(-1d, 1d, -1d, 1d), Vector256.Create(3L, 2L, 1L, 0L)), xx, q);
        q = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(-1d, -1d, 1d, 1d), Vector256.Create(2L, 3L, 0L, 1L)), yy, q);
        q = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(1d, -1d, -1d, 1d), Vector256.Create(1L, 0L, 3L, 2L)), zz, q);

        unsafe { Vector256.Store(q.As<double, T>(), (T*)&a); }
        return a;
    }
}
