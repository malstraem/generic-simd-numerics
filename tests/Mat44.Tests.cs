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
       mat = Mat44<T>.Gen(T.One);

    protected static readonly Quat<T>
       quat = Quat<T>.Gen(T.One);

    protected static readonly Vec3<T>
       vec = Vec3<T>.Gen(T.One),
       scale = Vec3<T>.Gen(T.One + T.One);

    [Test, DisplayName("from quaternion")]
    public async Task CreateFromQuaternion()
    {
        var res = Mat44.CreateFromQuat(quat);

        var expected = Matrix4X4.CreateFromQuaternion(quat.Silk()).Mat44();

        await Assert.That(res).IsEqualTo(expected);
    }

    [Test, DisplayName("from translation")]
    public async Task CreateFromTranslation()
    {
        var res = Mat44.CreateFromTranslation(vec);

        var expected = Matrix4X4.CreateTranslation(vec.Silk()).Mat44();

        await Assert.That(res).IsEqualTo(expected);
    }

    [Test, DisplayName("from scale")]
    public async Task CreateFromScale()
    {
        var res = Mat44.CreateFromScale(vec);

        var expected = Matrix4X4.CreateScale(vec.Silk()).Mat44();

        await Assert.That(res).IsEqualTo(expected);
    }

    [Test, DisplayName("transfrom")]
    public async Task Transform()
    {
        var res = Mat44.Transfrom(mat, quat);

        var expected = Matrix4X4.Transform(mat.Silk(), quat.Silk()).Mat44();

        await Assert.That(res).IsEqualTo(expected);
    }

    [Test, DisplayName("create model matrix")]
    public async Task FromTranslationRotationScale()
    {
        var res = Mat44.FromTranslationRotationScale(vec, quat, scale);

        var expected = (Matrix4X4.CreateScale(scale.Silk())
                      * Matrix4X4.CreateFromQuaternion(quat.Silk())
                      * Matrix4X4.CreateTranslation(vec.Silk())).Mat44();

        await Assert.That(res).IsEqualTo(expected);
    }
}
