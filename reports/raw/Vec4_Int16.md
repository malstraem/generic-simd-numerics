## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Add()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,21812801568
       mov       rcx,[rcx]
       mov       rdx,21812801570
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       movsx     r9,word ptr [r10]
       movsx     r11,word ptr [r10+2]
       movsx     rbx,word ptr [r10+4]
       movsx     r10,word ptr [r10+6]
       inc       eax
       mov       esi,eax
       lea       rsi,[rcx+rsi*8+10]
       movsx     rdi,word ptr [rsi]
       movsx     rbp,word ptr [rsi+2]
       movsx     r14,word ptr [rsi+4]
       movsx     rsi,word ptr [rsi+6]
       add       r9d,edi
       movsx     r9,r9w
       add       r11d,ebp
       movsx     r11,r11w
       add       ebx,r14d
       movsx     rbx,bx
       add       r10d,esi
       movsx     r10,r10w
       lea       r8,[rdx+r8*8+10]
       mov       [r8],r9w
       mov       [r8+2],r11w
       mov       [r8+4],bx
       mov       [r8+6],r10w
       cmp       eax,1869F
       jl        short 0000000000002F02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 155
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Subtract()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,1AFB4401568
       mov       rcx,[rcx]
       mov       rdx,1AFB4401570
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       movsx     r9,word ptr [r10]
       movsx     r11,word ptr [r10+2]
       movsx     rbx,word ptr [r10+4]
       movsx     r10,word ptr [r10+6]
       inc       eax
       mov       esi,eax
       lea       rsi,[rcx+rsi*8+10]
       movsx     rdi,word ptr [rsi]
       movsx     rbp,word ptr [rsi+2]
       movsx     r14,word ptr [rsi+4]
       movsx     rsi,word ptr [rsi+6]
       sub       r9d,edi
       movsx     r9,r9w
       sub       r11d,ebp
       movsx     r11,r11w
       sub       ebx,r14d
       movsx     rbx,bx
       sub       r10d,esi
       movsx     r10,r10w
       lea       r8,[rdx+r8*8+10]
       mov       [r8],r9w
       mov       [r8+2],r11w
       mov       [r8+4],bx
       mov       [r8+6],r10w
       cmp       eax,1869F
       jl        short 0000000000002E42
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 155
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Multiply()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,1A6E1001568
       mov       rcx,[rcx]
       mov       rdx,1A6E1001570
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       movsx     r9,word ptr [r10]
       movsx     r11,word ptr [r10+2]
       movsx     rbx,word ptr [r10+4]
       movsx     r10,word ptr [r10+6]
       inc       eax
       mov       esi,eax
       lea       rsi,[rcx+rsi*8+10]
       movsx     rdi,word ptr [rsi]
       movsx     rbp,word ptr [rsi+2]
       movsx     r14,word ptr [rsi+4]
       movsx     rsi,word ptr [rsi+6]
       imul      r9d,edi
       movsx     r9,r9w
       imul      r11d,ebp
       movsx     r11,r11w
       imul      ebx,r14d
       movsx     rbx,bx
       imul      r10d,esi
       movsx     r10,r10w
       lea       r8,[rdx+r8*8+10]
       mov       [r8],r9w
       mov       [r8+2],r11w
       mov       [r8+4],bx
       mov       [r8+6],r10w
       cmp       eax,1869F
       jl        short 0000000000002982
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 159
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Divide()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       ecx,ecx
       mov       rax,1C171C01568
       mov       r8,[rax]
       mov       rax,1C171C01570
       mov       r10,[rax]
M00_L00:
       mov       r9d,ecx
       lea       rax,[r8+r9*8+10]
       movsx     rdx,word ptr [rax]
       movsx     r11,word ptr [rax+2]
       movsx     rbx,word ptr [rax+4]
       movsx     rsi,word ptr [rax+6]
       inc       ecx
       mov       eax,ecx
       lea       rax,[r8+rax*8+10]
       movsx     rdi,word ptr [rax]
       movsx     rbp,word ptr [rax+2]
       movsx     r14,word ptr [rax+4]
       movsx     r15,word ptr [rax+6]
       mov       eax,edx
       cdq
       idiv      edi
       movsx     rdi,ax
       mov       eax,r11d
       cdq
       idiv      ebp
       movsx     r11,ax
       mov       eax,ebx
       cdq
       idiv      r14d
       movsx     rbx,ax
       mov       eax,esi
       cdq
       idiv      r15d
       cwde
       lea       rdx,[r10+r9*8+10]
       mov       [rdx],di
       mov       [rdx+2],r11w
       mov       [rdx+4],bx
       mov       [rdx+6],ax
       cmp       ecx,1869F
       jl        short 0000000000002A64
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Sum()
       push      rbx
       mov       rax,2090D001568
       mov       rax,[rax]
       mov       rcx,2090D001578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       movsx     r9,word ptr [r10]
       movsx     r11,word ptr [r10+2]
       movsx     rbx,word ptr [r10+4]
       movsx     r10,word ptr [r10+6]
       add       r9d,r11d
       add       r9d,ebx
       movsx     r9,r9w
       add       r10d,r9d
       mov       [rcx+rdx+10],r10w
       add       rdx,2
       dec       r8d
       jne       short 0000000000002783
       pop       rbx
       ret
