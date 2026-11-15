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
| Add       | 186.9 μs | 0.55 μs | 0.49 μs |     185 B |
| Subtract  | 185.2 μs | 0.36 μs | 0.32 μs |     185 B |
| Multiply  | 297.9 μs | 1.20 μs | 1.00 μs |     449 B |
| Rotation  | 235.6 μs | 0.68 μs | 0.64 μs |     352 B |
| Transform | 687.8 μs | 2.63 μs | 2.46 μs |     844 B |
| Affine    | 895.5 μs | 2.06 μs | 1.93 μs |   1,078 B |
