using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(double))]
public class StressVec3<T> : StressSignedVec3<T>
    where T : unmanaged, INumber<T>, ISignedNumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
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

    [Benchmark]
    public void Sin()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = vecs[i].Sin();
    }

    [Benchmark]
    public void Cos()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = vecs[i].Cos();
    }
}

[GenericTypeArguments(typeof(byte))]
[GenericTypeArguments(typeof(short))]
[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(long))]
public class StressVec3I<T> : BaseStressVec3<T>
    where T : unmanaged, INumber<T>;

public abstract class StressSignedVec3<T> : BaseStressVec3<T>
    where T : unmanaged, INumber<T>, ISignedNumber<T>
{
    [Benchmark]
    public void Abs()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = vecs[i].Abs();
    }
}

public abstract class BaseStressVec3<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vec3<T>[] vecs = new Vec3<T>[Count],
                                        @out = new Vec3<T>[Count];

    public BaseStressVec3()
    {
        var v = Vec3<T>.Gen(T.One);

        for (int i = 0; i < Count; i++)
            vecs[i] = v;
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
