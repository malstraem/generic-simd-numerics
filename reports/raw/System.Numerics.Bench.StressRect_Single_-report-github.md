```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method     | Mean     | Error    | StdDev   | Code Size |
|----------- |---------:|---------:|---------:|----------:|
| Intersects | 66.08 μs | 0.198 μs | 0.165 μs |     124 B |
| Contains   | 67.47 μs | 0.068 μs | 0.057 μs |     118 B |
| Area       | 28.25 μs | 0.068 μs | 0.061 μs |      76 B |
