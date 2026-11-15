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
| Add      |   898.7 μs |  2.19 μs |  1.94 μs |     739 B |
| Subtract |   893.4 μs |  2.27 μs |  2.12 μs |     739 B |
| Multiply | 5,426.3 μs | 11.44 μs | 10.14 μs |   1,940 B |
