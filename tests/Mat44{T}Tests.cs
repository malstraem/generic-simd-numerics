using Silk.NET.Maths;

namespace System.Numerics.Tests;

[Obsolete("TODO")]
public class Mat44Tests
{
    public async Task Multiply() => await Task.WhenAll
    (
        Multiply<float>(),
        Multiply<double>()
    );

    private static async Task Multiply<T>() where T : unmanaged, IBinaryFloatingPointIeee754<T>
    {
        var a = Mat44<T>.Gen(T.One);
        var b = Mat44<T>.Gen(T.One + T.One);

        var mul = a * b;

        var expected = (a.Silk() * b.Silk()).Mat44();

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
