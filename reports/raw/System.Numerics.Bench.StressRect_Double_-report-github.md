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
| Intersects | 66.99 μs | 0.149 μs | 0.132 μs |     127 B |
| Contains   | 67.91 μs | 0.356 μs | 0.316 μs |     121 B |
| Area       | 32.53 μs | 0.101 μs | 0.090 μs |      78 B |
