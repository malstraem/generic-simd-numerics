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
| Multiply  | 120.87 μs | 0.140 μs | 0.117 μs |     218 B |
| Divide    | 203.18 μs | 0.386 μs | 0.342 μs |     278 B |
| Conjugate |  49.12 μs | 0.241 μs | 0.213 μs |      85 B |
| Inverse   |  70.77 μs | 0.212 μs | 0.188 μs |     125 B |
