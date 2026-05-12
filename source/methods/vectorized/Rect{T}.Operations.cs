namespace System.Numerics;

public partial struct Rect<T>
{
    private static Vec4<T> inverse = new(-T.One, -T.One, T.One, T.One);

    [MethodImpl(AggressiveInlining)]
    private static T Square(Vec4<T> v)
    {
        var size = v.ZWXY() - v;

        size *= size.YXWZ();

        return SizeOf<T>() == 4 ? size.As128()[0] : size.As256()[0];
    }

    [MethodImpl(AggressiveInlining)]
    private readonly bool IsIntersect(Vec4<T> rect) => this.Vec4().ZWXY() * inverse <= rect * inverse;

    [MethodImpl(AggressiveInlining)]
    private readonly bool Contains(Vec4<T> rect) => rect * inverse <= this.Vec4() * inverse;
}
