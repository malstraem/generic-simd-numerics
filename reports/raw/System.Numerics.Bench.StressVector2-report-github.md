```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.2.26159.112
  [Host]    : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method              | Mean      | Error    | StdDev   | Code Size |
|-------------------- |----------:|---------:|---------:|----------:|
| Add                 |  26.55 μs | 0.306 μs | 0.271 μs |      73 B |
| Subtract            |  26.42 μs | 0.034 μs | 0.028 μs |      73 B |
| MultiplyElementWise |  26.56 μs | 0.120 μs | 0.100 μs |      73 B |
| DivideElementWise   |  58.13 μs | 0.074 μs | 0.065 μs |      73 B |
| Abs                 |  20.03 μs | 0.046 μs | 0.041 μs |      72 B |
| Sum                 |  38.72 μs | 0.028 μs | 0.022 μs |      82 B |
| Dot                 |  98.46 μs | 0.065 μs | 0.054 μs |      87 B |
| LengthSquared       |  96.85 μs | 0.192 μs | 0.160 μs |      72 B |
| DistanceSquared     |  98.04 μs | 0.120 μs | 0.094 μs |      85 B |
| Length              |  96.68 μs | 0.020 μs | 0.017 μs |      76 B |
| Distance            |  98.23 μs | 0.056 μs | 0.049 μs |      89 B |
| Normalize           | 158.27 μs | 0.108 μs | 0.095 μs |      82 B |
