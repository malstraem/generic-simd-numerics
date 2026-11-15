```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             |  30.56 μs | 0.554 μs | 0.518 μs |      78 B |
| Subtract        |  29.97 μs | 0.341 μs | 0.432 μs |      78 B |
| Multiply        |  29.76 μs | 0.065 μs | 0.051 μs |      78 B |
| Divide          |  56.93 μs | 0.139 μs | 0.123 μs |      78 B |
| Abs             |  26.11 μs | 0.106 μs | 0.099 μs |      68 B |
| Sum             |  32.23 μs | 0.113 μs | 0.105 μs |      76 B |
| Dot             |  45.92 μs | 0.080 μs | 0.071 μs |      96 B |
| LengthSquared   |  34.50 μs | 0.095 μs | 0.084 μs |      80 B |
| DistanceSquared |  48.75 μs | 0.204 μs | 0.181 μs |     100 B |
| Length          |  91.46 μs | 0.043 μs | 0.038 μs |      84 B |
| Distance        |  95.00 μs | 0.459 μs | 0.429 μs |     104 B |
| Normalize       | 151.55 μs | 0.048 μs | 0.040 μs |      89 B |
| Transform       |  65.71 μs | 0.127 μs | 0.118 μs |     129 B |
