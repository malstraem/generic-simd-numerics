```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method          | Mean     | Error   | StdDev  | Code Size |
|---------------- |---------:|--------:|--------:|----------:|
| Add             | 115.3 μs | 0.25 μs | 0.22 μs |     136 B |
| Subtract        | 102.7 μs | 0.22 μs | 0.20 μs |     136 B |
| Multiply        | 124.6 μs | 2.31 μs | 2.16 μs |     140 B |
| Divide          | 503.5 μs | 0.33 μs | 0.27 μs |     173 B |
| Abs             | 110.3 μs | 0.29 μs | 0.26 μs |     141 B |
| Dot             | 107.5 μs | 0.22 μs | 0.20 μs |     136 B |
| LengthSquared   | 115.3 μs | 0.12 μs | 0.09 μs |     118 B |
| DistanceSquared | 158.4 μs | 0.52 μs | 0.46 μs |     148 B |
| Transform       | 201.6 μs | 0.42 μs | 0.37 μs |     210 B |
