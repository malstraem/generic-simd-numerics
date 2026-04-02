using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace System.Numerics.Bench;

[SimpleJob(RuntimeMoniker.Net10_0), DisassemblyDiagnoser]
public class StressQuat<T> : BaseBench
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    private readonly Quat<T>[] quats = new Quat<T>[Count];

    public StressQuat()
    {
        for (int i = 0; i < quats.Length; i++)
            quats[i] = Quat<T>.Gen(T.CreateTruncating(Random.Shared.Next(10, 100)));
    }

    //[Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            quats[i] = quats[i] + quats[i + 1];
    }

    //[Benchmark]
    public void Substract()
    {
        for (int i = 0; i < Count - 1; i++)
            quats[i] = quats[i] - quats[i + 1];
    }

    [Benchmark]
    public void Multiply()
    {
        for (int i = 0; i < Count - 1; i++)
            quats[i] = quats[i] * quats[i + 1];
    }
}
