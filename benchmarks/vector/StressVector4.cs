using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace System.Numerics.Bench;

[SimpleJob(RuntimeMoniker.Net10_0), DisassemblyDiagnoser]
public class StressVector4 : BaseBench
{
    private static readonly float[] nums = new float[Count];

    private static readonly Vector4[] vecs = new Vector4[Count];

    private static readonly Matrix4x4 mat = Mat44<float>.Gen(1f).System();

    public StressVector4()
    {
        for (int i = 0; i < vecs.Length; i++)
            vecs[i] = Vec4<float>.Gen(Random.Shared.Next(10, 100)).System();
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
            vecs[i] = Vector4.Abs(vecs[i]);
    }

    [Benchmark]
    public void Sum()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = Vector4.Sum(vecs[i]);
    }

    [Benchmark]
    public void Dot()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = Vector4.Dot(vecs[i], vecs[i + 1]);
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
            nums[i] = Vector4.DistanceSquared(vecs[i], vecs[i + 1]);
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
            nums[i] = Vector4.Distance(vecs[i], vecs[i + 1]);
    }

    [Benchmark]
    public void Normalize()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = Vector4.Normalize(vecs[i]);
    }

    [Benchmark]
    public void Transform()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = Vector4.Transform(vecs[i], mat);
    }
}
