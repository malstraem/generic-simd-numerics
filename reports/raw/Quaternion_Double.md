## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean     | Error   | StdDev  | Code Size |
|---------- |---------:|--------:|--------:|----------:|
| Multiply  | 206.5 μs | 0.48 μs | 0.40 μs |     327 B |
| Divide    | 469.6 μs | 0.85 μs | 0.71 μs |     438 B |
| Conjugate | 115.3 μs | 0.23 μs | 0.19 μs |     128 B |
| Inverse   | 149.8 μs | 0.48 μs | 0.45 μs |     204 B |

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
       vmovsd    xmm0,qword ptr [7FFEC1485F38]
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
       vxorps    xmm5,xmm5,[7FFEC1485F40]
       vmulsd    xmm16,xmm16,xmm19
       vxorps    xmm16,xmm16,[7FFEC1485F50]
       vmulsd    xmm17,xmm17,xmm19
       vxorps    xmm17,xmm17,[7FFEC1485F60]
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
       vxorps    xmm0,xmm0,[7FFEC14A5460]
       vxorps    xmm1,xmm1,[7FFEC14A5460]
       vxorps    xmm2,xmm2,[7FFEC14A5460]
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
       vmovsd    xmm0,qword ptr [7FFEC14D5530]
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
       vxorps    xmm1,xmm1,[7FFEC14D5540]
       vmulsd    xmm2,xmm2,xmm5
       vxorps    xmm2,xmm2,[7FFEC14D5550]
       vmulsd    xmm3,xmm3,xmm5
       vxorps    xmm3,xmm3,[7FFEC14D5560]
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
