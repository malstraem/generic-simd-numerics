namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007

/* called in right case

IBELIEAVE:

1) asm could be more lighter for both single/double, not all offsets proved now and there is unnecessary instructions

2) shuffle/permute can be generalized to Permute<T> with only byte indices, isn't?

   permutation should return non-generic "VectorNNN bit word" struct to juggle bits as it's now

   non generic vector should be able to be operand and always interpretate as other

   Vector128<T> some = ...

   Vector128 perm = some.Permute(1, 0) / Permute(3, 2, 1, 0) / Permute(0, .., 7) etc that JIT process/fallback to naive

   Vector128<T> other = some + perm */

public static partial class Mat44
{
    // any way to mix with 256? only 256 way?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe Mat44<T> Affine128<T>(Quat<T> r, Vec3<T>* s, Vec3<T>* t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m;

        var one = Vector128<T>.One;

        var w = r.Vec4().As128(); // x, y, z, w

        var x = Vector128.Shuffle(w.AsSingle(), Vector128.Create(1, 2, 0, 3)).As<float, T>(); // y, z, x, w
        var y = Vector128.Shuffle(w.AsSingle(), Vector128.Create(3, 3, 3, 3)).As<float, T>(); // w, w, w, w
        var z = Vector128.Shuffle(w.AsSingle(), Vector128.Create(2, 0, 1, 3)).As<float, T>(); // z, x, y, w

        x *= w; // xy, yz, zx, ww
        y *= z; // zw, xw, yw, ww
        w *= w; // xx, yy, zz, ww

        var n = x + y;
            z = x - y;
                     // xx + yy,        yy + zz,        zz + xx,        2ww no mean
        w += Vector128.Shuffle(w.AsSingle(), Vector128.Create(1, 2, 0, 3)).As<float, T>(); 

        n += n;      // 2(xy + zw),     2(yz + xw),     2(zx + yw),     2ww no mean
        z += z;      // 2(xy - zw),     2(yz - xw),     2(zx - yw),     0
        w += w;      // 2(xx + yy),     2(yy + zz),     2(zz + xx),     4ww no mean
        w = -w;
        w += one;    // 1 - 2(xx + yy), 1 - 2(yy + zz), 1 - 2(zz + xx), 1 - 4ww no mean 

        x = z.WithElement(0, w[1]).WithElement(1, n[0]);
        y = z.WithElement(1, w[2]).WithElement(2, n[1]); // can be more optimal IBELIEVE
        z = z.WithElement(0, n[2]).WithElement(2, w[0]);

        var p = (T*)t;

        w = one.WithElement(0, *p).WithElement(1, *(p + 1)).WithElement(2, *(p + 2));

        //w = one.WithElement(0, t.X).WithElement(1, t.Y).WithElement(2, t.Z); // not recognized by JIT

        p = (T*)s;

        var sx = Vector128.Create(*p);
        var sy = Vector128.Create(*(p + 1));
        var sz = Vector128.Create(*(p + 2));

        (x * sx).Store((T*)&m);
        (y * sy).Store(&m.Y.X);
        (z * sz).Store(&m.Z.X);
         w      .Store(&m.W.X);

        return m;
    }

    // any way to mix with 512? only 512 way?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static unsafe Mat44<T> Affine256<T>(Quat<T> r, Vec3<T>* s, Vec3<T>* t)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Mat44<T> m;

        var one = Vector256<T>.One;

        var w = r.Vec4().As256(); // x, y, z, w

        var x = Vector256.Shuffle(w.AsDouble(), Vector256.Create(1, 2, 0, 3)).As<double, T>(); // y, z, x, w
        var y = Vector256.Shuffle(w.AsDouble(), Vector256.Create(3, 3, 3, 3)).As<double, T>(); // w, w, w, w
        var z = Vector256.Shuffle(w.AsDouble(), Vector256.Create(2, 0, 1, 3)).As<double, T>(); // z, x, y, w

        x *= w; // xy, yz, zx, ww
        y *= z; // zw, xw, yw, ww
        w *= w; // xx, yy, zz, ww

        var n = x + y;
            z = x - y;
                     // xx + yy,        yy + zz,        zz + xx,        2ww no mean
        w += Vector256.Shuffle(w.AsDouble(), Vector256.Create(1, 2, 0, 3)).As<double, T>();

        n += n;      // 2(xy + zw),     2(yz + xw),     2(zx + yw),     2ww no mean
        z += z;      // 2(xy - zw),     2(yz - xw),     2(zx - yw),     0
        w += w;      // 2(xx + yy),     2(yy + zz),     2(zz + xx),     4ww no mean
        w = -w;
        w += one;    // 1 - 2(xx + yy), 1 - 2(yy + zz), 1 - 2(zz + xx), 1 - 4ww no mean 

        x = z.WithElement(0, w[1]).WithElement(1, n[0]);
        y = z.WithElement(1, w[2]).WithElement(2, n[1]); // can be more optimal IBELIEVE
        z = z.WithElement(0, n[2]).WithElement(2, w[0]);

        w = one.WithElement(0, t->X).WithElement(1, t->Y).WithElement(2, t->Z);

        var sx = Vector256.Create(s->X);
        var sy = Vector256.Create(s->Y);
        var sz = Vector256.Create(s->Z);

        (x * sx).Store((T*)&m);
        (y * sy).Store(&m.Y.X);
        (z * sz).Store(&m.Z.X);
         w      .Store(&m.W.X);

        return m;
    }
}
