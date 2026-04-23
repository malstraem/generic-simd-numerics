using Silk.NET.Maths;

namespace System.Numerics.QuatTests;

/* need more time investments
    1) random generation with saving/formatting
    2) provide more edge cases with better way */

[InheritsTests]
public class Quatf32 : QuatBase<float>;

[InheritsTests]
public class Quatf64 : QuatBase<double>;

public abstract class QuatBase<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    private static readonly bool system = typeof(T) == typeof(float);

    private static readonly T num1 = T.CreateTruncating(0.123456789),
                              num2 = T.CreateTruncating(0.555555555),
                              num3 = T.CreateTruncating(0.333333333);

    private static readonly Quat<T> a = new(num1, num1, num1, num1),
                                    b = new(num2, num2, num2, num2);

    private static readonly Vec3<T> axis = new(num3, num3, num3);

    [Test, DisplayName("a × b")]
    public async Task Multiply()
    {
        var mul = a * b;

        await Assert.That(Quat.Multiply(a, b)).IsEqualTo(mul);

        if (system)
        {
            await Assert.That(mul).IsEqualTo((a.System() * b.System()).Quat<T>());
            return;
        }

        var eps = T.One / T.CreateTruncating(1e16);

        var expected = (a.Silk() * b.Silk()).Quat();

        await Assert.That(eps).IsGreaterThanOrEqualTo(T.Abs(mul.X - expected.X))
                          .And.IsGreaterThanOrEqualTo(T.Abs(mul.Y - expected.Y))
                          .And.IsGreaterThanOrEqualTo(T.Abs(mul.Z - expected.Z))
                          .And.IsGreaterThanOrEqualTo(T.Abs(mul.W - expected.W));
    }

    [Test, DisplayName("a / b")]
    public async Task Divide()
    {
        var div = a / b;

        await Assert.That(Quat.Divide(a, b)).IsEqualTo(div);

        if (system)
        {
            await Assert.That(div).IsEqualTo((a.System() / b.System()).Quat<T>());
            return;
        }

        var eps = T.One / T.CreateTruncating(1e16);

        var expected = (a.Silk() / b.Silk()).Quat();

        await Assert.That(eps).IsGreaterThanOrEqualTo(T.Abs(div.X - expected.X))
                          .And.IsGreaterThanOrEqualTo(T.Abs(div.Y - expected.Y))
                          .And.IsGreaterThanOrEqualTo(T.Abs(div.Z - expected.Z))
                          .And.IsGreaterThanOrEqualTo(T.Abs(div.W - expected.W));
    }

    [Test, DisplayName("dot")]
    public async Task Dot()
    {
        var dot = a.Dot(b);

        await Assert.That(Quat.Dot(a, b)).IsEqualTo(dot);

        var expected = system ? (T)(object)Quaternion.Dot(a.System(), b.System())
                                      : Quaternion<T>.Dot(a.Silk(), b.Silk());

        await Assert.That(dot).IsEqualTo(expected);
    }

    [Test, DisplayName("len")]
    public async Task Length()
    {
        var len = a.Length();

        await Assert.That(Quat.Length(a)).IsEqualTo(len);

        var expected = system ? (T)(object)a.System().Length()
                                           : a.Silk().Length();

        await Assert.That(len).IsEqualTo(expected);
    }

    [Test, DisplayName("len²")]
    public async Task LengthSquared()
    {
        var len = a.LengthSquared();

        await Assert.That(Quat.LengthSquared(a)).IsEqualTo(len);

        var expected = system ? (T)(object)a.System().LengthSquared()
                                           : a.Silk().LengthSquared();

        await Assert.That(len).IsEqualTo(expected);
    }

    [Test, DisplayName("norm")]
    public async Task Normalize()
    {
        var norm = a.Normalize();

        await Assert.That(Quat.Normalize(a)).IsEqualTo(norm);

        var expected = system ? Quaternion.Normalize(a.System()).Quat<T>()
                           : Quaternion<T>.Normalize(a.Silk()).Quat();

        await Assert.That(norm).IsEqualTo(expected);
    }

    [Test, DisplayName("lerp")]
    public async Task Lerp()
    {
        var am = T.One + T.One + T.One;

        var lerp = a.Lerp(b, am);

        await Assert.That(Quat.Lerp(a, b, am)).IsEqualTo(lerp);

        var expected = system ? Quaternion.Lerp(a.System(), b.System(), (float)(object)am).Quat<T>()
                           : Quaternion<T>.Lerp(a.Silk(), b.Silk(), am).Quat();

        await Assert.That(lerp).IsEqualTo(expected);
    }

    [Test, DisplayName("conj")]
    public async Task Conjugate()
    {
        var conj = a.Conjugate();

        var expected = Quaternion<T>.Conjugate(a.Silk()).Quat();

        await Assert.That(conj).IsEqualTo(expected);
        await Assert.That(Quat.Conjugate(a)).IsEqualTo(conj);
    }

    [Test, DisplayName("inv")]
    public async Task Inverse()
    {
        var quat = Quat<T>.Rand();

        var inv = quat.Inverse();

        await Assert.That(Quat.Inverse(quat)).IsEqualTo(inv);

        if (system)
        {
            await Assert.That(inv).IsEqualTo(Quaternion.Inverse(quat.System()).Quat<T>());
            return;
        }

        var eps = T.One / T.CreateTruncating(1e15);

        var expected = Quaternion<T>.Inverse(quat.Silk()).Quat();

        await Assert.That(eps).IsGreaterThanOrEqualTo(T.Abs(inv.X - expected.X))
                          .And.IsGreaterThanOrEqualTo(T.Abs(inv.Y - expected.Y))
                          .And.IsGreaterThanOrEqualTo(T.Abs(inv.Z - expected.Z))
                          .And.IsGreaterThanOrEqualTo(T.Abs(inv.W - expected.W));
    }

    [Test, DisplayName("axis angle")]
    public async Task AxisAngle()
    {
        var aa = Quat.AxisAngle(axis, num3);

        var expected = system ? Quaternion.CreateFromAxisAngle(axis.System(), (float)(object)num3).Quat<T>()
                           : Quaternion<T>.CreateFromAxisAngle(axis.Silk(), num3).Quat();

        await Assert.That(aa).IsEqualTo(expected);
    }

    [Test, DisplayName("yaw pitch roll")]
    public async Task YawPitchRoll()
    {
        var ypr = Quat.YawPitchRoll(num1, num2, num3);

        var expected = system ? Quaternion.CreateFromYawPitchRoll((float)(object)num1, (float)(object)num2, (float)(object)num3).Quat<T>()
                           : Quaternion<T>.CreateFromYawPitchRoll(num1, num2, num3).Quat();

        await Assert.That(ypr).IsEqualTo(expected);
    }

    [Test, DisplayName("rotation")]
    public async Task Rotation()
    {
        var m = Matrix4X4.CreateFromYawPitchRoll(num1, num2, num3);

        var rot = Quat.Rotation(m.Mat44());

        var expected = system ? Quaternion.CreateFromRotationMatrix(m.As<float>().ToSystem()).Quat<T>()
                           : Quaternion<T>.CreateFromRotationMatrix(m).Quat();

        await Assert.That(rot).IsEqualTo(expected);
    }
}
