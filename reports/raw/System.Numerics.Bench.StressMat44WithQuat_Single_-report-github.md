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
| Rotation  | 184.7 μs | 0.33 μs | 0.31 μs |     238 B |
| Transform | 321.7 μs | 0.57 μs | 0.53 μs |     422 B |
| Affine    | 245.9 μs | 0.41 μs | 0.38 μs |     375 B |
| Add       | 105.5 μs | 0.19 μs | 0.18 μs |     118 B |
| Subtract  | 105.4 μs | 0.14 μs | 0.13 μs |     118 B |
| Multiply  | 294.1 μs | 0.30 μs | 0.28 μs |     438 B |
