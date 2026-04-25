## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Add()
       sub       rsp,18
       xor       eax,eax
       mov       [rsp],rax
       mov       rax,1DA3A400358
       mov       rax,[rax]
       xor       ecx,ecx
M00_L00:
       lea       rdx,[rax+rcx*8+10]
       mov       r8,[rdx]
       mov       [rsp+10],r8
       inc       ecx
       mov       r8d,ecx
       mov       r8,[rax+r8*8+10]
       mov       [rsp+8],r8
       lea       r8,[rsp+10]
       vmovsd    xmm0,qword ptr [r8]
       lea       r8,[rsp+8]
       vmovsd    xmm1,qword ptr [r8]
       vaddps    xmm0,xmm0,xmm1
       vmovsd    qword ptr [rsp],xmm0
       mov       r8,[rsp]
       mov       [rdx],r8
       cmp       ecx,1869F
       jl        short M00_L00
       add       rsp,18
       ret
; Total bytes of code 102
```

