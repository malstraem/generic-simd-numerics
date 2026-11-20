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
        var r = Rect<T>.Gen(T.One).Silk();

        for (int i = 0; i < Count; i++)
            rects[i] = r;
    }

    [Benchmark]
    public void Intersects()
    {
        for (int i = 0; i < Count - 1; i++)
        {
            var a = rects[i];
            var b = rects[i + 1];

            bools[i] = a.Contains(b.Origin) || b.Contains(a.Origin);
        }
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
        for (int i = 0; i < Count; i++)
        {
            var rect = rects[i];
            nums[i] = rect.Size.X * rect.Size.Y;
        }
    }
}
