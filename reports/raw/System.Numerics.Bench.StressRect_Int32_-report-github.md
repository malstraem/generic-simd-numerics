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
| IsIntersect | 66.74 μs | 0.430 μs | 0.402 μs |     122 B |
| Contains    | 61.63 μs | 0.244 μs | 0.203 μs |     116 B |
| Area        | 25.97 μs | 0.050 μs | 0.047 μs |      77 B |
