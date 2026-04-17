using Silk.NET.Maths;

namespace System.Numerics.Tests.Matrix44;

[InheritsTests]
public class Mat44f32 : Mat44WithQuaternion<float>
{
    [Test, Repeat(99), DisplayName("translation (vs System.Numerics)")]
    public async Task TranslationSystem()
    {
        var t = Mat44.Translation(Position);

        var expected = Matrix4x4.CreateTranslation(Position.System()).Mat44();

        await Assert.That(t).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("rotation (vs System.Numerics)")]
    public async Task RotationSystem()
    {
        var r = Mat44.FromRotation(Rotation);

        var expected = Matrix4x4.CreateFromQuaternion(Rotation.System()).Mat44();

        await Assert.That(r).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("scale (vs System.Numerics)")]
    public async Task ScaleSystem()
    {
        var s = Mat44.FromScale(Scale);

        var expected = Matrix4x4.CreateScale(Scale.System()).Mat44();

        await Assert.That(s).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("transform (vs System.Numerics)")]
    public async Task TransformSystem()
    {
        var transformed = Mat44.Rotate(a, Rotation);

        var expected = Matrix4x4.Transform(a.System(), Rotation.System()).Mat44();

        await Assert.That(transformed).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("affine (vs System.Numerics)")]
    public async Task AffineSystem()
    {
        var affine = Mat44.Affine(Position, Rotation, Scale);

        var expected = (Matrix4x4.CreateScale(Scale.System())
                      * Matrix4x4.CreateFromQuaternion(Rotation.System())
                      * Matrix4x4.CreateTranslation(Position.System())).Mat44();

        await Assert.That(affine).IsEqualTo(expected);
    }
}

[InheritsTests]
public class Mat44f64 : Mat44WithQuaternion<double>;

[InheritsTests]
public abstract class Mat44WithQuaternion<T> : Mat44Base<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    protected static Quat<T> Rotation => Quat.YawPitchRoll(
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()));

    protected static Vec3<T> Position => new(
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()));

    protected static Vec3<T> Scale => new(
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()));

    [Test, Repeat(99), DisplayName("translation")]
    public async Task Translation()
    {
        var t = Mat44.Translation(Position);

        var expected = Matrix4X4.CreateTranslation(Position.Silk()).Mat44();

        await Assert.That(t).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("rotation")]
    public async Task FromRotation()
    {
        var r = Mat44.FromRotation(Rotation);

        var expected = Matrix4X4.CreateFromQuaternion(Rotation.Silk()).Mat44();

        await Assert.That(r).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("scale")]
    public async Task FromScale()
    {
        var s = Mat44.FromScale(Scale);

        var expected = Matrix4X4.CreateScale(Scale.Silk()).Mat44();

        await Assert.That(s).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("transform")]
    public async Task Transform()
    {
        var transformed = Mat44.Rotate(a, Rotation);

        var expected = Matrix4X4.Transform(a.Silk(), Rotation.Silk()).Mat44();

        await Assert.That(transformed).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("affine")]
    public async Task Affine()
    {
        var affine = Mat44.Affine(Position, Rotation, Scale);

        var expected = (Matrix4X4.CreateScale(Scale.Silk())
                      * Matrix4X4.CreateFromQuaternion(Rotation.Silk())
                      * Matrix4X4.CreateTranslation(Position.Silk())).Mat44();

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
