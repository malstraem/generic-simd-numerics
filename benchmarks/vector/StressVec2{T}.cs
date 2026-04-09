using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public class StressVec2<T> : StressVec2<T, T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>;

public class StressVec2<T, R> : BaseBench<T>
    where T : unmanaged, INumber<T>
    where R : unmanaged, IRootFunctions<R>
{
    private static readonly Vec2<T>[] vecs = new Vec2<T>[Count];

    public StressVec2()
    {
        for (int i = 0; i < vecs.Length; i++)
            vecs[i] = Vec2<T>.Gen(T.CreateTruncating(Random.Shared.Next(1, 10)));
    }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            vecs[i] = vecs[i] + vecs[i + 1];
    }

    [Benchmark]
    public void Subtract()
    {
        for (int i = 0; i < Count - 1; i++)
            vecs[i] = vecs[i] - vecs[i + 1];
    }

    [Benchmark]
    public void ElementMultiply()
    {
        for (int i = 0; i < Count - 1; i++)
            vecs[i] = vecs[i].ElementMultiply(vecs[i + 1]);
    }

    [Benchmark]
    public void ElementDivide()
    {
        for (int i = 0; i < Count - 1; i++)
            vecs[i] = vecs[i].ElementDivide(vecs[i + 1]);
    }

    [Benchmark]
    public void Abs()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = vecs[i].Abs();
    }

    [Benchmark]
    public void Sum()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = vecs[i].Sum();
    }

    [Benchmark]
    public void Dot()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = vecs[i] * vecs[i + 1];
    }

    [Benchmark]
    public void LengthSquared()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = vecs[i].LengthSquared();
    }

    [Benchmark]
    public void DistanceSquared()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = vecs[i].DistanceSquared(vecs[i + 1]);
    }

    [Benchmark]
    public void Length()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = vecs[i].Length<R>();
    }

    [Benchmark]
    public void Distance()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = vecs[i].Distance<R>(vecs[i + 1]);
    }

    [Benchmark]
    public void Normalize()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = vecs[i].Normalize<R>();
    }
}
