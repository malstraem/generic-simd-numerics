```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Length          |  92.06 μs | 0.451 μs | 0.422 μs |      80 B |
| Distance        |  94.36 μs | 0.123 μs | 0.115 μs |      90 B |
| Normalize       | 151.58 μs | 0.323 μs | 0.286 μs |      71 B |
| Add             |  29.43 μs | 0.123 μs | 0.115 μs |      78 B |
| Subtract        |  29.41 μs | 0.027 μs | 0.024 μs |      78 B |
| Multiply        |  29.45 μs | 0.032 μs | 0.028 μs |      78 B |
| Divide          |  56.37 μs | 0.055 μs | 0.048 μs |      78 B |
| Sum             |  31.98 μs | 0.061 μs | 0.057 μs |      76 B |
| Dot             | 110.07 μs | 0.107 μs | 0.100 μs |      89 B |
| LengthSquared   |  74.45 μs | 0.116 μs | 0.109 μs |      62 B |
| DistanceSquared | 110.57 μs | 0.132 μs | 0.110 μs |      93 B |
| Transform       |  65.60 μs | 0.172 μs | 0.153 μs |     134 B |
