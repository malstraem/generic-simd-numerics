## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Int32, System.Private.CoreLib]].Contains()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,2673EC00358
       mov       rcx,[rcx]
       mov       rdx,2673EC00360
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
       mov       r11d,[r9]
       mov       ebx,[r9+4]
       mov       esi,[r9+8]
       mov       r9d,[r9+0C]
       mov       edi,[r10]
       mov       ebp,edi
       mov       r14d,[r10+4]
       mov       r15d,r14d
       mov       r13d,[r10+8]
       mov       r10d,[r10+0C]
       add       ebp,r13d
       add       r10d,r15d
       add       esi,r11d
       add       r9d,ebx
       cmp       r11d,edi
       jl        short M00_L02
       cmp       ebx,r14d
       jl        short M00_L02
       cmp       esi,ebp
       jg        short M00_L02
       cmp       r9d,r10d
       setle     r10b
       movzx     r10d,r10b
M00_L01:
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       xor       r10d,r10d
       jmp       short M00_L01
; Total bytes of code 167
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Int32, System.Private.CoreLib]].Area()
       mov       rax,1E362800358
       mov       rax,[rax]
       mov       rcx,1E362800368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       lea       r10,[rax+rdx*4+10]
       mov       r9d,[r10+8]
       mov       r10d,[r10+0C]
       imul      r10d,r9d
       mov       [rcx+rdx+10],r10d
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 80
```

