using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace System.Numerics.Bench;

[DisassemblyDiagnoser]

[SimpleJob(RuntimeMoniker.Net10_0)]
public abstract class BaseBench
{
    public const int Count = 100_000;
}
