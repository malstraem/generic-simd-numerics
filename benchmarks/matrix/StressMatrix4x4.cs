using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public class StressMatrix4x4 : BaseBench<float>
{
    private readonly Matrix4x4[] mats = new Matrix4x4[Count],
                                 @out = new Matrix4x4[Count];

    private readonly Quaternion[] quats = new Quaternion[Count];

    private readonly Vector3[] scales = new Vector3[Count],
                               positions = new Vector3[Count];

    public StressMatrix4x4()
    {
        for (int i = 0; i < Count; i++)
        {
            mats[i] = Mat44<float>.Gen(Random.Shared.Next(1, 10)).System();
            quats[i] = Quat<float>.Gen(Random.Shared.Next(1, 10)).System();
            scales[i] = Vec3<float>.Gen(Random.Shared.Next(1, 10)).System();
            positions[i] = Vec3<float>.Gen(Random.Shared.Next(1, 10)).System();
        }
    }

    [Benchmark]
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
    }

    [Benchmark]
    public void Multiply()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = mats[i] * mats[i + 1];
    }

    [Benchmark]
    public void Rotation()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Matrix4x4.CreateFromQuaternion(quats[i]);
    }

    [Benchmark]
    public void Transform()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Matrix4x4.Transform(mats[i], quats[i]);
    }

    [Benchmark]
    public void Affine()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Matrix4x4.Transform(Matrix4x4.CreateScale(scales[i]), quats[i]) * Matrix4x4.CreateTranslation(positions[i]);
    }
}
