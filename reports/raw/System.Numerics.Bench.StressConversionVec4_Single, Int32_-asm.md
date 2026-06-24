## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressConversionVec4`2[[System.Single, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].Convert()
       sub       rsp,28
       mov       rax,[rcx+10]
       vbroadcastss xmm0,dword ptr [7FFEE0E19DD8]
       vbroadcastss xmm1,dword ptr [7FFEE0E19DDC]
       vbroadcastss xmm2,dword ptr [7FFEE0E19DE0]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,4
       vmovups   xmm3,[r10+r9+10]
       vfixupimmps xmm3,xmm3,xmm0,0
       vcmpgeps  xmm4,xmm3,xmm1
       vcvttps2dq xmm3,xmm3
       vpblendvb xmm3,xmm3,xmm2,xmm4
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+r9+10],xmm3
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 120
```

