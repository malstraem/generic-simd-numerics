## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean      | Error    | StdDev   | Code Size |
|---------- |----------:|---------:|---------:|----------:|
| Multiply  | 119.89 μs | 0.550 μs | 0.515 μs |     243 B |
| Divide    | 205.16 μs | 3.477 μs | 5.310 μs |     333 B |
| Conjugate |  70.48 μs | 0.107 μs | 0.084 μs |      79 B |
| Inverse   |  78.85 μs | 0.393 μs | 0.348 μs |     129 B |
| Lerp      | 167.63 μs | 0.760 μs | 0.711 μs |     210 B |
| Slerp     | 114.93 μs | 0.377 μs | 0.353 μs |     415 B |

```assembly
; System.Numerics.Bench.StressQuaternion.Multiply()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       vmovups   xmm0,[7FF915F35AC0]
       vmovddup  xmm1,qword ptr [7FF915F35AD0]
       vmovups   xmm2,[7FF915F35AE0]
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
       vmovups   xmm3,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr M00_L01
       mov       r11d,r9d
       shl       r11,4
       vmovups   xmm4,[r10+r11+10]
       vpermilps xmm5,xmm4,4E
       vmovshdup xmm16,xmm3
       vbroadcastss xmm16,xmm16
       vmulps    xmm5,xmm16,xmm5
       vpermilps xmm16,xmm4,1B
       vmovaps   xmm17,xmm3
       vbroadcastss xmm17,xmm17
       vmulps    xmm16,xmm17,xmm16
       vshufps   xmm17,xmm3,xmm3,0FF
       vbroadcastss xmm17,xmm17
       vmulps    xmm17,xmm17,xmm4
       vfmadd213ps xmm16,xmm1,xmm17
       vfmadd213ps xmm5,xmm0,xmm16
       cmp       edx,[r8+8]
       jae       short M00_L01
       vpermilps xmm4,xmm4,0B1
       vunpckhps xmm3,xmm3,xmm3
       vbroadcastss xmm3,xmm3
       vmulps    xmm3,xmm3,xmm4
       vfmadd213ps xmm3,xmm2,xmm5
       vmovups   [r8+rbx+10],xmm3
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr M00_L00
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 243
```

```assembly
; System.Numerics.Bench.StressQuaternion.Divide()
       push      rbx
       sub       rsp,30
       vmovaps   [rsp+20],xmm6
       mov       rax,[rcx+10]
       vmovups   xmm0,[7FF915F52D10]
       vbroadcastss xmm1,dword ptr [7FF915F52D20]
       vmovups   xmm2,[7FF915F52D30]
       vmovddup  xmm3,qword ptr [7FF915F52D40]
       vmovups   xmm4,[7FF915F52D50]
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
       vmovups   xmm5,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr M00_L01
       mov       r11d,r9d
       shl       r11,4
       vmovups   xmm16,[r10+r11+10]
       vmulps    xmm17,xmm16,xmm16
       vpermilps xmm18,xmm17,0B1
       vaddps    xmm17,xmm18,xmm17
       vpermilps xmm18,xmm17,4E
       vaddps    xmm6,xmm18,xmm17
       vmulps    xmm16,xmm16,xmm0
       vdivps    xmm16,xmm16,xmm6
       vcmpnleps xmm6,xmm6,xmm1
       vandps    xmm16,xmm16,xmm6
       vpermilps xmm17,xmm16,4E
       vmovshdup xmm18,xmm5
       vbroadcastss xmm18,xmm18
       vmulps    xmm17,xmm18,xmm17
       vpermilps xmm18,xmm16,1B
       vmovaps   xmm19,xmm5
       vbroadcastss xmm19,xmm19
       vmulps    xmm18,xmm19,xmm18
       vshufps   xmm19,xmm5,xmm5,0FF
       vbroadcastss xmm19,xmm19
       vmulps    xmm19,xmm19,xmm16
       vfmadd213ps xmm18,xmm3,xmm19
       vfmadd213ps xmm17,xmm2,xmm18
       cmp       edx,[r8+8]
       jae       short M00_L01
       vpermilps xmm16,xmm16,0B1
       vunpckhps xmm5,xmm5,xmm5
       vbroadcastss xmm5,xmm5
       vmulps    xmm5,xmm16,xmm5
       vfmadd213ps xmm5,xmm4,xmm17
       vmovups   [r8+rbx+10],xmm5
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+20]
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 333
```

