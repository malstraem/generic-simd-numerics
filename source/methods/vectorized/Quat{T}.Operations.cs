namespace System.Numerics;

// calls in right cases
// this version combines 128 and 256 ways into one
public partial struct Quat<T>
{
    private static readonly Vec4<T>
        inv1 = new(+T.One, -T.One, +T.One, -T.One),
        inv2 = new(+T.One, +T.One, -T.One, -T.One),
        inv3 = new(-T.One, +T.One, +T.One, -T.One),

        conjugate = new(-T.One, -T.One, -T.One, +T.One);

    [MethodImpl(AggressiveInlining)]
    internal static Quat<T> Multiply(Quat<T> a, Quat<T> b)
    {
        var q = b.Vec4();

        a.Vec4().Broadcast(out var x, out var y, out var z, out var w);

        x *= q.WZYX(); y *= q.ZWXY(); z *= q.YXWZ();

        return inv3.Estimate(z, inv2.Estimate(y, inv1.Estimate(x, q *= w))).Quat();
    }

    [MethodImpl(AggressiveInlining)]
    internal static Quat<T> Conjugate(Quat<T> q) => (q.Vec4() * conjugate).Quat();
}
