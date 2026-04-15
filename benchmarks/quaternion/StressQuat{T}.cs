using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public class StressQuat<T> : BaseBench<T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    private readonly Quat<T>[] quats = new Quat<T>[Count],
                               @out = new Quat<T>[Count];

    public StressQuat()
    {
        for (int i = 0; i < Count; i++)
            quats[i] = Quat<T>.Gen(T.CreateTruncating(Random.Shared.Next(1, 10)));
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
            nums[i] = quats[i].Dot(quats[i + 1]);
    }
}
