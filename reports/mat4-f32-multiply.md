# .NET (10.0.326.7603), X64 RyuJIT x86-64-v4, Windows 11 (10.0.26200.7922)

## AMD Ryzen 9 7900X 4.70GHz

```mermaid
xychart
    title "float x * y 100k"
    x-axis [System.Numercs.Matrix4x4, "Mat44", Silk.NET.Matrix4X4]
    y-axis "time (μs)" 0 --> 5000
    bar [300.2, 653.1, 4625.2]
```

## System.Matrix4x4

<details>
<summary>asm</summary>

```assembly
; System.Numerics.Bench.StressMatrix4x4.Multiply()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+8]
       mov       r8,rdx
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       near ptr M00_L01
       mov       r9,rax
       shl       r9,6
       lea       r8,[r8+r9+10]
       mov       r9,r8
       vmovups   xmm0,[r9]
       vmovups   xmm1,[r9+10]
       vmovups   xmm2,[r9+20]
       vmovups   xmm3,[r9+30]
       inc       eax
       cmp       eax,r10d
       jae       near ptr M00_L01
       mov       r10d,eax
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   xmm4,[rdx]
       vmovups   xmm5,[rdx+10]
       vmovups   xmm16,[rdx+20]
       vmovups   xmm17,[rdx+30]
       vunpckhps xmm18,xmm0,xmm0
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm0
       vbroadcastss xmm19,xmm19
       vmovaps   xmm20,xmm0
       vbroadcastss xmm20,xmm20
       vmulps    xmm20,xmm20,xmm4
       vfmadd231ps xmm20,xmm19,xmm5
       vfmadd231ps xmm20,xmm18,xmm16
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm20,xmm0,xmm17
       vunpckhps xmm0,xmm1,xmm1
       vbroadcastss xmm0,xmm0
       vmovshdup xmm18,xmm1
       vbroadcastss xmm18,xmm18
       vmovaps   xmm19,xmm1
       vbroadcastss xmm19,xmm19
       vmulps    xmm19,xmm19,xmm4
       vfmadd231ps xmm19,xmm18,xmm5
       vfmadd231ps xmm19,xmm0,xmm16
       vshufps   xmm0,xmm1,xmm1,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm19,xmm0,xmm17
       vunpckhps xmm0,xmm2,xmm2
       vbroadcastss xmm0,xmm0
       vmovshdup xmm1,xmm2
       vbroadcastss xmm1,xmm1
       vmovaps   xmm18,xmm2
       vbroadcastss xmm18,xmm18
       vmulps    xmm18,xmm18,xmm4
       vfmadd231ps xmm18,xmm1,xmm5
       vfmadd231ps xmm18,xmm0,xmm16
       vshufps   xmm0,xmm2,xmm2,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm18,xmm0,xmm17
       vunpckhps xmm0,xmm3,xmm3
       vbroadcastss xmm0,xmm0
       vmovshdup xmm1,xmm3
       vbroadcastss xmm1,xmm1
       vmovaps   xmm2,xmm3
       vbroadcastss xmm2,xmm2
       vmulps    xmm2,xmm2,xmm4
       vfmadd213ps xmm5,xmm1,xmm2
       vfmadd213ps xmm16,xmm0,xmm5
       vshufps   xmm0,xmm3,xmm3,0FF
       vbroadcastss xmm0,xmm0
       vfmadd213ps xmm17,xmm0,xmm16
       vmovups   [r8],xmm20
       vmovups   [r8+10],xmm19
       vmovups   [r8+20],xmm18
       vmovups   [r8+30],xmm17
       mov       eax,eax
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 420
```
</details>

## draft Mat44

<details>
<summary>asm</summary>

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Single, System.Private.CoreLib]].Multiply()
       sub       rsp,118
       vmovaps   [rsp+100],xmm6
       vmovaps   [rsp+0F0],xmm7
       vmovaps   [rsp+0E0],xmm8
       vmovaps   [rsp+0D0],xmm9
       vmovaps   [rsp+0C0],xmm10
       vxorps    xmm0,xmm0,xmm0
       vmovaps   xmm1,xmm0
       vmovaps   xmm2,xmm0
       vmovaps   xmm3,xmm0
       vmovaps   xmm4,xmm0
       vmovaps   xmm5,xmm0
       vmovaps   xmm16,xmm0
       mov       rax,[rcx+8]
       xor       ecx,ecx
