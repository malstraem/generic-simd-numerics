using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace System.Numerics.Bench;

// todo gen "hand crafted" reports

public static class Prettifier
{
    public static void WriteMarkdownReports(Summary summary)
    {
        Dictionary<string, List<BenchmarkCase>> methods = [];

        foreach (var @case in summary.BenchmarksCases)
        {
            string method = @case.Descriptor.WorkloadMethodDisplayInfo;

            if (!methods.TryGetValue(method, out var cases))
                cases = methods[method] = [];

            cases.Add(@case);
        }

        foreach (var (method, cases) in methods)
        {
            foreach (var @case in cases)
            {
                var asm = (DisassemblyDiagnoser)@case.Config.GetDiagnosers().First(x => x is DisassemblyDiagnoser);
            }
        }
    }
}
