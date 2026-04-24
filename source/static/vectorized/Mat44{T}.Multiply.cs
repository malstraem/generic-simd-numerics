using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

// called in right cases
// result is quite good, but asm could be lighter
public partial struct Mat44<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Accumulate(
        T* dst,
        Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w,
        Vector128<T> b0, Vector128<T> b1, Vector128<T> b2, Vector128<T> b3)
            => (x.MultiplyAdd(b0, y * b1) + z.MultiplyAdd(b2, w * b3)).Store(dst);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe void Accumulate(
        T* dst,
        Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w,
        Vector256<T> b0, Vector256<T> b1, Vector256<T> b2, Vector256<T> b3)
            => (x.MultiplyAdd(b0, y * b1) + z.MultiplyAdd(b2, w * b3)).Store(dst);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe Mat44<T> Multiply128(Mat44<T>* a, Mat44<T> b)
    {
        var x = b.X.As128();
        var y = b.Y.As128();
        var z = b.Z.As128();
        var w = b.W.As128();

        /*var ax = a.X.As128();
        var ay = a.Y.As128();
        var az = a.Z.As128();
        var aw = a.W.As128();*/

        Mat44<T> m = default;

        float* ptr = (float*)&a;

        for (int i = 0; i < 4; i++)
        {
            float* p = ptr + (i * 4);

            var c = Vector128.Create(*p);
            var d = Vector128.Create(*(p + 1));
            var e = Vector128.Create(*(p + 2));
            var f = Vector128.Create(*(p + 3));

            (x.MultiplyAdd(c.As<float, T>(), y * d.As<float, T>())
           + z.MultiplyAdd(e.As<float, T>(), w * f.As<float, T>())).Store((T*)&m + (i * 4));

            /*m.X = (x.MultiplyAdd(c.As<float, T>(), y * d.As<float, T>())
                   + z.MultiplyAdd(e.As<float, T>(), w * f.As<float, T>())).Vec4();*/
        }

        //unsafe
        //{
        //    var p = (float*)&ax;

        //    var c = Vector128.Create(*p);
        //    var d = Vector128.Create(*(p + 1));
        //    var e = Vector128.Create(*(p + 2));
        //    var f = Vector128.Create(*(p + 3));

        //    p = (float*)&ay;
        //    var c2 = Vector128.Create(*p);
        //    var d2 = Vector128.Create(*(p + 1));
        //    var e2 = Vector128.Create(*(p + 2));
        //    var f2 = Vector128.Create(*(p + 3));

        //    p = (float*)&az;

        //    var c3 = Vector128.Create(*p);
        //    var d3 = Vector128.Create(*(p + 1));
        //    var e3 = Vector128.Create(*(p + 2));
        //    var f3 = Vector128.Create(*(p + 3));

        //    p = (float*)&az;

        //    var c4 = Avx.BroadcastScalarToVector128(p);
        //    var d4 = Avx.BroadcastScalarToVector128(p + 1);
        //    var e4 = Avx.BroadcastScalarToVector128(p + 2);
        //    var f4 = Avx.BroadcastScalarToVector128(p + 3);

        //    m.X = (x.MultiplyAdd(c.As<float, T>(), y * d.As<float, T>())
        //         + z.MultiplyAdd(e.As<float, T>(), w * f.As<float, T>())).Vec4();

        //    m.Y = (x.MultiplyAdd(c2.As<float, T>(), y * d2.As<float, T>())
        //         + z.MultiplyAdd(e2.As<float, T>(), w * f2.As<float, T>())).Vec4();

        //    m.Z = (x.MultiplyAdd(c3.As<float, T>(), y * d3.As<float, T>())
        //         + z.MultiplyAdd(e3.As<float, T>(), w * f3.As<float, T>())).Vec4();

        //    m.W = (x.MultiplyAdd(c4.As<float, T>(), y * d4.As<float, T>())
        //         + z.MultiplyAdd(e4.As<float, T>(), w * f4.As<float, T>())).Vec4();
        //}

        //Vec4<T>.Broadcast128(a.X, out var c, out var d, out var e, out var f);
        //m.X = (x.MultiplyAdd(c, y * d) + z.MultiplyAdd(e, w * f)).Vec4();
        //Accumulate(&b.X.X, x, y, z, w, b0, b1, b2, b3);

        //var c2 = Vector128.Create(*(p + 4));
        //var d2 = Vector128.Create(*(p + 5));
        //var e2 = Vector128.Create(*(p + 6));
        //var f2 = Vector128.Create(*(p + 7));

        //Vec4<T>.Broadcast128(a.Y, out c, out d, out e, out f);
        //Accumulate(&b.Y.X, x, y, z, w, c, d, e, f);
        //m.Y = (x.MultiplyAdd(c2, y * d2) + z.MultiplyAdd(e2, w * f2)).Vec4();

        //var c3 = Vector128.Create(*(p + 8));
        //var d3 = Vector128.Create(*(p + 9));
        //var e3 = Vector128.Create(*(p + 10));
        //var f3 = Vector128.Create(*(p + 11));

        //Vec4<T>.Broadcast128(a.Z, out c, out d, out e, out f);
        //Accumulate(&b.Z.X, x, y, z, w, c, d, e, f);
        //m.Z = (x.MultiplyAdd(c3, y * d3) + z.MultiplyAdd(e3, w * f3)).Vec4();

        //var c4 = Vector128.Create(*(p + 12));
        //var d4 = Vector128.Create(*(p + 13));
        //var e4 = Vector128.Create(*(p + 14));
        //var f4 = Vector128.Create(*(p + 15));

        //Vec4<T>.Broadcast128(a.W, out c, out d, out e, out f);
        //Accumulate(&b.W.X, x, y, z, w, c, d, e, f);
        //m.W = (x.MultiplyAdd(c4, y * d4) + z.MultiplyAdd(e4, w * f4)).Vec4();
        return m;
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Multiply256(Mat44<T> a, Mat44<T> b)
    {
        var x = b.X.As256();
        var y = b.Y.As256();
        var z = b.Z.As256();
        var w = b.W.As256();

        unsafe
        {
            a.X.Broadcast256(out var b0, out var b1, out var b2, out var b3);
            Accumulate(&b.X.X, x, y, z, w, b0, b1, b2, b3);

            a.Y.Broadcast256(out b0, out b1, out b2, out b3);
            Accumulate(&b.Y.X, x, y, z, w, b0, b1, b2, b3);

            a.Z.Broadcast256(out b0, out b1, out b2, out b3);
            Accumulate(&b.Z.X, x, y, z, w, b0, b1, b2, b3);

            a.W.Broadcast256(out b0, out b1, out b2, out b3);
            Accumulate(&b.W.X, x, y, z, w, b0, b1, b2, b3);
        }
        return b;
    }
}
