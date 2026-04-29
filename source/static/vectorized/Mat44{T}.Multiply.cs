namespace System.Numerics;

// quite fast but asm is non-optimal
public partial struct Mat44<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Vec4<T> Accumulate(
        Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w,
        Vector128<T> c, Vector128<T> d, Vector128<T> e, Vector128<T> f)
            => (x.MultiplyAdd(c, y * d) + z.MultiplyAdd(e, w * f)).Vec4();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Vec4<T> Accumulate(
        Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w,
        Vector256<T> c, Vector256<T> d, Vector256<T> e, Vector256<T> f)
            => (x.MultiplyAdd(c, y * d) + z.MultiplyAdd(e, w * f)).Vec4();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Multiply128(Mat44<T> a, Mat44<T> b)
    {
        var x = b.X.As128();
        var y = b.Y.As128();
        var z = b.Z.As128();
        var w = b.W.As128();

        a.X.Broadcast128(out var c, out var d, out var e, out var f);
        b.X = Accumulate(x, y, z, w, c, d, e, f);

        a.Y.Broadcast128(out c, out d, out e, out f);
        b.Y = Accumulate(x, y, z, w, c, d, e, f);

        a.Z.Broadcast128(out c, out d, out e, out f);
        b.Z = Accumulate(x, y, z, w, c, d, e, f);

        a.W.Broadcast128(out c, out d, out e, out f);
        b.W = Accumulate(x, y, z, w, c, d, e, f);

        return b;
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Multiply256(Mat44<T> a, Mat44<T> b)
    {
        var x = b.X.As256();
        var y = b.Y.As256();
        var z = b.Z.As256();
        var w = b.W.As256();

        a.X.Broadcast256(out var c, out var d, out var e, out var f);
        b.X = Accumulate(x, y, z, w, c, d, e, f);

        a.Y.Broadcast256(out c, out d, out e, out f);
        b.Y = Accumulate(x, y, z, w, c, d, e, f);

        a.Z.Broadcast256(out c, out d, out e, out f);
        b.Z = Accumulate(x, y, z, w, c, d, e, f);

        a.W.Broadcast256(out c, out d, out e, out f);
        b.W = Accumulate(x, y, z, w, c, d, e, f);

        return b;
    }
}
