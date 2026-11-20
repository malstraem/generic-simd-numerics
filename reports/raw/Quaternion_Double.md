## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean       | Error   | StdDev  | Code Size |
|---------- |-----------:|--------:|--------:|----------:|
| Multiply  |   212.1 μs | 1.48 μs | 1.38 μs |     327 B |
| Divide    |   483.3 μs | 1.07 μs | 0.89 μs |     438 B |
| Conjugate |   118.9 μs | 0.45 μs | 0.42 μs |     128 B |
| Inverse   |   153.6 μs | 0.57 μs | 0.51 μs |     204 B |
| Lerp      |   339.3 μs | 1.24 μs | 1.10 μs |     405 B |
| Slerp     | 1,458.9 μs | 1.43 μs | 1.20 μs |     599 B |

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Double, System.Private.CoreLib]].Multiply()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M00_L01
       mov       r11,rax
       shl       r11,5
       lea       r10,[r10+r11+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L01
       mov       r9d,r10d
       shl       r9,5
       lea       r8,[r8+r9+10]
       vmovsd    xmm4,qword ptr [r8]
       vmovsd    xmm5,qword ptr [r8+8]
       vmovsd    xmm16,qword ptr [r8+10]
       vmovsd    xmm17,qword ptr [r8+18]
       vmulsd    xmm18,xmm16,xmm1
       vmulsd    xmm19,xmm2,xmm5
       vsubsd    xmm18,xmm18,xmm19
       vmulsd    xmm19,xmm2,xmm4
       vmulsd    xmm20,xmm16,xmm0
       vsubsd    xmm19,xmm19,xmm20
       vmulsd    xmm20,xmm0,xmm5
       vmulsd    xmm21,xmm1,xmm4
       vsubsd    xmm20,xmm20,xmm21
       vmulsd    xmm21,xmm0,xmm4
       vmulsd    xmm22,xmm1,xmm5
       vaddsd    xmm21,xmm22,xmm21
       vmulsd    xmm22,xmm16,xmm2
       vaddsd    xmm21,xmm22,xmm21
       vmulsd    xmm0,xmm17,xmm0
       vmulsd    xmm4,xmm4,xmm3
       vaddsd    xmm0,xmm4,xmm0
       vaddsd    xmm0,xmm18,xmm0
       vmulsd    xmm1,xmm17,xmm1
       vmulsd    xmm4,xmm5,xmm3
       vaddsd    xmm1,xmm4,xmm1
       vaddsd    xmm1,xmm19,xmm1
       vmulsd    xmm2,xmm17,xmm2
       vmulsd    xmm4,xmm16,xmm3
       vaddsd    xmm2,xmm4,xmm2
       vaddsd    xmm2,xmm20,xmm2
       vmulsd    xmm3,xmm17,xmm3
       vsubsd    xmm3,xmm3,xmm21
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovsd    qword ptr [rax],xmm0
       vmovsd    qword ptr [rax+8],xmm1
       vmovsd    qword ptr [rax+10],xmm2
       vmovsd    qword ptr [rax+18],xmm3
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 327
```

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Double, System.Private.CoreLib]].Divide()
       sub       rsp,28
       vmovsd    xmm0,qword ptr [7FF915F739F8]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M00_L01
       mov       r11,rax
       shl       r11,5
       lea       r10,[r10+r11+10]
       vmovsd    xmm1,qword ptr [r10]
       vmovsd    xmm2,qword ptr [r10+8]
       vmovsd    xmm3,qword ptr [r10+10]
       vmovsd    xmm4,qword ptr [r10+18]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L01
       mov       r9d,r10d
       shl       r9,5
       lea       r8,[r8+r9+10]
       vmovsd    xmm5,qword ptr [r8]
       vmovsd    xmm16,qword ptr [r8+8]
       vmovsd    xmm17,qword ptr [r8+10]
       vmovsd    xmm18,qword ptr [r8+18]
       vmulsd    xmm19,xmm5,xmm5
       vmulsd    xmm20,xmm16,xmm16
       vaddsd    xmm19,xmm20,xmm19
       vmulsd    xmm20,xmm17,xmm17
       vaddsd    xmm19,xmm20,xmm19
       vmulsd    xmm20,xmm18,xmm18
       vaddsd    xmm19,xmm20,xmm19
       vdivsd    xmm19,xmm0,xmm19
       vmulsd    xmm5,xmm19,xmm5
       vxorps    xmm5,xmm5,[7FF915F73A00]
       vmulsd    xmm16,xmm16,xmm19
       vxorps    xmm16,xmm16,[7FF915F73A10]
       vmulsd    xmm17,xmm17,xmm19
       vxorps    xmm17,xmm17,[7FF915F73A20]
       vmulsd    xmm18,xmm18,xmm19
       vmulsd    xmm19,xmm17,xmm2
       vmulsd    xmm20,xmm16,xmm3
       vsubsd    xmm19,xmm19,xmm20
       vmulsd    xmm20,xmm3,xmm5
       vmulsd    xmm21,xmm17,xmm1
       vsubsd    xmm20,xmm20,xmm21
       vmulsd    xmm21,xmm16,xmm1
       vmulsd    xmm22,xmm2,xmm5
       vsubsd    xmm21,xmm21,xmm22
       vmulsd    xmm22,xmm1,xmm5
       vmulsd    xmm23,xmm16,xmm2
       vaddsd    xmm22,xmm23,xmm22
       vmulsd    xmm23,xmm17,xmm3
       vaddsd    xmm22,xmm23,xmm22
       vmulsd    xmm1,xmm18,xmm1
       vmulsd    xmm5,xmm5,xmm4
       vaddsd    xmm1,xmm5,xmm1
       vaddsd    xmm1,xmm19,xmm1
       vmulsd    xmm2,xmm18,xmm2
       vmulsd    xmm5,xmm16,xmm4
       vaddsd    xmm2,xmm5,xmm2
       vaddsd    xmm2,xmm20,xmm2
       vmulsd    xmm3,xmm18,xmm3
       vmulsd    xmm5,xmm17,xmm4
       vaddsd    xmm3,xmm5,xmm3
       vaddsd    xmm3,xmm21,xmm3
       vmulsd    xmm4,xmm18,xmm4
       vsubsd    xmm4,xmm4,xmm22
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovsd    qword ptr [rax],xmm1
       vmovsd    qword ptr [rax+8],xmm2
       vmovsd    qword ptr [rax+10],xmm3
       vmovsd    qword ptr [rax+18],xmm4
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 438
```

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Double, System.Private.CoreLib]].Conjugate()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short M00_L01
       mov       r10,rax
       shl       r10,5
       lea       r8,[r8+r10+10]
       vmovsd    xmm0,qword ptr [r8]
       vmovsd    xmm1,qword ptr [r8+8]
       vmovsd    xmm2,qword ptr [r8+10]
       vmovsd    xmm3,qword ptr [r8+18]
       vxorps    xmm0,xmm0,[7FF915F62C60]
       vxorps    xmm1,xmm1,[7FF915F62C60]
       vxorps    xmm2,xmm2,[7FF915F62C60]
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r10+10]
       vmovsd    qword ptr [rdx],xmm0
       vmovsd    qword ptr [rdx+8],xmm1
       vmovsd    qword ptr [rdx+10],xmm2
       vmovsd    qword ptr [rdx+18],xmm3
       inc       eax
       cmp       eax,186A0
       jl        short M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 128
