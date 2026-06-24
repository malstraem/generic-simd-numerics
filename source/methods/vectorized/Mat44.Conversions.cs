using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

// dummy

public partial struct Mat44<T>
{
    [MethodImpl(AggressiveInlining)]
    internal static Mat44<T2> ByRows<T2>(Mat44<T> m)
        where T2 : unmanaged, INumber<T2>
    {
        Mat44<T2> c;

        c.X = m.X.As<T2>();
        c.Y = m.Y.As<T2>();
        c.Z = m.Z.As<T2>();
        c.W = m.W.As<T2>();

        return c;
    }

    [MethodImpl(AggressiveInlining)]
    internal static Mat44<T2> Convert64<T2>(Mat44<T> m)
        where T2 : unmanaged, INumber<T2>
    {
        if (SizeOf<T2>() == 8 && Vector512<T>.IsSupported && Vector512<T2>.IsSupported && Vector512.IsHardwareAccelerated)
        {
            if (typeof(T) == typeof(long) && typeof(T2) == typeof(double))
            {
                m.As512(out var xy, out var zw);

                var xyc = Vector512.ConvertToDouble(xy.AsUInt64()).As<double, T2>();
                var zwc = Vector512.ConvertToDouble(zw.AsUInt64()).As<double, T2>();

                return xyc.Mat44(zwc);
            }

            if (typeof(T) == typeof(double) && typeof(T2) == typeof(long))
            {
                m.As512(out var xy, out var zw);

                var xyc = Vector512.ConvertToInt64(xy.AsDouble()).As<long, T2>();
                var zwc = Vector512.ConvertToInt64(zw.AsDouble()).As<long, T2>();

                return xyc.Mat44(zwc);
            }
        }

        if (SizeOf<T2>() == 4)
        {
            if (typeof(T) == typeof(double) && typeof(T2) == typeof(float))
            {
                if (Avx512F.IsSupported)
                {
                    m.As512(out var xy, out var zw);

                    var xyc = Avx512F.ConvertToVector256Single(xy.AsDouble()).As<float, T2>();
                    var zwc = Avx512F.ConvertToVector256Single(zw.AsDouble()).As<float, T2>();

                    return xyc.Mat44(zwc);
                }
                // another ISA
            }
            // another type cases
        }
        return ByRows<T2>(m);
    }
}
