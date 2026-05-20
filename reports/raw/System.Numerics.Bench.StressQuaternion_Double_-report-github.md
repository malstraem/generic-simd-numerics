```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method    | Mean     | Error   | StdDev  | Code Size |
|---------- |---------:|--------:|--------:|----------:|
| Multiply  | 207.7 μs | 0.20 μs | 0.19 μs |     327 B |
| Divide    | 498.1 μs | 0.59 μs | 0.52 μs |     445 B |
| Conjugate | 102.0 μs | 1.97 μs | 1.84 μs |     124 B |
| Inverse   | 155.6 μs | 0.14 μs | 0.12 μs |     212 B |
