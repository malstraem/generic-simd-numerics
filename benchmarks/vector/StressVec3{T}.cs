using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(double))]
public class StressVec3<T> : StressBaseVec3<T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>
{
    [Benchmark]
    public void Length()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = vecs[i].Length();
    }

    [Benchmark]
    public void Distance()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = vecs[i].Distance(vecs[i + 1]);
    }

    [Benchmark]
    public void Normalize()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = vecs[i].Normalize();
    }
}

[GenericTypeArguments(typeof(byte))]
[GenericTypeArguments(typeof(short))]
[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(long))]
public class StressBaseVec3<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vec3<T>[] vecs = new Vec3<T>[Count],
                                        @out = new Vec3<T>[Count];

    public StressBaseVec3()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = Vec3<T>.Gen(T.One);
    }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i] + vecs[i + 1];
    }

    [Benchmark]
    public void Subtract()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i] - vecs[i + 1];
    }

    [Benchmark]
    public void Multiply()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i] * vecs[i + 1];
    }

    [Benchmark]
    public void Divide()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i] / vecs[i + 1];
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
            nums[i] = vecs[i].Dot(vecs[i + 1]);
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
}
