## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Int32, System.Private.CoreLib]].Add()
       sub       rsp,18
       xor       eax,eax
       mov       rcx,2C45A800358
       mov       rcx,[rcx]
       mov       rdx,2C45A800360
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+10],r10
       inc       eax
       mov       r10d,eax
       mov       r10,[rcx+r10*8+10]
       mov       [rsp+8],r10
       vmovsd    xmm0,qword ptr [rsp+10]
       vmovsd    xmm1,qword ptr [rsp+8]
       vpaddd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rsp+10],xmm0
       mov       r10,[rsp+10]
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       add       rsp,18
       ret
; Total bytes of code 104
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Int32, System.Private.CoreLib]].Subtract()
       push      rbx
       xor       eax,eax
       mov       rcx,22C1A800358
       mov       rcx,[rcx]
       mov       rdx,22C1A800360
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       inc       eax
       mov       r11d,eax
       lea       r11,[rcx+r11*8+10]
       mov       ebx,[r11]
       mov       r11d,[r11+4]
       sub       r9d,ebx
       sub       r10d,r11d
       lea       r8,[rdx+r8*8+10]
       mov       [r8],r9d
       mov       [r8+4],r10d
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       ret
; Total bytes of code 91
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Int32, System.Private.CoreLib]].Multiply()
       push      rbx
       xor       eax,eax
       mov       rcx,27FEF800358
       mov       rcx,[rcx]
       mov       rdx,27FEF800360
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       inc       eax
       mov       r11d,eax
       lea       r11,[rcx+r11*8+10]
       mov       ebx,[r11]
       mov       r11d,[r11+4]
       imul      r9d,ebx
       imul      r10d,r11d
       lea       r8,[rdx+r8*8+10]
       mov       [r8],r9d
       mov       [r8+4],r10d
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       ret
; Total bytes of code 93
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Int32, System.Private.CoreLib]].Divide()
       push      rsi
       push      rbx
       xor       ecx,ecx
       mov       rax,1C7DE000358
       mov       r8,[rax]
       mov       rax,1C7DE000360
       mov       r10,[rax]
       xchg      ax,ax
M00_L00:
       mov       r9d,ecx
       lea       rax,[r8+r9*8+10]
       mov       edx,[rax]
       mov       r11d,[rax+4]
       inc       ecx
       mov       eax,ecx
       lea       rax,[r8+rax*8+10]
       mov       ebx,[rax]
       mov       esi,[rax+4]
       mov       eax,edx
       cdq
       idiv      ebx
       mov       ebx,eax
       mov       eax,r11d
       cdq
       idiv      esi
       lea       rdx,[r10+r9*8+10]
       mov       [rdx],ebx
       mov       [rdx+4],eax
       cmp       ecx,1869F
       jl        short M00_L00
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 94
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Int32, System.Private.CoreLib]].Sum()
       mov       rax,2CB08400358
       mov       rax,[rax]
       mov       rcx,2CB08400368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       add       r10d,r9d
       mov       [rcx+rdx+10],r10d
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 64
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Int32, System.Private.CoreLib]].Dot()
       push      rbx
       xor       eax,eax
       mov       rcx,29828000358
       mov       rcx,[rcx]
       mov       rdx,29828000368
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       inc       eax
       mov       r9d,eax
       lea       r9,[rcx+r9*8+10]
       mov       r11d,[r9]
       mov       r9d,[r9+4]
       mov       ebx,[r10]
       mov       r10d,[r10+4]
       imul      r11d,ebx
       imul      r10d,r9d
       add       r10d,r11d
       mov       [rdx+r8*4+10],r10d
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       ret
; Total bytes of code 89
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Int32, System.Private.CoreLib]].LengthSquared()
       mov       rax,2A4EB000358
       mov       rax,[rax]
       mov       rcx,2A4EB000368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       imul      r9d,r9d
       imul      r10d,r10d
       add       r10d,r9d
       mov       [rcx+rdx+10],r10d
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 72
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Int32, System.Private.CoreLib]].DistanceSquared()
       push      rbx
       xor       eax,eax
       mov       rcx,1BA5FC00358
       mov       rcx,[rcx]
       mov       rdx,1BA5FC00368
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       inc       eax
       mov       r9d,eax
       lea       r9,[rcx+r9*8+10]
       mov       r11d,[r9]
       mov       r9d,[r9+4]
       mov       ebx,[r10]
       mov       r10d,[r10+4]
       sub       ebx,r11d
       sub       r10d,r9d
       imul      ebx,ebx
       imul      r10d,r10d
       add       r10d,ebx
       mov       [rdx+r8*4+10],r10d
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       ret
; Total bytes of code 94
```

