```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method          | Mean      | Error    | StdDev   | Median    | Code Size |
|---------------- |----------:|---------:|---------:|----------:|----------:|
| Add             |  29.93 μs | 0.584 μs | 0.738 μs |  29.47 μs |      78 B |
| Subtract        |  29.39 μs | 0.040 μs | 0.036 μs |  29.39 μs |      78 B |
| Multiply        |  29.52 μs | 0.084 μs | 0.079 μs |  29.47 μs |      78 B |
| Divide          |  56.44 μs | 0.048 μs | 0.042 μs |  56.45 μs |      78 B |
| Abs             |  25.91 μs | 0.041 μs | 0.037 μs |  25.92 μs |      68 B |
| Sum             |  32.12 μs | 0.049 μs | 0.046 μs |  32.14 μs |      76 B |
| Dot             |  94.19 μs | 0.220 μs | 0.206 μs |  94.14 μs |      81 B |
| LengthSquared   |  75.07 μs | 0.092 μs | 0.086 μs |  75.04 μs |      80 B |
| DistanceSquared |  93.97 μs | 0.135 μs | 0.120 μs |  93.96 μs |      86 B |
| Length          |  92.24 μs | 0.292 μs | 0.273 μs |  92.38 μs |      70 B |
| Distance        |  94.39 μs | 0.115 μs | 0.107 μs |  94.41 μs |      90 B |
| Normalize       | 151.73 μs | 0.565 μs | 0.441 μs | 151.66 μs |      71 B |
| Transform       |  65.49 μs | 0.192 μs | 0.161 μs |  65.51 μs |     129 B |
