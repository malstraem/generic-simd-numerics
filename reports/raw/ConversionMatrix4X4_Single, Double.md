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
| Convert | 303.3 μs | 0.46 μs | 0.41 μs |     294 B |
| Back    | 301.5 μs | 0.60 μs | 0.50 μs |     294 B |

```assembly
; System.Numerics.Bench.StressConversionMatrix4X4`2[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000066C0
       mov       r10,rax
       shl       r10,6
       lea       r8,[r8+r10+10]
       vcvtss2sd xmm0,xmm0,dword ptr [r8]
       vcvtss2sd xmm1,xmm1,dword ptr [r8+4]
       vcvtss2sd xmm2,xmm2,dword ptr [r8+8]
       vcvtss2sd xmm3,xmm3,dword ptr [r8+0C]
       lea       r10,[r8+10]
       vcvtss2sd xmm4,xmm4,dword ptr [r10]
       vcvtss2sd xmm5,xmm5,dword ptr [r10+4]
       vcvtss2sd xmm16,xmm16,dword ptr [r10+8]
       vcvtss2sd xmm17,xmm17,dword ptr [r10+0C]
       lea       r10,[r8+20]
       vcvtss2sd xmm18,xmm18,dword ptr [r10]
       vcvtss2sd xmm19,xmm19,dword ptr [r10+4]
       vcvtss2sd xmm20,xmm20,dword ptr [r10+8]
       vcvtss2sd xmm21,xmm21,dword ptr [r10+0C]
       add       r8,30
       vcvtss2sd xmm22,xmm22,dword ptr [r8]
       vcvtss2sd xmm23,xmm23,dword ptr [r8+4]
       vcvtss2sd xmm24,xmm24,dword ptr [r8+8]
       vcvtss2sd xmm25,xmm25,dword ptr [r8+0C]
       cmp       eax,[rdx+8]
       jae       near ptr 00000000000066C0
       mov       r8,rax
       shl       r8,7
       lea       rdx,[rdx+r8+10]
       vmovsd    qword ptr [rdx],xmm0
       vmovsd    qword ptr [rdx+8],xmm1
       vmovsd    qword ptr [rdx+10],xmm2
       vmovsd    qword ptr [rdx+18],xmm3
       vmovsd    qword ptr [rdx+20],xmm4
       vmovsd    qword ptr [rdx+28],xmm5
       vmovsd    qword ptr [rdx+30],xmm16
       vmovsd    qword ptr [rdx+38],xmm17
       vmovsd    qword ptr [rdx+40],xmm18
       vmovsd    qword ptr [rdx+48],xmm19
       vmovsd    qword ptr [rdx+50],xmm20
       vmovsd    qword ptr [rdx+58],xmm21
       vmovsd    qword ptr [rdx+60],xmm22
       vmovsd    qword ptr [rdx+68],xmm23
       vmovsd    qword ptr [rdx+70],xmm24
       vmovsd    qword ptr [rdx+78],xmm25
       inc       eax
       cmp       eax,186A0
       jl        near ptr 00000000000065A6
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 294
```

```assembly
; System.Numerics.Bench.StressConversionMatrix4X4`2[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Back()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+8]
       mov       r8,[rcx+10]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000006E80
       mov       r10,rax
       shl       r10,7
       lea       r8,[r8+r10+10]
       vcvtsd2ss xmm0,xmm0,qword ptr [r8]
       vcvtsd2ss xmm1,xmm1,qword ptr [r8+8]
       vcvtsd2ss xmm2,xmm2,qword ptr [r8+10]
       vcvtsd2ss xmm3,xmm3,qword ptr [r8+18]
       lea       r10,[r8+20]
       vcvtsd2ss xmm4,xmm4,qword ptr [r10]
       vcvtsd2ss xmm5,xmm5,qword ptr [r10+8]
       vcvtsd2ss xmm16,xmm16,qword ptr [r10+10]
       vcvtsd2ss xmm17,xmm17,qword ptr [r10+18]
       lea       r10,[r8+40]
       vcvtsd2ss xmm18,xmm18,qword ptr [r10]
       vcvtsd2ss xmm19,xmm19,qword ptr [r10+8]
       vcvtsd2ss xmm20,xmm20,qword ptr [r10+10]
       vcvtsd2ss xmm21,xmm21,qword ptr [r10+18]
       add       r8,60
       vcvtsd2ss xmm22,xmm22,qword ptr [r8]
       vcvtsd2ss xmm23,xmm23,qword ptr [r8+8]
       vcvtsd2ss xmm24,xmm24,qword ptr [r8+10]
       vcvtsd2ss xmm25,xmm25,qword ptr [r8+18]
       cmp       eax,[rdx+8]
       jae       near ptr 0000000000006E80
       mov       r8,rax
       shl       r8,6
       lea       rdx,[rdx+r8+10]
       vmovss    dword ptr [rdx],xmm0
       vmovss    dword ptr [rdx+4],xmm1
       vmovss    dword ptr [rdx+8],xmm2
       vmovss    dword ptr [rdx+0C],xmm3
       vmovss    dword ptr [rdx+10],xmm4
       vmovss    dword ptr [rdx+14],xmm5
       vmovss    dword ptr [rdx+18],xmm16
       vmovss    dword ptr [rdx+1C],xmm17
       vmovss    dword ptr [rdx+20],xmm18
       vmovss    dword ptr [rdx+24],xmm19
       vmovss    dword ptr [rdx+28],xmm20
       vmovss    dword ptr [rdx+2C],xmm21
       vmovss    dword ptr [rdx+30],xmm22
       vmovss    dword ptr [rdx+34],xmm23
       vmovss    dword ptr [rdx+38],xmm24
       vmovss    dword ptr [rdx+3C],xmm25
       inc       eax
       cmp       eax,186A0
       jl        near ptr 0000000000006D66
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 294
```
