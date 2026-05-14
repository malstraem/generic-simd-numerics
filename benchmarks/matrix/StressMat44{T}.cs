using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[GenericTypeArguments(typeof(float))]
//[GenericTypeArguments(typeof(double))]
public class StressMat44WithQuat<T> : StressMat44<T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    private readonly Quat<T>[] quats = new Quat<T>[Count];

    private readonly Vec3<T>[] scales = new Vec3<T>[Count],
                               positions = new Vec3<T>[Count];

    public StressMat44WithQuat()
    {
        for (int i = 0; i < Count; i++)
        {
            quats[i] = Quat<T>.Rand();
            scales[i] = Vec3<T>.Gen(T.One);
            positions[i] = Vec3<T>.Gen(T.One);
        }
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

    [Benchmark]
    public void Affine()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Mat44.Affine(quats[i], scales[i], positions[i]);
    }
}

[GenericTypeArguments(typeof(byte))]
[GenericTypeArguments(typeof(short))]
[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(long))]
public class StressMat44<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    protected readonly Mat44<T>[] mats = new Mat44<T>[Count],
                                  @out = new Mat44<T>[Count];

    public StressMat44()
    {
        for (int i = 0; i < Count; i++)
            mats[i] = Mat44<T>.Gen(T.CreateTruncating(Random.Shared.Next(1, 10)));
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
}
