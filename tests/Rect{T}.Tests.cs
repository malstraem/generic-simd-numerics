namespace System.Numerics.RectTests;

[InheritsTests]
public class Rectf32 : RectBase<float>;

[InheritsTests]
public class Rectf64 : RectBase<double>;

[InheritsTests]
public class Recti8 : RectBase<sbyte>;

[InheritsTests]
public class Rectui8 : RectBase<byte>;

[InheritsTests]
public class Recti16 : RectBase<short>;

[InheritsTests]
public class Rectui16 : RectBase<ushort>;

[InheritsTests]
public class Recti32 : RectBase<int>;

[InheritsTests]
public class Rectui32 : RectBase<uint>;

[InheritsTests]
public class Recti64 : RectBase<long>;

[InheritsTests]
public class Rectui64 : RectBase<ulong>;

public class RectBase<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vec2<T>
       point = Vec2<T>.Gen(T.One);

    protected static readonly Rect<T>
       a = Rect<T>.Gen(T.One),
       b = Rect<T>.Gen(T.One + T.One);

    [Test, DisplayName("intersects")]
    public async Task Intersects()
    {
        bool contains = a.Intersects(b);

        await Assert.That(contains).IsEqualTo(Rect.Intersects(a, b));

        var sa = a.Silk();
        var sb = b.Silk();

        bool expected = sa.Contains(sb.Origin) || sa.Contains(sb.Max);

        await Assert.That(contains).IsEqualTo(expected);
    }

    [Test, DisplayName("contains")]
    public async Task Contains()
    {
        bool contains = a.Contains(b);

        await Assert.That(contains).IsEqualTo(Rect.Contains(a, b));

        bool expected = a.Silk().Contains(b.Silk());

        await Assert.That(contains).IsEqualTo(expected);
    }

    [Test, DisplayName("contains (point)")]
    public async Task ContainsPoint()
    {
        bool contains = a.Contains(point);

        await Assert.That(contains).IsEqualTo(Rect.Contains(a, point));

        bool expected = a.Silk().Contains(point.Silk());

        await Assert.That(contains).IsEqualTo(expected);
    }
}
