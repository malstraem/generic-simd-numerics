using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(double))]
public class StressQuaternion<T> : BaseBench<T>
    where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    private readonly Quaternion<T>[] quats = new Quaternion<T>[Count],
                                     @out = new Quaternion<T>[Count];

    public StressQuaternion()
    {
        // force spherical slerp way
        var s1 = T.CreateTruncating(0.1);
        var s2 = T.CreateTruncating(0.5);
        var q1 = new Quat<T>(s1, s1, s1, s1).Silk();
        var q2 = new Quat<T>(s2, s2, s2, s2).Silk();

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
            @out[i] = Quaternion<T>.Conjugate(quats[i]);
    }

    [Benchmark]
    public void Inverse()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Quaternion<T>.Inverse(quats[i]);
    }

    [Benchmark]
    public void Lerp()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = Quaternion<T>.Lerp(quats[i], quats[i + 1], T.One);
    }

    [Benchmark]
    public void Slerp()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = Quaternion<T>.Slerp(quats[i], quats[i + 1], T.One);
    }
}
