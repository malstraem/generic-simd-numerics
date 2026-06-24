```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method  | Mean     | Error    | StdDev   | Code Size |
|-------- |---------:|---------:|---------:|----------:|
| Convert | 54.10 μs | 0.782 μs | 0.732 μs |      86 B |
