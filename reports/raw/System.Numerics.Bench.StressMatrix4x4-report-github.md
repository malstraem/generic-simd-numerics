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
| Add       | 161.2 μs | 0.15 μs | 0.13 μs |     185 B |
| Subtract  | 159.9 μs | 0.51 μs | 0.48 μs |     185 B |
| Multiply  | 295.4 μs | 0.29 μs | 0.27 μs |     436 B |
| Rotation  | 240.7 μs | 0.10 μs | 0.09 μs |     360 B |
| Transform | 736.5 μs | 0.38 μs | 0.30 μs |     870 B |
| Affine    | 890.2 μs | 0.21 μs | 0.18 μs |   1,083 B |
