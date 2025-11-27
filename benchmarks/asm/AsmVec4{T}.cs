using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public abstract class AsmVec4<T, TRoot> : BaseBench
    where T : unmanaged, INumber<T>
    where TRoot : IRootFunctions<TRoot>
{
    private static readonly Vec4<T>
        x = Vec4<T>.Gen(T.One),
        y = Vec4<T>.Gen(T.One + T.One),
        vec = Vec4<T>.Gen(T.One + T.One + T.One),
        negative = -vec;

    private static readonly Mat44<T> mat = Mat44<T>.Gen(T.One);

    [Benchmark]
    public Vec4<T> Add() => x + y;

    [Benchmark]
    public Vec4<T> Substract() => x - y;

    /*[Benchmark]
    public Vec4<T> Multiply() => x * y;

    [Benchmark]
    public Vec4<T> Divide() => x / y;

    [Benchmark]
    public T Sum() => vec.Sum();

    [Benchmark]
    public T Dot() => x.Dot(y);

    [Benchmark]
    public T LengthSquared() => vec.LengthSquared();

    [Benchmark]
    public T DistanceSquared() => x.DistanceSquared(y);

    [Benchmark]
    public T Length() => vec.Length<TRoot>();

    [Benchmark]
    public T Distance() => x.Distance<TRoot>(y);

    [Benchmark]
    public Vec4<T> Normalize() => vec.Normalize<TRoot>();

    [Benchmark]
    public Vec4<T> Abs() => negative.Abs();

    [Benchmark]
    public Vec4<T> Transform() => vec.Transform(mat);*/
}
