using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace System.Numerics.Bench;

[SimpleJob(RuntimeMoniker.Net10_0), DisassemblyDiagnoser]
public class StressMat44<T> : BaseBench
    where T : unmanaged, INumber<T>
{
    private readonly Mat44<T>[] mats = new Mat44<T>[Count];

    public StressMat44()
    {
        for (int i = 0; i < mats.Length; i++)
            mats[i] = Mat44<T>.Gen(T.CreateTruncating(Random.Shared.Next(1, 10)));
    }

    //[Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = mats[i] + mats[i + 1];
    }

    //[Benchmark]
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
