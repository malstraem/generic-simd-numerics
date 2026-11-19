using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(int), typeof(float))]
[GenericTypeArguments(typeof(int), typeof(double))]
[GenericTypeArguments(typeof(float), typeof(double))]
public class StressConversionMatrix4X4<T1, T2> : BaseBench<T1>
    where T1 : unmanaged, INumber<T1>
    where T2 : unmanaged, INumber<T2>
{
    private readonly Matrix4X4<T1>[] mats = new Matrix4X4<T1>[Count];

    private readonly Matrix4X4<T2>[] converted = new Matrix4X4<T2>[Count];

    public StressConversionMatrix4X4()
    {
        for (int i = 0; i < Count; i++)
        {
            mats[i] = Mat44<T1>.Gen(T1.One).Silk();
            converted[i] = mats[i].As<T2>();
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
[GenericTypeArguments(typeof(double))]
public class StressMatrix4X4WithQuaternion<T> : BaseStressMatrix4X4<T>
    where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    private readonly Vector3D<T>[] scales = new Vector3D<T>[Count],
                                   positions = new Vector3D<T>[Count];

    private readonly Quaternion<T>[] quats = new Quaternion<T>[Count];

    private readonly Matrix4X4<T>[] inverts = new Matrix4X4<T>[Count];

    public StressMatrix4X4WithQuaternion()
    {
        var q = Quat<T>.Rand().Silk();
        var v = Vec3<T>.Gen(T.One).Silk();

        var invert = new Mat44<T>(
            T.CreateTruncating(0.74999994), T.CreateTruncating(-0.216506317), T.CreateTruncating(0.62499994), T.Zero,
            T.CreateTruncating(0.433012635), T.CreateTruncating(0.87499994), T.CreateTruncating(-0.216506317), T.Zero,
            T.CreateTruncating(-0.49999997), T.CreateTruncating(0.433012635), T.CreateTruncating(0.74999994), T.Zero,
            T.Zero, T.Zero, T.Zero, T.CreateTruncating(0.99999994)).Silk();

        for (int i = 0; i < Count; i++)
        {
            quats[i] = q;
            scales[i] = v;
            positions[i] = v;
            inverts[i] = invert;
        }
    }

    [Benchmark]
    public void Invert()
    {
        for (int i = 0; i < Count; i++)
            _ = Matrix4X4.Invert(mats[i], out @out[i]);
    }

    //[Benchmark]
    //public void Rotation()
    //{
    //    for (int i = 0; i < Count; i++)
    //        @out[i] = Matrix4X4.CreateFromQuaternion(quats[i]);
    //}

    //[Benchmark]
    //public void Transform()
    //{
    //    for (int i = 0; i < Count; i++)
    //        @out[i] = Matrix4X4.Transform(mats[i], quats[i]);
    //}

    //[Benchmark]
    //public void Affine()
    //{
    //    for (int i = 0; i < Count; i++)
    //        @out[i] = Matrix4X4.Transform(Matrix4X4.CreateScale(scales[i]), quats[i]) * Matrix4X4.CreateTranslation(positions[i]);
    //}
}

[GenericTypeArguments(typeof(byte))]
[GenericTypeArguments(typeof(short))]
[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(long))]
public class StressMatrix4X4<T> : BaseStressMatrix4X4<T>
    where T : unmanaged, INumber<T>;

public abstract class BaseStressMatrix4X4<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    protected readonly Matrix4X4<T>[] mats = new Matrix4X4<T>[Count],
                                      @out = new Matrix4X4<T>[Count];

    public BaseStressMatrix4X4()
    {
        for (int i = 0; i < Count; i++)
            mats[i] = Mat44<T>.Gen(T.One).Silk();
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
    //        @out[i] = Matrix4X4.Transpose(mats[i]);
    //}
}
