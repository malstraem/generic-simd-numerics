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
| Rotation  | 293.9 μs | 0.69 μs | 0.61 μs |     322 B |
| Transform | 525.4 μs | 1.88 μs | 1.76 μs |     491 B |
| Affine    | 450.3 μs | 0.99 μs | 0.88 μs |     509 B |
| Add       | 270.7 μs | 1.36 μs | 1.28 μs |     144 B |
| Subtract  | 266.6 μs | 0.71 μs | 0.66 μs |     144 B |
| Multiply  | 405.0 μs | 0.69 μs | 0.65 μs |     490 B |
