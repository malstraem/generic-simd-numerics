using System.Numerics.Bench;

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

// todo: post process results to prettified reports

var bench = BenchmarkSwitcher.FromTypes([
    typeof(StressVector2),
    typeof(StressVec2<>),
    typeof(StressVector2D<>),

    typeof(StressVec2<,>),
    typeof(StressVector2DI<>),

    typeof(StressVector3),
    typeof(StressVec3<>),
    typeof(StressVector3D<>),

    typeof(StressVec3<,>),
    typeof(StressVector3DI<>),

    typeof(StressVector4),
    typeof(StressVec4<>),
    typeof(StressVector4D<>),

    typeof(StressBaseVec4<>),
    typeof(StressVector4DI<>),

    typeof(StressMat44<>),
    typeof(StressMatrix4X4<>),

    typeof(StressMatrix4x4),
    typeof(StressMat44WithQuat<>),
    typeof(StressMatrix4X4WithQuaternion<>),

    typeof(StressQuaternion),
    typeof(StressQuat<>),
    typeof(StressQuaternion<>)
]);

var summaries = bench.RunAll();

Console.ReadLine();
