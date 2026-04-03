using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

[SimpleJob(RuntimeMoniker.Net10_0), DisassemblyDiagnoser]
public class StressVector3D<T> : BaseBench
    where T : unmanaged, INumber<T>
{
    private static readonly T[] nums = new T[Count];

    private static readonly Vector3D<T>[] vecs = new Vector3D<T>[Count];

    public StressVector3D()
    {
        for (int i = 0; i < vecs.Length; i++)
            vecs[i] = Vec3<T>.Gen(T.CreateTruncating(Random.Shared.Next(10, 100))).Silk();
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

    [Benchmark]
    public void Abs()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = Vector3D.Abs(vecs[i]);
    }

    [Benchmark]
    public void Dot()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = Vector3D.Dot(vecs[i], vecs[i + 1]);
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
            nums[i] = Vector3D.DistanceSquared(vecs[i], vecs[i + 1]);
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
            nums[i] = Vector3D.Distance(vecs[i], vecs[i + 1]);
    }

    [Benchmark]
    public void Normalize()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = Vector3D.Normalize(vecs[i]);
    }
}
