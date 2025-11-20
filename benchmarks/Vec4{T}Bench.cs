using Silk.NET.Maths;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;

namespace System.Numerics.Bench;

//[RyuJitX64Job]
//[SimpleJob(RuntimeMoniker.Net10_0)]
[DisassemblyDiagnoser(printInstructionAddresses: true, syntax: DisassemblySyntax.Masm)]
public class Vector4Bench : BaseBench
{
    private const int Count = 100_000;

    private static readonly Vec4<Half>[] halves = new Vec4<Half>[Count];

    private static readonly Vec4<float>[] floats = new Vec4<float>[Count];

    private static readonly Vec4<double>[] doubles = new Vec4<double>[Count];

    private static readonly Vector4[] systemFloats = new Vector4[Count];

    private static readonly Vector4D<double>[] silkDoubles = new Vector4D<double>[Count];

    private static readonly Vector4D<Half>[] silkHalves = new Vector4D<Half>[Count];

    [Benchmark(Description = "Vector4 + Vector4")]
    public Vector4 AddSystemFloats()
    {
        var res = Vector4.One;

        foreach (var vec in systemFloats)
            res += vec;

        return res;
    }

    [Benchmark(Description = "Vec4<float> + Vec4<float>")]
    public Vec4<float> AddGenericFloats() => Add(floats);

    [Benchmark(Description = "Vector4D<double> + Vector4D<double>")]
    public Vector4D<double> AddSilkDoubles()
    {
        var res = Vector4D<double>.One;

        foreach (var vec in silkDoubles)
            res += vec;

        return res;
    }

    [Benchmark(Description = "Vec4<double> + Vec4<double>")]
    public Vec4<double> AddGenericDoubles() => Add(doubles);

    [Benchmark(Description = "Vector4 * Vector4")]
    public Vector4 MultiplySystemFloats()
    {
        var res = Vector4.One;

        foreach (var vec in systemFloats)
            res *= vec;

        return res;
    }

    [Benchmark(Description = "Vec4<float> * Vec4<float>")]
    public Vec4<float> MultiplyGenericFloats() => Multiply(floats);

    [Benchmark(Description = "Vector4D<double> * Vector4D<double>")]
    public Vector4D<double> MultiplySilkDoubles()
    {
        var res = Vector4D<double>.One;

        foreach (var vec in silkDoubles)
            res *= vec;

        return res;
    }

    [Benchmark(Description = "Vec4<double> * Vec4<double>")]
    public Vec4<double> MultiplyGenericDoubles() => Multiply(doubles);

    [Benchmark(Description = "Vector4D<Half> * Vector4D<Half>")]
    public Vector4D<Half> MultiplySilkHalves()
    {
        var res = Vector4D<Half>.One;

        foreach (var vec in silkHalves)
            res *= vec;

        return res;
    }

    [Benchmark(Description = "Vec4<Half> * Vec4<Half>")]
    public Vec4<Half> MultiplyGenericHalves() => Multiply(halves);
}
