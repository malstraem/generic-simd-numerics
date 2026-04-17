using Silk.NET.Maths;

namespace System.Numerics.Tests.Matrix44;

[InheritsTests]
public class Mat44f32 : Mat44WithQuaternion<float>
{
    [Test, Repeat(99), DisplayName("translation (vs System.Numerics)")]
    public async Task TranslationSystem()
    {
        var t = Position;

        var translation = Mat44.Translation(t);

        var expected = Matrix4x4.CreateTranslation(t.System()).Mat44();

        await Assert.That(translation).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("rotation (vs System.Numerics)")]
    public async Task RotationSystem()
    {
        var r = Rotation;

        var rotation = Mat44.Rotation(r);

        var expected = Matrix4x4.CreateFromQuaternion(r.System()).Mat44();

        await Assert.That(rotation).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("scale (vs System.Numerics)")]
    public async Task ScaleSystem()
    {
        var s = Scale;

        var scale = Mat44.Scale(s);

        var expected = Matrix4x4.CreateScale(s.System()).Mat44();

        await Assert.That(scale).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("transform (vs System.Numerics)")]
    public async Task RotateSystem()
    {
        var r = Rotation;

        var rotated = Mat44.Rotate(a, r);

        var expected = Matrix4x4.Transform(a.System(), r.System()).Mat44();

        await Assert.That(rotated).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("affine (vs System.Numerics)")]
    public async Task AffineSystem()
    {
        Affine(out var t, out var r, out var s);

        var affine = Mat44.Affine(t, r, s);

        var expected = (Matrix4x4.CreateScale(s.System())
                      * Matrix4x4.CreateFromQuaternion(r.System())
                      * Matrix4x4.CreateTranslation(t.System())).Mat44();

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

    protected void Affine(out Vec3<T> t, out Quat<T> r, out Vec3<T> s)
    {
        t = Position;
        r = Rotation;
        s = Scale;
    }

    [Test, Repeat(99), DisplayName("translation")]
    public async Task Translation()
    {
        var t = Position;

        var translation = Mat44.Translation(t);

        var expected = Matrix4X4.CreateTranslation(t.Silk()).Mat44();

        await Assert.That(translation).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("rotation")]
    public async Task FromRotation()
    {
        var r = Rotation;

        var rotation = Mat44.Rotation(r);

        var expected = Matrix4X4.CreateFromQuaternion(r.Silk()).Mat44();

        await Assert.That(rotation).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("scale")]
    public async Task FromScale()
    {
        var s = Scale;

        var scale = Mat44.Scale(s);

        var expected = Matrix4X4.CreateScale(s.Silk()).Mat44();

        await Assert.That(scale).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("rotate")]
    public async Task Rotate()
    {
        var r = Rotation;

        var rotated = Mat44.Rotate(a, r);

        var expected = Matrix4X4.Transform(a.Silk(), r.Silk()).Mat44();

        await Assert.That(rotated).IsEqualTo(expected);
    }

    [Test, Repeat(99), DisplayName("affine")]
    public async Task Affine()
    {
        Affine(out var t, out var r, out var s);

        var affine = Mat44.Affine(t, r, s);

        var expected = (Matrix4X4.CreateScale(s.Silk())
                      * Matrix4X4.CreateFromQuaternion(r.Silk())
                      * Matrix4X4.CreateTranslation(t.Silk())).Mat44();

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
