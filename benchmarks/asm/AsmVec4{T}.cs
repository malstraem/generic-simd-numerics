using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;

namespace System.Numerics.Bench;

public class AsmConfig : ManualConfig
{
    public AsmConfig() => AddJob().AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig
    (
        maxDepth: 5,
        syntax: DisassemblySyntax.Intel,
        formatterOptions: Iced.Intel.FormatterOptions.CreateIntel()
    )));
}

[DisassemblyDiagnoser(maxDepth: 10), RyuJitX64Job]
public class AsmVec4<T, TRoot> : BaseBench
    where T : unmanaged, INumber<T>
    where TRoot : IRootFunctions<TRoot>
{
    private static readonly Vec4<T>
        a = Vec4<T>.Gen(T.One),
        b = Vec4<T>.Gen(T.One + T.One),
        vec = Vec4<T>.Gen(T.One + T.One + T.One),
        negative = -vec;

    private static readonly Mat44<T> mat = Mat44<T>.Gen(T.One);

    [Benchmark(Description = "a + b")]
    public Vec4<T> Add() => a + b;

    [Benchmark(Description = "a - b")]
    public Vec4<T> Substract() => a - b;

    [Benchmark(Description = "a * b")]
    public Vec4<T> Multiply() => a * b;

    [Benchmark(Description = "a / b")]
    public Vec4<T> Divide() => a / b;

    [Benchmark]
    public T Sum() => vec.Sum();

    [Benchmark]
    public T Dot() => a.Dot(b);

    [Benchmark]
    public T LengthSquared() => vec.LengthSquared();

    [Benchmark]
    public T DistanceSquared() => a.DistanceSquared(b);

    [Benchmark]
    public T Length() => vec.Length<TRoot>();

    [Benchmark]
    public T Distance() => a.Distance<TRoot>(b);

    [Benchmark]
    public Vec4<T> Abs() => negative.Abs();

    [Benchmark]
    public Vec4<T> Transform() => vec.Transform(mat);
}
