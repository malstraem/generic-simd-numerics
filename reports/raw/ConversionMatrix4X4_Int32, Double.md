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
| Convert | 304.6 μs | 0.64 μs | 0.60 μs |     378 B |
| Back    | 628.8 μs | 0.88 μs | 0.82 μs |     789 B |

```assembly
; System.Numerics.Bench.StressConversionMatrix4X4`2[[System.Int32, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000006394
       mov       r10,rax
       shl       r10,6
       lea       r8,[r8+r10+10]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [r8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2sd xmm1,xmm1,dword ptr [r8+4]
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2sd xmm2,xmm2,dword ptr [r8+8]
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2sd xmm3,xmm3,dword ptr [r8+0C]
       lea       r10,[r8+10]
       vxorps    xmm4,xmm4,xmm4
       vcvtsi2sd xmm4,xmm4,dword ptr [r10]
       vxorps    xmm5,xmm5,xmm5
       vcvtsi2sd xmm5,xmm5,dword ptr [r10+4]
       vxorps    xmm16,xmm16,xmm16
       vcvtsi2sd xmm16,xmm16,dword ptr [r10+8]
       vxorps    xmm17,xmm17,xmm17
       vcvtsi2sd xmm17,xmm17,dword ptr [r10+0C]
       lea       r10,[r8+20]
       vxorps    xmm18,xmm18,xmm18
       vcvtsi2sd xmm18,xmm18,dword ptr [r10]
       vxorps    xmm19,xmm19,xmm19
       vcvtsi2sd xmm19,xmm19,dword ptr [r10+4]
       vxorps    xmm20,xmm20,xmm20
       vcvtsi2sd xmm20,xmm20,dword ptr [r10+8]
       vxorps    xmm21,xmm21,xmm21
       vcvtsi2sd xmm21,xmm21,dword ptr [r10+0C]
       add       r8,30
       vxorps    xmm22,xmm22,xmm22
       vcvtsi2sd xmm22,xmm22,dword ptr [r8]
       vxorps    xmm23,xmm23,xmm23
       vcvtsi2sd xmm23,xmm23,dword ptr [r8+4]
       vxorps    xmm24,xmm24,xmm24
       vcvtsi2sd xmm24,xmm24,dword ptr [r8+8]
       vxorps    xmm25,xmm25,xmm25
       vcvtsi2sd xmm25,xmm25,dword ptr [r8+0C]
       cmp       eax,[rdx+8]
       jae       near ptr 0000000000006394
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
       jl        near ptr 0000000000006226
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 378
```

```assembly
; System.Numerics.Bench.StressConversionMatrix4X4`2[[System.Int32, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Back()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+8]
       mov       [rsp+80],rcx
       mov       r8,[rcx+10]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000069CF
       mov       r10,rax
       shl       r10,7
       lea       r8,[r8+r10+10]
       vmovsd    xmm0,qword ptr [r8]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r10d,7FFFFFFF
       vcvttsd2si r9d,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     r10d,r9d
       vmovsd    xmm0,qword ptr [r8+8]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r9d,7FFFFFFF
       vcvttsd2si r11d,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     r9d,r11d
       vmovsd    xmm0,qword ptr [r8+10]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r11d,7FFFFFFF
       vcvttsd2si ebx,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     r11d,ebx
       vmovsd    xmm0,qword ptr [r8+18]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       ebx,7FFFFFFF
       vcvttsd2si esi,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     ebx,esi
       mov       [rsp+34],ebx
       lea       rsi,[r8+20]
       vmovsd    xmm0,qword ptr [rsi]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       edi,7FFFFFFF
       vcvttsd2si ebp,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     edi,ebp
       vmovsd    xmm0,qword ptr [rsi+8]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       ebp,7FFFFFFF
       vcvttsd2si r14d,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     ebp,r14d
       vmovsd    xmm0,qword ptr [rsi+10]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r14d,7FFFFFFF
       vcvttsd2si r15d,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     r14d,r15d
       vmovsd    xmm0,qword ptr [rsi+18]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       esi,7FFFFFFF
       vcvttsd2si r15d,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     esi,r15d
       mov       [rsp+30],esi
       lea       r15,[r8+40]
       vmovsd    xmm0,qword ptr [r15]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r13d,7FFFFFFF
       vcvttsd2si r12d,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     r13d,r12d
       vmovsd    xmm0,qword ptr [r15+8]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r12d,7FFFFFFF
       vcvttsd2si esi,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     r12d,esi
       vmovsd    xmm0,qword ptr [r15+10]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       esi,7FFFFFFF
       vcvttsd2si ebx,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     esi,ebx
       vmovsd    xmm0,qword ptr [r15+18]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       ebx,7FFFFFFF
       vcvttsd2si r15d,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     ebx,r15d
       mov       [rsp+2C],ebx
       add       r8,60
       vmovsd    xmm0,qword ptr [r8]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r15d,7FFFFFFF
       vcvttsd2si ebx,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     r15d,ebx
       vmovsd    xmm0,qword ptr [r8+8]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       ebx,7FFFFFFF
       vcvttsd2si ecx,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     ebx,ecx
       mov       [rsp+28],ebx
       vmovsd    xmm0,qword ptr [r8+10]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       ecx,7FFFFFFF
       vcvttsd2si ebx,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     ecx,ebx
       vmovsd    xmm0,qword ptr [r8+18]
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r8d,7FFFFFFF
       vcvttsd2si ebx,xmm1
       vucomisd  xmm0,qword ptr [69D8]
       cmovb     r8d,ebx
       cmp       eax,[rdx+8]
       jae       short 00000000000069CF
       mov       rbx,rax
       shl       rbx,6
       lea       rdx,[rdx+rbx+10]
       mov       [rdx],r10d
       mov       [rdx+4],r9d
       mov       [rdx+8],r11d
       mov       ebx,[rsp+34]
       mov       [rdx+0C],ebx
       mov       [rdx+10],edi
       mov       [rdx+14],ebp
       mov       [rdx+18],r14d
       mov       r10d,[rsp+30]
       mov       [rdx+1C],r10d
       mov       [rdx+20],r13d
       mov       [rdx+24],r12d
       mov       [rdx+28],esi
       mov       ebx,[rsp+2C]
       mov       [rdx+2C],ebx
       mov       [rdx+30],r15d
       mov       ebx,[rsp+28]
       mov       [rdx+34],ebx
       mov       [rdx+38],ecx
       mov       [rdx+3C],r8d
       inc       eax
       cmp       eax,186A0
       mov       rcx,[rsp+80]
       jl        near ptr 00000000000066D2
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 789
```
