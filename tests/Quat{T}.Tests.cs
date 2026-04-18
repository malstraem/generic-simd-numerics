using Silk.NET.Maths;

namespace System.Numerics.QuatTests;

[InheritsTests]
public class Quatf32 : QuatBase<float>
{
    [Test, Repeat(9), DisplayName("a × b (system)")]
    public async Task MultiplySystem()
    {
        var mul = a * b;

        var expected = (a.System() * b.System()).Quat();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(Quat.Multiply(a, b)).IsEqualTo(mul);
    }

    [Test, Repeat(9), DisplayName("a / b (system)")]
    public async Task DivideSystem()
    {
        var div = a / b;

        var expected = (a.System() / b.System()).Quat();

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(Quat.Divide(a, b)).IsEqualTo(div);
    }

    [Test, Repeat(9), DisplayName("dot (system)")]
    public async Task DotSystem()
    {
        float dot = a.Dot(b);

        float expected = Quaternion.Dot(a.System(), b.System());

        await Assert.That(dot).IsEqualTo(expected);
        await Assert.That(Quat.Dot(a, b)).IsEqualTo(dot);
    }

    [Test, Repeat(9), DisplayName("len (system)")]
    public async Task LengthSystem()
    {
        float length = a.Length();

        float expected = a.System().Length();

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(Quat.Length(a)).IsEqualTo(length);
    }

    [Test, Repeat(9), DisplayName("len² (system)")]
    public async Task LengthSquaredSystem()
    {
        float length = a.LengthSquared();

        float expected = a.System().LengthSquared();

        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, Repeat(9), DisplayName("norm (system)")]
    public async Task NormalizeSystem()
    {
        var norm = a.Normalize();

        var expected = Quaternion.Normalize(a.System()).Quat();

        await Assert.That(norm).IsEqualTo(expected);
        await Assert.That(Quat.Normalize(a)).IsEqualTo(norm);
    }

    [Test, Repeat(9), DisplayName("lerp (system)")]
    public async Task LerpSystem()
    {
        float amount = 0.5f;

        var lerp = a.Lerp(b, amount);

        var expected = Quaternion.Lerp(a.System(), b.System(), amount).Quat();

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(Quat.Lerp(a, b, amount)).IsEqualTo(lerp);
    }

    [Test, Repeat(9), DisplayName("conj (system)")]
    public async Task ConjugateSystem()
    {
        var conj = a.Conjugate();

        var expected = Quaternion.Conjugate(a.System()).Quat();

        await Assert.That(conj).IsEqualTo(expected);
        await Assert.That(Quat.Conjugate(a)).IsEqualTo(conj);
    }

    [Test, Repeat(9), DisplayName("inv (system)")]
    public async Task InverseSystem()
    {
        var inv = a.Inverse();

        var expected = Quaternion.Inverse(a.System()).Quat();

        await Assert.That(inv).IsEqualTo(expected);
        await Assert.That(Quat.Inverse(a)).IsEqualTo(inv);
    }

    [Test, Repeat(9), DisplayName("axis & angle (system)")]
    public async Task AxisAngleSystem()
    {
        YawPitchRoll(out var yaw, out _, out _);

        var aa = Quat.AxisAngle(axis, yaw);

        var expected = Quaternion.CreateFromAxisAngle(axis.System(), yaw).Quat();

        await Assert.That(aa).IsEqualTo(expected);
    }

    [Test, Repeat(9), DisplayName("yaw pitch roll (system)")]
    public async Task YawPitchRollSystem()
    {
        YawPitchRoll(out var yaw, out var pitch, out var roll);

        var ypr = Quat.YawPitchRoll(yaw, pitch, roll);

        var expected = Quaternion.CreateFromYawPitchRoll(yaw, pitch, roll).Quat();

        await Assert.That(ypr).IsEqualTo(expected);
    }

    [Test, Repeat(9), DisplayName("rotation (system)")]
    public async Task RotationSystem()
    {
        YawPitchRoll(out var yaw, out var pitch, out var roll);

        var m = Matrix4x4.CreateFromYawPitchRoll(yaw, pitch, roll);

        var rot = Quat.Rotation(m.Mat44());

        var expected = Quaternion.CreateFromRotationMatrix(m).Quat();

        await Assert.That(rot).IsEqualTo(expected);
    }
}

[InheritsTests]
public class Quatf64 : QuatBase<double>;

