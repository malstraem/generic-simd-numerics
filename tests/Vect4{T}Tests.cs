using Silk.NET.Maths;

namespace System.Numerics.Tests;

public class Vec4Tests
{
    [Test]
    public async Task Add() => await Task.WhenAll
    (
        Add<Half>(),
        Add<float>(),
        Add<double>(),
        Add<int>()
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
        Length<Half>(),
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
    );

    private static async Task Add<T>() where T : unmanaged, /*IFloatingPoint<T>, IRootFunctions<T>*/ INumber<T>
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var add = a + b;

        Vec4<T> expected = (Vector4D<T>)a + (Vector4D<T>)b;

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Vec4<T>.Add(a, b));
    }

    private static async Task Substract<T>() where T : unmanaged, /*IFloatingPoint<T>, IRootFunctions<T>*/ INumber<T>
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var sub = a - b;

        Vec4<T> expected = (Vector4D<T>)a - (Vector4D<T>)b;

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Vec4<T>.Subtract(a, b));
    }

    private static async Task Multiply<T>() where T : unmanaged, /*IFloatingPoint<T>, IRootFunctions<T>*/ INumber<T>
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var mul = a * b;

        Vec4<T> expected = (Vector4D<T>)a * (Vector4D<T>)b;

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Vec4<T>.Multiply(a, b));
    }

    private static async Task Divide<T>() where T : unmanaged, /*IFloatingPoint<T>, IRootFunctions<T>*/ INumber<T>
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var div = a / b;

        Vec4<T> expected = (Vector4D<T>)a / (Vector4D<T>)b;

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(div).IsEqualTo(Vec4<T>.Divide(a, b));
    }

    private static async Task Length<T>() where T : unmanaged, /*IFloatingPoint<T>, IRootFunctions<T>*/ INumber<T>
    {
        var a = Vec4<T>.Gen(T.One);

        var length = a.Length<double>();

        var expected = ((Vector4D<T>)a).Length;

        await Assert.That(length).IsEqualTo(expected);
        //await Assert.That(length).IsEqualTo(Vec4<T>.Length(a));
    }

    private static async Task Distance<T>() where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var distance = a.Distance<double>(b);

        var expected = Vector4D.Distance((Vector4D<T>)a, (Vector4D<T>)b);

        await Assert.That(distance).IsEqualTo(expected);
        //await Assert.That(distance).IsEqualTo(Vec4<T>.Distance(a, b));
    }

    private static async Task LengthSquared<T>() where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
    {
        var a = Vec4<T>.Gen(T.One);

        var length = a.LengthSquared();

        var expected = ((Vector4D<T>)a).LengthSquared;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4<T>.LengthSquared(a));
    }

    private static async Task DistanceSquared<T>() where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var distance = a.DistanceSquared(b);

        var expected = Vector4D.DistanceSquared((Vector4D<T>)a, (Vector4D<T>)b);

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4<T>.DistanceSquared(a, b));
    }

    private static async Task Lerp<T>() where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
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
