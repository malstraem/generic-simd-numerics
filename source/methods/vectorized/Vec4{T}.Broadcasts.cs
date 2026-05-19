namespace System.Numerics;

using Runtime.Intrinsics.X86;

// calls in right cases
public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    internal void Broadcast(
        out Vec4<T> x, out Vec4<T> y,
        out Vec4<T> z, out Vec4<T> w)
    {
        if (SizeOf<T>() == 4)
        {
            Broadcast128(out x, out y, out z, out w);
        }
        else
        {
            Broadcast256(out x, out y, out z, out w);
        }
    }

    [MethodImpl(AggressiveInlining)]
    private void Broadcast128(
        out Vec4<T> x, out Vec4<T> y,
        out Vec4<T> z, out Vec4<T> w)
    {
        T s1, s2, s3;

        var xmm = this.As128();

        x = Vector128.Create(xmm[0]).Vec4();

        if (Avx.IsSupported)
        {
            var dup = Avx.MoveHighAndDuplicate(xmm.AsSingle()).As<float, T>();
            var unpk = Avx.UnpackHigh(xmm.AsSingle(), xmm.AsSingle()).As<float, T>();

            (s1, s2, s3) = (dup[0], unpk[0], dup.Permute64(1, 0)[0]);
        }
        else
        {
            (s1, s2, s3) = (xmm[1], xmm[2], xmm[3]);
        }
        y = Vector128.Create(s1).Vec4();
        z = Vector128.Create(s2).Vec4();
        w = Vector128.Create(s3).Vec4();
    }

    [MethodImpl(AggressiveInlining)]
    private readonly void Broadcast256(
        out Vec4<T> x, out Vec4<T> y,
        out Vec4<T> z, out Vec4<T> w)
    {
        T s1, s2, s3;

        var ymm = this.As256();

        var xmm = ymm.GetLower();

        x = Vector256.Create(xmm[0]).Vec4();

        if (Avx.IsSupported)
        {
            xmm = xmm.Permute64(1, 0);

            ymm = Avx.Permute2x128(ymm.AsDouble(), ymm.AsDouble(), 1).As<double, T>();

            var xmm2 = ymm.GetLower();
            var xmm3 = xmm2.Permute64(1, 0);

            (s1, s2, s3) = (xmm[0], xmm2[0], xmm3[0]);
        }
        else
        {
            (s1, s2, s3) = (ymm[1], ymm[2], ymm[3]);
        }
        y = Vector256.Create(s1).Vec4();
        z = Vector256.Create(s2).Vec4();
        w = Vector256.Create(s3).Vec4();
    }
}
