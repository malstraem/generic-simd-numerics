using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

public class StressVector3D<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    private static readonly Vector3D<T>[] vecs = new Vector3D<T>[Count],
                                          @out = new Vector3D<T>[Count];

    public StressVector3D()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = Vec3<T>.Gen(T.One).Silk();
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
    public void MultiplyElementWise()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i] * vecs[i + 1];
    }

    [Benchmark]
    public void DivideElementWise()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i] / vecs[i + 1];
    }

    [Benchmark]
    public void Abs()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Vector3D.Abs(vecs[i]);
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
            @out[i] = Vector3D.Normalize(vecs[i]);
    }
}
