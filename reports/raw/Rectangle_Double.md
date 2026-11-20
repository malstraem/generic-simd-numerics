## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method     | Mean      | Error    | StdDev   | Code Size |
|----------- |----------:|---------:|---------:|----------:|
| Intersects | 130.34 μs | 1.792 μs | 1.589 μs |     237 B |
| Contains   | 135.19 μs | 0.724 μs | 0.677 μs |     192 B |
| Area       |  31.19 μs | 0.161 μs | 0.151 μs |      71 B |

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Double, System.Private.CoreLib]].Intersects()
       xor       eax,eax
       mov       rcx,198D4800BB8
       mov       rcx,[rcx]
       mov       rdx,198D4800BC0
       mov       rdx,[rdx]
       jmp       short M00_L02
M00_L00:
       mov       r10d,1
M00_L01:
       mov       [r9+r8+10],r10b
       cmp       eax,1869F
       jge       near ptr M00_L05
M00_L02:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       inc       eax
       mov       r10d,eax
       shl       r10,5
       lea       r10,[rcx+r10+10]
       vmovsd    xmm4,qword ptr [r10]
       vmovsd    xmm5,qword ptr [r10+8]
       vmovsd    xmm16,qword ptr [r10+10]
       vmovsd    xmm17,qword ptr [r10+18]
       vaddsd    xmm2,xmm0,xmm2
       vaddsd    xmm3,xmm1,xmm3
       vucomisd  xmm4,xmm0
       jb        short M00_L06
       vucomisd  xmm5,xmm1
       jb        short M00_L06
       vucomisd  xmm2,xmm4
       jb        short M00_L06
       vucomisd  xmm3,xmm5
       setae     r10b
       movzx     r10d,r10b
M00_L03:
       mov       r9,rdx
       test      r10d,r10d
       jne       near ptr M00_L00
       vaddsd    xmm2,xmm16,xmm4
       vaddsd    xmm3,xmm17,xmm5
       vucomisd  xmm0,xmm4
       jb        short M00_L07
       vucomisd  xmm1,xmm5
       jb        short M00_L07
       vucomisd  xmm2,xmm0
       jb        short M00_L07
       vucomisd  xmm3,xmm1
       setae     r10b
       movzx     r10d,r10b
M00_L04:
       jmp       near ptr M00_L01
M00_L05:
       ret
M00_L06:
       xor       r10d,r10d
       jmp       short M00_L03
M00_L07:
       xor       r10d,r10d
       jmp       short M00_L04
; Total bytes of code 237
```

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Double, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,2C3C6000BB8
       mov       rcx,[rcx]
       mov       rdx,2C3C6000BC0
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,5
       lea       r9,[rcx+r9+10]
       vmovsd    xmm0,qword ptr [r9]
       vmovsd    xmm1,qword ptr [r9+8]
       vmovsd    xmm2,qword ptr [r9+10]
       vmovsd    xmm3,qword ptr [r9+18]
       vmovsd    xmm4,qword ptr [r10]
       vmovaps   xmm5,xmm4
       vmovsd    xmm16,qword ptr [r10+8]
       vmovaps   xmm17,xmm16
       vmovsd    xmm18,qword ptr [r10+10]
       vmovsd    xmm19,qword ptr [r10+18]
       vaddsd    xmm5,xmm18,xmm5
       vaddsd    xmm17,xmm17,xmm19
       vaddsd    xmm2,xmm0,xmm2
       vaddsd    xmm3,xmm1,xmm3
       vucomisd  xmm0,xmm4
       jb        short M00_L02
       vucomisd  xmm1,xmm16
       jb        short M00_L02
       vucomisd  xmm5,xmm2
       jb        short M00_L02
       vucomisd  xmm17,xmm3
       setae     r10b
       movzx     r10d,r10b
M00_L01:
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        near ptr M00_L00
       ret
M00_L02:
       xor       r10d,r10d
       jmp       short M00_L01
; Total bytes of code 192
```

```assembly
; System.Numerics.Bench.StressRectangle`1[[System.Double, System.Private.CoreLib]].Area()
       mov       rax,13460800BB8
       mov       rax,[rax]
       mov       rcx,13460800BC8
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovsd    xmm0,qword ptr [r10+10]
       vmovsd    xmm1,qword ptr [r10+18]
       vmulsd    xmm0,xmm0,xmm1
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 71
```
