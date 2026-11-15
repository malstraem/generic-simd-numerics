## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressConversionMat44`2[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short 000000000000353C
       mov       r10d,eax
       mov       r9,r10
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   xmm0,[r8]
       vmovups   xmm1,[r8+10]
       vmovups   xmm2,[r8+20]
       vmovups   xmm3,[r8+30]
       cmp       eax,[rdx+8]
       jae       short 000000000000353C
       shl       r10,7
       lea       rdx,[rdx+r10+10]
       vcvtps2pd ymm0,xmm0
       vmovups   [rdx],ymm0
       vcvtps2pd ymm0,xmm1
       vmovups   [rdx+20],ymm0
       vcvtps2pd ymm0,xmm2
       vmovups   [rdx+40],ymm0
       vcvtps2pd ymm0,xmm3
       vmovups   [rdx+60],ymm0
       inc       eax
       cmp       eax,186A0
       jl        short 00000000000034C6
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 130
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