```

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Double, System.Private.CoreLib]].Inverse()
       sub       rsp,28
       vmovsd    xmm0,qword ptr [7FF915F830B0]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10,rax
       shl       r10,5
       lea       r8,[r8+r10+10]
       vmovsd    xmm1,qword ptr [r8]
       vmovsd    xmm2,qword ptr [r8+8]
       vmovsd    xmm3,qword ptr [r8+10]
       vmovsd    xmm4,qword ptr [r8+18]
       vmulsd    xmm5,xmm1,xmm1
       vmulsd    xmm16,xmm2,xmm2
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm3,xmm3
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm4,xmm4
       vaddsd    xmm5,xmm16,xmm5
       vdivsd    xmm5,xmm0,xmm5
       vmulsd    xmm1,xmm1,xmm5
       vxorps    xmm1,xmm1,[7FF915F830C0]
       vmulsd    xmm2,xmm2,xmm5
       vxorps    xmm2,xmm2,[7FF915F830D0]
       vmulsd    xmm3,xmm3,xmm5
       vxorps    xmm3,xmm3,[7FF915F830E0]
       vmulsd    xmm4,xmm4,xmm5
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r10+10]
       vmovsd    qword ptr [rdx],xmm1
       vmovsd    qword ptr [rdx+8],xmm2
       vmovsd    qword ptr [rdx+10],xmm3
       vmovsd    qword ptr [rdx+18],xmm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 204
```

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Double, System.Private.CoreLib]].Lerp()
       sub       rsp,28
       vmovsd    xmm0,qword ptr [7FF915F93318]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M00_L03
       mov       r11,rax
       shl       r11,5
       lea       r10,[r10+r11+10]
       vmovsd    xmm1,qword ptr [r10]
       vmovsd    xmm2,qword ptr [r10+8]
       vmovsd    xmm3,qword ptr [r10+10]
       vmovsd    xmm4,qword ptr [r10+18]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L03
       mov       r9d,r10d
       shl       r9,5
       lea       r8,[r8+r9+10]
       vmovsd    xmm5,qword ptr [r8]
       vmovsd    xmm16,qword ptr [r8+8]
       vmovsd    xmm17,qword ptr [r8+10]
       vmovsd    xmm18,qword ptr [r8+18]
       vmulsd    xmm19,xmm1,xmm5
       vmulsd    xmm20,xmm16,xmm2
       vaddsd    xmm19,xmm20,xmm19
       vmulsd    xmm20,xmm17,xmm3
       vaddsd    xmm19,xmm20,xmm19
       vmulsd    xmm20,xmm18,xmm4
       vaddsd    xmm19,xmm20,xmm19
       vxorps    xmm20,xmm20,xmm20
       vucomisd  xmm19,xmm20
       jb        near ptr M00_L02
       vxorps    xmm19,xmm19,xmm19
       vmulsd    xmm1,xmm19,xmm1
       vaddsd    xmm1,xmm1,xmm5
       vmulsd    xmm5,xmm19,xmm2
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm2,xmm19,xmm3
       vaddsd    xmm2,xmm17,xmm2
       vmulsd    xmm16,xmm19,xmm4
       vaddsd    xmm16,xmm16,xmm18
