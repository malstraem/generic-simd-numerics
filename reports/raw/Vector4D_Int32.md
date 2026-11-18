## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Add()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,1A11D801578
       mov       rax,[rax]
       mov       rcx,1A11D801580
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       mov       r9d,[r10]
       mov       r11d,[r10+4]
       mov       ebx,[r10+8]
       mov       r10d,[r10+0C]
       inc       edx
       mov       esi,edx
       shl       rsi,4
       lea       rsi,[rax+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+4]
       mov       r14d,[rsi+8]
       mov       esi,[rsi+0C]
       add       r9d,edi
       add       r11d,ebp
       add       ebx,r14d
       add       r10d,esi
       lea       r8,[rcx+r8+10]
       mov       [r8],r9d
       mov       [r8+4],r11d
       mov       [r8+8],ebx
       mov       [r8+0C],r10d
       cmp       edx,1869F
       jl        short 0000000000002CA2
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 133
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Subtract()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,27CD1401568
       mov       rax,[rax]
       mov       rcx,27CD1401570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       mov       r9d,[r10]
       mov       r11d,[r10+4]
       mov       ebx,[r10+8]
       mov       r10d,[r10+0C]
       inc       edx
       mov       esi,edx
       shl       rsi,4
       lea       rsi,[rax+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+4]
       mov       r14d,[rsi+8]
       mov       esi,[rsi+0C]
       sub       r9d,edi
       sub       r11d,ebp
       sub       ebx,r14d
       sub       r10d,esi
       lea       r8,[rcx+r8+10]
       mov       [r8],r9d
       mov       [r8+4],r11d
       mov       [r8+8],ebx
       mov       [r8+0C],r10d
       cmp       edx,1869F
       jl        short 00000000000027A2
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 133
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Multiply()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,2330EC01568
       mov       rax,[rax]
       mov       rcx,2330EC01570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       mov       r9d,[r10]
       mov       r11d,[r10+4]
       mov       ebx,[r10+8]
       mov       r10d,[r10+0C]
       inc       edx
       mov       esi,edx
       shl       rsi,4
       lea       rsi,[rax+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+4]
       mov       r14d,[rsi+8]
       mov       esi,[rsi+0C]
       imul      r9d,edi
       imul      r11d,ebp
       imul      ebx,r14d
       imul      r10d,esi
       lea       r8,[rcx+r8+10]
       mov       [r8],r9d
       mov       [r8+4],r11d
       mov       [r8+8],ebx
       mov       [r8+0C],r10d
       cmp       edx,1869F
       jl        short 0000000000002782
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
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Divide()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,200C7001568
       mov       rcx,[rax]
       mov       rax,200C7001570
       mov       r8,[rax]
       xor       r10d,r10d
