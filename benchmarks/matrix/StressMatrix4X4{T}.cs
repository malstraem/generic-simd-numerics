using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

public class StressMatrix4X4WithQuaternion<T> : StressMatrix4X4<T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
{
    private readonly Vector3D<T>[] scales = new Vector3D<T>[Count],
                                   positions = new Vector3D<T>[Count];

    private readonly Quaternion<T>[] quats = new Quaternion<T>[Count];

    public StressMatrix4X4WithQuaternion()
    {
        for (int i = 0; i < Count; i++)
        {
            quats[i] = Quat<T>.Gen(T.CreateTruncating(Random.Shared.Next(1, 10))).Silk();
            scales[i] = Vec3<T>.Gen(T.CreateTruncating(Random.Shared.Next(1, 10))).Silk();
            positions[i] = Vec3<T>.Gen(T.CreateTruncating(Random.Shared.Next(1, 10))).Silk();
        }
    }

    /*[Benchmark]
    public void Rotation()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Matrix4X4.CreateFromQuaternion(quats[i]);
    }

    [Benchmark]
    public void Transform()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Matrix4X4.Transform(mats[i], quats[i]);
    }*/

    [Benchmark]
    public void Affine()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Matrix4X4.Transform(Matrix4X4.CreateScale(scales[i]), quats[i]) * Matrix4X4.CreateTranslation(positions[i]);
    }
}

public class StressMatrix4X4<T> : BaseBench<T>
    where T : unmanaged, INumber<T>
{
    protected readonly Matrix4X4<T>[] mats = new Matrix4X4<T>[Count],
                                      @out = new Matrix4X4<T>[Count];

    public StressMatrix4X4()
    {
        for (int i = 0; i < Count; i++)
            mats[i] = Mat44<T>.Gen(T.CreateTruncating(Random.Shared.Next(1, 10))).Silk();
    }

    /*[Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = mats[i] + mats[i + 1];
    }

    [Benchmark]
    public void Substract()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = mats[i] - mats[i + 1];
    }*/

    [Benchmark]
    public void Multiply()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = mats[i] * mats[i + 1];
    }
}