M00_L01:
       vmulsd    xmm3,xmm1,xmm1
       vmulsd    xmm4,xmm5,xmm5
       vaddsd    xmm3,xmm4,xmm3
       vmulsd    xmm4,xmm2,xmm2
       vaddsd    xmm3,xmm4,xmm3
       vmulsd    xmm4,xmm16,xmm16
       vaddsd    xmm3,xmm4,xmm3
       vsqrtsd   xmm3,xmm3,xmm3
       vdivsd    xmm3,xmm0,xmm3
       vmulsd    xmm1,xmm1,xmm3
       vmulsd    xmm5,xmm5,xmm3
       vmulsd    xmm2,xmm2,xmm3
       vmulsd    xmm16,xmm16,xmm3
       cmp       eax,[rdx+8]
       jae       short M00_L03
       lea       rax,[rdx+r11+10]
       vmovsd    qword ptr [rax],xmm1
       vmovsd    qword ptr [rax+8],xmm5
       vmovsd    qword ptr [rax+10],xmm2
       vmovsd    qword ptr [rax+18],xmm16
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L02:
       vxorps    xmm19,xmm19,xmm19
       vmulsd    xmm1,xmm19,xmm1
       vsubsd    xmm1,xmm1,xmm5
       vmulsd    xmm2,xmm19,xmm2
       vsubsd    xmm5,xmm2,xmm16
       vmulsd    xmm2,xmm19,xmm3
       vsubsd    xmm2,xmm2,xmm17
       vmulsd    xmm3,xmm19,xmm4
       vsubsd    xmm16,xmm3,xmm18
       jmp       near ptr M00_L01
