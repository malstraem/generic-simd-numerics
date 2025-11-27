using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace System.Numerics.Bench;

[DisassemblyDiagnoser(syntax: DisassemblySyntax.Att)]
public class AsmVector4
{
    private static readonly Vector4
        x = Vector4.Gen(1f),
        y = Vector4.Gen(2f),
        vec = Vector4.Gen(3f),
        negative = -vec;

    private static readonly Matrix4x4 mat = Matrix4x4.Gen(1f);

    [Benchmark]
    public Vector4 Add() => x + y;

    [Benchmark]
    public Vector4 Substract() => x - y;

    [Benchmark]
    public Vector4 Multiply() => x * y;

    [Benchmark]
    public Vector4 Divide() => x / y;

    [Benchmark]
    public Vector4 Transform() => Vector4.Transform(vec, mat);

    [Benchmark]
    public float Sum() => Vector4.Sum(vec);

    [Benchmark]
    public Vector4 Abs() => Vector4.Abs(negative);

    [Benchmark]
    public float Dot() => Vector4.Dot(x, y);

    [Benchmark]
    public float LengthSquared() => vec.LengthSquared();

    [Benchmark]
    public float DistanceSquared() => Vector4.DistanceSquared(x, y);

    [Benchmark]
    public float Length() => vec.Length();

    [Benchmark]
    public float Distance() => Vector4.Distance(x, y);

    [Benchmark]
    public Vector4 Normalize() => Vector4.Normalize(vec);
}
