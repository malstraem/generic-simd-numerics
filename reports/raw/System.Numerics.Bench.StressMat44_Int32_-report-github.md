```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method   | Mean     | Error   | StdDev  | Code Size |
|--------- |---------:|--------:|--------:|----------:|
| Add      | 121.5 μs | 0.22 μs | 0.18 μs |     118 B |
| Subtract | 136.1 μs | 0.40 μs | 0.35 μs |     118 B |
| Multiply | 503.5 μs | 1.37 μs | 1.28 μs |     582 B |
