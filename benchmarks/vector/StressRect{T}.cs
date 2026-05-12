using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(double))]
public class StressRect<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    private static readonly Rect<T>[] rects = new Rect<T>[Count];

    private static readonly bool[] bools = new bool[Count];

    public StressRect()
    {
        for (int i = 0; i < Count; i++)
            rects[i] = Vec4<T>.Gen(T.One).Rect();
    }

    [Benchmark]
    public void IsIntersect()
    {
        for (int i = 0; i < Count - 1; i++)
            bools[i] = rects[i].IsIntersect(rects[i + 1]);
    }

    [Benchmark]
    public void Contains()
    {
        for (int i = 0; i < Count - 1; i++)
            bools[i] = rects[i].Contains(rects[i + 1]);
    }

    [Benchmark]
    public void Square()
    {
        for (int i = 0; i < Count - 1; i++)
            nums[i] = rects[i].Square();
    }
}
