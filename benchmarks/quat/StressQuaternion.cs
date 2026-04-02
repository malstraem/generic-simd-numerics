using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace System.Numerics.Bench;

[SimpleJob(RuntimeMoniker.Net10_0), DisassemblyDiagnoser]
public class StressQuaternion : BaseBench
{
    private readonly Quaternion[] quats = new Quaternion[Count];

    public StressQuaternion()
    {
        for (int i = 0; i < quats.Length; i++)
            quats[i] = Quat<float>.Gen(Random.Shared.Next(10, 100)).System();
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
