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
public class Vec4ui16 : Vec4Root<ushort, double>;

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
        var length = vec.Length();

        var expected = vec.Silk().Length;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4<T>.Length(vec));
    }

    [Test, DisplayName("dist (sealed variant)")]
    public async Task DistanceSealed()
    {
        var distance = x.Distance(y);

        var expected = Vector4D.Distance(x.Silk(), y.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4<T>.Distance(x, y));
    }

    [Test, DisplayName("norm (sealed variant)")]
    public async Task NormalizeSealed()
    {
        var normal = vec.Normalize();

        var expected = Vector4D.Normalize(vec.Silk()).Vec4();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec4<T>.Normalize(vec));
    }
}

[InheritsTests]
public abstract class Vec4Root<T, TRoot> : Vec4Base<T>
    where T : unmanaged, INumber<T>
    where TRoot : IRootFunctions<TRoot>
{
    [Test, DisplayName("len")]
    public async Task Length()
    {
        var expected = vec.Silk().Length;

        var length = vec.Length<TRoot>();

        await Assert.That(length).IsEqualTo(Vec4<T>.Length<TRoot>(vec));
        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("dist")]
    public async Task Distance()
    {
        var distance = x.Distance<TRoot>(y);

        var expected = Vector4D.Distance(x.Silk(), y.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4<T>.Distance<TRoot>(x, y));
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var normal = vec.Normalize<TRoot>();

        var expected = Vector4D.Normalize(vec.Silk()).Vec4();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec4<T>.Normalize<TRoot>(vec));
    }

    [Test, DisplayName("sqrt")]
    public async Task SquareRoot()
    {
        var root = vec.SquareRoot<TRoot>();

        var expected = Vector4D.SquareRoot(vec.Silk()).Vec4();

        await Assert.That(root).IsEqualTo(expected);
        await Assert.That(root).IsEqualTo(Vec4<T>.SquareRoot<TRoot>(vec));

    }
}

public abstract class Vec4Base<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vec4<T>
       x = Vec4<T>.Gen(T.One),
       y = Vec4<T>.Gen(T.One + T.One),
       min = Vec4<T>.Gen(-T.One),
       max = Vec4<T>.Gen(T.One + T.One + T.One),
       vec = Vec4<T>.Gen(T.One + T.One + T.One + T.One),
       negative = -vec;

    [Test, DisplayName("x + y")]
    public async Task Add()
    {
        var add = x + y;

        var expected = (x.Silk() + y.Silk()).Vec4();

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Vec4<T>.Add(x, y));
    }

    [Test, DisplayName("x - y")]
    public async Task Substract()
    {
        var sub = x - y;

        var expected = (x.Silk() - y.Silk()).Vec4();

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Vec4<T>.Subtract(x, y));
    }

    [Test, DisplayName("x * y")]
    public async Task Multiply()
    {
        var mul = x * y;

        var expected = (x.Silk() * y.Silk()).Vec4();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Vec4<T>.Multiply(x, y));
    }

    [Test, DisplayName("x / y")]
    public async Task Divide()
    {
        var div = x / y;

        var expected = (x.Silk() / y.Silk()).Vec4();

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(div).IsEqualTo(Vec4<T>.Divide(x, y));
    }

    [Test, DisplayName("abs")]
    public async Task Abs()
    {
        var abs = negative.Abs();

        var expected = Vector4D.Abs(negative.Silk()).Vec4();

        await Assert.That(abs).IsEqualTo(expected);
        await Assert.That(abs).IsEqualTo(Vec4<T>.Abs(negative));
    }

    [Test, DisplayName("min")]
    public async Task Min()
    {
        var m = min.Min(max);

        var expected = Vector4D.Min(min.Silk(), max.Silk()).Vec4();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec4<T>.Min(min, max));

        m = max.Min(min);

        expected = Vector4D.Min(max.Silk(), min.Silk()).Vec4();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec4<T>.Min(max, min));
    }

    [Test, DisplayName("max")]
    public async Task Max()
    {
        var m = min.Max(max);

        var expected = Vector4D.Max(min.Silk(), max.Silk()).Vec4();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec4<T>.Max(min, max));

        m = max.Max(min);

        expected = Vector4D.Max(max.Silk(), min.Silk()).Vec4();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec4<T>.Max(max, min));
    }

    [Test, DisplayName("clamp")]
    public async Task Clamp()
    {
        var clamp = vec.Clamp(min, max);

        var expected = Vector4D.Clamp(vec.Silk(), min.Silk(), max.Silk()).Vec4();

        await Assert.That(clamp).IsEqualTo(expected);
        await Assert.That(clamp).IsEqualTo(Vec4<T>.Clamp(vec, min, max));
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = x.Lerp(y, amount);

        var expected = Vector4D.Lerp(x.Silk(), y.Silk(), amount).Vec4();

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(lerp).IsEqualTo(Vec4<T>.Lerp(x, y, amount));
    }

    [Test, DisplayName("transform")]
    public async Task Transform()
    {
        var mat = Mat44<T>.Gen(T.One);

        var transform = vec.Transform(mat);

        var expected = Vector4D.Transform(vec.Silk(), mat.Silk()).Vec4();

        await Assert.That(transform).IsEqualTo(expected);
        await Assert.That(transform).IsEqualTo(Vec4<T>.Transform(vec, mat));
    }

    [Test, DisplayName("dot")]
    public async Task Dot()
    {
        var dot = x.Dot(y);

        var expected = Vector4D.Dot(x.Silk(), y.Silk());

        await Assert.That(dot).IsEqualTo(expected);
        await Assert.That(dot).IsEqualTo(Vec4<T>.Dot(x, y));
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = vec.LengthSquared();

        var expected = vec.Silk().LengthSquared;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4<T>.LengthSquared(vec));
    }

    [Test, DisplayName("dist²")]
    public async Task DistanceSquared()
    {
        var distance = x.DistanceSquared(y);

        var expected = Vector4D.DistanceSquared(x.Silk(), y.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4<T>.DistanceSquared(x, y));
    }
}
