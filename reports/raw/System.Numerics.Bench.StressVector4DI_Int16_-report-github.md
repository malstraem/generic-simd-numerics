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
| Add             | 133.9 μs | 0.61 μs | 0.54 μs |     155 B |
| Subtract        | 134.3 μs | 0.44 μs | 0.39 μs |     155 B |
| Multiply        | 138.1 μs | 0.47 μs | 0.41 μs |     159 B |
| Divide          | 431.2 μs | 0.26 μs | 0.22 μs |     165 B |
| Abs             | 180.8 μs | 0.39 μs | 0.34 μs |     204 B |
| Dot             | 183.0 μs | 1.28 μs | 1.19 μs |     150 B |
| LengthSquared   | 167.0 μs | 1.23 μs | 1.15 μs |     141 B |
| DistanceSquared | 231.6 μs | 0.84 μs | 0.79 μs |     183 B |
| Transform       | 286.7 μs | 1.19 μs | 1.06 μs |     274 B |
