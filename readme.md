prototype of generic linear algebraic objects using current state of .NET System.Numerics SIMD vectors

focused to outperform [Silk.NET](https://github.com/dotnet/Silk.NET), especially on matrix operation with double precision

firstly this is for in-house engine, but possible draft for https://github.com/dotnet/runtime/issues/24168

> [!WARNING]
SIMD support check is currently dumb -> `sizeof` + `VectorXXX<T>.IsSupported`</br></br>
so make sure you have the necessary instruction sets to pass the tests and run benchmarks</br></br>
tested and benchmarked on AMD Ryzen 9 7900X that have</br></br>
`AVX512 - BITALG+VBMI2+VNNI+VPOPCNTDQ+IFMA+VBMI+F+BW+CD+DQ+VL`</br></br>
`AVX2 - BMI1+BMI2+F16C+FMA+LZCNT+MOVBE`</br></br>
`AVX+SSE3+SSSE3+SSE4.1+SSE4.2`
