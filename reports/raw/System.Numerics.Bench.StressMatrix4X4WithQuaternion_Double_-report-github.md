```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method    | Mean       | Error    | StdDev   | Code Size |
|---------- |-----------:|---------:|---------:|----------:|
| Rotation  | 1,185.7 μs |  5.06 μs |  4.74 μs |     473 B |
| Transform | 5,030.6 μs |  6.70 μs |  5.94 μs |   2,294 B |
| Affine    | 8,132.1 μs | 25.61 μs | 22.70 μs |   4,082 B |
| Add       |   536.6 μs |  1.40 μs |  1.24 μs |     649 B |
| Subtract  |   548.7 μs |  1.31 μs |  1.16 μs |     649 B |
| Multiply  | 4,142.1 μs | 12.25 μs | 11.45 μs |   2,014 B |
