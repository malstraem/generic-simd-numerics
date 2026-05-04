namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007, IDE0047

// call in right cases
// this version combines 128 and 256 ways into one
public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    internal static Mat44<T> RotateV2<T>(Mat44<T> m, Quat<T> r)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        Vec4<T> z = r.Vec4(),      // x, y, z, w

        x = z.Permute(1, 2, 0, 3), // y, z, x, w
        y = z.Permute(3, 3, 3, 3), // w, w, w, w
        k = z.Permute(2, 0, 1, 3), // z, x, y, w

        w = x * x; // yy, zz, xx, ww
        x = z * x; // xy, yz, xz, ww
        y = k * y; // zw, xw, yw, ww

        var n = x + y; // xy + zw, yz + xw, xz + yw, 2ww
            k = x - y; // xy - zw, yz - xw, xz - yw, 0

        n = n.Permute(2, 0, 1, 3);
        w += w.Permute(1, 2, 0, 3); // yy + zz        | zz + xx        | xx + yy        | 2ww, no mean

        n += n;                     // 2(xz + yw)     | 2(xy + zw)     | 2(yz + xw)     | 4ww, no mean     || (q31, q12, q23
        k += k;                     // 2(xy - zw)     | 2(yz - xw)     | 2(xz - yw)     | 0                || (q21, q32, q13
        w = SizeOf<T>() == 4        // 1 - 2(yy + zz) | 1 - 2(zz + xx) | 1 - 2(xx + yy) | 1 - 4ww, no mean || (q11, q22, q33)
            ? Vector128<T>.One.Vec4() - (w + w)
            : Vector256<T>.One.Vec4() - (w + w); // Vec4<T>.One provokes unnecessary transfers currently

        x = m.X * w;                                // mx(x, y, z, w) * (q11, q22, q33, -)
        x = m.X.Permute(1, 2, 0, 3).Estimate(k, x); // mx(y, z, x, w) * (q21, q32, q13, -) + ...
        x = m.X.Permute(2, 0, 1, 3).Estimate(n, x); // mx(z, x, y, w) * (q31, q12, q23, -) + ...

        y = m.Y * w;                                // my(x, y, z, w) * (q11, q22, q33, -)
        y = m.Y.Permute(1, 2, 0, 3).Estimate(k, y); // my(y, z, x, w) * (q21, q32, q13, -) + ...
        y = m.Y.Permute(2, 0, 1, 3).Estimate(n, y); // my(z, x, y, w) * (q31, q12, q23, -) + ...

        z = m.Z * w;                                // mz(x, y, z, w) * (q11, q22, q33, -)
        z = m.Z.Permute(1, 2, 0, 3).Estimate(k, z); // mz(y, z, x, w) * (q21, q32, q13, -) + ...
        z = m.Z.Permute(2, 0, 1, 3).Estimate(n, z); // mz(z, x, y, w) * (q31, q12, q23, -) + ...

        w = m.W * w;                                // mw(x, y, z, w) * (q11, q22, q33, -)
        w = m.W.Permute(1, 2, 0, 3).Estimate(k, w); // mw(y, z, x, w) * (q21, q32, q13, -) + ...
        w = m.W.Permute(2, 0, 1, 3).Estimate(n, w); // mw(z, x, y, w) * (q31, q12, q23, -) + ...

        m.X = x.Insert(3, 3, m.X);
        m.Y = y.Insert(3, 3, m.Y);
        m.Z = z.Insert(3, 3, m.Z);
        m.W = w.Insert(3, 3, m.W);

        return m;
    }
}
