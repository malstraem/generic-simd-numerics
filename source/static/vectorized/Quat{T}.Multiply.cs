namespace System.Numerics;

// called in right cases

// any ways to 256 float and 512 double?
public partial struct Quat<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Multiply128F(Quat<T> a, Quat<T> b)
    {
        Vec4<T>.Broadcast128(a.Vec4(), out var c, out var d, out var e, out var f);

        var q = b.As128();

        c *= q.Permute32(3, 2, 1, 0);
        d *= q.Permute32(2, 3, 0, 1);
        e *= q.Permute32(1, 0, 3, 2);

        q *= f;

        q = c.MultiplyAdd(Vector128.Create(+1, -1, +1, -1f).As<float, T>(), q);
        q = d.MultiplyAdd(Vector128.Create(+1, +1, -1, -1f).As<float, T>(), q);
        q = e.MultiplyAdd(Vector128.Create(-1, +1, +1, -1f).As<float, T>(), q);

        return q.Quat();
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Multiply256D(Quat<T> a, Quat<T> b)
    {
        a.Vec4().Broadcast256(out var c, out var d, out var e, out var f);

        var q = b.As256();

        c *= q.Permute64(3, 2, 1, 0);
        d *= q.Permute64(2, 3, 0, 1);
        e *= q.Permute64(1, 0, 3, 2);

        q *= f;

        q = c.MultiplyAdd(Vector256.Create(+1, -1, +1, -1d).As<double, T>(), q);
        q = d.MultiplyAdd(Vector256.Create(+1, +1, -1, -1d).As<double, T>(), q);
        q = e.MultiplyAdd(Vector256.Create(-1, +1, +1, -1d).As<double, T>(), q);

        return q.Quat();
    }
}
