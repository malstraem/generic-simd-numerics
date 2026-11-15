```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method   | Mean        | Error     | StdDev    | Code Size |
|--------- |------------:|----------:|----------:|----------:|
| Add      |    74.29 μs |  0.195 μs |  0.173 μs |     106 B |
| Subtract |    74.68 μs |  0.122 μs |  0.109 μs |     106 B |
| Multiply | 4,891.53 μs | 16.798 μs | 15.713 μs |   2,944 B |
