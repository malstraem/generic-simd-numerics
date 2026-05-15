namespace System.Numerics;

public static class Rect
{
    [MethodImpl(AggressiveInlining)]
    public static T Square<T>(Rect<T> rect)
        where T : unmanaged, INumber<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Rect<T>.Square(rect.Vec4());
        }
        var size = rect.Size;
        return size.X * size.Y;
    }

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining)]
    public static bool Contains<T>(Rect<T> rect, Vec2<T> point)
        where T : unmanaged, INumber<T>
            => point >= rect.Origin && point <= rect.Max;

    [MethodImpl(AggressiveInlining)]
    public static bool Contains<T>(Rect<T> a, Rect<T> b)
        where T : unmanaged, INumber<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Rect<T>.Contains(a.Vec4(), b.Vec4());
        }
        return b.Origin >= a.Origin && b.Max <= a.Max;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool IsIntersect<T>(Rect<T> a, Rect<T> b)
        where T : unmanaged, INumber<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Rect<T>.IsIntersect(a.Vec4(), b.Vec4());
        }
        return a.Origin <= b.Max && b.Origin <= a.Max;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool ContainsExclusive<T>(Rect<T> a, Rect<T> b)
        where T : unmanaged, INumber<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Rect<T>.ContainsExclusive(a.Vec4(), b.Vec4());
        }
        return b.Origin > a.Origin && b.Max < a.Max;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool IsIntersectExclusive<T>(Rect<T> a, Rect<T> b)
        where T : unmanaged, INumber<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Rect<T>.IsIntersectExclusive(a.Vec4(), b.Vec4());
        }
        return a.Origin < b.Max && b.Origin < a.Max;
    }
}

public partial struct Rect<T>
{
    private static Vec4<T> inverse = new(-T.One, -T.One, T.One, T.One);

    [MethodImpl(AggressiveInlining)]
    internal static T Square(Vec4<T> r)
    {
        var size = r.ZWXY() - r;

        size *= size.YXWZ();

        return SizeOf<T>() == 4 ? size.As128()[0] : size.As256()[0];
    }

    [MethodImpl(AggressiveInlining)]
    internal static bool Contains(Vec4<T> a, Vec4<T> b) => b * inverse <= a * inverse;

    [MethodImpl(AggressiveInlining)]
    internal static bool IsIntersect(Vec4<T> a, Vec4<T> b) => a.ZWXY() * inverse <= b * inverse;

    [MethodImpl(AggressiveInlining)]
    internal static bool ContainsExclusive(Vec4<T> a, Vec4<T> b) => b * inverse < a * inverse;

    [MethodImpl(AggressiveInlining)]
    internal static bool IsIntersectExclusive(Vec4<T> a, Vec4<T> b) => a.ZWXY() * inverse < b * inverse;
}
