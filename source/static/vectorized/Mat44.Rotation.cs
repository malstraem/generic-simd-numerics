namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007, IDE0047

/* called in right cases

IBELIEVE:

1) asm could be more lighter for both single/double, there is few unnecessary instructions

2) shuffle/permute can be generalized to Permute<T> with only byte indices, isn't?

   permutation can return non-generic "VectorNNN bit word" struct to juggle bits as it's now

   non generic vector should be able to be operand (always interpretate as other) and to assign (how?) to VectorNNN<T>

   Vector128<T> some = ...
   Vector128 perm = some.Permute(1, 0) / Permute(3, 2, 1, 0) / Permute(0, .., 7) etc that JIT process/fallback to naive
   Vector128<T> other = some + perm

 3) fully generic Permute<T> way below, prove me wrong */

public static partial class Mat44
{
    // any way to mix with 256?
    // only 256 way?
    // JIT actually produce vshufd (idk how it's proved), so code can be more optimal
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    internal static Mat44<T> Rotation128F<T>(Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m = default;

        var w = r.As128();

        var x = w.Permute32(1, 2, 0, 3); // y, z, x, w
        var y = w.Permute32(3, 3, 3, 3); // w, w, w, w
        var z = w.Permute32(2, 0, 1, 3); // z, x, y, w

        x *= w; // xy, yz, zx, ww
        y *= z; // zw, xw, yw, ww
        w *= w; // xx, yy, zz, ww

        var n = x + y; // yx + zw        | zy + xw        | xz + yw        | 2ww, no mean
            z = x - y; // yx - zw        | zy - xw        | xz - yw        | 0

        n += n;        // 2(xy + zw)     | 2(yz + xw)     | 2(zx + yw)     | 4ww, no mean
        z += z;        // 2(xy - zw)     | 2(yz - xw)     | 2(zx - yw)     | 0

        w += w.Permute32(1, 2, 0, 3);   // xx + yy        | yy + zz        | zz + xx        | 4ww, no mean
        w = Vector128<T>.One - (w + w); // 1 - 2(xx + yy) | 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 4ww, no mean

        x = z.WithElement(0, w[1]).WithElement(1, n[0]); // 1 - 2(yy + zz) | 2(yx + zw)     | 2(xz - yw)     | 0
        y = z.WithElement(1, w[2]).WithElement(2, n[1]); // 2(yx - zw)     | 1 - 2(zz + xx) | 2(zy + xw)     | 0
        z = z.WithElement(0, n[2]).WithElement(2, w[0]); // 2(xz + yw)     | 2(zy - xw)     | 1 - 2(xx + yy) | 0

        m.X = x.Vec4();
        m.Y = y.Vec4();
        m.Z = z.Vec4();
        m.W = Vector128<T>.Zero.WithElement(3, T.One).Vec4();

        return m;
    }

    // asm can be more optimal
    // any way to mix with 512?
    // only 512 way?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Rotation256D<T>(Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m;

        var w = r.As256(); // x, y, z, w

        var x = w.Permute64(1, 2, 0, 3); // y, z, x, w
        var y = w.Permute64(3, 3, 3, 3); // w, w, w, w
        var z = w.Permute64(2, 0, 1, 3); // z, x, y, w

        x *= w; // xy, yz, zx, ww
        y *= z; // zw, xw, yw, ww
        w *= w; // xx, yy, zz, ww

        var n = x + y; // yx + zw        | zy + xw        | xz + yw        | 2ww, no mean
            z = x - y; // yx - zw        | zy - xw        | xz - yw        | 0

        n += n;        // 2(xy + zw)     | 2(yz + xw)     | 2(zx + yw)     | 4ww, no mean
        z += z;        // 2(xy - zw)     | 2(yz - xw)     | 2(zx - yw)     | 0

        w += w.Permute64(1, 2, 0, 3);   // xx + yy        | yy + zz        | zz + xx        | 4ww, no mean
        w = Vector256<T>.One - (w + w); // 1 - 2(xx + yy) | 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 4ww, no mean

        x = z.WithElement(0, w[1]).WithElement(1, n[0]); // 1 - 2(yy + zz) | 2(yx + zw)     | 2(xz - yw)     | 0
        y = z.WithElement(1, w[2]).WithElement(2, n[1]); // 2(yx - zw)     | 1 - 2(zz + xx) | 2(zy + xw)     | 0
        z = z.WithElement(0, n[2]).WithElement(2, w[0]); // 2(xz + yw)     | 2(zy - xw)     | 1 - 2(xx + yy) | 0

        m.X = x.Vec4();
        m.Y = y.Vec4();
        m.Z = z.Vec4();
        m.W = Vector256<T>.Zero.WithElement(3, T.One).Vec4();

        return m;
    }
}
