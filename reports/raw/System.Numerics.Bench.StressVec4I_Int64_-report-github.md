```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             |  54.92 μs | 0.035 μs | 0.031 μs |      81 B |
| Subtract        |  73.88 μs | 0.279 μs | 0.261 μs |      81 B |
| Multiply        |  55.10 μs | 0.147 μs | 0.130 μs |      85 B |
| Divide          | 988.30 μs | 3.452 μs | 3.229 μs |     415 B |
| Sum             |  36.43 μs | 0.109 μs | 0.102 μs |      82 B |
| Dot             |  57.69 μs | 0.148 μs | 0.131 μs |     105 B |
| LengthSquared   |  39.33 μs | 0.087 μs | 0.082 μs |      88 B |
| DistanceSquared |  65.98 μs | 0.547 μs | 0.511 μs |     114 B |
| Transform       | 122.73 μs | 0.297 μs | 0.263 μs |     186 B |
