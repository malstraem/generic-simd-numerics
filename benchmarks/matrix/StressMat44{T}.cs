using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(int), typeof(float))]
[GenericTypeArguments(typeof(int), typeof(double))]
[GenericTypeArguments(typeof(float), typeof(double))]
public class StressConversionMat44<T1, T2> : BaseBench<T1>
    where T1 : unmanaged, INumber<T1>
    where T2 : unmanaged, INumber<T2>
{
    private readonly Mat44<T1>[] mats = new Mat44<T1>[Count];

    private readonly Mat44<T2>[] converted = new Mat44<T2>[Count];

    public StressConversionMat44()
    {
        var t1 = Mat44<T1>.Gen(T1.One);
        var t2 = t1.As<T2>();

        for (int i = 0; i < Count; i++)
        {
            mats[i] = t1;
            converted[i] = t2;
        }
    }

    [Benchmark]
    public void Convert()
    {
        for (int i = 0; i < Count; i++)
            converted[i] = mats[i].As<T2>();
    }

    [Benchmark]
    public void Back()
    {
        for (int i = 0; i < Count; i++)
            mats[i] = converted[i].As<T1>();
    }
}

[GenericTypeArguments(typeof(float))]
//[GenericTypeArguments(typeof(double))]
public class StressMat44WithQuat<T> : BaseStressMat44<T>
    where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    private readonly Quat<T>[] quats = new Quat<T>[Count];

    private readonly Vec3<T>[] scales = new Vec3<T>[Count],
                               positions = new Vec3<T>[Count];

    private readonly Mat44<T>[] inverts = new Mat44<T>[Count];

    public StressMat44WithQuat()
    {
        var q = Quat<T>.Rand();
        var v = Vec3<T>.Gen(T.One);
#pragma warning disable format
        // determinant > eps
        Mat44<T> invert = new(
            T.CreateTruncating(0.5),  T.CreateTruncating(-0.1), T.CreateTruncating(0.6),  T.Zero,
            T.CreateTruncating(0.4),  T.CreateTruncating(0.8),  T.CreateTruncating(-0.2), T.Zero,
            T.CreateTruncating(-0.5), T.CreateTruncating(0.4),  T.CreateTruncating(0.3),  T.Zero,
            T.Zero,                   T.Zero,                   T.Zero,                   T.CreateTruncating(0.7));
#pragma warning restore format
        for (int i = 0; i < Count; i++)
        {
            quats[i] = q;
            scales[i] = v;
            positions[i] = v;
            inverts[i] = invert;
        }
    }

    //[Benchmark]
    //public bool EqualEpsilon()
    //{
    //    bool equal = false;

    //    for (int i = 0; i < Count - 1; i++)
    //        equal = Mat44.Equal(mats[i], mats[i + 1], T.CreateTruncating(0.1));

    //    return equal;
    //}

    [Benchmark]
    public void Invert()
    {
        for (int i = 0; i < Count; i++)
            //_ = mats[i].TryInvert(out @out[i]);
            _ = Mat44.TryInvert(mats[i], out @out[i]);
    }

    //[Benchmark]
    //public void Rotation()
    //{
    //    for (int i = 0; i < Count; i++)
    //        @out[i] = Mat44.Rotation(quats[i]);
    //}

    //[Benchmark]
    //public void Transform()
    //{
    //    for (int i = 0; i < Count; i++)
    //        @out[i] = Mat44.Rotate(mats[i], quats[i]);
    //}

    //[Benchmark]
    //public void Affine()
    //{
    //    for (int i = 0; i < Count; i++)
    //        @out[i] = Mat44.Affine(quats[i], scales[i], positions[i]);
    //}
}

[GenericTypeArguments(typeof(byte))]
[GenericTypeArguments(typeof(short))]
[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(long))]
public class StressMat44<T> : BaseStressMat44<T>
    where T : unmanaged, INumber<T>;

public abstract class BaseStressMat44<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    protected readonly Mat44<T>[] mats = new Mat44<T>[Count],
                                  @out = new Mat44<T>[Count];

    public BaseStressMat44()
    {
        var m = Mat44<T>.Gen(T.One);

        for (int i = 0; i < Count; i++)
            mats[i] = m;
    }

    //[Benchmark]
    //public void Add()
    //{
    //    for (int i = 0; i < Count - 1; i++)
    //        @out[i] = mats[i] + mats[i + 1];
    //}

    //[Benchmark]
    //public void Subtract()
    //{
    //    for (int i = 0; i < Count - 1; i++)
    //        @out[i] = mats[i] - mats[i + 1];
    //}

    //[Benchmark]
    //public void Multiply()
    //{
    //    for (int i = 0; i < Count - 1; i++)
    //        @out[i] = mats[i] * mats[i + 1];
    //}

    //[Benchmark]
    //public void Transpose()
    //{
    //    for (int i = 0; i < Count; i++)
    //        @out[i] = mats[i].Transpose();
    //}

    [Benchmark]
    public void Determinant()
    {
        for (int i = 0; i < Count; i++)
            nums[i] = mats[i].Determinant();
    }
}
