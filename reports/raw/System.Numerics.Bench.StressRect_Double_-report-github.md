```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method      | Mean     | Error    | StdDev   | Code Size |
|------------ |---------:|---------:|---------:|----------:|
| IsIntersect | 66.20 μs | 0.061 μs | 0.055 μs |     127 B |
| Contains    | 67.20 μs | 0.317 μs | 0.296 μs |     121 B |
| Area        | 32.33 μs | 0.057 μs | 0.053 μs |      78 B |
