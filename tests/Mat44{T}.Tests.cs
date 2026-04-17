using Silk.NET.Maths;

namespace System.Numerics.Tests.Matrix44;

[InheritsTests]
public class Mat44f32 : Mat44WithQuaternion<float>
{
    [Test, DisplayName("translation (vs System.Numerics)")]
    public async Task TranslationSystem()
    {
        var t = Mat44.Translation(position);

        var expected = Matrix4x4.CreateTranslation(position.System()).Mat44();

        await Assert.That(t).IsEqualTo(expected);
    }

    [Test, DisplayName("rotation (vs System.Numerics)")]
    public async Task RotationSystem()
    {
        var r = Mat44.FromRotation(rotation);

        var expected = Matrix4x4.CreateFromQuaternion(rotation.System()).Mat44();

        await Assert.That(r).IsEqualTo(expected);
    }

    [Test, DisplayName("scale (vs System.Numerics)")]
    public async Task ScaleSystem()
    {
        var s = Mat44.FromScale(scale);

        var expected = Matrix4x4.CreateScale(scale.System()).Mat44();

        await Assert.That(s).IsEqualTo(expected);
    }

    [Test, DisplayName("transform (vs System.Numerics)")]
    public async Task TransformSystem()
    {
        var transformed = Mat44.Rotate(a, rotation);

        var expected = Matrix4x4.Transform(a.System(), rotation.System()).Mat44();

        await Assert.That(transformed).IsEqualTo(expected);
    }

    [Test, DisplayName("affine (vs System.Numerics)")]
    public async Task AffineSystem()
    {
        var affine = Mat44.Affine(position, rotation, scale);

        var expected = (Matrix4x4.CreateScale(scale.System())
                      * Matrix4x4.CreateFromQuaternion(rotation.System())
                      * Matrix4x4.CreateTranslation(position.System())).Mat44();

        await Assert.That(affine).IsEqualTo(expected);
    }
}

[InheritsTests]
public class Mat44f64 : Mat44WithQuaternion<double>;

[InheritsTests]
public abstract class Mat44WithQuaternion<T> : Mat44Base<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    protected static readonly Quat<T> rotation = Quat.YawPitchRoll(
        T.CreateTruncating(0.333),
        T.CreateTruncating(0.333),
        T.CreateTruncating(0.333));

    protected static readonly Vec3<T> position = new(
        T.CreateTruncating(55555.55555),
        T.CreateTruncating(55555.55555),
        T.CreateTruncating(55555.55555));

    protected static readonly Vec3<T> scale = new(
        T.CreateTruncating(0.5),
        T.CreateTruncating(0.3),
        T.CreateTruncating(0.1));

    [Test, DisplayName("translation")]
    public async Task Translation()
    {
        var t = Mat44.Translation(position);

        var expected = Matrix4X4.CreateTranslation(position.Silk()).Mat44();

        await Assert.That(t).IsEqualTo(expected);
    }

    [Test, DisplayName("rotation")]
    public async Task Rotation()
    {
        var r = Mat44.FromRotation(rotation);

        var expected = Matrix4X4.CreateFromQuaternion(rotation.Silk()).Mat44();

        await Assert.That(r).IsEqualTo(expected);
    }

    [Test, DisplayName("scale")]
    public async Task Scale()
    {
        var s = Mat44.FromScale(scale);

        var expected = Matrix4X4.CreateScale(scale.Silk()).Mat44();

        await Assert.That(s).IsEqualTo(expected);
    }

    [Test, DisplayName("transform")]
    public async Task Transform()
    {
        var transformed = Mat44.Rotate(a, rotation);

        var expected = Matrix4X4.Transform(a.Silk(), rotation.Silk()).Mat44();

        await Assert.That(transformed).IsEqualTo(expected);
    }

    [Test, DisplayName("affine")]
    public async Task Affine()
    {
        var affine = Mat44.Affine(position, rotation, scale);

        var expected = (Matrix4X4.CreateScale(scale.Silk())
                      * Matrix4X4.CreateFromQuaternion(rotation.Silk())
                      * Matrix4X4.CreateTranslation(position.Silk())).Mat44();

        await Assert.That(affine).IsEqualTo(expected);
    }
}

[InheritsTests]
public class Mat44i8 : Mat44Base<sbyte>;

[InheritsTests]
public class Mat44ui8 : Mat44Base<byte>;

[InheritsTests]
public class Mat44i16 : Mat44Base<short>;

[InheritsTests]
public class Mat44ui16 : Mat44Base<ushort>;

[InheritsTests]
public class Mat44i32 : Mat44Base<int>;

[InheritsTests]
public class Mat44ui32 : Mat44Base<uint>;

[InheritsTests]
public class Mat44i64 : Mat44Base<long>;

[InheritsTests]
public class Mat44ui64 : Mat44Base<ulong>;

public abstract class Mat44Base<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Mat44<T>
       a = Mat44<T>.Gen(T.One),
       b = Mat44<T>.Gen(T.One + T.One + T.One);

    [Test, DisplayName("a + b")]
    public async Task Add()
    {
        var add = a + b;

        var expected = (a.Silk() + b.Silk()).Mat44();

        await Assert.That(add).IsEqualTo(expected);
    }

    [Test, DisplayName("a - b")]
    public async Task Subtract()
    {
        var sub = a - b;

        var expected = (a.Silk() - b.Silk()).Mat44();

        await Assert.That(sub).IsEqualTo(expected);
    }

    [Test, DisplayName("a × b")]
    public async Task Multiply()
    {
        var mul = a * b;

        var expected = (a.Silk() * b.Silk()).Mat44();

        await Assert.That(mul).IsEqualTo(expected);
    }
}
