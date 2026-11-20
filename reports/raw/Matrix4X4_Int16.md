## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean       | Error     | StdDev    | Code Size |
|---------- |-----------:|----------:|----------:|----------:|
| Add       |   780.3 μs |  12.64 μs |  11.82 μs |     776 B |
| Subtract  |   806.5 μs |   8.71 μs |   7.72 μs |     776 B |
| Multiply  | 6,377.4 μs | 127.28 μs | 125.01 μs |   2,985 B |
| Transpose |   349.8 μs |   6.23 μs |   5.82 μs |     296 B |

```assembly
; System.Numerics.Bench.BaseStressMatrix4X4`1[[System.Int16, System.Private.CoreLib]].Add()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       cmp       eax,[r10+8]
       jae       near ptr 00000000000030C2
       mov       r9,rax
       shl       r9,5
       lea       r10,[r10+r9+10]
       movsx     r11,word ptr [r10]
       movsx     rbx,word ptr [r10+2]
       movsx     rsi,word ptr [r10+4]
       movsx     rdi,word ptr [r10+6]
       movsx     rbp,word ptr [r10+8]
       mov       [rsp+78],ebp
       movsx     r14,word ptr [r10+0A]
       mov       [rsp+74],r14d
       movsx     r15,word ptr [r10+0C]
       mov       [rsp+70],r15d
       movsx     r13,word ptr [r10+0E]
       mov       [rsp+6C],r13d
       movsx     r12,word ptr [r10+10]
       mov       [rsp+68],r12d
       movsx     r12,word ptr [r10+12]
       mov       [rsp+64],r12d
       movsx     r12,word ptr [r10+14]
       mov       [rsp+60],r12d
       movsx     r12,word ptr [r10+16]
       mov       [rsp+5C],r12d
       movsx     r12,word ptr [r10+18]
       mov       [rsp+58],r12d
       movsx     r12,word ptr [r10+1A]
       mov       [rsp+54],r12d
       movsx     r12,word ptr [r10+1C]
       mov       [rsp+50],r12d
       movsx     r10,word ptr [r10+1E]
       mov       [rsp+4C],r10d
       lea       r10d,[rax+1]
       cmp       r10d,[r8+8]
       jae       near ptr 00000000000030C2
       mov       r12d,r10d
       shl       r12,5
       lea       r8,[r8+r12+10]
       movsx     r12,word ptr [r8]
       movsx     r13,word ptr [r8+2]
       movsx     r15,word ptr [r8+4]
       movsx     r14,word ptr [r8+6]
       movsx     rbp,word ptr [r8+8]
       mov       [rsp+48],ebp
       movsx     rbp,word ptr [r8+0A]
       mov       [rsp+44],ebp
       movsx     rbp,word ptr [r8+0C]
       mov       [rsp+40],ebp
       movsx     rbp,word ptr [r8+0E]
       mov       [rsp+3C],ebp
       movsx     rbp,word ptr [r8+10]
       mov       [rsp+38],ebp
       movsx     rbp,word ptr [r8+12]
       mov       [rsp+34],ebp
       movsx     rbp,word ptr [r8+14]
       mov       [rsp+30],ebp
       movsx     rbp,word ptr [r8+16]
       mov       [rsp+2C],ebp
       movsx     rbp,word ptr [r8+18]
       mov       [rsp+28],ebp
       movsx     rbp,word ptr [r8+1A]
       mov       [rsp+24],ebp
       movsx     rbp,word ptr [r8+1C]
       movsx     r8,word ptr [r8+1E]
       add       r11d,r12d
       movsx     r11,r11w
       add       ebx,r13d
       movsx     rbx,bx
       add       esi,r15d
       movsx     rsi,si
       add       edi,r14d
       movsx     rdi,di
       mov       [rsp+94],edi
       mov       r14d,[rsp+78]
       mov       r15d,[rsp+48]
       add       r14d,r15d
       movsx     r14,r14w
       mov       r15d,[rsp+74]
       mov       r13d,[rsp+44]
       add       r15d,r13d
       movsx     r15,r15w
       mov       r13d,[rsp+70]
       mov       r12d,[rsp+40]
       add       r13d,r12d
       movsx     r13,r13w
       mov       r12d,[rsp+6C]
       mov       edi,[rsp+3C]
       add       edi,r12d
       movsx     rdi,di
       mov       [rsp+90],edi
       mov       [rsp+8C],r14d
       mov       [rsp+88],r15d
       mov       [rsp+84],r13d
       mov       r12d,[rsp+68]
       mov       edi,[rsp+38]
       add       edi,r12d
       movsx     rdi,di
       mov       r12d,[rsp+64]
       mov       r13d,[rsp+34]
       add       r13d,r12d
       movsx     r13,r13w
       mov       r12d,[rsp+60]
       mov       r15d,[rsp+30]
       add       r15d,r12d
       movsx     r15,r15w
       mov       r12d,[rsp+5C]
       mov       r14d,[rsp+2C]
       add       r14d,r12d
       movsx     r14,r14w
       mov       [rsp+80],r14d
       mov       [rsp+7C],r15d
       mov       r12d,[rsp+58]
       mov       r14d,[rsp+28]
       add       r14d,r12d
       movsx     r14,r14w
       mov       r12d,[rsp+54]
       mov       r15d,[rsp+24]
       add       r15d,r12d
       movsx     r15,r15w
       mov       r12d,[rsp+50]
       add       ebp,r12d
       movsx     rbp,bp
       mov       r12d,[rsp+4C]
       add       r8d,r12d
       movsx     r8,r8w
       cmp       eax,[rdx+8]
       jae       near ptr 00000000000030C2
       lea       rax,[rdx+r9+10]
       mov       [rax],r11w
       mov       [rax+2],bx
       mov       [rax+4],si
       mov       edx,[rsp+94]
       mov       [rax+6],dx
       mov       edx,[rsp+8C]
       mov       [rax+8],dx
       mov       edx,[rsp+88]
       mov       [rax+0A],dx
       mov       edx,[rsp+84]
       mov       [rax+0C],dx
       mov       edx,[rsp+90]
       mov       [rax+0E],dx
       mov       [rax+10],di
       mov       [rax+12],r13w
       mov       edx,[rsp+7C]
       mov       [rax+14],dx
       mov       edx,[rsp+80]
       mov       [rax+16],dx
       mov       [rax+18],r14w
       mov       [rax+1A],r15w
       mov       [rax+1C],bp
       mov       [rax+1E],r8w
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000002DD5
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 776
```

```assembly
; System.Numerics.Bench.BaseStressMatrix4X4`1[[System.Int16, System.Private.CoreLib]].Subtract()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       cmp       eax,[r10+8]
       jae       near ptr 00000000000036C2
       mov       r9,rax
       shl       r9,5
       lea       r10,[r10+r9+10]
       movsx     r11,word ptr [r10]
       movsx     rbx,word ptr [r10+2]
       movsx     rsi,word ptr [r10+4]
       movsx     rdi,word ptr [r10+6]
       movsx     rbp,word ptr [r10+8]
       mov       [rsp+78],ebp
       movsx     r14,word ptr [r10+0A]
       mov       [rsp+74],r14d
       movsx     r15,word ptr [r10+0C]
       mov       [rsp+70],r15d
       movsx     r13,word ptr [r10+0E]
       mov       [rsp+6C],r13d
       movsx     r12,word ptr [r10+10]
       mov       [rsp+68],r12d
       movsx     r12,word ptr [r10+12]
       mov       [rsp+64],r12d
       movsx     r12,word ptr [r10+14]
       mov       [rsp+60],r12d
       movsx     r12,word ptr [r10+16]
       mov       [rsp+5C],r12d
       movsx     r12,word ptr [r10+18]
       mov       [rsp+58],r12d
       movsx     r12,word ptr [r10+1A]
       mov       [rsp+54],r12d
       movsx     r12,word ptr [r10+1C]
       mov       [rsp+50],r12d
       movsx     r10,word ptr [r10+1E]
       mov       [rsp+4C],r10d
       lea       r10d,[rax+1]
       cmp       r10d,[r8+8]
       jae       near ptr 00000000000036C2
       mov       r12d,r10d
       shl       r12,5
       lea       r8,[r8+r12+10]
       movsx     r12,word ptr [r8]
       movsx     r13,word ptr [r8+2]
       movsx     r15,word ptr [r8+4]
       movsx     r14,word ptr [r8+6]
       movsx     rbp,word ptr [r8+8]
       mov       [rsp+48],ebp
       movsx     rbp,word ptr [r8+0A]
       mov       [rsp+44],ebp
       movsx     rbp,word ptr [r8+0C]
       mov       [rsp+40],ebp
       movsx     rbp,word ptr [r8+0E]
       mov       [rsp+3C],ebp
       movsx     rbp,word ptr [r8+10]
       mov       [rsp+38],ebp
       movsx     rbp,word ptr [r8+12]
       mov       [rsp+34],ebp
       movsx     rbp,word ptr [r8+14]
       mov       [rsp+30],ebp
       movsx     rbp,word ptr [r8+16]
       mov       [rsp+2C],ebp
       movsx     rbp,word ptr [r8+18]
       mov       [rsp+28],ebp
       movsx     rbp,word ptr [r8+1A]
       mov       [rsp+24],ebp
       movsx     rbp,word ptr [r8+1C]
       movsx     r8,word ptr [r8+1E]
       sub       r11d,r12d
       movsx     r11,r11w
       sub       ebx,r13d
       movsx     rbx,bx
       sub       esi,r15d
       movsx     rsi,si
       sub       edi,r14d
       movsx     rdi,di
       mov       [rsp+94],edi
       mov       r14d,[rsp+78]
       mov       r15d,[rsp+48]
       sub       r14d,r15d
       movsx     r14,r14w
       mov       r15d,[rsp+74]
       mov       r13d,[rsp+44]
       sub       r15d,r13d
       movsx     r15,r15w
       mov       r13d,[rsp+70]
       mov       r12d,[rsp+40]
       sub       r13d,r12d
       movsx     r13,r13w
       mov       r12d,[rsp+6C]
       mov       edi,[rsp+3C]
       sub       r12d,edi
       movsx     rdi,r12w
       mov       [rsp+90],edi
       mov       [rsp+8C],r14d
       mov       [rsp+88],r15d
       mov       [rsp+84],r13d
       mov       r12d,[rsp+68]
       mov       edi,[rsp+38]
       sub       r12d,edi
       movsx     rdi,r12w
       mov       r12d,[rsp+64]
       mov       r13d,[rsp+34]
       sub       r12d,r13d
       movsx     r13,r12w
       mov       r12d,[rsp+60]
       mov       r15d,[rsp+30]
       sub       r12d,r15d
       movsx     r15,r12w
       mov       r12d,[rsp+5C]
       mov       r14d,[rsp+2C]
       sub       r12d,r14d
       movsx     r14,r12w
       mov       [rsp+80],r14d
       mov       [rsp+7C],r15d
       mov       r12d,[rsp+58]
       mov       r14d,[rsp+28]
       sub       r12d,r14d
       movsx     r14,r12w
       mov       r12d,[rsp+54]
       mov       r15d,[rsp+24]
       sub       r12d,r15d
       movsx     r15,r12w
       mov       r12d,[rsp+50]
       sub       r12d,ebp
       movsx     rbp,r12w
       mov       r12d,[rsp+4C]
       sub       r12d,r8d
       movsx     r8,r12w
       cmp       eax,[rdx+8]
       jae       near ptr 00000000000036C2
       lea       rax,[rdx+r9+10]
       mov       [rax],r11w
       mov       [rax+2],bx
       mov       [rax+4],si
       mov       edx,[rsp+94]
       mov       [rax+6],dx
       mov       edx,[rsp+8C]
       mov       [rax+8],dx
       mov       edx,[rsp+88]
       mov       [rax+0A],dx
       mov       edx,[rsp+84]
       mov       [rax+0C],dx
       mov       edx,[rsp+90]
       mov       [rax+0E],dx
       mov       [rax+10],di
       mov       [rax+12],r13w
       mov       edx,[rsp+7C]
       mov       [rax+14],dx
       mov       edx,[rsp+80]
       mov       [rax+16],dx
       mov       [rax+18],r14w
       mov       [rax+1A],r15w
       mov       [rax+1C],bp
       mov       [rax+1E],r8w
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 00000000000033D5
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 776
```

