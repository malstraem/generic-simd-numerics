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
| Length          | 164.33 μs | 0.090 μs | 0.080 μs |      87 B |
| Distance        | 162.51 μs | 0.475 μs | 0.444 μs |     107 B |
| Normalize       | 249.14 μs | 0.180 μs | 0.151 μs |      97 B |
| Add             |  71.21 μs | 0.170 μs | 0.151 μs |      81 B |
| Subtract        |  55.05 μs | 0.085 μs | 0.079 μs |      81 B |
| Multiply        |  54.96 μs | 0.039 μs | 0.035 μs |      81 B |
| Divide          |  88.67 μs | 0.321 μs | 0.300 μs |      81 B |
| Sum             |  33.50 μs | 0.075 μs | 0.063 μs |      79 B |
| Dot             |  57.68 μs | 0.110 μs | 0.092 μs |     106 B |
| LengthSquared   |  36.03 μs | 0.065 μs | 0.061 μs |      83 B |
| DistanceSquared |  57.80 μs | 0.149 μs | 0.132 μs |     110 B |
| Transform       |  77.78 μs | 0.206 μs | 0.183 μs |     145 B |
