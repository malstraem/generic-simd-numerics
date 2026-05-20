```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method   | Mean     | Error   | StdDev  | Code Size |
|--------- |---------:|--------:|--------:|----------:|
| Add      | 121.3 μs | 0.03 μs | 0.03 μs |     118 B |
| Subtract | 121.8 μs | 0.25 μs | 0.23 μs |     118 B |
| Multiply | 496.8 μs | 0.42 μs | 0.40 μs |     582 B |
