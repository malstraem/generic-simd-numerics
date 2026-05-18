using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(double))]
public class StressVector2D<T> : StressVector2DI<T>
    where T : unmanaged, INumber<T>
{
    [Benchmark]
    public void Length()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = vecs[i].Length;
    }

    [Benchmark]
    public void Distance()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = Vector2D.Distance(vecs[i], vecs[i + 1]);
    }

    [Benchmark]
    public void Normalize()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Vector2D.Normalize(vecs[i]);
    }
}

[GenericTypeArguments(typeof(byte))]
[GenericTypeArguments(typeof(short))]
[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(long))]
public class StressVector2DI<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vector2D<T>[] vecs = new Vector2D<T>[Count],
                                            @out = new Vector2D<T>[Count];

    public StressVector2DI()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = Vec2<T>.Gen(T.One).Silk();
    }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i] + vecs[i + 1];
    }

    [Benchmark]
    public void Subtract()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i] - vecs[i + 1];
    }

    [Benchmark]
    public void Multiply()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i] * vecs[i + 1];
    }

    [Benchmark]
    public void Divide()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i] / vecs[i + 1];
    }

    [Benchmark]
    public void Abs()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Vector2D.Abs(vecs[i]);
    }

    [Benchmark]
    public void Dot()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = Vector2D.Dot(vecs[i], vecs[i + 1]);
    }

    [Benchmark]
    public void LengthSquared()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = vecs[i].LengthSquared;
    }

    [Benchmark]
    public void DistanceSquared()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = Vector2D.DistanceSquared(vecs[i], vecs[i + 1]);
    }
}
