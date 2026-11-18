## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method     | Mean     | Error    | StdDev   | Code Size |
|----------- |---------:|---------:|---------:|----------:|
| Intersects | 66.16 μs | 0.234 μs | 0.219 μs |     127 B |
| Contains   | 66.76 μs | 0.195 μs | 0.173 μs |     121 B |
| Area       | 32.14 μs | 0.102 μs | 0.090 μs |      78 B |

```assembly
; System.Numerics.Bench.StressRect`1[[System.Double, System.Private.CoreLib]].Intersects()
       xor       eax,eax
       mov       rcx,141B2C00BC8
       mov       rcx,[rcx]
       mov       rdx,141B2C00BD0
       mov       rdx,[rdx]
       mov       r8,141A42D30E0
       vmovups   ymm0,[r8]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,5
       vmovups   ymm1,[rcx+r9+10]
       vmovups   ymm2,[r10]
       vpermq    ymm2,ymm2,4E
       vmulpd    ymm2,ymm2,ymm0
       vmulpd    ymm1,ymm0,ymm1
       vcmplepd  ymm1,ymm2,ymm1
       vpcmpeqd  ymm2,ymm2,ymm2
       vptest    ymm1,ymm2
       setb      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 127
```

```assembly
; System.Numerics.Bench.StressRect`1[[System.Double, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,205A4C00BC8
       mov       rcx,[rcx]
       mov       rdx,205A4C00BD0
       mov       rdx,[rdx]
       mov       r8,2155B6B30D0
       vmovups   ymm0,[r8]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,5
       vmovups   ymm1,[rcx+r9+10]
       vmovups   ymm2,[r10]
       vmulpd    ymm1,ymm0,ymm1
       vmulpd    ymm2,ymm0,ymm2
       vcmplepd  ymm1,ymm1,ymm2
       vpcmpeqd  ymm2,ymm2,ymm2
       vptest    ymm1,ymm2
       setb      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 121
```

```assembly
; System.Numerics.Bench.StressRect`1[[System.Double, System.Private.CoreLib]].Area()
       mov       rax,19C87000BB8
       mov       rax,[rax]
       mov       rcx,19C87000BD8
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vpermq    ymm1,ymm0,4E
       vsubpd    ymm0,ymm1,ymm0
       vshufpd   ymm1,ymm0,ymm0,0F
       vmulpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 78
```
