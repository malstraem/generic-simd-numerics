namespace System.Numerics;

// calls in right cases
// any ways to 256 float and 512 double?
public partial struct Quat<T>
{
    [MethodImpl(AggressiveInlining)]
    private static Quat<T> Multiply128(Quat<T> a, Quat<T> b)
    {
        a.Vec4().Broadcast128(out var c, out var d, out var e, out var f);

        var q = b.As128();

        c *= q.Permute32(3, 2, 1, 0);
        d *= q.Permute32(2, 3, 0, 1);
        e *= q.Permute32(1, 0, 3, 2);

        q *= f;

        q = c.Estimate(Vector128.Create(+1, -1, +1, -1f).As<float, T>(), q);
        q = d.Estimate(Vector128.Create(+1, +1, -1, -1f).As<float, T>(), q);
        q = e.Estimate(Vector128.Create(-1, +1, +1, -1f).As<float, T>(), q);

        return q.Quat();
    }

    [MethodImpl(AggressiveInlining)]
    private static Quat<T> Multiply256(Quat<T> a, Quat<T> b)
    {
        a.Vec4().Broadcast256(out var c, out var d, out var e, out var f);

        var q = b.As256();

        c *= q.Permute64(3, 2, 1, 0);
        d *= q.Permute64(2, 3, 0, 1);
        e *= q.Permute64(1, 0, 3, 2);

        q *= f;

        q = c.Estimate(Vector256.Create(+1, -1, +1, -1d).As<double, T>(), q);
        q = d.Estimate(Vector256.Create(+1, +1, -1, -1d).As<double, T>(), q);
        q = e.Estimate(Vector256.Create(-1, +1, +1, -1d).As<double, T>(), q);

        return q.Quat();
    }
}
