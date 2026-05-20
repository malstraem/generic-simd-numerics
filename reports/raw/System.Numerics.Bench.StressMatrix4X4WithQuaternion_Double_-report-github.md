```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method    | Mean       | Error    | StdDev   | Code Size |
|---------- |-----------:|---------:|---------:|----------:|
| Rotation  | 1,337.9 μs |  5.02 μs |  4.70 μs |     473 B |
| Transform | 4,993.2 μs | 16.23 μs | 15.18 μs |   2,294 B |
| Affine    | 7,844.3 μs |  7.83 μs |  7.32 μs |   4,042 B |
| Add       |   505.2 μs |  0.28 μs |  0.25 μs |     649 B |
| Subtract  |   500.1 μs |  1.49 μs |  1.40 μs |     649 B |
| Multiply  | 4,454.5 μs |  7.08 μs |  6.62 μs |   2,014 B |