```assembly
; System.Numerics.Bench.StressQuaternion.Conjugate()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovups   xmm0,[7FF915F32510]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,4
       vmulps    xmm1,xmm0,[r10+r9+10]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+r9+10],xmm1
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 79
```

```assembly
; System.Numerics.Bench.StressQuaternion.Inverse()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovups   xmm0,[7FF915F42110]
       vbroadcastss xmm1,dword ptr [7FF915F42120]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,4
       vmovups   xmm2,[r10+r9+10]
       vmulps    xmm3,xmm2,xmm2
       vpermilps xmm4,xmm3,0B1
       vaddps    xmm3,xmm4,xmm3
       vpermilps xmm4,xmm3,4E
       vaddps    xmm3,xmm4,xmm3
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmulps    xmm2,xmm0,xmm2
       vdivps    xmm2,xmm2,xmm3
       vcmpnleps xmm3,xmm3,xmm1
       vandps    xmm2,xmm3,xmm2
       vmovups   [r8+r9+10],xmm2
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 129
```

```assembly
; System.Numerics.Bench.StressQuaternion.Lerp()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       vbroadcastss xmm0,dword ptr [7FF915F52DD4]
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
       vxorps    xmm3,xmm3,xmm3
       vmulps    xmm4,xmm2,xmm1
       vpermilps xmm5,xmm4,0B1
       vaddps    xmm4,xmm5,xmm4
       vpermilps xmm5,xmm4,4E
       vaddps    xmm4,xmm5,xmm4
       vxorps    xmm5,xmm5,xmm5
       vpcmpnltd k1,xmm4,xmm5
       vxorps    xmm4,xmm0,xmm2
       vpblendmd xmm2{k1},xmm4,xmm2
       vfmadd231ps xmm2,xmm3,xmm1
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmulps    xmm1,xmm2,xmm2
       vpermilps xmm3,xmm1,0B1
       vaddps    xmm1,xmm3,xmm1
       vpermilps xmm3,xmm1,4E
       vaddps    xmm1,xmm3,xmm1
       vsqrtps   xmm1,xmm1
       vdivps    xmm1,xmm2,xmm1
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
; Total bytes of code 210
```

```assembly
; System.Numerics.Bench.StressQuaternion.Slerp()
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
       vmovss    xmm6,dword ptr [7FF915F32B00]
       vmovss    xmm7,dword ptr [7FF915F32B04]
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
       vmovups   xmm8,[rcx+r14+10]
       lea       r15d,[rdi+1]
       cmp       r15d,edx
       jae       near ptr M00_L05
       mov       ecx,r15d
       shl       rcx,4
       vmovups   xmm9,[rax+rcx+10]
       vmulps    xmm0,xmm8,xmm9
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
       vmulps    xmm0,xmm8,xmm0
       vbroadcastss xmm1,xmm10
       vmulps    xmm1,xmm9,xmm1
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
       vxorps    xmm0,xmm0,[7FF915F32B10]
       vmovss    xmm10,dword ptr [7FF915F32B20]
       jmp       near ptr M00_L01
M00_L04:
       call      qword ptr [7FF915EE7528]; Precode of System.Single.Acos(Single)
       vmovss    dword ptr [rsp+2C],xmm0
       call      qword ptr [7FF915EE7540]; Precode of System.Single.Sin(Single)
       vdivss    xmm12,xmm6,xmm0
       vxorps    xmm0,xmm0,xmm0
       vmulss    xmm0,xmm0,dword ptr [rsp+2C]
       call      qword ptr [7FF915EE7540]; Precode of System.Single.Sin(Single)
       vmulss    xmm11,xmm12,xmm0
       vmovss    xmm0,dword ptr [rsp+2C]
       call      qword ptr [7FF915EE7540]; Precode of System.Single.Sin(Single)
       vmulss    xmm0,xmm12,xmm0
       vmulss    xmm10,xmm10,xmm0
       jmp       near ptr M00_L02
M00_L05:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 415
```
