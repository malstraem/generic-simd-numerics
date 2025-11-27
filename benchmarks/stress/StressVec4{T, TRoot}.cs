using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[SimpleJob]
public abstract class StressVec4<T, TRoot> : BaseBench
    where T : unmanaged, INumber<T>
    where TRoot : IRootFunctions<TRoot>
{
    private T number = T.One;

    private static Vec4<T>
        x = Vec4<T>.Gen(T.One),
        y = Vec4<T>.Gen(T.One + T.One),
        vec = Vec4<T>.Gen(T.One + T.One + T.One),
        negative = -vec;

    private static readonly Mat44<T> mat = Mat44<T>.Gen(T.One);

    /*[IterationSetup]
    public void Setup()
    {
        x = Vec4<T>.Gen(T.One);
        y = Vec4<T>.Gen(T.One + T.One);
        vec = Vec4<T>.Gen(T.One + T.One + T.One);
        negative = -vec;
    }*/

    [Benchmark]
    public Vec4<T> Add()
    {
        for (int i = 0; i < Count; i++)
            x += y;

        return x;
    }

    [Benchmark]
    public Vec4<T> Substract()
    {
        for (int i = 0; i < Count; i++)
            x -= y;

        return x;
    }

    [Benchmark]
    public Vec4<T> Multiply()
    {
        for (int i = 0; i < Count; i++)
            x *= y;

        return x;
    }

    [Benchmark]
    public Vec4<T> Divide()
    {
        for (int i = 0; i < Count; i++)
            x /= y;

        return x;
    }

    [Benchmark]
    public T Sum()
    {
        for (int i = 0; i < Count; i++)
            number = vec.Sum();

        return number;
    }

    [Benchmark]
    public T Dot()
    {
        for (int i = 0; i < Count; i++)
            number = x.Dot(y);

        return number;
    }

    [Benchmark]
    public T LengthSquared()
    {
        for (int i = 0; i < Count; i++)
            number = vec.LengthSquared();

        return number;
    }

    [Benchmark]
    public T DistanceSquared()
    {
        for (int i = 0; i < Count; i++)
            number = x.DistanceSquared(y);

        return number;
    }

    [Benchmark]
    public T Length()
    {
        for (int i = 0; i < Count; i++)
            number = x.Length<TRoot>();

        return number;
    }

    [Benchmark]
    public T Distance()
    {
        for (int i = 0; i < Count; i++)
            number = x.Distance<TRoot>(y);

        return number;
    }

    [Benchmark]
    public Vec4<T> Normalize()
    {
        for (int i = 0; i < Count; i++)
            vec = vec.Normalize<TRoot>();

        return vec;
    }

    [Benchmark]
    public Vec4<T> Abs()
    {
        for (int i = 0; i < Count; i++)
            vec = negative.Abs();

        return vec;
    }

    [Benchmark]
    public Vec4<T> Transform()
    {
        for (int i = 0; i < Count; i++)
            vec = vec.Transform(mat);

        return vec;
    }
}
