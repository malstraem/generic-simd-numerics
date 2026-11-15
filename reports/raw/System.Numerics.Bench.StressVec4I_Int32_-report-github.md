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
| Add             |  41.45 μs | 0.109 μs | 0.091 μs |      78 B |
| Subtract        |  42.39 μs | 0.072 μs | 0.060 μs |      78 B |
| Multiply        |  29.58 μs | 0.068 μs | 0.060 μs |      78 B |
| Divide          |  90.14 μs | 0.144 μs | 0.120 μs |     152 B |
| Sum             |  35.09 μs | 0.079 μs | 0.074 μs |      78 B |
| Dot             |  93.55 μs | 0.190 μs | 0.168 μs |      94 B |
| LengthSquared   |  74.12 μs | 0.235 μs | 0.220 μs |      71 B |
| DistanceSquared |  93.66 μs | 0.095 μs | 0.089 μs |      98 B |
| Transform       | 122.36 μs | 0.244 μs | 0.228 μs |     171 B |
