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
| Rotation  | 270.3 μs | 0.46 μs | 0.43 μs |     322 B |
| Transform | 478.7 μs | 2.04 μs | 1.91 μs |     497 B |
| Affine    | 363.4 μs | 0.54 μs | 0.48 μs |     503 B |
| Add       | 222.0 μs | 0.64 μs | 0.60 μs |     144 B |
| Subtract  | 215.7 μs | 0.54 μs | 0.50 μs |     144 B |
| Multiply  | 334.6 μs | 0.31 μs | 0.28 μs |     470 B |
