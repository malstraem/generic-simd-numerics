using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

[SimpleJob]
public abstract class StressVector4D<T> : BaseBench
    where T : unmanaged, INumber<T>
{
    private T number = T.One;

    private static Vector4D<T>
        x = Vec4<T>.Gen(T.One).Silk(),
        y = Vec4<T>.Gen(T.One + T.One).Silk(),
        vec = Vec4<T>.Gen(T.One + T.One + T.One).Silk(),
        negative = -vec;

    private static readonly Matrix4X4<T> mat = Mat44<T>.Gen(T.One).Silk();

    /*[IterationSetup]
    public void Setup()
    {
        x = Vec4<T>.Gen(T.One);
        y = Vec4<T>.Gen(T.One + T.One);
        vec = Vec4<T>.Gen(T.One + T.One + T.One);
        negative = -vec;
    }*/

    [Benchmark]
    public Vector4D<T> Add()
    {
        for (int i = 0; i < Count; i++)
            x += y;

        return x;
    }

    [Benchmark]
    public Vector4D<T> Substract()
    {
        for (int i = 0; i < Count; i++)
            x -= y;

        return x;
    }

    [Benchmark]
    public Vector4D<T> Multiply()
    {
        for (int i = 0; i < Count; i++)
            x *= y;

        return x;
    }

    [Benchmark]
    public Vector4D<T> Divide()
    {
        for (int i = 0; i < Count; i++)
            x /= y;

        return x;
    }

    [Benchmark]
    public T Dot()
    {
        for (int i = 0; i < Count; i++)
            number = Vector4D.Dot(x, y);

        return number;
    }

    [Benchmark]
    public T LengthSquared()
    {
        for (int i = 0; i < Count; i++)
            number = vec.LengthSquared;

        return number;
    }

    [Benchmark]
    public T DistanceSquared()
    {
        for (int i = 0; i < Count; i++)
            number = Vector4D.DistanceSquared(x, y);

        return number;
    }

    [Benchmark]
    public T Length()
    {
        for (int i = 0; i < Count; i++)
            number = x.Length;

        return number;
    }

    [Benchmark]
    public T Distance()
    {
        for (int i = 0; i < Count; i++)
            number = Vector4D.Distance(x, y);

        return number;
    }

    [Benchmark]
    public Vector4D<T> Normalize()
    {
        for (int i = 0; i < Count; i++)
            vec = Vector4D.Normalize(vec);

        return vec;
    }

    [Benchmark]
    public Vector4D<T> Abs()
    {
        for (int i = 0; i < Count; i++)
            vec = Vector4D.Abs(negative);

        return vec;
    }

    [Benchmark]
    public Vector4D<T> Transform()
    {
        for (int i = 0; i < Count; i++)
            vec = Vector4D.Transform(vec, mat);

        return vec;
    }
}
