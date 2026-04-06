using Silk.NET.Maths;

namespace System.Numerics.Tests.Vector4;

[InheritsTests]
public class Vec4f32 : Vec4Root<float>;

[InheritsTests]
public class Vec4f64 : Vec4Root<double>;

[InheritsTests]
public class Vec4i8 : Vec4Root<sbyte, float>;

[InheritsTests]
public class Vec4ui8 : Vec4Root<byte, float>;

[InheritsTests]
public class Vec4i16 : Vec4Root<short, float>;

[InheritsTests]
public class Vec4ui16 : Vec4Root<ushort, float>;

[InheritsTests]
public class Vec4i32 : Vec4Root<int, float>;

[InheritsTests]
public class Vec4ui32 : Vec4Root<uint, float>;

[InheritsTests]
public class Vec4i64 : Vec4Root<long, double>;

[InheritsTests]
public class Vec4ui64 : Vec4Root<ulong, double>;

[InheritsTests]
public abstract class Vec4Root<T> : Vec4Root<T, T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>
{
    [Test, DisplayName("len (sealed variant)")]
    public async Task LengthSealed()
    {
        var length = a.Length();

        var expected = a.Silk().Length;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4.Length(a));
    }

    [Test, DisplayName("dist (sealed variant)")]
    public async Task DistanceSealed()
    {
        var distance = a.Distance(b);

        var expected = Vector4D.Distance(a.Silk(), b.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4.Distance<T>(a, b));
    }

    [Test, DisplayName("norm (sealed variant)")]
    public async Task NormalizeSealed()
    {
        var normal = a.Normalize();

        var expected = Vector4D.Normalize(a.Silk()).Vec4();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec4.Normalize(a));
    }
}

[InheritsTests]
public abstract class Vec4Root<T, R> : Vec4Base<T>
    where T : unmanaged, INumber<T>
    where R : unmanaged, INumber<R>, IRootFunctions<R>
{
    [Test, DisplayName("len")]
    public async Task Length()
    {
        var length = a.Length<R>();

        var expected = a.Silk().Length;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4.Length<T, R>(a));
    }

    [Test, DisplayName("dist")]
    public async Task Distance()
    {
        var distance = a.Distance<R>(b);

        var expected = Vector4D.Distance(a.Silk(), b.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4.Distance<T, R>(a, b));
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var normal = a.Normalize<R>();

        var expected = Vector4D.Normalize(a.Silk()).Vec4();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec4.Normalize<T, R>(a));
    }

    [Test, DisplayName("sqrt")]
    public async Task SquareRoot()
    {
        var root = a.SquareRoot<R>();

        var expected = Vector4D.SquareRoot(a.Silk()).Vec4();

        await Assert.That(root).IsEqualTo(expected);
        await Assert.That(root).IsEqualTo(Vec4.SquareRoot<T, R>(a));
    }
}

public abstract class Vec4Base<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vec4<T>
       a = Vec4<T>.Gen(T.One + T.One),
       b = Vec4<T>.Gen(T.One),
       min = Vec4<T>.Gen(-T.One),
       max = a;

    [Test, DisplayName("a + b")]
    public async Task Add()
    {
        var add = a + b;

        var expected = (a.Silk() + b.Silk()).Vec4();

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Vec4.Add(a, b));
    }

    [Test, DisplayName("a - b")]
    public async Task Subtract()
    {
        var sub = a - b;

        var expected = (a.Silk() - b.Silk()).Vec4();

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Vec4.Subtract(a, b));
    }

    [Test, DisplayName("a × b")]
    public async Task Dot()
    {
        var dot = a * b;

        var expected = Vector4D.Dot(a.Silk(), b.Silk());

        await Assert.That(dot).IsEqualTo(expected);
        await Assert.That(dot).IsEqualTo(Vec4.Dot(a, b));
    }

    [Test, DisplayName("a × b (element wise)")]
    public async Task ElementMultiply()
    {
        var mul = a.ElementMultiply(b);

        var expected = (a.Silk() * b.Silk()).Vec4();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Vec4.ElementMultiply(a, b));
    }

    [Test, DisplayName("a / b (element wise)")]
    public async Task ElementDivide()
    {
        var div = a.ElementDivide(b);

        var expected = (a.Silk() / b.Silk()).Vec4();

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(div).IsEqualTo(Vec4.ElementDivide(a, b));
    }

    [Test, DisplayName("abs")]
    public async Task Abs()
    {
        var abs = (-a).Abs();

        var expected = Vector4D.Abs((-a).Silk()).Vec4();

        await Assert.That(abs).IsEqualTo(expected);
        await Assert.That(abs).IsEqualTo(Vec4.Abs(-a));
    }

    [Test, DisplayName("sum")]
    public async Task Sum()
    {
        var sum = a.Sum();

        var expected = a.X + a.Y + a.Z + a.W;

        await Assert.That(sum).IsEqualTo(expected);
        await Assert.That(sum).IsEqualTo(Vec4.Sum(a));
    }

    [Test, DisplayName("min")]
    public async Task Min()
    {
        var m = min.Min(max);

        var expected = Vector4D.Min(min.Silk(), max.Silk()).Vec4();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec4.Min(min, max));

        m = max.Min(min);

        expected = Vector4D.Min(max.Silk(), min.Silk()).Vec4();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec4.Min(max, min));
    }

    [Test, DisplayName("max")]
    public async Task Max()
    {
        var m = min.Max(max);

        var expected = Vector4D.Max(min.Silk(), max.Silk()).Vec4();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec4.Max(min, max));

        m = max.Max(min);

        expected = Vector4D.Max(max.Silk(), min.Silk()).Vec4();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec4.Max(max, min));
    }

    [Test, DisplayName("clamp")]
    public async Task Clamp()
    {
        var clamp = a.Clamp(min, max);

        var expected = Vector4D.Clamp(a.Silk(), min.Silk(), max.Silk()).Vec4();

        await Assert.That(clamp).IsEqualTo(expected);
        await Assert.That(clamp).IsEqualTo(Vec4.Clamp(a, min, max));
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = a.Lerp(b, amount);

        var expected = Vector4D.Lerp(a.Silk(), b.Silk(), amount).Vec4();

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(lerp).IsEqualTo(Vec4.Lerp(a, b, amount));
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = a.LengthSquared();

        var expected = a.Silk().LengthSquared;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4.LengthSquared(a));
    }

    [Test, DisplayName("dist²")]
    public async Task DistanceSquared()
    {
        var distance = a.DistanceSquared(b);

        var expected = Vector4D.DistanceSquared(a.Silk(), b.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4.DistanceSquared(a, b));
    }
}
