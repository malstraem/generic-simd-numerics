```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 11.0.100-preview.4.26230.115
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             | 125.79 μs | 0.167 μs | 0.156 μs |      81 B |
| Subtract        | 105.74 μs | 0.140 μs | 0.131 μs |      81 B |
| Multiply        |  92.37 μs | 0.202 μs | 0.158 μs |      85 B |
| Divide          | 981.31 μs | 1.931 μs | 1.806 μs |     415 B |
| Sum             |  55.76 μs | 0.118 μs | 0.111 μs |      86 B |
| Dot             |  63.05 μs | 0.079 μs | 0.066 μs |     109 B |
| LengthSquared   |  39.16 μs | 0.098 μs | 0.091 μs |      92 B |
| DistanceSquared |  69.70 μs | 0.152 μs | 0.142 μs |     122 B |
| Transform       | 128.77 μs | 0.192 μs | 0.180 μs |     186 B |
