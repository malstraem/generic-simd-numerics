namespace System.Numerics;

// calls in right cases
// 128 and 256 ways are combined into one
public partial struct Quat<T>
{
    private static readonly Vec4<T>
    inv1 = new(+T.One, -T.One, +T.One, -T.One),
    inv2 = new(+T.One, +T.One, -T.One, -T.One),
    inv3 = new(-T.One, +T.One, +T.One, -T.One),

    conjugate = new(-T.One, -T.One, -T.One, +T.One),

    inverseEpsilon = typeof(T) == typeof(float)
        ? new Vec4<T>(T.CreateChecked(MathF.BitIncrement(1f) - 1f))
        : new Vec4<T>(T.CreateChecked(Math.BitIncrement(1d) - 1d));

    internal static readonly T slerpEpsilon = typeof(T) == typeof(float)
        ? T.CreateChecked(MathF.BitIncrement(1f) - 1f)
        : T.CreateChecked(Math.BitIncrement(1d) - 1d);

    [MethodImpl(AggressiveInlining)]
    internal static Quat<T> Conjugate(Quat<T> q) => (q.Vec4() * conjugate).Quat();

    [MethodImpl(AggressiveInlining)]
    internal static Quat<T> Multiply(Quat<T> a, Quat<T> b)
    {
        var q = b.Vec4();

        a.Vec4().Broadcast(out var x, out var y, out var z, out var w);

        x *= q.WZYX(); y *= q.ZWXY(); z *= q.YXWZ();

        return inv3.Estimate(z, inv2.Estimate(y, inv1.Estimate(x, q *= w))).Quat();
    }

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Inverse(Vec4<T> conjugate, T lengthSquared)
    {
        if (SizeOf<T>() == 4)
        {
            var v = Vector128.Create(lengthSquared);

            return Vector128.AndNot(
                conjugate.As128() / v,
                Vector128.LessThanOrEqual(v, inverseEpsilon.As128())).Quat();
        }
        else
        {
            var v = Vector256.Create(lengthSquared);

            return Vector256.AndNot(
                conjugate.As256() / v,
                Vector256.LessThanOrEqual(v, inverseEpsilon.As256())).Quat();
        }
    }

    [MethodImpl(AggressiveInlining)]
    internal static Quat<T> Lerp(Vec4<T> a, Vec4<T> b, T am)
    {
        var dot = a.Dot(b);

        Vec4<T> cond;
#pragma warning disable IDE0045
        if (SizeOf<T>() == 4)
        {
            cond = Vector128.ConditionalSelect(
                Vector128.IsPositive(Vector128.Create(dot)),
                +b.As128(),
                -b.As128()
            ).Vec4();
        }
        else
        {
            cond = Vector256.ConditionalSelect(
                Vector256.IsPositive(Vector256.Create(dot)),
                +b.As256(),
                -b.As256()
            ).Vec4();
        }
#pragma warning restore IDE0045
        return a.Estimate(Vec4<T>.One - am, cond * am).Normalize().Quat();
    }
}
