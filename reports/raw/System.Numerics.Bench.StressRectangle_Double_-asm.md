## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Double, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,271BC000358
       mov       rcx,[rcx]
       mov       rdx,271BC000360
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,5
       lea       r9,[rcx+r9+10]
       vmovsd    xmm0,qword ptr [r9]
       vmovsd    xmm1,qword ptr [r9+8]
       vmovsd    xmm2,qword ptr [r9+10]
       vmovsd    xmm3,qword ptr [r9+18]
       vmovsd    xmm4,qword ptr [r10]
       vmovaps   xmm5,xmm4
       vmovsd    xmm16,qword ptr [r10+8]
       vmovaps   xmm17,xmm16
       vmovsd    xmm18,qword ptr [r10+10]
       vmovsd    xmm19,qword ptr [r10+18]
       vaddsd    xmm5,xmm5,xmm18
       vaddsd    xmm17,xmm17,xmm19
       vaddsd    xmm2,xmm0,xmm2
       vaddsd    xmm3,xmm1,xmm3
       vucomisd  xmm0,xmm4
       jb        short M00_L02
       vucomisd  xmm1,xmm16
       jb        short M00_L02
       vucomisd  xmm5,xmm2
       jb        short M00_L02
       vucomisd  xmm17,xmm3
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Double, System.Private.CoreLib]].Area()
       mov       rax,1B046400358
       mov       rax,[rax]
       mov       rcx,1B046400368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovsd    xmm0,qword ptr [r10+10]
       vmovsd    xmm1,qword ptr [r10+18]
       vmulsd    xmm0,xmm0,xmm1
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 71
```

