using System.Numerics;

using Silk.NET.Maths;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace GenericNumerics.Bench;

//[SimpleJob(RuntimeMoniker.Net90)]
[SimpleJob(RuntimeMoniker.Net10_0)]
public class MatrixMultiplication
{
    private const int Count = 50_000;

    private const double Coeff = 200;

    private static Matrix4x4[] numericsFloats = new Matrix4x4[Count];

    private static Mat44<float>[] floats = new Mat44<float>[Count];

    private static Matrix4X4<double>[] doublesSilkNet = new Matrix4X4<double>[Count];

    private static Mat44<double>[] doubles = new Mat44<double>[Count];

    private static Mat44<FooInteger5>[] fiveBytes = new Mat44<FooInteger5>[Count];

    [Benchmark(Description = "Silk.NET.Maths.Matrix4X4<double>")]
    public Matrix4X4<double> SilkDoubles()
    {
        var res = Matrix4X4<double>.Identity;

        foreach (var mat in doublesSilkNet)
            res *= mat;

        return res;
    }

    [Benchmark(Description = "Mat44<double>")]
    public Mat44<double> GenericDoubles()
    {
        var res = Mat44<double>.Identity;

        foreach (var mat in doubles)
            res *= mat;

        return res;
    }

    [Benchmark(Description = "System.Numerics.Matrix4x4 (float)")]
    public Matrix4x4 SystemNumerics()
    {
        var res = Matrix4x4.Identity;

        foreach (var mat in numericsFloats)
            res *= mat;

        return res;
    }

    [Benchmark(Description = "Mat44<float>")]
    public Mat44<float> GenericFloats()
    {
        var res = Mat44<float>.Identity;

        foreach (var mat in floats)
            res *= mat;

        return res;
    }

    //[Benchmark(Description = "Proposal Matrix44<FooFiveByteInteger>")]
    public Mat44<FooInteger5> GenericFiveBytes()
    {
        var res = Mat44<FooInteger5>.Identity;

        foreach (var mat in fiveBytes)
            res *= mat;

        return res;
    }
}
