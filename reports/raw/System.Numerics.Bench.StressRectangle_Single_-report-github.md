```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method   | Mean      | Error    | StdDev   | Code Size |
|--------- |----------:|---------:|---------:|----------:|
| Contains | 136.06 μs | 0.290 μs | 0.257 μs |     192 B |
| Area     |  26.18 μs | 0.295 μs | 0.276 μs |      71 B |
