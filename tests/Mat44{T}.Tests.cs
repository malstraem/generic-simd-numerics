using System.Runtime.Intrinsics;

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

    [Test, Repeat(9), DisplayName("rotate compare")]
    public async Task Compare()
    {
        var r = Rotation;

        var ours = Mat44.Rotate(a, r).Silk().As<decimal>();

        var sys = (a.System() * Matrix4x4.CreateFromQuaternion(r.System())).Mat44<T>().Silk().As<decimal>();

        if (ours == sys)
            return;

        var decRes = Rotate(a.Silk().As<decimal>(), r.Silk().As<decimal>());

        decimal row1TolOurs = (decRes.Row1 - ours.Row1).LengthSquared;
        decimal row2TolOurs = (decRes.Row2 - ours.Row2).LengthSquared;
        decimal row3TolOurs = (decRes.Row3 - ours.Row3).LengthSquared;
        decimal row4TolOurs = (decRes.Row4 - ours.Row4).LengthSquared;

        decimal frobNormOurs = row1TolOurs + row2TolOurs + row3TolOurs + row4TolOurs;

        decimal row1TolSys = (decRes.Row1 - sys.Row1).LengthSquared;
        decimal row2TolSys = (decRes.Row2 - sys.Row2).LengthSquared;
        decimal row3TolSys = (decRes.Row3 - sys.Row3).LengthSquared;
        decimal row4TolSys = (decRes.Row4 - sys.Row4).LengthSquared;

        decimal frobNormSys = row1TolSys + row2TolSys + row3TolSys + row4TolSys;

        Assert.Fail($"Quaternion is {r}.\n" +
            $"Tolerance: ours ; sys\n" +
            $"Row1: {row1TolOurs} ; {row1TolSys}\n" +
            $"Is sys better {row1TolSys < row1TolOurs}\n" +
            $"Row2: {row2TolOurs} ; {row2TolSys}\n" +
            $"Is sys better {row2TolSys < row2TolOurs}\n" +
            $"Row3: {row3TolOurs} ; {row3TolSys}\n" +
            $"Is sys better {row3TolSys < row3TolOurs}\n" +
            $"Row4: {row4TolOurs} ; {row4TolSys}\n" +
            $"Is sys better {row4TolSys < row4TolOurs}\n" +
            $"Frobenius norm: {frobNormOurs} ; {frobNormSys}\n" +
            $"Is sys better {frobNormSys < frobNormOurs}\n");
    }

    public static Matrix4X4<decimal> Rotate(Matrix4X4<decimal> m, Quaternion<decimal> r)
    {
        decimal
        xx = r.X + r.X, yy = r.Y + r.Y, zz = r.Z + r.Z,

        xy = r.X * yy, xw = xx * r.W,
        yz = r.Y * zz, yw = yy * r.W,
        zx = r.Z * xx, zw = zz * r.W;

        xx = r.X * xx; yy = r.Y * yy; zz = r.Z * zz;

        decimal
        q11 = 1 - yy - zz, q12 = xy + zw, q13 = zx - yw,
        q21 = xy - zw, q22 = 1 - xx - zz, q23 = yz + xw,
        q31 = zx + yw, q32 = yz - xw, q33 = 1 - xx - yy;

        return new(
            (m.Row1.X * q11) + (m.Row1.Y * q21) + (m.Row1.Z * q31),
            (m.Row1.X * q12) + (m.Row1.Y * q22) + (m.Row1.Z * q32),
            (m.Row1.X * q13) + (m.Row1.Y * q23) + (m.Row1.Z * q33),
             m.Row1.W,

            (m.Row2.X * q11) + (m.Row2.Y * q21) + (m.Row2.Z * q31),
            (m.Row2.X * q12) + (m.Row2.Y * q22) + (m.Row2.Z * q32),
            (m.Row2.X * q13) + (m.Row2.Y * q23) + (m.Row2.Z * q33),
             m.Row2.W,

            (m.Row3.X * q11) + (m.Row3.Y * q21) + (m.Row3.Z * q31),
            (m.Row3.X * q12) + (m.Row3.Y * q22) + (m.Row3.Z * q32),
            (m.Row3.X * q13) + (m.Row3.Y * q23) + (m.Row3.Z * q33),
             m.Row3.W,

            (m.Row4.X * q11) + (m.Row4.Y * q21) + (m.Row4.Z * q31),
            (m.Row4.X * q12) + (m.Row4.Y * q22) + (m.Row4.Z * q32),
            (m.Row4.X * q13) + (m.Row4.Y * q23) + (m.Row4.Z * q33),
             m.Row4.W);
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
