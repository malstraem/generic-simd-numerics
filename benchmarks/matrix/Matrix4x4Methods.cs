using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public class Matrix4x4Methods : BaseBench
{
    private readonly Matrix4x4[] mats = new Matrix4x4[Count];
    private readonly Quaternion[] quats = new Quaternion[Count];
    private readonly Vector3[] pos = new Vector3[Count],
                               scale = new Vector3[Count];

    public Matrix4x4Methods()
    {
        for (int i = 0; i < mats.Length; i++)
        {
            mats[i] = Mat44<float>.Gen(Random.Shared.Next(1, 10)).System();
            pos[i] = Vec3<float>.Gen(Random.Shared.Next(10, 100)).System();
            scale[i] = Vec3<float>.Gen(Random.Shared.Next(10, 100)).System();
        }
    }

    //[Benchmark]
    public void CreateFromQuat()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = Matrix4x4.CreateFromQuaternion(quats[i]);
    }

    //[Benchmark]
    public void Transform()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = Matrix4x4.Transform(mats[i], quats[i]);
    }

    [Benchmark]
    public void CreateModelMatrix()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = Matrix4x4.Transform(Matrix4x4.CreateScale(scale[i]), quats[i]) * Matrix4x4.CreateTranslation(pos[i]);
    }
}
