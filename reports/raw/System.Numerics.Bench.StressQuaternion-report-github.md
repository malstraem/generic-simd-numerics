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
| Multiply  | 113.46 μs | 0.193 μs | 0.181 μs |     243 B |
| Divide    | 207.99 μs | 0.230 μs | 0.192 μs |     319 B |
| Conjugate |  42.49 μs | 0.110 μs | 0.103 μs |      79 B |
| Inverse   | 114.18 μs | 0.120 μs | 0.112 μs |     111 B |
