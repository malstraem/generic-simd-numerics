```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method          | Mean      | Error    | StdDev   | Median    | Code Size |
|---------------- |----------:|---------:|---------:|----------:|----------:|
| Add             |  98.96 μs | 0.217 μs | 0.203 μs |  98.97 μs |     133 B |
| Subtract        | 100.23 μs | 0.327 μs | 0.290 μs | 100.22 μs |     133 B |
| Multiply        | 119.68 μs | 1.943 μs | 1.817 μs | 120.53 μs |     137 B |
| Divide          | 431.58 μs | 0.438 μs | 0.389 μs | 431.49 μs |     154 B |
| Abs             | 111.93 μs | 0.157 μs | 0.139 μs | 111.94 μs |     146 B |
| Dot             | 107.64 μs | 2.134 μs | 2.458 μs | 106.06 μs |     133 B |
| LengthSquared   | 114.15 μs | 0.347 μs | 0.325 μs | 114.31 μs |     114 B |
| DistanceSquared | 149.69 μs | 0.433 μs | 0.384 μs | 149.75 μs |     144 B |
| Transform       | 189.20 μs | 0.662 μs | 0.587 μs | 189.23 μs |     203 B |
