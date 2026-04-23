## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Rotation()
       sub       rsp,28
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [7FF8F42DBF20]
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
       vmovups   ymm1,[7FF8F42DBF40]
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
       sub       rsp,98
       vmovaps   [rsp+80],xmm6
       vmovaps   [rsp+70],xmm7
       vmovaps   [rsp+60],xmm8
       vmovaps   [rsp+50],xmm9
       vmovaps   [rsp+40],xmm10
       vmovaps   [rsp+30],xmm11
       vmovaps   [rsp+20],xmm12
       vmovsd    xmm0,qword ptr [7FF8F430C470]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10,rax
       shl       r10,7
       lea       r8,[r8+r10+10]
       vmovsd    xmm1,qword ptr [r8]
       vmovsd    xmm2,qword ptr [r8+8]
       vmovsd    xmm3,qword ptr [r8+10]
       vmovsd    xmm4,qword ptr [r8+18]
       vmovsd    xmm5,qword ptr [r8+20]
       vmovsd    xmm16,qword ptr [r8+28]
       vmovsd    xmm17,qword ptr [r8+30]
       vmovsd    xmm18,qword ptr [r8+38]
       vmovsd    xmm19,qword ptr [r8+40]
       vmovsd    xmm20,qword ptr [r8+48]
       vmovsd    xmm21,qword ptr [r8+50]
       vmovsd    xmm22,qword ptr [r8+58]
       vmovsd    xmm23,qword ptr [r8+60]
       vmovsd    xmm24,qword ptr [r8+68]
       vmovsd    xmm25,qword ptr [r8+70]
       vmovsd    xmm26,qword ptr [r8+78]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r9,rax
       shl       r9,5
       lea       r8,[r8+r9+10]
       vmovsd    xmm27,qword ptr [r8]
       vmovsd    xmm28,qword ptr [r8+8]
       vmovsd    xmm29,qword ptr [r8+10]
       vmovsd    xmm30,qword ptr [r8+18]
       vaddsd    xmm31,xmm27,xmm27
       vaddsd    xmm6,xmm28,xmm28
       vaddsd    xmm7,xmm29,xmm29
       vmulsd    xmm8,xmm27,xmm6
       vmulsd    xmm9,xmm31,xmm30
       vmulsd    xmm10,xmm29,xmm31
       vmulsd    xmm11,xmm6,xmm30
       vmulsd    xmm12,xmm28,xmm7
       vmulsd    xmm30,xmm7,xmm30
       vmulsd    xmm31,xmm27,xmm31
       vmulsd    xmm6,xmm28,xmm6
       vmulsd    xmm7,xmm29,xmm7
       vsubsd    xmm27,xmm0,xmm6
       vsubsd    xmm27,xmm27,xmm7
       vaddsd    xmm28,xmm8,xmm30
       vsubsd    xmm29,xmm10,xmm11
       vsubsd    xmm30,xmm8,xmm30
       vsubsd    xmm31,xmm0,xmm31
       vsubsd    xmm7,xmm31,xmm7
       vaddsd    xmm8,xmm12,xmm9
       vaddsd    xmm10,xmm10,xmm11
       vsubsd    xmm9,xmm12,xmm9
       vsubsd    xmm31,xmm31,xmm6
       vmulsd    xmm6,xmm1,xmm27
       vmulsd    xmm11,xmm2,xmm30
       vaddsd    xmm6,xmm6,xmm11
       vmulsd    xmm11,xmm3,xmm10
       vaddsd    xmm6,xmm6,xmm11
       vmulsd    xmm11,xmm1,xmm28
       vmulsd    xmm12,xmm2,xmm7
       vaddsd    xmm11,xmm11,xmm12
       vmulsd    xmm12,xmm3,xmm9
       vaddsd    xmm11,xmm11,xmm12
       vmulsd    xmm1,xmm1,xmm29
       vmulsd    xmm2,xmm2,xmm8
       vaddsd    xmm1,xmm1,xmm2
       vmulsd    xmm2,xmm3,xmm31
       vaddsd    xmm1,xmm1,xmm2
       vmulsd    xmm2,xmm5,xmm27
       vmulsd    xmm3,xmm16,xmm30
       vaddsd    xmm2,xmm2,xmm3
       vmulsd    xmm3,xmm17,xmm10
       vaddsd    xmm2,xmm2,xmm3
       vmulsd    xmm3,xmm5,xmm28
       vmulsd    xmm12,xmm16,xmm7
       vaddsd    xmm3,xmm3,xmm12
       vmulsd    xmm12,xmm17,xmm9
       vaddsd    xmm3,xmm3,xmm12
       vmulsd    xmm5,xmm5,xmm29
       vmulsd    xmm16,xmm16,xmm8
       vaddsd    xmm5,xmm5,xmm16
       vmulsd    xmm16,xmm17,xmm31
       vaddsd    xmm5,xmm5,xmm16
       vmulsd    xmm16,xmm19,xmm27
       vmulsd    xmm17,xmm20,xmm30
       vaddsd    xmm16,xmm16,xmm17
       vmulsd    xmm17,xmm21,xmm10
       vaddsd    xmm16,xmm16,xmm17
       vmulsd    xmm17,xmm19,xmm28
       vmulsd    xmm12,xmm20,xmm7
       vaddsd    xmm17,xmm17,xmm12
       vmulsd    xmm12,xmm21,xmm9
       vaddsd    xmm17,xmm17,xmm12
       vmulsd    xmm19,xmm19,xmm29
       vmulsd    xmm20,xmm20,xmm8
       vaddsd    xmm19,xmm19,xmm20
       vmulsd    xmm20,xmm21,xmm31
       vaddsd    xmm19,xmm19,xmm20
       vmulsd    xmm20,xmm23,xmm27
       vmulsd    xmm21,xmm24,xmm30
       vaddsd    xmm20,xmm20,xmm21
       vmulsd    xmm21,xmm25,xmm10
       vaddsd    xmm20,xmm20,xmm21
       vmulsd    xmm21,xmm23,xmm28
       vmulsd    xmm27,xmm24,xmm7
       vaddsd    xmm21,xmm21,xmm27
       vmulsd    xmm27,xmm25,xmm9
       vaddsd    xmm21,xmm21,xmm27
       vmulsd    xmm23,xmm23,xmm29
       vmulsd    xmm24,xmm24,xmm8
       vaddsd    xmm23,xmm23,xmm24
       vmulsd    xmm24,xmm25,xmm31
       vaddsd    xmm23,xmm24,xmm23
       cmp       eax,[rdx+8]
       jae       near ptr M00_L01
       lea       rdx,[rdx+r10+10]
       vmovsd    qword ptr [rdx],xmm6
       vmovsd    qword ptr [rdx+8],xmm11
       vmovsd    qword ptr [rdx+10],xmm1
       vmovsd    qword ptr [rdx+18],xmm4
       vmovsd    qword ptr [rdx+20],xmm2
       vmovsd    qword ptr [rdx+28],xmm3
       vmovsd    qword ptr [rdx+30],xmm5
       vmovsd    qword ptr [rdx+38],xmm18
       vmovsd    qword ptr [rdx+40],xmm16
       vmovsd    qword ptr [rdx+48],xmm17
       vmovsd    qword ptr [rdx+50],xmm19
       vmovsd    qword ptr [rdx+58],xmm22
       vmovsd    qword ptr [rdx+60],xmm20
       vmovsd    qword ptr [rdx+68],xmm21
       vmovsd    qword ptr [rdx+70],xmm23
       vmovsd    qword ptr [rdx+78],xmm26
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+80]
       vmovaps   xmm7,[rsp+70]
       vmovaps   xmm8,[rsp+60]
       vmovaps   xmm9,[rsp+50]
       vmovaps   xmm10,[rsp+40]
       vmovaps   xmm11,[rsp+30]
       vmovaps   xmm12,[rsp+20]
       add       rsp,98
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 908
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Affine()
       sub       rsp,58
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [7FF8F42DC188]
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
; System.Numerics.Bench.StressMat44`1[[System.Double, System.Private.CoreLib]].Substract()
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

