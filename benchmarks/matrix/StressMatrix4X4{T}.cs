using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

public class StressMatrix4X4<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    private readonly Matrix4X4<T>[] mats = new Matrix4X4<T>[Count];

    public StressMatrix4X4()
    {
        for (int i = 0; i < mats.Length; i++)
            mats[i] = Mat44<T>.Gen(T.CreateTruncating(Random.Shared.Next(1, 10))).Silk();
    }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = mats[i] + mats[i + 1];
    }

    [Benchmark]
    public void Substract()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = mats[i] - mats[i + 1];
    }

    [Benchmark]
    public void Multiply()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = mats[i] * mats[i + 1];
    }
}
