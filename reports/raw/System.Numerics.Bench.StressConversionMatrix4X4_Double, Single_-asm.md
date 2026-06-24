## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressConversionMatrix4X4`2[[System.Double, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
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
       jae       near ptr M00_L01
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
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 294
```

