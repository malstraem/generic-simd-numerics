namespace System.Numerics;

// very draft
public static partial class Mat44
{
    [MethodImpl(AggressiveInlining)]
    private static Mat44<TOther> ByRows<T, TOther>(Mat44<T> m)
        where T : unmanaged, INumber<T>
        where TOther : unmanaged, INumber<TOther>
    {
        Mat44<TOther> res;

        res.X = m.X.As<TOther>();
        res.Y = m.Y.As<TOther>();
        res.Z = m.Z.As<TOther>();
        res.W = m.W.As<TOther>();

        return res;
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<TOther> As<T, TOther>(Mat44<T> m)
        where T : unmanaged, INumber<T>
        where TOther : unmanaged, INumber<TOther>
    {
        if (SizeOf<T>() == 2 && SizeOf<TOther>() == 2)
        {
            if (Vector256<T>.IsSupported && Vector256<TOther>.IsSupported && Vector256.IsHardwareAccelerated)
                return Convert256Size2To2<T, TOther>(m);
        }

        if (SizeOf<T>() == 4 && SizeOf<TOther>() == 4)
        {
            if (Vector512<T>.IsSupported && Vector512<TOther>.IsSupported && Vector512.IsHardwareAccelerated)
                return Convert512Size4To4<T, TOther>(m);
        }
        return ByRows<T, TOther>(m);
    }

    [MethodImpl(AggressiveInlining)]
    private static Mat44<TOther> Convert256Size2To2<T, TOther>(Mat44<T> m)
        where T : unmanaged, INumber<T>
        where TOther : unmanaged, INumber<TOther>
    {
        if (typeof(T) == typeof(int))
        {
            if (typeof(TOther) == typeof(float))
                return Vector256.ConvertToSingle(m.As256().AsInt32()).As<float, TOther>().Mat44();
        }

        if (typeof(T) == typeof(float))
        {
            if (typeof(TOther) == typeof(int))
                return Vector256.ConvertToInt32(m.As256().AsSingle()).As<int, TOther>().Mat44();

            if (typeof(TOther) == typeof(uint))
                return Vector256.ConvertToUInt32(m.As256().AsSingle()).As<uint, TOther>().Mat44();
        }
        return ByRows<T, TOther>(m);
    }

    [MethodImpl(AggressiveInlining)]
    private static Mat44<TOther> Convert256Size4To4<T, TOther>(Mat44<T> m)
        where T : unmanaged, INumber<T>
        where TOther : unmanaged, INumber<TOther>
    {
        if (typeof(T) == typeof(int))
        {
            if (typeof(TOther) == typeof(float))
            {
                m.As256(out var xy, out var zw);

                var xyc = Vector256.ConvertToSingle(xy.AsInt32()).As<float, TOther>();
                var zwc = Vector256.ConvertToSingle(zw.AsInt32()).As<float, TOther>();

                return xyc.Mat44(zwc);
            }
        }

        if (typeof(T) == typeof(float))
        {
            if (typeof(TOther) == typeof(int))
            {
                m.As256(out var xy, out var zw);

                var xyc = Vector256.ConvertToInt32(xy.AsSingle()).As<int, TOther>();
                var zwc = Vector256.ConvertToInt32(zw.AsSingle()).As<int, TOther>();

                return xyc.Mat44(zwc);
            }

            if (typeof(TOther) == typeof(uint))
            {
                m.As256(out var xy, out var zw);

                var xyc = Vector256.ConvertToUInt32(xy.AsSingle()).As<uint, TOther>();
                var zwc = Vector256.ConvertToUInt32(zw.AsSingle()).As<uint, TOther>();

                return xyc.Mat44(zwc);
            }
        }
        return ByRows<T, TOther>(m);
    }

    [MethodImpl(AggressiveInlining)]
    private static Mat44<TOther> Convert512Size4To4<T, TOther>(Mat44<T> m)
        where T : unmanaged, INumber<T>
        where TOther : unmanaged, INumber<TOther>
    {
        if (typeof(T) == typeof(int))
        {
            if (typeof(TOther) == typeof(float))
                return Vector512.ConvertToSingle(m.As512().AsInt32()).As<float, TOther>().Mat44();
        }

        if (typeof(T) == typeof(float))
        {
            if (typeof(TOther) == typeof(int))
                return Vector512.ConvertToInt32(m.As512().AsSingle()).As<int, TOther>().Mat44();

            if (typeof(TOther) == typeof(uint))
                return Vector512.ConvertToUInt32(m.As512().AsSingle()).As<uint, TOther>().Mat44();
        }
        return ByRows<T, TOther>(m);
    }
}
