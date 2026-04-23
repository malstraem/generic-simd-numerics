using Silk.NET.Maths;

namespace System.Numerics.Mat44Tests;

/* need more time investments
    1) save and format random generation
    2) provide more edge cases with better way */

[InheritsTests]
public class Mat44f32 : Mat44WithQuaternion<float>;

[InheritsTests]
public class Mat44f64 : Mat44WithQuaternion<double>;

[InheritsTests]
public abstract class Mat44WithQuaternion<T> : Mat44Base<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    private static readonly bool system = typeof(T) == typeof(float);

    protected static Quat<T> Rotation => new(
        T.CreateTruncating(Random.Shared.NextDouble()),
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

    protected void Affine(out Quat<T> r, out Vec3<T> s, out Vec3<T> t)
    {
        t = Position;
        r = Rotation;
        s = Scale;
    }

    [Test, Repeat(9), DisplayName("translation")]
    public async Task FromTranslation()
    {
        var t = Position;

        var translation = Mat44.Translation(t);

        var expected = system ? Matrix4x4.CreateTranslation(t.System()).Mat44<T>()
                              : Matrix4X4.CreateTranslation(t.Silk()).Mat44();

        await Assert.That(translation).IsEqualTo(expected);
    }

    [Test, Repeat(9), DisplayName("rotation")]
    public async Task FromRotation()
    {
        var r = Rotation;

        var rotation = Mat44.Rotation(r);

        var expected = system ? Matrix4x4.CreateFromQuaternion(r.System()).Mat44<T>()
                              : Matrix4X4.CreateFromQuaternion(r.Silk()).Mat44();

        await Assert.That(rotation).IsEqualTo(expected);
    }

    [Test, Repeat(9), DisplayName("scale")]
    public async Task FromScale()
    {
        var s = Scale;

        var scale = Mat44.Scale(s);

        var expected = system ? Matrix4x4.CreateScale(s.System()).Mat44<T>()
                              : Matrix4X4.CreateScale(s.Silk()).Mat44();

        await Assert.That(scale).IsEqualTo(expected);
    }

    [Test, Repeat(9), DisplayName("rotate")]
    public async Task Rotate()
    {
        var r = Rotation;

        var rotated = Mat44.Rotate(a, r);

        var expected = system ? (a.System() * Matrix4x4.CreateFromQuaternion(r.System())).Mat44<T>() //Matrix4x4.Transform(a.System(), r.System()).Mat44<T>()
                              : Matrix4X4.Transform(a.Silk(), r.Silk()).Mat44();

        await Assert.That(rotated).IsEqualTo(expected).Because($"quaternion is {r}");
    }

    [Test, Repeat(9), DisplayName("affine")]
    public async Task Affine()
    {
        Affine(out var r, out var s, out var t);

        var affine = Mat44.Affine(r, s, t);

        var expected = system ? (Matrix4x4.CreateScale(s.System())
                               * Matrix4x4.CreateFromQuaternion(r.System())
                               * Matrix4x4.CreateTranslation(t.System())).Mat44<T>()

                              : (Matrix4X4.CreateScale(s.Silk())
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
