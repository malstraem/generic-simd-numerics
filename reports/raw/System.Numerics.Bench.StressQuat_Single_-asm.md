## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Multiply()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       vmovups   xmm0,[7FFF431B9A20]
       vmovups   xmm1,[7FFF431B9A30]
       vmovddup  xmm2,qword ptr [7FFF431B9A40]
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
       vmovaps   xmm5,xmm3
       vbroadcastss xmm5,xmm5
       vmovshdup xmm16,xmm3
       vbroadcastss xmm16,xmm16
       vunpckhps xmm17,xmm3,xmm3
       vbroadcastss xmm17,xmm17
       vshufps   xmm3,xmm3,xmm3,0FF
       vbroadcastss xmm3,xmm3
       vpshufd   xmm18,xmm4,0B1
       vmulps    xmm17,xmm18,xmm17
       vpshufd   xmm18,xmm4,4E
       vmulps    xmm16,xmm18,xmm16
       vpshufd   xmm18,xmm4,1B
       vmulps    xmm5,xmm18,xmm5
       vmulps    xmm3,xmm4,xmm3
       vfmadd213ps xmm5,xmm2,xmm3
       vfmadd213ps xmm16,xmm1,xmm5
       vfmadd213ps xmm17,xmm0,xmm16
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+rbx+10],xmm17
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr M00_L00
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 243
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Divide()
       push      rbx
       sub       rsp,40
       vmovaps   [rsp+30],xmm6
       vmovaps   [rsp+20],xmm7
       mov       rax,[rcx+10]
       vmovups   xmm0,[7FFF431CA6E0]
       vbroadcastss xmm1,dword ptr [7FFF431CA6F0]
       vmovups   xmm2,[7FFF431CA700]
       vmovups   xmm3,[7FFF431CA710]
       vmovddup  xmm4,qword ptr [7FFF431CA720]
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
       vmovups   xmm6,[r10+r11+10]
       vdpps     xmm7,xmm6,xmm6,0FF
       vmulps    xmm16,xmm0,xmm6
       vdivps    xmm16,xmm16,xmm7
       vcmpnleps xmm6,xmm7,xmm1
       vandps    xmm16,xmm6,xmm16
       vmovaps   xmm17,xmm5
       vbroadcastss xmm17,xmm17
       vmovshdup xmm18,xmm5
       vbroadcastss xmm18,xmm18
       vunpckhps xmm19,xmm5,xmm5
       vbroadcastss xmm19,xmm19
       vshufps   xmm5,xmm5,xmm5,0FF
       vbroadcastss xmm5,xmm5
       vpshufd   xmm20,xmm16,0B1
       vmulps    xmm19,xmm20,xmm19
       vpshufd   xmm20,xmm16,4E
       vmulps    xmm18,xmm20,xmm18
       vpshufd   xmm20,xmm16,1B
       vmulps    xmm17,xmm20,xmm17
       vmulps    xmm5,xmm16,xmm5
       vfmadd213ps xmm17,xmm4,xmm5
       vfmadd213ps xmm18,xmm3,xmm17
       vfmadd213ps xmm19,xmm2,xmm18
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+rbx+10],xmm19
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+30]
       vmovaps   xmm7,[rsp+20]
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 319
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Conjugate()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovups   xmm0,[7FFF431C9A90]
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Inverse()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovups   xmm0,[7FFF431BA180]
       vbroadcastss xmm1,dword ptr [7FFF431BA190]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,4
       lea       r10,[r10+r9+10]
       vmovups   xmm2,[r10]
       vmovaps   xmm3,xmm2
       vdpps     xmm3,xmm3,xmm3,0FF
       vmulps    xmm2,xmm0,xmm2
       vdivps    xmm2,xmm2,xmm3
       vcmpnleps xmm3,xmm3,xmm1
       vandps    xmm2,xmm3,xmm2
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+r9+10],xmm2
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 118
```

