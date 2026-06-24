## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Single, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,2BF5E400358
       mov       rcx,[rcx]
       mov       rdx,2BF5E400360
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       lea       r9,[rcx+r9+10]
       vmovss    xmm0,dword ptr [r9]
       vmovss    xmm1,dword ptr [r9+4]
       vmovss    xmm2,dword ptr [r9+8]
       vmovss    xmm3,dword ptr [r9+0C]
       vmovss    xmm4,dword ptr [r10]
       vmovaps   xmm5,xmm4
       vmovss    xmm16,dword ptr [r10+4]
       vmovaps   xmm17,xmm16
       vmovss    xmm18,dword ptr [r10+8]
       vmovss    xmm19,dword ptr [r10+0C]
       vaddss    xmm5,xmm5,xmm18
       vaddss    xmm17,xmm17,xmm19
       vaddss    xmm2,xmm0,xmm2
       vaddss    xmm3,xmm1,xmm3
       vucomiss  xmm0,xmm4
       jb        short M00_L02
       vucomiss  xmm1,xmm16
       jb        short M00_L02
       vucomiss  xmm5,xmm2
       jb        short M00_L02
       vucomiss  xmm17,xmm3
       setae     r10b
       movzx     r10d,r10b
M00_L01:
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        near ptr M00_L00
       ret
M00_L02:
       xor       r10d,r10d
       jmp       short M00_L01
; Total bytes of code 192
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Single, System.Private.CoreLib]].Area()
       mov       rax,19EE3000358
       mov       rax,[rax]
       mov       rcx,19EE3000368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovss    xmm0,dword ptr [r10+8]
       vmovss    xmm1,dword ptr [r10+0C]
       vmulss    xmm0,xmm0,xmm1
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 71
```

