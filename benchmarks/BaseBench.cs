using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace System.Numerics.Bench;

[DisassemblyDiagnoser]

[SimpleJob(RuntimeMoniker.Net10_0)]
public abstract class BaseBench<T>
{
    protected const int Count = 100_000;

    protected static readonly T[] nums = new T[Count];
}
