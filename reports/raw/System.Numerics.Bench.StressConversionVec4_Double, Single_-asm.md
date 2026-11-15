## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressConversionVec4`2[[System.Double, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
       mov       rdx,[rcx+10]
       nop       word ptr [rax+rax]
M00_L00:
       mov       r8,rdx
       mov       r10,[rcx+8]
       cmp       eax,[r10+8]
       jae       short 0000000000002350
       mov       r9d,eax
       mov       r11,r9
       shl       r11,5
       vcvtpd2ps xmm0,ymmword ptr [r10+r11+10]
       cmp       eax,[r8+8]
       jae       short 0000000000002350
       shl       r9,4
       vmovups   [r8+r9+10],xmm0
       inc       eax
       cmp       eax,186A0
       jl        short 0000000000002310
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 86
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

