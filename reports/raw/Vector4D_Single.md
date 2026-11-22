## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             | 113.80 μs | 0.172 μs | 0.161 μs |     163 B |
| Subtract        | 113.95 μs | 0.198 μs | 0.185 μs |     163 B |
| Multiply        |  99.03 μs | 0.087 μs | 0.077 μs |     163 B |
| Divide          | 220.63 μs | 0.484 μs | 0.404 μs |     163 B |
| Abs             | 140.56 μs | 0.092 μs | 0.076 μs |     173 B |
| Dot             |  94.71 μs | 0.061 μs | 0.051 μs |     152 B |
| LengthSquared   |  66.67 μs | 1.264 μs | 1.405 μs |     127 B |
| DistanceSquared | 113.27 μs | 0.106 μs | 0.099 μs |     172 B |
| Transform       | 185.55 μs | 0.252 μs | 0.223 μs |     296 B |
| Length          |  96.14 μs | 0.184 μs | 0.172 μs |     131 B |
| Distance        | 124.79 μs | 0.199 μs | 0.186 μs |     176 B |
| Normalize       | 319.20 μs | 0.594 μs | 0.555 μs |     149 B |

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Add()
       mov       rax,2B2CB001568
       mov       rax,[rax]
       mov       rcx,2B2CB001570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vaddss    xmm0,xmm0,xmm4
       vaddss    xmm1,xmm1,xmm5
       vaddss    xmm2,xmm16,xmm2
       vaddss    xmm3,xmm17,xmm3
       lea       r8,[rcx+r8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       vmovss    dword ptr [r8+8],xmm2
       vmovss    dword ptr [r8+0C],xmm3
       cmp       edx,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Subtract()
       mov       rax,20434001568
       mov       rax,[rax]
       mov       rcx,20434001570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vsubss    xmm0,xmm0,xmm4
       vsubss    xmm1,xmm1,xmm5
       vsubss    xmm2,xmm2,xmm16
       vsubss    xmm3,xmm3,xmm17
       lea       r8,[rcx+r8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       vmovss    dword ptr [r8+8],xmm2
       vmovss    dword ptr [r8+0C],xmm3
       cmp       edx,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Multiply()
       mov       rax,1FD5A401568
       mov       rax,[rax]
       mov       rcx,1FD5A401570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vmulss    xmm0,xmm0,xmm4
       vmulss    xmm1,xmm1,xmm5
       vmulss    xmm2,xmm16,xmm2
       vmulss    xmm3,xmm17,xmm3
       lea       r8,[rcx+r8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       vmovss    dword ptr [r8+8],xmm2
       vmovss    dword ptr [r8+0C],xmm3
       cmp       edx,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Divide()
       mov       rax,28C6A001568
       mov       rax,[rax]
       mov       rcx,28C6A001570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vdivss    xmm0,xmm0,xmm4
       vdivss    xmm1,xmm1,xmm5
       vdivss    xmm2,xmm2,xmm16
       vdivss    xmm3,xmm3,xmm17
       lea       r8,[rcx+r8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       vmovss    dword ptr [r8+8],xmm2
       vmovss    dword ptr [r8+0C],xmm3
       cmp       edx,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Abs()
       mov       rax,1DBA9801568
       mov       rax,[rax]
       mov       rcx,1DBA9801570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       vmovd     r10d,xmm0
       and       r10d,7FFFFFFF
       vmovd     xmm0,r10d
       vmovd     r10d,xmm1
       and       r10d,7FFFFFFF
       vmovd     xmm1,r10d
       vmovd     r10d,xmm2
       and       r10d,7FFFFFFF
       vmovd     xmm2,r10d
       vmovd     r10d,xmm3
       and       r10d,7FFFFFFF
       vmovd     xmm3,r10d
       lea       r10,[rcx+rdx]
       vmovss    dword ptr [r10],xmm0
       vmovss    dword ptr [r10+4],xmm1
       vmovss    dword ptr [r10+8],xmm2
       vmovss    dword ptr [r10+0C],xmm3
       add       rdx,10
       dec       r8d
       jne       near ptr M00_L00
       ret
; Total bytes of code 173
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,168F5401568
       mov       rcx,[rcx]
       mov       rdx,168F5401578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vmulss    xmm0,xmm0,xmm4
       vmulss    xmm1,xmm1,xmm5
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm16,xmm2
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm17,xmm3
       vaddss    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 152
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].LengthSquared()
       mov       rax,1752E401568
       mov       rax,[rax]
       mov       rcx,1752E401578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovss    xmm0,dword ptr [r10]
       vmovaps   xmm1,xmm0
       vmovss    xmm2,dword ptr [r10+4]
       vmovaps   xmm3,xmm2
       vmovss    xmm4,dword ptr [r10+8]
       vmovaps   xmm5,xmm4
       vmovss    xmm16,dword ptr [r10+0C]
       vmovaps   xmm17,xmm16
       vmulss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,xmm2
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm5,xmm4
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm17,xmm16
       vaddss    xmm0,xmm1,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 127
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,18ADA401568
       mov       rcx,[rcx]
       mov       rdx,18ADA401578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vsubss    xmm0,xmm0,xmm4
       vsubss    xmm1,xmm1,xmm5
       vsubss    xmm2,xmm2,xmm16
       vsubss    xmm3,xmm3,xmm17
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm2,xmm2
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,xmm3
       vaddss    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 172
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Transform()
       mov       rax,2998A801568
       mov       rax,[rax]
       mov       rcx,2998A801570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       vmulss    xmm4,xmm1,dword ptr [7FF9C99C2FC8]
       vaddss    xmm4,xmm4,xmm0
       vmulss    xmm5,xmm2,dword ptr [7FF9C99C2FCC]
       vaddss    xmm4,xmm5,xmm4
       vmulss    xmm5,xmm3,dword ptr [7FF9C99C2FD0]
       vaddss    xmm4,xmm5,xmm4
       vaddss    xmm5,xmm0,xmm0
       vmulss    xmm16,xmm1,dword ptr [7FF9C99C2FD4]
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm2,dword ptr [7FF9C99C2FD8]
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm3,dword ptr [7FF9C99C2FDC]
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm0,dword ptr [7FF9C99C2FE0]
       vmulss    xmm17,xmm1,dword ptr [7FF9C99C2FE4]
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm17,xmm2,dword ptr [7FF9C99C2FE8]
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm17,xmm3,dword ptr [7FF9C99C2FEC]
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm0,xmm0,dword ptr [7FF9C99C2FF0]
       vmulss    xmm1,xmm1,dword ptr [7FF9C99C2FF4]
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm2,dword ptr [7FF9C99C2FF8]
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,dword ptr [7FF9C99C2FFC]
       vaddss    xmm0,xmm1,xmm0
       lea       r10,[rcx+rdx]
       vmovss    dword ptr [r10],xmm4
       vmovss    dword ptr [r10+4],xmm5
       vmovss    dword ptr [r10+8],xmm16
       vmovss    dword ptr [r10+0C],xmm0
       add       rdx,10
       dec       r8d
       jne       near ptr M00_L00
       ret
; Total bytes of code 296
```

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Single, System.Private.CoreLib]].Length()
       mov       rax,272BE801568
       mov       rax,[rax]
       mov       rcx,272BE801578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovss    xmm0,dword ptr [r10]
       vmovaps   xmm1,xmm0
       vmovss    xmm2,dword ptr [r10+4]
       vmovaps   xmm3,xmm2
       vmovss    xmm4,dword ptr [r10+8]
       vmovaps   xmm5,xmm4
       vmovss    xmm16,dword ptr [r10+0C]
       vmovaps   xmm17,xmm16
       vmulss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,xmm2
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm5,xmm4
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm17,xmm16
       vaddss    xmm0,xmm1,xmm0
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 131
```

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Single, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,2B7BAC01568
       mov       rcx,[rcx]
       mov       rdx,2B7BAC01578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vsubss    xmm0,xmm0,xmm4
       vsubss    xmm1,xmm1,xmm5
       vsubss    xmm2,xmm2,xmm16
       vsubss    xmm3,xmm3,xmm17
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm2,xmm2
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,xmm3
       vaddss    xmm0,xmm1,xmm0
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 176
```

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Single, System.Private.CoreLib]].Normalize()
       mov       rax,1ACF2801568
       mov       rax,[rax]
       mov       rcx,1ACF2801570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       vmulss    xmm4,xmm0,xmm0
       vmulss    xmm5,xmm1,xmm1
       vaddss    xmm4,xmm5,xmm4
       vmulss    xmm5,xmm2,xmm2
       vaddss    xmm4,xmm5,xmm4
       vmulss    xmm5,xmm3,xmm3
       vaddss    xmm4,xmm5,xmm4
       vsqrtss   xmm4,xmm4,xmm4
       vdivss    xmm0,xmm0,xmm4
       vdivss    xmm1,xmm1,xmm4
       vdivss    xmm2,xmm2,xmm4
       vdivss    xmm3,xmm3,xmm4
       lea       r10,[rcx+rdx]
       vmovss    dword ptr [r10],xmm0
       vmovss    dword ptr [r10+4],xmm1
       vmovss    dword ptr [r10+8],xmm2
       vmovss    dword ptr [r10+0C],xmm3
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 149
```
