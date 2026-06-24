## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

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
       jae       short M00_L01
       mov       r9d,eax
       mov       r11,r9
       shl       r11,5
       vcvtpd2ps xmm0,ymmword ptr [r10+r11+10]
       cmp       eax,[r8+8]
       jae       short M00_L01
       shl       r9,4
       vmovups   [r8+r9+10],xmm0
       inc       eax
       cmp       eax,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 86
```

