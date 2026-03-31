using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

public abstract class StressSilkQuat<T> : BaseBench
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    private readonly Quaternion<T>[] quats = new Quaternion<T>[Count];

    public StressSilkQuat()
    {
        for (int i = 0; i < quats.Length; i++)
            quats[i] = Quat<T>.Gen(T.CreateTruncating(Random.Shared.Next(10, 100))).Silk();
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
