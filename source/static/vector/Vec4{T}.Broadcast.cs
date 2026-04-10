namespace System.Numerics;

public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    internal readonly void Broadcast128(
        out Vector128<T> b0, out Vector128<T> b1,
        out Vector128<T> b2, out Vector128<T> b3)
    {
        var xmm = this.As128();

        unsafe
        {
            b0 = Vector128.Create(*(T*)&xmm);
            b1 = Vector128.Create(*((T*)&xmm + 1));
            b2 = Vector128.Create(*((T*)&xmm + 2));
            b3 = Vector128.Create(*((T*)&xmm + 3));
        }
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    internal readonly void Broadcast256(
        out Vector256<T> b0, out Vector256<T> b1,
        out Vector256<T> b2, out Vector256<T> b3)
    {
        /*var ymm = As256();

        unsafe
        {
            b0 = Vector256.Create(*(T*)&ymm);
            b1 = Vector256.Create(*((T*)&ymm + 1));
            b2 = Vector256.Create(*((T*)&ymm + 2));
            b3 = Vector256.Create(*((T*)&ymm + 3));
        }*/

        b0 = Vector256.Create(X);
        b1 = Vector256.Create(Y);
        b2 = Vector256.Create(Z);
        b3 = Vector256.Create(W);

        // take offset "from ymm" -> pessimized, idk :(
        // now JIT produce 16 scalar movs to xmm and it's better on 9 7900X
        // 128 bit version works as expected
    }
}
