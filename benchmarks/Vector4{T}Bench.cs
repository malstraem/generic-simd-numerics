using System.Numerics;

using Silk.NET.Maths;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace GenericNumerics.Bench;

//[SimpleJob(RuntimeMoniker.Net90)]
[SimpleJob(RuntimeMoniker.Net10_0)]
public class Vector4Bench
{
    private const int Count = 50_000;

    private static readonly Vector4[] floatSystemNumerics = new Vector4[Count];

    private static readonly Vec4<float>[] floats = new Vec4<float>[Count];

    private static readonly Vector4D<double>[] doubleSilkNetMaths = new Vector4D<double>[Count];

    private static readonly Vec4<double>[] doubles = new Vec4<double>[Count];

    private static readonly Vec4<FooInteger5>[] fooInteger5 = new Vec4<FooInteger5>[Count];

    private static T Multiply<T>(T[] vectors) where T : IVector<T>, IMultiplyOperators<T, T, T>
    {
        var res = T.One;

        foreach (var vec in vectors)
            res *= vec;

        return res;
    }

    [Benchmark(Description = "System.Numerics.Vector4 (float)")]
    public Vector4 SystemNumerics()
    {
        var res = Vector4.One;

        foreach (var vec in floatSystemNumerics)
            res *= vec;

        return res;
    }

    [Benchmark(Description = "Vec4<float>")]
    public Vec4<float> GenericFloats() => Multiply(floats);

    [Benchmark(Description = "Silk.NET.Maths.Vector4D<double>")]
    public Vector4D<double> SilkDoubles()
    {
        var res = Vector4D<double>.One;

        foreach (var vec in doubleSilkNetMaths)
            res *= vec;

        return res;
    }

    [Benchmark(Description = "Vec4<double>")]
    public Vec4<double> GenericDoubles() => Multiply(doubles);

    //[Benchmark(Description = "Vec4<FooFiveByteInteger>")]
    public Vec4<FooInteger5> GenericFiveBytes() => Multiply(fooInteger5);
}
