## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean       | Error   | StdDev  | Code Size |
|---------- |-----------:|--------:|--------:|----------:|
| Multiply  |   209.3 μs | 0.66 μs | 0.62 μs |     327 B |
| Divide    |   436.3 μs | 1.29 μs | 1.20 μs |     438 B |
| Conjugate |   113.8 μs | 0.36 μs | 0.34 μs |     128 B |
| Inverse   |   143.1 μs | 0.63 μs | 0.56 μs |     204 B |
| Lerp      |   584.6 μs | 2.04 μs | 1.90 μs |     497 B |
| Slerp     | 2,018.6 μs | 7.81 μs | 7.30 μs |   3,324 B |

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
       vmovss    xmm0,dword ptr [7FF915F63158]
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
       vxorps    xmm5,xmm5,[7FF915F63160]
       vmulss    xmm16,xmm16,xmm19
       vxorps    xmm16,xmm16,[7FF915F63170]
       vmulss    xmm17,xmm17,xmm19
       vxorps    xmm17,xmm17,[7FF915F63180]
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
       vxorps    xmm0,xmm0,[7FF915F92B40]
       vxorps    xmm1,xmm1,[7FF915F92B40]
       vxorps    xmm2,xmm2,[7FF915F92B40]
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
       vmovss    xmm0,dword ptr [7FF915F62C0C]
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
       vxorps    xmm1,xmm1,[7FF915F62C10]
       vmulss    xmm2,xmm2,xmm5
       vxorps    xmm2,xmm2,[7FF915F62C20]
       vmulss    xmm3,xmm3,xmm5
       vxorps    xmm3,xmm3,[7FF915F62C30]
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

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Single, System.Private.CoreLib]].Lerp()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vmovaps   [rsp+50],xmm6
       mov       rbx,rcx
       vmovss    xmm6,dword ptr [7FF915F93590]
       xor       esi,esi
M00_L00:
       mov       rdi,[rbx+10]
       mov       rdx,[rbx+8]
       mov       r8,rdx
       mov       ecx,[r8+8]
       cmp       esi,ecx
       jae       short M00_L01
       mov       rbp,rsi
       shl       rbp,4
       vmovups   xmm3,[r8+rbp+10]
       vmovups   [rsp+30],xmm3
       lea       r14d,[rsi+1]
       cmp       r14d,ecx
       jae       short M00_L01
       mov       r8d,r14d
       shl       r8,4
       vmovups   xmm3,[rdx+r8+10]
       vmovups   [rsp+20],xmm3
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       vmovaps   xmm3,xmm6
       lea       rcx,[rsp+40]
       call      qword ptr [7FF915F04588]; Silk.NET.Maths.Quaternion`1[[System.Single, System.Private.CoreLib]].Lerp(Silk.NET.Maths.Quaternion`1<Single>, Silk.NET.Maths.Quaternion`1<Single>, Single)
       cmp       esi,[rdi+8]
       jae       short M00_L01
       vmovups   xmm0,[rsp+40]
       vmovups   [rdi+rbp+10],xmm0
       mov       esi,r14d
       cmp       esi,1869F
       jl        short M00_L00
       vmovaps   xmm6,[rsp+50]
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 173

; Silk.NET.Maths.Quaternion`1[[System.Single, System.Private.CoreLib]].Lerp(Silk.NET.Maths.Quaternion`1<Single>, Silk.NET.Maths.Quaternion`1<Single>, Single)
       vmovss    xmm0,dword ptr [r8]
       vmovss    xmm1,dword ptr [r8+4]
       vmovss    xmm2,dword ptr [r8+8]
       vmovss    xmm4,dword ptr [r8+0C]
       vmovss    xmm5,dword ptr [rdx]
       vmovss    xmm16,dword ptr [rdx+4]
       vmovss    xmm17,dword ptr [rdx+8]
       vmovss    xmm18,dword ptr [rdx+0C]
       vmovss    xmm19,dword ptr [7FF915F90274]
       vsubss    xmm20,xmm19,xmm3
       vmulss    xmm21,xmm5,xmm0
       vmulss    xmm22,xmm16,xmm1
       vaddss    xmm21,xmm22,xmm21
       vmulss    xmm22,xmm17,xmm2
       vaddss    xmm21,xmm22,xmm21
       vmulss    xmm22,xmm18,xmm4
       vaddss    xmm21,xmm22,xmm21
       vxorps    xmm22,xmm22,xmm22
       vucomiss  xmm21,xmm22
       jb        near ptr M01_L01
       vmulss    xmm5,xmm20,xmm5
       vmulss    xmm0,xmm3,xmm0
       vaddss    xmm0,xmm0,xmm5
       vmulss    xmm16,xmm20,xmm16
       vmulss    xmm1,xmm3,xmm1
       vaddss    xmm1,xmm16,xmm1
       vmulss    xmm17,xmm20,xmm17
       vmulss    xmm2,xmm3,xmm2
       vaddss    xmm2,xmm17,xmm2
       vmulss    xmm20,xmm20,xmm18
       vmulss    xmm3,xmm3,xmm4
       vaddss    xmm3,xmm20,xmm3
