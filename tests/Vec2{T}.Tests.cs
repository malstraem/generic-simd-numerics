using Silk.NET.Maths;

namespace System.Numerics.Vec2Tests;

/* need more time investments
    1) random generation with saving/formatting
    2) provide more edge cases with better way */

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
        var length = a.Length();

        var expected = a.Silk().Length;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec2.Length(a));
    }

    [Test, DisplayName("dist (sealed variant)")]
    public async Task DistanceSealed()
    {
        var distance = a.Distance(b);

        var expected = Vector2D.Distance(a.Silk(), b.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec2.Distance(a, b));
    }

    [Test, DisplayName("norm (sealed variant)")]
    public async Task NormalizeSealed()
    {
        var normal = a.Normalize();

        var expected = Vector2D.Normalize(a.Silk()).Vec2();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec2.Normalize(a));
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
        var length = a.Length<R>();

        var expected = a.Silk().Length;

        await Assert.That(length).IsEqualTo(Vec2.Length<T, R>(a));
        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("dist")]
    public async Task Distance()
    {
        var distance = a.Distance<R>(b);

        var expected = Vector2D.Distance(a.Silk(), b.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec2.Distance<T, R>(a, b));
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var normal = a.Normalize<R>();

        var expected = Vector2D.Normalize(a.Silk()).Vec2();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec2.Normalize<T, R>(a));
    }

    [Test, DisplayName("sqrt")]
    public async Task SquareRoot()
    {
        var root = a.SquareRoot<R>();

        var expected = Vector2D.SquareRoot(a.Silk()).Vec2();

        await Assert.That(root).IsEqualTo(expected);
        await Assert.That(root).IsEqualTo(Vec2.SquareRoot<T, R>(a));
    }
}

public abstract class Vec2Base<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vec2<T>
       a = Vec2<T>.Gen(T.One + T.One),
       b = Vec2<T>.Gen(T.One),
       min = Vec2<T>.Gen(-T.One),
       max = a;

    [Test, DisplayName("a + b")]
    public async Task Add()
    {
        var add = a + b;

        var expected = (a.Silk() + b.Silk()).Vec2();

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Vec2.Add(a, b));
    }

    [Test, DisplayName("a - b")]
    public async Task Subtract()
    {
        var sub = a - b;

        var expected = (a.Silk() - b.Silk()).Vec2();

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Vec2.Subtract(a, b));
    }

    [Test, DisplayName("a × b")]
    public async Task Dot()
    {
        var dot = a * b;

        var expected = Vector2D.Dot(a.Silk(), b.Silk());

        await Assert.That(dot).IsEqualTo(expected);
        await Assert.That(dot).IsEqualTo(Vec2.Dot(a, b));
    }

    [Test, DisplayName("a × b (element wise)")]
    public async Task ElementMultiply()
    {
        var mul = a.ElementMultiply(b);

        var expected = (a.Silk() * b.Silk()).Vec2();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Vec2.ElementMultiply(a, b));
    }

    [Test, DisplayName("a / b (element wise)")]
    public async Task ElementDivide()
    {
        var div = a.ElementDivide(b);

        var expected = (a.Silk() / b.Silk()).Vec2();

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(div).IsEqualTo(Vec2.ElementDivide(a, b));
    }

    [Test, DisplayName("sum")]
    public async Task Sum()
    {
        var sum = a.Sum();

        var expected = a.X + a.Y;

        await Assert.That(sum).IsEqualTo(expected);
        await Assert.That(sum).IsEqualTo(Vec2.Sum(a));
    }

    [Test, DisplayName("abs")]
    public async Task Abs()
    {
        var abs = (-a).Abs();

        var expected = Vector2D.Abs((-a).Silk()).Vec2();

        await Assert.That(abs).IsEqualTo(expected);
        await Assert.That(abs).IsEqualTo(Vec2.Abs(-a));
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
        var clamp = a.Clamp(min, max);

        var expected = Vector2D.Clamp(a.Silk(), min.Silk(), max.Silk()).Vec2();

        await Assert.That(clamp).IsEqualTo(expected);
        await Assert.That(clamp).IsEqualTo(Vec2.Clamp(a, min, max));
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = a.Lerp(b, amount);

        var expected = Vector2D.Lerp(a.Silk(), b.Silk(), amount).Vec2();

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(lerp).IsEqualTo(Vec2.Lerp(a, b, amount));
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = a.LengthSquared();

        var expected = a.Silk().LengthSquared;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec2.LengthSquared(a));
    }

    [Test, DisplayName("dist²")]
    public async Task DistanceSquared()
    {
        var distance = a.DistanceSquared(b);

        var expected = Vector2D.DistanceSquared(a.Silk(), b.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec2.DistanceSquared(a, b));
    }
}
