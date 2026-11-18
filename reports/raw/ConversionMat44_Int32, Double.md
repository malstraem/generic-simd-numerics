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

| Method  | Mean     | Error   | StdDev  | Code Size |
|-------- |---------:|--------:|--------:|----------:|
| Convert | 170.4 μs | 0.32 μs | 0.28 μs |     130 B |
| Back    | 171.9 μs | 3.41 μs | 4.44 μs |     130 B |

```assembly
; System.Numerics.Bench.StressConversionMat44`2[[System.Int32, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short 0000000000005FBC
       mov       r10d,eax
       mov       r9,r10
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   xmm0,[r8]
       vmovups   xmm1,[r8+10]
       vmovups   xmm2,[r8+20]
       vmovups   xmm3,[r8+30]
       cmp       eax,[rdx+8]
       jae       short 0000000000005FBC
       shl       r10,7
       lea       rdx,[rdx+r10+10]
       vcvtdq2pd ymm0,xmm0
       vmovups   [rdx],ymm0
       vcvtdq2pd ymm0,xmm1
       vmovups   [rdx+20],ymm0
       vcvtdq2pd ymm0,xmm2
       vmovups   [rdx+40],ymm0
       vcvtdq2pd ymm0,xmm3
       vmovups   [rdx+60],ymm0
       inc       eax
       cmp       eax,186A0
       jl        short 0000000000005F46
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 130
```

```assembly
; System.Numerics.Bench.StressConversionMat44`2[[System.Int32, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Back()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+8]
       mov       r8,[rcx+10]
       cmp       eax,[r8+8]
       jae       short 000000000000643C
       mov       r10d,eax
       mov       r9,r10
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   ymm0,[r8]
       vmovups   ymm1,[r8+20]
       vmovups   ymm2,[r8+40]
       vmovups   ymm3,[r8+60]
       cmp       eax,[rdx+8]
       jae       short 000000000000643C
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vcvtpd2dq xmm0,ymm0
       vmovups   [rdx],xmm0
       vcvtpd2dq xmm0,ymm1
       vmovups   [rdx+10],xmm0
       vcvtpd2dq xmm0,ymm2
       vmovups   [rdx+20],xmm0
       vcvtpd2dq xmm0,ymm3
       vmovups   [rdx+30],xmm0
       inc       eax
       cmp       eax,186A0
       jl        short 00000000000063C6
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 130
```
