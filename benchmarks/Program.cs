using BenchmarkDotNet.Running;

using System.Numerics.Bench;

BenchmarkRunner.Run<AsmVec4<float, float>>();

Console.ReadLine();
