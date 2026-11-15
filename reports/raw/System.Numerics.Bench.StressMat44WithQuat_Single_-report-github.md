```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method    | Mean     | Error   | StdDev  | Code Size |
|---------- |---------:|--------:|--------:|----------:|
| Rotation  | 187.4 μs | 0.41 μs | 0.36 μs |     238 B |
| Transform | 345.3 μs | 0.58 μs | 0.52 μs |     416 B |
| Affine    | 261.4 μs | 0.96 μs | 0.85 μs |     390 B |
| Add       | 140.5 μs | 0.54 μs | 0.50 μs |     118 B |
| Subtract  | 145.3 μs | 0.22 μs | 0.18 μs |     118 B |
| Multiply  | 309.1 μs | 0.65 μs | 0.58 μs |     451 B |
