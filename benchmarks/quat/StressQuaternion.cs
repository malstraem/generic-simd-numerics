using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public class StressQuaternion : BaseBench
{
    private readonly Quaternion[] quats = new Quaternion[Count];

    public StressQuaternion()
    {
        for (int i = 0; i < quats.Length; i++)
            quats[i] = Quaternion.Gen(Random.Shared.Next(10, 100));
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
