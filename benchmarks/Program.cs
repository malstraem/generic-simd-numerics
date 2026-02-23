using BenchmarkDotNet.Running;

using System.Numerics.Bench;

/*Environment.SetEnvironmentVariable("DOTNET_JitDisasm",
    "op_Addition"
);
Environment.SetEnvironmentVariable("DOTNET_JitDisasmOnlyOptimized", "1");*/

//BenchmarkRunner.Run<StressVector3>();
BenchmarkRunner.Run<StressVec3<float>>();
//BenchmarkRunner.Run<StressVector3D<float>>();

//BenchmarkRunner.Run<StressVec2<float>>();
//BenchmarkRunner.Run<StressVec2<byte, float>>();
//BenchmarkRunner.Run<StressVec2<short, float>>();
//BenchmarkRunner.Run<StressVec2<int, float>>();

//BenchmarkRunner.Run<StressMatrix4x4>();

BenchmarkRunner.Run<StressMat44<float>>();
//BenchmarkRunner.Run<StressMatrix4X4<float>>();

Console.ReadLine();
