namespace System.Numerics;

// called in right cases
public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    internal static void Broadcast128(
        Vec4<T> v,
        out Vector128<T> x, out Vector128<T> y,
        out Vector128<T> z, out Vector128<T> w)
    {
        /*var xmm = this.As128();

        unsafe
        {
            b0 = Vector128.Create(*(T*)&xmm);
            b1 = Vector128.Create(*((T*)&xmm + 1));
            b2 = Vector128.Create(*((T*)&xmm + 2));
            b3 = Vector128.Create(*((T*)&xmm + 3));
        }*/

        unsafe
        {
            var p = (T*)&v;
            x = Vector128.Create(*p);
            y = Vector128.Create(*(p + 1));
            z = Vector128.Create(*(p + 2));
            w = Vector128.Create(*(p + 3));
        }
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    internal readonly void Broadcast256(
        out Vector256<T> x, out Vector256<T> y,
        out Vector256<T> z, out Vector256<T> w)
    {
        // take offset "from ymm" -> pessimized, idk :(

        /*var ymm = As256();

        unsafe
        {
            b0 = Vector256.Create(*(T*)&ymm);
            b1 = Vector256.Create(*((T*)&ymm + 1));
            b2 = Vector256.Create(*((T*)&ymm + 2));
            b3 = Vector256.Create(*((T*)&ymm + 3));
        }*/

        // now JIT produce 16 scalar movs to xmm and it's better on 9 7900X
        // 128 bit version works as expected

        x = Vector256.Create(X);
        y = Vector256.Create(Y);
        z = Vector256.Create(Z);
        w = Vector256.Create(W);
    }
}
