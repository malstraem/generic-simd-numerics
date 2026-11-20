## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean        | Error    | StdDev   | Code Size |
|---------- |------------:|---------:|---------:|----------:|
| Multiply  |   131.46 μs | 0.645 μs | 0.603 μs |     224 B |
| Divide    |   236.84 μs | 1.195 μs | 1.118 μs |     278 B |
| Conjugate |    64.32 μs | 0.412 μs | 0.366 μs |      88 B |
| Inverse   |   103.53 μs | 0.451 μs | 0.422 μs |     128 B |
| Lerp      |   260.27 μs | 0.585 μs | 0.518 μs |     252 B |
| Slerp     | 1,336.00 μs | 2.755 μs | 2.442 μs |     526 B |

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
       vfmadd132pd ymm3,ymm1,[7FF915F64F60]
       vfmadd132pd ymm2,ymm3,[7FF915F64F80]
       vfmadd132pd ymm0,ymm2,[7FF915F64FA0]
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
       vmulpd    ymm2,ymm1,[7FF915FA5E80]
       vmulpd    ymm1,ymm1,ymm1
       vpermilpd ymm3,ymm1,5
       vaddpd    ymm1,ymm3,ymm1
       vperm2f128 ymm3,ymm1,ymm1,1
       vaddpd    ymm1,ymm3,ymm1
       vbroadcastsd ymm1,xmm1
       vdivpd    ymm2,ymm2,ymm1
       vcmpnlepd ymm1,ymm1,[7FF915FA5EA0]
       vandpd    ymm1,ymm1,ymm2
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
       vfmadd132pd ymm3,ymm1,[7FF915FA5EC0]
       vfmadd132pd ymm2,ymm3,[7FF915FA5EE0]
       vfmadd132pd ymm0,ymm2,[7FF915FA5F00]
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
; Total bytes of code 278
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
       vmulpd    ymm0,ymm0,[7FF915F83EA0]
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
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,5
       vmovups   ymm0,[r10+r9+10]
       vmulpd    ymm1,ymm0,[7FF915F73840]
       vmulpd    ymm0,ymm0,ymm0
       vpermilpd ymm2,ymm0,5
       vaddpd    ymm0,ymm2,ymm0
       vperm2f128 ymm2,ymm0,ymm0,1
       vaddpd    ymm0,ymm2,ymm0
       vbroadcastsd ymm0,xmm0
       cmp       edx,[r8+8]
       jae       short M00_L01
       vdivpd    ymm1,ymm1,ymm0
       vcmpnlepd ymm0,ymm0,[7FF915F73860]
       vandpd    ymm0,ymm0,ymm1
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
; Total bytes of code 128
```

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Lerp()
       push      rsi
       push      rbx
       sub       rsp,38
       vmovaps   [rsp+20],xmm6
       mov       rax,[rcx+10]
       vbroadcastsd ymm0,qword ptr [7FF915F74300]
       vbroadcastsd ymm1,qword ptr [7FF915F74308]
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
       lea       r9,[r9+rbx+10]
       lea       esi,[rdx+1]
       cmp       esi,r11d
       jae       near ptr M00_L01
       mov       r11d,esi
       shl       r11,5
       vmovups   ymm2,[r10+r11+10]
       vmovups   ymm3,[r9]
       vxorps    ymm4,ymm4,ymm4
       vmulpd    ymm5,ymm2,ymm3
       vpermilpd ymm16,ymm5,5
       vaddpd    ymm5,ymm16,ymm5
       vperm2f128 ymm6,ymm5,ymm5,1
       vaddpd    ymm5,ymm6,ymm5
       vbroadcastsd ymm5,xmm5
       vxorps    ymm16,ymm16,ymm16
       vpcmpnltq k1,ymm5,ymm16
       vxorpd    ymm5,ymm1,ymm2
       vandpd    ymm5{k1},ymm0,ymm2
       vfmadd213pd ymm4,ymm3,ymm5
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmulpd    ymm2,ymm4,ymm4
       vpermilpd ymm3,ymm2,5
       vaddpd    ymm2,ymm3,ymm2
       vperm2f128 ymm3,ymm2,ymm2,1
       vaddpd    ymm2,ymm3,ymm2
       vsqrtsd   xmm2,xmm2,xmm2
       vbroadcastsd ymm2,xmm2
       vdivpd    ymm2,ymm4,ymm2
       vmovups   [r8+rbx+10],ymm2
       mov       edx,esi
       cmp       edx,1869F
       jl        near ptr M00_L00
       vzeroupper
       vmovaps   xmm6,[rsp+20]
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 252
```

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Slerp()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vmovaps   [rsp+0B0],xmm6
       vmovaps   [rsp+0A0],xmm7
       vmovaps   [rsp+90],xmm8
       vmovaps   [rsp+80],xmm9
       vmovaps   [rsp+70],xmm10
       vmovaps   [rsp+60],xmm11
       vmovaps   [rsp+50],xmm12
       vmovaps   [rsp+40],xmm13
       vmovaps   [rsp+30],xmm14
       vmovaps   [rsp+20],xmm15
       mov       rbx,rcx
       mov       rsi,[rbx+10]
       vmovsd    xmm6,qword ptr [7FF9CE297D10]
       vsubsd    xmm7,xmm6,qword ptr [7FF9CDA1B198]
       xor       edi,edi
