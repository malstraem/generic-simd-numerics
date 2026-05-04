using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(int))]
public class StressRect<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    private static readonly Rect<T>[] rects = new Rect<T>[Count];

    public StressRect()
    {
        for (int i = 0; i < Count; i++)
            rects[i] = Vec4<T>.Gen(T.One).Rect();
    }

    [Benchmark]
    public bool IsIntersectNaive()
    {
        bool intersect = false;

        for (int i = 0; i < Count - 1; i++)
            intersect = rects[i].IsIntersectNaive(rects[i + 1]);

        return intersect;
    }

    [Benchmark]
    public bool IsIntersectInvert()
    {
        bool intersect = false;

        for (int i = 0; i < Count - 1; i++)
            intersect = rects[i].IsIntersectVectorizedInvert(rects[i + 1]);

        return intersect;
    }

    [Benchmark]
    public bool IsIntersectSwap()
    {
        bool intersect = false;

        for (int i = 0; i < Count - 1; i++)
            intersect = rects[i].IsIntersectVectorizedSwap(rects[i + 1]);

        return intersect;
    }
}
