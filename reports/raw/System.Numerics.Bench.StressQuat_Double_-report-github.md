```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method    | Mean      | Error    | StdDev   | Code Size |
|---------- |----------:|---------:|---------:|----------:|
| Multiply  | 130.24 μs | 0.625 μs | 0.554 μs |     224 B |
| Divide    | 243.62 μs | 0.658 μs | 0.583 μs |     287 B |
| Conjugate |  76.15 μs | 0.389 μs | 0.345 μs |      88 B |
| Inverse   |  92.70 μs | 0.292 μs | 0.259 μs |     127 B |
