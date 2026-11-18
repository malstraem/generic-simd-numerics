## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean      | Error    | StdDev   | Code Size |
|---------- |----------:|---------:|---------:|----------:|
| Multiply  | 121.66 μs | 0.350 μs | 0.327 μs |     215 B |
| Divide    | 205.94 μs | 0.289 μs | 0.241 μs |     269 B |
| Conjugate |  67.78 μs | 0.430 μs | 0.381 μs |      85 B |
| Inverse   |  76.18 μs | 0.323 μs | 0.302 μs |     125 B |
| Lerp      | 174.45 μs | 1.110 μs | 1.038 μs |     230 B |
| Slerp     | 122.24 μs | 1.003 μs | 0.939 μs |     417 B |

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
       vpshufd   xmm4,xmm1,0B1
       vmulps    xmm0,xmm4,xmm0
       vmovaps   xmm4,xmm3
       vbroadcastss xmm4,xmm4
       vpshufd   xmm5,xmm1,4E
       vmulps    xmm4,xmm5,xmm4
       vpshufd   xmm5,xmm1,1B
       vmulps    xmm2,xmm5,xmm2
       vpermilpd xmm3,xmm3,1
       vbroadcastss xmm3,xmm3
       vmulps    xmm1,xmm3,xmm1
       vfmadd231ps xmm1,xmm2,[7FF915F54D00]
       vfmadd231ps xmm1,xmm4,[7FF915F54D10]
       vfmadd132ps xmm0,xmm1,[7FF915F54D20]
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
; Total bytes of code 215
```

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Divide()
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
       vmulps    xmm2,xmm1,[7FF915F95B50]
       vmulps    xmm1,xmm1,xmm1
       vpermilps xmm3,xmm1,0B1
       vaddps    xmm1,xmm3,xmm1
       vpermilps xmm3,xmm1,4E
       vaddps    xmm1,xmm3,xmm1
       vbroadcastss xmm1,xmm1
       vdivps    xmm2,xmm2,xmm1
       vcmpnleps xmm1,xmm1,[7FF915F95B60]
       vandps    xmm1,xmm1,xmm2
       vmovaps   xmm2,xmm0
       vbroadcastss xmm2,xmm2
       vmovshdup xmm3,xmm0
       vunpckhps xmm0,xmm0,xmm0
       vbroadcastss xmm0,xmm0
       vpshufd   xmm4,xmm1,0B1
       vmulps    xmm0,xmm4,xmm0
       vmovaps   xmm4,xmm3
       vbroadcastss xmm4,xmm4
       vpshufd   xmm5,xmm1,4E
       vmulps    xmm4,xmm5,xmm4
       vpshufd   xmm5,xmm1,1B
       vmulps    xmm2,xmm5,xmm2
       vpermilpd xmm3,xmm3,1
       vbroadcastss xmm3,xmm3
       vmulps    xmm1,xmm3,xmm1
       vfmadd231ps xmm1,xmm2,[7FF915F95B70]
       vfmadd231ps xmm1,xmm4,[7FF915F95B80]
       vfmadd132ps xmm0,xmm1,[7FF915F95B90]
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
; Total bytes of code 269
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
       vmulps    xmm0,xmm0,[7FF915F93FE0]
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
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,4
       vmovups   xmm0,[r10+r9+10]
       vmulps    xmm1,xmm0,[7FF915FA3E80]
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm2,xmm0,0B1
       vaddps    xmm0,xmm2,xmm0
       vpermilps xmm2,xmm0,4E
       vaddps    xmm0,xmm2,xmm0
       vbroadcastss xmm0,xmm0
       cmp       edx,[r8+8]
       jae       short M00_L01
       vdivps    xmm1,xmm1,xmm0
       vcmpnleps xmm0,xmm0,[7FF915FA3E90]
       vandps    xmm0,xmm0,xmm1
       vmovups   [r8+r9+10],xmm0
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

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Lerp()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rax,[rcx+10]
       vbroadcastss xmm0,dword ptr [7FF915F94528]
       vbroadcastss xmm1,dword ptr [7FF915F9452C]
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
       lea       r9,[r9+rbx+10]
       lea       esi,[rdx+1]
       cmp       esi,r11d
       jae       near ptr M00_L01
       mov       r11d,esi
       shl       r11,4
       vmovups   xmm2,[r10+r11+10]
       vmovups   xmm3,[r9]
       vxorps    xmm4,xmm4,xmm4
       vmulps    xmm5,xmm2,xmm3
       vpermilps xmm16,xmm5,0B1
       vaddps    xmm5,xmm16,xmm5
       vpermilps xmm16,xmm5,4E
       vaddps    xmm5,xmm16,xmm5
       vxorps    xmm16,xmm16,xmm16
       vpcmpnltd k1,xmm5,xmm16
       vxorps    xmm5,xmm1,xmm2
       vandps    xmm5{k1},xmm0,xmm2
       vfmadd213ps xmm4,xmm3,xmm5
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmulps    xmm2,xmm4,xmm4
       vpermilps xmm3,xmm2,0B1
       vaddps    xmm2,xmm3,xmm2
       vpermilps xmm3,xmm2,4E
       vaddps    xmm2,xmm3,xmm2
       vsqrtps   xmm2,xmm2
       vdivps    xmm2,xmm4,xmm2
       vmovups   [r8+rbx+10],xmm2
       mov       edx,esi
       cmp       edx,1869F
       jl        near ptr M00_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 230
```

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Slerp()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       vzeroupper
       vmovaps   [rsp+90],xmm6
       vmovaps   [rsp+80],xmm7
       vmovaps   [rsp+70],xmm8
       vmovaps   [rsp+60],xmm9
       vmovaps   [rsp+50],xmm10
       vmovaps   [rsp+40],xmm11
       vmovaps   [rsp+30],xmm12
       mov       rbx,rcx
       mov       rsi,[rbx+10]
       vmovss    xmm6,dword ptr [7FF915F84684]
       vsubss    xmm7,xmm6,dword ptr [7FF9156EB1B0]
       xor       edi,edi
