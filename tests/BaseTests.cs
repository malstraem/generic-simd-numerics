namespace System.Numerics.Tests;

public class BaseTests
{
    [Test]
    public void SimpleTest()
    {
        var vec1 = new Vec3<float>(1, 2, 3);
        var vec2 = new Vec3<float>(4, 5, 6);

        var temp = vec1 + vec2;

    }
}
