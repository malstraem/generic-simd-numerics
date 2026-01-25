using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[SimpleJob, DisassemblyDiagnoser]
public abstract class StressVec4<T> : BaseBench
    where T : unmanaged, INumber<T>, IRootFunctions<T>
{
    private static readonly T[] nums = new T[Count];

    private static readonly Vec4<T>[] vecs = new Vec4<T>[Count];

    private static readonly Mat44<T> mat = Mat44<T>.Gen(T.One);

    public StressVec4()
    {
        for (int i = 0; i < vecs.Length; i++)
            vecs[i] = Vec4<T>.Gen(T.CreateTruncating(Random.Shared.Next(10, 100)));
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
            vecs[i] = vecs[i].Abs();
    }

    [Benchmark]
    public void Sum()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = vecs[i].Sum();
    }

    [Benchmark]
    public void Dot()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = vecs[i].Dot(vecs[i + 1]);
    }

    [Benchmark]
    public void LengthSquared()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = vecs[i].LengthSquared();
    }

    [Benchmark]
    public void DistanceSquared()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = vecs[i].DistanceSquared(vecs[i + 1]);
    }

    [Benchmark]
    public void Length()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = vecs[i].Length();
    }

    [Benchmark]
    public void Distance()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = vecs[i].Distance(vecs[i + 1]);
    }

    [Benchmark]
    public void Normalize()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = vecs[i].Normalize();
    }

    [Benchmark]
    public void Transform()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = vecs[i].Transform(mat);
    }
}
