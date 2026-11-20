## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method  | Mean      | Error    | StdDev   | Code Size |
|-------- |----------:|---------:|---------:|----------:|
| Convert |  91.62 μs | 0.134 μs | 0.126 μs |     120 B |
| Back    | 178.23 μs | 1.189 μs | 1.112 μs |     233 B |

```assembly
; System.Numerics.Bench.StressConversionVector4D`2[[System.Int32, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short 0000000000005172
       mov       r10,rax
       shl       r10,4
       lea       r8,[r8+r10+10]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,dword ptr [r8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [r8+4]
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2ss xmm2,xmm2,dword ptr [r8+8]
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2ss xmm3,xmm3,dword ptr [r8+0C]
       cmp       eax,[rdx+8]
       jae       short 0000000000005172
       lea       rdx,[rdx+r10+10]
       vmovss    dword ptr [rdx],xmm0
       vmovss    dword ptr [rdx+4],xmm1
       vmovss    dword ptr [rdx+8],xmm2
       vmovss    dword ptr [rdx+0C],xmm3
       inc       eax
       cmp       eax,186A0
       jl        short 0000000000005106
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 120
```

```assembly
; System.Numerics.Bench.StressConversionVector4D`2[[System.Int32, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Back()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+8]
       mov       r8,[rcx+10]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000004EE3
       mov       r10,rax
       shl       r10,4
       lea       r8,[r8+r10+10]
       vmovss    xmm0,dword ptr [r8]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r9d,7FFFFFFF
       vcvttss2si r11d,xmm1
       vucomiss  xmm0,dword ptr [4EEC]
       cmovb     r9d,r11d
       vmovss    xmm0,dword ptr [r8+4]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r11d,7FFFFFFF
       vcvttss2si ebx,xmm1
       vucomiss  xmm0,dword ptr [4EEC]
       cmovb     r11d,ebx
       vmovss    xmm0,dword ptr [r8+8]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       ebx,7FFFFFFF
       vcvttss2si esi,xmm1
       vucomiss  xmm0,dword ptr [4EEC]
       cmovb     ebx,esi
       vmovss    xmm0,dword ptr [r8+0C]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r8d,7FFFFFFF
       vcvttss2si esi,xmm1
       vucomiss  xmm0,dword ptr [4EEC]
       cmovb     r8d,esi
       cmp       eax,[rdx+8]
       jae       short 0000000000004EE3
       lea       rdx,[rdx+r10+10]
       mov       [rdx],r9d
       mov       [rdx+4],r11d
       mov       [rdx+8],ebx
       mov       [rdx+0C],r8d
       inc       eax
       cmp       eax,186A0
       jl        near ptr 0000000000004E08
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 233
```
