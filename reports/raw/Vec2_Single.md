## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Length          |  91.92 μs | 0.237 μs | 0.198 μs |      82 B |
| Distance        |  95.23 μs | 0.119 μs | 0.099 μs |     107 B |
| Normalize       | 208.59 μs | 1.407 μs | 1.316 μs |     101 B |
| Sin             | 674.80 μs | 3.368 μs | 3.150 μs |     152 B |
| Cos             | 656.55 μs | 2.664 μs | 2.492 μs |     152 B |
| Add             |  77.14 μs | 0.282 μs | 0.264 μs |     104 B |
| Subtract        |  57.52 μs | 0.180 μs | 0.150 μs |     100 B |
| Multiply        |  57.42 μs | 0.299 μs | 0.280 μs |     100 B |
| Divide          | 111.67 μs | 0.256 μs | 0.227 μs |     100 B |
| Sum             |  25.70 μs | 0.099 μs | 0.092 μs |      70 B |
| Dot             |  57.06 μs | 0.117 μs | 0.104 μs |      95 B |
| LengthSquared   |  32.98 μs | 0.165 μs | 0.154 μs |      78 B |
| DistanceSquared |  75.60 μs | 0.207 μs | 0.194 μs |     103 B |

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Single, System.Private.CoreLib]].Length()
       mov       rax,2B691C00BB8
       mov       rax,[rax]
       mov       rcx,2B691C00C48
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm0,xmm1
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 82
```

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Single, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,1C606800BC8
       mov       rcx,[rcx]
       mov       rdx,1C606800BE8
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       inc       eax
       mov       r10d,eax
       lea       r10,[rcx+r10*8+10]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vsubss    xmm0,xmm0,xmm2
       vsubss    xmm1,xmm1,xmm3
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm0,xmm1
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 107
```

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Single, System.Private.CoreLib]].Normalize()
       mov       rax,20C9A400BB8
       mov       rax,[rax]
       mov       rcx,20C9A400BC0
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmulss    xmm2,xmm0,xmm0
       vmulss    xmm3,xmm1,xmm1
       vaddss    xmm2,xmm2,xmm3
       vsqrtss   xmm2,xmm2,xmm2
       vdivss    xmm0,xmm0,xmm2
       vdivss    xmm1,xmm1,xmm2
       lea       r10,[rcx+rdx]
       vmovss    dword ptr [r10],xmm0
       vmovss    dword ptr [r10+4],xmm1
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 101
```

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Single, System.Private.CoreLib]].Sin()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       vmovaps   [rsp+20],xmm7
       mov       rax,23BA5800BC8
       mov       rbx,[rax]
       mov       rax,23BA5800BD0
       mov       rsi,[rax]
       mov       edi,10
       mov       ebp,186A0
M00_L00:
       lea       rax,[rbx+rdi]
       vmovss    xmm0,dword ptr [rax]
       vmovss    xmm6,dword ptr [rax+4]
       call      qword ptr [7FF8EBC3D7B8]; System.Single.Sin(Single)
       vmovaps   xmm7,xmm0
       vmovaps   xmm0,xmm6
       call      qword ptr [7FF8EBC3D7B8]; System.Single.Sin(Single)
       lea       rax,[rsi+rdi]
       vmovss    dword ptr [rax],xmm7
       vmovss    dword ptr [rax+4],xmm0
       add       rdi,8
       dec       ebp
       jne       short M00_L00
       vmovaps   xmm6,[rsp+30]
       vmovaps   xmm7,[rsp+20]
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 134
```
```assembly
; System.Single.Sin(Single)
       sub       rsp,28
       vzeroupper
       call      00007FF94B184570
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Single, System.Private.CoreLib]].Cos()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       vmovaps   [rsp+20],xmm7
       mov       rax,1E3DC800BC8
       mov       rbx,[rax]
       mov       rax,1E3DC800BD0
       mov       rsi,[rax]
       mov       edi,10
       mov       ebp,186A0
M00_L00:
       lea       rax,[rbx+rdi]
       vmovss    xmm0,dword ptr [rax]
       vmovss    xmm6,dword ptr [rax+4]
       call      qword ptr [7FF8EBC2D740]; System.Single.Cos(Single)
       vmovaps   xmm7,xmm0
       vmovaps   xmm0,xmm6
       call      qword ptr [7FF8EBC2D740]; System.Single.Cos(Single)
       lea       rax,[rsi+rdi]
       vmovss    dword ptr [rax],xmm7
       vmovss    dword ptr [rax+4],xmm0
       add       rdi,8
       dec       ebp
       jne       short M00_L00
       vmovaps   xmm6,[rsp+30]
       vmovaps   xmm7,[rsp+20]
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 134
```
```assembly
; System.Single.Cos(Single)
       sub       rsp,28
       vzeroupper
       call      00007FF94B1844C0
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Single, System.Private.CoreLib]].Add()
       sub       rsp,18
       xor       eax,eax
       mov       rcx,24B2C000BC8
       mov       rcx,[rcx]
       mov       rdx,24B2C000BD0
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+10],r10
       inc       eax
       mov       r10d,eax
       mov       r10,[rcx+r10*8+10]
       mov       [rsp+8],r10
       vmovsd    xmm0,qword ptr [rsp+10]
       vmovsd    xmm1,qword ptr [rsp+8]
       vaddps    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rsp+10],xmm0
       mov       r10,[rsp+10]
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       add       rsp,18
       ret
; Total bytes of code 104
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Single, System.Private.CoreLib]].Subtract()
       xor       eax,eax
       mov       rcx,21A8D400BB8
       mov       rcx,[rcx]
       mov       rdx,21A8D400BC0
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       inc       eax
       mov       r10d,eax
       lea       r10,[rcx+r10*8+10]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vsubss    xmm0,xmm0,xmm2
       vsubss    xmm1,xmm1,xmm3
       lea       r8,[rdx+r8*8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 100
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Single, System.Private.CoreLib]].Multiply()
       xor       eax,eax
       mov       rcx,2318D000BB8
       mov       rcx,[rcx]
       mov       rdx,2318D000BC0
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       inc       eax
       mov       r10d,eax
       lea       r10,[rcx+r10*8+10]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vmulss    xmm0,xmm0,xmm2
       vmulss    xmm1,xmm1,xmm3
       lea       r8,[rdx+r8*8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 100
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Single, System.Private.CoreLib]].Divide()
       xor       eax,eax
       mov       rcx,23DC4000BB8
       mov       rcx,[rcx]
       mov       rdx,23DC4000BC0
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       inc       eax
       mov       r10d,eax
       lea       r10,[rcx+r10*8+10]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vdivss    xmm0,xmm0,xmm2
       vdivss    xmm1,xmm1,xmm3
       lea       r8,[rdx+r8*8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 100
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Single, System.Private.CoreLib]].Sum()
       mov       rax,20073C00BC8
       mov       rax,[rax]
       mov       rcx,20073C00BE8
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vaddss    xmm0,xmm0,xmm1
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 70
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Single, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,23124400BC8
       mov       rcx,[rcx]
       mov       rdx,23124400BE8
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       inc       eax
       mov       r9d,eax
       lea       r9,[rcx+r9*8+10]
       vmovss    xmm0,dword ptr [r9]
       vmovss    xmm1,dword ptr [r9+4]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vmulss    xmm0,xmm2,xmm0
       vmulss    xmm1,xmm3,xmm1
       vaddss    xmm0,xmm0,xmm1
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 95
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Single, System.Private.CoreLib]].LengthSquared()
       mov       rax,27FC2400BC8
       mov       rax,[rax]
       mov       rcx,27FC2400BE8
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm0,xmm1
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 78
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Single, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,2215F400BB8
       mov       rcx,[rcx]
       mov       rdx,2215F400BE8
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       inc       eax
       mov       r9d,eax
       lea       r9,[rcx+r9*8+10]
       vmovss    xmm0,dword ptr [r9]
       vmovss    xmm1,dword ptr [r9+4]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vsubss    xmm0,xmm2,xmm0
       vsubss    xmm1,xmm3,xmm1
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm0,xmm1
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 103
```