```assembly
; System.Numerics.Bench.BaseStressMatrix4X4`1[[System.Int16, System.Private.CoreLib]].Multiply()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,208
       mov       rbx,rcx
       xor       esi,esi
M00_L00:
       mov       rdi,[rbx+10]
       mov       [rsp+250],rbx
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       cmp       esi,[rdx+8]
       jae       near ptr 0000000000005361
       mov       r8,rsi
       shl       r8,5
       lea       rdx,[rdx+r8+10]
       movsx     r8,word ptr [rdx]
       movsx     r9,word ptr [rdx+2]
       movsx     rax,word ptr [rdx+4]
       mov       [rsp+94],eax
       movsx     r10,word ptr [rdx+6]
       mov       [rsp+90],r10d
       movsx     r11,word ptr [rdx+8]
       mov       [rsp+8C],r11d
       movsx     rbp,word ptr [rdx+0A]
       mov       [rsp+88],ebp
       movsx     r14,word ptr [rdx+0C]
       mov       [rsp+84],r14d
       movsx     r15,word ptr [rdx+0E]
       mov       [rsp+80],r15d
       movsx     r13,word ptr [rdx+10]
       mov       [rsp+7C],r13d
       movsx     r12,word ptr [rdx+12]
       mov       [rsp+78],r12d
       movsx     r12,word ptr [rdx+14]
       mov       [rsp+74],r12d
       movsx     r12,word ptr [rdx+16]
       mov       [rsp+70],r12d
       movsx     r12,word ptr [rdx+18]
       mov       [rsp+6C],r12d
       movsx     r12,word ptr [rdx+1A]
       mov       [rsp+68],r12d
       movsx     r13,word ptr [rdx+1C]
       mov       [rsp+64],r13d
       movsx     rdx,word ptr [rdx+1E]
       mov       [rsp+60],edx
       lea       r13d,[rsi+1]
       cmp       r13d,[rcx+8]
       jae       near ptr 0000000000005361
       lea       r13d,[rsi+1]
       shl       r13,5
       lea       rcx,[rcx+r13+10]
       movsx     r13,word ptr [rcx]
       mov       [rsp+5C],r13d
       movsx     r15,word ptr [rcx+2]
       movsx     rdx,word ptr [rcx+4]
       mov       [rsp+58],edx
       movsx     rbx,word ptr [rcx+6]
       movsx     r12,word ptr [rcx+8]
       movsx     r14,word ptr [rcx+0A]
       movsx     rbp,word ptr [rcx+0C]
       movsx     r11,word ptr [rcx+0E]
       mov       [rsp+54],r11d
       movsx     r10,word ptr [rcx+10]
       mov       [rsp+50],r10d
       movsx     rax,word ptr [rcx+12]
       mov       [rsp+4C],eax
       movsx     rax,word ptr [rcx+14]
       mov       [rsp+48],eax
       movsx     rax,word ptr [rcx+16]
       mov       [rsp+44],eax
       movsx     rax,word ptr [rcx+18]
       mov       [rsp+40],eax
       movsx     rax,word ptr [rcx+1A]
       mov       [rsp+3C],eax
       movsx     rax,word ptr [rcx+1C]
       mov       [rsp+38],eax
       movsx     rcx,word ptr [rcx+1E]
       mov       [rsp+34],ecx
       imul      r13d,r8d
       movsx     r13,r13w
       mov       [rsp+164],r13d
       mov       r13d,r15d
       imul      r13d,r8d
       movsx     r13,r13w
       mov       [rsp+160],r13d
       mov       r13d,edx
       imul      r13d,r8d
       movsx     r13,r13w
       imul      r8d,ebx
       movsx     r8,r8w
       mov       [rsp+15C],r8d
       mov       r8d,[rsp+164]
       mov       [rsp+158],r8d
       mov       r8d,[rsp+160]
       mov       [rsp+154],r8d
       mov       [rsp+150],r13d
       mov       r13d,r12d
       imul      r13d,r9d
       movsx     r13,r13w
       mov       r8d,r14d
       imul      r8d,r9d
       movsx     r8,r8w
       mov       [rsp+14C],r8d
       mov       r8d,ebp
       imul      r8d,r9d
       movsx     r8,r8w
       imul      r9d,r11d
       movsx     r9,r9w
       mov       [rsp+148],r9d
       mov       r9d,[rsp+14C]
       mov       [rsp+144],r8d
       mov       r8d,[rsp+158]
       add       r8d,r13d
       movsx     r8,r8w
       mov       r13d,[rsp+154]
       add       r9d,r13d
       movsx     r9,r9w
       mov       [rsp+140],r9d
       mov       r13d,[rsp+150]
       mov       r9d,[rsp+144]
       add       r9d,r13d
       movsx     r9,r9w
       mov       [rsp+13C],r9d
       mov       r13d,[rsp+15C]
       mov       r9d,[rsp+148]
       add       r9d,r13d
       movsx     r9,r9w
       mov       [rsp+138],r9d
       mov       [rsp+134],r8d
       mov       r13d,[rsp+140]
       mov       [rsp+130],r13d
       mov       r9d,[rsp+13C]
       mov       [rsp+12C],r9d
       mov       r9d,[rsp+94]
       mov       r13d,r10d
       imul      r13d,r9d
       movsx     r13,r13w
       mov       r8d,[rsp+4C]
       imul      r8d,r9d
       movsx     r8,r8w
       mov       r9d,[rsp+48]
       imul      r9d,[rsp+94]
       movsx     r9,r9w
       mov       [rsp+128],r9d
       mov       r9d,[rsp+44]
       imul      r9d,[rsp+94]
       movsx     r9,r9w
       mov       [rsp+124],r9d
       mov       r9d,[rsp+128]
       mov       [rsp+120],r9d
       mov       r9d,[rsp+134]
       add       r9d,r13d
       movsx     r9,r9w
       mov       r13d,[rsp+130]
       add       r8d,r13d
       movsx     r8,r8w
       mov       [rsp+11C],r8d
       mov       r13d,[rsp+12C]
       mov       r8d,[rsp+120]
       add       r8d,r13d
       movsx     r8,r8w
       mov       [rsp+118],r8d
       mov       r13d,[rsp+138]
       mov       r8d,[rsp+124]
       add       r8d,r13d
       movsx     r8,r8w
       mov       [rsp+114],r8d
       mov       [rsp+110],r9d
       mov       r13d,[rsp+11C]
       mov       [rsp+10C],r13d
       mov       r8d,[rsp+118]
       mov       [rsp+108],r8d
       mov       r8d,[rsp+40]
       mov       r13d,[rsp+90]
       mov       r9d,r8d
       imul      r9d,r13d
       movsx     r9,r9w
       mov       r8d,[rsp+3C]
       imul      r8d,r13d
       movsx     r8,r8w
       imul      r13d,eax
       movsx     r13,r13w
       mov       [rsp+104],r13d
       mov       r13d,ecx
       imul      r13d,[rsp+90]
       movsx     r13,r13w
       mov       [rsp+100],r13d
       mov       r13d,[rsp+104]
       mov       [rsp+0FC],r13d
       mov       r13d,[rsp+110]
       add       r9d,r13d
       movsx     r13,r9w
       mov       r9d,[rsp+10C]
       add       r8d,r9d
       movsx     r9,r8w
       mov       [rsp+0F8],r9d
       mov       r8d,[rsp+108]
       mov       r9d,[rsp+0FC]
       add       r8d,r9d
       movsx     r9,r8w
       mov       [rsp+0F4],r9d
       mov       r8d,[rsp+114]
       mov       r9d,[rsp+100]
       add       r8d,r9d
       movsx     r9,r8w
       mov       [rsp+0F0],r9d
       mov       [rsp+0EC],r13d
       mov       r8d,[rsp+0F8]
       mov       [rsp+0E8],r8d
       mov       r13d,[rsp+0F4]
       mov       [rsp+0E4],r13d
       mov       r13d,[rsp+5C]
       mov       r9d,[rsp+8C]
       mov       r8d,r13d
       imul      r8d,r9d
       movsx     r8,r8w
       mov       r13d,r15d
       imul      r13d,r9d
       movsx     r13,r13w
       imul      r9d,edx
       movsx     r9,r9w
       mov       [rsp+0E0],r9d
       mov       r9d,ebx
       imul      r9d,[rsp+8C]
       movsx     r9,r9w
       mov       [rsp+0DC],r9d
       mov       [rsp+0D8],r8d
       mov       [rsp+0D4],r13d
       mov       r13d,[rsp+0E0]
       mov       [rsp+0D0],r13d
       mov       r13d,[rsp+88]
       mov       r9d,r12d
       imul      r9d,r13d
       movsx     r9,r9w
       mov       r8d,r14d
       imul      r8d,r13d
       movsx     r8,r8w
       imul      r13d,ebp
       movsx     r13,r13w
       mov       [rsp+0CC],r13d
       mov       r13d,r11d
       imul      r13d,[rsp+88]
       movsx     r13,r13w
       mov       [rsp+0BC],r13d
       xor       r13d,r13d
       mov       [rsp+0C0],r13
       mov       r13d,[rsp+0BC]
       mov       [rsp+20],r13d
       lea       rcx,[rsp+0C0]
       mov       edx,r9d
       mov       r9d,[rsp+0CC]
       call      qword ptr [7C48]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]]..ctor(Int16, Int16, Int16, Int16)
       movsx     rcx,word ptr [rsp+0C0]
       movsx     rdx,word ptr [rsp+0C2]
       movsx     r8,word ptr [rsp+0C4]
       movsx     r9,word ptr [rsp+0C6]
       mov       r13d,[rsp+0D8]
       add       ecx,r13d
       movsx     rax,cx
       mov       r13d,[rsp+0D4]
       add       edx,r13d
       movsx     r10,dx
       mov       r13d,[rsp+0D0]
       add       r8d,r13d
       movsx     r11,r8w
       mov       r13d,[rsp+0DC]
       add       r9d,r13d
       movsx     rcx,r9w
       xor       edx,edx
       mov       [rsp+0B0],rdx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+0B0]
       mov       edx,eax
       mov       r8d,r10d
       mov       r9d,r11d
       call      qword ptr [7C48]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]]..ctor(Int16, Int16, Int16, Int16)
       mov       rcx,[rsp+0B0]
       mov       [rsp+200],rcx
       mov       ecx,[rsp+50]
       mov       edx,[rsp+84]
       call      qword ptr [4768]; Silk.NET.Maths.Scalar.Multiply[[System.Int16, System.Private.CoreLib]](Int16, Int16)
       mov       r13d,eax
       mov       ecx,[rsp+4C]
       mov       edx,[rsp+84]
       call      qword ptr [4768]; Silk.NET.Maths.Scalar.Multiply[[System.Int16, System.Private.CoreLib]](Int16, Int16)
       mov       [rsp+0AC],eax
       mov       ecx,[rsp+48]
       mov       edx,[rsp+84]
       call      qword ptr [4768]; Silk.NET.Maths.Scalar.Multiply[[System.Int16, System.Private.CoreLib]](Int16, Int16)
       mov       [rsp+0A8],eax
       xor       ecx,ecx
       mov       [rsp+0A0],rcx
       mov       ecx,[rsp+44]
       mov       edx,[rsp+84]
       call      qword ptr [4768]; Silk.NET.Maths.Scalar.Multiply[[System.Int16, System.Private.CoreLib]](Int16, Int16)
       mov       [rsp+20],eax
       lea       rcx,[rsp+0A0]
       mov       edx,r13d
       mov       r8d,[rsp+0AC]
       mov       r9d,[rsp+0A8]
       call      qword ptr [7C48]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]]..ctor(Int16, Int16, Int16, Int16)
       mov       rcx,[rsp+200]
       mov       rdx,[rsp+0A0]
       call      qword ptr [45E8]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       mov       [rsp+1F8],rax
       mov       r13d,[rsp+40]
       movzx     ecx,r13w
       mov       eax,[rsp+3C]
       movzx     edx,ax
       shl       edx,10
       or        ecx,edx
       mov       r8d,[rsp+38]
       movzx     edx,r8w
       shl       rdx,20
       or        rcx,rdx
       mov       r10d,[rsp+34]
       mov       edx,r10d
       shl       rdx,30
       or        rcx,rdx
       mov       edx,[rsp+80]
       call      qword ptr [0C060]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Int16>, Int16)
       mov       [rsp+1F0],rax
       mov       rcx,[rsp+1F8]
       mov       rdx,[rsp+1F0]
       call      qword ptr [45E8]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       mov       [rsp+1E8],rax
       mov       eax,[rsp+5C]
       movzx     ecx,ax
       movzx     edx,r15w
       shl       edx,10
       or        ecx,edx
       mov       r8d,[rsp+58]
       movzx     edx,r8w
       shl       rdx,20
       or        rcx,rdx
       mov       edx,ebx
       shl       rdx,30
       or        rcx,rdx
       mov       edx,[rsp+7C]
       call      qword ptr [0C060]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Int16>, Int16)
       mov       [rsp+1E0],rax
       movzx     ecx,r12w
       movzx     edx,r14w
       shl       edx,10
       or        ecx,edx
       movzx     edx,bp
       shl       rdx,20
       or        rcx,rdx
       mov       eax,[rsp+54]
       mov       edx,eax
       shl       rdx,30
       or        rcx,rdx
       mov       edx,[rsp+78]
       call      qword ptr [0C060]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Int16>, Int16)
       mov       [rsp+1D8],rax
       mov       rcx,[rsp+1E0]
       mov       rdx,[rsp+1D8]
       call      qword ptr [45E8]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       mov       [rsp+1D0],rax
       mov       eax,[rsp+50]
       movzx     ecx,ax
       mov       r8d,[rsp+4C]
       movzx     edx,r8w
       shl       edx,10
       or        ecx,edx
       mov       r10d,[rsp+48]
       movzx     edx,r10w
       shl       rdx,20
       or        rcx,rdx
       mov       r9d,[rsp+44]
       mov       edx,r9d
       shl       rdx,30
       or        rcx,rdx
       mov       edx,[rsp+74]
       call      qword ptr [0C060]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Int16>, Int16)
       mov       [rsp+1C8],rax
       mov       rcx,[rsp+1D0]
       mov       rdx,[rsp+1C8]
       call      qword ptr [45E8]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       mov       [rsp+1C0],rax
       movzx     ecx,r13w
       mov       eax,[rsp+3C]
       movzx     edx,ax
       shl       edx,10
       or        ecx,edx
       mov       r8d,[rsp+38]
       movzx     edx,r8w
       shl       rdx,20
       or        rcx,rdx
       mov       r10d,[rsp+34]
       mov       edx,r10d
       shl       rdx,30
       or        rcx,rdx
       mov       edx,[rsp+70]
       call      qword ptr [0C060]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Int16>, Int16)
       mov       [rsp+1B8],rax
       mov       rcx,[rsp+1C0]
       mov       rdx,[rsp+1B8]
       call      qword ptr [45E8]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       mov       [rsp+1B0],rax
       mov       ecx,[rsp+5C]
       movzx     ecx,cx
       movzx     edx,r15w
       shl       edx,10
       or        ecx,edx
       mov       r15d,[rsp+58]
       movzx     edx,r15w
       shl       rdx,20
       or        rcx,rdx
       mov       edx,ebx
       shl       rdx,30
       or        rcx,rdx
       mov       edx,[rsp+6C]
       call      qword ptr [0C060]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Int16>, Int16)
       mov       [rsp+1A8],rax
       mov       ecx,r12d
       mov       edx,[rsp+68]
       call      qword ptr [4768]; Silk.NET.Maths.Scalar.Multiply[[System.Int16, System.Private.CoreLib]](Int16, Int16)
       mov       ebx,eax
       mov       ecx,r14d
       mov       edx,[rsp+68]
       call      qword ptr [4768]; Silk.NET.Maths.Scalar.Multiply[[System.Int16, System.Private.CoreLib]](Int16, Int16)
       mov       r14d,eax
       mov       ecx,ebp
       mov       edx,[rsp+68]
       call      qword ptr [4768]; Silk.NET.Maths.Scalar.Multiply[[System.Int16, System.Private.CoreLib]](Int16, Int16)
       mov       ebp,eax
       xor       ecx,ecx
       mov       [rsp+98],rcx
       mov       ecx,[rsp+54]
       mov       edx,[rsp+68]
       call      qword ptr [4768]; Silk.NET.Maths.Scalar.Multiply[[System.Int16, System.Private.CoreLib]](Int16, Int16)
       mov       [rsp+20],eax
       lea       rcx,[rsp+98]
       mov       edx,ebx
       mov       r8d,r14d
       mov       r9d,ebp
       call      qword ptr [7C48]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]]..ctor(Int16, Int16, Int16, Int16)
       mov       rcx,[rsp+1A8]
       mov       rdx,[rsp+98]
       call      qword ptr [45E8]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       mov       [rsp+1A0],rax
       mov       ebx,[rsp+50]
       movzx     ecx,bx
       mov       ebx,[rsp+4C]
       movzx     edx,bx
       shl       edx,10
       or        ecx,edx
       mov       ebx,[rsp+48]
       movzx     edx,bx
       shl       rdx,20
       or        rcx,rdx
       mov       ebx,[rsp+44]
       mov       edx,ebx
       shl       rdx,30
       or        rcx,rdx
       mov       edx,[rsp+64]
       call      qword ptr [0C060]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Int16>, Int16)
       mov       [rsp+198],rax
       mov       rcx,[rsp+1A0]
       mov       rdx,[rsp+198]
       call      qword ptr [45E8]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       mov       [rsp+190],rax
       movzx     ecx,r13w
       mov       ebx,[rsp+3C]
       movzx     edx,bx
       shl       edx,10
       or        ecx,edx
       mov       ebx,[rsp+38]
       movzx     edx,bx
       shl       rdx,20
       or        rcx,rdx
       mov       ebx,[rsp+34]
       mov       edx,ebx
       shl       rdx,30
       or        rcx,rdx
       mov       edx,[rsp+60]
       call      qword ptr [0C060]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Int16>, Int16)
       mov       [rsp+188],rax
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+168],ymm0
       mov       rcx,[rsp+190]
       mov       rdx,[rsp+188]
       call      qword ptr [45E8]; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       mov       [rsp+20],rax
       mov       r13d,[rsp+0EC]
       movzx     edx,r13w
       mov       ebx,[rsp+0E8]
       movzx     ecx,bx
       shl       ecx,10
       or        edx,ecx
       mov       r13d,[rsp+0E4]
       movzx     ecx,r13w
       shl       rcx,20
       or        rdx,rcx
       mov       ebx,[rsp+0F0]
       mov       ecx,ebx
       shl       rcx,30
       or        rdx,rcx
       lea       rcx,[rsp+168]
       mov       r8,[rsp+1E8]
       mov       r9,[rsp+1B0]
       call      qword ptr [4750]; Silk.NET.Maths.Matrix4X4`1[[System.Int16, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       cmp       esi,[rdi+8]
       jae       short 0000000000005361
       mov       rax,rsi
       shl       rax,5
       vmovdqu   ymm0,ymmword ptr [rsp+168]
       vmovdqu   ymmword ptr [rdi+rax+10],ymm0
       inc       esi
       cmp       esi,1869F
       mov       rbx,[rsp+250]
       jl        near ptr 00000000000048F8
       vzeroupper
       add       rsp,208
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 2695

; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]]..ctor(Int16, Int16, Int16, Int16)
       movsx     rax,dx
       movsx     rdx,r8w
       movsx     r8,r9w
       movsx     r10,word ptr [rsp+28]
       mov       [rcx],ax
       mov       [rcx+2],dx
       mov       [rcx+4],r8w
       mov       [rcx+6],r10w
       ret
; Total bytes of code 36

; Silk.NET.Maths.Scalar.Multiply[[System.Int16, System.Private.CoreLib]](Int16, Int16)
       imul      ecx,edx
       movsx     rax,cx
       ret
; Total bytes of code 8

; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       push      rbx
       movsx     rax,cx
       mov       r8,rcx
       sar       r8,10
       movsx     r8,r8w
       mov       r10,rcx
       sar       r10,20
       movsx     r10,r10w
       sar       rcx,30
       movsx     rcx,cx
       movsx     r9,dx
       mov       r11,rdx
       sar       r11,10
       movsx     r11,r11w
       mov       rbx,rdx
       sar       rbx,20
       movsx     rbx,bx
       sar       rdx,30
       movsx     rdx,dx
       add       eax,r9d
       cwde
       add       r8d,r11d
       movsx     r8,r8w
       add       r10d,ebx
       movsx     r10,r10w
       add       ecx,edx
       movsx     rcx,cx
       movzx     eax,ax
       movzx     edx,r8w
       shl       edx,10
       or        eax,edx
       movzx     edx,r10w
       shl       rdx,20
       or        rax,rdx
       mov       ecx,ecx
       shl       rcx,30
       or        rax,rcx
       pop       rbx
       ret
; Total bytes of code 127

; Silk.NET.Maths.Vector4D`1[[System.Int16, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Int16>, Int16)
       movsx     rax,cx
       mov       r8,rcx
       sar       r8,10
       movsx     r8,r8w
       mov       r10,rcx
       sar       r10,20
       movsx     r10,r10w
       sar       rcx,30
       movsx     rcx,cx
       movsx     rdx,dx
       imul      eax,edx
       cwde
       imul      r8d,edx
       movsx     r8,r8w
       imul      r10d,edx
       movsx     r10,r10w
       imul      ecx,edx
       movsx     rcx,cx
       movzx     eax,ax
       movzx     edx,r8w
       shl       edx,10
       or        eax,edx
       movzx     edx,r10w
       shl       rdx,20
       or        rax,rdx
       mov       ecx,ecx
       shl       rcx,30
       or        rax,rcx
       ret
; Total bytes of code 98

; Silk.NET.Maths.Matrix4X4`1[[System.Int16, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>, Silk.NET.Maths.Vector4D`1<Int16>)
       mov       [rcx],rdx
       mov       [rcx+8],r8
       mov       [rcx+10],r9
       mov       rax,[rsp+28]
       mov       [rcx+18],rax
       ret
