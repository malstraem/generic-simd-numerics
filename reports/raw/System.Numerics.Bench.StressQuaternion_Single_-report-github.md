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
| Multiply  | 207.4 μs | 0.36 μs | 0.32 μs |     327 B |
| Divide    | 432.4 μs | 1.97 μs | 1.74 μs |     438 B |
| Conjugate | 113.7 μs | 0.34 μs | 0.30 μs |     128 B |
| Inverse   | 143.1 μs | 0.39 μs | 0.34 μs |     204 B |
