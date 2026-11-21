## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.10075)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Length          | 166.38 μs | 2.338 μs | 2.187 μs |      74 B |
| Distance        | 171.74 μs | 3.389 μs | 3.766 μs |      98 B |
| Normalize       | 249.76 μs | 2.040 μs | 1.809 μs |      79 B |
| Sin             | 801.60 μs | 4.416 μs | 3.688 μs |     152 B |
| Cos             | 937.77 μs | 6.237 μs | 5.208 μs |     152 B |
| Add             |  67.35 μs | 0.889 μs | 0.832 μs |     109 B |
| Subtract        |  33.50 μs | 0.214 μs | 0.190 μs |      82 B |
| Multiply        |  33.75 μs | 0.331 μs | 0.310 μs |      82 B |
| Divide          |  86.31 μs | 0.526 μs | 0.492 μs |      82 B |
| Sum             |  23.36 μs | 0.298 μs | 0.278 μs |      80 B |
| Dot             |  49.42 μs | 0.286 μs | 0.254 μs |      97 B |
| LengthSquared   |  24.23 μs | 0.176 μs | 0.156 μs |      70 B |
| DistanceSquared |  54.01 μs | 0.453 μs | 0.402 μs |      97 B |

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Double, System.Private.CoreLib]].Length()
       mov       rax,26DE5400BB8
       mov       rax,[rax]
       mov       rcx,26DE5400C48
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*2+10]
       vmulpd    xmm0,xmm0,xmm0
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 74
```

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Double, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,234F8400BC8
       mov       rcx,[rcx]
       mov       rdx,234F8400BE8
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       vmovups   xmm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       vmovups   xmm1,[rcx+r10+10]
       vsubpd    xmm0,xmm0,xmm1
       vmulpd    xmm0,xmm0,xmm0
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 98
```

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Double, System.Private.CoreLib]].Normalize()
       mov       rax,24D3C800BB8
       mov       rax,[rax]
       mov       rcx,24D3C800BC0
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx]
       vmulpd    xmm1,xmm0,xmm0
       vpermilpd xmm2,xmm1,1
       vaddpd    xmm1,xmm2,xmm1
       vsqrtpd   xmm1,xmm1
       vdivpd    xmm0,xmm0,xmm1
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 79
```

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Double, System.Private.CoreLib]].Sin()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       vmovaps   [rsp+20],xmm7
       mov       rax,1B1C9C00BC8
       mov       rbx,[rax]
       mov       rax,1B1C9C00BD0
       mov       rsi,[rax]
       mov       edi,10
       mov       ebp,186A0
M00_L00:
       lea       rax,[rbx+rdi]
       vmovsd    xmm0,qword ptr [rax]
       vmovsd    xmm6,qword ptr [rax+8]
       call      qword ptr [7FF8EBBFD728]; System.Double.Sin(Double)
       vmovaps   xmm7,xmm0
       vmovaps   xmm0,xmm6
       call      qword ptr [7FF8EBBFD728]; System.Double.Sin(Double)
       lea       rax,[rsi+rdi]
       vmovsd    qword ptr [rax],xmm7
       vmovsd    qword ptr [rax+8],xmm0
       add       rdi,10
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
; System.Double.Sin(Double)
       sub       rsp,28
       vzeroupper
       call      00007FF94B1843E0
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Double, System.Private.CoreLib]].Cos()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       vmovaps   [rsp+20],xmm7
       mov       rax,27F52C00BC8
       mov       rbx,[rax]
       mov       rax,27F52C00BD0
       mov       rsi,[rax]
       mov       edi,10
       mov       ebp,186A0
M00_L00:
       lea       rax,[rbx+rdi]
       vmovsd    xmm0,qword ptr [rax]
       vmovsd    xmm6,qword ptr [rax+8]
       call      qword ptr [7FF8EBC1D938]; System.Double.Cos(Double)
       vmovaps   xmm7,xmm0
       vmovaps   xmm0,xmm6
       call      qword ptr [7FF8EBC1D938]; System.Double.Cos(Double)
       lea       rax,[rsi+rdi]
       vmovsd    qword ptr [rax],xmm7
       vmovsd    qword ptr [rax+8],xmm0
       add       rdi,10
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
; System.Double.Cos(Double)
       sub       rsp,28
       vzeroupper
       call      00007FF94B184320
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Double, System.Private.CoreLib]].Add()
       mov       rax,17D64400BC8
       mov       rax,[rax]
       mov       rcx,17D64400BD0
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovsd    xmm2,qword ptr [r10]
       vmovsd    xmm3,qword ptr [r10+8]
       vaddsd    xmm0,xmm0,xmm2
       vaddsd    xmm1,xmm1,xmm3
       lea       r8,[rcx+r8+10]
       vmovsd    qword ptr [r8],xmm0
       vmovsd    qword ptr [r8+8],xmm1
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 109
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Double, System.Private.CoreLib]].Subtract()
       mov       rax,1AF98C00BC8
       mov       rax,[rax]
       mov       rcx,1AF98C00BD0
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
       vmovups   xmm1,[rax+r10+10]
       vsubpd    xmm0,xmm0,xmm1
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 82
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Double, System.Private.CoreLib]].Multiply()
       mov       rax,2064C000BC8
       mov       rax,[rax]
       mov       rcx,2064C000BD0
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
       vmovups   xmm1,[rax+r10+10]
       vmulpd    xmm0,xmm0,xmm1
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 82
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Double, System.Private.CoreLib]].Divide()
       mov       rax,1D08D000BB8
       mov       rax,[rax]
       mov       rcx,1D08D000BC0
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
       vmovups   xmm1,[rax+r10+10]
       vdivpd    xmm0,xmm0,xmm1
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 82
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Double, System.Private.CoreLib]].Sum()
       mov       rax,17D0BC00BC8
       mov       rax,[rax]
       mov       rcx,17D0BC00BE8
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       vmovups   xmm0,[rax+rdx*2+10]
       vpermilpd xmm1,xmm0,55
       vaddpd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 80
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Double, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,27078400BC8
       mov       rcx,[rcx]
       mov       rdx,27078400BE8
       mov       rdx,[rdx]
       nop       dword ptr [rax]
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
       vmulpd    xmm0,xmm1,xmm0
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 97
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Double, System.Private.CoreLib]].LengthSquared()
       mov       rax,1F772800BC8
       mov       rax,[rax]
       mov       rcx,1F772800BE8
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*2+10]
       vmulpd    xmm0,xmm0,xmm0
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 70
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Double, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,24423000BC8
       mov       rcx,[rcx]
       mov       rdx,24423000BE8
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
       vsubpd    xmm0,xmm1,xmm0
       vmulpd    xmm0,xmm0,xmm0
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 97
```
