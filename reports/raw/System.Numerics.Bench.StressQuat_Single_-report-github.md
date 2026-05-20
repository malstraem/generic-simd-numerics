```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method    | Mean      | Error    | StdDev   | Code Size |
|---------- |----------:|---------:|---------:|----------:|
| Multiply  | 119.87 μs | 0.087 μs | 0.077 μs |     218 B |
| Divide    | 208.40 μs | 0.109 μs | 0.102 μs |     260 B |
| Conjugate |  48.20 μs | 0.080 μs | 0.075 μs |      85 B |
| Inverse   | 114.59 μs | 0.088 μs | 0.078 μs |     107 B |
