namespace System.Numerics;

// quite fast but asm is non-optimal
public partial struct Mat44<T>
{
    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> Accumulate(
        Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w,
        Vector128<T> c, Vector128<T> d, Vector128<T> e, Vector128<T> f)
            => (x.MultiplyAdd(c, y * d) + z.MultiplyAdd(e, w * f)).Vec4();

    [MethodImpl(AggressiveInlining)]
    private static Vec4<T> Accumulate(
        Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w,
        Vector256<T> c, Vector256<T> d, Vector256<T> e, Vector256<T> f)
            => (x.MultiplyAdd(c, y * d) + z.MultiplyAdd(e, w * f)).Vec4();

    [MethodImpl(AggressiveInlining)]
    private static Vector128<T> CalcRow(
        Vector128<T> a, Vector128<T> bx, Vector128<T> by, Vector128<T> bz, Vector128<T> bw)
    {
        var a1 = a.Permute32(1, 1, 0, 0);
        a1 = Vector128.Create(a1[0]);
        var a2 = a.Permute32(2, 2, 0, 0);
        a2 = Vector128.Create(a2[0]);

        var res = Vector128.Create(a[0]) * bx;

        res = a2.MultiplyAdd(bz, res);
        res = a1.MultiplyAdd(by, res);
        res = Vector128.Create(a[3]).MultiplyAdd(bw, res);

        return res;
    }

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> CoolMultiply128(Mat44<T> a, Mat44<T> b)
    {
        Vector128<T>
            ax = a.X.As128(),
            ay = a.Y.As128(),
            az = a.Z.As128(),
            aw = a.W.As128(),

            bx = b.X.As128(),
            by = b.Y.As128(),
            bz = b.Z.As128(),
            bw = b.W.As128();

        a.X = CalcRow(ax, bx, by, bz, bw).Vec4();
        a.Y = CalcRow(ay, bx, by, bz, bw).Vec4();
        a.Z = CalcRow(az, bx, by, bz, bw).Vec4();
        a.W = CalcRow(aw, bx, by, bz, bw).Vec4();

        return a;
    }

    [MethodImpl(AggressiveInlining)]
    private static Vector256<T> CalcRow256(
    Vector256<T> a, Vector256<T> bx, Vector256<T> by, Vector256<T> bz, Vector256<T> bw)
    {
        var a1 = a.Permute64(1, 1, 0, 0);
        a1 = Vector256.Create(a1[0]);
        var a2 = a.Permute64(2, 2, 0, 0);
        a2 = Vector256.Create(a2[0]);

        var res = Vector256.Create(a[0]) * bx;

        res = a2.MultiplyAdd(bz, res);
        res = a1.MultiplyAdd(by, res);

        //var a0 = Vector128.Shuffle(a2.GetLower().AsDouble(), Vector128.Create(1, 0)).As<double, T>();
        //var temp = Vector256.Create(a0[0]);

        res = Vector256.Create(a[3])/*temp*/.MultiplyAdd(bw, res);

        return res;
    }

    [MethodImpl(AggressiveInlining)]
    private static Mat44<T> CoolMultiply256(Mat44<T> a, Mat44<T> b)
    {
        Vector256<T>
            ax = a.X.As256(),
            ay = a.Y.As256(),
            az = a.Z.As256(),
            aw = a.W.As256(),

            bx = b.X.As256(),
            by = b.Y.As256(),
            bz = b.Z.As256(),
            bw = b.W.As256();

        a.X = CalcRow256(ax, bx, by, bz, bw).Vec4();
        a.Y = CalcRow256(ay, bx, by, bz, bw).Vec4();
        a.Z = CalcRow256(az, bx, by, bz, bw).Vec4();
        a.W = CalcRow256(aw, bx, by, bz, bw).Vec4();

        return a;
    }

    [MethodImpl(AggressiveInlining)]
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

    [MethodImpl(AggressiveInlining)]
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
