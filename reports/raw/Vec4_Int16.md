## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             | 134.53 μs | 0.128 μs | 0.107 μs |     155 B |
| Subtract        | 134.34 μs | 0.151 μs | 0.134 μs |     155 B |
| Multiply        | 138.34 μs | 0.240 μs | 0.225 μs |     159 B |
| Divide          | 432.25 μs | 0.760 μs | 0.711 μs |     165 B |
| Sum             |  67.81 μs | 0.088 μs | 0.078 μs |      89 B |
| Dot             | 184.10 μs | 0.276 μs | 0.258 μs |     154 B |
| LengthSquared   | 159.06 μs | 0.500 μs | 0.467 μs |     120 B |
| DistanceSquared | 245.73 μs | 0.638 μs | 0.597 μs |     200 B |
| Transform       | 346.84 μs | 0.629 μs | 0.526 μs |     344 B |

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Add()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,192EE401568
       mov       rcx,[rcx]
       mov       rdx,192EE401570
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 155
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Subtract()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,20499801568
       mov       rcx,[rcx]
       mov       rdx,20499801570
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 155
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Multiply()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,1DE59401568
       mov       rcx,[rcx]
       mov       rdx,1DE59401570
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 159
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Divide()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       ecx,ecx
       mov       rax,13D67C01568
       mov       r8,[rax]
       mov       rax,13D67C01570
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 165
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Sum()
       push      rbx
       mov       rax,2157A801568
       mov       rax,[rax]
       mov       rcx,2157A801578
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
       jne       short M00_L00
       pop       rbx
       ret
; Total bytes of code 89
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Dot()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,26090801568
       mov       rcx,[rcx]
       mov       rdx,26090801578
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 154
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].LengthSquared()
       push      rbx
       mov       rax,2D360001568
       mov       rax,[rax]
       mov       rcx,2D360001578
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
       jne       short M00_L00
       pop       rbx
       ret
; Total bytes of code 120
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].DistanceSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,2E958801568
       mov       rax,[rax]
       mov       rcx,2E958801578
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
       jl        near ptr M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 200
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int16, System.Private.CoreLib]].Transform()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,2D67DC01568
       mov       rax,[rax]
       mov       rcx,2D67DC01570
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
       jne       near ptr M00_L00
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
