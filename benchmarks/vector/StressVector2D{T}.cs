using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

[SimpleJob(RuntimeMoniker.Net10_0), DisassemblyDiagnoser]
public class StressVector2D<T> : BaseBench
    where T : unmanaged, INumber<T>
{
    private static readonly T[] nums = new T[Count];

    private static readonly Vector2D<T>[] vecs = new Vector2D<T>[Count];

    public StressVector2D()
    {
        for (int i = 0; i < vecs.Length; i++)
            vecs[i] = Vec2<T>.Gen(T.CreateTruncating(Random.Shared.Next(1, 10))).Silk();
    }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            vecs[i] = vecs[i] + vecs[i + 1];
    }

    [Benchmark]
    public void Substract()
    {
        for (int i = 0; i < Count - 1; i++)
            vecs[i] = vecs[i] - vecs[i + 1];
    }

    [Benchmark]
    public void Multiply()
    {
        for (int i = 0; i < Count - 1; i++)
            vecs[i] = vecs[i] * vecs[i + 1];
    }

    [Benchmark]
    public void Divide()
    {
        for (int i = 0; i < Count - 1; i++)
            vecs[i] = vecs[i] / vecs[i + 1];
    }

    /*[Benchmark]
    public void Abs()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = Vector2D.Abs(vecs[i]);
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
            vecs[i] = Vector2D.Normalize(vecs[i]);
    }*/
}
