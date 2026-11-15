## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Rotation()
       sub       rsp,28
       xor       eax,eax
       vbroadcastss xmm0,dword ptr [4B70]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000004B68
       mov       r10d,eax
       mov       r9,r10
       shl       r9,4
       vmovups   xmm1,[r8+r9+10]
       vpermilps xmm2,xmm1,0D2
       vpermilps xmm3,xmm1,0C9
       vmulps    xmm3,xmm3,xmm1
       vpermilps xmm4,xmm1,0FF
       vmulps    xmm2,xmm4,xmm2
       vmulps    xmm1,xmm1,xmm1
       vaddps    xmm4,xmm3,xmm2
       vsubps    xmm2,xmm3,xmm2
       vaddps    xmm3,xmm4,xmm4
       vaddps    xmm2,xmm2,xmm2
       vpermilps xmm4,xmm1,0C9
       vaddps    xmm1,xmm4,xmm1
       vaddps    xmm1,xmm1,xmm1
       vsubps    xmm1,xmm0,xmm1
       vmovshdup xmm4,xmm1
       vinsertps xmm4,xmm2,xmm4,0
       vmovaps   xmm5,xmm3
       vinsertps xmm4,xmm4,xmm5,10
       vunpckhps xmm5,xmm1,xmm1
       vinsertps xmm5,xmm2,xmm5,10
       vmovshdup xmm16,xmm3
       vinsertps xmm5,xmm5,xmm16,20
       vunpckhps xmm3,xmm3,xmm3
       vinsertps xmm2,xmm2,xmm3,0
       vinsertps xmm1,xmm2,xmm1,20
       cmp       eax,[rdx+8]
       jae       short 0000000000004B68
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm4
       vmovups   [rdx+10],xmm5
       vmovups   [rdx+20],xmm1
       vmovups   xmm1,[4B80]
       vmovups   [rdx+30],xmm1
       inc       eax
       cmp       eax,186A0
       jl        near ptr 0000000000004A8F
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 238
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Transform()
       sub       rsp,28
       xor       eax,eax
       vbroadcastss xmm0,dword ptr [5A20]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000005A1A
       mov       r10d,eax
       mov       r9,r10
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   xmm1,[r8]
       vmovups   xmm2,[r8+10]
       vmovups   xmm3,[r8+20]
       vmovups   xmm4,[r8+30]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000005A1A
       shl       r10,4
       vmovups   xmm5,[r8+r10+10]
       vpermilps xmm16,xmm5,0C9
       vpermilps xmm17,xmm5,0FF
       vpermilps xmm18,xmm5,0D2
       vmulps    xmm19,xmm16,xmm16
       vmulps    xmm16,xmm16,xmm5
       vmulps    xmm17,xmm18,xmm17
       vaddps    xmm5,xmm16,xmm17
       vsubps    xmm18,xmm16,xmm17
       vpermilps xmm5,xmm5,0D2
       vpermilps xmm16,xmm19,0C9
       vaddps    xmm19,xmm16,xmm19
       vaddps    xmm5,xmm5,xmm5
       vaddps    xmm18,xmm18,xmm18
       vaddps    xmm19,xmm19,xmm19
       vsubps    xmm19,xmm0,xmm19
       vpermilps xmm16,xmm1,0D2
       vpermilps xmm17,xmm1,0C9
       vmulps    xmm20,xmm19,xmm1
       vfmadd213ps xmm17,xmm18,xmm20
       vfmadd213ps xmm16,xmm5,xmm17
       vpermilps xmm17,xmm2,0D2
       vpermilps xmm20,xmm2,0C9
       vmulps    xmm21,xmm19,xmm2
       vfmadd213ps xmm20,xmm18,xmm21
       vfmadd213ps xmm17,xmm5,xmm20
       vpermilps xmm20,xmm3,0D2
       vpermilps xmm21,xmm3,0C9
       vmulps    xmm19,xmm19,xmm3
       vfmadd231ps xmm19,xmm18,xmm21
       vfmadd231ps xmm19,xmm5,xmm20
       vshufps   xmm1,xmm1,xmm1,0FF
       vinsertps xmm1,xmm16,xmm1,30
       vshufps   xmm2,xmm2,xmm2,0FF
       vinsertps xmm2,xmm17,xmm2,30
       vshufps   xmm3,xmm3,xmm3,0FF
       vinsertps xmm3,xmm19,xmm3,30
       vpermilps xmm16,xmm4,0D2
       vpermilps xmm17,xmm4,0C9
       vmulps    xmm19,xmm19,xmm4
       vfmadd231ps xmm19,xmm18,xmm17
       vfmadd213ps xmm5,xmm16,xmm19
       vshufps   xmm4,xmm4,xmm4,0FF
       vinsertps xmm4,xmm5,xmm4,30
       cmp       eax,[rdx+8]
       jae       short 0000000000005A1A
       lea       rdx,[rdx+r9+10]
       vmovups   [rdx],xmm1
       vmovups   [rdx+10],xmm2
       vmovups   [rdx+20],xmm3
       vmovups   [rdx+30],xmm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr 000000000000588F
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 416
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Affine()
       sub       rsp,28
       xor       eax,eax
       vbroadcastss xmm0,dword ptr [57E8]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000057E0
       mov       r10d,eax
       mov       r9,r10
       shl       r9,4
       vmovups   xmm1,[r8+r9+10]
       mov       r8,[rcx+20]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000057E0
       lea       r9,[r10+r10*2]
       lea       r8,[r8+r9*4+10]
       vmovss    xmm2,dword ptr [r8]
       vmovss    xmm3,dword ptr [r8+4]
       vmovss    xmm4,dword ptr [r8+8]
       mov       r8,[rcx+28]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000057E0
       lea       r8,[r8+r9*4+10]
       vmovss    xmm5,dword ptr [r8]
       vmovss    xmm16,dword ptr [r8+4]
       vmovss    xmm17,dword ptr [r8+8]
       vpermilps xmm18,xmm1,0D2
       vpermilps xmm19,xmm1,0C9
       vmulps    xmm19,xmm19,xmm1
       vpermilps xmm20,xmm1,0FF
       vmulps    xmm18,xmm20,xmm18
       vmulps    xmm1,xmm1,xmm1
       vaddps    xmm20,xmm19,xmm18
       vsubps    xmm18,xmm19,xmm18
       vaddps    xmm19,xmm20,xmm20
       vaddps    xmm18,xmm18,xmm18
       vpermilps xmm20,xmm1,0C9
       vaddps    xmm1,xmm20,xmm1
       vaddps    xmm1,xmm1,xmm1
       vsubps    xmm1,xmm0,xmm1
       vmovshdup xmm20,xmm1
       vinsertps xmm20,xmm18,xmm20,0
       vmovaps   xmm21,xmm19
       vinsertps xmm20,xmm20,xmm21,10
       vunpckhps xmm21,xmm1,xmm1
       vinsertps xmm21,xmm18,xmm21,10
       vmovshdup xmm22,xmm19
       vinsertps xmm21,xmm21,xmm22,20
       vunpckhps xmm19,xmm19,xmm19
       vinsertps xmm18,xmm18,xmm19,0
       vinsertps xmm1,xmm18,xmm1,20
       vbroadcastss xmm2,xmm2
       vmulps    xmm2,xmm20,xmm2
       vbroadcastss xmm3,xmm3
       vmulps    xmm3,xmm21,xmm3
       vbroadcastss xmm4,xmm4
       vmulps    xmm1,xmm4,xmm1
       vinsertps xmm4,xmm0,xmm5,0
       vinsertps xmm4,xmm4,xmm16,10
       vinsertps xmm4,xmm4,xmm17,20
       cmp       eax,[rdx+8]
       jae       short 00000000000057E0
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm2
       vmovups   [rdx+10],xmm3
       vmovups   [rdx+20],xmm1
       vmovups   [rdx+30],xmm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr 000000000000566F
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 390
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Single, System.Private.CoreLib]].Add()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       short 0000000000003950
       mov       rbx,rdx
       shl       rbx,6
       vmovups   zmm0,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       short 0000000000003950
       mov       r11d,r9d
       shl       r11,6
       vaddps    zmm0,zmm0,[r10+r11+10]
       cmp       edx,[r8+8]
       jae       short 0000000000003950
       vmovups   [r8+rbx+10],zmm0
       mov       edx,r9d
       cmp       edx,1869F
       jl        short 00000000000038EB
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 118
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Single, System.Private.CoreLib]].Subtract()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       short 0000000000003E90
       mov       rbx,rdx
       shl       rbx,6
       vmovups   zmm0,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       short 0000000000003E90
       mov       r11d,r9d
       shl       r11,6
       vsubps    zmm0,zmm0,[r10+r11+10]
       cmp       edx,[r8+8]
       jae       short 0000000000003E90
       vmovups   [r8+rbx+10],zmm0
       mov       edx,r9d
       cmp       edx,1869F
       jl        short 0000000000003E2B
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 118
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Single, System.Private.CoreLib]].Multiply()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr 00000000000041DD
       mov       r11,rax
       shl       r11,6
       lea       r10,[r10+r11+10]
       vmovups   xmm0,[r10]
       vmovups   xmm1,[r10+10]
       vmovups   xmm2,[r10+20]
       vmovups   xmm3,[r10+30]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr 00000000000041DD
       mov       r9d,r10d
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm16,[r8+20]
       vmovups   xmm17,[r8+30]
       vmovaps   xmm18,xmm0
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm0
       vpermilpd xmm20,xmm19,1
       vbroadcastss xmm20,xmm20
       vunpckhps xmm0,xmm0,xmm0
       vbroadcastss xmm0,xmm0
       vbroadcastss xmm19,xmm19
       vmulps    xmm18,xmm18,xmm4
       vfmadd231ps xmm18,xmm19,xmm5
       vfmadd213ps xmm0,xmm16,xmm18
       vfmadd231ps xmm0,xmm20,xmm17
       vmovaps   xmm18,xmm1
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm1
       vpermilpd xmm20,xmm19,1
       vbroadcastss xmm20,xmm20
       vunpckhps xmm1,xmm1,xmm1
       vbroadcastss xmm1,xmm1
       vbroadcastss xmm19,xmm19
       vmulps    xmm18,xmm18,xmm4
       vfmadd231ps xmm18,xmm19,xmm5
       vfmadd213ps xmm1,xmm16,xmm18
       vfmadd231ps xmm1,xmm20,xmm17
       vmovaps   xmm18,xmm2
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm2
       vpermilpd xmm20,xmm19,1
       vbroadcastss xmm20,xmm20
       vunpckhps xmm2,xmm2,xmm2
       vbroadcastss xmm2,xmm2
       vbroadcastss xmm19,xmm19
       vmulps    xmm18,xmm18,xmm4
       vfmadd231ps xmm18,xmm19,xmm5
       vfmadd213ps xmm2,xmm16,xmm18
       vfmadd231ps xmm2,xmm20,xmm17
       vmovaps   xmm18,xmm3
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm3
       vpermilpd xmm20,xmm19,1
       vbroadcastss xmm20,xmm20
       vunpckhps xmm3,xmm3,xmm3
       vbroadcastss xmm3,xmm3
       vbroadcastss xmm19,xmm19
       vmulps    xmm4,xmm18,xmm4
       vfmadd213ps xmm5,xmm19,xmm4
       vfmadd213ps xmm3,xmm16,xmm5
       vfmadd213ps xmm17,xmm20,xmm3
       cmp       eax,[rdx+8]
       jae       short 00000000000041DD
       lea       rax,[rdx+r11+10]
       vmovups   [rax],xmm0
       vmovups   [rax+10],xmm1
       vmovups   [rax+20],xmm2
       vmovups   [rax+30],xmm17
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000004026
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 451
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

