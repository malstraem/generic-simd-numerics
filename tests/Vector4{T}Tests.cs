using Silk.NET.Maths;

namespace System.Numerics.Tests;

public class Vector4Tests
{
    [Test]
    public async Task Multiply() => await Task.WhenAll
    (
        Multiply<float>(),
        Multiply<double>(),
        Multiply<int>(),
        Multiply<long>()
    );

    [Test]
    public async Task Length() => await Task.WhenAll
    (
        Length<float>(),
        Length<double>(),
        Length<int>(),
        Length<long>()
    );

    /* Waiting Vector4<T>.Lerp...
    [Test]
    public async Task Lerp() => await Task.WhenAll
    (
        Lerp(0.5f),
        Lerp(0.5),
        Lerp(2),
        Lerp(2L)
    );
    */

    private static async Task Multiply<T>() where T : unmanaged, IBinaryNumber<T>
    {
        var a = Vector4<T>.Generate(T.One);
        var b = Vector4<T>.Generate(T.One + T.One);

        var mul = a * b;

        Vector4<T> expected = (Vector4D<T>)a * (Vector4D<T>)b;

        await Assert.That(mul).IsEqualTo(expected);
    }

    private static async Task Length<T>() where T : unmanaged, IBinaryNumber<T>
    {
        var a = Vector4<T>.Generate(T.One);

        var length = a.Length();

        var expected = ((Vector4D<T>)a).Length;

        await Assert.That(length).IsEqualTo(expected);
    }

    /* Waiting Vector4<T>.Lerp...
    private static async Task Lerp<T>(T amount) where T : unmanaged, IBinaryNumber<T>
    {
        var a = Vector4<T>.Generate(T.One);
        var b = Vector4<T>.Generate(T.One + T.One);

        var actual = Vector4<T>.Lerp(a, b, amount);

        Vector4<T> expected = Vector4D.Lerp((Vector4D<T>)a, (Vector4D<T>)b, amount);

        await Assert.That(expected).IsEqualTo(actual);
    }
    */
}
