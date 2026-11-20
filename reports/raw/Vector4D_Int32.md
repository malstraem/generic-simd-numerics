## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             |  99.01 μs | 0.162 μs | 0.135 μs |     133 B |
| Subtract        | 110.80 μs | 0.232 μs | 0.217 μs |     133 B |
| Multiply        | 120.44 μs | 1.900 μs | 1.777 μs |     137 B |
| Divide          | 432.96 μs | 0.968 μs | 0.858 μs |     154 B |
| Abs             | 112.16 μs | 0.085 μs | 0.080 μs |     146 B |
| Dot             | 106.41 μs | 0.737 μs | 0.575 μs |     133 B |
| LengthSquared   | 114.63 μs | 0.230 μs | 0.215 μs |     114 B |
| DistanceSquared | 150.30 μs | 0.176 μs | 0.156 μs |     144 B |
| Transform       | 189.02 μs | 0.195 μs | 0.183 μs |     203 B |

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Add()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,29FCA001568
       mov       rax,[rax]
       mov       rcx,29FCA001570
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 133
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Subtract()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,1AE48401568
       mov       rax,[rax]
       mov       rcx,1AE48401570
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 133
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Multiply()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,16574C01568
       mov       rax,[rax]
       mov       rcx,16574C01570
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 137
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Divide()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,24A3F801568
       mov       rcx,[rax]
       mov       rax,24A3F801570
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 154
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Abs()
       push      rsi
       push      rbx
       mov       rax,1C57BC01568
       mov       rax,[rax]
       mov       rcx,1C57BC01570
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
       jne       short M00_L00
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 146
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Dot()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,1AA55401568
       mov       rcx,[rcx]
       mov       rdx,1AA55401578
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 133
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].LengthSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,22058401568
       mov       rax,[rax]
       mov       rcx,22058401578
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
       jne       short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 114
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].DistanceSquared()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       xor       eax,eax
       mov       rcx,200BA001568
       mov       rcx,[rcx]
       mov       rdx,200BA001578
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
       jl        short M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 144
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Int32, System.Private.CoreLib]].Transform()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,1E51B001568
       mov       rax,[rax]
       mov       rcx,1E51B001570
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
       jne       near ptr M00_L00
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 203
```
