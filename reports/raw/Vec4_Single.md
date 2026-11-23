## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.10075)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error     | StdDev    | Code Size |
|---------------- |----------:|----------:|----------:|----------:|
| Add             |  29.59 μs |  0.029 μs |  0.025 μs |      78 B |
| Subtract        |  29.70 μs |  0.043 μs |  0.036 μs |      78 B |
| Multiply        |  32.09 μs |  0.302 μs |  0.283 μs |      78 B |
| Divide          |  56.60 μs |  0.089 μs |  0.084 μs |      78 B |
| Abs             |  26.05 μs |  0.108 μs |  0.090 μs |      68 B |
| Sum             |  32.15 μs |  0.047 μs |  0.044 μs |      76 B |
| Dot             |  57.02 μs |  0.058 μs |  0.054 μs |     103 B |
| LengthSquared   |  37.15 μs |  0.738 μs |  1.059 μs |      80 B |
| DistanceSquared |  58.61 μs |  0.916 μs |  0.856 μs |     107 B |
| Transform       |  66.14 μs |  0.130 μs |  0.121 μs |     134 B |
| Length          |  91.44 μs |  0.049 μs |  0.038 μs |      84 B |
| Distance        |  95.26 μs |  0.656 μs |  0.581 μs |     104 B |
| Normalize       | 151.69 μs |  0.205 μs |  0.181 μs |      89 B |
| Sin             | 611.50 μs | 11.415 μs | 16.371 μs |     699 B |
| Cos             | 553.37 μs | 10.809 μs |  9.582 μs |     728 B |

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Add()
       mov       rax,2401A801568
       mov       rax,[rax]
       mov       rcx,2401A801570
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Subtract()
       mov       rax,245BD401568
       mov       rax,[rax]
       mov       rcx,245BD401570
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Multiply()
       mov       rax,25729401568
       mov       rax,[rax]
       mov       rcx,25729401570
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Divide()
       mov       rax,26E6D001568
       mov       rax,[rax]
       mov       rcx,26E6D001570
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
; System.Numerics.Bench.StressSignedVec4`1[[System.Single, System.Private.CoreLib]].Abs()
       mov       rax,2C3B4800BD0
       mov       rax,[rax]
       vbroadcastss xmm0,dword ptr [7FF985E0CF04]
       mov       rcx,2C3B4800BD8
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Sum()
       mov       rax,1E022001568
       mov       rax,[rax]
       mov       rcx,1E022001578
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,1B63EC01568
       mov       rcx,[rcx]
       mov       rdx,1B63EC01578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       vmovups   xmm0,[rcx+r9+10]
       vmovups   xmm1,[r10]
       vmulps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 103
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].LengthSquared()
       mov       rax,2D003401568
       mov       rax,[rax]
       mov       rcx,2D003401578
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,21145401568
       mov       rcx,[rcx]
       mov       rdx,21145401578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       vmovups   xmm0,[rcx+r9+10]
       vmovups   xmm1,[r10]
       vsubps    xmm0,xmm1,xmm0
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 107
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Transform()
       mov       rax,2D228801568
       mov       rax,[rax]
       mov       rcx,2D228801570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   xmm0,[r10]
       vmovaps   xmm1,xmm0
       vbroadcastss xmm1,xmm1
       vmovshdup xmm2,xmm0
       vpermilpd xmm3,xmm2,1
       vbroadcastss xmm3,xmm3
       vunpckhps xmm0,xmm0,xmm0
       vbroadcastss xmm0,xmm0
       vbroadcastss xmm2,xmm2
       vmulps    xmm1,xmm1,[7FF9C99939D0]
       vfmadd231ps xmm1,xmm2,[7FF9C99939E0]
       vfmadd132ps xmm0,xmm1,[7FF9C99939F0]
       vfmadd231ps xmm0,xmm3,[7FF9C9993A00]
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 134
```

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Single, System.Private.CoreLib]].Length()
       mov       rax,29454001568
       mov       rax,[rax]
       mov       rcx,29454001578
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
; System.Numerics.Bench.StressVec4`1[[System.Single, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,20929401568
       mov       rcx,[rcx]
       mov       rdx,20929401578
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
; System.Numerics.Bench.StressVec4`1[[System.Single, System.Private.CoreLib]].Normalize()
       mov       rax,225A9001568
       mov       rax,[rax]
       mov       rcx,225A9001570
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
