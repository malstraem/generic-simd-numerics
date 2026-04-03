using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public abstract class Mat44Methods<T> : BaseBench
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    private readonly Quat<T>[] quats = new Quat<T>[Count];

    private readonly Mat44<T>[] mats = new Mat44<T>[Count];

    public Mat44Methods()
    {
        for (int i = 0; i < quats.Length; i++)
            quats[i] = Quat<T>.Gen(T.CreateTruncating(Random.Shared.Next(10, 100)));
    }

    //[Benchmark]
    public void CreateFromQuat()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = Mat44.CreateFromQuat(quats[i]);
    }

    [Benchmark]
    public void Transform()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] *= Mat44.CreateFromQuat(quats[i]);
    }
}
