## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method     | Mean     | Error    | StdDev   | Code Size |
|----------- |---------:|---------:|---------:|----------:|
| Intersects | 64.85 μs | 0.189 μs | 0.177 μs |     123 B |
| Contains   | 65.88 μs | 0.168 μs | 0.149 μs |     118 B |
| Area       | 27.77 μs | 0.093 μs | 0.087 μs |      74 B |

```assembly
; System.Numerics.Bench.StressRect`1[[System.Single, System.Private.CoreLib]].Intersects()
       xor       eax,eax
       mov       rcx,16F32000BB8
       mov       rcx,[rcx]
       mov       rdx,16F32000BC0
       mov       rdx,[rdx]
       mov       r8,16F243D3080
       vmovups   xmm0,[r8]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       vmovups   xmm1,[rcx+r9+10]
       vmovups   xmm2,[r10]
       vpshufd   xmm2,xmm2,4E
       vmulps    xmm2,xmm2,xmm0
       vmulps    xmm1,xmm0,xmm1
       vcmpleps  xmm1,xmm2,xmm1
       vpcmpeqd  xmm2,xmm2,xmm2
       vptest    xmm1,xmm2
       setb      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 123
```

```assembly
; System.Numerics.Bench.StressRect`1[[System.Single, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,2B81DC00BB8
       mov       rcx,[rcx]
       mov       rdx,2B81DC00BC0
       mov       rdx,[rdx]
       mov       r8,2C7D4662F60
       vmovups   xmm0,[r8]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       vmovups   xmm1,[rcx+r9+10]
       vmovups   xmm2,[r10]
       vmulps    xmm1,xmm0,xmm1
       vmulps    xmm2,xmm0,xmm2
       vcmpleps  xmm1,xmm1,xmm2
       vpcmpeqd  xmm2,xmm2,xmm2
       vptest    xmm1,xmm2
       setb      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 118
```

```assembly
; System.Numerics.Bench.StressRect`1[[System.Single, System.Private.CoreLib]].Area()
       mov       rax,1F79EC00BB8
       mov       rax,[rax]
       mov       rcx,1F79EC00BD8
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpshufd   xmm1,xmm0,4E
       vsubps    xmm0,xmm1,xmm0
       vpshufd   xmm1,xmm0,0F5
       vmulps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 74
```
