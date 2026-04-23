namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007, IDE0047

/* called in right cases

IBELIEVE:

1) asm could be more lighter for both single/double, not all offsets proved now and there is few unnecessary instructions

2) shuffle/permute can be generalized to Permute<T> with only byte indices, isn't?

   permutation can return non-generic "VectorNNN bit word" struct to juggle bits as it's now

   non generic vector should be able to be operand (always interpretated as other) and to assign (how?) to VectorNNN<T>

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
    internal static unsafe Mat44<T> Affine128F<T>(Quat<T> r, Vec3<T>* s, Vec3<T>* t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m;

        var (one, w) = (Vector128<T>.One, r.As128());

        var x = w.Permute32(1, 2, 0, 3); // y, z, x, w
        var y = w.Permute32(3, 3, 3, 3); // w, w, w, w
        var z = w.Permute32(2, 0, 1, 3); // z, x, y, w

        x *= w; // xy, yz, zx, ww
        y *= z; // zw, xw, yw, ww
        w *= w; // xx, yy, zz, ww

        var n = x + y; // yx + zw        | zy + xw        | xz + yw | 2ww, no mean
            z = x - y; // yx - zw        | zy - xw        | xz - yw | 0

        n += n;        // 2(xy + zw)     | 2(yz + xw)     | 2(zx + yw)     | 4ww, no mean
        z += z;        // 2(xy - zw)     | 2(yz - xw)     | 2(zx - yw)     | 0

        w += w.Permute32(1, 2, 0, 3);   // xx + yy        | yy + zz        | zz + xx        | 4ww, no mean
        w = one - (w + w);              // 1 - 2(xx + yy) | 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 4ww, no mean

        x = z.WithElement(0, w[1]).WithElement(1, n[0]); // 1 - 2(yy + zz) | 2(yx + zw)     | 2(xz - yw)     | 0
        y = z.WithElement(1, w[2]).WithElement(2, n[1]); // 2(yx - zw)     | 1 - 2(zz + xx) | 2(zy + xw)     | 0
        z = z.WithElement(0, n[2]).WithElement(2, w[0]); // 2(xz + yw)     | 2(zy - xw)     | 1 - 2(xx + yy) | 0

        var tp = (T*)t; var sp = (T*)s;

        // this is not recognized by JIT to produce vmovsd
        // w = one.WithElement(0, *tp).WithElement(1, *(tp + 1)).WithElement(2, *(tp + 2));

        w = one.AsDouble().WithElement(0, *(double*)tp).As<double, T>().WithElement(2, *(tp + 2));

        (x * Vector128.Create(*sp      )).Store((T*)&m);
        (y * Vector128.Create(*(sp + 1))).Store(&m.Y.X);
        (z * Vector128.Create(*(sp + 2))).Store(&m.Z.X);
        (w                              ).Store(&m.W.X);

        return m;
    }

    // asm can be more optimal
    // any way to mix with 512?
    // only 512 way?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe Mat44<T> Affine256D<T>(Quat<T> r, Vec3<T>* s, Vec3<T>* t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m;

        var one = Vector256<T>.One;

        var w = r.As256(); // x, y, z, w

        var x = w.Permute64(1, 2, 0, 3); // y, z, x, w
        var y = w.Permute64(3, 3, 3, 3); // w, w, w, w
        var z = w.Permute64(2, 0, 1, 3); // z, x, y, w

        x *= w; // xy, yz, zx, ww
        y *= z; // zw, xw, yw, ww
        w *= w; // xx, yy, zz, ww

        var n = x + y; // yx + zw        | zy + xw        | xz + yw | 2ww, no mean
            z = x - y; // yx - zw        | zy - xw        | xz - yw | 0

        n += n;        // 2(xy + zw)     | 2(yz + xw)     | 2(zx + yw)     | 4ww, no mean
        z += z;        // 2(xy - zw)     | 2(yz - xw)     | 2(zx - yw)     | 0

        w += w.Permute64(1, 2, 0, 3);   // xx + yy        | yy + zz        | zz + xx        | 4ww, no mean
        w = one - (w + w);              // 1 - 2(xx + yy) | 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 4ww, no mean

        x = z.WithElement(0, w[1]).WithElement(1, n[0]); // 1 - 2(yy + zz) | 2(yx + zw)     | 2(xz - yw)     | 0
        y = z.WithElement(1, w[2]).WithElement(2, n[1]); // 2(yx - zw)     | 1 - 2(zz + xx) | 2(zy + xw)     | 0
        z = z.WithElement(0, n[2]).WithElement(2, w[0]); // 2(xz + yw)     | 2(zy - xw)     | 1 - 2(xx + yy) | 0

        var tp = (T*)t; var sp = (T*)s;

        w = one.WithElement(0, *tp).WithElement(1, *(tp + 1)).WithElement(2, *(tp + 2));

        (x * Vector256.Create(*sp      )).Store((T*)&m);
        (y * Vector256.Create(*(sp + 1))).Store(&m.Y.X);
        (z * Vector256.Create(*(sp + 2))).Store(&m.Z.X);
        (w                              ).Store(&m.W.X);

        return m;
    }
}
