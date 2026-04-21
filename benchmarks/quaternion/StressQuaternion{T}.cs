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
            quats[i] = Quat<T>.Rand().Silk();
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
            @out[i] = Quaternion<T>.Conjugate(quats[i]);
    }
}
