using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(double))]
public class StressQuat<T> : BaseBench<T>
    where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    private readonly Quat<T>[] quats = new Quat<T>[Count],
                               @out = new Quat<T>[Count];

    public StressQuat()
    {
        // force spherical slerp way
        var s1 = T.CreateTruncating(0.1);
        var s2 = T.CreateTruncating(0.5);
        var q1 = new Quat<T>(s1, s1, s1, s1);
        var q2 = new Quat<T>(s2, s2, s2, s2);

        for (int i = 0; i < Count - 1; i += 2)
        {
            quats[i] = q1;
            quats[i + 1] = q2;
        }
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

    [Benchmark]
    public void Inverse()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = quats[i].Inverse();
    }

    [Benchmark]
    public void Lerp()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = quats[i].Lerp(quats[i + 1], T.One);
    }

    [Benchmark]
    public void Slerp()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = quats[i].Slerp(quats[i + 1], T.One);
    }
}
