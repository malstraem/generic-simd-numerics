using Silk.NET.Maths;

namespace System.Numerics.Tests.Vector2;

[InheritsTests]
public class Vec2f32 : Vec2Root<float>;

[InheritsTests]
public class Vec2f64 : Vec2Root<double>;

[InheritsTests]
public class Vec2i8 : Vec2Root<sbyte, float>;

[InheritsTests]
public class Vec2ui8 : Vec2Root<byte, float>;

[InheritsTests]
public class Vec2i16 : Vec2Root<short, float>;

[InheritsTests]
public class Vec2ui16 : Vec2Root<ushort, float>;

[InheritsTests]
public class Vec2i32 : Vec2Root<int, float>;

[InheritsTests]
public class Vec2ui32 : Vec2Root<uint, float>;

[InheritsTests]
public class Vec2i64 : Vec2Root<long, double>;

[InheritsTests]
public class Vec2ui64 : Vec2Root<ulong, double>;

[InheritsTests]
public abstract class Vec2Root<T> : Vec2Root<T, T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>
{
    [Test, DisplayName("len (sealed variant)")]
    public async Task LengthSealed()
    {
        var length = vec.Length();

        var expected = vec.Silk().Length;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec2.Length(vec));
    }

    [Test, DisplayName("dist (sealed variant)")]
    public async Task DistanceSealed()
    {
        var distance = x.Distance(y);

        var expected = Vector2D.Distance(x.Silk(), y.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec2.Distance(x, y));
    }

    [Test, DisplayName("norm (sealed variant)")]
    public async Task NormalizeSealed()
    {
        var normal = vec.Normalize();

        var expected = Vector2D.Normalize(vec.Silk()).Vec2();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec2.Normalize(vec));
    }
}

[InheritsTests]
public abstract class Vec2Root<T, R> : Vec2Base<T>
    where T : unmanaged, INumber<T>
    where R : IRootFunctions<R>
{
    [Test, DisplayName("len")]
    public async Task Length()
    {
        var length = vec.Length<R>();

        var expected = vec.Silk().Length;

        await Assert.That(length).IsEqualTo(Vec2.Length<T, R>(vec));
        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("dist")]
    public async Task Distance()
    {
        var distance = x.Distance<R>(y);

        var expected = Vector2D.Distance(x.Silk(), y.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec2.Distance<T, R>(x, y));
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var normal = vec.Normalize<R>();

        var expected = Vector2D.Normalize(vec.Silk()).Vec2();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec2.Normalize<T, R>(vec));
    }

    [Test, DisplayName("sqrt")]
    public async Task SquareRoot()
    {
        var root = vec.SquareRoot<R>();

        var expected = Vector2D.SquareRoot(vec.Silk()).Vec2();

        await Assert.That(root).IsEqualTo(expected);
        await Assert.That(root).IsEqualTo(Vec2.SquareRoot<T, R>(vec));
    }
}

public abstract class Vec2Base<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vec2<T>
       x = Vec2<T>.Gen(T.One),
       y = Vec2<T>.Gen(T.One + T.One),
       min = Vec2<T>.Gen(-T.One),
       max = Vec2<T>.Gen(T.One + T.One + T.One),
       vec = Vec2<T>.Gen(T.One + T.One + T.One + T.One),
       negative = -vec;

    [Test, DisplayName("x + y")]
    public async Task Add()
    {
        var add = x + y;

        var expected = (x.Silk() + y.Silk()).Vec2();

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Vec2.Add(x, y));
    }

    [Test, DisplayName("x - y")]
    public async Task Substract()
    {
        var sub = x - y;

        var expected = (x.Silk() - y.Silk()).Vec2();

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Vec2.Substract(x, y));
    }

    [Test, DisplayName("x * y")]
    public async Task Multiply()
    {
        var mul = x * y;

        var expected = (x.Silk() * y.Silk()).Vec2();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Vec2.Multiply(x, y));
    }

    [Test, DisplayName("x / y")]
    public async Task Divide()
    {
        var div = x / y;

        var expected = (x.Silk() / y.Silk()).Vec2();

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(div).IsEqualTo(Vec2.Divide(x, y));
    }

    [Test, DisplayName("abs")]
    public async Task Abs()
    {
        var abs = negative.Abs();

        var expected = Vector2D.Abs(negative.Silk()).Vec2();

        await Assert.That(abs).IsEqualTo(expected);
        await Assert.That(abs).IsEqualTo(Vec2.Abs(negative));
    }

    [Test, DisplayName("min")]
    public async Task Min()
    {
        var m = min.Min(max);

        var expected = Vector2D.Min(min.Silk(), max.Silk()).Vec2();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec2.Min(min, max));

        m = max.Min(min);

        expected = Vector2D.Min(max.Silk(), min.Silk()).Vec2();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec2.Min(max, min));
    }

    [Test, DisplayName("max")]
    public async Task Max()
    {
        var m = min.Max(max);

        var expected = Vector2D.Max(min.Silk(), max.Silk()).Vec2();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec2.Max(min, max));

        m = max.Max(min);

        expected = Vector2D.Max(max.Silk(), min.Silk()).Vec2();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec2.Max(max, min));
    }

    [Test, DisplayName("clamp")]
    public async Task Clamp()
    {
        var clamp = vec.Clamp(min, max);

        var expected = Vector2D.Clamp(vec.Silk(), min.Silk(), max.Silk()).Vec2();

        await Assert.That(clamp).IsEqualTo(expected);
        await Assert.That(clamp).IsEqualTo(Vec2.Clamp(vec, min, max));
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = x.Lerp(y, amount);

        var expected = Vector2D.Lerp(x.Silk(), y.Silk(), amount).Vec2();

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(lerp).IsEqualTo(Vec2.Lerp(x, y, amount));
    }

    [Test, DisplayName("dot")]
    public async Task Dot()
    {
        var dot = x.Dot(y);

        var expected = Vector2D.Dot(x.Silk(), y.Silk());

        await Assert.That(dot).IsEqualTo(expected);
        await Assert.That(dot).IsEqualTo(Vec2.Dot(x, y));
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = vec.LengthSquared();

        var expected = vec.Silk().LengthSquared;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec2.LengthSquared(vec));
    }

    [Test, DisplayName("dist²")]
    public async Task DistanceSquared()
    {
        var distance = x.DistanceSquared(y);

        var expected = Vector2D.DistanceSquared(x.Silk(), y.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec2.DistanceSquared(x, y));
    }
}