public abstract class QuatBase<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    protected static readonly T eps = T.One / T.CreateTruncating(1e8);

    protected static T num = T.CreateTruncating(0.123456789),
                       num2 = T.CreateTruncating(0.55555555);

    protected static readonly Vec3<T> axis = Vec3<T>.Gen(T.One);

    protected static readonly Quat<T>
       a = new(num, num, num, num),
       b = new(num2, num2, num2, num2);

    protected void YawPitchRoll(out T yaw, out T pitch, out T roll)
    {
        yaw = T.CreateTruncating(Random.Shared.NextDouble());
        pitch = T.CreateTruncating(Random.Shared.NextDouble());
        roll = T.CreateTruncating(Random.Shared.NextDouble());
    }

    [Test, DisplayName("a + b")]
    public async Task Add()
    {
        var add = a + b;

        var expected = (a.Silk() + b.Silk()).Quat();

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(Quat.Add(a, b)).IsEqualTo(add);
    }

    [Test, DisplayName("a - b")]
    public async Task Subtract()
    {
        var sub = a - b;

        var expected = (a.Silk() - b.Silk()).Quat();

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(Quat.Subtruct(a, b)).IsEqualTo(sub);
    }

    [Test, Repeat(9), DisplayName("a × b")]
    public async Task Multiply()
    {
        var mul = a * b;

        var expected = (a.Silk() * b.Silk()).Quat();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(Quat.Multiply(a, b)).IsEqualTo(mul);
    }

    [Test, Repeat(9), DisplayName("a / b")]
    public async Task Divide()
    {
        var div = a / b;

        var expected = (a.Silk() / b.Silk()).Quat();

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(Quat.Divide(a, b)).IsEqualTo(div);
    }

    [Test, Repeat(9), DisplayName("dot")]
    public async Task Dot()
    {
        var dot = a.Dot(b);

        var expected = Quaternion<T>.Dot(a.Silk(), b.Silk());

        await Assert.That(dot).IsEqualTo(expected);
        await Assert.That(Quat.Dot(a, b)).IsEqualTo(dot);
    }

    [Test, Repeat(9), DisplayName("len")]
    public async Task Length()
    {
        var length = a.Length();

        var expected = a.Silk().Length();

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(Quat.Length(a)).IsEqualTo(length);
    }

    [Test, Repeat(9), DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = a.LengthSquared();

        var expected = a.Silk().LengthSquared();

        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, Repeat(9), DisplayName("norm")]
    public async Task Normalize()
    {
        var norm = a.Normalize();

        var expected = Quaternion<T>.Normalize(a.Silk()).Quat();

        // Silk.NET behavior not match with System.Numerics
        await Assert.That(norm.X - expected.X).IsLessThan(eps);
        await Assert.That(norm.Y - expected.Y).IsLessThan(eps);
        await Assert.That(norm.Z - expected.Z).IsLessThan(eps);
        await Assert.That(norm.W - expected.W).IsLessThan(eps);

        await Assert.That(Quat.Normalize(a)).IsEqualTo(norm);
    }

    [Test, Repeat(9), DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = a.Lerp(b, amount);

        var expected = Quaternion<T>.Lerp(a.Silk(), b.Silk(), amount).Quat();

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(Quat.Lerp(a, b, amount)).IsEqualTo(lerp);
    }

    [Test, Repeat(9), DisplayName("conj")]
    public async Task Conjugate()
    {
        var conj = a.Conjugate();

        var expected = Quaternion<T>.Conjugate(a.Silk()).Quat();

        await Assert.That(conj).IsEqualTo(expected);
        await Assert.That(Quat.Conjugate(a)).IsEqualTo(conj);
    }

    [Test, Repeat(9), DisplayName("inv")]
    public async Task Inverse()
    {
        YawPitchRoll(out var yaw, out var pitch, out var roll);

        var ypr = Quat.YawPitchRoll(yaw, pitch, roll);

        var inv = ypr.Inverse();

        var expected = Quaternion<T>.Inverse(ypr.Silk()).Quat();

        // Silk.NET behavior not match with System.Numerics
        await Assert.That(inv.X - expected.X).IsLessThan(eps);
        await Assert.That(inv.Y - expected.Y).IsLessThan(eps);
        await Assert.That(inv.Z - expected.Z).IsLessThan(eps);
        await Assert.That(inv.W - expected.W).IsLessThan(eps);

        await Assert.That(Quat.Inverse(ypr)).IsEqualTo(inv);
    }

    [Test, Repeat(9), DisplayName("axis & angle")]
    public async Task AxisAngle()
    {
        YawPitchRoll(out var yaw, out _, out _);

        var aa = Quat.AxisAngle(axis, yaw);

        var expected = Quaternion<T>.CreateFromAxisAngle(axis.Silk(), yaw).Quat();

        await Assert.That(aa).IsEqualTo(expected);
    }

    [Test, Repeat(9), DisplayName("yaw pitch roll")]
    public async Task YawPitchRoll()
    {
        YawPitchRoll(out var yaw, out var pitch, out var roll);

        var ypr = Quat.YawPitchRoll(yaw, pitch, roll);

        var expected = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll).Quat();

        await Assert.That(ypr).IsEqualTo(expected);
    }

    [Test, Repeat(9), DisplayName("rotation")]
    public async Task Rotation()
    {
        YawPitchRoll(out var yaw, out var pitch, out var roll);

        var m = Matrix4X4.CreateFromYawPitchRoll(yaw, pitch, roll);

        var rot = Quat.Rotation(m.Mat44());

        var expected = Quaternion<T>.CreateFromRotationMatrix(m).Quat();

        await Assert.That(rot).IsEqualTo(expected);
    }
}
