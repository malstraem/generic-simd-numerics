using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[SimpleJob]
public abstract class StressVector4 : BaseBench
{
    private Vector4
        x = Vec4<float>.Gen(5f).System(),
        y = Vec4<float>.Gen(5f).System(),
        vec = Vec4<float>.Gen(5f).System(),
        negative = -Vec4<float>.Gen(5f).System();

    private static readonly Matrix4x4 mat = Mat44<float>.Gen(5f).System();

    [Benchmark]
    public Vector4 Add()
    {
        var add = Vector4.One;

        for (int i = 0; i < Count; i++)
            add += vec;

        return add;
    }

    [Benchmark]
    public Vector4 Substract()
    {
        var sub = Vector4.One;

        for (int i = 0; i < Count; i++)
            sub -= vec;

        return sub;
    }

    [Benchmark]
    public Vector4 Multiply()
    {
        var mul = Vector4.One;

        for (int i = 0; i < Count; i++)
            mul *= y;

        return mul;
    }

    [Benchmark]
    public Vector4 Divide()
    {
        var div = Vector4.One;

        for (int i = 0; i < Count; i++)
            div /= y;

        return div;
    }

    [Benchmark]
    public float Sum()
    {
        float sum = 0f;

        for (int i = 0; i < Count; i++)
            sum = Vector4.Sum(vec);

        return sum;
    }

    [Benchmark]
    public float Dot()
    {
        float dot = 0f;

        for (int i = 0; i < Count; i++)
            dot = Vector4.Dot(x, y);

        return dot;
    }

    [Benchmark]
    public float LengthSquared()
    {
        float len = 0f;

        for (int i = 0; i < Count; i++)
            len = vec.LengthSquared();

        return len;
    }

    [Benchmark]
    public float DistanceSquared()
    {
        float dist = 0f;

        for (int i = 0; i < Count; i++)
            dist = Vector4.DistanceSquared(x, y);

        return dist;
    }

    [Benchmark]
    public float Length()
    {
        float len = 0f;

        for (int i = 0; i < Count; i++)
            len = x.Length();

        return len;
    }

    [Benchmark]
    public float Distance()
    {
        float dist = 0f;

        for (int i = 0; i < Count; i++)
            dist = Vector4.Distance(x, y);

        return dist;
    }

    [Benchmark]
    public Vector4 Normalize()
    {
        var norm = Vector4.One;

        for (int i = 0; i < Count; i++)
            norm = Vector4.Normalize(vec);

        return norm;
    }

    [Benchmark]
    public Vector4 Abs()
    {
        var abs = Vector4.One;

        for (int i = 0; i < Count; i++)
            abs = Vector4.Abs(negative);

        return abs;
    }

    [Benchmark]
    public Vector4 Transform()
    {
        var vec = Vector4.One;

        for (int i = 0; i < Count; i++)
            vec = Vector4.Transform(vec, mat);

        return vec;
    }
}
