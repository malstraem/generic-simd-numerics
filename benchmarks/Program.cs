using BenchmarkDotNet.Running;

using System.Numerics.Bench;

/*Environment.SetEnvironmentVariable("DOTNET_JitDisasm",
    "op_Addition"
);
Environment.SetEnvironmentVariable("DOTNET_JitDisasmOnlyOptimized", "1");*/

BenchmarkRunner.Run<StressVector4>();
BenchmarkRunner.Run<StressVec4<float>>();
//BenchmarkRunner.Run<StressVector4D<float>>();

Console.ReadLine();
