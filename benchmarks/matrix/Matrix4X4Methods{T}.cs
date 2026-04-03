using BenchmarkDotNet.Attributes;

using Silk.NET.Maths;

namespace System.Numerics.Bench;

public abstract class Matrix4X4Methods<T> : BaseBench
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    private readonly Vector3D<T>[] pos = new Vector3D<T>[Count],
                                   scale = new Vector3D<T>[Count];

    private readonly Quaternion<T>[] quats = new Quaternion<T>[Count];

    private readonly Matrix4X4<T>[] mats = new Matrix4X4<T>[Count];

    public Matrix4X4Methods()
    {
        for (int i = 0; i < quats.Length; i++)
        {
            quats[i] = Quat<T>.Gen(T.CreateTruncating(Random.Shared.Next(10, 100))).Silk();
            pos[i] = Vec3<T>.Gen(T.CreateTruncating(Random.Shared.Next(10, 100))).Silk();
            scale[i] = Vec3<T>.Gen(T.CreateTruncating(Random.Shared.Next(10, 100))).Silk();
        }
    }

    //[Benchmark]
    public void CreateFromQuat()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = Matrix4X4.CreateFromQuaternion(quats[i]);
    }

    //[Benchmark]
    public void Transform()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = Matrix4X4.Transform(mats[i], quats[i]);
    }

    [Benchmark]
    public void CreateModelMatrix()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = Matrix4X4.Transform(Matrix4X4.CreateScale(scale[i]), quats[i]) * Matrix4X4.CreateTranslation(pos[i]);
    }
}
