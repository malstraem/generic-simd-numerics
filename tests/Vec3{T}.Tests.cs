using Silk.NET.Maths;

namespace System.Numerics.Tests.Vector3;

[InheritsTests]
public class Vec3f32 : Vec3Root<float>;

[InheritsTests]
public class Vec3f64 : Vec3Root<float>;

[InheritsTests]
public class Vec3i8 : Vec3Root<sbyte, float>;

[InheritsTests]
public class Vec3ui8 : Vec3Root<byte, float>;

[InheritsTests]
public class Vec3i16 : Vec3Root<short, float>;

[InheritsTests]
public class Vec3ui16 : Vec3Root<ushort, float>;

[InheritsTests]
public class Vec3i32 : Vec3Root<int, float>;

[InheritsTests]
public class Vec3ui32 : Vec3Root<uint, float>;

[InheritsTests]
public class Vec3i64 : Vec3Root<long, double>;

[InheritsTests]
public class Vec3ui64 : Vec3Root<ulong, double>;

[InheritsTests]
public abstract class Vec3Root<T> : Vec3Root<T, T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>
{
    [Test, DisplayName("len (sealed variant)")]
    public async Task LengthSealed()
    {
        var length = vec.Length();

        var expected = vec.Silk().Length;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec3.Length(vec));
    }

    [Test, DisplayName("dist (sealed variant)")]
    public async Task DistanceSealed()
    {
        var distance = x.Distance(y);

        var expected = Vector3D.Distance(x.Silk(), y.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec3.Distance(x, y));
    }

    [Test, DisplayName("norm (sealed variant)")]
    public async Task NormalizeSealed()
    {
        var normal = vec.Normalize();

        var expected = Vector3D.Normalize(vec.Silk()).Vec3();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec3.Normalize(vec));
    }
}

[InheritsTests]
public abstract class Vec3Root<T, R> : Vec3Base<T>
    where T : unmanaged, INumber<T>
    where R : IRootFunctions<R>
{
    [Test, DisplayName("len")]
    public async Task Length()
    {
        var length = vec.Length<R>();

        var expected = vec.Silk().Length;

        await Assert.That(length).IsEqualTo(Vec3.Length<T, R>(vec));
        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("dist")]
    public async Task Distance()
    {
        var distance = x.Distance<R>(y);

        var expected = Vector3D.Distance(x.Silk(), y.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec3.Distance<T, R>(x, y));
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var normal = vec.Normalize<R>();

        var expected = Vector3D.Normalize(vec.Silk()).Vec3();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec3.Normalize<T, R>(vec));
    }

    [Test, DisplayName("sqrt")]
    public async Task SquareRoot()
    {
        var root = vec.SquareRoot<R>();

        var expected = Vector3D.SquareRoot(vec.Silk()).Vec3();

        await Assert.That(root).IsEqualTo(expected);
        await Assert.That(root).IsEqualTo(Vec3.SquareRoot<T, R>(vec));
    }
}

public abstract class Vec3Base<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vec3<T>
       x = Vec3<T>.Gen(T.One),
       y = Vec3<T>.Gen(T.One + T.One),
       min = Vec3<T>.Gen(-T.One),
       max = Vec3<T>.Gen(T.One + T.One + T.One),
       vec = Vec3<T>.Gen(T.One + T.One + T.One + T.One),
       negative = -vec;

    [Test, DisplayName("x + y")]
    public async Task Add()
    {
        var add = x + y;

        var expected = (x.Silk() + y.Silk()).Vec3();

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Vec3.Add(x, y));
    }

    [Test, DisplayName("x - y")]
    public async Task Substract()
    {
        var sub = x - y;

        var expected = (x.Silk() - y.Silk()).Vec3();

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Vec3.Substract(x, y));
    }

    [Test, DisplayName("x * y")]
    public async Task Multiply()
    {
        var mul = x * y;

        var expected = (x.Silk() * y.Silk()).Vec3();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Vec3.Multiply(x, y));
    }

    [Test, DisplayName("x / y")]
    public async Task Divide()
    {
        var div = x / y;

        var expected = (x.Silk() / y.Silk()).Vec3();

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(div).IsEqualTo(Vec3.Divide(x, y));
    }

    [Test, DisplayName("dot")]
    public async Task Dot()
    {
        var dot = x.Dot(y);

        var expected = Vector3D.Dot(x.Silk(), y.Silk());

        await Assert.That(dot).IsEqualTo(expected);
        await Assert.That(dot).IsEqualTo(Vec3.Dot(x, y));
    }

    [Test, DisplayName("abs")]
    public async Task Abs()
    {
        var abs = negative.Abs();

        var expected = Vector3D.Abs(negative.Silk()).Vec3();

        await Assert.That(abs).IsEqualTo(expected);
        await Assert.That(abs).IsEqualTo(Vec3.Abs(negative));
    }

    [Test, DisplayName("min")]
    public async Task Min()
    {
        var m = min.Min(max);

        var expected = Vector3D.Min(min.Silk(), max.Silk()).Vec3();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec3.Min(min, max));

        m = max.Min(min);

        expected = Vector3D.Min(max.Silk(), min.Silk()).Vec3();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec3.Min(max, min));
    }

    [Test, DisplayName("max")]
    public async Task Max()
    {
        var m = min.Max(max);

        var expected = Vector3D.Max(min.Silk(), max.Silk()).Vec3();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec3.Max(min, max));

        m = max.Max(min);

        expected = Vector3D.Max(max.Silk(), min.Silk()).Vec3();

        await Assert.That(m).IsEqualTo(expected);
        await Assert.That(m).IsEqualTo(Vec3.Max(max, min));
    }

    [Test, DisplayName("clamp")]
    public async Task Clamp()
    {
        var clamp = vec.Clamp(min, max);

        var expected = Vector3D.Clamp(vec.Silk(), min.Silk(), max.Silk()).Vec3();

        await Assert.That(clamp).IsEqualTo(expected);
        await Assert.That(clamp).IsEqualTo(Vec3.Clamp(vec, min, max));
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = x.Lerp(y, amount);

        var expected = Vector3D.Lerp(x.Silk(), y.Silk(), amount).Vec3();

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(lerp).IsEqualTo(Vec3.Lerp(x, y, amount));
    }

    [Test, DisplayName("cross")]
    public async Task Cross()
    {
        var cross = x.Cross(y);

        var expected = Vector3D.Cross(x.Silk(), y.Silk()).Vec3();

        await Assert.That(cross).IsEqualTo(expected);
        await Assert.That(cross).IsEqualTo(Vec3.Cross(x, y));
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = vec.LengthSquared();

        var expected = vec.Silk().LengthSquared;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec3.LengthSquared(vec));
    }

    [Test, DisplayName("dist²")]
    public async Task DistanceSquared()
    {
        var distance = x.DistanceSquared(y);

        var expected = Vector3D.DistanceSquared(x.Silk(), y.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec3.DistanceSquared(x, y));
    }
}
