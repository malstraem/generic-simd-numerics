using Silk.NET.Maths;

namespace System.Numerics.Tests;

#if EXPOSE_ROOT
[InheritsTests]
public class Vec4IntFloatExposedRootMethod : Vec4Tests<int, float>;

[InheritsTests]
public class Vec4IntDoubleExposedRootMethod : Vec4Tests<int, double>;

[InheritsTests]
public class Vec4FloatExposedRootMethod : Vec4Tests<float, float>;

[InheritsTests]
public class Vec4DoubleExposedRootMethod : Vec4Tests<double, double>;

public abstract class Vec4Tests<T, TRoot>
    where T : unmanaged, INumber<T>
    where TRoot : IRootFunctions<TRoot>
#else
[InheritsTests]
public class Vec4Half : Vec4Tests<Half>;

[InheritsTests]
public class Vec4Float : Vec4Tests<float>;

[InheritsTests]
public class Vec4Double : Vec4Tests<double>;

public abstract class Vec4Tests<T>
    where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, IFormattable, IEquatable<T>, IComparable<T>
#endif
{
    /*[Test]
    public async Task Add() => await Task.WhenAll
    (
        Add<Half>(),
        Add<float>(),
        Add<double>(),

        Add<byte>(),
        Add<short>(),
        Add<ushort>(),
        Add<int>(),
        Add<uint>(),
        Add<long>(),
        Add<ulong>(),
        Add<byte>(),
        Add<BigInteger>()
    );

    [Test]
    public async Task Substract() => await Task.WhenAll
    (
        Substract<Half>(),
        Substract<float>(),
        Substract<double>()
    );

    [Test]
    public async Task Multiply() => await Task.WhenAll
    (
        Multiply<Half>(),
        Multiply<float>(),
        Multiply<double>()
    );

    [Test]
    public async Task Divide() => await Task.WhenAll
    (
        Divide<Half>(),
        Divide<float>(),
        Divide<double>()
    );

    [Test]
    public async Task Length() => await Task.WhenAll
    (
        Length<Half, float>(),
        Length<Half, double>(),
        Length<float>(),
        Length<double>()
    );

    [Test]
    public async Task Distance() => await Task.WhenAll
    (
        Distance<Half>(),
        Distance<float>(),
        Distance<double>()
    );

    [Test]
    public async Task LengthSquared() => await Task.WhenAll
    (
        LengthSquared<Half>(),
        LengthSquared<float>(),
        LengthSquared<double>()
    );

    [Test]
    public async Task DistanceSquared() => await Task.WhenAll
    (
        DistanceSquared<Half>(),
        DistanceSquared<float>(),
        DistanceSquared<double>()
    );

    [Test]
    public async Task Lerp() => await Task.WhenAll
    (
        Lerp<Half>(),
        Lerp<float>(),
        Lerp<double>()
    );*/

    [Test, DisplayName("a + b")]
    public async Task Add()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var add = a + b;

        Vec4<T> expected = (Vector4D<T>)a + (Vector4D<T>)b;

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Vec4<T>.Add(a, b));
    }

    [Test, DisplayName("a - b")]
    public async Task Substract()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var sub = a - b;

        Vec4<T> expected = (Vector4D<T>)a - (Vector4D<T>)b;

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Vec4<T>.Subtract(a, b));
    }

    [Test, DisplayName("a * b")]
    public async Task Multiply()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var mul = a * b;

        Vec4<T> expected = (Vector4D<T>)a * (Vector4D<T>)b;

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Vec4<T>.Multiply(a, b));
    }

    [Test, DisplayName("a / b")]
    public async Task Divide()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var div = a / b;

        Vec4<T> expected = (Vector4D<T>)a / (Vector4D<T>)b;

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(div).IsEqualTo(Vec4<T>.Divide(a, b));
    }

    [Test]
    public async Task LengthSquared()
    {
        var a = Vec4<T>.Gen(T.One);

        var length = a.LengthSquared();

        var expected = ((Vector4D<T>)a).LengthSquared;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4<T>.LengthSquared(a));
    }

    [Test]
    public async Task DistanceSquared()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var distance = a.DistanceSquared(b);

        var expected = Vector4D.DistanceSquared((Vector4D<T>)a, (Vector4D<T>)b);

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4<T>.DistanceSquared(a, b));
    }
#if EXPOSE_ROOT
    [Test]
    public async Task Length()
    {
        var a = Vec4<T>.Gen(T.One);

        var length = a.Length<TRoot>();

        var expected = ((Vector4D<T>)a).Length;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4<T>.Length<TRoot>(a));
    }

    [Test]
    public async Task Distance()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var distance = a.Distance<TRoot>(b);

        var expected = Vector4D.Distance((Vector4D<T>)a, (Vector4D<T>)b);

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4<T>.Distance<TRoot>(a, b));
    }
#else
    [Test]
    public async Task Length()
    {
        var a = Vec4<T>.Gen(T.One);

        var length = a.Length();

        var expected = ((Vector4D<T>)a).Length;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4<T>.Length(a));
    }

    [Test]
    public async Task Distance()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var distance = a.Distance(b);

        var expected = Vector4D.Distance((Vector4D<T>)a, (Vector4D<T>)b);

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4<T>.Distance(a, b));
    }
#endif
    [Test]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var lerp = a.Lerp(b, amount);

        Vec4<T> expected = Vector4D.Lerp((Vector4D<T>)a, (Vector4D<T>)b, amount);

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(lerp).IsEqualTo(Vec4<T>.Lerp(a, b, amount));
    }
}
