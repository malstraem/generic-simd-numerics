## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             |  30.39 μs | 0.540 μs | 0.505 μs |      78 B |
| Subtract        |  29.65 μs | 0.043 μs | 0.041 μs |      78 B |
| Multiply        |  29.69 μs | 0.035 μs | 0.031 μs |      78 B |
| Divide          |  56.71 μs | 0.076 μs | 0.071 μs |      78 B |
| Abs             |  26.01 μs | 0.020 μs | 0.015 μs |      68 B |
| Sum             |  32.23 μs | 0.074 μs | 0.070 μs |      76 B |
| Dot             |  45.82 μs | 0.085 μs | 0.079 μs |      96 B |
| LengthSquared   |  34.35 μs | 0.050 μs | 0.044 μs |      80 B |
| DistanceSquared |  56.87 μs | 0.057 μs | 0.051 μs |     100 B |
| Length          |  91.50 μs | 0.120 μs | 0.113 μs |      84 B |
| Distance        |  94.85 μs | 0.297 μs | 0.277 μs |     104 B |
| Normalize       | 151.66 μs | 0.294 μs | 0.275 μs |      89 B |
| Transform       |  65.64 μs | 0.133 μs | 0.124 μs |     129 B |

```assembly
; System.Numerics.Bench.StressVector4.Add()
       mov       rax,23B6F0015A0
       mov       rax,[rax]
       mov       rcx,23B6F0015A8
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,4
       vmovups   xmm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       vaddps    xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

```assembly
; System.Numerics.Bench.StressVector4.Subtract()
       mov       rax,1EB15001568
       mov       rax,[rax]
       mov       rcx,1EB15001570
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,4
       vmovups   xmm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       vsubps    xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

```assembly
; System.Numerics.Bench.StressVector4.Multiply()
       mov       rax,16930001568
       mov       rax,[rax]
       mov       rcx,16930001570
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,4
       vmovups   xmm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       vmulps    xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

```assembly
; System.Numerics.Bench.StressVector4.Divide()
       mov       rax,25504401568
       mov       rax,[rax]
       mov       rcx,25504401570
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,4
       vmovups   xmm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       vdivps    xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

```assembly
; System.Numerics.Bench.StressVector4.Abs()
       mov       rax,21B90C01568
       mov       rax,[rax]
       vbroadcastss xmm0,dword ptr [7FF9C99A2F24]
       mov       rcx,21B90C01570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
       xchg      ax,ax
M00_L00:
       vandps    xmm1,xmm0,[rax+rdx]
       vmovups   [rcx+rdx],xmm1
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 68
```

```assembly
; System.Numerics.Bench.StressVector4.Sum()
       mov       rax,2270DC01568
       mov       rax,[rax]
       mov       rcx,2270DC01578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 76
```

```assembly
; System.Numerics.Bench.StressVector4.Dot()
       xor       eax,eax
       mov       rcx,27CB6001568
       mov       rcx,[rcx]
       mov       rdx,27CB6001578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       vmovups   xmm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       vmulps    xmm0,xmm0,[rcx+r10+10]
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 96
```

```assembly
; System.Numerics.Bench.StressVector4.LengthSquared()
       mov       rax,24F48801568
       mov       rax,[rax]
       mov       rcx,24F48801578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 80
```

```assembly
; System.Numerics.Bench.StressVector4.DistanceSquared()
       xor       eax,eax
       mov       rcx,21420001568
       mov       rcx,[rcx]
       mov       rdx,21420001578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       vmovups   xmm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       vsubps    xmm0,xmm0,[rcx+r10+10]
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 100
```

```assembly
; System.Numerics.Bench.StressVector4.Length()
       mov       rax,1E0D7801568
       mov       rax,[rax]
       mov       rcx,1E0D7801578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 84
```

```assembly
; System.Numerics.Bench.StressVector4.Distance()
       xor       eax,eax
       mov       rcx,17B9B401568
       mov       rcx,[rcx]
       mov       rdx,17B9B401578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       vmovups   xmm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       vsubps    xmm0,xmm0,[rcx+r10+10]
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 104
```

```assembly
; System.Numerics.Bench.StressVector4.Normalize()
       mov       rax,18BAC001568
       mov       rax,[rax]
       mov       rcx,18BAC001570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx]
       vmulps    xmm1,xmm0,xmm0
       vpermilps xmm2,xmm1,0B1
       vaddps    xmm1,xmm2,xmm1
       vpermilps xmm2,xmm1,4E
       vaddps    xmm1,xmm2,xmm1
       vsqrtps   xmm1,xmm1
       vdivps    xmm0,xmm0,xmm1
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 89
```

```assembly
; System.Numerics.Bench.StressVector4.Transform()
       mov       rax,2B23D801568
       mov       rax,[rax]
       mov       rcx,2B23D801570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx]
       vunpckhps xmm1,xmm0,xmm0
       vbroadcastss xmm1,xmm1
       vmovshdup xmm2,xmm0
       vbroadcastss xmm2,xmm2
       vmovaps   xmm3,xmm0
       vbroadcastss xmm3,xmm3
       vmulps    xmm3,xmm3,[7FF9C9983390]
       vfmadd132ps xmm2,xmm3,[7FF9C99833A0]
       vfmadd132ps xmm1,xmm2,[7FF9C99833B0]
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd132ps xmm0,xmm1,[7FF9C99833C0]
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 129
```
