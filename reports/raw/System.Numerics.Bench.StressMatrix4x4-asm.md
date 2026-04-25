## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4x4.Add()
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
       shl       r11,6
       lea       r10,[r10+r11+10]
       vmovups   xmm0,[r10]
       vmovups   xmm1,[r10+10]
       vmovups   xmm2,[r10+20]
       vmovups   xmm3,[r10+30]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       short M00_L01
       mov       r9d,r10d
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm16,[r8+20]
       vmovups   xmm17,[r8+30]
       vaddps    xmm0,xmm0,xmm4
       vaddps    xmm1,xmm1,xmm5
       vaddps    xmm2,xmm2,xmm16
       vaddps    xmm3,xmm3,xmm17
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],xmm0
       vmovups   [rax+10],xmm1
       vmovups   [rax+20],xmm2
       vmovups   [rax+30],xmm3
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 185
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4x4.Substract()
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
       shl       r11,6
       lea       r10,[r10+r11+10]
       vmovups   xmm0,[r10]
       vmovups   xmm1,[r10+10]
       vmovups   xmm2,[r10+20]
       vmovups   xmm3,[r10+30]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       short M00_L01
       mov       r9d,r10d
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm16,[r8+20]
       vmovups   xmm17,[r8+30]
       vsubps    xmm0,xmm0,xmm4
       vsubps    xmm1,xmm1,xmm5
       vsubps    xmm2,xmm2,xmm16
       vsubps    xmm3,xmm3,xmm17
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],xmm0
       vmovups   [rax+10],xmm1
       vmovups   [rax+20],xmm2
       vmovups   [rax+30],xmm3
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 185
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4x4.Rotation()
       sub       rsp,28
       xor       eax,eax
       vmovss    xmm0,dword ptr [7FFF431AA9B0]
       vmovss    xmm1,dword ptr [7FFF431AA9B4]
       vmovups   xmm2,[7FFF431AA9C0]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,4
       vmovups   xmm3,[r8+r9+10]
       vmovaps   xmm4,xmm3
       vmulss    xmm5,xmm4,xmm4
       vmovshdup xmm16,xmm3
       vmulss    xmm17,xmm16,xmm16
       vunpckhps xmm18,xmm3,xmm3
       vmulss    xmm19,xmm18,xmm18
       vmulss    xmm20,xmm4,xmm16
       vshufps   xmm3,xmm3,xmm3,0FF
       vmulss    xmm21,xmm18,xmm3
       vmulss    xmm22,xmm18,xmm4
       vmulss    xmm23,xmm16,xmm3
       vmulss    xmm16,xmm16,xmm18
       vmulss    xmm3,xmm4,xmm3
       vaddss    xmm4,xmm17,xmm19
       vmulss    xmm4,xmm4,xmm0
       vsubss    xmm4,xmm1,xmm4
       vaddss    xmm18,xmm20,xmm21
       vmulss    xmm18,xmm18,xmm0
       vinsertps xmm4,xmm4,xmm18,10
       vsubss    xmm18,xmm22,xmm23
       vmulss    xmm18,xmm18,xmm0
       vinsertps xmm4,xmm4,xmm18,28
       vsubss    xmm18,xmm20,xmm21
       vmulss    xmm18,xmm18,xmm0
       vaddss    xmm19,xmm19,xmm5
       vmulss    xmm19,xmm19,xmm0
       vsubss    xmm19,xmm1,xmm19
       vinsertps xmm18,xmm18,xmm19,10
       vaddss    xmm19,xmm16,xmm3
       vmulss    xmm19,xmm19,xmm0
       vinsertps xmm18,xmm18,xmm19,28
       vaddss    xmm19,xmm22,xmm23
       vmulss    xmm19,xmm19,xmm0
       vsubss    xmm3,xmm16,xmm3
       vmulss    xmm3,xmm3,xmm0
       vinsertps xmm3,xmm19,xmm3,10
       vaddss    xmm5,xmm17,xmm5
       vmulss    xmm5,xmm5,xmm0
       vsubss    xmm5,xmm1,xmm5
       vinsertps xmm3,xmm3,xmm5,28
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm4
       vmovups   [rdx+10],xmm18
       vmovups   [rdx+20],xmm3
       vmovups   xmm3,[7FFF431AA9C0]
       vmovups   [rdx+30],xmm3
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 360
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4x4.Transform()
       sub       rsp,98
       vmovaps   [rsp+80],xmm6
       vmovaps   [rsp+70],xmm7
       vmovaps   [rsp+60],xmm8
       vmovaps   [rsp+50],xmm9
       vmovaps   [rsp+40],xmm10
       vmovaps   [rsp+30],xmm11
       vmovaps   [rsp+20],xmm12
       vmovss    xmm0,dword ptr [7FFF431AB348]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10,rax
       shl       r10,6
       lea       r8,[r8+r10+10]
       vmovss    xmm1,dword ptr [r8]
       vmovss    xmm2,dword ptr [r8+4]
       vmovss    xmm3,dword ptr [r8+8]
       vmovss    xmm4,dword ptr [r8+0C]
       vmovss    xmm5,dword ptr [r8+10]
       vmovss    xmm16,dword ptr [r8+14]
       vmovss    xmm17,dword ptr [r8+18]
       vmovss    xmm18,dword ptr [r8+1C]
       vmovss    xmm19,dword ptr [r8+20]
       vmovss    xmm20,dword ptr [r8+24]
       vmovss    xmm21,dword ptr [r8+28]
       vmovss    xmm22,dword ptr [r8+2C]
       vmovss    xmm23,dword ptr [r8+30]
       vmovss    xmm24,dword ptr [r8+34]
       vmovss    xmm25,dword ptr [r8+38]
       vmovss    xmm26,dword ptr [r8+3C]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r9,rax
       shl       r9,4
       vmovups   xmm27,[r8+r9+10]
       vmovaps   xmm28,xmm27
       vaddss    xmm29,xmm28,xmm28
       vmovshdup xmm30,xmm27
       vaddss    xmm31,xmm30,xmm30
       vunpckhps xmm6,xmm27,xmm27
       vaddss    xmm7,xmm6,xmm6
       vshufps   xmm27,xmm27,xmm27,0FF
       vmulss    xmm8,xmm27,xmm29
       vmulss    xmm9,xmm27,xmm31
       vmulss    xmm27,xmm27,xmm7
       vmulss    xmm29,xmm28,xmm29
       vmulss    xmm10,xmm28,xmm7
       vmulss    xmm11,xmm30,xmm31
       vmulss    xmm30,xmm30,xmm7
       vmulss    xmm6,xmm6,xmm7
       vsubss    xmm7,xmm0,xmm11
       vsubss    xmm7,xmm7,xmm6
       vmulss    xmm28,xmm28,xmm31
       vsubss    xmm31,xmm28,xmm27
       vaddss    xmm12,xmm10,xmm9
       vaddss    xmm27,xmm28,xmm27
       vsubss    xmm28,xmm0,xmm29
       vsubss    xmm29,xmm28,xmm6
       vsubss    xmm6,xmm30,xmm8
       vsubss    xmm9,xmm10,xmm9
       vaddss    xmm30,xmm30,xmm8
       vsubss    xmm28,xmm28,xmm11
       vmulss    xmm8,xmm1,xmm7
       vmulss    xmm10,xmm2,xmm31
       vaddss    xmm8,xmm8,xmm10
       vmulss    xmm10,xmm3,xmm12
       vaddss    xmm8,xmm8,xmm10
       vmulss    xmm10,xmm1,xmm27
       vmulss    xmm11,xmm2,xmm29
       vaddss    xmm10,xmm10,xmm11
       vmulss    xmm11,xmm3,xmm6
       vaddss    xmm10,xmm10,xmm11
       vinsertps xmm8,xmm8,xmm10,10
       vmulss    xmm1,xmm1,xmm9
       vmulss    xmm2,xmm2,xmm30
       vaddss    xmm1,xmm1,xmm2
       vmulss    xmm2,xmm3,xmm28
       vaddss    xmm1,xmm1,xmm2
       vinsertps xmm1,xmm8,xmm1,20
       vinsertps xmm1,xmm1,xmm4,30
       vmulss    xmm2,xmm5,xmm7
       vmulss    xmm3,xmm16,xmm31
       vaddss    xmm2,xmm2,xmm3
       vmulss    xmm3,xmm17,xmm12
       vaddss    xmm2,xmm2,xmm3
       vmulss    xmm3,xmm5,xmm27
       vmulss    xmm4,xmm16,xmm29
       vaddss    xmm3,xmm3,xmm4
       vmulss    xmm4,xmm17,xmm6
       vaddss    xmm3,xmm3,xmm4
       vinsertps xmm2,xmm2,xmm3,10
       vmulss    xmm3,xmm5,xmm9
       vmulss    xmm4,xmm16,xmm30
       vaddss    xmm3,xmm3,xmm4
       vmulss    xmm4,xmm17,xmm28
       vaddss    xmm3,xmm3,xmm4
       vinsertps xmm2,xmm2,xmm3,20
       vinsertps xmm2,xmm2,xmm18,30
       vmulss    xmm3,xmm19,xmm7
       vmulss    xmm4,xmm20,xmm31
       vaddss    xmm3,xmm3,xmm4
       vmulss    xmm4,xmm21,xmm12
       vaddss    xmm3,xmm3,xmm4
       vmulss    xmm4,xmm19,xmm27
       vmulss    xmm5,xmm20,xmm29
       vaddss    xmm4,xmm4,xmm5
       vmulss    xmm5,xmm21,xmm6
       vaddss    xmm4,xmm4,xmm5
       vinsertps xmm3,xmm3,xmm4,10
       vmulss    xmm4,xmm19,xmm9
       vmulss    xmm5,xmm20,xmm30
       vaddss    xmm4,xmm4,xmm5
       vmulss    xmm5,xmm21,xmm28
       vaddss    xmm4,xmm4,xmm5
       vinsertps xmm3,xmm3,xmm4,20
       vinsertps xmm3,xmm3,xmm22,30
       vmulss    xmm4,xmm23,xmm7
       vmulss    xmm5,xmm24,xmm31
       vaddss    xmm4,xmm4,xmm5
       vmulss    xmm5,xmm25,xmm12
       vaddss    xmm4,xmm4,xmm5
       vmulss    xmm5,xmm23,xmm27
       vmulss    xmm16,xmm24,xmm29
       vaddss    xmm5,xmm5,xmm16
       vmulss    xmm16,xmm25,xmm6
       vaddss    xmm5,xmm5,xmm16
       vinsertps xmm4,xmm4,xmm5,10
       vmulss    xmm5,xmm23,xmm9
       vmulss    xmm16,xmm24,xmm30
       vaddss    xmm5,xmm5,xmm16
       vmulss    xmm16,xmm25,xmm28
       vaddss    xmm5,xmm5,xmm16
       vinsertps xmm4,xmm4,xmm5,20
       vinsertps xmm4,xmm4,xmm26,30
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm1
       vmovups   [rdx+10],xmm2
       vmovups   [rdx+20],xmm3
       vmovups   [rdx+30],xmm4
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
; Total bytes of code 870
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4x4.Affine()
       sub       rsp,118
       vmovaps   [rsp+100],xmm6
       vmovaps   [rsp+0F0],xmm7
       vmovaps   [rsp+0E0],xmm8
       vmovaps   [rsp+0D0],xmm9
       vmovaps   [rsp+0C0],xmm10
       vmovaps   [rsp+0B0],xmm11
       vmovaps   [rsp+0A0],xmm12
       vmovaps   [rsp+90],xmm13
       vmovaps   [rsp+80],xmm14
       vmovaps   [rsp+70],xmm15
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rsp+30],zmm4
       xor       eax,eax
       vmovups   xmm0,[7FFF431CC0D0]
       vmovaps   [rsp+20],xmm0
       vmovss    xmm1,dword ptr [7FFF431CC0E0]
       vmovss    xmm2,dword ptr [7FFF431CC0E0]
       vmovsd    xmm3,qword ptr [7FFF431CC0E8]
       vmovups   xmm4,[7FFF431CC0F0]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+20]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       lea       r9,[r10+r10*2]
       vmovsd    xmm5,qword ptr [r8+r9*4+10]
       vinsertps xmm5,xmm5,dword ptr [r8+r9*4+18],28
       vmovaps   xmm16,xmm5
       vinsertps xmm16,xmm16,xmm16,3E
       vmovaps   [rsp+30],xmm16
       vmovshdup xmm16,xmm5
       vinsertps xmm16,xmm16,xmm16,1D
       vmovaps   [rsp+40],xmm16
       vunpckhps xmm5,xmm5,xmm5
       vinsertps xmm5,xmm5,xmm5,2B
       vmovaps   [rsp+50],xmm5
       vmovaps   [rsp+60],xmm0
       vmovss    xmm5,dword ptr [rsp+30]
       vmovss    xmm16,dword ptr [rsp+34]
       vmovss    xmm17,dword ptr [rsp+38]
       vmovss    xmm18,dword ptr [rsp+3C]
       vmovss    xmm19,dword ptr [rsp+40]
       vmovss    xmm20,dword ptr [rsp+44]
       vmovss    xmm21,dword ptr [rsp+48]
       vmovss    xmm22,dword ptr [rsp+4C]
       vmovss    xmm23,dword ptr [rsp+50]
       vmovss    xmm24,dword ptr [rsp+54]
       vmovss    xmm25,dword ptr [rsp+58]
       vmovss    xmm26,dword ptr [rsp+5C]
       vmovss    xmm27,dword ptr [rsp+60]
       vmovss    xmm28,dword ptr [rsp+64]
       vmovss    xmm29,dword ptr [rsp+68]
       vmovss    xmm30,dword ptr [rsp+6C]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r11,r10
       shl       r11,4
       vmovups   xmm31,[r8+r11+10]
       vmovaps   xmm6,xmm31
       vaddss    xmm7,xmm6,xmm6
       vmovshdup xmm8,xmm31
       vaddss    xmm9,xmm8,xmm8
       vunpckhps xmm10,xmm31,xmm31
       vaddss    xmm11,xmm10,xmm10
       vshufps   xmm31,xmm31,xmm31,0FF
       vmulss    xmm12,xmm31,xmm7
       vmulss    xmm13,xmm31,xmm9
       vmulss    xmm31,xmm31,xmm11
       vmulss    xmm7,xmm6,xmm7
       vmulss    xmm14,xmm6,xmm11
       vmulss    xmm15,xmm8,xmm9
       vmulss    xmm8,xmm8,xmm11
       vmulss    xmm10,xmm10,xmm11
       vsubss    xmm11,xmm1,xmm15
       vsubss    xmm11,xmm11,xmm10
       vmulss    xmm6,xmm6,xmm9
       vsubss    xmm9,xmm6,xmm31
       vaddss    xmm0,xmm14,xmm13
       vaddss    xmm31,xmm6,xmm31
       vsubss    xmm6,xmm1,xmm7
       vsubss    xmm7,xmm6,xmm10
       vsubss    xmm10,xmm8,xmm12
       vsubss    xmm13,xmm14,xmm13
       vaddss    xmm8,xmm8,xmm12
       vsubss    xmm6,xmm6,xmm15
       vmulss    xmm12,xmm5,xmm11
       vmulss    xmm14,xmm16,xmm9
       vaddss    xmm12,xmm12,xmm14
       vmulss    xmm14,xmm17,xmm0
       vaddss    xmm12,xmm12,xmm14
       vmulss    xmm14,xmm5,xmm31
       vmulss    xmm15,xmm16,xmm7
       vaddss    xmm14,xmm14,xmm15
       vmulss    xmm15,xmm17,xmm10
       vaddss    xmm14,xmm14,xmm15
       vinsertps xmm12,xmm12,xmm14,10
       vmulss    xmm5,xmm5,xmm13
       vmulss    xmm16,xmm16,xmm8
       vaddss    xmm5,xmm5,xmm16
       vmulss    xmm16,xmm17,xmm6
       vaddss    xmm5,xmm5,xmm16
       vinsertps xmm5,xmm12,xmm5,20
       vinsertps xmm5,xmm5,xmm18,30
       vmulss    xmm16,xmm19,xmm11
       vmulss    xmm17,xmm20,xmm9
       vaddss    xmm16,xmm16,xmm17
       vmulss    xmm17,xmm21,xmm0
       vaddss    xmm16,xmm16,xmm17
       vmulss    xmm17,xmm19,xmm31
       vmulss    xmm18,xmm20,xmm7
       vaddss    xmm17,xmm17,xmm18
       vmulss    xmm18,xmm21,xmm10
       vaddss    xmm17,xmm17,xmm18
       vinsertps xmm16,xmm16,xmm17,10
       vmulss    xmm17,xmm19,xmm13
       vmulss    xmm18,xmm20,xmm8
       vaddss    xmm17,xmm17,xmm18
       vmulss    xmm18,xmm21,xmm6
       vaddss    xmm17,xmm17,xmm18
       vinsertps xmm16,xmm16,xmm17,20
       vinsertps xmm16,xmm16,xmm22,30
       vmulss    xmm17,xmm23,xmm11
       vmulss    xmm18,xmm24,xmm9
       vaddss    xmm17,xmm17,xmm18
       vmulss    xmm18,xmm25,xmm0
       vaddss    xmm17,xmm17,xmm18
       vmulss    xmm18,xmm23,xmm31
       vmulss    xmm19,xmm24,xmm7
       vaddss    xmm18,xmm18,xmm19
       vmulss    xmm19,xmm25,xmm10
       vaddss    xmm18,xmm18,xmm19
       vinsertps xmm17,xmm17,xmm18,10
       vmulss    xmm18,xmm23,xmm13
       vmulss    xmm19,xmm24,xmm8
       vaddss    xmm18,xmm18,xmm19
       vmulss    xmm19,xmm25,xmm6
       vaddss    xmm18,xmm18,xmm19
       vinsertps xmm17,xmm17,xmm18,20
       vinsertps xmm17,xmm17,xmm26,30
       vmulss    xmm18,xmm27,xmm11
       vmulss    xmm19,xmm28,xmm9
       vaddss    xmm18,xmm18,xmm19
       vmulss    xmm0,xmm29,xmm0
       vaddss    xmm0,xmm18,xmm0
       vmulss    xmm18,xmm27,xmm31
       vmulss    xmm19,xmm28,xmm7
       vaddss    xmm18,xmm18,xmm19
       vmulss    xmm19,xmm29,xmm10
       vaddss    xmm18,xmm18,xmm19
       vinsertps xmm0,xmm0,xmm18,10
       vmulss    xmm18,xmm27,xmm13
       vmulss    xmm19,xmm28,xmm8
       vaddss    xmm18,xmm18,xmm19
       vmulss    xmm19,xmm29,xmm6
       vaddss    xmm18,xmm18,xmm19
       vinsertps xmm0,xmm0,xmm18,20
       vinsertps xmm0,xmm0,xmm30,30
       mov       r8,[rcx+28]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       vmovsd    xmm18,qword ptr [r8+r9*4+10]
       vinsertps xmm18,xmm18,dword ptr [r8+r9*4+18],28
       vmovaps   xmm19,xmm2
       vmovaps   xmm20,xmm3
       vmovaps   xmm21,xmm4
       vinsertps xmm18,xmm18,xmm1,30
       vunpckhps xmm22,xmm5,xmm5
       vbroadcastss xmm22,xmm22
       vmovshdup xmm23,xmm5
       vbroadcastss xmm23,xmm23
       vmovaps   xmm24,xmm5
       vbroadcastss xmm24,xmm24
       vmulps    xmm24,xmm24,xmm19
       vfmadd231ps xmm24,xmm23,xmm20
       vfmadd231ps xmm24,xmm22,xmm21
       vshufps   xmm5,xmm5,xmm5,0FF
       vbroadcastss xmm5,xmm5
       vfmadd231ps xmm24,xmm5,xmm18
       vunpckhps xmm5,xmm16,xmm16
       vbroadcastss xmm5,xmm5
       vmovshdup xmm22,xmm16
       vbroadcastss xmm22,xmm22
       vmovaps   xmm23,xmm16
       vbroadcastss xmm23,xmm23
       vmulps    xmm23,xmm23,xmm19
       vfmadd231ps xmm23,xmm22,xmm20
       vfmadd231ps xmm23,xmm5,xmm21
       vshufps   xmm5,xmm16,xmm16,0FF
       vbroadcastss xmm5,xmm5
       vfmadd231ps xmm23,xmm5,xmm18
       vunpckhps xmm5,xmm17,xmm17
       vbroadcastss xmm5,xmm5
       vmovshdup xmm16,xmm17
       vbroadcastss xmm16,xmm16
       vmovaps   xmm22,xmm17
       vbroadcastss xmm22,xmm22
       vmulps    xmm22,xmm22,xmm19
       vfmadd231ps xmm22,xmm16,xmm20
       vfmadd231ps xmm22,xmm5,xmm21
       vshufps   xmm5,xmm17,xmm17,0FF
       vbroadcastss xmm5,xmm5
       vfmadd231ps xmm22,xmm5,xmm18
       vunpckhps xmm5,xmm0,xmm0
       vbroadcastss xmm5,xmm5
       vmovshdup xmm16,xmm0
       vbroadcastss xmm16,xmm16
       vmovaps   xmm17,xmm0
       vbroadcastss xmm17,xmm17
       vmulps    xmm17,xmm17,xmm19
       vfmadd213ps xmm20,xmm16,xmm17
       vfmadd213ps xmm21,xmm5,xmm20
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd213ps xmm18,xmm0,xmm21
       cmp       eax,[rdx+8]
       jae       near ptr M00_L01
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm24
       vmovups   [rdx+10],xmm23
       vmovups   [rdx+20],xmm22
       vmovups   [rdx+30],xmm18
       inc       eax
       cmp       eax,186A0
       vmovaps   xmm0,[rsp+20]
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+100]
       vmovaps   xmm7,[rsp+0F0]
       vmovaps   xmm8,[rsp+0E0]
       vmovaps   xmm9,[rsp+0D0]
       vmovaps   xmm10,[rsp+0C0]
       vmovaps   xmm11,[rsp+0B0]
       vmovaps   xmm12,[rsp+0A0]
       vmovaps   xmm13,[rsp+90]
       vmovaps   xmm14,[rsp+80]
       vmovaps   xmm15,[rsp+70]
       add       rsp,118
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1476
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4x4.Multiply()
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
       shl       r11,6
       lea       r10,[r10+r11+10]
       vmovups   xmm0,[r10]
       vmovups   xmm1,[r10+10]
       vmovups   xmm2,[r10+20]
       vmovups   xmm3,[r10+30]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L01
       mov       r9d,r10d
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm16,[r8+20]
       vmovups   xmm17,[r8+30]
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
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],xmm20
       vmovups   [rax+10],xmm19
       vmovups   [rax+20],xmm18
       vmovups   [rax+30],xmm17
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 436
```

