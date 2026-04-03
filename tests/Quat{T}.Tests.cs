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
       x = Quat<T>.Gen(T.One),
       y = Quat<T>.Gen(T.One + T.One),
       min = Quat<T>.Gen(-T.One),
       max = Quat<T>.Gen(T.One + T.One + T.One),
       quat = Quat<T>.Gen(T.One + T.One + T.One + T.One),
       negative = -quat;

    [Test, DisplayName("x + y")]
    public async Task Add()
    {
        var add = x + y;

        var expected = (x.Silk() + y.Silk()).Quat();

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(Quat.Add(x, y)).IsEqualTo(add);
    }

    [Test, DisplayName("x - y")]
    public async Task Substract()
    {
        var sub = x - y;

        var expected = (x.Silk() - y.Silk()).Quat();

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(Quat.Substruct(x, y)).IsEqualTo(sub);
    }

    [Test, DisplayName("x * y")]
    public async Task Multiply()
    {
        var mul = x * y;

        var expected = (x.Silk() * y.Silk()).Quat();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(Quat.Multiply(x, y)).IsEqualTo(mul);
    }

    [Test, DisplayName("x / y")]
    public async Task Divide()
    {
        var div = x / y;

        var expected = (x.Silk() / y.Silk()).Quat();

        await Assert.That(div.X - expected.X).IsLessThan(eps);
        await Assert.That(div.Y - expected.Y).IsLessThan(eps);
        await Assert.That(div.Z - expected.Z).IsLessThan(eps);
        await Assert.That(div.W - expected.W).IsLessThan(eps);

        await Assert.That(Quat.Divide(x, y)).IsEqualTo(div);
    }

    [Test, DisplayName("dot")]
    public async Task Dot()
    {
        var dot = x.Dot(y);

        var expected = Quaternion<T>.Dot(x.Silk(), y.Silk());

        await Assert.That(dot).IsEqualTo(expected);
        await Assert.That(Quat.Dot(x, y)).IsEqualTo(dot);
    }

    [Test, DisplayName("len")]
    public async Task Length()
    {
        var length = quat.Length();

        var expected = quat.Silk().Length();

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(Quat.Length(quat)).IsEqualTo(length);
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = quat.LengthSquared();

        var expected = quat.Silk().LengthSquared();

        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var normal = quat.Normalize();

        var expected = Quaternion<T>.Normalize(quat.Silk()).Quat();

        await Assert.That(normal).IsEqualTo(expected);
        await Assert.That(Quat.Normalize(quat)).IsEqualTo(normal);
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = x.Lerp(y, amount);

        var expected = Quaternion<T>.Lerp(x.Silk(), y.Silk(), amount).Quat();

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(Quat.Lerp(x, y, amount)).IsEqualTo(lerp);
    }

    [Test, DisplayName("conj")]
    public async Task Conjugate()
    {
        var con = x.Conjugate();

        var expected = Quaternion<T>.Conjugate(x.Silk()).Quat();

        await Assert.That(con.X - expected.X).IsLessThan(eps);
        await Assert.That(con.Y - expected.Y).IsLessThan(eps);
        await Assert.That(con.Z - expected.Z).IsLessThan(eps);
        await Assert.That(con.W - expected.W).IsLessThan(eps);

        await Assert.That(Quat.Conjugate(x)).IsEqualTo(con);
    }

    [Test, DisplayName("inv")]
    public async Task Inverse()
    {
        var inv = x.Inverse();

        var expected = Quaternion<T>.Inverse(x.Silk()).Quat();

        await Assert.That(inv.X - expected.X).IsLessThan(eps);
        await Assert.That(inv.Y - expected.Y).IsLessThan(eps);
        await Assert.That(inv.Z - expected.Z).IsLessThan(eps);
        await Assert.That(inv.W - expected.W).IsLessThan(eps);

        await Assert.That(Quat.Inverse(x)).IsEqualTo(inv);
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