M00_L00:
       mov       rbp,rsi
       mov       rax,[rbx+8]
       mov       rcx,rax
       mov       edx,[rcx+8]
       cmp       edi,edx
       jae       near ptr M00_L05
       mov       r14,rdi
       shl       r14,4
       lea       rcx,[rcx+r14+10]
       lea       r15d,[rdi+1]
       cmp       r15d,edx
       jae       near ptr M00_L05
       mov       edx,r15d
       shl       rdx,4
       vmovups   xmm8,[rax+rdx+10]
       vmovups   xmm9,[rcx]
       vmulps    xmm0,xmm9,xmm8
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovaps   xmm10,xmm6
       vmovd     eax,xmm0
       test      eax,eax
       jl        near ptr M00_L03
M00_L01:
       vucomiss  xmm0,xmm7
       jbe       near ptr M00_L04
       vxorps    xmm11,xmm11,xmm11
M00_L02:
       cmp       edi,[rbp+8]
       jae       near ptr M00_L05
       vbroadcastss xmm0,xmm11
       vmulps    xmm0,xmm9,xmm0
       vbroadcastss xmm1,xmm10
       vmulps    xmm1,xmm8,xmm1
       vaddps    xmm0,xmm1,xmm0
       vmovups   [rbp+r14+10],xmm0
       mov       edi,r15d
       cmp       edi,1869F
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+90]
       vmovaps   xmm7,[rsp+80]
       vmovaps   xmm8,[rsp+70]
       vmovaps   xmm9,[rsp+60]
       vmovaps   xmm10,[rsp+50]
       vmovaps   xmm11,[rsp+40]
       vmovaps   xmm12,[rsp+30]
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L03:
       vxorps    xmm0,xmm0,[7FF915F84690]
       vmovss    xmm10,dword ptr [7FF915F846A0]
       jmp       near ptr M00_L01
M00_L04:
       call      qword ptr [7FF915F145A0]; Precode of System.Single.Acos(Single)
       vmovss    dword ptr [rsp+2C],xmm0
       call      qword ptr [7FF915F145B8]; Precode of System.Single.Sin(Single)
       vdivss    xmm12,xmm6,xmm0
       vxorps    xmm0,xmm0,xmm0
       vmulss    xmm0,xmm0,dword ptr [rsp+2C]
       call      qword ptr [7FF915F145B8]; Precode of System.Single.Sin(Single)
       vmulss    xmm11,xmm12,xmm0
       vmovss    xmm0,dword ptr [rsp+2C]
       call      qword ptr [7FF915F145B8]; Precode of System.Single.Sin(Single)
       vmulss    xmm0,xmm12,xmm0
       vmulss    xmm10,xmm10,xmm0
       jmp       near ptr M00_L02
M00_L05:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 417
```
