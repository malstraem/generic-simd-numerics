```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method    | Mean       | Error   | StdDev  | Code Size |
|---------- |-----------:|--------:|--------:|----------:|
| Rotation  | 1,075.3 μs | 4.97 μs | 4.41 μs |     409 B |
| Transform |   932.0 μs | 3.36 μs | 2.98 μs |     921 B |
| Affine    | 5,077.7 μs | 6.37 μs | 5.96 μs |   2,883 B |
| Add       |   491.2 μs | 0.44 μs | 0.41 μs |     649 B |
| Subtract  |   489.6 μs | 1.24 μs | 1.09 μs |     649 B |
| Multiply  | 4,634.5 μs | 9.82 μs | 9.19 μs |   2,068 B |
