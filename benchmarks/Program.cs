using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

using System.Numerics.Bench;

var vecs = BenchmarkSwitcher.FromTypes([
    //typeof(StressVector2),
    //typeof(StressVector2D<float>),

    typeof(StressVec2<float>),
    //typeof(StressVec2<double>),
    typeof(StressVec2<int, float>),
    //typeof(StressVec2<short, float>),
    //typeof(StressVector2D<float>),
]);

vecs.RunAll(DefaultConfig.Instance);

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