M00_L00:
       mov       r9,r10
       shl       r9,4
       lea       rax,[rcx+r9+10]
       mov       edx,[rax]
       mov       r11d,[rax+4]
       mov       ebx,[rax+8]
       mov       esi,[rax+0C]
       inc       r10d
       mov       eax,r10d
       shl       rax,4
       lea       rax,[rcx+rax+10]
       mov       edi,[rax]
       mov       ebp,[rax+4]
       mov       r14d,[rax+8]
       mov       r15d,[rax+0C]
       mov       eax,edx
       cdq
       idiv      edi
       mov       edi,eax
       mov       eax,r11d
       cdq
       idiv      ebp
       mov       r11d,eax
       mov       eax,ebx
       cdq
       idiv      r14d
       mov       ebx,eax
       mov       eax,esi
       cdq
       idiv      r15d
       lea       rdx,[r8+r9+10]
       mov       [rdx],edi
       mov       [rdx+4],r11d
       mov       [rdx+8],ebx
       mov       [rdx+0C],eax
       cmp       r10d,1869F
       jl        short 00000000000036A5
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 154
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Abs()
       push      rsi
       push      rbx
       mov       rax,1DE8A801568
       mov       rax,[rax]
       mov       rcx,1DE8A801570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       mov       r9d,[r10]
       mov       r11d,[r10+4]
       mov       ebx,[r10+8]
       mov       r10d,[r10+0C]
       vmovd     xmm0,r9d
       vpabsd    xmm0,xmm0
       vmovd     r9d,xmm0
       vmovd     xmm0,r11d
       vpabsd    xmm0,xmm0
       vmovd     r11d,xmm0
       vmovd     xmm0,ebx
       vpabsd    xmm0,xmm0
       vmovd     ebx,xmm0
       vmovd     xmm0,r10d
       vpabsd    xmm0,xmm0
       vmovd     r10d,xmm0
       lea       rsi,[rcx+rdx]
       mov       [rsi],r9d
       mov       [rsi+4],r11d
       mov       [rsi+8],ebx
       mov       [rsi+0C],r10d
       add       rdx,10
       dec       r8d
       jne       short 0000000000002D27
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 146
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Dot()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,2135DC01568
       mov       rcx,[rcx]
       mov       rdx,2135DC01578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       mov       r9d,[r10]
       mov       r11d,[r10+4]
       mov       ebx,[r10+8]
       mov       r10d,[r10+0C]
       inc       eax
       mov       esi,eax
       shl       rsi,4
       lea       rsi,[rcx+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+4]
       mov       r14d,[rsi+8]
       mov       esi,[rsi+0C]
       imul      r9d,edi
       imul      r11d,ebp
       add       r9d,r11d
       imul      ebx,r14d
       add       r9d,ebx
       imul      r10d,esi
       add       r10d,r9d
       mov       [rdx+r8*4+10],r10d
       cmp       eax,1869F
       jl        short 0000000000002482
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 133
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].LengthSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,1C21FC01578
       mov       rax,[rax]
       mov       rcx,1C21FC01588
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       mov       r9d,[r10]
       mov       r11d,r9d
       mov       ebx,[r10+4]
       mov       esi,ebx
       mov       edi,[r10+8]
       mov       ebp,edi
       mov       r10d,[r10+0C]
       mov       r14d,r10d
       imul      r9d,r11d
       imul      ebx,esi
       add       r9d,ebx
       imul      edi,ebp
       add       r9d,edi
       imul      r10d,r14d
       add       r10d,r9d
       mov       [rcx+rdx+10],r10d
       add       rdx,4
       dec       r8d
       jne       short 0000000000002B68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 114
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].DistanceSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,2B478401568
       mov       rcx,[rcx]
       mov       rdx,2B478401578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       mov       r9d,[r10]
       mov       r11d,[r10+4]
       mov       ebx,[r10+8]
       mov       r10d,[r10+0C]
       inc       eax
       mov       esi,eax
       shl       rsi,4
       lea       rsi,[rcx+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+4]
       mov       r14d,[rsi+8]
       mov       esi,[rsi+0C]
       sub       r9d,edi
       sub       r11d,ebp
       sub       ebx,r14d
       sub       r10d,esi
       imul      r9d,r9d
       imul      r11d,r11d
       add       r9d,r11d
       imul      ebx,ebx
       add       r9d,ebx
       imul      r10d,r10d
       add       r10d,r9d
       mov       [rdx+r8*4+10],r10d
       cmp       eax,1869F
       jl        short 0000000000002D82
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 144
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Transform()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,2C32AC01568
       mov       rax,[rax]
       mov       rcx,2C32AC01570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       mov       r9d,[r10]
       mov       r11d,[r10+4]
       mov       ebx,[r10+8]
       mov       r10d,[r10+0C]
       lea       esi,[r11+r11*4]
       add       esi,r9d
       lea       edi,[rbx+rbx*8]
       add       esi,edi
       imul      edi,r10d,0D
       add       esi,edi
       lea       edi,[r9+r9]
       lea       ebp,[r11+r11*2]
       lea       edi,[rdi+rbp*2]
       lea       ebp,[rbx+rbx*4]
       lea       edi,[rdi+rbp*2]
       imul      ebp,r10d,0E
       add       edi,ebp
       lea       ebp,[r9+r9*2]
       lea       r14d,[r11*8]
       sub       r14d,r11d
       add       ebp,r14d
       imul      r14d,ebx,0B
       add       ebp,r14d
       mov       r14d,r10d
       shl       r14d,4
       sub       r14d,r10d
       add       ebp,r14d
       shl       r9d,2
       lea       r9d,[r9+r11*8]
       lea       r11d,[rbx+rbx*2]
       lea       r9d,[r9+r11*4]
       shl       r10d,4
       add       r10d,r9d
       lea       r9,[rcx+rdx]
       mov       [r9],esi
       mov       [r9+4],edi
       mov       [r9+8],ebp
       mov       [r9+0C],r10d
       add       rdx,10
       dec       r8d
       jne       near ptr 0000000000002CEB
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 203
```

