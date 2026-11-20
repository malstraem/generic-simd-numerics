## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method     | Mean     | Error    | StdDev   | Code Size |
|----------- |---------:|---------:|---------:|----------:|
| Intersects | 66.33 μs | 0.282 μs | 0.264 μs |     121 B |
| Contains   | 61.26 μs | 0.247 μs | 0.219 μs |     116 B |
| Area       | 25.96 μs | 0.095 μs | 0.080 μs |      75 B |

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].Intersects()
       xor       eax,eax
       mov       rcx,1845EC00BB8
       mov       rcx,[rcx]
       mov       rdx,1845EC00BC0
       mov       rdx,[rdx]
       mov       r8,184242D30A8
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
       vpmulld   xmm2,xmm2,xmm0
       vpmulld   xmm1,xmm0,xmm1
       vpcmpgtd  k1,xmm2,xmm1
       kortestb  k1,k1
       sete      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 121
```

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,13AC0000BB8
       mov       rcx,[rcx]
       mov       rdx,13AC0000BC0
       mov       rdx,[rdx]
       mov       r8,13AA42D3070
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
       vpmulld   xmm1,xmm0,xmm1
       vpmulld   xmm2,xmm0,xmm2
       vpcmpgtd  k1,xmm1,xmm2
       kortestb  k1,k1
       sete      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 116
```

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].Area()
       mov       rax,25762800BB8
       mov       rax,[rax]
       mov       rcx,25762800BD8
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpshufd   xmm1,xmm0,4E
       vpsubd    xmm0,xmm1,xmm0
       vpshufd   xmm1,xmm0,0F5
       vpmulld   xmm0,xmm1,xmm0
       vmovd     dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 75
```
