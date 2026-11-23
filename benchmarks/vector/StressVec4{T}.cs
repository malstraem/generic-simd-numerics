using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(int), typeof(float))]
[GenericTypeArguments(typeof(int), typeof(double))]
[GenericTypeArguments(typeof(float), typeof(double))]
public class StressConversionVec4<T1, T2> : BaseBench<T1>
    where T1 : unmanaged, INumber<T1>
    where T2 : unmanaged, INumber<T2>
{
    private readonly Vec4<T1>[] vecs = new Vec4<T1>[Count];

    private readonly Vec4<T2>[] converted = new Vec4<T2>[Count];

    public StressConversionVec4()
    {
        var t1 = Vec4<T1>.Gen(T1.One);
        var t2 = t1.As<T2>();

        for (int i = 0; i < Count; i++)
        {
            vecs[i] = t1;
            converted[i] = t2;
        }
    }

    [Benchmark]
    public void Convert()
    {
        for (int i = 0; i < Count; i++)
            converted[i] = vecs[i].As<T2>();
    }

    [Benchmark]
    public void Back()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = converted[i].As<T1>();
    }
}

[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(double))]
public class StressVec4<T> : StressSignedVec4<T>
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
public class StressVec4I<T> : BaseStressVec4<T>
    where T : unmanaged, INumber<T>;

public abstract class StressSignedVec4<T> : BaseStressVec4<T>
    where T : unmanaged, INumber<T>, ISignedNumber<T>
{
    [Benchmark]
    public void Abs()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = vecs[i].Abs();
    }
}

public abstract class BaseStressVec4<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    protected static readonly Vec4<T>[] vecs = new Vec4<T>[Count],
                                        @out = new Vec4<T>[Count];

    private static readonly Mat44<T> m = Mat44<T>.Gen(T.One);

    public BaseStressVec4()
    {
        var v = Vec4<T>.Gen(T.One);

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

    [Benchmark]
    public void Transform()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = vecs[i].Transform(m);
    }
}
