using BenchmarkDotNet.Running;

using System.Numerics.Bench;

//BenchmarkRunner.Run<StressVec2<float>>();
//BenchmarkRunner.Run<StressVec2<byte, float>>();
//BenchmarkRunner.Run<StressVec2<short, float>>();
//BenchmarkRunner.Run<StressVec2<int, float>>();

//BenchmarkRunner.Run<StressVector3>();
//BenchmarkRunner.Run<StressVec3<float>>();
//BenchmarkRunner.Run<StressVector3D<float>>();

/*BenchmarkRunner.Run<StressVector3>();
BenchmarkRunner.Run<StressVec3<float>>();
BenchmarkRunner.Run<StressVector3D<float>>();*/

//BenchmarkRunner.Run<StressVector4>();

//BenchmarkRunner.Run<StressVec4<float>>();
//BenchmarkRunner.Run<StressVector4D<float>>();

//BenchmarkRunner.Run<StressVec4<double>>();
//BenchmarkRunner.Run<StressVector4D<double>>();

//BenchmarkRunner.Run<StressMatrix4x4>();

//BenchmarkRunner.Run<StressMat44<short>>();
//BenchmarkRunner.Run<StressMat44<int>>();

//BenchmarkRunner.Run<StressMat44<float>>();
//BenchmarkRunner.Run<StressMat44<double>>();

//BenchmarkRunner.Run<StressMatrix4X4<short>>();
//BenchmarkRunner.Run<StressMatrix4X4<int>>();

BenchmarkRunner.Run<StressMatrix4X4<float>>();
//BenchmarkRunner.Run<StressMatrix4X4<double>>();

Console.ReadLine();
