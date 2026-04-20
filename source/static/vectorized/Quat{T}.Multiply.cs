namespace System.Numerics;

// called in right cases
public partial struct Quat<T>
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Multiply128(Quat<T> a, Quat<T> b)
    {
        var xmm = BitCast<Quat<T>, Vector128<float>>(b); //bx, by, bz, bw

        // (ax, ax, ax, ax) (ay, ay, ay, ay) (az, az, az, az) (aw, aw, aw, aw)
        BitCast<Quat<T>, Vec4<float>>(a).Broadcast128(out var xx, out var yy, out var zz, out var ww);

        var q = xmm * ww; // bx*aw, by * aw, bz * aw, bw * aw 
        // q = (bw, -bx, by, -bx) * (ax, ax, ax, ax) + (bx*aw, by * aw, bz * aw, bw * aw)
        q = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(-1f, 1f, -1f, 1f), Vector128.Create(3, 2, 1, 0)), xx, q);
        // q = (bz, bw, -bx, -by) * (ay, ay, ay, ay) + (bw*ax + bx*aw, -bx * ax + by * aw, by * ax + bz * aw, -bx * ax + bw * aw)
        q = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(-1f, -1f, 1f, 1f), Vector128.Create(2, 3, 0, 1)), yy, q);
        // q = (-by, bx, bw, -bz) * (az, az, az, az) + (bw*ax + bx*aw + bz*ay, -bx * ax + by * aw + bw*ay, by * ax + bz * aw - bx*ay, -bx * ax + bw * aw - by*ay)
        q = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(1f, -1f, -1f, 1f), Vector128.Create(1, 0, 3, 2)), zz, q);

        unsafe { Vector128.Store(q.As<float, T>(), (T*)&a); }
        return a;
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Multiply256(Quat<T> a, Quat<T> b)
    {
        var ymm = BitCast<Quat<T>, Vector256<double>>(b); //bx, by, bz, bw

        // (ax, ax, ax, ax) (ay, ay, ay, ay) (az, az, az, az) (aw, aw, aw, aw)
        BitCast<Quat<T>, Vec4<double>>(a).Broadcast256(out var xx, out var yy, out var zz, out var ww);

        var q = ymm * ww; // bx*aw, by * aw, bz * aw, bw * aw
        // q = (bw, -bx, by, -bx) * (ax, ax, ax, ax) + (bx*aw, by * aw, bz * aw, bw * aw)
        q = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(-1d, 1d, -1d, 1d), Vector256.Create(3L, 2L, 1L, 0L)), xx, q);
        // q = (bz, bw, -bx, -by) * (ay, ay, ay, ay) + (bw*ax + bx*aw, -bx * ax + by * aw, by * ax + bz * aw, -bx * ax + bw * aw)
        q = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(-1d, -1d, 1d, 1d), Vector256.Create(2L, 3L, 0L, 1L)), yy, q);
        // q = (-by, bx, bw, -bz) * (az, az, az, az) + (bw*ax + bx*aw + bz*ay, -bx * ax + by * aw + bw*ay, by * ax + bz * aw - bx*ay, -bx * ax + bw * aw - by*ay)
        q = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(1d, -1d, -1d, 1d), Vector256.Create(1L, 0L, 3L, 2L)), zz, q);

        unsafe { Vector256.Store(q.As<double, T>(), (T*)&a); }
        return a;
    }

    /*[MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Divide128(Quat<T> a, Quat<T> b)
    {
        var xmm = BitCast<Quat<T>, Vector128<float>>(b); //bx, by, bz, bw

        // bx / (bx^2 + by^2 + bz^2 + bw^2), by / (bx^2 + by^2 + bz^2 + bw^2), bz / (bx^2 + by^2 + bz^2 + bw^2), bw / (bx^2 + by^2 + bz^2 + bw^2)
        xmm /= Vector128.Sum(xmm * xmm);

        // b^(-1) = -bx / (bx^2 + by^2 + bz^2 + bw^2), -by / (bx^2 + by^2 + bz^2 + bw^2), -bz / (bx^2 + by^2 + bz^2 + bw^2), bw / (bx^2 + by^2 + bz^2 + bw^2)
        xmm *= Vector128.Create(-1f, -1f, -1f, 1f);

        // (ax, ax, ax, ax) (ay, ay, ay, ay) (az, az, az, az) (aw, aw, aw, aw)
        BitCast<Quat<T>, Vec4<float>>(a).Broadcast128(out var xx, out var yy, out var zz, out var ww);

        var q = xmm * ww; // bx*aw, by * aw, bz * aw, bw * aw 
        // q = (bw, -bx, by, -bx) * (ax, ax, ax, ax) + (bx*aw, by * aw, bz * aw, bw * aw)
        q = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(-1f, 1f, -1f, 1f), Vector128.Create(3, 2, 1, 0)), xx, q);
        // q = (bz, bw, -bx, -by) * (ay, ay, ay, ay) + (bw*ax + bx*aw, -bx * ax + by * aw, by * ax + bz * aw, -bx * ax + bw * aw)
        q = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(-1f, -1f, 1f, 1f), Vector128.Create(2, 3, 0, 1)), yy, q);
        // q = (-by, bx, bw, -bz) * (az, az, az, az) + (bw*ax + bx*aw + bz*ay, -bx * ax + by * aw + bw*ay, by * ax + bz * aw - bx*ay, -bx * ax + bw * aw - by*ay)
        q = Vector128.MultiplyAddEstimate(Vector128.Shuffle(xmm * Vector128.Create(1f, -1f, -1f, 1f), Vector128.Create(1, 0, 3, 2)), zz, q);

        unsafe { Vector128.Store(q.As<float, T>(), (T*)&a); }
        return a;
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Quat<T> Divide256(Quat<T> a, Quat<T> b)
    {
        var ymm = BitCast<Quat<T>, Vector256<double>>(b); //bx, by, bz, bw

        // bx / (bx^2 + by^2 + bz^2 + bw^2), by / (bx^2 + by^2 + bz^2 + bw^2), bz / (bx^2 + by^2 + bz^2 + bw^2), bw / (bx^2 + by^2 + bz^2 + bw^2)
        ymm /= Vector256.Sum(ymm * ymm);

        // b^(-1) = -bx / (bx^2 + by^2 + bz^2 + bw^2), -by / (bx^2 + by^2 + bz^2 + bw^2), -bz / (bx^2 + by^2 + bz^2 + bw^2), bw / (bx^2 + by^2 + bz^2 + bw^2)
        ymm *= Vector256.Create(-1f, -1f, -1f, 1f);

        // (ax, ax, ax, ax) (ay, ay, ay, ay) (az, az, az, az) (aw, aw, aw, aw)
        BitCast<Quat<T>, Vec4<double>>(a).Broadcast256(out var xx, out var yy, out var zz, out var ww);

        var q = ymm * ww; // bx*aw, by * aw, bz * aw, bw * aw
        // q = (bw, -bx, by, -bx) * (ax, ax, ax, ax) + (bx*aw, by * aw, bz * aw, bw * aw)
        q = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(-1d, 1d, -1d, 1d), Vector256.Create(3L, 2L, 1L, 0L)), xx, q);
        // q = (bz, bw, -bx, -by) * (ay, ay, ay, ay) + (bw*ax + bx*aw, -bx * ax + by * aw, by * ax + bz * aw, -bx * ax + bw * aw)
        q = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(-1d, -1d, 1d, 1d), Vector256.Create(2L, 3L, 0L, 1L)), yy, q);
        // q = (-by, bx, bw, -bz) * (az, az, az, az) + (bw*ax + bx*aw + bz*ay, -bx * ax + by * aw + bw*ay, by * ax + bz * aw - bx*ay, -bx * ax + bw * aw - by*ay)
        q = Vector256.MultiplyAddEstimate(Vector256.Shuffle(ymm * Vector256.Create(1d, -1d, -1d, 1d), Vector256.Create(1L, 0L, 3L, 2L)), zz, q);

        unsafe { Vector256.Store(q.As<double, T>(), (T*)&a); }
        return a;
    }*/
}
