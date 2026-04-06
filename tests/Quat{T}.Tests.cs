using Silk.NET.Maths;

namespace System.Numerics.Tests.Quaternion;

[InheritsTests]
public class Quatf32 : QuatBase<float>;

[InheritsTests]
public class Quatf64 : QuatBase<double>;

public abstract class QuatBase<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    protected static readonly T eps = T.One / T.CreateTruncating(1e7);

    protected static readonly Vec3<T> axis = Vec3<T>.Gen(T.One);

    protected static readonly T yaw = T.One / T.CreateChecked(10),
                                pitch = (T.One + T.One) / T.CreateChecked(10),
                                roll = (T.One + T.One + T.One) / T.CreateChecked(10);

    protected static readonly Quat<T>
       a = Quat<T>.Gen(T.One),
       b = Quat<T>.Gen(T.One + T.One),
       min = Quat<T>.Gen(-T.One),
       max = a;

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

    [Test, DisplayName("a * b")]
    public async Task Multiply()
    {
        var mul = a * b;

        var expected = (a.Silk() * b.Silk()).Quat();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(Quat.Multiply(a, b)).IsEqualTo(mul);
    }

    [Test, DisplayName("a / b")]
    public async Task Divide()
    {
        var div = a / b;

        var expected = (a.Silk() / b.Silk()).Quat();

        await Assert.That(div.X - expected.X).IsLessThan(eps);
        await Assert.That(div.Y - expected.Y).IsLessThan(eps);
        await Assert.That(div.Z - expected.Z).IsLessThan(eps);
        await Assert.That(div.W - expected.W).IsLessThan(eps);

        await Assert.That(Quat.Divide(a, b)).IsEqualTo(div);
    }

    [Test, DisplayName("dot")]
    public async Task Dot()
    {
        var dot = a.Dot(b);

        var expected = Quaternion<T>.Dot(a.Silk(), b.Silk());

        await Assert.That(dot).IsEqualTo(expected);
        await Assert.That(Quat.Dot(a, b)).IsEqualTo(dot);
    }

    [Test, DisplayName("len")]
    public async Task Length()
    {
        var length = a.Length();

        var expected = a.Silk().Length();

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(Quat.Length(a)).IsEqualTo(length);
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = a.LengthSquared();

        var expected = a.Silk().LengthSquared();

        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var normal = a.Normalize();

        var expected = Quaternion<T>.Normalize(a.Silk()).Quat();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(Quat.Normalize(a)).IsEqualTo(normal);
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = a.Lerp(b, amount);

        var expected = Quaternion<T>.Lerp(a.Silk(), b.Silk(), amount).Quat();

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(Quat.Lerp(a, b, amount)).IsEqualTo(lerp);
    }

    [Test, DisplayName("conj")]
    public async Task Conjugate()
    {
        var conj = a.Conjugate();

        var expected = Quaternion<T>.Conjugate(a.Silk()).Quat();

        await Assert.That(conj.X - expected.X).IsLessThan(eps);
        await Assert.That(conj.Y - expected.Y).IsLessThan(eps);
        await Assert.That(conj.Z - expected.Z).IsLessThan(eps);
        await Assert.That(conj.W - expected.W).IsLessThan(eps);

        await Assert.That(Quat.Conjugate(a)).IsEqualTo(conj);
    }

    [Test, DisplayName("inv")]
    public async Task Inverse()
    {
        var inv = a.Inverse();

        var expected = Quaternion<T>.Inverse(a.Silk()).Quat();

        await Assert.That(inv.X - expected.X).IsLessThan(eps);
        await Assert.That(inv.Y - expected.Y).IsLessThan(eps);
        await Assert.That(inv.Z - expected.Z).IsLessThan(eps);
        await Assert.That(inv.W - expected.W).IsLessThan(eps);

        await Assert.That(Quat.Inverse(a)).IsEqualTo(inv);
    }

    [Test, DisplayName("axis & angle")]
    public async Task AxisAngle()
    {
        var aa = Quat.AxisAngle(axis, yaw);

        var expected = Quaternion<T>.CreateFromAxisAngle(axis.Silk(), yaw).Quat();

        await Assert.That(aa.X - expected.X).IsLessThan(eps);
        await Assert.That(aa.Y - expected.Y).IsLessThan(eps);
        await Assert.That(aa.Z - expected.Z).IsLessThan(eps);
        await Assert.That(aa.W - expected.W).IsLessThan(eps);
    }

    [Test, DisplayName("yaw & pitch & roll")]
    public async Task YawPitchRoll()
    {
        var ypr = Quat.YawPitchRoll(yaw, pitch, roll);

        var expected = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll).Quat();

        await Assert.That(ypr.X - expected.X).IsLessThan(eps);
        await Assert.That(ypr.Y - expected.Y).IsLessThan(eps);
        await Assert.That(ypr.Z - expected.Z).IsLessThan(eps);
        await Assert.That(ypr.W - expected.W).IsLessThan(eps);
    }

    [Test, DisplayName("rotation")]
    public async Task Rotation()
    {
        var m = Matrix4X4.CreateRotationX(yaw) * Matrix4X4.CreateRotationX(pitch) * Matrix4X4.CreateScale(T.One + T.One);

        var rot = Quat.Rotation(m.Mat44());

        var expected = Quaternion<T>.CreateFromRotationMatrix(m).Quat();

        await Assert.That(rot.X - expected.X).IsLessThan(eps);
        await Assert.That(rot.Y - expected.Y).IsLessThan(eps);
        await Assert.That(rot.Z - expected.Z).IsLessThan(eps);
        await Assert.That(rot.W - expected.W).IsLessThan(eps);
    }
}
