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
| Add             | 108.62 μs | 0.272 μs | 0.242 μs |     150 B |
| Subtract        | 108.45 μs | 0.307 μs | 0.272 μs |     150 B |
| Multiply        | 111.13 μs | 0.178 μs | 0.158 μs |     154 B |
| Divide          | 431.09 μs | 0.213 μs | 0.189 μs |     165 B |
| Abs             |  51.95 μs | 0.106 μs | 0.094 μs |      92 B |
| Dot             | 119.54 μs | 0.185 μs | 0.164 μs |     149 B |
| LengthSquared   | 122.64 μs | 0.506 μs | 0.449 μs |     137 B |
| DistanceSquared | 159.75 μs | 0.649 μs | 0.607 μs |     182 B |
| Transform       | 281.07 μs | 1.842 μs | 1.723 μs |     270 B |
