namespace System.Numerics;

public partial struct Rect<T>
{
    private static Vec4<T> inverse = new(-T.One, -T.One, T.One, T.One);

    [MethodImpl(AggressiveInlining)]
    internal static T Area(Vec4<T> rect)
    {
        var size = rect.ZWXY() - rect;

        size *= size.YYWW();

        return SizeOf<T>() == 4 ? size.As128()[0] : size.As256()[0];
    }

    [MethodImpl(AggressiveInlining)]
    internal static bool Contains(Vec4<T> a, Vec4<T> b) => b * inverse <= a * inverse;

    [MethodImpl(AggressiveInlining)]
    internal static bool Intersects(Vec4<T> a, Vec4<T> b) => a.ZWXY() * inverse <= b * inverse;

    [MethodImpl(AggressiveInlining)]
    internal static bool ContainsExclusive(Vec4<T> a, Vec4<T> b) => b * inverse < a * inverse;

    [MethodImpl(AggressiveInlining)]
    internal static bool IntersectsExclusive(Vec4<T> a, Vec4<T> b) => a.ZWXY() * inverse < b * inverse;
}
