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

    protected static readonly Vec3<T> axis = Vec3<T>.Gen(T.One).Normalize();

    protected static readonly T yaw = T.One / T.CreateChecked(10),
                                pitch = (T.One + T.One) / T.CreateChecked(10),
                                roll = (T.One + T.One + T.One) / T.CreateChecked(10);

    protected static readonly Quat<T>
       x = Quat<T>.Gen(T.One),
       y = Quat<T>.Gen(T.One + T.One),
       min = Quat<T>.Gen(-T.One),
       max = Quat<T>.Gen(T.One + T.One + T.One),
       vec = Quat<T>.Gen(T.One + T.One + T.One + T.One),
       negative = -vec;

    [Test, DisplayName("x + y")]
    public async Task Add()
    {
        var add = x + y;

        var expected = (x.Silk() + y.Silk()).Quat();

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Quat<T>.Add(x, y));
    }

    [Test, DisplayName("x - y")]
    public async Task Substract()
    {
        var sub = x - y;

        var expected = (x.Silk() - y.Silk()).Quat();

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Quat<T>.Subtract(x, y));
    }

    [Test, DisplayName("x * y")]
    public async Task Multiply()
    {
        var mul = x * y;

        var expected = (x.Silk() * y.Silk()).Quat();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Quat<T>.Multiply(x, y));
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

        await Assert.That(div).IsEqualTo(Quat<T>.Divide(x, y));
    }

    [Test, DisplayName("dot")]
    public async Task Dot()
    {
        var dot = Quat<T>.Dot(x, y);

        var expected = Quaternion<T>.Dot(x.Silk(), y.Silk());

        await Assert.That(dot).IsEqualTo(expected);
    }

    [Test, DisplayName("len")]
    public async Task Length()
    {
        var length = vec.Length();

        var expected = vec.Silk().Length();

        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = vec.LengthSquared();

        var expected = vec.Silk().LengthSquared();

        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var normal = Quat<T>.Normalize(vec);

        var expected = Quaternion<T>.Normalize(vec.Silk()).Quat();

        await Assert.That(normal).IsEqualTo(expected);
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = Quat<T>.Lerp(x, y, amount);

        var expected = Quaternion<T>.Lerp(x.Silk(), y.Silk(), amount).Quat();

        await Assert.That(lerp).IsEqualTo(expected);
    }

    [Test, DisplayName("inv")]
    public async Task Inverse()
    {
        var inv = Quat<T>.Inverse(x);

        var expected = Quaternion<T>.Inverse(x.Silk()).Quat();

        await Assert.That(inv.X - expected.X).IsLessThan(eps);
        await Assert.That(inv.Y - expected.Y).IsLessThan(eps);
        await Assert.That(inv.Z - expected.Z).IsLessThan(eps);
        await Assert.That(inv.W - expected.W).IsLessThan(eps);
    }

    [Test, DisplayName("conj")]
    public async Task Conjugate()
    {
        var con = Quat<T>.Conjugate(x);

        var expected = Quaternion<T>.Conjugate(x.Silk()).Quat();

        await Assert.That(con.X - expected.X).IsLessThan(eps);
        await Assert.That(con.Y - expected.Y).IsLessThan(eps);
        await Assert.That(con.Z - expected.Z).IsLessThan(eps);
        await Assert.That(con.W - expected.W).IsLessThan(eps);
    }

    [Test, DisplayName("axis/angle")]
    public async Task FromAxisAngle()
    {
        var aa = Quat<T>.CreateFromAxisAngle(axis, yaw);

        var expected = Quaternion<T>.CreateFromAxisAngle(axis.Silk(), yaw).Quat();

        await Assert.That(aa.X - expected.X).IsLessThan(eps);
        await Assert.That(aa.Y - expected.Y).IsLessThan(eps);
        await Assert.That(aa.Z - expected.Z).IsLessThan(eps);
        await Assert.That(aa.W - expected.W).IsLessThan(eps);
    }

    [Test, DisplayName("yaw/pitch/roll")]
    public async Task FromYawPitchRoll()
    {
        var ypr = Quat<T>.CreateFromYawPitchRoll(yaw, pitch, roll);

        var expected = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll).Quat();

        await Assert.That(ypr.X - expected.X).IsLessThan(eps);
        await Assert.That(ypr.Y - expected.Y).IsLessThan(eps);
        await Assert.That(ypr.Z - expected.Z).IsLessThan(eps);
        await Assert.That(ypr.W - expected.W).IsLessThan(eps);
    }

    [Test, DisplayName("rotation")]
    public async Task FromRotationMatrix()
    {
        var m = Matrix4X4.CreateRotationX(yaw) * Matrix4X4.CreateRotationX(pitch) * Matrix4X4.CreateScale(T.One + T.One);

        var rot = Quat<T>.CreateFromRotationMatrix(m.Mat44());

        var expected = Quaternion<T>.CreateFromRotationMatrix(m).Quat();

        await Assert.That(rot.X - expected.X).IsLessThan(eps);
        await Assert.That(rot.Y - expected.Y).IsLessThan(eps);
        await Assert.That(rot.Z - expected.Z).IsLessThan(eps);
        await Assert.That(rot.W - expected.W).IsLessThan(eps);
    }
}
