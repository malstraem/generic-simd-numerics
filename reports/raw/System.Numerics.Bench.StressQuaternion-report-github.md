```

BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31.15 GB Total, 22.76 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  

```
| Method    | Mean      | Error    | StdDev   | Code Size |
|---------- |----------:|---------:|---------:|----------:|
| Multiply  | 114.25 μs | 0.171 μs | 0.160 μs |     243 B |
| Divide    | 201.10 μs | 0.481 μs | 0.427 μs |     333 B |
| Conjugate |  42.67 μs | 0.130 μs | 0.116 μs |      79 B |
| Inverse   |  70.67 μs | 0.225 μs | 0.199 μs |     129 B |
