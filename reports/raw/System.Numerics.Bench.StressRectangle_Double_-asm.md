## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Double, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,21BF0801560
       mov       rcx,[rcx]
       mov       rdx,21BF0801568
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
       vaddsd    xmm5,xmm18,xmm5
       vaddsd    xmm17,xmm17,xmm19
       vaddsd    xmm2,xmm0,xmm2
       vaddsd    xmm3,xmm1,xmm3
       vucomisd  xmm0,xmm4
       jb        short 0000000000002AFB
       vucomisd  xmm1,xmm16
       jb        short 0000000000002AFB
       vucomisd  xmm5,xmm2
       jb        short 0000000000002AFB
       vucomisd  xmm17,xmm3
       setae     r10b
       movzx     r10d,r10b
M00_L01:
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        near ptr 0000000000002A5C
       ret
M00_L02:
       xor       r10d,r10d
       jmp       short 0000000000002AEA
; Total bytes of code 192
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Double, System.Private.CoreLib]].Area()
       mov       rax,20395801560
       mov       rax,[rax]
       mov       rcx,20395801570
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
       jne       short 0000000000001D02
       ret
; Total bytes of code 71
```

