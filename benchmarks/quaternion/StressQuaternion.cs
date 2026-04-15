using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public class StressQuaternion : BaseBench<float>
{
    private readonly Quaternion[] quats = new Quaternion[Count],
                                  @out = new Quaternion[Count];

    public StressQuaternion()
    {
        for (int i = 0; i < Count; i++)
            quats[i] = Quat<float>.Gen(Random.Shared.Next(1, 10)).System();
    }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = quats[i] + quats[i + 1];
    }

    [Benchmark]
    public void Substract()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = quats[i] - quats[i + 1];
    }

    [Benchmark]
    public void Multiply()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = quats[i] * quats[i + 1];
    }

    [Benchmark]
    public void Dot()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = Quaternion.Dot(quats[i], quats[i + 1]);
    }
}
