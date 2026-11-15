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
| Add      |   764.3 μs |  1.66 μs |  1.47 μs |     776 B |
| Subtract |   763.2 μs |  1.31 μs |  1.16 μs |     776 B |
| Multiply | 5,980.3 μs | 14.76 μs | 13.08 μs |   2,985 B |
