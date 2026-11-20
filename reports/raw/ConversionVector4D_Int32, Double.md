## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method  | Mean      | Error    | StdDev   | Code Size |
|-------- |----------:|---------:|---------:|----------:|
| Convert |  98.21 μs | 0.132 μs | 0.124 μs |     127 B |
| Back    | 179.33 μs | 1.381 μs | 1.224 μs |     240 B |

```assembly
; System.Numerics.Bench.StressConversionVector4D`2[[System.Int32, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short 0000000000004E59
       mov       r10d,eax
       mov       r9,r10
       shl       r9,4
       lea       r8,[r8+r9+10]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [r8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2sd xmm1,xmm1,dword ptr [r8+4]
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2sd xmm2,xmm2,dword ptr [r8+8]
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2sd xmm3,xmm3,dword ptr [r8+0C]
       cmp       eax,[rdx+8]
       jae       short 0000000000004E59
       shl       r10,5
       lea       rdx,[rdx+r10+10]
       vmovsd    qword ptr [rdx],xmm0
       vmovsd    qword ptr [rdx+8],xmm1
       vmovsd    qword ptr [rdx+10],xmm2
       vmovsd    qword ptr [rdx+18],xmm3
       inc       eax
       cmp       eax,186A0
       jl        short 0000000000004DE6
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 127
```

```assembly
; System.Numerics.Bench.StressConversionVector4D`2[[System.Int32, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Back()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+8]
       mov       r8,[rcx+10]
       cmp       eax,[r8+8]
       jae       near ptr 000000000000512A
       mov       r10d,eax
       mov       r9,r10
       shl       r9,5
       lea       r8,[r8+r9+10]
       vmovsd    xmm0,qword ptr [r8]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r9d,7FFFFFFF
       vcvttsd2si r11d,xmm1
       vucomisd  xmm0,qword ptr [5130]
       cmovb     r9d,r11d
       vmovsd    xmm0,qword ptr [r8+8]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r11d,7FFFFFFF
       vcvttsd2si ebx,xmm1
       vucomisd  xmm0,qword ptr [5130]
       cmovb     r11d,ebx
       vmovsd    xmm0,qword ptr [r8+10]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       ebx,7FFFFFFF
       vcvttsd2si esi,xmm1
       vucomisd  xmm0,qword ptr [5130]
       cmovb     ebx,esi
       vmovsd    xmm0,qword ptr [r8+18]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r8d,7FFFFFFF
       vcvttsd2si esi,xmm1
       vucomisd  xmm0,qword ptr [5130]
       cmovb     r8d,esi
       cmp       eax,[rdx+8]
       jae       short 000000000000512A
       shl       r10,4
       lea       rdx,[rdx+r10+10]
       mov       [rdx],r9d
       mov       [rdx+4],r11d
       mov       [rdx+8],ebx
       mov       [rdx+0C],r8d
       inc       eax
       cmp       eax,186A0
       jl        near ptr 0000000000005048
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 240
```
