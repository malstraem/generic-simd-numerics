## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Int64, System.Private.CoreLib]].Add()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,29CF5C00360
       mov       rax,[rax]
       mov       rcx,29CF5C00368
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,5
       lea       r10,[rax+r8+10]
       mov       r9,[r10]
       mov       r11,[r10+8]
       mov       rbx,[r10+10]
       mov       r10,[r10+18]
       inc       edx
       mov       esi,edx
       shl       rsi,5
       lea       rsi,[rax+rsi+10]
       mov       rdi,[rsi]
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       mov       rsi,[rsi+18]
       add       r9,rdi
       add       r11,rbp
       add       rbx,r14
       add       r10,rsi
       lea       r8,[rcx+r8+10]
       mov       [r8],r9
       mov       [r8+8],r11
       mov       [r8+10],rbx
       mov       [r8+18],r10
       cmp       edx,1869F
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 136
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Int64, System.Private.CoreLib]].Subtract()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,103AB400360
       mov       rax,[rax]
       mov       rcx,103AB400368
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,5
       lea       r10,[rax+r8+10]
       mov       r9,[r10]
       mov       r11,[r10+8]
       mov       rbx,[r10+10]
       mov       r10,[r10+18]
       inc       edx
       mov       esi,edx
       shl       rsi,5
       lea       rsi,[rax+rsi+10]
       mov       rdi,[rsi]
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       mov       rsi,[rsi+18]
       sub       r9,rdi
       sub       r11,rbp
       sub       rbx,r14
       sub       r10,rsi
       lea       r8,[rcx+r8+10]
       mov       [r8],r9
       mov       [r8+8],r11
       mov       [r8+10],rbx
       mov       [r8+18],r10
       cmp       edx,1869F
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 136
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Int64, System.Private.CoreLib]].Multiply()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,28A33000360
       mov       rax,[rax]
       mov       rcx,28A33000368
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,5
       lea       r10,[rax+r8+10]
       mov       r9,[r10]
       mov       r11,[r10+8]
       mov       rbx,[r10+10]
       mov       r10,[r10+18]
       inc       edx
       mov       esi,edx
       shl       rsi,5
       lea       rsi,[rax+rsi+10]
       mov       rdi,[rsi]
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       mov       rsi,[rsi+18]
       imul      r9,rdi
       imul      r11,rbp
       imul      rbx,r14
       imul      r10,rsi
       lea       r8,[rcx+r8+10]
       mov       [r8],r9
       mov       [r8+8],r11
       mov       [r8+10],rbx
       mov       [r8+18],r10
       cmp       edx,1869F
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 140
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Int64, System.Private.CoreLib]].Divide()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,1C871800360
       mov       rcx,[rax]
       mov       rax,1C871800368
       mov       r8,[rax]
       xor       r10d,r10d
