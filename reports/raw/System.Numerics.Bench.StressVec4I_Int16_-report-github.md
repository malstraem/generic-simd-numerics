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
| Add             | 134.28 μs | 0.405 μs | 0.359 μs |     155 B |
| Subtract        | 134.45 μs | 0.556 μs | 0.493 μs |     155 B |
| Multiply        | 138.00 μs | 0.507 μs | 0.474 μs |     159 B |
| Divide          | 431.32 μs | 0.401 μs | 0.335 μs |     165 B |
| Sum             |  67.68 μs | 0.155 μs | 0.138 μs |      89 B |
| Dot             | 183.21 μs | 0.673 μs | 0.629 μs |     154 B |
| LengthSquared   | 158.50 μs | 0.616 μs | 0.576 μs |     120 B |
| DistanceSquared | 244.42 μs | 0.959 μs | 0.897 μs |     200 B |
| Transform       | 346.44 μs | 0.632 μs | 0.560 μs |     344 B |
