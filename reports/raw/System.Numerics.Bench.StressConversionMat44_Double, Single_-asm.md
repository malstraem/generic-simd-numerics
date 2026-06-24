## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressConversionMat44`2[[System.Double, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   zmm0,[r8]
       vmovups   zmm1,[r8+40]
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vcvtpd2ps ymm0,zmm0
       vmovups   [rdx],ymm0
       vcvtpd2ps ymm0,zmm1
       vmovups   [rdx+20],ymm0
       inc       eax
       cmp       eax,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 106
```

