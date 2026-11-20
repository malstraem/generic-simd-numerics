## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method     | Mean      | Error    | StdDev   | Code Size |
|----------- |----------:|---------:|---------:|----------:|
| Intersects | 117.34 μs | 1.279 μs | 1.196 μs |     198 B |
| Contains   | 112.35 μs | 1.108 μs | 1.036 μs |     167 B |
| Area       |  53.16 μs | 0.337 μs | 0.315 μs |      80 B |

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Int32, System.Private.CoreLib]].Intersects()
       push      rdi
       push      rsi
       push      rbx
       xor       eax,eax
       jmp       short M00_L02
M00_L00:
       mov       r8d,1
M00_L01:
       mov       [r11+rdx+10],r8b
       cmp       eax,1869F
       jge       near ptr M00_L05
M00_L02:
       mov       rcx,2488B800BB8
       mov       rcx,[rcx]
       mov       edx,eax
       mov       r8,rdx
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       r10d,[r8]
       mov       r9d,[r8+4]
       mov       r11d,[r8+8]
       mov       r8d,[r8+0C]
       inc       eax
       mov       ebx,eax
       shl       rbx,4
       lea       rcx,[rcx+rbx+10]
       mov       ebx,[rcx]
       mov       esi,[rcx+4]
       mov       edi,[rcx+8]
       mov       ecx,[rcx+0C]
       add       r11d,r10d
       add       r8d,r9d
       cmp       ebx,r10d
       jl        short M00_L06
       cmp       esi,r9d
       jl        short M00_L06
       cmp       ebx,r11d
       jg        short M00_L06
       cmp       esi,r8d
       setle     r8b
       movzx     r8d,r8b
M00_L03:
       mov       r11,2488B800BC0
       mov       r11,[r11]
       test      r8d,r8d
       jne       near ptr M00_L00
       add       edi,ebx
       add       ecx,esi
       cmp       r10d,ebx
       jl        short M00_L07
       cmp       r9d,esi
       jl        short M00_L07
       cmp       r10d,edi
       jg        short M00_L07
       cmp       r9d,ecx
       setle     r8b
       movzx     r8d,r8b
M00_L04:
       jmp       near ptr M00_L01
M00_L05:
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L06:
       xor       r8d,r8d
       jmp       short M00_L03
M00_L07:
       xor       r8d,r8d
       jmp       short M00_L04
; Total bytes of code 198
```

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
       mov       rcx,1E471000BB8
       mov       rcx,[rcx]
       mov       rdx,1E471000BC0
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

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Int32, System.Private.CoreLib]].Area()
       mov       rax,1AB6BC00BC8
       mov       rax,[rax]
       mov       rcx,1AB6BC00BD8
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
