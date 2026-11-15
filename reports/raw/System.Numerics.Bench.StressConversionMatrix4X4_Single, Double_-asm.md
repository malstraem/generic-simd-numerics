## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressConversionMatrix4X4`2[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000034C0
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
       jae       near ptr 00000000000034C0
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
       jl        near ptr 00000000000033A6
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 294
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