M01_L00:
       vmulss    xmm4,xmm0,xmm0
       vmulss    xmm5,xmm1,xmm1
       vaddss    xmm4,xmm5,xmm4
       vmulss    xmm5,xmm2,xmm2
       vaddss    xmm4,xmm5,xmm4
       vmulss    xmm5,xmm3,xmm3
       vaddss    xmm4,xmm5,xmm4
       vsqrtss   xmm4,xmm4,xmm4
       vdivss    xmm4,xmm19,xmm4
       vmulss    xmm0,xmm0,xmm4
       vmulss    xmm1,xmm1,xmm4
       vmulss    xmm2,xmm2,xmm4
       vmulss    xmm3,xmm3,xmm4
       vmovss    dword ptr [rcx],xmm0
       vmovss    dword ptr [rcx+4],xmm1
       vmovss    dword ptr [rcx+8],xmm2
       vmovss    dword ptr [rcx+0C],xmm3
       mov       rax,rcx
       ret
M01_L01:
       vmulss    xmm5,xmm20,xmm5
       vmulss    xmm0,xmm3,xmm0
       vsubss    xmm0,xmm5,xmm0
       vmulss    xmm5,xmm20,xmm16
       vmulss    xmm1,xmm3,xmm1
       vsubss    xmm1,xmm5,xmm1
       vmulss    xmm5,xmm20,xmm17
       vmulss    xmm2,xmm3,xmm2
       vsubss    xmm2,xmm5,xmm2
       vmulss    xmm5,xmm20,xmm18
       vmulss    xmm3,xmm3,xmm4
       vsubss    xmm3,xmm5,xmm3
       jmp       near ptr M01_L00
