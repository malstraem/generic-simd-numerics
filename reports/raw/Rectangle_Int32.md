## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method   | Mean      | Error    | StdDev   | Code Size |
|--------- |----------:|---------:|---------:|----------:|
| Contains | 110.62 μs | 0.374 μs | 0.350 μs |     167 B |
| Area     |  52.10 μs | 0.101 μs | 0.094 μs |      80 B |

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
