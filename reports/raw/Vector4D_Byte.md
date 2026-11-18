## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Byte, System.Private.CoreLib]].Add()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,228F6C01568
       mov       rcx,[rcx]
       mov       rdx,228F6C01570
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*4+10]
       movzx     r9d,byte ptr [r10]
       movzx     r11d,byte ptr [r10+1]
       movzx     ebx,byte ptr [r10+2]
       movzx     r10d,byte ptr [r10+3]
       inc       eax
       mov       esi,eax
       lea       rsi,[rcx+rsi*4+10]
       movzx     edi,byte ptr [rsi]
       movzx     ebp,byte ptr [rsi+1]
       movzx     r14d,byte ptr [rsi+2]
       movzx     esi,byte ptr [rsi+3]
       add       r9d,edi
       movzx     r9d,r9b
       add       r11d,ebp
       movzx     r11d,r11b
       add       ebx,r14d
       movzx     ebx,bl
       add       r10d,esi
       movzx     r10d,r10b
       lea       r8,[rdx+r8*4+10]
       mov       [r8],r9b
       mov       [r8+1],r11b
       mov       [r8+2],bl
       mov       [r8+3],r10b
       cmp       eax,1869F
       jl        short 0000000000002F42
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 150
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Byte, System.Private.CoreLib]].Subtract()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,1A3D7801568
       mov       rcx,[rcx]
       mov       rdx,1A3D7801570
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*4+10]
       movzx     r9d,byte ptr [r10]
       movzx     r11d,byte ptr [r10+1]
       movzx     ebx,byte ptr [r10+2]
       movzx     r10d,byte ptr [r10+3]
       inc       eax
       mov       esi,eax
       lea       rsi,[rcx+rsi*4+10]
       movzx     edi,byte ptr [rsi]
       movzx     ebp,byte ptr [rsi+1]
       movzx     r14d,byte ptr [rsi+2]
       movzx     esi,byte ptr [rsi+3]
       sub       r9d,edi
       movzx     r9d,r9b
       sub       r11d,ebp
       movzx     r11d,r11b
       sub       ebx,r14d
       movzx     ebx,bl
       sub       r10d,esi
       movzx     r10d,r10b
       lea       r8,[rdx+r8*4+10]
       mov       [r8],r9b
       mov       [r8+1],r11b
       mov       [r8+2],bl
       mov       [r8+3],r10b
       cmp       eax,1869F
       jl        short 0000000000002342
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 150
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Byte, System.Private.CoreLib]].Multiply()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,27524801568
       mov       rcx,[rcx]
       mov       rdx,27524801570
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*4+10]
       movzx     r9d,byte ptr [r10]
       movzx     r11d,byte ptr [r10+1]
       movzx     ebx,byte ptr [r10+2]
       movzx     r10d,byte ptr [r10+3]
       inc       eax
       mov       esi,eax
       lea       rsi,[rcx+rsi*4+10]
       movzx     edi,byte ptr [rsi]
       movzx     ebp,byte ptr [rsi+1]
       movzx     r14d,byte ptr [rsi+2]
       movzx     esi,byte ptr [rsi+3]
       imul      r9d,edi
       movzx     r9d,r9b
       imul      r11d,ebp
       movzx     r11d,r11b
       imul      ebx,r14d
       movzx     ebx,bl
       imul      r10d,esi
       movzx     r10d,r10b
       lea       r8,[rdx+r8*4+10]
       mov       [r8],r9b
       mov       [r8+1],r11b
       mov       [r8+2],bl
       mov       [r8+3],r10b
       cmp       eax,1869F
       jl        short 0000000000002AA2
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 154
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Byte, System.Private.CoreLib]].Divide()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       ecx,ecx
       mov       rax,1D03E001568
       mov       r8,[rax]
       mov       rax,1D03E001570
       mov       r10,[rax]
