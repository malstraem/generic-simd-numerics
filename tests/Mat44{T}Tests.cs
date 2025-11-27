namespace System.Numerics.Tests.Matrix;

public class Mat44Base<T> where T : unmanaged, INumber<T>
{
    protected static readonly Mat44<T>
       x = Mat44<T>.Gen(T.One),
       y = Mat44<T>.Gen(T.One + T.One);

    [Test]
    public async Task Multiply()
    {
        var mul = x * y;

        var expected = (x.Silk() * y.Silk()).Mat44();

        await Assert.That(mul).IsEqualTo(expected);
    }

    public async Task MultiplyByVector()
    {
        var mat = Matrix44<T>.Generate(T.One);
        var vec = Vector4<T>.Generate(T.One + T.One);

        vec *= mat;

        var expected = (Vector4D<T>)vec * (Matrix4X4<T>)mat;

        await Assert.That(vec).IsEqualTo(expected);
    }
}
