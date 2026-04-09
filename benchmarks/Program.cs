using System.Numerics.Bench;

using BenchmarkDotNet.Running;

// todo: post process results to reports

var vecs = BenchmarkSwitcher.FromTypes([
    //typeof(StressVector2),
    //typeof(StressVec2<float>),
    //typeof(StressVector2D<float>),

    //typeof(StressVec2<double>),
    //typeof(StressVector2D<double>),

    //typeof(StressVec2<byte, float>),
    //typeof(StressVec2<short, float>),
    //typeof(StressVec2<int, float>),
    //typeof(StressVec2<long, double>),
    //typeof(StressVector2D<byte>),
    //typeof(StressVector2D<short>),
    //typeof(StressVector2D<int>),
    //typeof(StressVector2D<long>),

    //typeof(StressVector3),
    //typeof(StressVec3<float>),
    //typeof(StressVector3D<float>),

    //typeof(StressVec3<double>),
    //typeof(StressVector3D<double>),

    //typeof(StressVec3<byte, float>),
    //typeof(StressVec3<short, float>),
    //typeof(StressVec3<int, float>),
    //typeof(StressVec3<long, double>),
    //typeof(StressVector3D<byte>),
    //typeof(StressVector3D<short>),
    //typeof(StressVector3D<int>),
    //typeof(StressVector3D<long>),

    //typeof(StressVector4),
    //typeof(StressVec4<float>),
    //typeof(StressVector4D<float>),

    //typeof(StressVec4<double>),
    //typeof(StressVector4D<double>),

    //typeof(StressVec4<byte, float>),
    //typeof(StressVec4<short, float>),
    //typeof(StressVec4<int, float>),
    //typeof(StressVec4<long, double>),
    //typeof(StressVector4D<byte>),
    //typeof(StressVector4D<short>),
    //typeof(StressVector4D<int>),
    //typeof(StressVector4D<long>),

    //typeof(StressMatrix4x4),
    //typeof(StressMat44<float>),
    //typeof(StressMatrix4X4<float>),

    //typeof(StressMat44<double>),
    //typeof(StressMatrix4X4<double>),

    //typeof(StressMat44<byte>),
    //typeof(StressMat44<short>),
    //typeof(StressMat44<int>),
    //typeof(StressMat44<long>),
    //typeof(StressMatrix4X4<byte>),
    //typeof(StressMatrix4X4<short>),
    //typeof(StressMatrix4X4<int>),
    //typeof(StressMatrix4X4<long>),

    typeof(StressQuaternion),
    typeof(StressQuat<float>),
    typeof(StressQuaternion<float>),

    //typeof(StressQuat<double>),
    //typeof(StressQuaternion<double>)
]);

var summary = vecs.RunAll();

Console.ReadLine();
