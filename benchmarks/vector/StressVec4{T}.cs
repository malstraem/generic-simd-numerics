using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(double))]
public class StressVec4<T> : StressVec4<T, T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>;

[GenericTypeArguments(typeof(byte), typeof(float))]
[GenericTypeArguments(typeof(short), typeof(float))]
[GenericTypeArguments(typeof(int), typeof(float))]
[GenericTypeArguments(typeof(long), typeof(double))]
public class StressVec4<T, R> : BaseBench<T>
    where T : unmanaged, INumber<T>
    where R : unmanaged, INumber<R>, IRootFunctions<R>
{
    private static readonly Vec4<T>[] vecs = new Vec4<T>[Count],
                                      @out = new Vec4<T>[Count];

    private static readonly Mat44<T> m = Mat44<T>.Gen(T.One);

    public StressVec4()
    {
        for (int i = 0; i < Count; i++)
            vecs[i] = Vec4<T>.Gen(T.One);
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
    public void MultiplyElementWise()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i].MultiplyWise(vecs[i + 1]);
    }

    [Benchmark]
    public void DivideElementWise()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = vecs[i].DivideWise(vecs[i + 1]);
    }

    [Benchmark]
    public void Abs()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = vecs[i].Abs();
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
            @out[i] = vecs[i].Normalize<R>();
    }

    [Benchmark]
    public void Transform()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = vecs[i].Transform(m);
    }
}