; Total bytes of code 89
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Dot()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,1AA0A001568
       mov       rcx,[rcx]
       mov       rdx,1AA0A001578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       inc       eax
       mov       r9d,eax
       lea       r9,[rcx+r9*8+10]
       movsx     r11,word ptr [r9]
       movsx     rbx,word ptr [r9+2]
       movsx     rsi,word ptr [r9+4]
       movsx     r9,word ptr [r9+6]
       movsx     rdi,word ptr [r10]
       movsx     rbp,word ptr [r10+2]
       movsx     r14,word ptr [r10+4]
       movsx     r10,word ptr [r10+6]
       imul      r11d,edi
       movsx     r11,r11w
       imul      ebx,ebp
       movsx     rbx,bx
       imul      esi,r14d
       movsx     rsi,si
       imul      r10d,r9d
       movsx     r10,r10w
       add       r11d,ebx
       add       r11d,esi
       movsx     r9,r11w
       add       r10d,r9d
       mov       [rdx+r8*2+10],r10w
       cmp       eax,1869F
       jl        short 0000000000002D42
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
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].LengthSquared()
       push      rbx
       mov       rax,2CA56C01568
       mov       rax,[rax]
       mov       rcx,2CA56C01578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       movsx     r9,word ptr [r10]
       movsx     r11,word ptr [r10+2]
       movsx     rbx,word ptr [r10+4]
       movsx     r10,word ptr [r10+6]
       imul      r9d,r9d
       movsx     r9,r9w
       imul      r11d,r11d
       movsx     r11,r11w
       imul      ebx,ebx
       movsx     rbx,bx
       imul      r10d,r10d
       movsx     r10,r10w
       add       r9d,r11d
       add       r9d,ebx
       movsx     r9,r9w
       add       r10d,r9d
       mov       [rcx+rdx+10],r10w
       add       rdx,2
       dec       r8d
       jne       short 0000000000002E23
       pop       rbx
       ret
; Total bytes of code 120
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].DistanceSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,2A2A4401568
       mov       rax,[rax]
       mov       rcx,2A2A4401578
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       lea       r8,[rax+rdx*8+10]
       lea       r10d,[rdx+1]
       mov       r9d,r10d
       lea       r9,[rax+r9*8+10]
       movsx     r11,word ptr [r9]
       movsx     rbx,word ptr [r9+2]
       movsx     rsi,word ptr [r9+4]
       movsx     r9,word ptr [r9+6]
       movsx     rdi,word ptr [r8]
       movsx     rbp,word ptr [r8+2]
       movsx     r14,word ptr [r8+4]
       movsx     r8,word ptr [r8+6]
       sub       edi,r11d
       movsx     r11,di
       sub       ebp,ebx
       movsx     rbx,bp
       sub       r14d,esi
       movsx     rsi,r14w
       sub       r8d,r9d
       movsx     r8,r8w
       movsx     r9,r11w
       imul      r9d,r9d
       movsx     r9,r9w
       movsx     r11,bx
       imul      r11d,r11d
       movsx     r11,r11w
       movsx     rbx,si
       imul      ebx,ebx
       movsx     rbx,bx
       imul      r8d,r8d
       movsx     r8,r8w
       add       r9d,r11d
       add       r9d,ebx
       movsx     r9,r9w
       add       r8d,r9d
       mov       [rcx+rdx*2+10],r8w
       mov       edx,r10d
       cmp       edx,1869F
       jl        near ptr 00000000000036A2
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 200
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Transform()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,1FFD6001578
       mov       rax,[rax]
       mov       rcx,1FFD6001580
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       movsx     r9,word ptr [r10]
       movsx     r11,word ptr [r10+2]
       movsx     rbx,word ptr [r10+4]
       movsx     r10,word ptr [r10+6]
       mov       esi,r9d
       lea       edi,[r9+r9]
       movsx     rdi,di
       lea       ebp,[r9+r9*2]
       movsx     rbp,bp
       shl       r9d,2
       movsx     r9,r9w
       lea       r14d,[r11+r11*4]
       movsx     r14,r14w
       lea       r15d,[r11+r11*2]
       add       r15d,r15d
       movsx     r15,r15w
       lea       r13d,[r11*8]
       sub       r13d,r11d
       movsx     r13,r13w
       shl       r11d,3
       movsx     r11,r11w
       add       esi,r14d
       movsx     rsi,si
       add       edi,r15d
       movsx     rdi,di
       add       ebp,r13d
       movsx     rbp,bp
       add       r9d,r11d
       movsx     r9,r9w
       lea       r11d,[rbx+rbx*8]
       movsx     r11,r11w
       lea       r14d,[rbx+rbx*4]
       add       r14d,r14d
       movsx     r14,r14w
       imul      r15d,ebx,0B
       movsx     r15,r15w
       lea       ebx,[rbx+rbx*2]
       shl       ebx,2
       movsx     rbx,bx
       add       r11d,esi
       movsx     r11,r11w
       add       edi,r14d
       movsx     rsi,di
       add       ebp,r15d
       movsx     rdi,bp
       add       r9d,ebx
       movsx     r9,r9w
       imul      ebx,r10d,0D
       movsx     rbx,bx
       imul      ebp,r10d,0E
       movsx     rbp,bp
       mov       r14d,r10d
       shl       r14d,4
       sub       r14d,r10d
       movsx     r14,r14w
       shl       r10d,4
       movsx     r10,r10w
       add       r11d,ebx
       movsx     r11,r11w
       add       esi,ebp
       movsx     rbx,si
       add       edi,r14d
       movsx     rsi,di
       add       r10d,r9d
       movsx     r10,r10w
       lea       r9,[rcx+rdx]
       mov       [r9],r11w
       mov       [r9+2],bx
       mov       [r9+4],si
       mov       [r9+6],r10w
       add       rdx,8
       dec       r8d
       jne       near ptr 000000000000300F
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 344
```

