using System.Numerics.Bench;

using BenchmarkDotNet.Running;

//to do: post process result to form reports

var vecs = BenchmarkSwitcher.FromTypes([
    //typeof(StressVector2),

    typeof(StressVec2<float>),
    //typeof(StressVec2<double>),
    //typeof(StressVec2<byte, float>),
    //typeof(StressVec2<sbyte, float>),
    typeof(StressVec2<short, float>),
    //typeof(StressVec2<ushort, float>),
    typeof(StressVec2<int, float>),
    //typeof(StressVec2<uint, float>),

   /*typeof(StressVector2D<float>),
    typeof(StressVector2D<double>),
    typeof(StressVector2D<int>)*/
]);
vecs.RunAll();

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

Console.ReadLine();
