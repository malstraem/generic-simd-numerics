using BenchmarkDotNet.Running;

using GenericNumerics.Bench;

BenchmarkRunner.Run<MatrixMultiplication>();
//BenchmarkRunner.Run<Vector4Bench>();

Console.ReadLine();
