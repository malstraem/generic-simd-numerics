using BenchmarkDotNet.Attributes;

namespace System.Numerics.Bench;

[SimpleJob, DisassemblyDiagnoser]
public abstract class StressVec3<T> : StressVec3<T, T>
    where T : unmanaged, INumber<T>, IRootFunctions<T>;

[SimpleJob, DisassemblyDiagnoser]
public abstract class StressVec3<T, R> : BaseBench
    where T : unmanaged, INumber<T>
    where R : unmanaged, IRootFunctions<R>
{
    private static readonly T[] nums = new T[Count];

    private static readonly Vec3<T>[] vecs = new Vec3<T>[Count];

    public StressVec3()
    {
        for (int i = 0; i < vecs.Length; i++)
            vecs[i] = Vec3<T>.Gen(T.CreateTruncating(Random.Shared.Next(10, 100)));
    }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Count - 1; i++)
            vecs[i] = vecs[i] + vecs[i + 1];
    }

    //[Benchmark]
    //public void Substract()
    //{
    //    for (int i = 0; i < Count - 1; i++)
    //        vecs[i] = vecs[i] - vecs[i + 1];
    //}

    //[Benchmark]
    //public void Multiply()
    //{
    //    for (int i = 0; i < Count - 1; i++)
    //        vecs[i] = vecs[i] * vecs[i + 1];
    //}

    //[Benchmark]
    //public void Divide()
    //{
    //    for (int i = 0; i < Count - 1; i++)
    //        vecs[i] = vecs[i] / vecs[i + 1];
    //}

    //[Benchmark]
    //public void Abs()
    //{
    //    for (int i = 0; i < Count; i++)
    //        vecs[i] = vecs[i].Abs();
    //}

    //[Benchmark]
    //public void Sum()
    //{
    //    for (int i = 0; i < Count; i++)
    //        nums[i] = vecs[i].Sum();
    //}

    //[Benchmark]
    //public void Dot()
    //{
    //    for (int i = 0; i < Count - 1; i++)
    //        nums[i] = vecs[i].Dot(vecs[i + 1]);
    //}

    //[Benchmark]
    //public void LengthSquared()
    //{
    //    for (int i = 0; i < Count; i++)
    //        nums[i] = vecs[i].LengthSquared();
    //}

    //[Benchmark]
    //public void DistanceSquared()
    //{
    //    for (int i = 0; i < Count - 1; i++)
    //        nums[i] = vecs[i].DistanceSquared(vecs[i + 1]);
    //}

    //[Benchmark]
    //public void Length()
    //{
    //    for (int i = 0; i < Count; i++)
    //        nums[i] = vecs[i].Length<R>();
    //}

    //[Benchmark]
    //public void Distance()
    //{
    //    for (int i = 0; i < Count - 1; i++)
    //        nums[i] = vecs[i].Distance<R>(vecs[i + 1]);
    //}

    //[Benchmark]
    //public void Normalize()
    //{
    //    for (int i = 0; i < Count; i++)
    //        vecs[i] = vecs[i].Normalize<R>();
    //}
}
