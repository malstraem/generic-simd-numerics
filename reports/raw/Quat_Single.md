## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean      | Error    | StdDev   | Code Size |
|---------- |----------:|---------:|---------:|----------:|
| Multiply  | 119.43 μs | 0.405 μs | 0.359 μs |     218 B |
| Divide    | 199.15 μs | 0.495 μs | 0.439 μs |     278 B |
| Conjugate |  48.46 μs | 0.210 μs | 0.186 μs |      85 B |
| Inverse   |  70.55 μs | 0.449 μs | 0.420 μs |     125 B |

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Multiply()
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
       shl       rbx,4
       vmovups   xmm0,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr M00_L01
       mov       r11d,r9d
       shl       r11,4
       vmovups   xmm1,[r10+r11+10]
       vmovaps   xmm2,xmm0
       vbroadcastss xmm2,xmm2
       vmovshdup xmm3,xmm0
       vunpckhps xmm0,xmm0,xmm0
       vbroadcastss xmm0,xmm0
       vpermilps xmm4,xmm1,0B1
       vmulps    xmm0,xmm4,xmm0
       vmovaps   xmm4,xmm3
       vbroadcastss xmm4,xmm4
       vpermilps xmm5,xmm1,4E
       vmulps    xmm4,xmm5,xmm4
       vpermilps xmm5,xmm1,1B
       vmulps    xmm2,xmm5,xmm2
       vpermilpd xmm3,xmm3,1
       vbroadcastss xmm3,xmm3
       vmulps    xmm1,xmm3,xmm1
       vfmadd231ps xmm1,xmm2,[7FFEC1477740]
       vfmadd231ps xmm1,xmm4,[7FFEC1477750]
       vfmadd132ps xmm0,xmm1,[7FFEC1477760]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+rbx+10],xmm0
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr M00_L00
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 218
```

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Divide()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       vbroadcastss xmm0,dword ptr [7FFEC14B7AD8]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       near ptr M00_L01
       mov       rbx,rdx
       shl       rbx,4
       vmovups   xmm1,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr M00_L01
       mov       r11d,r9d
       shl       r11,4
       vmovups   xmm2,[r10+r11+10]
       vmulps    xmm3,xmm2,xmm2
       vpermilps xmm4,xmm3,0B1
       vaddps    xmm3,xmm4,xmm3
       vpermilps xmm4,xmm3,4E
       vaddps    xmm3,xmm4,xmm3
       vmulps    xmm2,xmm2,[7FFEC14B7AE0]
       vdivps    xmm2,xmm2,xmm3
       vcmpnleps xmm3,xmm3,xmm0
       vandps    xmm2,xmm3,xmm2
       vmovaps   xmm3,xmm1
       vbroadcastss xmm3,xmm3
       vmovshdup xmm4,xmm1
       vunpckhps xmm1,xmm1,xmm1
       vbroadcastss xmm1,xmm1
       vpermilps xmm5,xmm2,0B1
       vmulps    xmm1,xmm5,xmm1
       vmovaps   xmm5,xmm4
       vbroadcastss xmm5,xmm5
       vpermilps xmm16,xmm2,4E
       vmulps    xmm5,xmm16,xmm5
       vpermilps xmm16,xmm2,1B
       vmulps    xmm3,xmm16,xmm3
       vpermilpd xmm4,xmm4,1
       vbroadcastss xmm4,xmm4
       vmulps    xmm2,xmm4,xmm2
       vfmadd231ps xmm2,xmm3,[7FFEC14B7AF0]
       vfmadd231ps xmm2,xmm5,[7FFEC14B7B00]
       vfmadd132ps xmm1,xmm2,[7FFEC14B7B10]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+rbx+10],xmm1
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr M00_L00
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 278
```

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Conjugate()
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
       shl       r9,4
       vmovups   xmm0,[r10+r9+10]
       vmulps    xmm0,xmm0,[7FFEC14A6360]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+r9+10],xmm0
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 85
```

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Inverse()
       sub       rsp,28
       mov       rax,[rcx+10]
       vbroadcastss xmm0,dword ptr [7FFEC1496680]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,4
       vmovups   xmm1,[r10+r9+10]
       vmulps    xmm2,xmm1,xmm1
       vpermilps xmm3,xmm2,0B1
       vaddps    xmm2,xmm3,xmm2
       vpermilps xmm3,xmm2,4E
       vaddps    xmm2,xmm3,xmm2
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmulps    xmm1,xmm1,[7FFEC1496690]
       vdivps    xmm1,xmm1,xmm2
       vcmpnleps xmm2,xmm2,xmm0
       vandps    xmm1,xmm2,xmm1
       vmovups   [r8+r9+10],xmm1
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 125
```
