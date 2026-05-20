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
| Add             |  46.62 μs | 0.099 μs | 0.092 μs |      78 B |
| Subtract        |  29.12 μs | 0.066 μs | 0.062 μs |      78 B |
| Multiply        |  29.25 μs | 0.014 μs | 0.012 μs |      78 B |
| Divide          |  89.56 μs | 0.101 μs | 0.090 μs |     155 B |
| Sum             |  34.90 μs | 0.050 μs | 0.047 μs |      78 B |
| Dot             |  92.66 μs | 0.201 μs | 0.188 μs |      94 B |
| LengthSquared   |  74.46 μs | 0.134 μs | 0.125 μs |      71 B |
| DistanceSquared |  92.82 μs | 0.171 μs | 0.160 μs |      98 B |
| Transform       | 123.07 μs | 0.191 μs | 0.179 μs |     171 B |
