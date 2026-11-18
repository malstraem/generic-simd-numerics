using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public class StressQuaternion : BaseBench<float>
{
    private readonly Quaternion[] quats = new Quaternion[Count],
                                  @out = new Quaternion[Count];

    public StressQuaternion()
    {
        for (int i = 0; i < Count; i++)
            quats[i] = Quat<float>.Rand().System();
    }

    [Benchmark]
    public void Multiply()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = quats[i] * quats[i + 1];
    }

    [Benchmark]
    public void Divide()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = quats[i] / quats[i + 1];
    }

    [Benchmark]
    public void Conjugate()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Quaternion.Conjugate(quats[i]);
    }

    [Benchmark]
    public void Inverse()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Quaternion.Inverse(quats[i]);
    }

    [Benchmark]
    public void Lerp()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = Quaternion.Lerp(quats[i], quats[i + 1], 1f);
    }

    [Benchmark]
    public void Slerp()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = Quaternion.Slerp(quats[i], quats[i + 1], 1f);
    }
}
