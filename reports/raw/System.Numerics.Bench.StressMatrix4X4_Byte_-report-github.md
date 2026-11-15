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
| Add      |   739.9 μs |  1.39 μs |  1.23 μs |     762 B |
| Subtract |   740.2 μs |  0.91 μs |  0.81 μs |     762 B |
| Multiply | 5,279.4 μs | 13.08 μs | 11.60 μs |   2,797 B |
