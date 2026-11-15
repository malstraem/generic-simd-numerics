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
| Length          |  96.15 μs | 0.216 μs | 0.202 μs |     131 B |
| Distance        | 125.49 μs | 0.379 μs | 0.336 μs |     176 B |
| Normalize       | 319.00 μs | 0.177 μs | 0.166 μs |     149 B |
| Add             | 113.79 μs | 0.182 μs | 0.162 μs |     163 B |
| Subtract        |  99.01 μs | 0.153 μs | 0.143 μs |     163 B |
| Multiply        | 113.79 μs | 0.163 μs | 0.145 μs |     163 B |
| Divide          | 220.26 μs | 0.867 μs | 0.811 μs |     163 B |
| Abs             | 140.42 μs | 0.325 μs | 0.288 μs |     173 B |
| Dot             |  95.85 μs | 0.234 μs | 0.219 μs |     152 B |
| LengthSquared   |  64.74 μs | 0.581 μs | 0.544 μs |     127 B |
| DistanceSquared | 113.10 μs | 0.141 μs | 0.125 μs |     172 B |
| Transform       | 185.28 μs | 0.174 μs | 0.155 μs |     296 B |
