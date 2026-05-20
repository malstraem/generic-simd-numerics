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
| Length          | 164.68 μs | 0.122 μs | 0.108 μs |     131 B |
| Distance        | 166.91 μs | 0.134 μs | 0.126 μs |     176 B |
| Normalize       | 520.10 μs | 0.649 μs | 0.576 μs |     149 B |
| Add             | 133.17 μs | 1.011 μs | 0.896 μs |     163 B |
| Subtract        | 121.85 μs | 0.292 μs | 0.259 μs |     163 B |
| Multiply        | 114.04 μs | 0.190 μs | 0.178 μs |     163 B |
| Divide          | 352.00 μs | 0.558 μs | 0.522 μs |     163 B |
| Abs             | 146.97 μs | 0.314 μs | 0.293 μs |     163 B |
| Dot             |  94.77 μs | 0.105 μs | 0.094 μs |     152 B |
| LengthSquared   |  65.00 μs | 0.056 μs | 0.047 μs |     127 B |
| DistanceSquared | 116.04 μs | 0.067 μs | 0.063 μs |     172 B |
| Transform       | 184.09 μs | 0.214 μs | 0.190 μs |     296 B |
