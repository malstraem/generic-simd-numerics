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
| Add             | 108.55 μs | 0.145 μs | 0.128 μs |     150 B |
| Subtract        | 108.48 μs | 0.314 μs | 0.294 μs |     150 B |
| Multiply        | 111.56 μs | 0.129 μs | 0.114 μs |     154 B |
| Divide          | 431.11 μs | 0.264 μs | 0.234 μs |     165 B |
| Sum             |  56.41 μs | 0.084 μs | 0.074 μs |      88 B |
| Dot             | 112.64 μs | 0.204 μs | 0.181 μs |     152 B |
| LengthSquared   | 136.87 μs | 0.421 μs | 0.394 μs |     113 B |
| DistanceSquared | 181.18 μs | 0.571 μs | 0.506 μs |     198 B |
| Transform       | 349.63 μs | 2.103 μs | 1.967 μs |     338 B |
