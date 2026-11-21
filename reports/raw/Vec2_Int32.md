## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             |  76.78 μs | 0.328 μs | 0.291 μs |     104 B |
| Subtract        |  57.36 μs | 0.137 μs | 0.114 μs |      91 B |
| Multiply        |  59.32 μs | 0.337 μs | 0.315 μs |      93 B |
| Divide          | 217.66 μs | 0.333 μs | 0.278 μs |      94 B |
| Sum             |  39.26 μs | 0.148 μs | 0.131 μs |      64 B |
| Dot             |  58.42 μs | 0.303 μs | 0.284 μs |      89 B |
| LengthSquared   |  42.99 μs | 0.282 μs | 0.264 μs |      72 B |
| DistanceSquared |  75.15 μs | 0.580 μs | 0.542 μs |      94 B |

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Int32, System.Private.CoreLib]].Add()
       sub       rsp,18
       xor       eax,eax
       mov       rcx,2B8EE401560
       mov       rcx,[rcx]
       mov       rdx,2B8EE401568
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+10],r10
       inc       eax
       mov       r10d,eax
       mov       r10,[rcx+r10*8+10]
       mov       [rsp+8],r10
       vmovsd    xmm0,qword ptr [rsp+10]
       vmovsd    xmm1,qword ptr [rsp+8]
       vpaddd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rsp+10],xmm0
       mov       r10,[rsp+10]
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       add       rsp,18
       ret
; Total bytes of code 104
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Int32, System.Private.CoreLib]].Subtract()
       push      rbx
       xor       eax,eax
       mov       rcx,224FA001560
       mov       rcx,[rcx]
       mov       rdx,224FA001568
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       inc       eax
       mov       r11d,eax
       lea       r11,[rcx+r11*8+10]
       mov       ebx,[r11]
       mov       r11d,[r11+4]
       sub       r9d,ebx
       sub       r10d,r11d
       lea       r8,[rdx+r8*8+10]
       mov       [r8],r9d
       mov       [r8+4],r10d
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       ret
; Total bytes of code 91
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Int32, System.Private.CoreLib]].Multiply()
       push      rbx
       xor       eax,eax
       mov       rcx,239F5001560
       mov       rcx,[rcx]
       mov       rdx,239F5001568
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       inc       eax
       mov       r11d,eax
       lea       r11,[rcx+r11*8+10]
       mov       ebx,[r11]
       mov       r11d,[r11+4]
       imul      r9d,ebx
       imul      r10d,r11d
       lea       r8,[rdx+r8*8+10]
       mov       [r8],r9d
       mov       [r8+4],r10d
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       ret
; Total bytes of code 93
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Int32, System.Private.CoreLib]].Divide()
       push      rsi
       push      rbx
       xor       ecx,ecx
       mov       rax,1A502401560
       mov       r8,[rax]
       mov       rax,1A502401568
       mov       r10,[rax]
       xchg      ax,ax
M00_L00:
       mov       r9d,ecx
       lea       rax,[r8+r9*8+10]
       mov       edx,[rax]
       mov       r11d,[rax+4]
       inc       ecx
       mov       eax,ecx
       lea       rax,[r8+rax*8+10]
       mov       ebx,[rax]
       mov       esi,[rax+4]
       mov       eax,edx
       cdq
       idiv      ebx
       mov       ebx,eax
       mov       eax,r11d
       cdq
       idiv      esi
       lea       rdx,[r10+r9*8+10]
       mov       [rdx],ebx
       mov       [rdx+4],eax
       cmp       ecx,1869F
       jl        short M00_L00
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 94
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Int32, System.Private.CoreLib]].Sum()
       mov       rax,24752001560
       mov       rax,[rax]
       mov       rcx,24752001570
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       add       r10d,r9d
       mov       [rcx+rdx+10],r10d
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 64
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Int32, System.Private.CoreLib]].Dot()
       push      rbx
       xor       eax,eax
       mov       rcx,231B3001560
       mov       rcx,[rcx]
       mov       rdx,231B3001570
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       inc       eax
       mov       r9d,eax
       lea       r9,[rcx+r9*8+10]
       mov       r11d,[r9]
       mov       r9d,[r9+4]
       mov       ebx,[r10]
       mov       r10d,[r10+4]
       imul      r11d,ebx
       imul      r10d,r9d
       add       r10d,r11d
       mov       [rdx+r8*4+10],r10d
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       ret
; Total bytes of code 89
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Int32, System.Private.CoreLib]].LengthSquared()
       mov       rax,20D47401560
       mov       rax,[rax]
       mov       rcx,20D47401570
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       imul      r9d,r9d
       imul      r10d,r10d
       add       r10d,r9d
       mov       [rcx+rdx+10],r10d
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 72
```

```assembly
; System.Numerics.Bench.BaseStressVec2`1[[System.Int32, System.Private.CoreLib]].DistanceSquared()
       push      rbx
       xor       eax,eax
       mov       rcx,23775401560
       mov       rcx,[rcx]
       mov       rdx,23775401570
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       inc       eax
       mov       r9d,eax
       lea       r9,[rcx+r9*8+10]
       mov       r11d,[r9]
       mov       r9d,[r9+4]
       mov       ebx,[r10]
       mov       r10d,[r10+4]
       sub       ebx,r11d
       sub       r10d,r9d
       imul      ebx,ebx
       imul      r10d,r10d
       add       r10d,ebx
       mov       [rdx+r8*4+10],r10d
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       ret
; Total bytes of code 94
```
