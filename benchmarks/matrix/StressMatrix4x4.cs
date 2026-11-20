using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public class StressMatrix4x4 : BaseBench<float>
{
    private readonly Matrix4x4[] mats = new Matrix4x4[Count],
                                 @out = new Matrix4x4[Count],
                                 inverts = new Matrix4x4[Count];

    private readonly Quaternion[] quats = new Quaternion[Count];

    private readonly Vector3[] scales = new Vector3[Count],
                               positions = new Vector3[Count];

    public StressMatrix4x4()
    {
        var m = Mat44<float>.Gen(1f).System();
        var q = Quat<float>.Rand().System();
        var v = Vec3<float>.Gen(1).System();

        // determinant > eps
        var invert = new Mat44<float>(
            0.5f, -0.1f, 0.6f, 0,
            0.4f, 0.8f, -0.2f, 0,
            -0.5f, 0.4f, 0.3f, 0,
            0f, 0f, 0f, 0.7f).System();

        for (int i = 0; i < Count; i++)
        {
            mats[i] = m;
            quats[i] = q;
            scales[i] = v;
            positions[i] = v;
            inverts[i] = invert;
        }
    }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            @out[i] = mats[i] + mats[i + 1];
    }

    [Benchmark]
    public void Subtract()
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
    public void Transpose()
    {
        for (int i = 0; i < Count; i++)
            @out[i] = Matrix4x4.Transpose(mats[i]);
    }

    [Benchmark]
    public void Invert()
    {
        for (int i = 0; i < Count; i++)
            _ = Matrix4x4.Invert(mats[i], out @out[i]);
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
            @out[i] = Matrix4x4.CreateFromQuaternion(quats[i]) * Matrix4x4.CreateScale(scales[i]) * Matrix4x4.CreateTranslation(positions[i]);
    }
}
