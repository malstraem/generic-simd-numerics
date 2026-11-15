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
| Length          |  91.45 μs | 0.062 μs | 0.055 μs |      84 B |
| Distance        |  94.90 μs | 0.346 μs | 0.324 μs |     104 B |
| Normalize       | 151.63 μs | 0.142 μs | 0.126 μs |      89 B |
| Add             |  29.67 μs | 0.085 μs | 0.075 μs |      78 B |
| Subtract        |  29.73 μs | 0.132 μs | 0.123 μs |      78 B |
| Multiply        |  29.78 μs | 0.092 μs | 0.086 μs |      78 B |
| Divide          |  56.68 μs | 0.120 μs | 0.112 μs |      78 B |
| Sum             |  32.14 μs | 0.048 μs | 0.045 μs |      76 B |
| Dot             |  57.07 μs | 0.123 μs | 0.109 μs |     103 B |
| LengthSquared   |  34.37 μs | 0.079 μs | 0.074 μs |      80 B |
| DistanceSquared |  57.11 μs | 0.093 μs | 0.082 μs |     107 B |
| Transform       |  65.93 μs | 0.111 μs | 0.103 μs |     134 B |
