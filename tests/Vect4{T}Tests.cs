using Silk.NET.Maths;

namespace System.Numerics.Tests;

public class Vec4Tests
{
    [Test]
    public async Task Multiply() => await Task.WhenAll
    (
        Multiply<Half>(),
        Multiply<float>(),
        Multiply<double>()
    );

    [Test]
    public async Task Length() => await Task.WhenAll
    (
        Length<Half>(),
        Length<float>(),
        Length<double>()
    );

    [Test]
    public async Task Lerp() => await Task.WhenAll
    (
        Lerp((Half)0.5f),
        Lerp(0.5f),
        Lerp(0.5)
    );

    private static async Task Multiply<T>() where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
    {
        var a = Vec4<T>.Generate(T.One);
        var b = Vec4<T>.Generate(T.One + T.One);

        var mul = a * b;

        Vec4<T> expected = (Vector4D<T>)a * (Vector4D<T>)b;

        await Assert.That(mul).IsEqualTo(expected);
    }

    private static async Task Length<T>() where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
    {
        var a = Vec4<T>.Generate(T.One);

        var length = a.Length();

        var expected = ((Vector4D<T>)a).Length;

        await Assert.That(length).IsEqualTo(expected);
    }

    private static async Task Lerp<T>(T amount) where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
    {
        var a = Vec4<T>.Generate(T.One);
        var b = Vec4<T>.Generate(T.One + T.One);

        var actual = a.Lerp(b, amount);

        Vec4<T> expected = Vector4D.Lerp((Vector4D<T>)a, (Vector4D<T>)b, amount);

        await Assert.That(expected).IsEqualTo(actual);
    }
}
