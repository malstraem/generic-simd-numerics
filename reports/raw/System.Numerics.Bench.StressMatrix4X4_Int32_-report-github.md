```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method   | Mean       | Error   | StdDev  | Code Size |
|--------- |-----------:|--------:|--------:|----------:|
| Add      |   844.9 μs | 0.99 μs | 0.92 μs |     664 B |
| Subtract |   845.7 μs | 1.08 μs | 1.01 μs |     664 B |
| Multiply | 4,515.1 μs | 5.10 μs | 4.26 μs |   1,711 B |
