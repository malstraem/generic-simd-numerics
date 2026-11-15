```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method   | Mean       | Error    | StdDev   | Code Size |
|--------- |-----------:|---------:|---------:|----------:|
| Add      |   848.3 μs |  0.92 μs |  0.81 μs |     664 B |
| Subtract |   847.9 μs |  1.18 μs |  1.11 μs |     664 B |
| Multiply | 4,554.0 μs | 13.11 μs | 11.62 μs |   1,711 B |
