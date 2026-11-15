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
| Rotation  | 1,100.7 μs | 21.86 μs | 25.17 μs |     409 B |
| Transform |   938.8 μs | 10.67 μs |  9.98 μs |     911 B |
| Affine    | 5,078.4 μs |  8.85 μs |  7.84 μs |   2,861 B |
| Add       |   493.6 μs |  1.04 μs |  0.97 μs |     649 B |
| Subtract  |   496.1 μs |  1.39 μs |  1.23 μs |     649 B |
| Multiply  | 4,650.6 μs | 19.77 μs | 18.49 μs |   2,068 B |
