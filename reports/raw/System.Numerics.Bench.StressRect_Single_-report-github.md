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
| IsIntersect | 65.59 μs | 0.102 μs | 0.091 μs |     124 B |
| Contains    | 66.66 μs | 0.460 μs | 0.430 μs |     118 B |
| Area        | 27.93 μs | 0.055 μs | 0.052 μs |      76 B |
