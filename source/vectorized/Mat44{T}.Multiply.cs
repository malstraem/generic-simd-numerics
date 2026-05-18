using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

public partial struct Mat44<T>
{
    [MethodImpl(AggressiveInlining)]
    private static Vector128<T> Row(
        Vector128<T> a, Vector128<T> bx, Vector128<T> by, Vector128<T> bz, Vector128<T> bw)
    {
        var a1 = Vector128.Create(a.Permute32(1, 0, 0, 0)[0]);
        var a2 = Vector128.Create(a.Permute32(2, 2, 3, 3)[0]);
        var a3 = Vector128.Create(a.Permute32(3, 0, 0, 0)[0]);

        var res = Vector128.Create(a[0]) * bx;

        res = a2.Estimate(bz, res);
        res = a1.Estimate(by, res);
        res = a3.Estimate(bw, res);

        return res;
    }

    [MethodImpl(AggressiveInlining)]
    internal static Mat44<T> CoolMultiply128(Mat44<T> a, Mat44<T> b)
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

        a.X = Row(ax, bx, by, bz, bw).Vec4();
        a.Y = Row(ay, bx, by, bz, bw).Vec4();
        a.Z = Row(az, bx, by, bz, bw).Vec4();
        a.W = Row(aw, bx, by, bz, bw).Vec4();

        return a;
    }

    [MethodImpl(AggressiveInlining)]
    private static Vector256<T> Row(Vector256<T> a, Vector256<T> bx, Vector256<T> by, Vector256<T> bz, Vector256<T> bw)
    {
        var a1 = a.Permute64(1, 0, 0, 0);
        a1 = Vector256.Create(a1[0]);
        var a2 = a.Permute64(2, 0, 0, 0);
        a2 = Vector256.Create(a2[0]);

        var res = Vector256.Create(a[0]) * bx;

        res = a2.Estimate(bz, res);
        res = a1.Estimate(by, res);

        //var a0 = Vector128.Shuffle(a2.GetLower().AsDouble(), Vector128.Create(1, 0)).As<double, T>();
        //var temp = Vector256.Create(a0[0]);

        res = Vector256.Create(a[3])/*temp*/.Estimate(bw, res);

        return res;
    }

    [MethodImpl(AggressiveInlining)]
    internal static Mat44<T> CoolMultiply256(Mat44<T> a, Mat44<T> b)
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

        a.X = Row(ax, bx, by, bz, bw).Vec4();
        a.Y = Row(ay, bx, by, bz, bw).Vec4();
        a.Z = Row(az, bx, by, bz, bw).Vec4();
        a.W = Row(aw, bx, by, bz, bw).Vec4();

        return a;
    }
}