M00_L00:
       mov       rbp,rsi
       mov       rax,[rbx+8]
       mov       rcx,rax
       mov       edx,[rcx+8]
       cmp       edi,edx
       jae       near ptr M00_L05
       mov       r14,rdi
       shl       r14,5
       lea       rcx,[rcx+r14+10]
       lea       r15d,[rdi+1]
       cmp       r15d,edx
       jae       near ptr M00_L05
       mov       edx,r15d
       shl       rdx,5
       vmovups   ymm8,[rax+rdx+10]
       vmovups   ymm9,[rcx]
       vmulpd    ymm0,ymm9,ymm8
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovaps   xmm10,xmm6
       vmovq     rax,xmm0
       test      rax,rax
       jl        near ptr M00_L04
M00_L01:
       vucomisd  xmm0,xmm7
       ja        near ptr M00_L03
       vextractf128 xmm11,ymm8,1
       vextractf128 xmm12,ymm9,1
       vzeroupper
       call      qword ptr [7FF9CE1AD9E0]; System.Double.Acos(Double)
       vmovaps   xmm13,xmm0
       vmovaps   xmm0,xmm13
       vzeroupper
       call      qword ptr [7FF9CE1AD9F8]; System.Double.Sin(Double)
       vmovaps   xmm14,xmm0
       vdivsd    xmm15,xmm6,xmm14
       vxorps    xmm0,xmm0,xmm0
       vmulsd    xmm0,xmm13,xmm0
       vzeroupper
       call      qword ptr [7FF9CE1AD9F8]; System.Double.Sin(Double)
       vmulsd    xmm0,xmm15,xmm0
       vmulsd    xmm1,xmm14,xmm15
       vmulsd    xmm10,xmm10,xmm1
       vinsertf128 ymm8,ymm8,xmm11,1
       vinsertf128 ymm9,ymm9,xmm12,1
M00_L02:
       cmp       edi,[rbp+8]
       jae       near ptr M00_L05
       vbroadcastsd ymm0,xmm0
       vmulpd    ymm0,ymm9,ymm0
       vbroadcastsd ymm1,xmm10
       vmulpd    ymm1,ymm8,ymm1
       vaddpd    ymm0,ymm1,ymm0
       vmovups   [rbp+r14+10],ymm0
       mov       edi,r15d
       cmp       edi,1869F
       jl        near ptr M00_L00
       vzeroupper
       vmovaps   xmm6,[rsp+0B0]
       vmovaps   xmm7,[rsp+0A0]
       vmovaps   xmm8,[rsp+90]
       vmovaps   xmm9,[rsp+80]
       vmovaps   xmm10,[rsp+70]
       vmovaps   xmm11,[rsp+60]
       vmovaps   xmm12,[rsp+50]
       vmovaps   xmm13,[rsp+40]
       vmovaps   xmm14,[rsp+30]
       vmovaps   xmm15,[rsp+20]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L03:
       vxorps    xmm0,xmm0,xmm0
       jmp       near ptr M00_L02
M00_L04:
       vxorps    xmm0,xmm0,[7FF9CE297D20]
       vmovsd    xmm10,qword ptr [7FF9CE297D30]
       jmp       near ptr M00_L01
M00_L05:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 490

; System.Double.Acos(Double)
       sub       rsp,28
       vzeroupper
       call      00007FFA2D7142D0
       nop
       add       rsp,28
       ret
; Total bytes of code 18

; System.Double.Sin(Double)
       sub       rsp,28
       vzeroupper
       call      00007FFA2D7143E0
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```
