using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(double))]
public class StressRectangle<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    private static readonly Rectangle<T>[] rects = new Rectangle<T>[Count];

    private static readonly bool[] bools = new bool[Count];

    public StressRectangle()
    {
        for (int i = 0; i < Count; i++)
            rects[i] = Rect<T>.Gen(T.One).Silk();
    }

    [Benchmark]
    public void Contains()
    {
        for (int i = 0; i < Count - 1; i++)
            bools[i] = rects[i].Contains(rects[i + 1]);
    }

    [Benchmark]
    public void Area()
    {
        for (int i = 0; i < Count - 1; i++)
        {
            var rect = rects[i];
            nums[i] = rect.Size.X * rect.Size.Y;
        }
    }
}
