```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             |  98.99 μs | 0.336 μs | 0.315 μs |     133 B |
| Subtract        |  98.70 μs | 0.180 μs | 0.150 μs |     133 B |
| Multiply        | 118.46 μs | 2.317 μs | 2.168 μs |     137 B |
| Divide          | 429.55 μs | 0.389 μs | 0.364 μs |     154 B |
| Abs             | 112.70 μs | 0.063 μs | 0.059 μs |     146 B |
| Dot             | 108.22 μs | 2.146 μs | 2.865 μs |     133 B |
| LengthSquared   | 113.81 μs | 0.084 μs | 0.079 μs |     114 B |
| DistanceSquared | 148.68 μs | 0.184 μs | 0.172 μs |     144 B |
| Transform       | 187.75 μs | 0.274 μs | 0.257 μs |     203 B |
