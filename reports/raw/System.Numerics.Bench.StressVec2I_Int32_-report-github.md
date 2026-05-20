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
| Add             |  76.03 μs | 0.061 μs | 0.054 μs |     104 B |
| Subtract        |  56.60 μs | 0.083 μs | 0.077 μs |      91 B |
| Multiply        |  58.09 μs | 0.058 μs | 0.052 μs |      93 B |
| Divide          | 215.43 μs | 0.205 μs | 0.182 μs |      94 B |
| Sum             |  38.77 μs | 0.030 μs | 0.025 μs |      64 B |
| Dot             |  57.64 μs | 0.049 μs | 0.043 μs |      89 B |
| LengthSquared   |  42.22 μs | 0.033 μs | 0.030 μs |      72 B |
| DistanceSquared |  74.35 μs | 0.087 μs | 0.081 μs |      94 B |