; Total bytes of code 324
```

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Single, System.Private.CoreLib]].Slerp()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vzeroupper
       vmovaps   [rsp+0D0],xmm6
       vmovaps   [rsp+0C0],xmm7
       vmovaps   [rsp+0B0],xmm8
       vmovaps   [rsp+0A0],xmm9
       vmovaps   [rsp+90],xmm10
       vmovaps   [rsp+80],xmm11
       vmovaps   [rsp+70],xmm12
       vmovaps   [rsp+60],xmm13
       vmovaps   [rsp+50],xmm14
       vmovaps   [rsp+40],xmm15
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       xor       esi,esi
       jmp       near ptr M00_L35
M00_L00:
       vucomisd  xmm1,qword ptr [7FF9CE2A83C8]
       jb        short M00_L01
       vcvtss2sd xmm1,xmm1,xmm14
       vmulsd    xmm0,xmm1,xmm1
       vmulsd    xmm0,xmm0,xmm1
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A83D0]
       vaddsd    xmm15,xmm0,xmm1
       jmp       near ptr M00_L14
M00_L01:
       vcvtss2sd xmm15,xmm15,xmm14
       jmp       near ptr M00_L14
M00_L02:
       xor       r13d,r13d
       vmovd     edx,xmm0
       test      edx,edx
       jge       short M00_L03
       vxorps    xmm0,xmm14,[7FF9CE2A83E0]
       mov       r13d,1
M00_L03:
       vcvtss2sd xmm0,xmm0,xmm0
       vmovsd    xmm2,qword ptr [7FF9CE2A83F0]
       vucomisd  xmm2,xmm0
       jbe       near ptr M00_L12
       vmulsd    xmm2,xmm0,qword ptr [7FF9CE2A83F8]
       vaddsd    xmm2,xmm2,qword ptr [7FF9CE2A8400]
       vcmpordsd xmm3,xmm2,xmm2
       vandpd    xmm3,xmm3,xmm2
       mov       edx,7FFFFFFF
       vcvttsd2si eax,xmm3
       vucomisd  xmm2,qword ptr [7FF9CE2A8408]
       cmovb     edx,eax
       mov       [rsp+30],edx
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2sd xmm2,xmm2,dword ptr [rsp+30]
       vmulsd    xmm3,xmm2,qword ptr [7FF9CE2A8410]
       vsubsd    xmm15,xmm0,xmm3
       vmulsd    xmm0,xmm2,qword ptr [7FF9CE2A8418]
       vsubsd    xmm0,xmm15,xmm0
       vmovq     rdx,xmm0
       add       rdx,rdx
       sar       rdx,35
       vmovq     rax,xmm1
       sar       rax,34
       sub       rax,rdx
       cmp       rax,0F
       jle       short M00_L04
       vmovaps   xmm0,xmm15
       vmulsd    xmm1,xmm2,qword ptr [7FF9CE2A8420]
       vsubsd    xmm15,xmm0,xmm1
       vsubsd    xmm0,xmm0,xmm15
       vsubsd    xmm0,xmm0,xmm1
       vmulsd    xmm1,xmm2,qword ptr [7FF9CE2A8428]
       vsubsd    xmm0,xmm1,xmm0
       vsubsd    xmm0,xmm15,xmm0
M00_L04:
       cmp       rdx,3F2
       jl        near ptr M00_L07
       test      byte ptr [rsp+30],1
       je        short M00_L06
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm2,xmm0,qword ptr [7FF9CE2A8430]
       vaddsd    xmm2,xmm2,qword ptr [7FF9CE2A8438]
       vmulsd    xmm2,xmm1,xmm2
       vmulsd    xmm3,xmm0,qword ptr [7FF9CE2A8440]
       vaddsd    xmm3,xmm3,qword ptr [7FF9CE2A8448]
       vaddsd    xmm2,xmm2,xmm3
       vmulsd    xmm1,xmm1,xmm2
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A8450]
       vaddsd    xmm0,xmm0,qword ptr [7FF9CE2A8458]
       vaddsd    xmm15,xmm1,xmm0
M00_L05:
       jmp       near ptr M00_L13
M00_L06:
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm2,xmm1,xmm0
       vmulsd    xmm3,xmm1,xmm1
       vmulsd    xmm4,xmm1,qword ptr [7FF9CE2A8460]
       vaddsd    xmm4,xmm4,qword ptr [7FF9CE2A8468]
       vmulsd    xmm3,xmm3,xmm4
       vmulsd    xmm1,xmm1,qword ptr [7FF9CE2A8470]
       vaddsd    xmm1,xmm1,qword ptr [7FF9CE2A83D0]
       vaddsd    xmm1,xmm3,xmm1
       vmulsd    xmm1,xmm2,xmm1
       vaddsd    xmm15,xmm0,xmm1
       jmp       short M00_L05
M00_L07:
       cmp       rdx,3DE
       jle       short M00_L10
       test      byte ptr [rsp+30],1
       je        short M00_L09
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A8448]
       vaddsd    xmm15,xmm0,qword ptr [7FF9CE2A8458]
M00_L08:
       jmp       near ptr M00_L13
M00_L09:
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm1,xmm1,xmm0
       vmulsd    xmm1,xmm1,qword ptr [7FF9CE2A83D0]
       vaddsd    xmm15,xmm1,xmm0
       jmp       short M00_L08
M00_L10:
       test      byte ptr [rsp+30],1
       jne       short M00_L11
       vmovaps   xmm15,xmm0
       jmp       short M00_L13
M00_L11:
       vmovsd    xmm15,qword ptr [7FF9CE2A8458]
       jmp       short M00_L13
M00_L12:
       lea       rdx,[rsp+30]
       call      qword ptr [7FF9CE1DE070]; Precode of Silk.NET.Maths.Scalar.<Sin_Ported>g__ReduceForLargeInput|84_2(Double, Int32 ByRef)
       test      byte ptr [rsp+30],1
       je        near ptr M00_L16
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm2,xmm0,qword ptr [7FF9CE2A8430]
       vaddsd    xmm2,xmm2,qword ptr [7FF9CE2A8438]
       vmulsd    xmm2,xmm1,xmm2
       vmulsd    xmm3,xmm0,qword ptr [7FF9CE2A8440]
       vaddsd    xmm3,xmm3,qword ptr [7FF9CE2A8448]
       vaddsd    xmm2,xmm2,xmm3
       vmulsd    xmm1,xmm1,xmm2
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A8450]
       vaddsd    xmm0,xmm0,qword ptr [7FF9CE2A8458]
       vaddsd    xmm15,xmm1,xmm0
M00_L13:
       mov       edx,[rsp+30]
       sar       edx,1
       mov       [rsp+30],edx
       mov       edx,r13d
       and       edx,[rsp+30]
       mov       eax,[rsp+30]
       not       eax
       mov       [rsp+30],eax
       andn      eax,r13d,[rsp+30]
       or        edx,eax
       test      dl,1
       jne       short M00_L14
       vxorps    xmm15,xmm15,[7FF9CE2A8480]
M00_L14:
       vcvtsd2ss xmm0,xmm0,xmm15
M00_L15:
       vmovss    xmm1,dword ptr [7FF9CE2A8490]
       vdivss    xmm15,xmm1,xmm0
       vxorps    xmm0,xmm0,xmm0
       vmulss    xmm0,xmm14,xmm0
       xor       edx,edx
       mov       [rsp+28],edx
       vmovd     edx,xmm0
       and       edx,7FFFFFFF
       cmp       edx,7F800000
       jge       near ptr M00_L39
       vandps    xmm1,xmm0,[7FF9CE2A84A0]
       vcvtss2sd xmm1,xmm1,xmm1
       vmovsd    xmm2,qword ptr [7FF9CE2A84B0]
       vucomisd  xmm2,xmm1
       jb        near ptr M00_L20
       vucomisd  xmm1,qword ptr [7FF9CE2A84B8]
       jb        near ptr M00_L18
       vcvtss2sd xmm1,xmm1,xmm0
       vmulsd    xmm0,xmm1,xmm1
       vmulsd    xmm2,xmm0,xmm1
       vmulsd    xmm3,xmm0,xmm0
       vmulsd    xmm4,xmm0,qword ptr [7FF9CE2A8460]
       vaddsd    xmm4,xmm4,qword ptr [7FF9CE2A8468]
       vmulsd    xmm3,xmm3,xmm4
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A8470]
       vaddsd    xmm0,xmm0,qword ptr [7FF9CE2A83D0]
       vaddsd    xmm0,xmm3,xmm0
       vmulsd    xmm0,xmm2,xmm0
       vaddsd    xmm0,xmm1,xmm0
       jmp       near ptr M00_L32
M00_L16:
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm2,xmm1,xmm0
       vmulsd    xmm3,xmm1,xmm1
       vmulsd    xmm4,xmm1,qword ptr [7FF9CE2A8460]
       vaddsd    xmm4,xmm4,qword ptr [7FF9CE2A8468]
       vmulsd    xmm3,xmm3,xmm4
       vmulsd    xmm1,xmm1,qword ptr [7FF9CE2A8470]
       vaddsd    xmm1,xmm1,qword ptr [7FF9CE2A83D0]
       vaddsd    xmm1,xmm3,xmm1
       vmulsd    xmm1,xmm2,xmm1
       vaddsd    xmm15,xmm0,xmm1
       jmp       near ptr M00_L13
M00_L17:
       vmovss    xmm0,dword ptr [7FF9CE2A84C0]
       jmp       near ptr M00_L15
M00_L18:
       vucomisd  xmm1,qword ptr [7FF9CE2A83C8]
       jb        short M00_L19
       vcvtss2sd xmm0,xmm0,xmm0
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm1,xmm1,xmm0
       vmulsd    xmm1,xmm1,qword ptr [7FF9CE2A83D0]
       vaddsd    xmm0,xmm1,xmm0
       jmp       near ptr M00_L32
M00_L19:
       vcvtss2sd xmm0,xmm0,xmm0
       jmp       near ptr M00_L32
M00_L20:
       xor       r13d,r13d
       vmovd     edx,xmm0
       test      edx,edx
       jge       short M00_L21
       vxorps    xmm0,xmm0,[7FF9CE2A83E0]
       mov       r13d,1
M00_L21:
       vcvtss2sd xmm0,xmm0,xmm0
       vmovsd    xmm2,qword ptr [7FF9CE2A83F0]
       vucomisd  xmm2,xmm0
       jbe       near ptr M00_L30
       vmulsd    xmm2,xmm0,qword ptr [7FF9CE2A83F8]
       vaddsd    xmm2,xmm2,qword ptr [7FF9CE2A8400]
       vcmpordsd xmm3,xmm2,xmm2
       vandpd    xmm3,xmm3,xmm2
       mov       edx,7FFFFFFF
       vcvttsd2si eax,xmm3
       vucomisd  xmm2,qword ptr [7FF9CE2A8408]
       cmovb     edx,eax
       mov       [rsp+28],edx
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2sd xmm2,xmm2,dword ptr [rsp+28]
       vmulsd    xmm3,xmm2,qword ptr [7FF9CE2A8410]
       vsubsd    xmm0,xmm0,xmm3
       vmulsd    xmm3,xmm2,qword ptr [7FF9CE2A8418]
       vsubsd    xmm3,xmm0,xmm3
       vmovq     rdx,xmm3
       add       rdx,rdx
       sar       rdx,35
       vmovq     rax,xmm1
       sar       rax,34
       sub       rax,rdx
       cmp       rax,0F
       jle       short M00_L22
       vmovaps   xmm3,xmm0
       vmulsd    xmm1,xmm2,qword ptr [7FF9CE2A8420]
       vsubsd    xmm0,xmm3,xmm1
       vsubsd    xmm3,xmm3,xmm0
       vsubsd    xmm1,xmm3,xmm1
       vmulsd    xmm2,xmm2,qword ptr [7FF9CE2A8428]
       vsubsd    xmm1,xmm2,xmm1
       vsubsd    xmm3,xmm0,xmm1
M00_L22:
       cmp       rdx,3F2
       jl        near ptr M00_L25
       test      byte ptr [rsp+28],1
       je        short M00_L24
       vmulsd    xmm3,xmm3,xmm3
       vmulsd    xmm0,xmm3,xmm3
       vmulsd    xmm1,xmm3,qword ptr [7FF9CE2A8430]
       vaddsd    xmm1,xmm1,qword ptr [7FF9CE2A8438]
       vmulsd    xmm1,xmm0,xmm1
       vmulsd    xmm2,xmm3,qword ptr [7FF9CE2A8440]
       vaddsd    xmm2,xmm2,qword ptr [7FF9CE2A8448]
       vaddsd    xmm1,xmm1,xmm2
       vmulsd    xmm0,xmm0,xmm1
       vmulsd    xmm1,xmm3,qword ptr [7FF9CE2A8450]
       vaddsd    xmm1,xmm1,qword ptr [7FF9CE2A8458]
       vaddsd    xmm0,xmm0,xmm1
M00_L23:
       jmp       near ptr M00_L31
M00_L24:
       vmulsd    xmm0,xmm3,xmm3
       vmulsd    xmm1,xmm0,xmm3
       vmulsd    xmm2,xmm0,xmm0
       vmulsd    xmm4,xmm0,qword ptr [7FF9CE2A8460]
       vaddsd    xmm4,xmm4,qword ptr [7FF9CE2A8468]
       vmulsd    xmm2,xmm2,xmm4
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A8470]
       vaddsd    xmm0,xmm0,qword ptr [7FF9CE2A83D0]
       vaddsd    xmm0,xmm2,xmm0
       vmulsd    xmm0,xmm1,xmm0
       vaddsd    xmm0,xmm3,xmm0
       jmp       short M00_L23
M00_L25:
       cmp       rdx,3DE
       jle       short M00_L28
       test      byte ptr [rsp+28],1
       je        short M00_L27
       vmulsd    xmm3,xmm3,xmm3
       vmulsd    xmm0,xmm3,qword ptr [7FF9CE2A8448]
       vaddsd    xmm0,xmm0,qword ptr [7FF9CE2A8458]
M00_L26:
       jmp       near ptr M00_L31
M00_L27:
       vmulsd    xmm0,xmm3,xmm3
       vmulsd    xmm0,xmm0,xmm3
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A83D0]
       vaddsd    xmm0,xmm0,xmm3
       jmp       short M00_L26
M00_L28:
       test      byte ptr [rsp+28],1
       jne       short M00_L29
       vmovaps   xmm0,xmm3
       jmp       short M00_L31
M00_L29:
       vmovsd    xmm0,qword ptr [7FF9CE2A8458]
       jmp       short M00_L31
M00_L30:
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9CE1DE070]; Precode of Silk.NET.Maths.Scalar.<Sin_Ported>g__ReduceForLargeInput|84_2(Double, Int32 ByRef)
       test      byte ptr [rsp+28],1
       je        near ptr M00_L38
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm2,xmm0,qword ptr [7FF9CE2A8430]
       vaddsd    xmm2,xmm2,qword ptr [7FF9CE2A8438]
       vmulsd    xmm2,xmm1,xmm2
       vmulsd    xmm3,xmm0,qword ptr [7FF9CE2A8440]
       vaddsd    xmm3,xmm3,qword ptr [7FF9CE2A8448]
       vaddsd    xmm2,xmm2,xmm3
       vmulsd    xmm1,xmm1,xmm2
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A8450]
       vaddsd    xmm0,xmm0,qword ptr [7FF9CE2A8458]
       vaddsd    xmm0,xmm1,xmm0
M00_L31:
       mov       eax,[rsp+28]
       sar       eax,1
       mov       [rsp+28],eax
       mov       eax,r13d
       and       eax,[rsp+28]
       mov       ecx,[rsp+28]
       not       ecx
       mov       [rsp+28],ecx
       andn      ecx,r13d,[rsp+28]
       or        eax,ecx
       test      al,1
       jne       short M00_L32
       vxorps    xmm0,xmm0,[7FF9CE2A84D0]
M00_L32:
       vcvtsd2ss xmm0,xmm0,xmm0
M00_L33:
       vmulss    xmm0,xmm15,xmm0
       vmovss    dword ptr [rsp+3C],xmm0
       test      r15d,r15d
       jne       near ptr M00_L44
       vmovaps   xmm0,xmm14
       call      qword ptr [7FF9CE267EA0]; Silk.NET.Maths.Scalar.Sin_Ported(Single)
       vmulss    xmm14,xmm15,xmm0
M00_L34:
       vmovss    xmm15,dword ptr [rsp+3C]
       vmulss    xmm0,xmm15,xmm6
       vmulss    xmm1,xmm14,xmm10
       vaddss    xmm6,xmm1,xmm0
       vmulss    xmm0,xmm15,xmm7
       vmulss    xmm1,xmm14,xmm11
       vaddss    xmm7,xmm1,xmm0
       vmovaps   xmm0,xmm15
       vmovaps   xmm1,xmm8
       call      qword ptr [7FF9CE1DD950]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm8,xmm0
       vmovaps   xmm0,xmm14
       vmovaps   xmm1,xmm12
       call      qword ptr [7FF9CE1DD950]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm1,xmm0
       vmovaps   xmm0,xmm8
       call      qword ptr [7FF9CE1DD980]; Silk.NET.Maths.Scalar.Add[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm8,xmm0
       vmovaps   xmm0,xmm15
       vmovaps   xmm1,xmm9
       call      qword ptr [7FF9CE1DD950]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm9,xmm0
       vmovaps   xmm0,xmm14
       vmovaps   xmm1,xmm13
       call      qword ptr [7FF9CE1DD950]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm1,xmm0
       vmovaps   xmm0,xmm9
       call      qword ptr [7FF9CE1DD980]; Silk.NET.Maths.Scalar.Add[[System.Single, System.Private.CoreLib]](Single, Single)
       cmp       esi,[rdi+8]
       jae       near ptr M00_L45
       lea       rax,[rdi+rbp+10]
       vmovss    dword ptr [rax],xmm6
       vmovss    dword ptr [rax+4],xmm7
       vmovss    dword ptr [rax+8],xmm8
       vmovss    dword ptr [rax+0C],xmm0
       mov       esi,r14d
       cmp       esi,1869F
       jge       near ptr M00_L37
M00_L35:
       mov       rdi,[rbx+10]
       mov       rax,[rbx+8]
       mov       rcx,rax
       mov       edx,[rcx+8]
       cmp       esi,edx
       jae       near ptr M00_L45
       mov       rbp,rsi
       shl       rbp,4
       lea       rcx,[rcx+rbp+10]
       vmovss    xmm6,dword ptr [rcx]
       vmovss    xmm7,dword ptr [rcx+4]
       vmovss    xmm8,dword ptr [rcx+8]
       vmovss    xmm9,dword ptr [rcx+0C]
       lea       r14d,[rsi+1]
       cmp       r14d,edx
       jae       near ptr M00_L45
       mov       ecx,r14d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       vmovss    xmm10,dword ptr [rax]
       vmovss    xmm11,dword ptr [rax+4]
       vmovss    xmm12,dword ptr [rax+8]
       vmovss    xmm13,dword ptr [rax+0C]
       vmulss    xmm0,xmm10,xmm6
       vmulss    xmm1,xmm11,xmm7
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm8,xmm12
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm9,xmm13
       vaddss    xmm0,xmm1,xmm0
       xor       r15d,r15d
       vxorps    xmm1,xmm1,xmm1
       vucomiss  xmm0,xmm1
       jb        near ptr M00_L42
M00_L36:
       vucomiss  xmm0,dword ptr [7FF9CE2A84E0]
       ja        near ptr M00_L40
       call      00007FFA2D714470
       vmovaps   xmm14,xmm0
       vmovaps   xmm0,xmm14
       xor       edx,edx
       mov       [rsp+30],edx
       vmovd     edx,xmm0
       and       edx,7FFFFFFF
       cmp       edx,7F800000
       jge       near ptr M00_L17
       vandps    xmm1,xmm0,[7FF9CE2A84F0]
       vcvtss2sd xmm1,xmm1,xmm1
       vmovsd    xmm2,qword ptr [7FF9CE2A8500]
       vucomisd  xmm2,xmm1
       jb        near ptr M00_L02
       vucomisd  xmm1,qword ptr [7FF9CE2A8508]
       jb        near ptr M00_L00
       vcvtss2sd xmm1,xmm1,xmm14
       vmulsd    xmm0,xmm1,xmm1
       vmulsd    xmm2,xmm0,xmm1
       vmulsd    xmm3,xmm0,xmm0
       vmulsd    xmm4,xmm0,qword ptr [7FF9CE2A8460]
       vaddsd    xmm4,xmm4,qword ptr [7FF9CE2A8468]
       vmulsd    xmm3,xmm3,xmm4
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A8470]
       vaddsd    xmm0,xmm0,qword ptr [7FF9CE2A83D0]
       vaddsd    xmm0,xmm3,xmm0
       vmulsd    xmm0,xmm2,xmm0
       vaddsd    xmm15,xmm1,xmm0
       jmp       near ptr M00_L14
M00_L37:
       vmovaps   xmm6,[rsp+0D0]
       vmovaps   xmm7,[rsp+0C0]
       vmovaps   xmm8,[rsp+0B0]
       vmovaps   xmm9,[rsp+0A0]
       vmovaps   xmm10,[rsp+90]
       vmovaps   xmm11,[rsp+80]
       vmovaps   xmm12,[rsp+70]
       vmovaps   xmm13,[rsp+60]
       vmovaps   xmm14,[rsp+50]
       vmovaps   xmm15,[rsp+40]
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L38:
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm2,xmm1,xmm0
       vmulsd    xmm3,xmm1,xmm1
       vmulsd    xmm4,xmm1,qword ptr [7FF9CE2A8460]
       vaddsd    xmm4,xmm4,qword ptr [7FF9CE2A8468]
       vmulsd    xmm3,xmm3,xmm4
       vmulsd    xmm1,xmm1,qword ptr [7FF9CE2A8470]
       vaddsd    xmm1,xmm1,qword ptr [7FF9CE2A83D0]
       vaddsd    xmm1,xmm3,xmm1
       vmulsd    xmm1,xmm2,xmm1
       vaddsd    xmm0,xmm0,xmm1
       jmp       near ptr M00_L31
M00_L39:
       vmovss    xmm0,dword ptr [7FF9CE2A84C0]
       jmp       near ptr M00_L33
M00_L40:
       vxorps    xmm1,xmm1,xmm1
       vxorps    xmm15,xmm15,xmm15
       test      r15d,r15d
       jne       short M00_L43
       vmovss    xmm14,dword ptr [7FF9CE2A8490]
M00_L41:
       vmovss    dword ptr [rsp+3C],xmm15
       jmp       near ptr M00_L34
M00_L42:
       mov       r15d,1
       vxorps    xmm0,xmm0,[7FF9CE2A83E0]
       jmp       near ptr M00_L36
M00_L43:
       vmovss    xmm14,dword ptr [7FF9CE2A8510]
       jmp       short M00_L41
M00_L44:
       vmovaps   xmm0,xmm14
       call      qword ptr [7FF9CE267EA0]; Silk.NET.Maths.Scalar.Sin_Ported(Single)
       vmulss    xmm0,xmm15,xmm0
       vxorps    xmm14,xmm0,[7FF9CE2A83E0]
       jmp       near ptr M00_L34
M00_L45:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 2435

; Silk.NET.Maths.Scalar.Sin_Ported(Single)
       push      rbx
       sub       rsp,40
       vmovaps   [rsp+30],xmm6
       xor       eax,eax
       mov       [rsp+28],rax
       vmovd     edx,xmm0
       and       edx,7FFFFFFF
       cmp       edx,7F800000
       jge       near ptr M01_L16
       vandps    xmm1,xmm0,[7FF9CE2A9060]
       vcvtss2sd xmm1,xmm1,xmm1
       vmovsd    xmm2,qword ptr [7FF9CE2A9070]
       vucomisd  xmm2,xmm1
       jb        near ptr M01_L02
       vucomisd  xmm1,qword ptr [7FF9CE2A9078]
       jb        short M01_L00
       vcvtss2sd xmm1,xmm1,xmm0
       vmulsd    xmm0,xmm1,xmm1
       vmulsd    xmm2,xmm0,xmm1
       vmulsd    xmm3,xmm0,xmm0
       vmulsd    xmm4,xmm0,qword ptr [7FF9CE2A9080]
       vaddsd    xmm4,xmm4,qword ptr [7FF9CE2A9088]
       vmulsd    xmm3,xmm3,xmm4
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A9090]
       vaddsd    xmm0,xmm0,qword ptr [7FF9CE2A9098]
       vaddsd    xmm0,xmm3,xmm0
       vmulsd    xmm0,xmm2,xmm0
       vaddsd    xmm6,xmm1,xmm0
       jmp       near ptr M01_L14
M01_L00:
       vucomisd  xmm1,qword ptr [7FF9CE2A90A0]
       jb        short M01_L01
       vcvtss2sd xmm0,xmm0,xmm0
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm1,xmm1,xmm0
       vmulsd    xmm1,xmm1,qword ptr [7FF9CE2A9098]
       vaddsd    xmm6,xmm1,xmm0
       jmp       near ptr M01_L14
M01_L01:
       vcvtss2sd xmm6,xmm6,xmm0
       jmp       near ptr M01_L14
M01_L02:
       xor       ebx,ebx
       vmovd     edx,xmm0
       test      edx,edx
       jge       short M01_L03
       vxorps    xmm0,xmm0,[7FF9CE2A90B0]
       mov       ebx,1
M01_L03:
       vcvtss2sd xmm0,xmm0,xmm0
       vmovsd    xmm2,qword ptr [7FF9CE2A90C0]
       vucomisd  xmm2,xmm0
       jbe       near ptr M01_L12
       vmulsd    xmm2,xmm0,qword ptr [7FF9CE2A90C8]
       vaddsd    xmm2,xmm2,qword ptr [7FF9CE2A90D0]
       vcmpordsd xmm3,xmm2,xmm2
       vandpd    xmm3,xmm3,xmm2
       mov       edx,7FFFFFFF
       vcvttsd2si eax,xmm3
       vucomisd  xmm2,qword ptr [7FF9CE2A90D8]
       cmovb     edx,eax
       mov       [rsp+28],edx
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2sd xmm2,xmm2,dword ptr [rsp+28]
       vmulsd    xmm3,xmm2,qword ptr [7FF9CE2A90E0]
       vsubsd    xmm6,xmm0,xmm3
       vmulsd    xmm0,xmm2,qword ptr [7FF9CE2A90E8]
       vsubsd    xmm0,xmm6,xmm0
       vmovq     rdx,xmm0
       add       rdx,rdx
       sar       rdx,35
       vmovq     rax,xmm1
       sar       rax,34
       sub       rax,rdx
       cmp       rax,0F
       jle       short M01_L04
       vmovaps   xmm0,xmm6
       vmulsd    xmm1,xmm2,qword ptr [7FF9CE2A90F0]
       vsubsd    xmm6,xmm0,xmm1
       vsubsd    xmm0,xmm0,xmm6
       vsubsd    xmm0,xmm0,xmm1
       vmulsd    xmm1,xmm2,qword ptr [7FF9CE2A90F8]
       vsubsd    xmm0,xmm1,xmm0
       vsubsd    xmm0,xmm6,xmm0
M01_L04:
       cmp       rdx,3F2
       jl        near ptr M01_L07
       test      byte ptr [rsp+28],1
       je        short M01_L06
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm2,xmm0,qword ptr [7FF9CE2A9100]
       vaddsd    xmm2,xmm2,qword ptr [7FF9CE2A9108]
       vmulsd    xmm2,xmm1,xmm2
       vmulsd    xmm3,xmm0,qword ptr [7FF9CE2A9110]
       vaddsd    xmm3,xmm3,qword ptr [7FF9CE2A9118]
       vaddsd    xmm2,xmm2,xmm3
       vmulsd    xmm1,xmm1,xmm2
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A9120]
       vaddsd    xmm0,xmm0,qword ptr [7FF9CE2A9128]
       vaddsd    xmm6,xmm1,xmm0
M01_L05:
       jmp       near ptr M01_L13
M01_L06:
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm2,xmm1,xmm0
       vmulsd    xmm3,xmm1,xmm1
       vmulsd    xmm4,xmm1,qword ptr [7FF9CE2A9080]
       vaddsd    xmm4,xmm4,qword ptr [7FF9CE2A9088]
       vmulsd    xmm3,xmm3,xmm4
       vmulsd    xmm1,xmm1,qword ptr [7FF9CE2A9090]
       vaddsd    xmm1,xmm1,qword ptr [7FF9CE2A9098]
       vaddsd    xmm1,xmm3,xmm1
       vmulsd    xmm1,xmm2,xmm1
       vaddsd    xmm6,xmm0,xmm1
       jmp       short M01_L05
M01_L07:
       cmp       rdx,3DE
       jle       short M01_L10
       test      byte ptr [rsp+28],1
       je        short M01_L09
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A9118]
       vaddsd    xmm6,xmm0,qword ptr [7FF9CE2A9128]
M01_L08:
       jmp       near ptr M01_L13
M01_L09:
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm1,xmm1,xmm0
       vmulsd    xmm1,xmm1,qword ptr [7FF9CE2A9098]
       vaddsd    xmm6,xmm1,xmm0
       jmp       short M01_L08
M01_L10:
       test      byte ptr [rsp+28],1
       jne       short M01_L11
       vmovaps   xmm6,xmm0
       jmp       short M01_L13
M01_L11:
       vmovsd    xmm6,qword ptr [7FF9CE2A9128]
       jmp       short M01_L13
M01_L12:
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9CE1DE070]; Precode of Silk.NET.Maths.Scalar.<Sin_Ported>g__ReduceForLargeInput|84_2(Double, Int32 ByRef)
       test      byte ptr [rsp+28],1
       je        near ptr M01_L15
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm2,xmm0,qword ptr [7FF9CE2A9100]
       vaddsd    xmm2,xmm2,qword ptr [7FF9CE2A9108]
       vmulsd    xmm2,xmm1,xmm2
       vmulsd    xmm3,xmm0,qword ptr [7FF9CE2A9110]
       vaddsd    xmm3,xmm3,qword ptr [7FF9CE2A9118]
       vaddsd    xmm2,xmm2,xmm3
       vmulsd    xmm1,xmm1,xmm2
       vmulsd    xmm0,xmm0,qword ptr [7FF9CE2A9120]
       vaddsd    xmm0,xmm0,qword ptr [7FF9CE2A9128]
       vaddsd    xmm6,xmm1,xmm0
M01_L13:
       mov       eax,[rsp+28]
       sar       eax,1
       mov       [rsp+28],eax
       mov       eax,ebx
       and       eax,[rsp+28]
       mov       ecx,[rsp+28]
       not       ecx
       mov       [rsp+28],ecx
       andn      ecx,ebx,[rsp+28]
       or        eax,ecx
       test      al,1
       jne       short M01_L14
       vxorps    xmm6,xmm6,[7FF9CE2A9130]
M01_L14:
       vcvtsd2ss xmm0,xmm0,xmm6
       vmovaps   xmm6,[rsp+30]
       add       rsp,40
       pop       rbx
       ret
M01_L15:
       vmulsd    xmm1,xmm0,xmm0
       vmulsd    xmm2,xmm1,xmm0
       vmulsd    xmm3,xmm1,xmm1
       vmulsd    xmm4,xmm1,qword ptr [7FF9CE2A9080]
       vaddsd    xmm4,xmm4,qword ptr [7FF9CE2A9088]
       vmulsd    xmm3,xmm3,xmm4
       vmulsd    xmm1,xmm1,qword ptr [7FF9CE2A9090]
       vaddsd    xmm1,xmm1,qword ptr [7FF9CE2A9098]
       vaddsd    xmm1,xmm3,xmm1
       vmulsd    xmm1,xmm2,xmm1
       vaddsd    xmm6,xmm0,xmm1
       jmp       short M01_L13
M01_L16:
       vmovss    xmm0,dword ptr [7FF9CE2A9140]
       vmovaps   xmm6,[rsp+30]
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 879

; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmulss    xmm0,xmm0,xmm1
       ret
; Total bytes of code 5

; Silk.NET.Maths.Scalar.Add[[System.Single, System.Private.CoreLib]](Single, Single)
       vaddss    xmm0,xmm0,xmm1
       ret
; Total bytes of code 5
```