```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Length          | 164.66 μs | 0.114 μs | 0.107 μs |     131 B |
| Distance        | 169.78 μs | 0.838 μs | 0.784 μs |     176 B |
| Normalize       | 519.78 μs | 0.416 μs | 0.325 μs |     149 B |
| Add             | 114.48 μs | 0.125 μs | 0.117 μs |     163 B |
| Subtract        | 114.41 μs | 0.213 μs | 0.189 μs |     163 B |
| Multiply        | 114.51 μs | 0.176 μs | 0.156 μs |     163 B |
| Divide          | 349.32 μs | 1.631 μs | 1.525 μs |     163 B |
| Abs             | 151.66 μs | 0.346 μs | 0.307 μs |     163 B |
| Dot             |  95.25 μs | 0.102 μs | 0.085 μs |     152 B |
| LengthSquared   |  65.44 μs | 0.236 μs | 0.209 μs |     127 B |
| DistanceSquared | 113.61 μs | 0.262 μs | 0.232 μs |     172 B |
| Transform       | 186.29 μs | 0.537 μs | 0.476 μs |     296 B |
