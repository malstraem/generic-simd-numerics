## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean     | Error   | StdDev  | Code Size |
|---------- |---------:|--------:|--------:|----------:|
| Multiply  | 204.1 μs | 0.52 μs | 0.43 μs |     327 B |
| Divide    | 424.5 μs | 1.07 μs | 0.95 μs |     438 B |
| Conjugate | 111.3 μs | 0.25 μs | 0.23 μs |     128 B |
| Inverse   | 140.0 μs | 0.36 μs | 0.33 μs |     204 B |

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Single, System.Private.CoreLib]].Multiply()
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
       shl       r11,4
       lea       r10,[r10+r11+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L01
       mov       r9d,r10d
       shl       r9,4
       lea       r8,[r8+r9+10]
       vmovss    xmm4,dword ptr [r8]
       vmovss    xmm5,dword ptr [r8+4]
       vmovss    xmm16,dword ptr [r8+8]
       vmovss    xmm17,dword ptr [r8+0C]
       vmulss    xmm18,xmm16,xmm1
       vmulss    xmm19,xmm2,xmm5
       vsubss    xmm18,xmm18,xmm19
       vmulss    xmm19,xmm2,xmm4
       vmulss    xmm20,xmm16,xmm0
       vsubss    xmm19,xmm19,xmm20
       vmulss    xmm20,xmm0,xmm5
       vmulss    xmm21,xmm1,xmm4
       vsubss    xmm20,xmm20,xmm21
       vmulss    xmm21,xmm0,xmm4
       vmulss    xmm22,xmm1,xmm5
       vaddss    xmm21,xmm22,xmm21
       vmulss    xmm22,xmm16,xmm2
       vaddss    xmm21,xmm22,xmm21
       vmulss    xmm0,xmm17,xmm0
       vmulss    xmm4,xmm4,xmm3
       vaddss    xmm0,xmm4,xmm0
       vaddss    xmm0,xmm18,xmm0
       vmulss    xmm1,xmm17,xmm1
       vmulss    xmm4,xmm5,xmm3
       vaddss    xmm1,xmm4,xmm1
       vaddss    xmm1,xmm19,xmm1
       vmulss    xmm2,xmm17,xmm2
       vmulss    xmm4,xmm16,xmm3
       vaddss    xmm2,xmm4,xmm2
       vaddss    xmm2,xmm20,xmm2
       vmulss    xmm3,xmm17,xmm3
       vsubss    xmm3,xmm3,xmm21
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovss    dword ptr [rax],xmm0
       vmovss    dword ptr [rax+4],xmm1
       vmovss    dword ptr [rax+8],xmm2
       vmovss    dword ptr [rax+0C],xmm3
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
; System.Numerics.Bench.StressQuaternion`1[[System.Single, System.Private.CoreLib]].Divide()
       sub       rsp,28
       vmovss    xmm0,dword ptr [7FFEC14C5F58]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M00_L01
       mov       r11,rax
       shl       r11,4
       lea       r10,[r10+r11+10]
       vmovss    xmm1,dword ptr [r10]
       vmovss    xmm2,dword ptr [r10+4]
       vmovss    xmm3,dword ptr [r10+8]
       vmovss    xmm4,dword ptr [r10+0C]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L01
       mov       r9d,r10d
       shl       r9,4
       lea       r8,[r8+r9+10]
       vmovss    xmm5,dword ptr [r8]
       vmovss    xmm16,dword ptr [r8+4]
       vmovss    xmm17,dword ptr [r8+8]
       vmovss    xmm18,dword ptr [r8+0C]
       vmulss    xmm19,xmm5,xmm5
       vmulss    xmm20,xmm16,xmm16
       vaddss    xmm19,xmm20,xmm19
       vmulss    xmm20,xmm17,xmm17
       vaddss    xmm19,xmm20,xmm19
       vmulss    xmm20,xmm18,xmm18
       vaddss    xmm19,xmm20,xmm19
       vdivss    xmm19,xmm0,xmm19
       vmulss    xmm5,xmm19,xmm5
       vxorps    xmm5,xmm5,[7FFEC14C5F60]
       vmulss    xmm16,xmm16,xmm19
       vxorps    xmm16,xmm16,[7FFEC14C5F70]
       vmulss    xmm17,xmm17,xmm19
       vxorps    xmm17,xmm17,[7FFEC14C5F80]
       vmulss    xmm18,xmm18,xmm19
       vmulss    xmm19,xmm17,xmm2
       vmulss    xmm20,xmm16,xmm3
       vsubss    xmm19,xmm19,xmm20
       vmulss    xmm20,xmm3,xmm5
       vmulss    xmm21,xmm17,xmm1
       vsubss    xmm20,xmm20,xmm21
       vmulss    xmm21,xmm16,xmm1
       vmulss    xmm22,xmm2,xmm5
       vsubss    xmm21,xmm21,xmm22
       vmulss    xmm22,xmm1,xmm5
       vmulss    xmm23,xmm16,xmm2
       vaddss    xmm22,xmm23,xmm22
       vmulss    xmm23,xmm17,xmm3
       vaddss    xmm22,xmm23,xmm22
       vmulss    xmm1,xmm18,xmm1
       vmulss    xmm5,xmm5,xmm4
       vaddss    xmm1,xmm5,xmm1
       vaddss    xmm1,xmm19,xmm1
       vmulss    xmm2,xmm18,xmm2
       vmulss    xmm5,xmm16,xmm4
       vaddss    xmm2,xmm5,xmm2
       vaddss    xmm2,xmm20,xmm2
       vmulss    xmm3,xmm18,xmm3
       vmulss    xmm5,xmm17,xmm4
       vaddss    xmm3,xmm5,xmm3
       vaddss    xmm3,xmm21,xmm3
       vmulss    xmm4,xmm18,xmm4
       vsubss    xmm4,xmm4,xmm22
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovss    dword ptr [rax],xmm1
       vmovss    dword ptr [rax+4],xmm2
       vmovss    dword ptr [rax+8],xmm3
       vmovss    dword ptr [rax+0C],xmm4
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
; System.Numerics.Bench.StressQuaternion`1[[System.Single, System.Private.CoreLib]].Conjugate()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short M00_L01
       mov       r10,rax
       shl       r10,4
       lea       r8,[r8+r10+10]
       vmovss    xmm0,dword ptr [r8]
       vmovss    xmm1,dword ptr [r8+4]
       vmovss    xmm2,dword ptr [r8+8]
       vmovss    xmm3,dword ptr [r8+0C]
       vxorps    xmm0,xmm0,[7FFEC14B56E0]
       vxorps    xmm1,xmm1,[7FFEC14B56E0]
       vxorps    xmm2,xmm2,[7FFEC14B56E0]
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r10+10]
       vmovss    dword ptr [rdx],xmm0
       vmovss    dword ptr [rdx+4],xmm1
       vmovss    dword ptr [rdx+8],xmm2
       vmovss    dword ptr [rdx+0C],xmm3
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
; System.Numerics.Bench.StressQuaternion`1[[System.Single, System.Private.CoreLib]].Inverse()
       sub       rsp,28
       vmovss    xmm0,dword ptr [7FFEC14954CC]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10,rax
       shl       r10,4
       lea       r8,[r8+r10+10]
       vmovss    xmm1,dword ptr [r8]
       vmovss    xmm2,dword ptr [r8+4]
       vmovss    xmm3,dword ptr [r8+8]
       vmovss    xmm4,dword ptr [r8+0C]
       vmulss    xmm5,xmm1,xmm1
       vmulss    xmm16,xmm2,xmm2
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm3,xmm3
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm4,xmm4
       vaddss    xmm5,xmm16,xmm5
       vdivss    xmm5,xmm0,xmm5
       vmulss    xmm1,xmm1,xmm5
       vxorps    xmm1,xmm1,[7FFEC14954D0]
       vmulss    xmm2,xmm2,xmm5
       vxorps    xmm2,xmm2,[7FFEC14954E0]
       vmulss    xmm3,xmm3,xmm5
       vxorps    xmm3,xmm3,[7FFEC14954F0]
       vmulss    xmm4,xmm4,xmm5
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r10+10]
       vmovss    dword ptr [rdx],xmm1
       vmovss    dword ptr [rdx+4],xmm2
       vmovss    dword ptr [rdx+8],xmm3
       vmovss    dword ptr [rdx+0C],xmm4
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
