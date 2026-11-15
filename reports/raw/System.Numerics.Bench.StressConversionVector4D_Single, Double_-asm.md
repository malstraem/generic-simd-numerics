## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressConversionVector4D`2[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short 0000000000002229
       mov       r10d,eax
       mov       r9,r10
       shl       r9,4
       lea       r8,[r8+r9+10]
       vcvtss2sd xmm0,xmm0,dword ptr [r8]
       vcvtss2sd xmm1,xmm1,dword ptr [r8+4]
       vcvtss2sd xmm2,xmm2,dword ptr [r8+8]
       vcvtss2sd xmm3,xmm3,dword ptr [r8+0C]
       cmp       eax,[rdx+8]
       jae       short 0000000000002229
       shl       r10,5
       lea       rdx,[rdx+r10+10]
       vmovsd    qword ptr [rdx],xmm0
       vmovsd    qword ptr [rdx+8],xmm1
       vmovsd    qword ptr [rdx+10],xmm2
       vmovsd    qword ptr [rdx+18],xmm3
       inc       eax
       cmp       eax,186A0
       jl        short 00000000000021C6
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 111
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

