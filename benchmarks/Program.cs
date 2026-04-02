using System.Numerics.Bench;

using BenchmarkDotNet.Running;

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

//BenchmarkRunner.Run<StressMat44<byte>>();
//BenchmarkRunner.Run<StressMat44<short>>();
//BenchmarkRunner.Run<StressMat44<int>>();
//BenchmarkRunner.Run<StressMatrix4X4<byte>>();
//BenchmarkRunner.Run<StressMatrix4X4<short>>();
//BenchmarkRunner.Run<StressMatrix4X4<int>>();

//BenchmarkRunner.Run<StressMatrix4x4>();
//BenchmarkRunner.Run<StressMat44<float>>();
//BenchmarkRunner.Run<StressMat44<double>>();
//BenchmarkRunner.Run<StressMatrix4X4<float>>();
//BenchmarkRunner.Run<StressMatrix4X4<double>>();

//BenchmarkRunner.Run<StressQuat<float>>();
//BenchmarkRunner.Run<StressQuat<double>>();

//BenchmarkRunner.Run<StressQuaternion>();

//BenchmarkRunner.Run<StressQuaternion<float>>();
//BenchmarkRunner.Run<StressQuaternion<double>>();

BenchmarkRunner.Run<Mat44Methods<float>>();
BenchmarkRunner.Run<Mat44Methods<double>>();

BenchmarkRunner.Run<Matrix4x4Methods>();

BenchmarkRunner.Run<Matrix4X4Methods<float>>();
BenchmarkRunner.Run<Matrix4X4Methods<double>>();


Console.ReadLine();
