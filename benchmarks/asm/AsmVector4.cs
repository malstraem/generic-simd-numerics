using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[Config(typeof(AsmConfig))]
public class AsmVector4
{
    private static readonly Vector4
        a = Vector4.Gen(1f),
        b = Vector4.Gen(2f),
        vec = Vector4.Gen(3f),
        negative = -vec;

    private static readonly Matrix4x4 mat = Matrix4x4.Gen(1f);

    [Benchmark(Description = "a + b")]
    public Vector4 Add() => a + b;

    [Benchmark(Description = "a - b")]
    public Vector4 Substract() => a - b;

    [Benchmark(Description = "a * b")]
    public Vector4 Multiply() => a * b;

    [Benchmark(Description = "a / b")]
    public Vector4 Divide() => a / b;

    [Benchmark]
    public float Sum() => Vector4.Sum(vec);

    [Benchmark]
    public float Dot() => Vector4.Dot(a, b);

    [Benchmark]
    public float LengthSquared() => vec.LengthSquared();

    [Benchmark]
    public float DistanceSquared() => Vector4.DistanceSquared(a, b);

    [Benchmark]
    public Vector4 Abs() => Vector4.Abs(negative);

    [Benchmark]
    public Vector4 Transform() => Vector4.Transform(vec, mat);
}
