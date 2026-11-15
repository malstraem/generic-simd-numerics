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
| Multiply  | 211.2 μs | 0.44 μs | 0.39 μs |     327 B |
| Divide    | 477.9 μs | 1.61 μs | 1.50 μs |     438 B |
| Conjugate | 120.6 μs | 0.23 μs | 0.20 μs |     128 B |
| Inverse   | 154.6 μs | 0.57 μs | 0.48 μs |     204 B |
