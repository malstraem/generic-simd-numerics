## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean      | Error    | StdDev   | Code Size |
|---------- |----------:|---------:|---------:|----------:|
| Multiply  | 129.29 μs | 0.525 μs | 0.466 μs |     224 B |
| Divide    | 233.72 μs | 1.037 μs | 0.919 μs |     287 B |
| Conjugate |  62.66 μs | 0.319 μs | 0.298 μs |      88 B |
| Inverse   |  92.23 μs | 0.342 μs | 0.320 μs |     127 B |

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Multiply()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       near ptr M00_L01
       mov       rbx,rdx
       shl       rbx,5
       vmovups   ymm0,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr M00_L01
       mov       r11d,r9d
       shl       r11,5
       vmovups   ymm1,[r10+r11+10]
       vmovaps   xmm2,xmm0
       vmovaps   xmm3,xmm2
       vbroadcastsd ymm3,xmm3
       vpermilpd xmm2,xmm2,1
       vperm2f128 ymm0,ymm0,ymm0,1
       vpermilpd xmm4,xmm0,1
       vbroadcastsd ymm2,xmm2
       vbroadcastsd ymm0,xmm0
       vbroadcastsd ymm4,xmm4
       vpermq    ymm5,ymm1,1B
       vmulpd    ymm3,ymm5,ymm3
       vpermq    ymm5,ymm1,4E
       vmulpd    ymm2,ymm5,ymm2
       vshufpd   ymm5,ymm1,ymm1,5
       vmulpd    ymm0,ymm5,ymm0
       vmulpd    ymm1,ymm1,ymm4
       vfmadd132pd ymm3,ymm1,[7FFEC14B7660]
       vfmadd132pd ymm2,ymm3,[7FFEC14B7680]
       vfmadd132pd ymm0,ymm2,[7FFEC14B76A0]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+rbx+10],ymm0
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 224
```

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Divide()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       vmovsd    xmm0,qword ptr [7FFEC1498220]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       near ptr M00_L01
       mov       rbx,rdx
       shl       rbx,5
       vmovups   ymm1,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr M00_L01
       mov       r11d,r9d
       shl       r11,5
       vmovups   ymm2,[r10+r11+10]
       vmulpd    ymm3,ymm2,ymm2
       vpermilpd ymm4,ymm3,5
       vaddpd    ymm3,ymm4,ymm3
       vperm2f128 ymm4,ymm3,ymm3,1
       vaddpd    ymm3,ymm4,ymm3
       vmulpd    ymm2,ymm2,[7FFEC1498240]
       vdivsd    xmm3,xmm0,xmm3
       vbroadcastsd ymm3,xmm3
       vmulpd    ymm2,ymm3,ymm2
       vmovaps   xmm3,xmm1
       vmovaps   xmm4,xmm3
       vbroadcastsd ymm4,xmm4
       vpermilpd xmm3,xmm3,1
       vperm2f128 ymm1,ymm1,ymm1,1
       vpermilpd xmm5,xmm1,1
       vbroadcastsd ymm3,xmm3
       vbroadcastsd ymm1,xmm1
       vbroadcastsd ymm5,xmm5
       vpermq    ymm16,ymm2,1B
       vmulpd    ymm4,ymm16,ymm4
       vpermq    ymm16,ymm2,4E
       vmulpd    ymm3,ymm16,ymm3
       vshufpd   ymm16,ymm2,ymm2,5
       vmulpd    ymm1,ymm16,ymm1
       vmulpd    ymm2,ymm2,ymm5
       vfmadd132pd ymm4,ymm2,[7FFEC1498260]
       vfmadd132pd ymm3,ymm4,[7FFEC1498280]
       vfmadd132pd ymm1,ymm3,[7FFEC14982A0]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+rbx+10],ymm1
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 287
```

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Conjugate()
       sub       rsp,28
       mov       rax,[rcx+10]
       xor       edx,edx
       nop       word ptr [rax+rax]
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,5
       vmovups   ymm0,[r10+r9+10]
       vmulpd    ymm0,ymm0,[7FFEC1475F60]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+r9+10],ymm0
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 88
```

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Inverse()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovsd    xmm0,qword ptr [7FFEC14A69A0]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,5
       vmovups   ymm1,[r10+r9+10]
       vmulpd    ymm2,ymm1,ymm1
       vpermilpd ymm3,ymm2,5
       vaddpd    ymm2,ymm3,ymm2
       vperm2f128 ymm3,ymm2,ymm2,1
       vaddpd    ymm2,ymm3,ymm2
       vmulpd    ymm1,ymm1,[7FFEC14A69C0]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vdivsd    xmm2,xmm0,xmm2
       vbroadcastsd ymm2,xmm2
       vmulpd    ymm1,ymm2,ymm1
       vmovups   [r8+r9+10],ymm1
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 127
```
