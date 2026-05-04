namespace System.Numerics;

// calls in right cases
// this version combines 128 and 256 ways into one
public partial struct Quat<T>
{
    private static readonly Vec4<T> inv1 = new(+T.One, -T.One, +T.One, -T.One),
                                    inv2 = new(+T.One, +T.One, -T.One, -T.One),
                                    inv3 = new(-T.One, +T.One, +T.One, -T.One);

    [MethodImpl(AggressiveInlining)]
    private static Quat<T> MultiplyV2(Quat<T> a, Quat<T> b)
    {
        a.Vec4().Broadcast(out var x, out var y, out var z, out var w);

        var q = b.Vec4();

        x *= q.Permute(3, 2, 1, 0);
        y *= q.Permute(2, 3, 0, 1);
        z *= q.Permute(1, 0, 3, 2);

        return inv3.Estimate(z, inv2.Estimate(y, inv1.Estimate(x, q *= w))).Quat();
    }
}
