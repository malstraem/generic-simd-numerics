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
| Add      |   868.6 μs | 1.11 μs | 1.04 μs |     739 B |
| Subtract |   872.5 μs | 1.54 μs | 1.44 μs |     739 B |
| Multiply | 5,236.9 μs | 3.03 μs | 2.53 μs |   1,940 B |
