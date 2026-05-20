```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method          | Mean     | Error   | StdDev  | Median   | Code Size |
|---------------- |---------:|--------:|--------:|---------:|----------:|
| Add             | 118.4 μs | 0.26 μs | 0.24 μs | 118.3 μs |     136 B |
| Subtract        | 122.8 μs | 0.29 μs | 0.27 μs | 122.9 μs |     136 B |
| Multiply        | 138.1 μs | 0.82 μs | 0.77 μs | 138.3 μs |     140 B |
| Divide          | 501.2 μs | 0.93 μs | 0.87 μs | 501.3 μs |     173 B |
| Abs             | 119.2 μs | 0.27 μs | 0.24 μs | 119.1 μs |     141 B |
| Dot             | 108.5 μs | 2.10 μs | 2.66 μs | 106.7 μs |     136 B |
| LengthSquared   | 115.1 μs | 0.14 μs | 0.13 μs | 115.1 μs |     118 B |
| DistanceSquared | 149.3 μs | 0.16 μs | 0.15 μs | 149.4 μs |     148 B |
| Transform       | 194.9 μs | 0.32 μs | 0.30 μs | 194.9 μs |     210 B |
