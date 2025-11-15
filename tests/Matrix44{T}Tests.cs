using Silk.NET.Maths;

namespace System.Numerics.Tests;

public class Matrix44Tests
{
    [Test]
    public async Task Multiply() => await Task.WhenAll
    (
        Multiply<float>(),
        Multiply<double>(),
        Multiply<int>(),
        Multiply<long>()/*,
        Multiply<FooInteger5>()*/
    );

    /*[Test]
    public async Task MultiplyToVector() => await Task.WhenAll
    (
        MultiplyByVector<double>(),
        MultiplyByVector<float>(),
        MultiplyByVector<int>(),
        MultiplyByVector<long>()
    );*/

    private static async Task Multiply<T>() where T : unmanaged, IBinaryNumber<T>
    {
        var a = Mat44<T>.Generate(T.One);
        var b = Mat44<T>.Generate(T.One + T.One);

        var mul = a * b;

        Mat44<T> expected = (Matrix4X4<T>)a * (Matrix4X4<T>)b;

        await Assert.That(mul).IsEqualTo(expected);
    }

    /*private static async Task MultiplyByVector<T>() where T : unmanaged, IBinaryNumber<T>
    {
        var mat = Matrix44<T>.Generate(T.One);
        var vec = Vector4<T>.Generate(T.One + T.One);

        vec *= mat;

        var expected = (Vector4D<T>)vec * (Matrix4X4<T>)mat;

        await Assert.That(vec).IsEqualTo(expected);
    }*/
}
