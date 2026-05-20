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
| Multiply  | 128.88 μs | 0.237 μs | 0.221 μs |     224 B |
| Divide    | 242.84 μs | 0.786 μs | 0.735 μs |     281 B |
| Conjugate |  62.76 μs | 0.171 μs | 0.152 μs |      88 B |
| Inverse   |  98.27 μs | 0.092 μs | 0.081 μs |     121 B |
