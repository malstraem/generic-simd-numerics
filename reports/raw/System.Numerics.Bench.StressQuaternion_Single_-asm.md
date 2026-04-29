## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

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
       vmulss    xmm18,xmm1,xmm16
       vmulss    xmm19,xmm2,xmm5
       vsubss    xmm18,xmm18,xmm19
       vmulss    xmm19,xmm2,xmm4
       vmulss    xmm20,xmm0,xmm16
       vsubss    xmm19,xmm19,xmm20
       vmulss    xmm20,xmm0,xmm5
       vmulss    xmm21,xmm1,xmm4
       vsubss    xmm20,xmm20,xmm21
       vmulss    xmm21,xmm0,xmm4
       vmulss    xmm22,xmm1,xmm5
       vaddss    xmm21,xmm22,xmm21
       vmulss    xmm22,xmm2,xmm16
       vaddss    xmm21,xmm22,xmm21
       vmulss    xmm0,xmm0,xmm17
       vmulss    xmm4,xmm4,xmm3
       vaddss    xmm0,xmm4,xmm0
       vaddss    xmm0,xmm0,xmm18
       vmulss    xmm1,xmm1,xmm17
       vmulss    xmm4,xmm5,xmm3
       vaddss    xmm1,xmm4,xmm1
       vaddss    xmm1,xmm1,xmm19
       vmulss    xmm2,xmm2,xmm17
       vmulss    xmm4,xmm16,xmm3
       vaddss    xmm2,xmm4,xmm2
       vaddss    xmm2,xmm2,xmm20
       vmulss    xmm3,xmm3,xmm17
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 327
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Single, System.Private.CoreLib]].Divide()
       sub       rsp,28
       vmovss    xmm0,dword ptr [7FFF431CA900]
       vmovss    xmm1,dword ptr [7FFF431CA904]
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
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vmovss    xmm4,dword ptr [r10+8]
       vmovss    xmm5,dword ptr [r10+0C]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L01
       mov       r9d,r10d
       shl       r9,4
       lea       r8,[r8+r9+10]
       vmovss    xmm16,dword ptr [r8]
       vmovss    xmm17,dword ptr [r8+4]
       vmovss    xmm18,dword ptr [r8+8]
       vmovss    xmm19,dword ptr [r8+0C]
       vmulss    xmm20,xmm16,xmm16
       vmulss    xmm21,xmm17,xmm17
       vaddss    xmm20,xmm21,xmm20
       vmulss    xmm21,xmm18,xmm18
       vaddss    xmm20,xmm21,xmm20
       vmulss    xmm21,xmm19,xmm19
       vaddss    xmm20,xmm21,xmm20
       vdivss    xmm20,xmm0,xmm20
       vmulss    xmm16,xmm16,xmm20
       vmulss    xmm16,xmm16,xmm1
       vmulss    xmm17,xmm17,xmm20
       vmulss    xmm17,xmm17,xmm1
       vmulss    xmm18,xmm18,xmm20
       vmulss    xmm18,xmm18,xmm1
       vmulss    xmm19,xmm19,xmm20
       vmulss    xmm20,xmm3,xmm18
       vmulss    xmm21,xmm4,xmm17
       vsubss    xmm20,xmm20,xmm21
       vmulss    xmm21,xmm4,xmm16
       vmulss    xmm22,xmm2,xmm18
       vsubss    xmm21,xmm21,xmm22
       vmulss    xmm22,xmm2,xmm17
       vmulss    xmm23,xmm3,xmm16
       vsubss    xmm22,xmm22,xmm23
       vmulss    xmm23,xmm2,xmm16
       vmulss    xmm24,xmm3,xmm17
       vaddss    xmm23,xmm24,xmm23
       vmulss    xmm24,xmm4,xmm18
       vaddss    xmm23,xmm24,xmm23
       vmulss    xmm2,xmm2,xmm19
       vmulss    xmm16,xmm16,xmm5
       vaddss    xmm2,xmm16,xmm2
       vaddss    xmm2,xmm2,xmm20
       vmulss    xmm3,xmm3,xmm19
       vmulss    xmm16,xmm17,xmm5
       vaddss    xmm3,xmm16,xmm3
       vaddss    xmm3,xmm3,xmm21
       vmulss    xmm4,xmm4,xmm19
       vmulss    xmm16,xmm18,xmm5
       vaddss    xmm4,xmm16,xmm4
       vaddss    xmm4,xmm4,xmm22
       vmulss    xmm5,xmm5,xmm19
       vsubss    xmm5,xmm5,xmm23
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovss    dword ptr [rax],xmm2
       vmovss    dword ptr [rax+4],xmm3
       vmovss    dword ptr [rax+8],xmm4
       vmovss    dword ptr [rax+0C],xmm5
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 445
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Single, System.Private.CoreLib]].Conjugate()
       sub       rsp,28
       vmovss    xmm0,dword ptr [7FFF431A9B60]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short M00_L01
       mov       r10,rax
       shl       r10,4
       lea       r8,[r8+r10+10]
       vmovss    xmm1,dword ptr [r8]
       vmovss    xmm2,dword ptr [r8+4]
       vmovss    xmm3,dword ptr [r8+8]
       vmovss    xmm4,dword ptr [r8+0C]
       vmulss    xmm1,xmm1,xmm0
       vmulss    xmm2,xmm2,xmm0
       vmulss    xmm3,xmm3,xmm0
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r10+10]
       vmovss    dword ptr [rdx],xmm1
       vmovss    dword ptr [rdx+4],xmm2
       vmovss    dword ptr [rdx+8],xmm3
       vmovss    dword ptr [rdx+0C],xmm4
       inc       eax
       cmp       eax,186A0
       jl        short M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 124
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Single, System.Private.CoreLib]].Inverse()
       sub       rsp,28
       vmovss    xmm0,dword ptr [7FFF431C9EF8]
       vmovss    xmm1,dword ptr [7FFF431C9EFC]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10,rax
       shl       r10,4
       lea       r8,[r8+r10+10]
       vmovss    xmm2,dword ptr [r8]
       vmovss    xmm3,dword ptr [r8+4]
       vmovss    xmm4,dword ptr [r8+8]
       vmovss    xmm5,dword ptr [r8+0C]
       vmulss    xmm16,xmm2,xmm2
       vmulss    xmm17,xmm3,xmm3
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm17,xmm4,xmm4
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm17,xmm5,xmm5
       vaddss    xmm16,xmm17,xmm16
       vdivss    xmm16,xmm0,xmm16
       vmulss    xmm2,xmm2,xmm16
       vmulss    xmm2,xmm2,xmm1
       vmulss    xmm3,xmm3,xmm16
       vmulss    xmm3,xmm3,xmm1
       vmulss    xmm4,xmm4,xmm16
       vmulss    xmm4,xmm4,xmm1
       vmulss    xmm5,xmm5,xmm16
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r10+10]
       vmovss    dword ptr [rdx],xmm2
       vmovss    dword ptr [rdx+4],xmm3
       vmovss    dword ptr [rdx+8],xmm4
       vmovss    dword ptr [rdx+0C],xmm5
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 212
```

