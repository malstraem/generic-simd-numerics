## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Byte, System.Private.CoreLib]].Add()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,210C2C01568
       mov       rcx,[rcx]
       mov       rdx,210C2C01570
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
       jl        short 0000000000002EA2
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Byte, System.Private.CoreLib]].Subtract()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,185FFC01568
       mov       rcx,[rcx]
       mov       rdx,185FFC01570
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
       jl        short 0000000000002642
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Byte, System.Private.CoreLib]].Multiply()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,1AE52001568
       mov       rcx,[rcx]
       mov       rdx,1AE52001570
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
       jl        short 0000000000002962
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Byte, System.Private.CoreLib]].Divide()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       ecx,ecx
       mov       rax,2BFFC001578
       mov       r8,[rax]
       mov       rax,2BFFC001580
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
       jl        short 0000000000002C64
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Byte, System.Private.CoreLib]].Sum()
       push      rbx
       xor       eax,eax
       mov       rcx,1E76B401568
       mov       rcx,[rcx]
       mov       rdx,1E76B401588
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*4+10]
       movzx     r9d,byte ptr [r10]
       movzx     r11d,byte ptr [r10+1]
       movzx     ebx,byte ptr [r10+2]
       movzx     r10d,byte ptr [r10+3]
       add       r9d,r11d
       add       r9d,ebx
       movzx     r9d,r9b
       add       r10d,r9d
       mov       [rdx+r8+10],r10b
       inc       eax
       cmp       eax,186A0
       jl        short 0000000000002540
       pop       rbx
       ret
; Total bytes of code 88
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Byte, System.Private.CoreLib]].Dot()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,2398D401578
       mov       rcx,[rcx]
       mov       rdx,2398D401588
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*4+10]
       inc       eax
       mov       r9d,eax
       lea       r9,[rcx+r9*4+10]
       movzx     r11d,byte ptr [r9]
       movzx     ebx,byte ptr [r9+1]
       movzx     esi,byte ptr [r9+2]
       movzx     r9d,byte ptr [r9+3]
       movzx     edi,byte ptr [r10]
       movzx     ebp,byte ptr [r10+1]
       movzx     r14d,byte ptr [r10+2]
       movzx     r10d,byte ptr [r10+3]
       imul      r11d,edi
       movzx     r11d,r11b
       imul      ebx,ebp
       movzx     ebx,bl
       imul      esi,r14d
       movzx     esi,sil
       imul      r10d,r9d
       movzx     r10d,r10b
       add       r11d,ebx
       add       r11d,esi
       movzx     r9d,r11b
       add       r10d,r9d
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short 0000000000002C82
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 152
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Byte, System.Private.CoreLib]].LengthSquared()
       mov       rax,26C3F001568
       mov       rax,[rax]
       mov       rcx,26C3F001578
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       lea       r8,[rax+rdx*4+10]
       movzx     r10d,byte ptr [r8]
       movzx     r9d,byte ptr [r8+1]
       movzx     r11d,byte ptr [r8+2]
       movzx     r8d,byte ptr [r8+3]
       imul      r10d,r10d
       movzx     r10d,r10b
       imul      r9d,r9d
       movzx     r9d,r9b
       imul      r11d,r11d
       movzx     r11d,r11b
       imul      r8d,r8d
       movzx     r8d,r8b
       add       r10d,r9d
       add       r10d,r11d
       movzx     r10d,r10b
       add       r8d,r10d
       mov       [rcx+rdx+10],r8b
       inc       edx
       cmp       edx,186A0
       jl        short 000000000000301C
       ret
; Total bytes of code 113
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Byte, System.Private.CoreLib]].DistanceSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,20644801568
       mov       rax,[rax]
       mov       rcx,20644801578
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       lea       r8,[rax+rdx*4+10]
       lea       r10d,[rdx+1]
       mov       r9d,r10d
       lea       r9,[rax+r9*4+10]
       movzx     r11d,byte ptr [r9]
       movzx     ebx,byte ptr [r9+1]
       movzx     esi,byte ptr [r9+2]
       movzx     r9d,byte ptr [r9+3]
       movzx     edi,byte ptr [r8]
       movzx     ebp,byte ptr [r8+1]
       movzx     r14d,byte ptr [r8+2]
       movzx     r8d,byte ptr [r8+3]
       sub       edi,r11d
       movzx     r11d,dil
       sub       ebp,ebx
       movzx     ebx,bpl
       sub       r14d,esi
       movzx     esi,r14b
       sub       r8d,r9d
       movzx     r8d,r8b
       movzx     r9d,r11b
       imul      r9d,r9d
       movzx     r9d,r9b
       movzx     r11d,bl
       imul      r11d,r11d
       movzx     r11d,r11b
       movzx     ebx,sil
       imul      ebx,ebx
       movzx     ebx,bl
       imul      r8d,r8d
       movzx     r8d,r8b
       add       r9d,r11d
       add       r9d,ebx
       movzx     r9d,r9b
       add       r8d,r9d
       mov       [rcx+rdx+10],r8b
       mov       edx,r10d
       cmp       edx,1869F
       jl        near ptr 0000000000003362
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 198
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Byte, System.Private.CoreLib]].Transform()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,2302F401568
       mov       rax,[rax]
       mov       rcx,2302F401570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       movzx     r9d,byte ptr [r10]
       movzx     r11d,byte ptr [r10+1]
       movzx     ebx,byte ptr [r10+2]
       movzx     r10d,byte ptr [r10+3]
       mov       esi,r9d
       lea       edi,[r9+r9]
       movzx     edi,dil
       lea       ebp,[r9+r9*2]
       movzx     ebp,bpl
       shl       r9d,2
       movzx     r9d,r9b
       lea       r14d,[r11+r11*4]
       movzx     r14d,r14b
       lea       r15d,[r11+r11*2]
       add       r15d,r15d
       movzx     r15d,r15b
       lea       r13d,[r11*8]
       sub       r13d,r11d
       movzx     r13d,r13b
       shl       r11d,3
       movzx     r11d,r11b
       add       esi,r14d
       movzx     esi,sil
       add       edi,r15d
       movzx     edi,dil
       add       ebp,r13d
       movzx     ebp,bpl
       add       r9d,r11d
       movzx     r9d,r9b
       lea       r11d,[rbx+rbx*8]
       movzx     r11d,r11b
       lea       r14d,[rbx+rbx*4]
       add       r14d,r14d
       movzx     r14d,r14b
       imul      r15d,ebx,0B
       movzx     r15d,r15b
       lea       ebx,[rbx+rbx*2]
       shl       ebx,2
       movzx     ebx,bl
       add       r11d,esi
       movzx     r11d,r11b
       add       edi,r14d
       movzx     esi,dil
       add       ebp,r15d
       movzx     edi,bpl
       add       r9d,ebx
       movzx     r9d,r9b
       imul      ebx,r10d,0D
       movzx     ebx,bl
       imul      ebp,r10d,0E
       movzx     ebp,bpl
       mov       r14d,r10d
       shl       r14d,4
       sub       r14d,r10d
       movzx     r14d,r14b
       shl       r10d,4
       movzx     r10d,r10b
       add       r11d,ebx
       movzx     r11d,r11b
       add       esi,ebp
       movzx     ebx,sil
       add       edi,r14d
       movzx     esi,dil
       add       r10d,r9d
       movzx     r10d,r10b
       lea       r9,[rcx+rdx]
       mov       [r9],r11b
       mov       [r9+1],bl
       mov       [r9+2],sil
       mov       [r9+3],r10b
       add       rdx,4
       dec       r8d
       jne       near ptr 0000000000002D2F
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 338
```

