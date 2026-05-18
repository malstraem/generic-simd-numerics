prototype of generic linear algebraic objects using current state of
[System.Runtime.Intrinsics](https://learn.microsoft.com/ru-ru/dotnet/api/system.runtime.intrinsics?view=net-10.0) SIMD vectors

started as try to outperform [Silk.NET](https://github.com/dotnet/Silk.NET), especially on matrix operations with `double` precision

this is primarily for in-house engine, but possibly helpful draft for https://github.com/dotnet/runtime/issues/24168

next step is hardware accelerated ways for type conversions like `Vec4<int>` <-> `Vec4<float>` 🚧

> [!NOTE]
check [benchmark reports](./reports) for generated asm and timings

tested and benchmarked on AMD Ryzen 9 7900X that have</br></br>
`AVX512 - BITALG+VBMI2+VNNI+VPOPCNTDQ+IFMA+VBMI+F+BW+CD+DQ+VL`</br></br>
`AVX2 - BMI1+BMI2+F16C+FMA+LZCNT+MOVBE`</br></br>
`AVX+SSE3+SSSE3+SSE4.1+SSE4.2`
