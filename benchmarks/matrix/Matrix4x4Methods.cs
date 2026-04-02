using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

public class Matrix4x4Methods : BaseBench
{
    private readonly Matrix4x4[] mats = new Matrix4x4[Count];
    private readonly Quaternion[] quats = new Quaternion[Count];

    public Matrix4x4Methods()
    {
        for (int i = 0; i < mats.Length; i++)
            mats[i] = Mat44<float>.Gen(Random.Shared.Next(1, 10)).System();
    }

    [Benchmark]
    public void CreateFromQuat()
    {
        for (int i = 0; i < Count - 1; i++)
            mats[i] = Matrix4x4.CreateFromQuaternion(quats[i]);
    }
    /*{
        for (int i = 0; i < Count - 1; i++)
            mats[i] = Matrix4x4.Transform(mats[i], quats[i]);
    }*/
}
