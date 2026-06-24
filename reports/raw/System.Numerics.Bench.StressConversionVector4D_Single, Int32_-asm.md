## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressConversionVector4D`2[[System.Single, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].Convert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10,rax
       shl       r10,4
       lea       r8,[r8+r10+10]
       vmovss    xmm0,dword ptr [r8]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r9d,7FFFFFFF
       vcvttss2si r11d,xmm1
       vucomiss  xmm0,dword ptr [7FFEE0E39D90]
       cmovb     r9d,r11d
       vmovss    xmm0,dword ptr [r8+4]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r11d,7FFFFFFF
       vcvttss2si ebx,xmm1
       vucomiss  xmm0,dword ptr [7FFEE0E39D90]
       cmovb     r11d,ebx
       vmovss    xmm0,dword ptr [r8+8]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       ebx,7FFFFFFF
       vcvttss2si esi,xmm1
       vucomiss  xmm0,dword ptr [7FFEE0E39D90]
       cmovb     ebx,esi
       vmovss    xmm0,dword ptr [r8+0C]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r8d,7FFFFFFF
       vcvttss2si esi,xmm1
       vucomiss  xmm0,dword ptr [7FFEE0E39D90]
       cmovb     r8d,esi
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r10+10]
       mov       [rdx],r9d
       mov       [rdx+4],r11d
       mov       [rdx+8],ebx
       mov       [rdx+0C],r8d
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 233
```

