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
            quats[i] = Quat<T>.Rand();
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
            @out[i] = quats[i].Conjugate();
    }
}
