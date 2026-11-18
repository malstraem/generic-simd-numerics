## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Length          | 164.38 μs | 0.099 μs | 0.082 μs |      87 B |
| Distance        | 168.63 μs | 0.370 μs | 0.346 μs |     107 B |
| Normalize       | 249.40 μs | 0.323 μs | 0.302 μs |      97 B |
| Add             |  54.92 μs | 0.060 μs | 0.056 μs |      81 B |
| Subtract        |  67.75 μs | 0.095 μs | 0.089 μs |      81 B |
| Multiply        |  55.24 μs | 0.087 μs | 0.081 μs |      81 B |
| Divide          |  88.88 μs | 0.341 μs | 0.319 μs |      81 B |
| Sum             |  33.45 μs | 0.067 μs | 0.062 μs |      79 B |
| Dot             |  57.95 μs | 0.054 μs | 0.051 μs |     106 B |
| LengthSquared   |  35.98 μs | 0.052 μs | 0.049 μs |      83 B |
| DistanceSquared |  57.83 μs | 0.076 μs | 0.071 μs |     110 B |
| Transform       |  77.60 μs | 0.173 μs | 0.162 μs |     145 B |

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Length()
       mov       rax,197DA801568
       mov       rax,[rax]
       mov       rcx,197DA801578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vmulpd    ymm0,ymm0,ymm0
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 87
```

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,2AC7A401568
       mov       rcx,[rcx]
       mov       rdx,2AC7A401578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       vmovups   ymm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,5
       vsubpd    ymm0,ymm0,[rcx+r10+10]
       vmulpd    ymm0,ymm0,ymm0
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 107
```

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Normalize()
       mov       rax,1F2D8801568
       mov       rax,[rax]
       mov       rcx,1F2D8801570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx]
       vmulpd    ymm1,ymm0,ymm0
       vpermilpd ymm2,ymm1,5
       vaddpd    ymm1,ymm2,ymm1
       vperm2f128 ymm2,ymm1,ymm1,1
       vaddpd    ymm1,ymm2,ymm1
       vsqrtsd   xmm1,xmm1,xmm1
       vbroadcastsd ymm1,xmm1
       vdivpd    ymm0,ymm0,ymm1
       vmovups   [rcx+rdx],ymm0
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 97
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Add()
       mov       rax,202C9801568
       mov       rax,[rax]
       mov       rcx,202C9801570
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,5
       vmovups   ymm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       vaddpd    ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Subtract()
       mov       rax,1F593001568
       mov       rax,[rax]
       mov       rcx,1F593001570
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,5
       vmovups   ymm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       vsubpd    ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Multiply()
       mov       rax,25D9E801568
       mov       rax,[rax]
       mov       rcx,25D9E801570
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,5
       vmovups   ymm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       vmulpd    ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Divide()
       mov       rax,1ED13801568
       mov       rax,[rax]
       mov       rcx,1ED13801570
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,5
       vmovups   ymm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       vdivpd    ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Sum()
       mov       rax,2518DC01568
       mov       rax,[rax]
       mov       rcx,2518DC01578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vpermilpd ymm1,ymm0,55
       vaddpd    ymm0,ymm1,ymm0
       vextractf128 xmm1,ymm0,1
       vaddpd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 79
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,1951C801568
       mov       rcx,[rcx]
       mov       rdx,1951C801578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,5
       vmovups   ymm0,[rcx+r9+10]
       vmovups   ymm1,[r10]
       vmulpd    ymm0,ymm1,ymm0
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 106
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].LengthSquared()
       mov       rax,140FF801568
       mov       rax,[rax]
       mov       rcx,140FF801578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vmulpd    ymm0,ymm0,ymm0
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 83
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,297C2C01568
       mov       rcx,[rcx]
       mov       rdx,297C2C01578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,5
       vmovups   ymm0,[rcx+r9+10]
       vmovups   ymm1,[r10]
       vsubpd    ymm0,ymm1,ymm0
       vmulpd    ymm0,ymm0,ymm0
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 110
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Transform()
       mov       rax,14D98001568
       mov       rax,[rax]
       mov       rcx,14D98001570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   ymm0,[r10]
       vmovaps   xmm1,xmm0
       vmovaps   xmm2,xmm1
       vbroadcastsd ymm2,xmm2
       vpermilpd xmm1,xmm1,1
       vperm2f128 ymm0,ymm0,ymm0,1
       vpermilpd xmm3,xmm0,1
       vbroadcastsd ymm3,xmm3
       vbroadcastsd ymm0,xmm0
       vbroadcastsd ymm1,xmm1
       vmulpd    ymm2,ymm2,[7FF9C99B3AE0]
       vfmadd132pd ymm1,ymm2,[7FF9C99B3B00]
       vfmadd132pd ymm0,ymm1,[7FF9C99B3B20]
       vfmadd231pd ymm0,ymm3,[7FF9C99B3B40]
       vmovups   [rcx+rdx],ymm0
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 145
```
