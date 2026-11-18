## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method     | Mean     | Error    | StdDev   | Code Size |
|----------- |---------:|---------:|---------:|----------:|
| Intersects | 65.93 μs | 0.598 μs | 0.560 μs |     122 B |
| Contains   | 61.33 μs | 0.400 μs | 0.374 μs |     116 B |
| Area       | 25.51 μs | 0.168 μs | 0.157 μs |      77 B |

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].Intersects()
       xor       eax,eax
       mov       rcx,207C3000BB8
       mov       rcx,[rcx]
       mov       rdx,207C3000BC0
       mov       rdx,[rdx]
       mov       r8,207A42D3080
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
       vpermilps xmm2,xmm2,4E
       vpmulld   xmm2,xmm2,xmm0
       vpmulld   xmm1,xmm0,xmm1
       vpcmpgtd  k1,xmm2,xmm1
       kortestb  k1,k1
       sete      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 122
```

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,28BDE800BB8
       mov       rcx,[rcx]
       mov       rdx,28BDE800BC0
       mov       rdx,[rdx]
       mov       r8,28BA42D2F60
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
       mov       rax,202A4400BB8
       mov       rax,[rax]
       mov       rcx,202A4400BD8
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpermilps xmm1,xmm0,4E
       vpsubd    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,0F5
       vpmulld   xmm0,xmm1,xmm0
       vmovd     dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 77
```
