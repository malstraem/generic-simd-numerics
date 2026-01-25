namespace System.Numerics.Tests;

public abstract class Mat44Base<T> where T : unmanaged, INumber<T>
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
}
