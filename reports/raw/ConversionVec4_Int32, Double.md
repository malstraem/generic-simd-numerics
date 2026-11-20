## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method  | Mean     | Error    | StdDev   | Code Size |
|-------- |---------:|---------:|---------:|----------:|
| Convert | 54.96 μs | 0.119 μs | 0.111 μs |      86 B |
| Back    | 55.17 μs | 0.053 μs | 0.044 μs |      86 B |

```assembly
; System.Numerics.Bench.StressConversionVec4`2[[System.Int32, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
       mov       rdx,[rcx+10]
       nop       word ptr [rax+rax]
M00_L00:
       mov       r8,rdx
       mov       r10,[rcx+8]
       cmp       eax,[r10+8]
       jae       short 0000000000005270
       mov       r9d,eax
       mov       r11,r9
       shl       r11,4
       vcvtdq2pd ymm0,xmmword ptr [r10+r11+10]
       cmp       eax,[r8+8]
       jae       short 0000000000005270
       shl       r9,5
       vmovups   [r8+r9+10],ymm0
       inc       eax
       cmp       eax,186A0
       jl        short 0000000000005230
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 86
```

```assembly
; System.Numerics.Bench.StressConversionVec4`2[[System.Int32, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Back()
       sub       rsp,28
       xor       eax,eax
       mov       rdx,[rcx+8]
       nop       word ptr [rax+rax]
M00_L00:
       mov       r8,rdx
       mov       r10,[rcx+10]
       cmp       eax,[r10+8]
       jae       short 0000000000005310
       mov       r9d,eax
       mov       r11,r9
       shl       r11,5
       vcvtpd2dq xmm0,ymmword ptr [r10+r11+10]
       cmp       eax,[r8+8]
       jae       short 0000000000005310
       shl       r9,4
       vmovups   [r8+r9+10],xmm0
       inc       eax
       cmp       eax,186A0
       jl        short 00000000000052D0
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 86
```
