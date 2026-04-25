using Silk.NET.Maths;

namespace System.Numerics.Vec3Tests;

/* need more time investments
    1) random generation with saving/formatting
    2) provide more edge cases with better way */

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
        var length = a.Length();

        var expected = a.Silk().Length;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec3.Length(a));
    }

    [Test, DisplayName("dist (sealed variant)")]
    public async Task DistanceSealed()
    {
        var distance = a.Distance(b);

        var expected = Vector3D.Distance(a.Silk(), b.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec3.Distance(a, b));
    }

    [Test, DisplayName("norm (sealed variant)")]
    public async Task NormalizeSealed()
    {
        var normal = a.Normalize();

        var expected = Vector3D.Normalize(a.Silk()).Vec3();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec3.Normalize(a));
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
        var length = a.Length<R>();

        var expected = a.Silk().Length;

        await Assert.That(length).IsEqualTo(Vec3.Length<T, R>(a));
        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("dist")]
    public async Task Distance()
    {
        var distance = a.Distance<R>(b);

        var expected = Vector3D.Distance(a.Silk(), b.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec3.Distance<T, R>(a, b));
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var normal = a.Normalize<R>();

        var expected = Vector3D.Normalize(a.Silk()).Vec3();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(normal).IsEqualTo(Vec3.Normalize<T, R>(a));
    }

    [Test, DisplayName("sqrt")]
    public async Task SquareRoot()
    {
        var root = a.SquareRoot<R>();

        var expected = Vector3D.SquareRoot(a.Silk()).Vec3();

        await Assert.That(root).IsEqualTo(expected);
        await Assert.That(root).IsEqualTo(Vec3.SquareRoot<T, R>(a));
    }
}

public abstract class Vec3Base<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vec3<T>
       a = Vec3<T>.Gen(T.One + T.One),
       b = Vec3<T>.Gen(T.One),
       min = Vec3<T>.Gen(-T.One),
       max = a;

    [Test, DisplayName("a + b")]
    public async Task Add()
    {
        var add = a + b;

        var expected = (a.Silk() + b.Silk()).Vec3();

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Vec3.Add(a, b));
    }

    [Test, DisplayName("a - b")]
    public async Task Subtract()
    {
        var sub = a - b;

        var expected = (a.Silk() - b.Silk()).Vec3();

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Vec3.Subtract(a, b));
    }

    [Test, DisplayName("a × b")]
    public async Task Dot()
    {
        var dot = a * b;

        var expected = Vector3D.Dot(a.Silk(), b.Silk());

        await Assert.That(dot).IsEqualTo(expected);
        await Assert.That(dot).IsEqualTo(Vec3.Dot(a, b));
    }

    [Test, DisplayName("a × b (element wise)")]
    public async Task MultiplyWise()
    {
        var mul = a.MultiplyWise(b);

        var expected = (a.Silk() * b.Silk()).Vec3();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Vec3.MultiplyWise(a, b));
    }

    [Test, DisplayName("a / b (element wise)")]
    public async Task DivideWise()
    {
        var div = a.DivideWise(b);

        var expected = (a.Silk() / b.Silk()).Vec3();

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(div).IsEqualTo(Vec3.DivideWise(a, b));
    }

    [Test, DisplayName("sum")]
    public async Task Sum()
    {
        var sum = a.Sum();

        var expected = a.X + a.Y + a.Z;

        await Assert.That(sum).IsEqualTo(expected);
        await Assert.That(sum).IsEqualTo(Vec3.Sum(a));
    }

    [Test, DisplayName("abs")]
    public async Task Abs()
    {
        var abs = (-a).Abs();

        var expected = Vector3D.Abs((-a).Silk()).Vec3();

        await Assert.That(abs).IsEqualTo(expected);
        await Assert.That(abs).IsEqualTo(Vec3.Abs(-a));
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
        var clamp = a.Clamp(min, max);

        var expected = Vector3D.Clamp(a.Silk(), min.Silk(), max.Silk()).Vec3();

        await Assert.That(clamp).IsEqualTo(expected);
        await Assert.That(clamp).IsEqualTo(Vec3.Clamp(a, min, max));
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = a.Lerp(b, amount);

        var expected = Vector3D.Lerp(a.Silk(), b.Silk(), amount).Vec3();

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(lerp).IsEqualTo(Vec3.Lerp(a, b, amount));
    }

    [Test, DisplayName("cross")]
    public async Task Cross()
    {
        var cross = a.Cross(b);

        var expected = Vector3D.Cross(a.Silk(), b.Silk()).Vec3();

        await Assert.That(cross).IsEqualTo(expected);
        await Assert.That(cross).IsEqualTo(Vec3.Cross(a, b));
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = a.LengthSquared();

        var expected = a.Silk().LengthSquared;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec3.LengthSquared(a));
    }

    [Test, DisplayName("dist²")]
    public async Task DistanceSquared()
    {
        var distance = a.DistanceSquared(b);

        var expected = Vector3D.DistanceSquared(a.Silk(), b.Silk());

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec3.DistanceSquared(a, b));
    }
}
