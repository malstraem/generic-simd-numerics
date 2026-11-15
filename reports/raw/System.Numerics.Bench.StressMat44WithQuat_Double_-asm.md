## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Rotation()
       sub       rsp,28
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [5448]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr 000000000000543C
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
       vmovaps   xmm4,xmm1
       vmovaps   xmm5,xmm2
       vunpckhpd xmm4,xmm4,xmm4
       vmovsd    xmm4,xmm5,xmm4
       vinsertf128 ymm4,ymm2,xmm4,0
       vmovaps   xmm5,xmm4
       vmovaps   ymm16,ymm3
       vunpcklpd xmm5,xmm5,xmm16
       vinsertf128 ymm4,ymm4,xmm5,0
       vextractf128 xmm5,ymm1,1
       vmovaps   xmm16,xmm2
       vunpcklpd xmm5,xmm16,xmm5
       vinsertf128 ymm5,ymm2,xmm5,0
       vmovaps   xmm16,xmm3
       vextractf32x4 xmm17,ymm5,1
       vunpckhpd xmm16,xmm16,xmm16
       vmovsd    xmm16,xmm17,xmm16
       vinsertf32x4 ymm5,ymm5,xmm16,1
       vextractf128 xmm3,ymm3,1
       vmovaps   xmm16,xmm2
       vmovsd    xmm3,xmm16,xmm3
       vinsertf128 ymm2,ymm2,xmm3,0
       vextractf128 xmm3,ymm2,1
       vmovsd    xmm1,xmm3,xmm1
       vinsertf128 ymm1,ymm2,xmm1,1
       cmp       eax,[rdx+8]
       jae       short 000000000000543C
       shl       r10,7
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],ymm4
       vmovups   [rdx+20],ymm5
       vmovups   [rdx+40],ymm1
       vmovups   ymm1,[5460]
       vmovups   [rdx+60],ymm1
       inc       eax
       cmp       eax,186A0
       jl        near ptr 000000000000530F
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 322
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Transform()
       sub       rsp,28
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [6350]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000006345
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
       jae       near ptr 0000000000006345
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
       vfmadd231pd ymm19,ymm18,ymm21
       vfmadd231pd ymm19,ymm5,ymm20
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
       vfmadd231pd ymm19,ymm18,ymm17
       vfmadd213pd ymm5,ymm16,ymm19
       vextractf128 xmm4,ymm4,1
       vextractf32x4 xmm16,ymm5,1
       vunpckhpd xmm4,xmm4,xmm4
       vunpcklpd xmm4,xmm16,xmm4
       vinsertf128 ymm4,ymm5,xmm4,1
       cmp       eax,[rdx+8]
       jae       short 0000000000006345
       lea       rdx,[rdx+r9+10]
       vmovups   [rdx],ymm1
       vmovups   [rdx+20],ymm2
       vmovups   [rdx+40],ymm3
       vmovups   [rdx+60],ymm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr 000000000000616F
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 491
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Affine()
       sub       rsp,28
       xor       eax,eax
       vbroadcastsd ymm0,qword ptr [6420]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000006417
       mov       r10d,eax
       mov       r9,r10
       shl       r9,5
       vmovups   ymm1,[r8+r9+10]
       mov       r8,[rcx+20]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000006417
       lea       r9,[r10+r10*2]
       lea       r8,[r8+r9*8+10]
       vmovsd    xmm2,qword ptr [r8]
       vmovsd    xmm3,qword ptr [r8+8]
       vmovsd    xmm4,qword ptr [r8+10]
       mov       r8,[rcx+28]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000006417
       lea       r8,[r8+r9*8+10]
       vmovsd    xmm5,qword ptr [r8]
       vmovsd    xmm16,qword ptr [r8+8]
       vmovsd    xmm17,qword ptr [r8+10]
       vpermq    ymm18,ymm1,0D2
       vpermq    ymm19,ymm1,0C9
       vmulpd    ymm19,ymm19,ymm1
       vpermq    ymm20,ymm1,0FF
       vmulpd    ymm18,ymm20,ymm18
       vmulpd    ymm1,ymm1,ymm1
       vaddpd    ymm20,ymm19,ymm18
       vsubpd    ymm18,ymm19,ymm18
       vaddpd    ymm19,ymm20,ymm20
       vaddpd    ymm18,ymm18,ymm18
       vpermq    ymm20,ymm1,0C9
       vaddpd    ymm1,ymm20,ymm1
       vaddpd    ymm1,ymm1,ymm1
       vsubpd    ymm1,ymm0,ymm1
       vmovaps   xmm20,xmm1
       vmovaps   xmm21,xmm18
       vunpckhpd xmm20,xmm20,xmm20
       vmovsd    xmm20,xmm21,xmm20
       vinsertf32x4 ymm20,ymm18,xmm20,0
       vmovaps   xmm21,xmm20
       vmovaps   ymm22,ymm19
       vunpcklpd xmm21,xmm21,xmm22
       vinsertf32x4 ymm20,ymm20,xmm21,0
       vextractf32x4 xmm21,ymm1,1
       vmovaps   xmm22,xmm18
       vunpcklpd xmm21,xmm22,xmm21
       vinsertf32x4 ymm21,ymm18,xmm21,0
       vmovaps   xmm22,xmm19
       vextractf32x4 xmm23,ymm21,1
       vunpckhpd xmm22,xmm22,xmm22
       vmovsd    xmm22,xmm23,xmm22
       vinsertf32x4 ymm21,ymm21,xmm22,1
       vextractf32x4 xmm19,ymm19,1
       vmovaps   xmm22,xmm18
       vmovsd    xmm19,xmm22,xmm19
       vinsertf32x4 ymm18,ymm18,xmm19,0
       vextractf32x4 xmm19,ymm18,1
       vmovsd    xmm1,xmm19,xmm1
       vinsertf32x4 ymm1,ymm18,xmm1,1
       vbroadcastsd ymm2,xmm2
       vmulpd    ymm2,ymm20,ymm2
       vbroadcastsd ymm3,xmm3
       vmulpd    ymm3,ymm21,ymm3
       vbroadcastsd ymm4,xmm4
       vmulpd    ymm1,ymm4,ymm1
       vmovaps   xmm4,xmm0
       vmovsd    xmm4,xmm4,xmm5
       vinsertf128 ymm4,ymm0,xmm4,0
       vmovaps   xmm5,xmm4
       vunpcklpd xmm5,xmm5,xmm16
       vinsertf128 ymm4,ymm4,xmm5,0
       vextractf128 xmm5,ymm4,1
       vmovsd    xmm5,xmm5,xmm17
       vinsertf128 ymm4,ymm4,xmm5,1
       cmp       eax,[rdx+8]
       jae       short 0000000000006417
       shl       r10,7
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],ymm2
       vmovups   [rdx+20],ymm3
       vmovups   [rdx+40],ymm1
       vmovups   [rdx+60],ymm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr 000000000000622F
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 509
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Double, System.Private.CoreLib]].Add()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       short 0000000000003E2A
       mov       r11,rax
       shl       r11,7
       lea       r10,[r10+r11+10]
       vmovups   zmm0,[r10]
       vmovups   zmm1,[r10+40]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       short 0000000000003E2A
       mov       r9d,r10d
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   zmm2,[r8]
       vmovups   zmm3,[r8+40]
       cmp       eax,[rdx+8]
       jae       short 0000000000003E2A
       lea       rax,[rdx+r11+10]
       vaddpd    zmm0,zmm0,zmm2
       vmovups   [rax],zmm0
       vaddpd    zmm0,zmm1,zmm3
       vmovups   [rax+40],zmm0
       mov       eax,r10d
       cmp       eax,1869F
       jl        short 0000000000003DA6
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 144
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Double, System.Private.CoreLib]].Subtract()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       short 0000000000003BEA
       mov       r11,rax
       shl       r11,7
       lea       r10,[r10+r11+10]
       vmovups   zmm0,[r10]
       vmovups   zmm1,[r10+40]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       short 0000000000003BEA
       mov       r9d,r10d
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   zmm2,[r8]
       vmovups   zmm3,[r8+40]
       cmp       eax,[rdx+8]
       jae       short 0000000000003BEA
       lea       rax,[rdx+r11+10]
       vsubpd    zmm0,zmm0,zmm2
       vmovups   [rax],zmm0
       vsubpd    zmm0,zmm1,zmm3
       vmovups   [rax+40],zmm0
       mov       eax,r10d
       cmp       eax,1869F
       jl        short 0000000000003B66
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 144
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Double, System.Private.CoreLib]].Multiply()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr 0000000000004704
       mov       r11,rax
       shl       r11,7
       lea       r10,[r10+r11+10]
       vmovups   ymm0,[r10]
       vmovups   ymm1,[r10+20]
       vmovups   ymm2,[r10+40]
       vmovups   ymm3,[r10+60]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr 0000000000004704
       mov       r9d,r10d
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   ymm4,[r8]
       vmovups   ymm5,[r8+20]
       vmovups   ymm16,[r8+40]
       vmovups   ymm17,[r8+60]
       vmovaps   xmm18,xmm0
       vmovaps   xmm19,xmm18
       vbroadcastsd ymm19,xmm19
       vpermilpd xmm18,xmm18,1
       vperm2f128 ymm0,ymm0,ymm0,1
       vpermilpd xmm20,xmm0,1
       vbroadcastsd ymm20,xmm20
       vbroadcastsd ymm0,xmm0
       vbroadcastsd ymm18,xmm18
       vmulpd    ymm19,ymm19,ymm4
       vfmadd213pd ymm18,ymm5,ymm19
       vfmadd213pd ymm0,ymm16,ymm18
       vfmadd231pd ymm0,ymm20,ymm17
       vmovaps   xmm18,xmm1
       vmovaps   xmm19,xmm18
       vbroadcastsd ymm19,xmm19
       vpermilpd xmm18,xmm18,1
       vperm2f128 ymm1,ymm1,ymm1,1
       vpermilpd xmm20,xmm1,1
       vbroadcastsd ymm20,xmm20
       vbroadcastsd ymm1,xmm1
       vbroadcastsd ymm18,xmm18
       vmulpd    ymm19,ymm19,ymm4
       vfmadd213pd ymm18,ymm5,ymm19
       vfmadd213pd ymm1,ymm16,ymm18
       vfmadd231pd ymm1,ymm20,ymm17
       vmovaps   xmm18,xmm2
       vmovaps   xmm19,xmm18
       vbroadcastsd ymm19,xmm19
       vpermilpd xmm18,xmm18,1
       vperm2f128 ymm2,ymm2,ymm2,1
       vpermilpd xmm20,xmm2,1
       vbroadcastsd ymm20,xmm20
       vbroadcastsd ymm2,xmm2
       vbroadcastsd ymm18,xmm18
       vmulpd    ymm19,ymm19,ymm4
       vfmadd213pd ymm18,ymm5,ymm19
       vfmadd213pd ymm2,ymm16,ymm18
       vfmadd231pd ymm2,ymm20,ymm17
       vmovaps   xmm18,xmm3
       vmovaps   xmm19,xmm18
       vbroadcastsd ymm19,xmm19
       vpermilpd xmm18,xmm18,1
       vperm2f128 ymm3,ymm3,ymm3,1
       vpermilpd xmm20,xmm3,1
       vbroadcastsd ymm20,xmm20
       vbroadcastsd ymm3,xmm3
       vbroadcastsd ymm18,xmm18
       vmulpd    ymm4,ymm19,ymm4
       vfmadd213pd ymm5,ymm18,ymm4
       vfmadd213pd ymm3,ymm16,ymm5
       vfmadd213pd ymm17,ymm20,ymm3
       cmp       eax,[rdx+8]
       jae       short 0000000000004704
       lea       rax,[rdx+r11+10]
       vmovups   [rax],ymm0
       vmovups   [rax+20],ymm1
       vmovups   [rax+40],ymm2
       vmovups   [rax+60],ymm17
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000004526
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 490
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

