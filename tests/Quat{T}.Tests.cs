using System.Runtime.CompilerServices;

using Silk.NET.Maths;

namespace System.Numerics.Tests.Quaternion;

[InheritsTests]
public class Quatf32 : Quat<float>;

[InheritsTests]
public class Quatf64 : Quat<double>;

public abstract class Quat<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    protected static readonly T ten = T.One + T.One + T.One + T.One + T.One + T.One + T.One + T.One + T.One + T.One;

    protected static readonly T eps = T.One / (ten * ten * ten);

    protected static readonly Vec3<T> axis = Vec3<T>.Gen(T.One).Normalize();

    protected static readonly T yaw = T.One / ten,
                                pitch = (T.One + T.One) / ten,
                                roll = (T.One + T.One + T.One) / ten;

    protected static readonly Numerics.Quat<T>
       x = Numerics.Quat<T>.Gen(T.One),
       y = Numerics.Quat<T>.Gen(T.One + T.One),
       min = Numerics.Quat<T>.Gen(-T.One),
       max = Numerics.Quat<T>.Gen(T.One + T.One + T.One),
       vec = Numerics.Quat<T>.Gen(T.One + T.One + T.One + T.One),
       negative = -vec;

    [Test, DisplayName("x + y")]
    public async Task Add()
    {
        var add = x + y;

        var expected = (x.Silk() + y.Silk()).Quat();

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Numerics.Quat<T>.Add(x, y));
    }

    [Test, DisplayName("x - y")]
    public async Task Substract()
    {
        var sub = x - y;

        var expected = (x.Silk() - y.Silk()).Quat();

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Numerics.Quat<T>.Subtract(x, y));
    }

    [Test, DisplayName("x * y")]
    public async Task Multiply()
    {
        var mul = x * y;

        var expected = (x.Silk() * y.Silk()).Quat();

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Numerics.Quat<T>.Multiply(x, y));
    }

    [Test, DisplayName("x / y")]
    public async Task Divide()
    {
        var res = x / y;

        var expected = (x.Silk() / y.Silk()).Quat();

        await Assert.That(res.X).IsLessThan(expected.X + eps);
        await Assert.That(res.X).IsGreaterThan(expected.X - eps);

        await Assert.That(res.Y).IsLessThan(expected.Y + eps);
        await Assert.That(res.Y).IsGreaterThan(expected.Y - eps);

        await Assert.That(res.Z).IsLessThan(expected.Z + eps);
        await Assert.That(res.Z).IsGreaterThan(expected.Z - eps);

        await Assert.That(res.W).IsLessThan(expected.W + eps);
        await Assert.That(res.W).IsGreaterThan(expected.W - eps);

        expected = Numerics.Quat<T>.Divide(x, y);

        await Assert.That(res.X).IsLessThan(expected.X + eps);
        await Assert.That(res.X).IsGreaterThan(expected.X - eps);

        await Assert.That(res.Y).IsLessThan(expected.Y + eps);
        await Assert.That(res.Y).IsGreaterThan(expected.Y - eps);

        await Assert.That(res.Z).IsLessThan(expected.Z + eps);
        await Assert.That(res.Z).IsGreaterThan(expected.Z - eps);

        await Assert.That(res.W).IsLessThan(expected.W + eps);
        await Assert.That(res.W).IsGreaterThan(expected.W - eps);
    }

    [Test, DisplayName("dot")]
    public async Task Dot()
    {
        var dot = Numerics.Quat<T>.Dot(x, y);

        var expected = Quaternion<T>.Dot(x.Silk(), y.Silk());

        await Assert.That(dot).IsEqualTo(expected);
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var length = vec.LengthSquared();

        var expected = vec.Silk().LengthSquared();

        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("len")]
    public async Task Length()
    {
        var expected = vec.Silk().Length();

        var length = vec.Length();

        await Assert.That(length).IsEqualTo(expected);
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var normal = Numerics.Quat<T>.Normalize(vec);

        var expected = Quaternion<T>.Normalize(vec.Silk()).Quat();

        await Assert.That(normal).IsEqualTo(expected);
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var lerp = Numerics.Quat<T>.Lerp(x, y, amount);

        var expected = Quaternion<T>.Lerp(x.Silk(), y.Silk(), amount).Quat();

        await Assert.That(lerp).IsEqualTo(expected);
    }

    [Test, DisplayName("inverse")]
    public async Task Inverse()
    {
        var res = Numerics.Quat<T>.Inverse(x);

        var expected = Quaternion<T>.Inverse(x.Silk()).Quat();

        await Assert.That(res.X).IsLessThan(expected.X + eps);
        await Assert.That(res.X).IsGreaterThan(expected.X - eps);

        await Assert.That(res.Y).IsLessThan(expected.Y + eps);
        await Assert.That(res.Y).IsGreaterThan(expected.Y - eps);

        await Assert.That(res.Z).IsLessThan(expected.Z + eps);
        await Assert.That(res.Z).IsGreaterThan(expected.Z - eps);

        await Assert.That(res.W).IsLessThan(expected.W + eps);
        await Assert.That(res.W).IsGreaterThan(expected.W - eps);
    }

    [Test, DisplayName("conjugate")]
    public async Task Conjugate()
    {
        var res = Numerics.Quat<T>.Conjugate(x);

        var expected = Quaternion<T>.Conjugate(x.Silk()).Quat();

        await Assert.That(res.X).IsLessThan(expected.X + eps);
        await Assert.That(res.X).IsGreaterThan(expected.X - eps);

        await Assert.That(res.Y).IsLessThan(expected.Y + eps);
        await Assert.That(res.Y).IsGreaterThan(expected.Y - eps);

        await Assert.That(res.Z).IsLessThan(expected.Z + eps);
        await Assert.That(res.Z).IsGreaterThan(expected.Z - eps);

        await Assert.That(res.W).IsLessThan(expected.W + eps);
        await Assert.That(res.W).IsGreaterThan(expected.W - eps);
    }

    [Test, DisplayName("from axis angle")]
    public async Task FromAxisAngle()
    {
        var res = Numerics.Quat<T>.CreateFromAxisAngle(axis, yaw);

        var expected = Quaternion<T>.CreateFromAxisAngle(Unsafe.BitCast<Vec3<T>, Vector3D<T>>(axis), yaw).Quat();

        await Assert.That(res.X).IsLessThan(expected.X + eps);
        await Assert.That(res.X).IsGreaterThan(expected.X - eps);

        await Assert.That(res.Y).IsLessThan(expected.Y + eps);
        await Assert.That(res.Y).IsGreaterThan(expected.Y - eps);

        await Assert.That(res.Z).IsLessThan(expected.Z + eps);
        await Assert.That(res.Z).IsGreaterThan(expected.Z - eps);

        await Assert.That(res.W).IsLessThan(expected.W + eps);
        await Assert.That(res.W).IsGreaterThan(expected.W - eps);
    }

    [Test, DisplayName("from yaw pitch roll")]
    public async Task FromYawPitchRoll()
    {
        var res = Numerics.Quat<T>.CreateFromYawPitchRoll(yaw, pitch, roll);

        var expected = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll).Quat();

        await Assert.That(res.X).IsLessThan(expected.X + eps);
        await Assert.That(res.X).IsGreaterThan(expected.X - eps);

        await Assert.That(res.Y).IsLessThan(expected.Y + eps);
        await Assert.That(res.Y).IsGreaterThan(expected.Y - eps);

        await Assert.That(res.Z).IsLessThan(expected.Z + eps);
        await Assert.That(res.Z).IsGreaterThan(expected.Z - eps);

        await Assert.That(res.W).IsLessThan(expected.W + eps);
        await Assert.That(res.W).IsGreaterThan(expected.W - eps);
    }

    [Test, DisplayName("from rotation matrix")]
    public async Task FromRotationMatrix()
    {
        var matr = Matrix4X4.CreateRotationX(yaw) * Matrix4X4.CreateRotationX(pitch) * Matrix4X4.CreateScale(T.One + T.One);

        var res = Numerics.Quat<T>.CreateFromRotationMatrix(matr.Mat44());

        var expected = Quaternion<T>.CreateFromRotationMatrix(matr).Quat();

        await Assert.That(res.X).IsLessThan(expected.X + eps);
        await Assert.That(res.X).IsGreaterThan(expected.X - eps);

        await Assert.That(res.Y).IsLessThan(expected.Y + eps);
        await Assert.That(res.Y).IsGreaterThan(expected.Y - eps);

        await Assert.That(res.Z).IsLessThan(expected.Z + eps);
        await Assert.That(res.Z).IsGreaterThan(expected.Z - eps);

        await Assert.That(res.W).IsLessThan(expected.W + eps);
        await Assert.That(res.W).IsGreaterThan(expected.W - eps);
    }
}
