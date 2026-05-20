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
| Length          |  95.30 μs | 0.151 μs | 0.141 μs |     131 B |
| Distance        | 124.74 μs | 0.152 μs | 0.142 μs |     176 B |
| Normalize       | 320.93 μs | 2.103 μs | 1.967 μs |     149 B |
| Add             | 113.21 μs | 0.092 μs | 0.086 μs |     163 B |
| Subtract        | 113.23 μs | 0.145 μs | 0.136 μs |     163 B |
| Multiply        | 113.13 μs | 0.261 μs | 0.231 μs |     163 B |
| Divide          | 218.93 μs | 0.295 μs | 0.276 μs |     163 B |
| Abs             | 139.57 μs | 0.142 μs | 0.125 μs |     173 B |
| Dot             |  94.74 μs | 0.229 μs | 0.214 μs |     152 B |
| LengthSquared   |  64.23 μs | 0.704 μs | 0.658 μs |     127 B |
| DistanceSquared | 112.48 μs | 0.112 μs | 0.094 μs |     172 B |
| Transform       | 184.54 μs | 0.064 μs | 0.060 μs |     296 B |
