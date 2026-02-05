using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[SimpleJob, DisassemblyDiagnoser]
public class StressMatrix4x4 : BaseBench
{
    private static readonly Matrix4x4[] mats = new Matrix4x4[Count];

    public StressMatrix4x4()
    {
        for (int i = 0; i < mats.Length; i++)
            mats[i] = Mat44<float>.Gen(Random.Shared.Next(10, 100)).System();
    }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = mats[i] + mats[i + 1];
    }

    [Benchmark]
    public void Substract()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = mats[i] - mats[i + 1];
    }

    [Benchmark]
    public void Multiply()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = mats[i] * mats[i + 1];
    }
}
