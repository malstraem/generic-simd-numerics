## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean     | Error   | StdDev  | Code Size |
|---------------- |---------:|--------:|--------:|----------:|
| Add             | 134.4 μs | 0.14 μs | 0.13 μs |     155 B |
| Subtract        | 134.4 μs | 0.10 μs | 0.09 μs |     155 B |
| Multiply        | 138.2 μs | 0.15 μs | 0.14 μs |     159 B |
| Divide          | 432.6 μs | 0.82 μs | 0.77 μs |     165 B |
| Abs             | 183.5 μs | 0.23 μs | 0.21 μs |     204 B |
| Dot             | 183.6 μs | 0.87 μs | 0.81 μs |     150 B |
| LengthSquared   | 169.4 μs | 1.54 μs | 1.44 μs |     141 B |
| DistanceSquared | 232.6 μs | 0.46 μs | 0.43 μs |     183 B |
| Transform       | 287.3 μs | 0.51 μs | 0.47 μs |     274 B |

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int16, System.Private.CoreLib]].Add()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,15E61001568
       mov       rcx,[rcx]
       mov       rdx,15E61001570
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
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int16, System.Private.CoreLib]].Subtract()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,23C2E001568
       mov       rcx,[rcx]
       mov       rdx,23C2E001570
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
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int16, System.Private.CoreLib]].Multiply()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,29B2C801568
       mov       rcx,[rcx]
       mov       rdx,29B2C801570
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
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int16, System.Private.CoreLib]].Divide()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       ecx,ecx
       mov       rax,244AFC01568
       mov       r8,[rax]
       mov       rax,244AFC01570
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
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int16, System.Private.CoreLib]].Abs()
       push      rsi
       push      rbx
       mov       rax,14F46C01568
       mov       rax,[rax]
       mov       rcx,14F46C01570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       movsx     r9,word ptr [r10]
       movsx     r11,word ptr [r10+2]
       movsx     rbx,word ptr [r10+4]
       movsx     r10,word ptr [r10+6]
       movzx     r9d,r9w
       vmovd     xmm0,r9d
       vpabsw    xmm0,xmm0
       vmovd     r9d,xmm0
       movzx     r9d,r9w
       movsx     r9,r9w
       movzx     r11d,r11w
       vmovd     xmm0,r11d
       vpabsw    xmm0,xmm0
       vmovd     r11d,xmm0
       movzx     r11d,r11w
       movsx     r11,r11w
       movzx     ebx,bx
       vmovd     xmm0,ebx
       vpabsw    xmm0,xmm0
       vmovd     ebx,xmm0
       movzx     ebx,bx
       movsx     rbx,bx
       movzx     r10d,r10w
       vmovd     xmm0,r10d
       vpabsw    xmm0,xmm0
       vmovd     r10d,xmm0
       movzx     r10d,r10w
       movsx     r10,r10w
       lea       rsi,[rcx+rdx]
       mov       [rsi],r9w
       mov       [rsi+2],r11w
       mov       [rsi+4],bx
       mov       [rsi+6],r10w
       add       rdx,8
       dec       r8d
       jne       near ptr M00_L00
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 204
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int16, System.Private.CoreLib]].Dot()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,228A1001568
       mov       rcx,[rcx]
       mov       rdx,228A1001578
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
       add       r9d,r11d
       movsx     r9,r9w
       imul      ebx,r14d
       add       r9d,ebx
       movsx     r9,r9w
       imul      r10d,esi
       movsx     r10,r10w
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
; Total bytes of code 150
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int16, System.Private.CoreLib]].LengthSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,1D5BE001568
       mov       rax,[rax]
       mov       rcx,1D5BE001578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       movsx     r9,word ptr [r10]
       movsx     r11,r9w
       movsx     rbx,word ptr [r10+2]
       movsx     rsi,bx
       movsx     rdi,word ptr [r10+4]
       movsx     rbp,di
       movsx     r10,word ptr [r10+6]
       movsx     r14,r10w
       imul      r9d,r11d
       movsx     r9,r9w
       imul      ebx,esi
       add       r9d,ebx
       movsx     r9,r9w
       imul      edi,ebp
       add       r9d,edi
       movsx     r9,r9w
       imul      r10d,r14d
       movsx     r10,r10w
       add       r10d,r9d
       mov       [rcx+rdx+10],r10w
       add       rdx,2
       dec       r8d
       jne       short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 141
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int16, System.Private.CoreLib]].DistanceSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,1E0FD001568
       mov       rax,[rax]
       mov       rcx,1E0FD001578
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       lea       r8,[rax+rdx*8+10]
       movsx     r10,word ptr [r8]
       movsx     r9,word ptr [r8+2]
       movsx     r11,word ptr [r8+4]
       movsx     r8,word ptr [r8+6]
       lea       ebx,[rdx+1]
       mov       esi,ebx
       lea       rsi,[rax+rsi*8+10]
       movsx     rdi,word ptr [rsi]
       movsx     rbp,word ptr [rsi+2]
       movsx     r14,word ptr [rsi+4]
       movsx     rsi,word ptr [rsi+6]
       sub       r10d,edi
       movsx     r10,r10w
       sub       r9d,ebp
       movsx     r9,r9w
       sub       r11d,r14d
       movsx     r11,r11w
       sub       r8d,esi
       movsx     r8,r8w
       imul      r10d,r10d
       movsx     r10,r10w
       imul      r9d,r9d
       add       r10d,r9d
       movsx     r10,r10w
       imul      r11d,r11d
       add       r10d,r11d
       movsx     r10,r10w
       imul      r8d,r8d
       movsx     r8,r8w
       add       r8d,r10d
       mov       [rcx+rdx*2+10],r8w
       mov       edx,ebx
       cmp       edx,1869F
       jl        near ptr M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 183
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int16, System.Private.CoreLib]].Transform()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,22698C01568
       mov       rax,[rax]
       mov       rcx,22698C01570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       movsx     r9,word ptr [r10]
       movsx     r11,r9w
       movsx     rbx,word ptr [r10+2]
       movsx     rsi,word ptr [r10+4]
       movsx     r10,word ptr [r10+6]
       lea       edi,[rbx+rbx*4]
       add       r9d,edi
       movsx     r9,r9w
       lea       edi,[rsi+rsi*8]
       add       r9d,edi
       movsx     r9,r9w
       imul      edi,r10d,0D
       add       r9d,edi
       movsx     r9,r9w
       lea       edi,[r11+r11]
       movsx     rdi,di
       lea       ebp,[rbx+rbx*2]
       lea       edi,[rdi+rbp*2]
       movsx     rdi,di
       lea       ebp,[rsi+rsi*4]
       lea       edi,[rdi+rbp*2]
       movsx     rdi,di
       imul      ebp,r10d,0E
       add       edi,ebp
       movsx     rdi,di
       lea       ebp,[r11+r11*2]
       movsx     rbp,bp
       lea       r14d,[rbx*8]
       sub       r14d,ebx
       add       ebp,r14d
       movsx     rbp,bp
       imul      r14d,esi,0B
       add       ebp,r14d
       movsx     rbp,bp
       mov       r14d,r10d
       shl       r14d,4
       sub       r14d,r10d
       add       ebp,r14d
       movsx     rbp,bp
       shl       r11d,2
       movsx     r11,r11w
       lea       r11d,[r11+rbx*8]
       movsx     r11,r11w
       lea       ebx,[rsi+rsi*2]
       lea       r11d,[r11+rbx*4]
       movsx     r11,r11w
       shl       r10d,4
       add       r10d,r11d
       movsx     r10,r10w
       lea       r11,[rcx+rdx]
       mov       [r11],r9w
       mov       [r11+2],di
       mov       [r11+4],bp
       mov       [r11+6],r10w
       add       rdx,8
       dec       r8d
       jne       near ptr M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 274
```
