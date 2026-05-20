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
| Length          |  92.71 μs | 1.847 μs | 2.528 μs |  91.29 μs |      82 B |
| Distance        |  93.90 μs | 0.215 μs | 0.190 μs |  93.95 μs |     107 B |
| Normalize       | 207.61 μs | 0.276 μs | 0.245 μs | 207.56 μs |     101 B |
| Add             |  76.38 μs | 0.097 μs | 0.086 μs |  76.36 μs |     104 B |
| Subtract        |  56.62 μs | 0.070 μs | 0.062 μs |  56.62 μs |     100 B |
| Multiply        |  56.63 μs | 0.063 μs | 0.056 μs |  56.62 μs |     100 B |
| Divide          | 109.53 μs | 0.154 μs | 0.137 μs | 109.59 μs |     100 B |
| Sum             |  25.70 μs | 0.129 μs | 0.108 μs |  25.66 μs |      70 B |
| Dot             |  56.48 μs | 0.156 μs | 0.146 μs |  56.53 μs |      95 B |
| LengthSquared   |  32.45 μs | 0.059 μs | 0.053 μs |  32.46 μs |      78 B |
| DistanceSquared |  74.83 μs | 0.123 μs | 0.115 μs |  74.83 μs |     103 B |
