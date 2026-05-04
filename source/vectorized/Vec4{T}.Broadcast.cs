namespace System.Numerics;

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
            Broadcast128(out var c, out var d, out var e, out var f);
            x = c.Vec4();
            y = d.Vec4();
            z = e.Vec4();
            w = f.Vec4();
        }
        else
        {
            Broadcast256(out var c, out var d, out var e, out var f);
            x = c.Vec4();
            y = d.Vec4();
            z = e.Vec4();
            w = f.Vec4();
        }
    }

    [MethodImpl(AggressiveInlining)]
    internal void Broadcast128(
        out Vector128<T> x, out Vector128<T> y,
        out Vector128<T> z, out Vector128<T> w)
    {
        var xmm = this.As128();

        x = Vector128.Create(xmm[0]);
        y = Vector128.Create(xmm[1]);
        z = Vector128.Create(xmm[2]);
        w = Vector128.Create(xmm[3]);
    }

    [MethodImpl(AggressiveInlining)]
    internal readonly void Broadcast256(
        out Vector256<T> x, out Vector256<T> y,
        out Vector256<T> z, out Vector256<T> w)
    {
        // "offset ymm" to provoke shuffles as in 128 -> pessimized, idk :(

        /*var ymm = this.As256();

        x = Vector256.Create(ymm[0]);
        y = Vector256.Create(ymm[1]);
        z = Vector256.Create(ymm[2]);
        w = Vector256.Create(ymm[3]);*/

        // now JIT produce 16 scalar movs to xmm and it's better on 9 7900X
        // 128 bit version works as expected

        x = Vector256.Create(X);
        y = Vector256.Create(Y);
        z = Vector256.Create(Z);
        w = Vector256.Create(W);
    }
}
