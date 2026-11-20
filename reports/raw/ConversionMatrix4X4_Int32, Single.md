## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method  | Mean     | Error   | StdDev  | Code Size |
|-------- |---------:|--------:|--------:|----------:|
| Convert | 298.7 μs | 0.74 μs | 0.70 μs |     367 B |
| Back    | 630.6 μs | 0.91 μs | 0.85 μs |     802 B |

```assembly
; System.Numerics.Bench.StressConversionMatrix4X4`2[[System.Int32, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000006449
       mov       r10,rax
       shl       r10,6
       lea       r8,[r8+r10+10]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,dword ptr [r8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [r8+4]
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2ss xmm2,xmm2,dword ptr [r8+8]
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2ss xmm3,xmm3,dword ptr [r8+0C]
       lea       r9,[r8+10]
       vxorps    xmm4,xmm4,xmm4
       vcvtsi2ss xmm4,xmm4,dword ptr [r9]
       vxorps    xmm5,xmm5,xmm5
       vcvtsi2ss xmm5,xmm5,dword ptr [r9+4]
       vxorps    xmm16,xmm16,xmm16
       vcvtsi2ss xmm16,xmm16,dword ptr [r9+8]
       vxorps    xmm17,xmm17,xmm17
       vcvtsi2ss xmm17,xmm17,dword ptr [r9+0C]
       lea       r9,[r8+20]
       vxorps    xmm18,xmm18,xmm18
       vcvtsi2ss xmm18,xmm18,dword ptr [r9]
       vxorps    xmm19,xmm19,xmm19
       vcvtsi2ss xmm19,xmm19,dword ptr [r9+4]
       vxorps    xmm20,xmm20,xmm20
       vcvtsi2ss xmm20,xmm20,dword ptr [r9+8]
       vxorps    xmm21,xmm21,xmm21
       vcvtsi2ss xmm21,xmm21,dword ptr [r9+0C]
       add       r8,30
       vxorps    xmm22,xmm22,xmm22
       vcvtsi2ss xmm22,xmm22,dword ptr [r8]
       vxorps    xmm23,xmm23,xmm23
       vcvtsi2ss xmm23,xmm23,dword ptr [r8+4]
       vxorps    xmm24,xmm24,xmm24
       vcvtsi2ss xmm24,xmm24,dword ptr [r8+8]
       vxorps    xmm25,xmm25,xmm25
       vcvtsi2ss xmm25,xmm25,dword ptr [r8+0C]
       cmp       eax,[rdx+8]
       jae       short 0000000000006449
       lea       rdx,[rdx+r10+10]
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
       jl        near ptr 00000000000062E6
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 367
```

```assembly
; System.Numerics.Bench.StressConversionMatrix4X4`2[[System.Int32, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Back()
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
       jae       near ptr 000000000000669C
       mov       r10,rax
       shl       r10,6
       mov       [rsp+20],r10
       lea       r8,[r8+r10+10]
       vmovss    xmm0,dword ptr [r8]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r9d,7FFFFFFF
       vcvttss2si r11d,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     r9d,r11d
       vmovss    xmm0,dword ptr [r8+4]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r11d,7FFFFFFF
       vcvttss2si ebx,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     r11d,ebx
       vmovss    xmm0,dword ptr [r8+8]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       ebx,7FFFFFFF
       vcvttss2si esi,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     ebx,esi
       vmovss    xmm0,dword ptr [r8+0C]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       esi,7FFFFFFF
       vcvttss2si edi,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     esi,edi
       mov       [rsp+34],esi
       lea       rdi,[r8+10]
       vmovss    xmm0,dword ptr [rdi]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       ebp,7FFFFFFF
       vcvttss2si r14d,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     ebp,r14d
       vmovss    xmm0,dword ptr [rdi+4]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r14d,7FFFFFFF
       vcvttss2si r15d,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     r14d,r15d
       vmovss    xmm0,dword ptr [rdi+8]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r15d,7FFFFFFF
       vcvttss2si r13d,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     r15d,r13d
       vmovss    xmm0,dword ptr [rdi+0C]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       edi,7FFFFFFF
       vcvttss2si r13d,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     edi,r13d
       mov       [rsp+30],edi
       lea       r13,[r8+20]
       vmovss    xmm0,dword ptr [r13]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r12d,7FFFFFFF
       vcvttss2si edi,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     r12d,edi
       vmovss    xmm0,dword ptr [r13+4]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       edi,7FFFFFFF
       vcvttss2si esi,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     edi,esi
       vmovss    xmm0,dword ptr [r13+8]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       esi,7FFFFFFF
       vcvttss2si ecx,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     esi,ecx
       vmovss    xmm0,dword ptr [r13+0C]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       ecx,7FFFFFFF
       vcvttss2si r13d,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     ecx,r13d
       mov       [rsp+2C],ecx
       add       r8,30
       vmovss    xmm0,dword ptr [r8]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r13d,7FFFFFFF
       vcvttss2si ecx,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     r13d,ecx
       vmovss    xmm0,dword ptr [r8+4]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       ecx,7FFFFFFF
       vcvttss2si r10d,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     ecx,r10d
       mov       [rsp+28],ecx
       vmovss    xmm0,dword ptr [r8+8]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r10d,7FFFFFFF
       vcvttss2si ecx,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     r10d,ecx
       vmovss    xmm0,dword ptr [r8+0C]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       ecx,7FFFFFFF
       vcvttss2si r8d,xmm1
       vucomiss  xmm0,dword ptr [66A4]
       cmovb     ecx,r8d
       cmp       eax,[rdx+8]
       jae       near ptr 000000000000669C
       mov       r8,[rsp+20]
       lea       rdx,[rdx+r8+10]
       mov       [rdx],r9d
       mov       [rdx+4],r11d
       mov       [rdx+8],ebx
       mov       r8d,[rsp+34]
       mov       [rdx+0C],r8d
       mov       [rdx+10],ebp
       mov       [rdx+14],r14d
       mov       [rdx+18],r15d
       mov       r8d,[rsp+30]
       mov       [rdx+1C],r8d
       mov       [rdx+20],r12d
       mov       [rdx+24],edi
       mov       [rdx+28],esi
       mov       r8d,[rsp+2C]
       mov       [rdx+2C],r8d
       mov       [rdx+30],r13d
       mov       r8d,[rsp+28]
       mov       [rdx+34],r8d
       mov       [rdx+38],r10d
       mov       [rdx+3C],ecx
       inc       eax
       cmp       eax,186A0
       mov       rcx,[rsp+80]
       jl        near ptr 0000000000006392
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
; Total bytes of code 802
```