; Total bytes of code 21
```

```assembly
; System.Numerics.Bench.BaseStressMatrix4X4`1[[System.Int16, System.Private.CoreLib]].Transpose()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10,rax
       shl       r10,5
       lea       r8,[r8+r10+10]
       movsx     r9,word ptr [r8]
       movsx     r11,word ptr [r8+2]
       movsx     rbx,word ptr [r8+4]
       movsx     rsi,word ptr [r8+6]
       mov       [rsp+34],esi
       movsx     rdi,word ptr [r8+8]
       movsx     rbp,word ptr [r8+0A]
       movsx     r14,word ptr [r8+0C]
       mov       [rsp+30],r14d
       movsx     r15,word ptr [r8+0E]
       mov       [rsp+2C],r15d
       movsx     r13,word ptr [r8+10]
       movsx     r12,word ptr [r8+12]
       movsx     r15,word ptr [r8+14]
       mov       [rsp+28],r15d
       movsx     rsi,word ptr [r8+16]
       mov       [rsp+24],esi
       movsx     rsi,word ptr [r8+18]
       movsx     r15,word ptr [r8+1A]
       movsx     r14,word ptr [r8+1C]
       movsx     r8,word ptr [r8+1E]
       cmp       eax,[rdx+8]
       jae       near ptr M00_L01
       lea       rdx,[rdx+r10+10]
       mov       [rdx],r9w
       mov       [rdx+2],di
       mov       [rdx+4],r13w
       mov       [rdx+6],si
       mov       [rdx+8],r11w
       mov       [rdx+0A],bp
       mov       [rdx+0C],r12w
       mov       [rdx+0E],r15w
       mov       [rdx+10],bx
       mov       r10d,[rsp+30]
       mov       [rdx+12],r10w
       mov       r15d,[rsp+28]
       mov       [rdx+14],r15w
       mov       [rdx+16],r14w
       mov       esi,[rsp+34]
       mov       [rdx+18],si
       mov       r15d,[rsp+2C]
       mov       [rdx+1A],r15w
       mov       esi,[rsp+24]
       mov       [rdx+1C],si
       mov       [rdx+1E],r8w
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 296
```
