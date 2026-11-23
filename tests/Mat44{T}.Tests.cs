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
    where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    private static Quat<T> Rotation => new(
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()));

    private static Vec3<T> Position => new(
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()));

    private static Vec3<T> Scale => new(
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()),
        T.CreateTruncating(Random.Shared.NextDouble()));

    private void Affine(out Quat<T> r, out Vec3<T> s, out Vec3<T> t)
    {
        t = Position;
        r = Rotation;
        s = Scale;
    }

    [Test]
    [Arguments(
        0.5, -0.1, 0.6, 0,
        0.4, 0.8, -0.2, 0,
        -0.5, 0.4, 0.3, 0,
        0, 0, 0, 0.7)
    ]
    public async Task Invert(
        T m11, T m12, T m13, T m14,
        T m21, T m22, T m23, T m24,
        T m31, T m32, T m33, T m34,
        T m41, T m42, T m43, T m44)
    {
        Mat44<T> matrix = new(
            m11, m12, m13, m14,
            m21, m22, m23, m24,
            m31, m32, m33, m34,
            m41, m42, m43, m44);

        bool result = Mat44.TryInvert(matrix, out var inverted);

        bool expectedResult;

        Mat44<T> expected;

        if (system)
        {
            expectedResult = Matrix4x4.Invert(matrix.System(), out var inv);
            expected = inv.Mat44<T>();
        }
        else
        {
            expectedResult = Matrix4X4.Invert(matrix.Silk(), out var inv);
            expected = inv.Mat44();
        }
        await Assert.That(result).IsEqualTo(expectedResult);

        if (expectedResult)
            await Assert.That(inverted).IsEqualTo(expected);
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

    [Test]
    [Skip("run to see differences, also check frobenius norm")]
    public async Task Rotate()
    {
        var r = Rotation;

        var rotated = Mat44.Rotate(a, r);

        var expected = system ? Matrix4x4.Transform(a.System(), r.System()).Mat44<T>()
                              : Matrix4X4.Transform(a.Silk(), r.Silk()).Mat44();

        await Assert.That(rotated).IsEqualTo(expected).Because($"quaternion is {r}");
    }

    [Test, Repeat(999), DisplayName("compare rotations (kind of frobenius norm)")]
    [Skip("run to see differences")]
    public async Task FrobeniusCompareRotations()
    {
        if (typeof(T) == typeof(double)) // nobody cares...
            return;

        var r = Rotation;

        var draft = Mat44.Rotate(a, r).Silk().As<double>();

        var system = Matrix4x4.Transform(a.System(), r.System()).Mat44<T>().Silk().As<double>();

        var target = Matrix4X4.Transform(a.Silk().As<double>(), r.Silk().As<double>());

        double tol1 = (target.Row1 - draft.Row1).LengthSquared,
               tol2 = (target.Row2 - draft.Row2).LengthSquared,
               tol3 = (target.Row3 - draft.Row3).LengthSquared,
               tol4 = (target.Row4 - draft.Row4).LengthSquared,

               tolerSys1 = (target.Row1 - system.Row1).LengthSquared,
               tolerSys2 = (target.Row2 - system.Row2).LengthSquared,
               tolerSys3 = (target.Row3 - system.Row3).LengthSquared,
               tolerSys4 = (target.Row4 - system.Row4).LengthSquared,

        frob = double.Sqrt(tol1 + tol2 + tol3 + tol4),
        frobSystem = double.Sqrt(tolerSys1 + tolerSys2 + tolerSys3 + tolerSys4);

        if (frob < frobSystem)
            return;

        Assert.Fail(@$"Quaternion {r}
            Tolerance: draft | system
            Row1: {tol1} | {tolerSys1}
            Better? {(tolerSys1 < tol1 ? "system" : "draft")}

            Row2: {tol2} | {tolerSys2}
            Better? {(tolerSys2 < tol2 ? "system" : "draft")}

            Row3: {tol3} | {tolerSys3}
            Better? {(tolerSys3 < tol3 ? "system" : "draft")}

            Row4: {tol4} | {tolerSys4}
            Better? {(tolerSys4 < tol4 ? "system" : "draft")}
            Frobenius norm: {frob} | {frobSystem}");
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

[GenerateGenericTest(typeof(int), typeof(float))]
[GenerateGenericTest(typeof(int), typeof(double))]
[GenerateGenericTest(typeof(float), typeof(double))]
public class Mat44Conversion<T1, T2>
    where T1 : unmanaged, INumber<T1>
    where T2 : unmanaged, INumber<T2>
{
    private static readonly Mat44<T1> m = Mat44<T1>.Gen(T1.One);

    [Test]
    public async Task Convert()
    {
        var converted = m.As<T2>();

        var expected = m.Silk().As<T2>().Mat44();

        await Assert.That(converted).IsEqualTo(Mat44.As<T1, T2>(m));
        await Assert.That(converted).IsEqualTo(expected);

        var back = converted.As<T1>();

        var backExpected = converted.Silk().As<T1>().Mat44();

        await Assert.That(back).IsEqualTo(backExpected);
    }
}

public abstract class Mat44Base<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly bool system = typeof(T) == typeof(float);

    protected static readonly Mat44<T>
       a = Mat44<T>.Gen(T.One),
       b = Mat44<T>.Gen(T.One + T.One);

    [Test, DisplayName("==")]
    public async Task Equal()
    {
        bool equal = a == b;

        bool expected = system ? a.System() == b.System()
                               : a.Silk() == b.Silk();

        await Assert.That(equal).IsEqualTo(expected);
    }

    [Test, DisplayName("!=")]
    public async Task NotEqual()
    {
        bool equal = a != b;

        bool expected = system ? a.System() != b.System()
                               : a.Silk() != b.Silk();

        await Assert.That(equal).IsEqualTo(expected);
    }

    [Test, DisplayName("a + b")]
    public async Task Add()
    {
        var add = a + b;

        var expected = system ? (a.System() + b.System()).Mat44<T>()
                              : (a.Silk() + b.Silk()).Mat44();

        await Assert.That(add).IsEqualTo(expected);
    }

    [Test, DisplayName("a - b")]
    public async Task Subtract()
    {
        var sub = a - b;

        var expected = system ? (a.System() - b.System()).Mat44<T>()
                              : (a.Silk() - b.Silk()).Mat44();

        await Assert.That(sub).IsEqualTo(expected);
    }

    [Test, DisplayName("a × b")]
    public async Task Multiply()
    {
        var mul = a * b;

        var expected = system ? (a.System() * b.System()).Mat44<T>()
                              : (a.Silk() * b.Silk()).Mat44();

        await Assert.That(mul).IsEqualTo(expected);
    }

    [Test]
    public async Task Transpose()
    {
        var transpose = a.Transpose();

        var expected = system ? Matrix4x4.Transpose(a.System()).Mat44<T>()
                              : Matrix4X4.Transpose(a.Silk()).Mat44();

        await Assert.That(transpose).IsEqualTo(Mat44.Transpose(a));
        await Assert.That(transpose).IsEqualTo(expected);
    }
}
