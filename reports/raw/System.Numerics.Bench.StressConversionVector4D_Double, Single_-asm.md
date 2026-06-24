## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressConversionVector4D`2[[System.Double, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,5
       lea       r8,[r8+r9+10]
       vcvtsd2ss xmm0,xmm0,qword ptr [r8]
       vcvtsd2ss xmm1,xmm1,qword ptr [r8+8]
       vcvtsd2ss xmm2,xmm2,qword ptr [r8+10]
       vcvtsd2ss xmm3,xmm3,qword ptr [r8+18]
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,4
       lea       rdx,[rdx+r10+10]
       vmovss    dword ptr [rdx],xmm0
       vmovss    dword ptr [rdx+4],xmm1
       vmovss    dword ptr [rdx+8],xmm2
       vmovss    dword ptr [rdx+0C],xmm3
       inc       eax
       cmp       eax,186A0
       jl        short M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 111
```

