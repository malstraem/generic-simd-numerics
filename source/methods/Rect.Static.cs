namespace System.Numerics;

public static class Rect
{
    [MethodImpl(AggressiveInlining)]
    public static T Area<T>(Rect<T> rect)
        where T : unmanaged, INumber<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Rect<T>.Area(rect.Vec4());
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
    public static bool Intersects<T>(Rect<T> a, Rect<T> b)
        where T : unmanaged, INumber<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Rect<T>.Intersects(a.Vec4(), b.Vec4());
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
    public static bool IntersectsExclusive<T>(Rect<T> a, Rect<T> b)
        where T : unmanaged, INumber<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Rect<T>.IntersectsExclusive(a.Vec4(), b.Vec4());
        }
        return a.Origin < b.Max && b.Origin < a.Max;
    }

    [MethodImpl(AggressiveInlining)]
    public static Rect<T2> As<T, T2>(Rect<T> rect)
        where T : unmanaged, INumber<T>
        where T2 : unmanaged, INumber<T2>
            => rect.Vec4().As<T2>().Rect();
}