M00_L00:
       mov       rdx,rax
       mov       r8d,[rdx+8]
       cmp       ecx,r8d
       jae       near ptr M00_L01
       mov       r10,rcx
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       mov       r10,rdx
       vmovss    xmm17,dword ptr [r10]
       vmovss    xmm18,dword ptr [r10+4]
       vmovss    xmm19,dword ptr [r10+8]
       vmovss    xmm20,dword ptr [r10+0C]
       vmovss    xmm21,dword ptr [r10+10]
       vmovss    xmm22,dword ptr [r10+14]
       vmovss    xmm23,dword ptr [r10+18]
       vmovss    xmm24,dword ptr [r10+1C]
       vmovss    xmm25,dword ptr [r10+20]
       vmovss    xmm26,dword ptr [r10+24]
       vmovss    xmm27,dword ptr [r10+28]
       vmovss    xmm28,dword ptr [r10+2C]
       vmovss    xmm29,dword ptr [r10+30]
       vmovss    xmm30,dword ptr [r10+34]
       vmovss    xmm31,dword ptr [r10+38]
       vmovss    xmm6,dword ptr [r10+3C]
       mov       r10,rax
       inc       ecx
       cmp       ecx,r8d
       jae       near ptr M00_L01
       mov       r8d,ecx
       shl       r8,6
       lea       r8,[r10+r8+10]
       vmovups   xmm7,[r8]
       vmovups   xmm8,[r8+10]
       vmovups   xmm9,[r8+20]
       vmovups   xmm10,[r8+30]
       vbroadcastss xmm17,xmm17
       vmulps    xmm17,xmm17,xmm7
       vbroadcastss xmm21,xmm21
       vmulps    xmm21,xmm21,xmm7
       vinsertf32x4 ymm17,ymm17,xmm21,1
       vbroadcastss xmm21,xmm25
       vmulps    xmm21,xmm21,xmm7
       vbroadcastss xmm25,xmm29
       vmulps    xmm25,xmm25,xmm7
       vinsertf32x4 ymm21,ymm21,xmm25,1
       vinsertf32x8 zmm0,zmm0,ymm17,0
       vinsertf32x8 zmm0,zmm0,ymm21,1
       vbroadcastss xmm17,xmm18
       vbroadcastss xmm18,xmm22
       vinsertf32x4 ymm17,ymm17,xmm18,1
       vbroadcastss xmm18,xmm26
       vbroadcastss xmm21,xmm30
       vinsertf32x4 ymm18,ymm18,xmm21,1
       vinsertf32x8 zmm1,zmm1,ymm17,0
       vinsertf32x8 zmm1,zmm1,ymm18,1
       vbroadcastss xmm17,xmm19
       vbroadcastss xmm18,xmm23
       vinsertf32x4 ymm17,ymm17,xmm18,1
       vbroadcastss xmm18,xmm27
       vbroadcastss xmm19,xmm31
       vinsertf32x4 ymm18,ymm18,xmm19,1
       vinsertf32x8 zmm2,zmm2,ymm17,0
       vinsertf32x8 zmm2,zmm2,ymm18,1
       vbroadcastss xmm17,xmm20
       vbroadcastss xmm18,xmm24
       vinsertf32x4 ymm17,ymm17,xmm18,1
       vbroadcastss xmm18,xmm28
       vbroadcastss xmm19,xmm6
       vinsertf32x4 ymm18,ymm18,xmm19,1
       vinsertf32x8 zmm3,zmm3,ymm17,0
       vinsertf32x8 zmm3,zmm3,ymm18,1
       vmovaps   ymm17,ymm8
       vinsertf32x4 ymm17,ymm17,xmm8,1
       vinsertf32x8 zmm4,zmm4,ymm17,0
       vinsertf32x8 zmm4,zmm4,ymm17,1
       vmovaps   ymm17,ymm9
       vinsertf32x4 ymm17,ymm17,xmm9,1
       vinsertf32x8 zmm5,zmm5,ymm17,0
       vinsertf32x8 zmm5,zmm5,ymm17,1
       vmulps    zmm17,zmm4,zmm1
       vaddps    zmm17,zmm17,zmm0
       vmulps    zmm18,zmm2,zmm5
       vaddps    zmm17,zmm18,zmm17
       vmovaps   ymm18,ymm10
       vinsertf32x4 ymm18,ymm18,xmm10,1
       vinsertf32x8 zmm16,zmm16,ymm18,0
       vinsertf32x8 zmm16,zmm16,ymm18,1
       vmulps    zmm18,zmm3,zmm16
       vaddps    zmm17,zmm18,zmm17
       vmovups   [rsp+20],zmm17
       vmovdqu32 zmm17,[rsp+20]
       vmovdqu32 [rsp+80],zmm17
       vmovdqu32 [rdx],zmm17
       mov       ecx,ecx
       cmp       ecx,1869F
       jl        near ptr M00_L00
       vzeroupper
       vmovaps   xmm6,[rsp+100]
       vmovaps   xmm7,[rsp+0F0]
       vmovaps   xmm8,[rsp+0E0]
       vmovaps   xmm9,[rsp+0D0]
       vmovaps   xmm10,[rsp+0C0]
       add       rsp,118
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 729
```
</details>

## Silk.NET.Matrix4X4

<details>
<summary>asm</summary>

```assembly
; System.Numerics.Bench.StressMatrix4X4`1[[System.Single, System.Private.CoreLib]].Multiply()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2C0
       vmovaps   [rsp+2B0],xmm6
       vmovaps   [rsp+2A0],xmm7
       vmovaps   [rsp+290],xmm8
       vmovaps   [rsp+280],xmm9
       vmovaps   [rsp+270],xmm10
       vmovaps   [rsp+260],xmm11
       vmovaps   [rsp+250],xmm12
       vmovaps   [rsp+240],xmm13
       vmovaps   [rsp+230],xmm14
       vmovaps   [rsp+220],xmm15
       mov       rbx,rcx
       xor       esi,esi
M00_L00:
       mov       rdx,[rbx+8]
       mov       r8,rdx
       cmp       esi,[r8+8]
       jae       near ptr M00_L01
       mov       rcx,rsi
       shl       rcx,6
       lea       rdi,[r8+rcx+10]
       mov       r8,rdi
       vmovss    xmm0,dword ptr [r8]
       vmovss    xmm1,dword ptr [r8+4]
       vmovss    xmm2,dword ptr [r8+8]
       vmovss    xmm3,dword ptr [r8+0C]
       vmovss    xmm4,dword ptr [r8+10]
       vmovss    xmm5,dword ptr [r8+14]
       vmovss    xmm16,dword ptr [r8+18]
       vmovss    xmm6,dword ptr [r8+1C]
       vmovss    xmm7,dword ptr [r8+20]
       vmovss    xmm8,dword ptr [r8+24]
       vmovss    dword ptr [rsp+74],xmm8
       vmovss    xmm9,dword ptr [r8+28]
       vmovss    dword ptr [rsp+70],xmm9
       vmovss    xmm10,dword ptr [r8+2C]
       vmovss    dword ptr [rsp+6C],xmm10
       vmovss    xmm11,dword ptr [r8+30]
       vmovss    dword ptr [rsp+68],xmm11
       vmovss    xmm12,dword ptr [r8+34]
       vmovss    dword ptr [rsp+64],xmm12
       vmovss    xmm13,dword ptr [r8+38]
       vmovss    dword ptr [rsp+60],xmm13
       vmovss    xmm14,dword ptr [r8+3C]
       inc       esi
       cmp       esi,[rdx+8]
       jae       near ptr M00_L01
       mov       r8d,esi
       shl       r8,6
       lea       rdx,[rdx+r8+10]
       vmovss    xmm15,dword ptr [rdx+30]
       vmovss    xmm17,dword ptr [rdx+34]
       vmovss    dword ptr [rsp+5C],xmm17
       vmovss    xmm18,dword ptr [rdx+38]
       vmovss    dword ptr [rsp+58],xmm18
       vmovss    xmm19,dword ptr [rdx+3C]
       vmovss    dword ptr [rsp+54],xmm19
       vmovdqu32 zmm20,[rdx]
       vmovdqu32 [rsp+1E0],zmm20
       vmovss    xmm20,dword ptr [rsp+1E0]
       vmovaps   xmm21,xmm20
       vmovss    xmm22,dword ptr [rsp+1E4]
       vmovaps   xmm23,xmm22
       vmovss    xmm24,dword ptr [rsp+1E8]
       vmovaps   xmm25,xmm24
       vmovss    xmm26,dword ptr [rsp+1EC]
       vmovaps   xmm27,xmm26
       vmulss    xmm21,xmm21,xmm0
       vmulss    xmm23,xmm23,xmm0
       vmulss    xmm25,xmm25,xmm0
       vmulss    xmm0,xmm27,xmm0
       vmovss    xmm27,dword ptr [rsp+1F0]
       vmovaps   xmm28,xmm27
       vmovss    xmm29,dword ptr [rsp+1F4]
       vmovaps   xmm30,xmm29
       vmovss    xmm31,dword ptr [rsp+1F8]
       vmovaps   xmm13,xmm31
       vmovss    xmm12,dword ptr [rsp+1FC]
       vmovaps   xmm11,xmm12
       vmulss    xmm28,xmm28,xmm1
       vmulss    xmm30,xmm30,xmm1
       vmulss    xmm13,xmm13,xmm1
       vmulss    xmm1,xmm11,xmm1
       vaddss    xmm21,xmm21,xmm28
       vaddss    xmm23,xmm23,xmm30
       vaddss    xmm25,xmm25,xmm13
       vaddss    xmm0,xmm0,xmm1
       vmovss    xmm1,dword ptr [rsp+200]
       vmovaps   xmm28,xmm1
       vmovss    xmm30,dword ptr [rsp+204]
       vmovaps   xmm11,xmm30
       vmovss    xmm13,dword ptr [rsp+208]
       vmovaps   xmm10,xmm13
       vmovss    xmm9,dword ptr [rsp+20C]
       vmovaps   xmm8,xmm9
       vmulss    xmm28,xmm28,xmm2
       vmulss    xmm11,xmm11,xmm2
       vmulss    xmm10,xmm10,xmm2
       vmulss    xmm2,xmm8,xmm2
       vaddss    xmm21,xmm21,xmm28
       vaddss    xmm23,xmm23,xmm11
       vaddss    xmm25,xmm25,xmm10
       vaddss    xmm0,xmm0,xmm2
       vmulss    xmm2,xmm15,xmm3
       vmulss    xmm28,xmm17,xmm3
       vmulss    xmm8,xmm18,xmm3
       vmulss    xmm3,xmm19,xmm3
       vaddss    xmm10,xmm21,xmm2
       vaddss    xmm11,xmm23,xmm28
       vaddss    xmm8,xmm25,xmm8
       vaddss    xmm0,xmm0,xmm3
       vmovss    dword ptr [rsp+9C],xmm0
       vmulss    xmm2,xmm20,xmm4
       vmulss    xmm3,xmm22,xmm4
       vmulss    xmm20,xmm24,xmm4
       vmulss    xmm4,xmm26,xmm4
       vmulss    xmm21,xmm27,xmm5
       vmulss    xmm22,xmm29,xmm5
       vmulss    xmm23,xmm31,xmm5
       vmulss    xmm5,xmm12,xmm5
       vaddss    xmm2,xmm2,xmm21
       vaddss    xmm3,xmm3,xmm22
       vaddss    xmm20,xmm20,xmm23
       vaddss    xmm4,xmm4,xmm5
       vmulss    xmm1,xmm1,xmm16
       vmulss    xmm5,xmm30,xmm16
       vmulss    xmm21,xmm13,xmm16
       vmulss    xmm16,xmm9,xmm16
       vmovss    dword ptr [rsp+40],xmm2
       vmovss    dword ptr [rsp+44],xmm3
       vmovss    dword ptr [rsp+48],xmm20
       vmovss    dword ptr [rsp+4C],xmm4
       vmovss    dword ptr [rsp+30],xmm1
       vmovss    dword ptr [rsp+34],xmm5
       vmovss    dword ptr [rsp+38],xmm21
       vmovss    dword ptr [rsp+3C],xmm16
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       lea       rcx,[rsp+1D0]
       call      qword ptr [7FFE8A7E4498]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovaps   xmm0,xmm15
       vmovaps   xmm1,xmm6
       call      qword ptr [7FFE8A7E4618]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm9,xmm0
       vmovss    xmm0,dword ptr [rsp+5C]
       vmovaps   xmm1,xmm6
       call      qword ptr [7FFE8A7E4618]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm12,xmm0
       vmovss    xmm0,dword ptr [rsp+58]
       vmovaps   xmm1,xmm6
       call      qword ptr [7FFE8A7E4618]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm13,xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+88],xmm0
       vmovss    xmm0,dword ptr [rsp+54]
       vmovaps   xmm1,xmm6
       call      qword ptr [7FFE8A7E4618]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovss    dword ptr [rsp+20],xmm0
       lea       rcx,[rsp+88]
       vmovaps   xmm1,xmm9
       vmovaps   xmm2,xmm12
       vmovaps   xmm3,xmm13
       call      qword ptr [7FFE8A5AE808]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]]..ctor(Single, Single, Single, Single)
       vmovups   xmm0,[rsp+88]
       vmovups   [rsp+40],xmm0
       lea       r8,[rsp+40]
       lea       rdx,[rsp+1D0]
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFE8A7E4498]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovups   xmm2,[rsp+1E0]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+1B0]
       vmovaps   xmm2,xmm7
       call      qword ptr [7FFE8A7E4708]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       vmovups   xmm2,[rsp+1F0]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+1A0]
       vmovss    xmm2,dword ptr [rsp+74]
       call      qword ptr [7FFE8A7E4708]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+190]
       lea       rdx,[rsp+1B0]
       lea       r8,[rsp+1A0]
       call      qword ptr [7FFE8A7E4498]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovups   xmm2,[rsp+200]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+180]
       vmovss    xmm2,dword ptr [rsp+70]
       call      qword ptr [7FFE8A7E4708]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+170]
       lea       rdx,[rsp+190]
       lea       r8,[rsp+180]
       call      qword ptr [7FFE8A7E4498]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovss    dword ptr [rsp+210],xmm15
       vmovss    xmm6,dword ptr [rsp+5C]
       vmovss    dword ptr [rsp+214],xmm6
       vmovss    xmm7,dword ptr [rsp+58]
       vmovss    dword ptr [rsp+218],xmm7
       vmovss    xmm9,dword ptr [rsp+54]
       vmovss    dword ptr [rsp+21C],xmm9
       vmovups   xmm2,[rsp+210]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+160]
       vmovss    xmm2,dword ptr [rsp+6C]
       call      qword ptr [7FFE8A7E4708]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+150]
       lea       rdx,[rsp+170]
       lea       r8,[rsp+160]
       call      qword ptr [7FFE8A7E4498]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovups   xmm2,[rsp+1E0]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+140]
       vmovss    xmm2,dword ptr [rsp+68]
       call      qword ptr [7FFE8A7E4708]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       vmovups   xmm2,[rsp+1F0]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+130]
       vmovss    xmm2,dword ptr [rsp+64]
       call      qword ptr [7FFE8A7E4708]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+120]
       lea       rdx,[rsp+140]
       lea       r8,[rsp+130]
       call      qword ptr [7FFE8A7E4498]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       lea       rcx,[rsp+110]
       lea       rdx,[rsp+200]
       vmovss    xmm2,dword ptr [rsp+60]
       call      qword ptr [7FFE8A7E4708]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+100]
       lea       rdx,[rsp+120]
       lea       r8,[rsp+110]
       call      qword ptr [7FFE8A7E4498]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovaps   xmm0,xmm15
       vmovaps   xmm1,xmm14
       call      qword ptr [7FFE8A7E4618]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm12,xmm0
       vmovaps   xmm0,xmm6
       vmovaps   xmm1,xmm14
       call      qword ptr [7FFE8A7E4618]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm6,xmm0
       vmovaps   xmm0,xmm7
       vmovaps   xmm1,xmm14
       call      qword ptr [7FFE8A7E4618]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm7,xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+78],xmm0
       vmovaps   xmm0,xmm9
       vmovaps   xmm1,xmm14
       call      qword ptr [7FFE8A7E4618]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovss    dword ptr [rsp+20],xmm0
       lea       rcx,[rsp+78]
       vmovaps   xmm1,xmm12
       vmovaps   xmm2,xmm6
       vmovaps   xmm3,xmm7
       call      qword ptr [7FFE8A5AE808]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]]..ctor(Single, Single, Single, Single)
       vmovups   xmm0,[rsp+78]
       vmovups   [rsp+0F0],xmm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu32 [rsp+0B0],zmm0
       lea       rcx,[rsp+0A0]
       lea       rdx,[rsp+100]
       lea       r8,[rsp+0F0]
       call      qword ptr [7FFE8A7E4498]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovss    dword ptr [rsp+40],xmm10
       vmovss    dword ptr [rsp+44],xmm11
       vmovss    dword ptr [rsp+48],xmm8
       vmovss    xmm6,dword ptr [rsp+9C]
       vmovss    dword ptr [rsp+4C],xmm6
       lea       rdx,[rsp+0A0]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+0B0]
       lea       r8,[rsp+1C0]
       lea       r9,[rsp+150]
       call      qword ptr [7FFE8A7E4600]; Silk.NET.Maths.Matrix4X4`1[[System.Single, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovdqu32 zmm0,[rsp+0B0]
       vmovdqu32 [rdi],zmm0
       mov       esi,esi
       cmp       esi,1869F
       jl        near ptr M00_L00
       vzeroupper
       vmovaps   xmm6,[rsp+2B0]
       vmovaps   xmm7,[rsp+2A0]
       vmovaps   xmm8,[rsp+290]
       vmovaps   xmm9,[rsp+280]
       vmovaps   xmm10,[rsp+270]
       vmovaps   xmm11,[rsp+260]
       vmovaps   xmm12,[rsp+250]
       vmovaps   xmm13,[rsp+240]
       vmovaps   xmm14,[rsp+230]
       vmovaps   xmm15,[rsp+220]
       add       rsp,2C0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1861
```
</details>