M00_L03:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 405
```

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Double, System.Private.CoreLib]].Slerp()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vzeroupper
       vmovaps   [rsp+0C0],xmm6
       vmovaps   [rsp+0B0],xmm7
       vmovaps   [rsp+0A0],xmm8
       vmovaps   [rsp+90],xmm9
       vmovaps   [rsp+80],xmm10
       vmovaps   [rsp+70],xmm11
       vmovaps   [rsp+60],xmm12
       vmovaps   [rsp+50],xmm13
       vmovaps   [rsp+40],xmm14
       vmovaps   [rsp+30],xmm15
       mov       rbx,rcx
       vmovsd    xmm6,qword ptr [7FF9CE276698]
       xor       esi,esi
M00_L00:
       mov       rdi,[rbx+10]
       mov       rax,[rbx+8]
       mov       rcx,rax
       mov       edx,[rcx+8]
       cmp       esi,edx
       jae       near ptr M00_L08
       mov       rbp,rsi
       shl       rbp,5
       lea       rcx,[rcx+rbp+10]
       vmovsd    xmm7,qword ptr [rcx]
       vmovsd    xmm8,qword ptr [rcx+8]
       vmovsd    xmm9,qword ptr [rcx+10]
       vmovsd    xmm10,qword ptr [rcx+18]
       lea       r14d,[rsi+1]
       cmp       r14d,edx
       jae       near ptr M00_L08
       mov       ecx,r14d
       shl       rcx,5
       lea       rax,[rax+rcx+10]
       vmovsd    xmm11,qword ptr [rax]
       vmovsd    xmm12,qword ptr [rax+8]
       vmovsd    xmm13,qword ptr [rax+10]
       vmovsd    xmm14,qword ptr [rax+18]
       vmulsd    xmm0,xmm11,xmm7
       vmulsd    xmm1,xmm8,xmm12
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm9,xmm13
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm10,xmm14
       vaddsd    xmm0,xmm1,xmm0
       xor       r15d,r15d
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
       jb        near ptr M00_L05
M00_L01:
       vucomisd  xmm0,xmm6
       ja        near ptr M00_L03
       call      00007FFA2D7142D0
       vmovaps   xmm15,xmm0
       vmovaps   xmm0,xmm15
       call      00007FFA2D7143E0
       vmovaps   xmm1,xmm0
       vmovsd    qword ptr [rsp+20],xmm1
       vmovsd    xmm0,qword ptr [7FF9CE2766A0]
       vdivsd    xmm0,xmm0,xmm1
       vmovsd    qword ptr [rsp+28],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmulsd    xmm0,xmm15,xmm0
       call      00007FFA2D7143E0
       vmovsd    xmm15,qword ptr [rsp+28]
       vmulsd    xmm0,xmm15,xmm0
       test      r15d,r15d
       jne       near ptr M00_L07
       vmulsd    xmm1,xmm15,qword ptr [rsp+20]
M00_L02:
       vmulsd    xmm2,xmm0,xmm7
       vmulsd    xmm3,xmm11,xmm1
       vaddsd    xmm2,xmm3,xmm2
       vmulsd    xmm3,xmm8,xmm0
       vmulsd    xmm4,xmm12,xmm1
       vaddsd    xmm3,xmm4,xmm3
       vmulsd    xmm4,xmm9,xmm0
       vmulsd    xmm5,xmm13,xmm1
       vaddsd    xmm4,xmm5,xmm4
       vmulsd    xmm0,xmm10,xmm0
       vmulsd    xmm1,xmm14,xmm1
       vaddsd    xmm0,xmm1,xmm0
       cmp       esi,[rdi+8]
       jae       near ptr M00_L08
       lea       rax,[rdi+rbp+10]
       vmovsd    qword ptr [rax],xmm2
       vmovsd    qword ptr [rax+8],xmm3
       vmovsd    qword ptr [rax+10],xmm4
       vmovsd    qword ptr [rax+18],xmm0
       mov       esi,r14d
       cmp       esi,1869F
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+0C0]
       vmovaps   xmm7,[rsp+0B0]
       vmovaps   xmm8,[rsp+0A0]
       vmovaps   xmm9,[rsp+90]
       vmovaps   xmm10,[rsp+80]
       vmovaps   xmm11,[rsp+70]
       vmovaps   xmm12,[rsp+60]
       vmovaps   xmm13,[rsp+50]
       vmovaps   xmm14,[rsp+40]
       vmovaps   xmm15,[rsp+30]
       add       rsp,0D8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L03:
       vxorps    xmm0,xmm0,xmm0
       test      r15d,r15d
       jne       short M00_L06
       vmovsd    xmm1,qword ptr [7FF9CE2766A0]
M00_L04:
       jmp       near ptr M00_L02
M00_L05:
       mov       r15d,1
       vxorps    xmm0,xmm0,[7FF9CE2766B0]
       jmp       near ptr M00_L01
M00_L06:
       vmovsd    xmm1,qword ptr [7FF9CE2766C0]
       jmp       short M00_L04
M00_L07:
       vmulsd    xmm1,xmm15,qword ptr [rsp+20]
       vxorps    xmm1,xmm1,[7FF9CE2766B0]
       jmp       near ptr M00_L02
M00_L08:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 599
```
