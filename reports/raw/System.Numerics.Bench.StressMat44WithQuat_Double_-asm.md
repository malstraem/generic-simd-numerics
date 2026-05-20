## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Rotation()
       sub       rsp,28
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [7FF7FD4DCE00]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,5
       vmovups   ymm1,[r8+r9+10]
       vpermq    ymm2,ymm1,0D2
       vpermq    ymm3,ymm1,0C9
       vmulpd    ymm3,ymm3,ymm1
       vpermq    ymm4,ymm1,0FF
       vmulpd    ymm2,ymm4,ymm2
       vmulpd    ymm1,ymm1,ymm1
       vaddpd    ymm4,ymm3,ymm2
       vsubpd    ymm2,ymm3,ymm2
       vaddpd    ymm3,ymm4,ymm4
       vaddpd    ymm2,ymm2,ymm2
       vpermq    ymm4,ymm1,0C9
       vaddpd    ymm1,ymm4,ymm1
       vaddpd    ymm1,ymm1,ymm1
       vsubpd    ymm1,ymm0,ymm1
       vmovaps   ymm4,ymm1
       vmovaps   ymm5,ymm2
       vunpckhpd xmm4,xmm4,xmm4
       vmovsd    xmm4,xmm5,xmm4
       vinsertf128 ymm4,ymm2,xmm4,0
       vmovaps   ymm5,ymm4
       vmovaps   ymm16,ymm3
       vunpcklpd xmm5,xmm5,xmm16
       vinsertf128 ymm4,ymm4,xmm5,0
       vextractf128 xmm5,ymm1,1
       vmovaps   ymm16,ymm2
       vunpcklpd xmm5,xmm16,xmm5
       vinsertf128 ymm5,ymm2,xmm5,0
       vmovaps   ymm16,ymm3
       vextractf32x4 xmm17,ymm5,1
       vunpckhpd xmm16,xmm16,xmm16
       vmovsd    xmm16,xmm17,xmm16
       vinsertf32x4 ymm5,ymm5,xmm16,1
       vextractf128 xmm3,ymm3,1
       vmovaps   ymm16,ymm2
       vmovsd    xmm3,xmm16,xmm3
       vinsertf128 ymm2,ymm2,xmm3,0
       vextractf128 xmm3,ymm2,1
       vmovsd    xmm1,xmm3,xmm1
       vinsertf128 ymm1,ymm2,xmm1,1
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,7
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],ymm4
       vmovups   [rdx+20],ymm5
       vmovups   [rdx+40],ymm1
       vmovups   ymm1,[7FF7FD4DCE20]
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Transform()
       sub       rsp,28
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [7FF7FD4DD558]
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
       vpermq    ymm17,ymm2,0D2
       vpermq    ymm20,ymm2,0C9
       vmulpd    ymm21,ymm19,ymm2
       vfmadd213pd ymm20,ymm18,ymm21
       vfmadd213pd ymm17,ymm5,ymm20
       vpermq    ymm20,ymm3,0D2
       vpermq    ymm21,ymm3,0C9
       vmulpd    ymm19,ymm19,ymm3
       vfmadd213pd ymm21,ymm18,ymm19
       vmovaps   ymm19,ymm20
       vfmadd213pd ymm19,ymm5,ymm21
       vextractf128 xmm1,ymm1,1
       vextractf32x4 xmm20,ymm16,1
       vunpckhpd xmm1,xmm1,xmm1
       vunpcklpd xmm1,xmm20,xmm1
       vinsertf32x4 ymm1,ymm16,xmm1,1
       vextractf128 xmm2,ymm2,1
       vextractf32x4 xmm16,ymm17,1
       vunpckhpd xmm2,xmm2,xmm2
       vunpcklpd xmm2,xmm16,xmm2
       vinsertf32x4 ymm2,ymm17,xmm2,1
       vextractf128 xmm3,ymm3,1
       vextractf32x4 xmm16,ymm19,1
       vunpckhpd xmm3,xmm3,xmm3
       vunpcklpd xmm3,xmm16,xmm3
       vinsertf32x4 ymm3,ymm19,xmm3,1
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
; Total bytes of code 497
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Affine()
       sub       rsp,38
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [7FF7FD4EDAF8]
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
       vmovdqu   xmmword ptr [rsp+20],xmm2
       mov       r11,[r8+r9*8+20]
       mov       [rsp+30],r11
       mov       r8,[rcx+28]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       lea       r8,[r8+r9*8+10]
       vmovsd    xmm2,qword ptr [r8]
       vmovsd    xmm3,qword ptr [r8+8]
       vmovsd    xmm4,qword ptr [r8+10]
       vpermq    ymm5,ymm1,0D2
       vpermq    ymm16,ymm1,0C9
       vmulpd    ymm16,ymm16,ymm1
       vpermq    ymm17,ymm1,0FF
       vmulpd    ymm5,ymm17,ymm5
       vmulpd    ymm1,ymm1,ymm1
       vaddpd    ymm17,ymm16,ymm5
       vsubpd    ymm5,ymm16,ymm5
       vaddpd    ymm16,ymm17,ymm17
       vaddpd    ymm5,ymm5,ymm5
       vpermq    ymm17,ymm1,0C9
       vaddpd    ymm1,ymm17,ymm1
       vaddpd    ymm1,ymm1,ymm1
       vsubpd    ymm1,ymm0,ymm1
       vmovaps   ymm17,ymm1
       vmovaps   ymm18,ymm5
       vunpckhpd xmm17,xmm17,xmm17
       vmovsd    xmm17,xmm18,xmm17
       vinsertf32x4 ymm17,ymm5,xmm17,0
       vmovaps   ymm18,ymm17
       vmovaps   ymm19,ymm16
       vunpcklpd xmm18,xmm18,xmm19
       vinsertf32x4 ymm17,ymm17,xmm18,0
       vextractf32x4 xmm18,ymm1,1
       vmovaps   ymm19,ymm5
       vunpcklpd xmm18,xmm19,xmm18
       vinsertf32x4 ymm18,ymm5,xmm18,0
       vmovaps   ymm19,ymm16
       vextractf32x4 xmm20,ymm18,1
       vunpckhpd xmm19,xmm19,xmm19
       vmovsd    xmm19,xmm20,xmm19
       vinsertf32x4 ymm18,ymm18,xmm19,1
       vextractf32x4 xmm16,ymm16,1
       vmovaps   ymm19,ymm5
       vmovsd    xmm16,xmm19,xmm16
       vinsertf32x4 ymm5,ymm5,xmm16,0
       vextractf32x4 xmm16,ymm5,1
       vmovsd    xmm1,xmm16,xmm1
       vinsertf128 ymm1,ymm5,xmm1,1
       vmulpd    ymm5,ymm17,qword bcst [rsp+20]
       vmulpd    ymm16,ymm18,qword bcst [rsp+28]
       vmulpd    ymm1,ymm1,qword bcst [rsp+30]
       vmovaps   ymm17,ymm0
       vmovsd    xmm2,xmm17,xmm2
       vinsertf128 ymm2,ymm0,xmm2,0
       vmovaps   ymm17,ymm2
       vunpcklpd xmm3,xmm17,xmm3
       vinsertf128 ymm2,ymm2,xmm3,0
       vextractf128 xmm3,ymm2,1
       vmovsd    xmm3,xmm3,xmm4
       vinsertf128 ymm2,ymm2,xmm3,1
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,7
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],ymm5
       vmovups   [rdx+20],ymm16
       vmovups   [rdx+40],ymm1
       vmovups   [rdx+60],ymm2
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,38
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 503
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

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
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vaddpd    zmm0,zmm0,zmm2
       vmovups   [rax],zmm0
       vaddpd    zmm0,zmm1,zmm3
       vmovups   [rax+40],zmm0
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

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
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vsubpd    zmm0,zmm0,zmm2
       vmovups   [rax],zmm0
       vsubpd    zmm0,zmm1,zmm3
       vmovups   [rax+40],zmm0
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

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
       vmovups   ymm0,[r10]
       vmovups   ymm1,[r10+20]
       vmovups   ymm2,[r10+40]
       vmovups   ymm3,[r10+60]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L01
       mov       r9d,r10d
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   ymm4,[r8]
       vmovups   ymm5,[r8+20]
       vmovups   ymm16,[r8+40]
       vmovups   ymm17,[r8+60]
       vmovaps   ymm18,ymm0
       vmovaps   xmm19,xmm18
       vbroadcastsd ymm19,xmm19
       vpermilpd xmm18,xmm18,1
       vperm2f128 ymm0,ymm0,ymm0,1
       vpermilpd xmm20,xmm0,1
       vbroadcastsd ymm20,xmm20
       vbroadcastsd ymm0,xmm0
       vbroadcastsd ymm18,xmm18
       vmulpd    ymm19,ymm4,ymm19
       vfmadd231pd ymm19,ymm18,ymm5
       vfmadd231pd ymm19,ymm0,ymm16
       vfmadd231pd ymm19,ymm20,ymm17
       vmovaps   ymm0,ymm1
       vmovaps   xmm18,xmm0
       vbroadcastsd ymm18,xmm18
       vpermilpd xmm0,xmm0,1
       vperm2f128 ymm1,ymm1,ymm1,1
       vpermilpd xmm20,xmm1,1
       vbroadcastsd ymm20,xmm20
       vbroadcastsd ymm1,xmm1
       vbroadcastsd ymm0,xmm0
       vmulpd    ymm18,ymm4,ymm18
       vfmadd231pd ymm18,ymm0,ymm5
       vfmadd231pd ymm18,ymm1,ymm16
       vfmadd231pd ymm18,ymm20,ymm17
       vmovaps   ymm0,ymm2
       vmovaps   xmm1,xmm0
       vbroadcastsd ymm1,xmm1
       vpermilpd xmm0,xmm0,1
       vperm2f128 ymm2,ymm2,ymm2,1
       vpermilpd xmm20,xmm2,1
       vbroadcastsd ymm20,xmm20
       vbroadcastsd ymm2,xmm2
       vbroadcastsd ymm0,xmm0
       vmulpd    ymm1,ymm4,ymm1
       vfmadd231pd ymm1,ymm0,ymm5
       vfmadd231pd ymm1,ymm2,ymm16
       vfmadd231pd ymm1,ymm20,ymm17
       vmovaps   ymm0,ymm3
       vmovaps   xmm2,xmm0
       vbroadcastsd ymm2,xmm2
       vpermilpd xmm0,xmm0,1
       vperm2f128 ymm3,ymm3,ymm3,1
       vpermilpd xmm20,xmm3,1
       vbroadcastsd ymm20,xmm20
       vbroadcastsd ymm3,xmm3
       vbroadcastsd ymm0,xmm0
       vmulpd    ymm2,ymm4,ymm2
       vfmadd213pd ymm5,ymm0,ymm2
       vfmadd213pd ymm16,ymm3,ymm5
       vfmadd213pd ymm17,ymm20,ymm16
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],ymm19
       vmovups   [rax+20],ymm18
       vmovups   [rax+40],ymm1
       vmovups   [rax+60],ymm17
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 470
```

