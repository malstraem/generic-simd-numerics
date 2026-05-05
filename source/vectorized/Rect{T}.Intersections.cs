namespace System.Numerics;

public partial struct Rect<T>
{
    private static Vec4<T> intersectSigns = new(-T.One, -T.One, T.One, T.One);

    // better
    [MethodImpl(AggressiveInlining)]
    public readonly bool IsIntersectVectorizedInvert(Rect<T> b)
        => this.Vec4().Permute(2, 3, 0, 1) * intersectSigns <= b.Vec4() * intersectSigns;

    [MethodImpl(AggressiveInlining)]
    public readonly bool IsIntersectVectorizedSwap(Rect<T> other)
    {
        var (a, b) = (this.As128().As<T, double>(), other.As128().As<T, double>());

        double temp = a.ToScalar();

        a = a.WithElement(0, b[0]);
        b = b.WithElement(0, temp);

        return Vector128.LessThanOrEqualAll(a.As<double, T>(), b.As<double, T>());
    }
}
