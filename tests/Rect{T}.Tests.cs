using Silk.NET.Maths;

namespace System.Numerics.Tests.Rect;

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
       vec = Vec2<T>.Gen(T.One);

    protected static readonly Rect<T>
       x = Rect<T>.Gen(T.One),
       y = Rect<T>.Gen(T.One + T.One);

    [Test, DisplayName("contains point")]
    public async Task Contains()
    {
        var dot = x.Contains(vec);

        var expected = x.Silk().Contains(vec.Silk());

        await Assert.That(dot).IsEqualTo(expected);
    }

    [Test, DisplayName("contains rect")]
    public async Task LengthSquared()
    {
        var length = x.Contains(y);

        var expected = x.Silk().Contains(y.Silk());

        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("intersect rect")]
    public async Task Intersect()
    {
        var length = x.IsIntersect(y);

        var expected = IsIntersect(x.Silk(), y.Silk());

        await Assert.That(length).IsEqualTo(expected);
    }

    public static bool IsIntersect(Rectangle<T> self, Rectangle<T> other)
    {
        return self.Origin.X <= other.Max.X &&
               self.Origin.Y <= other.Max.Y &&
               self.Max.X >= other.Origin.X &&
               self.Max.Y >= other.Origin.Y;
    }
}
