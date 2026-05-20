```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method   | Mean     | Error   | StdDev  | Code Size |
|--------- |---------:|--------:|--------:|----------:|
| Add      | 262.1 μs | 0.41 μs | 0.38 μs |     144 B |
| Subtract | 264.7 μs | 0.84 μs | 0.75 μs |     144 B |
| Multiply | 537.9 μs | 1.13 μs | 1.06 μs |     618 B |
