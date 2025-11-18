```

BenchmarkDotNet v0.15.7, Windows 11 (10.0.26200.7171/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 7900X 4.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]    : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method                              | Mean       | Error    | StdDev   |
|------------------------------------ |-----------:|---------:|---------:|
| Silk.NET.Maths.Matrix4X4&lt;double&gt;    | 4,766.8 μs | 68.24 μs | 60.49 μs |
| Mat44&lt;double&gt;                       |   529.4 μs |  1.46 μs |  1.14 μs |
| &#39;System.Numerics.Matrix4x4 (float)&#39; |   364.4 μs |  0.55 μs |  0.49 μs |
| Mat44&lt;float&gt;                        |   499.2 μs |  0.60 μs |  0.53 μs |
