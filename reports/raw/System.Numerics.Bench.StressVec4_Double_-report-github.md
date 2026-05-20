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
| Length          | 164.82 μs | 0.394 μs | 0.349 μs |      81 B |
| Distance        | 164.24 μs | 0.773 μs | 0.723 μs |     101 B |
| Normalize       | 249.35 μs | 0.572 μs | 0.477 μs |      91 B |
| Add             |  54.86 μs | 0.061 μs | 0.051 μs |      81 B |
| Subtract        |  54.93 μs | 0.115 μs | 0.102 μs |      81 B |
| Multiply        |  55.03 μs | 0.093 μs | 0.082 μs |      81 B |
| Divide          |  96.06 μs | 0.346 μs | 0.307 μs |      81 B |
| Sum             |  46.27 μs | 0.061 μs | 0.057 μs |      93 B |
| Dot             |  76.29 μs | 0.511 μs | 0.478 μs |     100 B |
| LengthSquared   |  56.78 μs | 0.037 μs | 0.031 μs |      77 B |
| DistanceSquared |  76.01 μs | 0.086 μs | 0.077 μs |     104 B |
| Transform       |  77.32 μs | 0.133 μs | 0.125 μs |     145 B |
