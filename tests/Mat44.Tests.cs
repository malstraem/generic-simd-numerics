using Silk.NET.Maths;

namespace System.Numerics.Tests.Matrix44;

[InheritsTests]
public class Mat44Createf32 : Mat44CreateBase<float>;

[InheritsTests]
public class Mat44Createf64 : Mat44CreateBase<double>;

public abstract class Mat44CreateBase<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    protected static readonly Mat44<T>
       x = Mat44<T>.Gen(T.One),
       y = Mat44<T>.Gen(T.One + T.One + T.One);

    protected static readonly Quat<T>
       xx = Quat<T>.Gen(T.One);

    [Test, DisplayName("from quaternion")]
    public async Task CreateFromQuaternion()
    {
        var res = Mat44.CreateFromQuat(xx);

        var expected = Matrix4X4.CreateFromQuaternion(xx.Silk()).Mat44();

        await Assert.That(res).IsEqualTo(expected);
    }
}
