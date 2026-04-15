namespace System.Numerics;

// called in right cases
public partial struct Quat<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Multiply128(Quat<T> a, Quat<T> b)
    {
        var xmm = b.As128F();

        ((Vec4<float>)(object)a.Vec4()).Broadcast128(out var xx, out var yy, out var zz, out var ww);

        var res = xmm * ww;

        res = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(-1, 1, -1, 1f), Vector128.Create(3, 2, 1, 0)), xx, res);
        res = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(-1, -1, 1, 1f), Vector128.Create(2, 3, 0, 1)), yy, res);
        res = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(1, -1, -1, 1f), Vector128.Create(1, 0, 3, 2)), zz, res);

        unsafe { Vector128.Store(res.As<float, T>(), (T*)&a); }
        return a;
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Multiply256(Quat<T> a, Quat<T> b)
    {
        var ymm = b.As256D();

        ((Vec4<double>)(object)a.Vec4()).Broadcast256(out var xx, out var yy, out var zz, out var ww);

        var res = ymm * ww;
        res = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(-1d, 1d, -1d, 1d), Vector256.Create(3L, 2L, 1L, 0L)), xx, res);
        res = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(-1d, -1d, 1d, 1d), Vector256.Create(2L, 3L, 0L, 1L)), yy, res);
        res = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(1d, -1d, -1d, 1d), Vector256.Create(1L, 0L, 3L, 2L)), zz, res);

        unsafe { Vector256.Store(res.As<double, T>(), (T*)&a); }
        return a;
    }
}
