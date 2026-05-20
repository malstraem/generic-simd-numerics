```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method   | Mean      | Error    | StdDev   | Code Size |
|--------- |----------:|---------:|---------:|----------:|
| Contains | 136.98 μs | 0.142 μs | 0.133 μs |     192 B |
| Area     |  26.06 μs | 0.167 μs | 0.156 μs |      71 B |
