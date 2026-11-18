## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31,14 GB Total, 18,04 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  
```

| Method  | Mean     | Error    | StdDev   | Code Size |
|-------- |---------:|---------:|---------:|----------:|
| Convert | 42.28 μs | 0.065 μs | 0.061 μs |      71 B |
| Back    | 52.26 μs | 0.127 μs | 0.118 μs |     122 B |

```assembly
; System.Numerics.Bench.StressConversionVec4`2[[System.Int32, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Convert()
       sub       rsp,28
       mov       rax,[rcx+10]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short 00000000000051C1
       mov       r9,rdx
       shl       r9,4
       vcvtdq2ps xmm0,xmmword ptr [r10+r9+10]
       cmp       edx,[r8+8]
       jae       short 00000000000051C1
       vmovups   [r8+r9+10],xmm0
       inc       edx
       cmp       edx,186A0
       jl        short 000000000000518A
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 71
```

```assembly
; System.Numerics.Bench.StressConversionVec4`2[[System.Int32, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Back()
       sub       rsp,28
       mov       rax,[rcx+8]
       vbroadcastss xmm0,dword ptr [533C]
       vbroadcastss xmm1,dword ptr [5340]
       vbroadcastss xmm2,dword ptr [5344]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+10]
       cmp       edx,[r10+8]
       jae       short 0000000000005334
       mov       r9,rdx
       shl       r9,4
       vmovups   xmm3,[r10+r9+10]
       vfixupimmps xmm3,xmm3,xmm0,0
       vcmpgeps  k1,xmm3,xmm1
       vcvttps2dq xmm3,xmm3
       vblendmps xmm3{k1},xmm3,xmm2
       cmp       edx,[r8+8]
       jae       short 0000000000005334
       vmovups   [r8+r9+10],xmm3
       inc       edx
       cmp       edx,186A0
       jl        short 00000000000052E5
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 122
```
