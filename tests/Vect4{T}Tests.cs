using Silk.NET.Maths;

namespace System.Numerics.Tests;

#if EXPOSE_ROOT
[InheritsTests]
public class Vec4IntFloatExposedRootMethod : Vec4Tests<int, float>;

[InheritsTests]
public class Vec4IntDoubleExposedRootMethod : Vec4Tests<int, double>;

[InheritsTests]
public class Vec4LongDoubleExposedRootMethod : Vec4Tests<long, double>;

[InheritsTests]
public class Vec4FloatExposedRootMethod : Vec4Tests<float>;

[InheritsTests]
public class Vec4DoubleExposedRootMethod : Vec4Tests<double>;

[InheritsTests]
public abstract class Vec4Tests<T> : Vec4Tests<T, T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>
{
    [Test, DisplayName("Length (sealed variant)")]
    public async Task LengthSealedVariant()
    {
        var vec = Vec4<T>.Gen(T.One);

        var length = vec.Length();

        var expected = ((Vector4D<T>)vec).Length;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4<T>.Length(vec));
    }

    [Test, DisplayName("Distance (sealed variant)")]
    public async Task DistanceSealedVariant()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var distance = a.Distance(b);

        var expected = Vector4D.Distance((Vector4D<T>)a, (Vector4D<T>)b);

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4<T>.Distance(a, b));
    }
}

public abstract class Vec4Tests<T, TRoot>
    where T : unmanaged, INumber<T>
    where TRoot : IRootFunctions<TRoot>
#else
[InheritsTests]
public class Vec4Half : Vec4Tests<Half>;

[InheritsTests]
public class Vec4Float : Vec4Tests<float>;

[InheritsTests]
public class Vec4Double : Vec4Tests<double>;

public abstract class Vec4Tests<T>
    where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, IFormattable, IEquatable<T>, IComparable<T>
#endif
{
    [Test, DisplayName("a + b")]
    public async Task Add()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var add = a + b;

        Vec4<T> expected = (Vector4D<T>)a + (Vector4D<T>)b;

        await Assert.That(add).IsEqualTo(expected);
        await Assert.That(add).IsEqualTo(Vec4<T>.Add(a, b));
    }

    [Test, DisplayName("a - b")]
    public async Task Substract()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var sub = a - b;

        Vec4<T> expected = (Vector4D<T>)a - (Vector4D<T>)b;

        await Assert.That(sub).IsEqualTo(expected);
        await Assert.That(sub).IsEqualTo(Vec4<T>.Subtract(a, b));
    }

    [Test, DisplayName("a * b")]
    public async Task Multiply()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var mul = a * b;

        Vec4<T> expected = (Vector4D<T>)a * (Vector4D<T>)b;

        await Assert.That(mul).IsEqualTo(expected);
        await Assert.That(mul).IsEqualTo(Vec4<T>.Multiply(a, b));
    }

    [Test, DisplayName("a / b")]
    public async Task Divide()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var div = a / b;

        Vec4<T> expected = (Vector4D<T>)a / (Vector4D<T>)b;

        await Assert.That(div).IsEqualTo(expected);
        await Assert.That(div).IsEqualTo(Vec4<T>.Divide(a, b));
    }

    [Test]
    public async Task LengthSquared()
    {
        var vec = Vec4<T>.Gen(T.One);

        var length = vec.LengthSquared();

        var expected = ((Vector4D<T>)vec).LengthSquared;

        await Assert.That(length).IsEqualTo(expected);
        await Assert.That(length).IsEqualTo(Vec4<T>.LengthSquared(vec));
    }

    [Test]
    public async Task DistanceSquared()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var distance = a.DistanceSquared(b);

        var expected = Vector4D.DistanceSquared((Vector4D<T>)a, (Vector4D<T>)b);

        await Assert.That(distance).IsEqualTo(expected);
        await Assert.That(distance).IsEqualTo(Vec4<T>.DistanceSquared(a, b));
    }

    [Test]
    public async Task Length()
    {
        var vec = Vec4<T>.Gen(T.One);

        var expected = ((Vector4D<T>)vec).Length;
#if EXPOSE_ROOT
        var length = vec.Length<TRoot>();
        await Assert.That(length).IsEqualTo(Vec4<T>.Length<TRoot>(vec));
#else
        var length = vec.Length();
        await Assert.That(length).IsEqualTo(Vec4<T>.Length(vec));
#endif
        await Assert.That(length).IsEqualTo(expected);
    }

    [Test]
    public async Task Distance()
    {
        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var expected = Vector4D.Distance((Vector4D<T>)a, (Vector4D<T>)b);
#if EXPOSE_ROOT
        var distance = a.Distance<TRoot>(b);
        await Assert.That(distance).IsEqualTo(Vec4<T>.Distance<TRoot>(a, b));
#else
        var distance = a.Distance(b);
        await Assert.That(distance).IsEqualTo(Vec4<T>.Distance(a, b));
#endif
        await Assert.That(distance).IsEqualTo(expected);
    }

    [Test]
    public async Task Normalize()
    {
        var vec = Vec4<T>.Gen(T.One + T.One);

        var expected = Vector4D.Normalize((Vector4D<T>)vec);
#if EXPOSE_ROOT
        var normal = vec.Normalize<TRoot>();
        await Assert.That(normal).IsEqualTo(Vec4<T>.Normalize<TRoot>(vec));
#else
        var normal = vec.Normalize();
        await Assert.That(normal).IsEqualTo(Vec4<T>.Normalize(vec));
#endif
        await Assert.That(normal).IsEqualTo(expected);
    }

    [Test]
    public async Task SquareRoot()
    {
        var vec = Vec4<T>.Gen(T.One + T.One);

        var expected = Vector4D.SquareRoot((Vector4D<T>)vec);
#if EXPOSE_ROOT
        var root = vec.SquareRoot<TRoot>();
        await Assert.That(root).IsEqualTo(Vec4<T>.SquareRoot<TRoot>(vec));
#else
        var root = vec.SquareRoot();
        await Assert.That(root).IsEqualTo(Vec4<T>.SquareRoot(vec));
#endif
        await Assert.That(root).IsEqualTo(expected);
    }

    [Test]
    public async Task Lerp()
    {
        var amount = T.One + T.One + T.One;

        var a = Vec4<T>.Gen(T.One);
        var b = Vec4<T>.Gen(T.One + T.One);

        var lerp = a.Lerp(b, amount);

        Vec4<T> expected = Vector4D.Lerp((Vector4D<T>)a, (Vector4D<T>)b, amount);

        await Assert.That(lerp).IsEqualTo(expected);
        await Assert.That(lerp).IsEqualTo(Vec4<T>.Lerp(a, b, amount));
    }
}
