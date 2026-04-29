## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Rotation()
       sub       rsp,28
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [7FFF431CAC40]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,5
       vmovups   ymm1,[r8+r9+10]
       vpermq    ymm2,ymm1,0C9
       vpermq    ymm3,ymm1,0FF
       vpermq    ymm4,ymm1,0D2
       vmulpd    ymm2,ymm1,ymm2
       vmulpd    ymm3,ymm4,ymm3
       vmulpd    ymm1,ymm1,ymm1
       vaddpd    ymm5,ymm2,ymm3
       vsubpd    ymm4,ymm2,ymm3
       vaddpd    ymm5,ymm5,ymm5
       vaddpd    ymm4,ymm4,ymm4
       vpermq    ymm2,ymm1,0C9
       vaddpd    ymm1,ymm2,ymm1
       vaddpd    ymm1,ymm1,ymm1
       vsubpd    ymm1,ymm0,ymm1
       vmovaps   ymm3,ymm1
       vmovaps   ymm2,ymm4
       vunpckhpd xmm3,xmm3,xmm3
       vmovsd    xmm2,xmm2,xmm3
       vinsertf128 ymm2,ymm4,xmm2,0
       vmovaps   ymm3,ymm2
       vmovaps   ymm16,ymm5
       vunpcklpd xmm3,xmm3,xmm16
       vinsertf128 ymm2,ymm2,xmm3,0
       vextractf128 xmm3,ymm1,1
       vmovaps   ymm16,ymm4
       vunpcklpd xmm3,xmm16,xmm3
       vinsertf128 ymm3,ymm4,xmm3,0
       vmovaps   ymm16,ymm5
       vextractf32x4 xmm17,ymm3,1
       vunpckhpd xmm16,xmm16,xmm16
       vmovsd    xmm16,xmm17,xmm16
       vinsertf32x4 ymm3,ymm3,xmm16,1
       vextractf128 xmm5,ymm5,1
       vmovaps   ymm16,ymm4
       vmovsd    xmm5,xmm16,xmm5
       vinsertf128 ymm4,ymm4,xmm5,0
       vextractf128 xmm5,ymm4,1
       vmovsd    xmm1,xmm5,xmm1
       vinsertf128 ymm4,ymm4,xmm1,1
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,7
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],ymm2
       vmovups   [rdx+20],ymm3
       vmovups   [rdx+40],ymm4
       vmovups   ymm1,[7FFF431CAC60]
       vmovups   [rdx+60],ymm1
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 322
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Transform()
       sub       rsp,28
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [7FFF431AAAB0]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   ymm1,[r8]
       vmovups   ymm2,[r8+20]
       vmovups   ymm3,[r8+40]
       vmovups   ymm4,[r8+60]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       shl       r10,5
       vmovups   ymm5,[r8+r10+10]
       vpermq    ymm16,ymm5,0C9
       vpermq    ymm17,ymm5,0FF
       vpermq    ymm18,ymm5,0D2
       vmulpd    ymm19,ymm16,ymm16
       vmulpd    ymm16,ymm16,ymm5
       vmulpd    ymm17,ymm18,ymm17
       vaddpd    ymm5,ymm16,ymm17
       vsubpd    ymm18,ymm16,ymm17
       vpermq    ymm5,ymm5,0D2
       vpermq    ymm16,ymm19,0C9
       vaddpd    ymm19,ymm16,ymm19
       vaddpd    ymm5,ymm5,ymm5
       vaddpd    ymm18,ymm18,ymm18
       vaddpd    ymm19,ymm19,ymm19
       vsubpd    ymm19,ymm0,ymm19
       vpermq    ymm16,ymm1,0D2
       vpermq    ymm17,ymm1,0C9
       vmulpd    ymm20,ymm19,ymm1
       vfmadd213pd ymm17,ymm18,ymm20
       vfmadd213pd ymm16,ymm5,ymm17
       vextractf128 xmm1,ymm1,1
       vextractf32x4 xmm17,ymm16,1
       vunpckhpd xmm1,xmm1,xmm1
       vunpcklpd xmm1,xmm17,xmm1
       vinsertf32x4 ymm1,ymm16,xmm1,1
       vpermq    ymm16,ymm2,0D2
       vpermq    ymm17,ymm2,0C9
       vmulpd    ymm20,ymm19,ymm2
       vfmadd213pd ymm17,ymm18,ymm20
       vfmadd213pd ymm16,ymm5,ymm17
       vextractf128 xmm2,ymm2,1
       vextractf32x4 xmm17,ymm16,1
       vunpckhpd xmm2,xmm2,xmm2
       vunpcklpd xmm2,xmm17,xmm2
       vinsertf32x4 ymm2,ymm16,xmm2,1
       vpermq    ymm16,ymm3,0D2
       vpermq    ymm17,ymm3,0C9
       vmulpd    ymm20,ymm19,ymm3
       vfmadd213pd ymm17,ymm18,ymm20
       vfmadd213pd ymm16,ymm5,ymm17
       vextractf128 xmm3,ymm3,1
       vextractf32x4 xmm17,ymm16,1
       vunpckhpd xmm3,xmm3,xmm3
       vunpcklpd xmm3,xmm17,xmm3
       vinsertf32x4 ymm3,ymm16,xmm3,1
       vpermq    ymm16,ymm4,0D2
       vpermq    ymm17,ymm4,0C9
       vmulpd    ymm19,ymm19,ymm4
       vfmadd213pd ymm18,ymm17,ymm19
       vfmadd213pd ymm5,ymm16,ymm18
       vextractf128 xmm4,ymm4,1
       vextractf32x4 xmm16,ymm5,1
       vunpckhpd xmm4,xmm4,xmm4
       vunpcklpd xmm4,xmm16,xmm4
       vinsertf128 ymm4,ymm5,xmm4,1
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r9+10]
       vmovups   [rdx],ymm1
       vmovups   [rdx+20],ymm2
       vmovups   [rdx+40],ymm3
       vmovups   [rdx+60],ymm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 491
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Affine()
       sub       rsp,58
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [7FFF431BAEA8]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,5
       vmovups   ymm1,[r8+r9+10]
       mov       r8,[rcx+20]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       lea       r9,[r10+r10*2]
       vmovdqu   xmm2,xmmword ptr [r8+r9*8+10]
       vmovdqu   xmmword ptr [rsp+40],xmm2
       mov       r11,[r8+r9*8+20]
       mov       [rsp+50],r11
       mov       r8,[rcx+28]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       vmovdqu   xmm2,xmmword ptr [r8+r9*8+10]
       vmovdqu   xmmword ptr [rsp+28],xmm2
       mov       r11,[r8+r9*8+20]
       mov       [rsp+38],r11
       vpermq    ymm2,ymm1,0C9
       vpermq    ymm3,ymm1,0FF
       vpermq    ymm4,ymm1,0D2
       vmulpd    ymm2,ymm2,ymm1
       vmulpd    ymm3,ymm4,ymm3
       vmulpd    ymm1,ymm1,ymm1
       vaddpd    ymm5,ymm2,ymm3
       vsubpd    ymm4,ymm2,ymm3
       vaddpd    ymm5,ymm5,ymm5
       vaddpd    ymm4,ymm4,ymm4
       vpermq    ymm2,ymm1,0C9
       vaddpd    ymm1,ymm2,ymm1
       vaddpd    ymm1,ymm1,ymm1
       vsubpd    ymm1,ymm0,ymm1
       vmovaps   ymm3,ymm1
       vmovaps   ymm2,ymm4
       vunpckhpd xmm3,xmm3,xmm3
       vmovsd    xmm2,xmm2,xmm3
       vinsertf128 ymm2,ymm4,xmm2,0
       vmovaps   ymm3,ymm2
       vmovaps   ymm16,ymm5
       vunpcklpd xmm3,xmm3,xmm16
       vinsertf128 ymm2,ymm2,xmm3,0
       vextractf128 xmm3,ymm1,1
       vmovaps   ymm16,ymm4
       vunpcklpd xmm3,xmm16,xmm3
       vinsertf128 ymm3,ymm4,xmm3,0
       vmovaps   ymm16,ymm5
       vextractf32x4 xmm17,ymm3,1
       vunpckhpd xmm16,xmm16,xmm16
       vmovsd    xmm16,xmm17,xmm16
       vinsertf32x4 ymm3,ymm3,xmm16,1
       vextractf128 xmm5,ymm5,1
       vmovaps   ymm16,ymm4
       vmovsd    xmm5,xmm16,xmm5
       vinsertf128 ymm4,ymm4,xmm5,0
       vextractf128 xmm5,ymm4,1
       vmovsd    xmm1,xmm5,xmm1
       vinsertf128 ymm4,ymm4,xmm1,1
       vmulpd    ymm1,ymm2,qword bcst [rsp+40]
       vmulpd    ymm2,ymm3,qword bcst [rsp+48]
       vmulpd    ymm3,ymm4,qword bcst [rsp+50]
       vmovaps   ymm4,ymm0
       vmovsd    xmm5,qword ptr [rsp+28]
       vmovsd    xmm4,xmm4,xmm5
       vinsertf128 ymm4,ymm0,xmm4,0
       vmovaps   ymm5,ymm4
       vmovsd    xmm16,qword ptr [rsp+30]
       vunpcklpd xmm5,xmm5,xmm16
       vinsertf128 ymm4,ymm4,xmm5,0
       vextractf128 xmm5,ymm4,1
       vmovsd    xmm16,qword ptr [rsp+38]
       vmovsd    xmm5,xmm5,xmm16
       vinsertf128 ymm4,ymm4,xmm5,1
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,7
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],ymm1
       vmovups   [rdx+20],ymm2
       vmovups   [rdx+40],ymm3
       vmovups   [rdx+60],ymm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,58
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 486
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Double, System.Private.CoreLib]].Add()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       short M00_L01
       mov       r11,rax
       shl       r11,7
       lea       r10,[r10+r11+10]
       vmovups   zmm0,[r10]
       vmovups   zmm1,[r10+40]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       short M00_L01
       mov       r9d,r10d
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   zmm2,[r8]
       vmovups   zmm3,[r8+40]
       vaddpd    zmm0,zmm0,zmm2
       vaddpd    zmm1,zmm1,zmm3
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],zmm0
       vmovups   [rax+40],zmm1
       mov       eax,r10d
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 144
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Double, System.Private.CoreLib]].Subtract()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       short M00_L01
       mov       r11,rax
       shl       r11,7
       lea       r10,[r10+r11+10]
       vmovups   zmm0,[r10]
       vmovups   zmm1,[r10+40]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       short M00_L01
       mov       r9d,r10d
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   zmm2,[r8]
       vmovups   zmm3,[r8+40]
       vsubpd    zmm0,zmm0,zmm2
       vsubpd    zmm1,zmm1,zmm3
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],zmm0
       vmovups   [rax+40],zmm1
       mov       eax,r10d
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 144
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Double, System.Private.CoreLib]].Multiply()
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
       shl       r11,7
       lea       r10,[r10+r11+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       vmovsd    xmm4,qword ptr [r10+20]
       vmovsd    xmm5,qword ptr [r10+28]
       vmovsd    xmm16,qword ptr [r10+30]
       vmovsd    xmm17,qword ptr [r10+38]
       vmovsd    xmm18,qword ptr [r10+40]
       vmovsd    xmm19,qword ptr [r10+48]
       vmovsd    xmm20,qword ptr [r10+50]
       vmovsd    xmm21,qword ptr [r10+58]
       vmovsd    xmm22,qword ptr [r10+60]
       vmovsd    xmm23,qword ptr [r10+68]
       vmovsd    xmm24,qword ptr [r10+70]
       vmovsd    xmm25,qword ptr [r10+78]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L01
       mov       r9d,r10d
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   ymm26,[r8]
       vmovups   ymm27,[r8+20]
       vmovups   ymm28,[r8+40]
       vmovups   ymm29,[r8+60]
       vbroadcastsd ymm0,xmm0
       vbroadcastsd ymm1,xmm1
       vbroadcastsd ymm2,xmm2
       vbroadcastsd ymm3,xmm3
       vmulpd    ymm1,ymm1,ymm27
       vfmadd213pd ymm0,ymm26,ymm1
       vmulpd    ymm3,ymm3,ymm29
       vfmadd213pd ymm2,ymm28,ymm3
       vaddpd    ymm0,ymm2,ymm0
       vbroadcastsd ymm1,xmm4
       vbroadcastsd ymm2,xmm5
       vbroadcastsd ymm3,xmm16
       vbroadcastsd ymm4,xmm17
       vmulpd    ymm2,ymm2,ymm27
       vfmadd213pd ymm1,ymm26,ymm2
       vmulpd    ymm4,ymm4,ymm29
       vfmadd213pd ymm3,ymm28,ymm4
       vaddpd    ymm1,ymm3,ymm1
       vbroadcastsd ymm2,xmm18
       vbroadcastsd ymm3,xmm19
       vbroadcastsd ymm4,xmm20
       vbroadcastsd ymm5,xmm21
       vmulpd    ymm3,ymm3,ymm27
       vfmadd213pd ymm2,ymm26,ymm3
       vmulpd    ymm5,ymm5,ymm29
       vfmadd213pd ymm4,ymm28,ymm5
       vaddpd    ymm2,ymm4,ymm2
       vbroadcastsd ymm3,xmm22
       vbroadcastsd ymm4,xmm23
       vbroadcastsd ymm5,xmm24
       vbroadcastsd ymm16,xmm25
       vmulpd    ymm4,ymm4,ymm27
       vfmadd213pd ymm26,ymm3,ymm4
       vmulpd    ymm3,ymm16,ymm29
       vfmadd213pd ymm28,ymm5,ymm3
       vaddpd    ymm3,ymm28,ymm26
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],ymm0
       vmovups   [rax+20],ymm1
       vmovups   [rax+40],ymm2
       vmovups   [rax+60],ymm3
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 460
```