M00_L00:
       mov       r9,r10
       shl       r9,5
       lea       rax,[rcx+r9+10]
       mov       rdx,[rax]
       mov       r11,[rax+8]
       mov       rbx,[rax+10]
       mov       rsi,[rax+18]
       inc       r10d
       mov       eax,r10d
       shl       rax,5
       lea       rax,[rcx+rax+10]
       mov       rdi,[rax]
       mov       rbp,[rax+8]
       mov       r14,[rax+10]
       mov       r15,[rax+18]
       mov       rax,rdx
       cqo
       idiv      rdi
       mov       rdi,rax
       mov       rax,r11
       cqo
       idiv      rbp
       mov       r11,rax
       mov       rax,rbx
       cqo
       idiv      r14
       mov       rbx,rax
       mov       rax,rsi
       cqo
       idiv      r15
       lea       rdx,[r8+r9+10]
       mov       [rdx],rdi
       mov       [rdx+8],r11
       mov       [rdx+10],rbx
       mov       [rdx+18],rax
       cmp       r10d,1869F
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 173
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Int64, System.Private.CoreLib]].Abs()
       push      rsi
       push      rbx
       mov       rax,1C4E0C00360
       mov       rax,[rax]
       mov       rcx,1C4E0C00368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       mov       r9,[r10]
       mov       r11,[r10+8]
       mov       rbx,[r10+10]
       mov       r10,[r10+18]
       mov       rsi,r9
       sar       rsi,7
       add       r9,rsi
       xor       r9,rsi
       mov       rsi,r11
       sar       rsi,7
       add       r11,rsi
       xor       r11,rsi
       mov       rsi,rbx
       sar       rsi,7
       add       rbx,rsi
       xor       rbx,rsi
       mov       rsi,r10
       sar       rsi,7
       add       r10,rsi
       xor       r10,rsi
       lea       rsi,[rcx+rdx]
       mov       [rsi],r9
       mov       [rsi+8],r11
       mov       [rsi+10],rbx
       mov       [rsi+18],r10
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 141
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Int64, System.Private.CoreLib]].Dot()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,26221400360
       mov       rcx,[rcx]
       mov       rdx,26221400370
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       mov       r9,[r10]
       mov       r11,[r10+8]
       mov       rbx,[r10+10]
       mov       r10,[r10+18]
       inc       eax
       mov       esi,eax
       shl       rsi,5
       lea       rsi,[rcx+rsi+10]
       mov       rdi,[rsi]
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       mov       rsi,[rsi+18]
       imul      r9,rdi
       imul      r11,rbp
       add       r9,r11
       imul      rbx,r14
       add       r9,rbx
       imul      r10,rsi
       add       r10,r9
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 136
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Int64, System.Private.CoreLib]].LengthSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,2566A800360
       mov       rax,[rax]
       mov       rcx,2566A800370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       mov       r9,[r10]
       mov       r11,r9
       mov       rbx,[r10+8]
       mov       rsi,rbx
       mov       rdi,[r10+10]
       mov       rbp,rdi
       mov       r10,[r10+18]
       mov       r14,r10
       imul      r9,r11
       imul      rbx,rsi
       add       r9,rbx
       imul      rdi,rbp
       add       r9,rdi
       imul      r10,r14
       add       r10,r9
       mov       [rcx+rdx+10],r10
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 118
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Int64, System.Private.CoreLib]].DistanceSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,274DE800360
       mov       rcx,[rcx]
       mov       rdx,274DE800370
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       mov       r9,[r10]
       mov       r11,[r10+8]
       mov       rbx,[r10+10]
       mov       r10,[r10+18]
       inc       eax
       mov       esi,eax
       shl       rsi,5
       lea       rsi,[rcx+rsi+10]
       mov       rdi,[rsi]
       mov       rbp,[rsi+8]
       mov       r14,[rsi+10]
       mov       rsi,[rsi+18]
       sub       r9,rdi
       sub       r11,rbp
       sub       rbx,r14
       sub       r10,rsi
       imul      r9,r9
       imul      r11,r11
       add       r9,r11
       imul      rbx,rbx
       add       r9,rbx
       imul      r10,r10
       add       r10,r9
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 148
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Int64, System.Private.CoreLib]].Transform()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,2096EC00360
       mov       rax,[rax]
       mov       rcx,2096EC00368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       mov       r9,[r10]
       mov       r11,[r10+8]
       mov       rbx,[r10+10]
       mov       r10,[r10+18]
       lea       rsi,[r11+r11*4]
       add       rsi,r9
       lea       rdi,[rbx+rbx*8]
       add       rsi,rdi
       imul      rdi,r10,0D
       add       rsi,rdi
       lea       rdi,[r9+r9]
       lea       rbp,[r11+r11*2]
       lea       rdi,[rdi+rbp*2]
       lea       rbp,[rbx+rbx*4]
       lea       rdi,[rdi+rbp*2]
       imul      rbp,r10,0E
       add       rdi,rbp
       lea       rbp,[r9+r9*2]
       lea       r14,[r11*8]
       sub       r14,r11
       add       rbp,r14
       imul      r14,rbx,0B
       add       rbp,r14
       mov       r14,r10
       shl       r14,4
       sub       r14,r10
       add       rbp,r14
       shl       r9,2
       lea       r9,[r9+r11*8]
       lea       r11,[rbx+rbx*2]
       lea       r9,[r9+r11*4]
       shl       r10,4
       add       r10,r9
       lea       r9,[rcx+rdx]
       mov       [r9],rsi
       mov       [r9+8],rdi
       mov       [r9+10],rbp
       mov       [r9+18],r10
       add       rdx,20
       dec       r8d
       jne       near ptr M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 210
```

