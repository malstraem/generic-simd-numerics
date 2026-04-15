using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

public class StressQuaternion<T> : BaseBench<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    private readonly Quaternion<T>[] quats = new Quaternion<T>[Count],
                                     @out = new Quaternion<T>[Count];

    public StressQuaternion()
    {
        for (int i = 0; i < Count; i++)
            quats[i] = Quat<T>.Gen(T.CreateTruncating(Random.Shared.Next(10, 100))).Silk();
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
            nums[i] = Quaternion<T>.Dot(quats[i], quats[i + 1]);
    }
}
