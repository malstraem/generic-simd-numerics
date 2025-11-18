using BenchmarkDotNet.Running;

using System.Numerics.Bench;

BenchmarkRunner.Run<MatrixMultiplication>();
//BenchmarkRunner.Run<Vector4Bench>();

Console.ReadLine();