M00_L00:
       mov       r9d,ecx
       lea       rax,[r8+r9*4+10]
       movzx     edx,byte ptr [rax]
       movzx     r11d,byte ptr [rax+1]
       movzx     ebx,byte ptr [rax+2]
       movzx     esi,byte ptr [rax+3]
       inc       ecx
       mov       eax,ecx
       lea       rax,[r8+rax*4+10]
       movzx     edi,byte ptr [rax]
       movzx     ebp,byte ptr [rax+1]
       movzx     r14d,byte ptr [rax+2]
       movzx     r15d,byte ptr [rax+3]
       mov       eax,edx
       xor       edx,edx
       div       edi
       movzx     edi,al
       mov       eax,r11d
       xor       edx,edx
       div       ebp
       movzx     r11d,al
       mov       eax,ebx
       xor       edx,edx
       div       r14d
       movzx     ebx,al
       mov       eax,esi
       xor       edx,edx
       div       r15d
       movzx     eax,al
       lea       rdx,[r10+r9*4+10]
       mov       [rdx],dil
       mov       [rdx+1],r11b
       mov       [rdx+2],bl
       mov       [rdx+3],al
       cmp       ecx,1869F
       jl        short 00000000000027A4
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 165
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Byte, System.Private.CoreLib]].Abs()
       push      rsi
       push      rbx
       mov       rax,17D7E001568
       mov       rax,[rax]
       mov       rcx,17D7E001570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       movzx     r9d,byte ptr [r10]
       movzx     r11d,byte ptr [r10+1]
       movzx     ebx,byte ptr [r10+2]
       movzx     r10d,byte ptr [r10+3]
       lea       rsi,[rcx+rdx]
       mov       [rsi],r9b
       mov       [rsi+1],r11b
       mov       [rsi+2],bl
       mov       [rsi+3],r10b
       add       rdx,4
       dec       r8d
       jne       short 0000000000002787
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 92
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Byte, System.Private.CoreLib]].Dot()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,13A83401568
       mov       rcx,[rcx]
       mov       rdx,13A83401578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*4+10]
       movzx     r9d,byte ptr [r10]
       movzx     r11d,byte ptr [r10+1]
       movzx     ebx,byte ptr [r10+2]
       movzx     r10d,byte ptr [r10+3]
       inc       eax
       mov       esi,eax
       lea       rsi,[rcx+rsi*4+10]
       movzx     edi,byte ptr [rsi]
       movzx     ebp,byte ptr [rsi+1]
       movzx     r14d,byte ptr [rsi+2]
       movzx     esi,byte ptr [rsi+3]
       imul      r9d,edi
       movzx     r9d,r9b
       imul      r11d,ebp
       add       r9d,r11d
       movzx     r9d,r9b
       imul      ebx,r14d
       add       r9d,ebx
       movzx     r9d,r9b
       imul      r10d,esi
       movzx     r10d,r10b
       add       r10d,r9d
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short 0000000000002DC2
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 149
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Byte, System.Private.CoreLib]].LengthSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,2C6CF001568
       mov       rcx,[rcx]
       mov       rdx,2C6CF001578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*4+10]
       movzx     r9d,byte ptr [r10]
       movzx     r11d,r9b
       movzx     ebx,byte ptr [r10+1]
       movzx     esi,bl
       movzx     edi,byte ptr [r10+2]
       movzx     ebp,dil
       movzx     r10d,byte ptr [r10+3]
       movzx     r14d,r10b
       imul      r9d,r11d
       movzx     r9d,r9b
       imul      ebx,esi
       add       r9d,ebx
       movzx     r9d,r9b
       imul      edi,ebp
       add       r9d,edi
       movzx     r9d,r9b
       imul      r10d,r14d
       movzx     r10d,r10b
       add       r10d,r9d
       mov       [rdx+r8+10],r10b
       inc       eax
       cmp       eax,186A0
       jl        short 0000000000002A82
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 137
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Byte, System.Private.CoreLib]].DistanceSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,15428001568
       mov       rax,[rax]
       mov       rcx,15428001578
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       lea       r8,[rax+rdx*4+10]
       movzx     r10d,byte ptr [r8]
       movzx     r9d,byte ptr [r8+1]
       movzx     r11d,byte ptr [r8+2]
       movzx     r8d,byte ptr [r8+3]
       lea       ebx,[rdx+1]
       mov       esi,ebx
       lea       rsi,[rax+rsi*4+10]
       movzx     edi,byte ptr [rsi]
       movzx     ebp,byte ptr [rsi+1]
       movzx     r14d,byte ptr [rsi+2]
       movzx     esi,byte ptr [rsi+3]
       sub       r10d,edi
       movzx     r10d,r10b
       sub       r9d,ebp
       movzx     r9d,r9b
       sub       r11d,r14d
       movzx     r11d,r11b
       sub       r8d,esi
       movzx     r8d,r8b
       imul      r10d,r10d
       movzx     r10d,r10b
       imul      r9d,r9d
       add       r10d,r9d
       movzx     r10d,r10b
       imul      r11d,r11d
       add       r10d,r11d
       movzx     r10d,r10b
       imul      r8d,r8d
       movzx     r8d,r8b
       add       r8d,r10d
       mov       [rcx+rdx+10],r8b
       mov       edx,ebx
       cmp       edx,1869F
       jl        near ptr 0000000000002722
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 182
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Byte, System.Private.CoreLib]].Transform()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,1A1FC801568
       mov       rax,[rax]
       mov       rcx,1A1FC801570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       movzx     r9d,byte ptr [r10]
       movzx     r11d,r9b
       movzx     ebx,byte ptr [r10+1]
       movzx     esi,byte ptr [r10+2]
       movzx     r10d,byte ptr [r10+3]
       lea       edi,[rbx+rbx*4]
       add       r9d,edi
       movzx     r9d,r9b
       lea       edi,[rsi+rsi*8]
       add       r9d,edi
       movzx     r9d,r9b
       imul      edi,r10d,0D
       add       r9d,edi
       movzx     r9d,r9b
       lea       edi,[r11+r11]
       movzx     edi,dil
       lea       ebp,[rbx+rbx*2]
       lea       edi,[rdi+rbp*2]
       movzx     edi,dil
       lea       ebp,[rsi+rsi*4]
       lea       edi,[rdi+rbp*2]
       movzx     edi,dil
       imul      ebp,r10d,0E
       add       edi,ebp
       movzx     edi,dil
       lea       ebp,[r11+r11*2]
       movzx     ebp,bpl
       lea       r14d,[rbx*8]
       sub       r14d,ebx
       add       ebp,r14d
       movzx     ebp,bpl
       imul      r14d,esi,0B
       add       ebp,r14d
       movzx     ebp,bpl
       mov       r14d,r10d
       shl       r14d,4
       sub       r14d,r10d
       add       ebp,r14d
       movzx     ebp,bpl
       shl       r11d,2
       movzx     r11d,r11b
       lea       r11d,[r11+rbx*8]
       movzx     r11d,r11b
       lea       ebx,[rsi+rsi*2]
       lea       r11d,[r11+rbx*4]
       movzx     r11d,r11b
       shl       r10d,4
       add       r10d,r11d
       movzx     r10d,r10b
       lea       r11,[rcx+rdx]
       mov       [r11],r9b
       mov       [r11+1],dil
       mov       [r11+2],bpl
       mov       [r11+3],r10b
       add       rdx,4
       dec       r8d
       jne       near ptr 0000000000002A6B
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 270
```

