## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4WithQuaternion`1[[System.Single, System.Private.CoreLib]].Rotation()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       mov       rbx,rcx
       xor       esi,esi
M00_L00:
       mov       rdi,[rbx+10]
       mov       rdx,[rbx+28]
       cmp       esi,[rdx+8]
       jae       short M00_L01
       mov       rcx,rsi
       shl       rcx,4
       vmovups   xmm0,[rdx+rcx+10]
       vmovups   [rsp+20],xmm0
       lea       rdx,[rsp+20]
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF43564D68]; Silk.NET.Maths.Matrix4X4.CreateFromQuaternion[[System.Single, System.Private.CoreLib]](Silk.NET.Maths.Quaternion`1<Single>)
       cmp       esi,[rdi+8]
       jae       short M00_L01
       mov       rax,rsi
       shl       rax,6
       vmovdqu32 zmm0,[rsp+30]
       vmovdqu32 [rdi+rax+10],zmm0
       inc       esi
       cmp       esi,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```
```assembly
; Silk.NET.Maths.Matrix4X4.CreateFromQuaternion[[System.Single, System.Private.CoreLib]](Silk.NET.Maths.Quaternion`1<Single>)
       sub       rsp,48
       vmovss    xmm0,dword ptr [rdx]
       vmovss    xmm1,dword ptr [rdx+4]
       vmovss    xmm2,dword ptr [rdx+8]
       vmovss    xmm3,dword ptr [rdx+0C]
       mov       rax,2D957F88D28
       vmovdqu32 zmm4,[rax]
       vmovdqu32 [rsp+8],zmm4
       vmulss    xmm4,xmm0,xmm0
       vmulss    xmm5,xmm1,xmm1
       vmulss    xmm16,xmm2,xmm2
       vmulss    xmm17,xmm0,xmm1
       vmulss    xmm18,xmm2,xmm3
       vmulss    xmm19,xmm2,xmm0
       vmulss    xmm20,xmm1,xmm3
       vmulss    xmm1,xmm1,xmm2
       vmulss    xmm0,xmm0,xmm3
       vmovdqu32 zmm2,[rsp+8]
       vmovdqu32 [rcx],zmm2
       vaddss    xmm2,xmm5,xmm16
       vmovss    xmm3,dword ptr [7FFF431BBAF0]
       vmulss    xmm2,xmm2,xmm3
       vmovss    xmm21,dword ptr [7FFF431BBAF4]
       vsubss    xmm2,xmm21,xmm2
       vmovss    dword ptr [rcx],xmm2
       vaddss    xmm2,xmm17,xmm18
       vmulss    xmm2,xmm2,xmm3
       vmovss    dword ptr [rcx+4],xmm2
       vsubss    xmm2,xmm19,xmm20
       vmulss    xmm2,xmm2,xmm3
       vmovss    dword ptr [rcx+8],xmm2
       vsubss    xmm2,xmm17,xmm18
       vmulss    xmm2,xmm2,xmm3
       vmovss    dword ptr [rcx+10],xmm2
       vaddss    xmm2,xmm16,xmm4
       vmulss    xmm2,xmm2,xmm3
       vsubss    xmm2,xmm21,xmm2
       vmovss    dword ptr [rcx+14],xmm2
       vaddss    xmm2,xmm1,xmm0
       vmulss    xmm2,xmm2,xmm3
       vmovss    dword ptr [rcx+18],xmm2
       vaddss    xmm2,xmm19,xmm20
       vmulss    xmm2,xmm2,xmm3
       vmovss    dword ptr [rcx+20],xmm2
       vsubss    xmm0,xmm1,xmm0
       vmulss    xmm0,xmm0,xmm3
       vmovss    dword ptr [rcx+24],xmm0
       vaddss    xmm0,xmm5,xmm4
       vmulss    xmm0,xmm0,xmm3
       vsubss    xmm0,xmm21,xmm0
       vmovss    dword ptr [rcx+28],xmm0
       mov       rax,rcx
       vzeroupper
       add       rsp,48
       ret
; Total bytes of code 288
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4WithQuaternion`1[[System.Single, System.Private.CoreLib]].Transform()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       mov       rbx,rcx
       xor       esi,esi
M00_L00:
       mov       rdi,[rbx+10]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M00_L01
       mov       rbp,rsi
       shl       rbp,6
       vmovdqu32 zmm0,[rdx+rbp+10]
       vmovdqu32 [rsp+38],zmm0
       mov       rdx,[rbx+28]
       cmp       esi,[rdx+8]
       jae       short M00_L01
       mov       r8,rsi
       shl       r8,4
       vmovups   xmm0,[rdx+r8+10]
       vmovups   [rsp+28],xmm0
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       lea       rcx,[rsp+78]
       call      qword ptr [7FFF43574CA8]; Silk.NET.Maths.Matrix4X4.Transform[[System.Single, System.Private.CoreLib]](Silk.NET.Maths.Matrix4X4`1<Single>, Silk.NET.Maths.Quaternion`1<Single>)
       cmp       esi,[rdi+8]
       jae       short M00_L01
       vmovdqu32 zmm0,[rsp+78]
       vmovdqu32 [rdi+rbp+10],zmm0
       inc       esi
       cmp       esi,186A0
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 174
```
```assembly
; Silk.NET.Maths.Matrix4X4.Transform[[System.Single, System.Private.CoreLib]](Silk.NET.Maths.Matrix4X4`1<Single>, Silk.NET.Maths.Quaternion`1<Single>)
       sub       rsp,18
       vmovaps   [rsp],xmm6
       vmovss    xmm0,dword ptr [r8]
       vmovss    xmm1,dword ptr [r8+4]
       vmovss    xmm2,dword ptr [r8+8]
       vmovss    xmm3,dword ptr [r8+0C]
       vaddss    xmm4,xmm0,xmm0
       vaddss    xmm5,xmm1,xmm1
       vaddss    xmm16,xmm2,xmm2
       vmulss    xmm17,xmm3,xmm4
       vmulss    xmm18,xmm3,xmm5
       vmulss    xmm3,xmm3,xmm16
       vmulss    xmm4,xmm0,xmm4
       vmulss    xmm19,xmm0,xmm5
       vmulss    xmm0,xmm0,xmm16
       vmulss    xmm5,xmm1,xmm5
       vmulss    xmm1,xmm1,xmm16
       vmulss    xmm2,xmm2,xmm16
       vmovss    xmm16,dword ptr [7FFF431CA8A0]
       vsubss    xmm16,xmm16,xmm5
       vsubss    xmm16,xmm16,xmm2
       vsubss    xmm20,xmm19,xmm3
       vaddss    xmm21,xmm0,xmm18
       vaddss    xmm3,xmm19,xmm3
       vmovss    xmm19,dword ptr [7FFF431CA8A0]
       vsubss    xmm4,xmm19,xmm4
       vsubss    xmm2,xmm4,xmm2
       vsubss    xmm19,xmm1,xmm17
       vsubss    xmm0,xmm0,xmm18
       vaddss    xmm1,xmm1,xmm17
       vsubss    xmm4,xmm4,xmm5
       vmovss    xmm5,dword ptr [rdx]
       vmulss    xmm17,xmm16,xmm5
       vmulss    xmm18,xmm3,xmm5
       vmulss    xmm5,xmm0,xmm5
       vmovss    xmm22,dword ptr [rdx+4]
       vmulss    xmm23,xmm20,xmm22
       vmulss    xmm24,xmm2,xmm22
       vmulss    xmm22,xmm1,xmm22
       vaddss    xmm17,xmm17,xmm23
       vaddss    xmm18,xmm18,xmm24
       vaddss    xmm5,xmm5,xmm22
       vmovss    xmm22,dword ptr [rdx+8]
       vmulss    xmm23,xmm21,xmm22
       vmulss    xmm24,xmm19,xmm22
       vmulss    xmm22,xmm4,xmm22
       vaddss    xmm17,xmm17,xmm23
       vaddss    xmm18,xmm18,xmm24
       vaddss    xmm5,xmm5,xmm22
       vmovss    xmm22,dword ptr [rdx+0C]
       vmovss    xmm23,dword ptr [rdx+10]
       vmulss    xmm24,xmm16,xmm23
       vmulss    xmm25,xmm3,xmm23
       vmulss    xmm23,xmm0,xmm23
       vmovss    xmm26,dword ptr [rdx+14]
       vmulss    xmm27,xmm20,xmm26
       vmulss    xmm28,xmm2,xmm26
       vmulss    xmm26,xmm1,xmm26
       vaddss    xmm24,xmm24,xmm27
       vaddss    xmm25,xmm25,xmm28
       vaddss    xmm23,xmm23,xmm26
       vmovss    xmm26,dword ptr [rdx+18]
       vmulss    xmm27,xmm21,xmm26
       vmulss    xmm28,xmm19,xmm26
       vmulss    xmm26,xmm4,xmm26
       vaddss    xmm24,xmm24,xmm27
       vaddss    xmm25,xmm25,xmm28
       vaddss    xmm23,xmm23,xmm26
       vmovss    xmm26,dword ptr [rdx+1C]
       vmovss    xmm27,dword ptr [rdx+20]
       vmulss    xmm28,xmm16,xmm27
       vmulss    xmm29,xmm3,xmm27
       vmulss    xmm27,xmm0,xmm27
       vmovss    xmm30,dword ptr [rdx+24]
       vmulss    xmm31,xmm20,xmm30
       vmulss    xmm6,xmm2,xmm30
       vmulss    xmm30,xmm1,xmm30
       vaddss    xmm28,xmm28,xmm31
       vaddss    xmm29,xmm29,xmm6
       vaddss    xmm27,xmm27,xmm30
       vmovss    xmm30,dword ptr [rdx+28]
       vmulss    xmm31,xmm21,xmm30
       vmulss    xmm6,xmm19,xmm30
       vmulss    xmm30,xmm4,xmm30
       vaddss    xmm28,xmm28,xmm31
       vaddss    xmm29,xmm29,xmm6
       vaddss    xmm27,xmm27,xmm30
       vmovss    xmm30,dword ptr [rdx+2C]
       vmovss    xmm31,dword ptr [rdx+30]
       vmulss    xmm16,xmm16,xmm31
       vmulss    xmm3,xmm3,xmm31
       vmulss    xmm0,xmm0,xmm31
       vmovss    xmm31,dword ptr [rdx+34]
       vmulss    xmm20,xmm20,xmm31
       vmulss    xmm2,xmm2,xmm31
       vmulss    xmm1,xmm1,xmm31
       vaddss    xmm16,xmm16,xmm20
       vaddss    xmm2,xmm3,xmm2
       vaddss    xmm0,xmm0,xmm1
       vmovss    xmm1,dword ptr [rdx+38]
       vmulss    xmm3,xmm21,xmm1
       vmulss    xmm19,xmm19,xmm1
       vmulss    xmm1,xmm4,xmm1
       vaddss    xmm3,xmm16,xmm3
       vaddss    xmm2,xmm2,xmm19
       vaddss    xmm0,xmm0,xmm1
       vmovss    xmm1,dword ptr [rdx+3C]
       vmovss    dword ptr [rcx],xmm17
       vmovss    dword ptr [rcx+4],xmm18
       vmovss    dword ptr [rcx+8],xmm5
       vmovss    dword ptr [rcx+0C],xmm22
       vmovss    dword ptr [rcx+10],xmm24
       vmovss    dword ptr [rcx+14],xmm25
       vmovss    dword ptr [rcx+18],xmm23
       vmovss    dword ptr [rcx+1C],xmm26
       vmovss    dword ptr [rcx+20],xmm28
       vmovss    dword ptr [rcx+24],xmm29
       vmovss    dword ptr [rcx+28],xmm27
       vmovss    dword ptr [rcx+2C],xmm30
       vmovss    dword ptr [rcx+30],xmm3
       vmovss    dword ptr [rcx+34],xmm2
       vmovss    dword ptr [rcx+38],xmm0
       vmovss    dword ptr [rcx+3C],xmm1
       mov       rax,rcx
       vmovaps   xmm6,[rsp]
       add       rsp,18
       ret
; Total bytes of code 747
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4WithQuaternion`1[[System.Single, System.Private.CoreLib]].Affine()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,318
       vmovaps   [rsp+300],xmm6
       vmovaps   [rsp+2F0],xmm7
       vmovaps   [rsp+2E0],xmm8
       vmovaps   [rsp+2D0],xmm9
       vmovaps   [rsp+2C0],xmm10
       vmovaps   [rsp+2B0],xmm11
       vmovaps   [rsp+2A0],xmm12
       vmovaps   [rsp+290],xmm13
       vmovaps   [rsp+280],xmm14
       vmovaps   [rsp+270],xmm15
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rsp+1B0],zmm4
       mov       rbx,rcx
       xor       esi,esi
M00_L00:
       mov       rdi,[rbx+10]
       mov       r8,[rbx+18]
       cmp       esi,[r8+8]
       jae       near ptr M00_L01
       lea       rbp,[rsi+rsi*2]
       lea       r8,[r8+rbp*4+10]
       vmovss    xmm0,dword ptr [r8]
       vmovss    xmm1,dword ptr [r8+4]
       vmovss    xmm2,dword ptr [r8+8]
       mov       r8,24FCA7D8D28
       vmovdqu32 zmm3,[r8]
       vmovdqu32 [rsp+1B0],zmm3
       vmovss    dword ptr [rsp+1B0],xmm0
       vmovss    dword ptr [rsp+1C4],xmm1
       vmovss    dword ptr [rsp+1D8],xmm2
       mov       r8,[rbx+28]
       cmp       esi,[r8+8]
       jae       near ptr M00_L01
       mov       rdx,rsi
       shl       rdx,4
       vmovups   xmm0,[r8+rdx+10]
       vmovups   [rsp+40],xmm0
       lea       r8,[rsp+40]
       lea       rdx,[rsp+1B0]
       lea       rcx,[rsp+230]
       call      qword ptr [7FFF43554DB0]; Silk.NET.Maths.Matrix4X4.Transform[[System.Single, System.Private.CoreLib]](Silk.NET.Maths.Matrix4X4`1<Single>, Silk.NET.Maths.Quaternion`1<Single>)
       mov       rax,[rbx+20]
       cmp       esi,[rax+8]
       jae       near ptr M00_L01
       lea       rax,[rax+rbp*4+10]
       vmovss    xmm6,dword ptr [rax]
       vmovss    xmm7,dword ptr [rax+4]
       vmovss    xmm8,dword ptr [rax+8]
       vmovups   ymm0,[7FFF431B0F00]
       vmovups   [rsp+200],ymm0
       vmovss    xmm0,dword ptr [rsp+230]
       vmovss    xmm1,dword ptr [rsp+234]
       vmovss    xmm2,dword ptr [rsp+238]
       vmovss    xmm3,dword ptr [rsp+23C]
       vmovss    xmm4,dword ptr [rsp+240]
       vmovss    xmm5,dword ptr [rsp+244]
       vmovss    xmm16,dword ptr [rsp+248]
       vmovss    xmm17,dword ptr [rsp+24C]
       vmovss    xmm9,dword ptr [rsp+250]
       vmovss    xmm10,dword ptr [rsp+254]
       vmovss    xmm11,dword ptr [rsp+258]
       vmovss    xmm12,dword ptr [rsp+25C]
       vmovss    xmm13,dword ptr [rsp+260]
       vmovss    xmm14,dword ptr [rsp+264]
       vmovss    xmm15,dword ptr [rsp+268]
       vmovss    xmm18,dword ptr [rsp+26C]
       vmovss    dword ptr [rsp+54],xmm18
       vxorps    xmm19,xmm19,xmm19
       vmulss    xmm19,xmm0,xmm19
       vmovaps   xmm20,xmm19
       vmovss    xmm21,dword ptr [rsp+200]
       vmovss    xmm22,dword ptr [rsp+204]
       vmovss    xmm23,dword ptr [rsp+208]
       vmovss    xmm24,dword ptr [rsp+20C]
       vmulss    xmm21,xmm21,xmm1
       vmulss    xmm22,xmm22,xmm1
       vmulss    xmm23,xmm23,xmm1
       vmulss    xmm1,xmm24,xmm1
       vaddss    xmm0,xmm0,xmm21
       vaddss    xmm20,xmm20,xmm22
       vaddss    xmm21,xmm19,xmm23
       vaddss    xmm1,xmm19,xmm1
       vmovss    xmm19,dword ptr [rsp+210]
       vmovss    xmm22,dword ptr [rsp+214]
       vmovss    xmm23,dword ptr [rsp+218]
       vmovss    xmm24,dword ptr [rsp+21C]
       vmulss    xmm19,xmm19,xmm2
       vmulss    xmm22,xmm22,xmm2
       vmulss    xmm23,xmm23,xmm2
       vmulss    xmm2,xmm24,xmm2
       vaddss    xmm0,xmm0,xmm19
       vaddss    xmm19,xmm20,xmm22
       vaddss    xmm20,xmm21,xmm23
       vaddss    xmm1,xmm1,xmm2
       vmulss    xmm2,xmm6,xmm3
       vmulss    xmm21,xmm7,xmm3
       vmulss    xmm22,xmm8,xmm3
       vaddss    xmm0,xmm0,xmm2
       vmovss    dword ptr [rsp+9C],xmm0
       vaddss    xmm0,xmm19,xmm21
       vmovss    dword ptr [rsp+98],xmm0
       vaddss    xmm0,xmm20,xmm22
       vmovss    dword ptr [rsp+94],xmm0
       vaddss    xmm0,xmm1,xmm3
       vmovss    dword ptr [rsp+90],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmulss    xmm0,xmm4,xmm0
       vmovaps   xmm1,xmm0
       vmovss    xmm21,dword ptr [rsp+200]
       vmovss    xmm22,dword ptr [rsp+204]
       vmovss    xmm23,dword ptr [rsp+208]
       vmovss    xmm24,dword ptr [rsp+20C]
       vmulss    xmm21,xmm21,xmm5
       vmulss    xmm22,xmm22,xmm5
       vmulss    xmm23,xmm23,xmm5
       vmulss    xmm5,xmm24,xmm5
       vaddss    xmm4,xmm4,xmm21
       vaddss    xmm1,xmm1,xmm22
       vaddss    xmm21,xmm0,xmm23
       vaddss    xmm0,xmm0,xmm5
       vmovss    xmm5,dword ptr [rsp+210]
       vmovss    xmm22,dword ptr [rsp+214]
       vmovss    xmm23,dword ptr [rsp+218]
       vmovss    xmm24,dword ptr [rsp+21C]
       vmulss    xmm5,xmm5,xmm16
       vmulss    xmm22,xmm22,xmm16
       vmulss    xmm23,xmm23,xmm16
       vmulss    xmm16,xmm24,xmm16
       vaddss    xmm4,xmm4,xmm5
       vaddss    xmm1,xmm1,xmm22
       vaddss    xmm5,xmm21,xmm23
       vaddss    xmm0,xmm0,xmm16
       vmulss    xmm16,xmm6,xmm17
       vmulss    xmm21,xmm7,xmm17
       vmulss    xmm22,xmm8,xmm17
       vaddss    xmm4,xmm4,xmm16
       vmovss    dword ptr [rsp+8C],xmm4
       vaddss    xmm1,xmm1,xmm21
       vmovss    dword ptr [rsp+88],xmm1
       vaddss    xmm1,xmm5,xmm22
       vmovss    dword ptr [rsp+84],xmm1
       vaddss    xmm0,xmm0,xmm17
       vmovss    dword ptr [rsp+80],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmulss    xmm0,xmm9,xmm0
       vmovss    dword ptr [rsp+7C],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovaps   xmm1,xmm9
       call      qword ptr [7FFF43555368]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovss    dword ptr [rsp+78],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+68],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovaps   xmm1,xmm9
       call      qword ptr [7FFF43555368]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovss    dword ptr [rsp+20],xmm0
       lea       rcx,[rsp+68]
       vmovaps   xmm1,xmm9
       vmovss    xmm2,dword ptr [rsp+7C]
       vmovss    xmm3,dword ptr [rsp+78]
       call      qword ptr [7FFF435552D8]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]]..ctor(Single, Single, Single, Single)
       vmovups   xmm2,[rsp+68]
       vmovups   [rsp+1A0],xmm2
       vmovups   xmm2,[rsp+200]
       vmovups   [rsp+30],xmm2
       lea       rdx,[rsp+30]
       lea       rcx,[rsp+190]
       vmovaps   xmm2,xmm10
       call      qword ptr [7FFF43555950]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+180]
       lea       rdx,[rsp+1A0]
       lea       r8,[rsp+190]
       call      qword ptr [7FFF43555908]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovups   xmm2,[rsp+210]
       vmovups   [rsp+30],xmm2
       lea       rdx,[rsp+30]
       lea       rcx,[rsp+170]
       vmovaps   xmm2,xmm11
       call      qword ptr [7FFF43555950]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+160]
       lea       rdx,[rsp+180]
       lea       r8,[rsp+170]
       call      qword ptr [7FFF43555908]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovaps   xmm0,xmm6
       vmovaps   xmm1,xmm12
       call      qword ptr [7FFF43555368]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm9,xmm0
       vmovaps   xmm0,xmm7
       vmovaps   xmm1,xmm12
       call      qword ptr [7FFF43555368]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm10,xmm0
       vmovaps   xmm0,xmm8
       vmovaps   xmm1,xmm12
       call      qword ptr [7FFF43555368]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm11,xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+58],xmm0
       vmovss    xmm0,dword ptr [7FFF431B0F20]
       vmovaps   xmm1,xmm12
       call      qword ptr [7FFF43555368]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovss    dword ptr [rsp+20],xmm0
       lea       rcx,[rsp+58]
       vmovaps   xmm1,xmm9
       vmovaps   xmm2,xmm10
       vmovaps   xmm3,xmm11
       call      qword ptr [7FFF435552D8]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]]..ctor(Single, Single, Single, Single)
       vmovups   xmm0,[rsp+58]
       vmovups   [rsp+30],xmm0
       lea       r8,[rsp+30]
       lea       rdx,[rsp+160]
       lea       rcx,[rsp+150]
       call      qword ptr [7FFF43555908]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       mov       dword ptr [rsp+1F0],3F800000
       xor       edx,edx
       mov       [rsp+1F4],edx
       mov       [rsp+1F8],edx
       mov       [rsp+1FC],edx
       vmovups   xmm2,[rsp+1F0]
       vmovups   [rsp+30],xmm2
       lea       rdx,[rsp+30]
       lea       rcx,[rsp+140]
       vmovaps   xmm2,xmm13
       call      qword ptr [7FFF43555950]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       vmovups   xmm2,[rsp+200]
       vmovups   [rsp+30],xmm2
       lea       rdx,[rsp+30]
       lea       rcx,[rsp+130]
       vmovaps   xmm2,xmm14
       call      qword ptr [7FFF43555950]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+120]
       lea       rdx,[rsp+140]
       lea       r8,[rsp+130]
       call      qword ptr [7FFF43555908]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       lea       rcx,[rsp+110]
       lea       rdx,[rsp+210]
       vmovaps   xmm2,xmm15
       call      qword ptr [7FFF43555950]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+100]
       lea       rdx,[rsp+120]
       lea       r8,[rsp+110]
       call      qword ptr [7FFF43555908]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovss    dword ptr [rsp+220],xmm6
       vmovss    dword ptr [rsp+224],xmm7
       vmovss    dword ptr [rsp+228],xmm8
       mov       dword ptr [rsp+22C],3F800000
       lea       rcx,[rsp+0F0]
       lea       rdx,[rsp+220]
       vmovss    xmm2,dword ptr [rsp+54]
       call      qword ptr [7FFF43555950]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rsp+0D0],ymm0
       lea       rcx,[rsp+0A0]
       lea       rdx,[rsp+100]
       lea       r8,[rsp+0F0]
       call      qword ptr [7FFF43555908]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovups   xmm0,[rsp+150]
       vmovups   [rsp+0D0],xmm0
       vmovups   xmm0,[rsp+0A0]
       vmovups   [rsp+0E0],xmm0
       cmp       esi,[rdi+8]
       jae       near ptr M00_L01
       mov       rax,rsi
       shl       rax,6
       lea       rax,[rdi+rax+10]
       vmovss    xmm6,dword ptr [rsp+9C]
       vmovss    dword ptr [rax],xmm6
       vmovss    xmm6,dword ptr [rsp+98]
       vmovss    dword ptr [rax+4],xmm6
       vmovss    xmm6,dword ptr [rsp+94]
       vmovss    dword ptr [rax+8],xmm6
       vmovss    xmm6,dword ptr [rsp+90]
       vmovss    dword ptr [rax+0C],xmm6
       vmovss    xmm6,dword ptr [rsp+8C]
       vmovss    dword ptr [rax+10],xmm6
       vmovss    xmm6,dword ptr [rsp+88]
       vmovss    dword ptr [rax+14],xmm6
       vmovss    xmm6,dword ptr [rsp+84]
       vmovss    dword ptr [rax+18],xmm6
       vmovss    xmm6,dword ptr [rsp+80]
       vmovss    dword ptr [rax+1C],xmm6
       vmovups   ymm0,[rsp+0D0]
       vmovups   [rax+20],ymm0
       inc       esi
       cmp       esi,186A0
       jl        near ptr M00_L00
       vzeroupper
       vmovaps   xmm6,[rsp+300]
       vmovaps   xmm7,[rsp+2F0]
       vmovaps   xmm8,[rsp+2E0]
       vmovaps   xmm9,[rsp+2D0]
       vmovaps   xmm10,[rsp+2C0]
       vmovaps   xmm11,[rsp+2B0]
       vmovaps   xmm12,[rsp+2A0]
       vmovaps   xmm13,[rsp+290]
       vmovaps   xmm14,[rsp+280]
       vmovaps   xmm15,[rsp+270]
       add       rsp,318
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1998
```
```assembly
; Silk.NET.Maths.Matrix4X4.Transform[[System.Single, System.Private.CoreLib]](Silk.NET.Maths.Matrix4X4`1<Single>, Silk.NET.Maths.Quaternion`1<Single>)
       sub       rsp,18
       vmovaps   [rsp],xmm6
       vmovss    xmm0,dword ptr [r8]
       vmovss    xmm1,dword ptr [r8+4]
       vmovss    xmm2,dword ptr [r8+8]
       vmovss    xmm3,dword ptr [r8+0C]
       vaddss    xmm4,xmm0,xmm0
       vaddss    xmm5,xmm1,xmm1
       vaddss    xmm16,xmm2,xmm2
       vmulss    xmm17,xmm3,xmm4
       vmulss    xmm18,xmm3,xmm5
       vmulss    xmm3,xmm3,xmm16
       vmulss    xmm4,xmm0,xmm4
       vmulss    xmm19,xmm0,xmm5
       vmulss    xmm0,xmm0,xmm16
       vmulss    xmm5,xmm1,xmm5
       vmulss    xmm1,xmm1,xmm16
       vmulss    xmm2,xmm2,xmm16
       vmovss    xmm16,dword ptr [7FFF431AC070]
       vsubss    xmm16,xmm16,xmm5
       vsubss    xmm16,xmm16,xmm2
       vsubss    xmm20,xmm19,xmm3
       vaddss    xmm21,xmm0,xmm18
       vaddss    xmm3,xmm19,xmm3
       vmovss    xmm19,dword ptr [7FFF431AC070]
       vsubss    xmm4,xmm19,xmm4
       vsubss    xmm2,xmm4,xmm2
       vsubss    xmm19,xmm1,xmm17
       vsubss    xmm0,xmm0,xmm18
       vaddss    xmm1,xmm1,xmm17
       vsubss    xmm4,xmm4,xmm5
       vmovss    xmm5,dword ptr [rdx]
       vmulss    xmm17,xmm16,xmm5
       vmulss    xmm18,xmm3,xmm5
       vmulss    xmm5,xmm0,xmm5
       vmovss    xmm22,dword ptr [rdx+4]
       vmulss    xmm23,xmm20,xmm22
       vmulss    xmm24,xmm2,xmm22
       vmulss    xmm22,xmm1,xmm22
       vaddss    xmm17,xmm17,xmm23
       vaddss    xmm18,xmm18,xmm24
       vaddss    xmm5,xmm5,xmm22
       vmovss    xmm22,dword ptr [rdx+8]
       vmulss    xmm23,xmm21,xmm22
       vmulss    xmm24,xmm19,xmm22
       vmulss    xmm22,xmm4,xmm22
       vaddss    xmm17,xmm17,xmm23
       vaddss    xmm18,xmm18,xmm24
       vaddss    xmm5,xmm5,xmm22
       vmovss    xmm22,dword ptr [rdx+0C]
       vmovss    xmm23,dword ptr [rdx+10]
       vmulss    xmm24,xmm16,xmm23
       vmulss    xmm25,xmm3,xmm23
       vmulss    xmm23,xmm0,xmm23
       vmovss    xmm26,dword ptr [rdx+14]
       vmulss    xmm27,xmm20,xmm26
       vmulss    xmm28,xmm2,xmm26
       vmulss    xmm26,xmm1,xmm26
       vaddss    xmm24,xmm24,xmm27
       vaddss    xmm25,xmm25,xmm28
       vaddss    xmm23,xmm23,xmm26
       vmovss    xmm26,dword ptr [rdx+18]
       vmulss    xmm27,xmm21,xmm26
       vmulss    xmm28,xmm19,xmm26
       vmulss    xmm26,xmm4,xmm26
       vaddss    xmm24,xmm24,xmm27
       vaddss    xmm25,xmm25,xmm28
       vaddss    xmm23,xmm23,xmm26
       vmovss    xmm26,dword ptr [rdx+1C]
       vmovss    xmm27,dword ptr [rdx+20]
       vmulss    xmm28,xmm16,xmm27
       vmulss    xmm29,xmm3,xmm27
       vmulss    xmm27,xmm0,xmm27
       vmovss    xmm30,dword ptr [rdx+24]
       vmulss    xmm31,xmm20,xmm30
       vmulss    xmm6,xmm2,xmm30
       vmulss    xmm30,xmm1,xmm30
       vaddss    xmm28,xmm28,xmm31
       vaddss    xmm29,xmm29,xmm6
       vaddss    xmm27,xmm27,xmm30
       vmovss    xmm30,dword ptr [rdx+28]
       vmulss    xmm31,xmm21,xmm30
       vmulss    xmm6,xmm19,xmm30
       vmulss    xmm30,xmm4,xmm30
       vaddss    xmm28,xmm28,xmm31
       vaddss    xmm29,xmm29,xmm6
       vaddss    xmm27,xmm27,xmm30
       vmovss    xmm30,dword ptr [rdx+2C]
       vmovss    xmm31,dword ptr [rdx+30]
       vmulss    xmm16,xmm16,xmm31
       vmulss    xmm3,xmm3,xmm31
       vmulss    xmm0,xmm0,xmm31
       vmovss    xmm31,dword ptr [rdx+34]
       vmulss    xmm20,xmm20,xmm31
       vmulss    xmm2,xmm2,xmm31
       vmulss    xmm1,xmm1,xmm31
       vaddss    xmm16,xmm16,xmm20
       vaddss    xmm2,xmm3,xmm2
       vaddss    xmm0,xmm0,xmm1
       vmovss    xmm1,dword ptr [rdx+38]
       vmulss    xmm3,xmm21,xmm1
       vmulss    xmm19,xmm19,xmm1
       vmulss    xmm1,xmm4,xmm1
       vaddss    xmm3,xmm16,xmm3
       vaddss    xmm2,xmm2,xmm19
       vaddss    xmm0,xmm0,xmm1
       vmovss    xmm1,dword ptr [rdx+3C]
       vmovss    dword ptr [rcx],xmm17
       vmovss    dword ptr [rcx+4],xmm18
       vmovss    dword ptr [rcx+8],xmm5
       vmovss    dword ptr [rcx+0C],xmm22
       vmovss    dword ptr [rcx+10],xmm24
       vmovss    dword ptr [rcx+14],xmm25
       vmovss    dword ptr [rcx+18],xmm23
       vmovss    dword ptr [rcx+1C],xmm26
       vmovss    dword ptr [rcx+20],xmm28
       vmovss    dword ptr [rcx+24],xmm29
       vmovss    dword ptr [rcx+28],xmm27
       vmovss    dword ptr [rcx+2C],xmm30
       vmovss    dword ptr [rcx+30],xmm3
       vmovss    dword ptr [rcx+34],xmm2
       vmovss    dword ptr [rcx+38],xmm0
       vmovss    dword ptr [rcx+3C],xmm1
       mov       rax,rcx
       vmovaps   xmm6,[rsp]
       add       rsp,18
       ret
; Total bytes of code 747
```
```assembly
; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmulss    xmm0,xmm0,xmm1
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]]..ctor(Single, Single, Single, Single)
       vmovss    dword ptr [rcx],xmm1
       vmovss    dword ptr [rcx+4],xmm2
       vmovss    dword ptr [rcx+8],xmm3
       vmovss    xmm0,dword ptr [rsp+28]
       vmovss    dword ptr [rcx+0C],xmm0
       ret
; Total bytes of code 26
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       vmulss    xmm0,xmm2,dword ptr [rdx]
       vmulss    xmm1,xmm2,dword ptr [rdx+4]
       vmulss    xmm3,xmm2,dword ptr [rdx+8]
       vmulss    xmm2,xmm2,dword ptr [rdx+0C]
       vmovss    dword ptr [rcx],xmm0
       vmovss    dword ptr [rcx+4],xmm1
       vmovss    dword ptr [rcx+8],xmm3
       vmovss    dword ptr [rcx+0C],xmm2
       mov       rax,rcx
       ret
; Total bytes of code 42
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovss    xmm0,dword ptr [rdx]
       vaddss    xmm0,xmm0,dword ptr [r8]
       vmovss    xmm1,dword ptr [rdx+4]
       vaddss    xmm1,xmm1,dword ptr [r8+4]
       vmovss    xmm2,dword ptr [rdx+8]
       vaddss    xmm2,xmm2,dword ptr [r8+8]
       vmovss    xmm3,dword ptr [rdx+0C]
       vaddss    xmm3,xmm3,dword ptr [r8+0C]
       vmovss    dword ptr [rcx],xmm0
       vmovss    dword ptr [rcx+4],xmm1
       vmovss    dword ptr [rcx+8],xmm2
       vmovss    dword ptr [rcx+0C],xmm3
       mov       rax,rcx
       ret
; Total bytes of code 65
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4`1[[System.Single, System.Private.CoreLib]].Add()
       sub       rsp,0C8
       vmovaps   [rsp+0B0],xmm6
       vmovaps   [rsp+0A0],xmm7
       vmovaps   [rsp+90],xmm8
       vmovaps   [rsp+80],xmm9
       vmovaps   [rsp+70],xmm10
       vmovaps   [rsp+60],xmm11
       vmovaps   [rsp+50],xmm12
       vmovaps   [rsp+40],xmm13
       vmovaps   [rsp+30],xmm14
       vmovaps   [rsp+20],xmm15
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
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       vmovss    xmm4,dword ptr [r10+10]
       vmovss    xmm5,dword ptr [r10+14]
       vmovss    xmm16,dword ptr [r10+18]
       vmovss    xmm17,dword ptr [r10+1C]
       vmovss    xmm18,dword ptr [r10+20]
       vmovss    xmm19,dword ptr [r10+24]
       vmovss    xmm20,dword ptr [r10+28]
       vmovss    xmm21,dword ptr [r10+2C]
       vmovss    xmm22,dword ptr [r10+30]
       vmovss    xmm23,dword ptr [r10+34]
       vmovss    xmm24,dword ptr [r10+38]
       vmovss    xmm25,dword ptr [r10+3C]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L01
       mov       r9d,r10d
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovss    xmm26,dword ptr [r8]
       vmovss    xmm27,dword ptr [r8+4]
       vmovss    xmm28,dword ptr [r8+8]
       vmovss    xmm29,dword ptr [r8+0C]
       vmovss    xmm30,dword ptr [r8+10]
       vmovss    xmm31,dword ptr [r8+14]
       vmovss    xmm6,dword ptr [r8+18]
       vmovss    xmm7,dword ptr [r8+1C]
       vmovss    xmm8,dword ptr [r8+20]
       vmovss    xmm9,dword ptr [r8+24]
       vmovss    xmm10,dword ptr [r8+28]
       vmovss    xmm11,dword ptr [r8+2C]
       vmovss    xmm12,dword ptr [r8+30]
       vmovss    xmm13,dword ptr [r8+34]
       vmovss    xmm14,dword ptr [r8+38]
       vmovss    xmm15,dword ptr [r8+3C]
       vaddss    xmm0,xmm0,xmm26
       vaddss    xmm1,xmm1,xmm27
       vaddss    xmm2,xmm2,xmm28
       vaddss    xmm3,xmm3,xmm29
       vaddss    xmm4,xmm4,xmm30
       vaddss    xmm5,xmm5,xmm31
       vaddss    xmm16,xmm16,xmm6
       vaddss    xmm17,xmm17,xmm7
       vaddss    xmm18,xmm18,xmm8
       vaddss    xmm19,xmm19,xmm9
       vaddss    xmm20,xmm20,xmm10
       vaddss    xmm21,xmm21,xmm11
       vaddss    xmm22,xmm22,xmm12
       vaddss    xmm23,xmm23,xmm13
       vaddss    xmm24,xmm24,xmm14
       vaddss    xmm25,xmm25,xmm15
       cmp       eax,[rdx+8]
       jae       near ptr M00_L01
       lea       rax,[rdx+r11+10]
       vmovss    dword ptr [rax],xmm0
       vmovss    dword ptr [rax+4],xmm1
       vmovss    dword ptr [rax+8],xmm2
       vmovss    dword ptr [rax+0C],xmm3
       vmovss    dword ptr [rax+10],xmm4
       vmovss    dword ptr [rax+14],xmm5
       vmovss    dword ptr [rax+18],xmm16
       vmovss    dword ptr [rax+1C],xmm17
       vmovss    dword ptr [rax+20],xmm18
       vmovss    dword ptr [rax+24],xmm19
       vmovss    dword ptr [rax+28],xmm20
       vmovss    dword ptr [rax+2C],xmm21
       vmovss    dword ptr [rax+30],xmm22
       vmovss    dword ptr [rax+34],xmm23
       vmovss    dword ptr [rax+38],xmm24
       vmovss    dword ptr [rax+3C],xmm25
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+0B0]
       vmovaps   xmm7,[rsp+0A0]
       vmovaps   xmm8,[rsp+90]
       vmovaps   xmm9,[rsp+80]
       vmovaps   xmm10,[rsp+70]
       vmovaps   xmm11,[rsp+60]
       vmovaps   xmm12,[rsp+50]
       vmovaps   xmm13,[rsp+40]
       vmovaps   xmm14,[rsp+30]
       vmovaps   xmm15,[rsp+20]
       add       rsp,0C8
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 649
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4`1[[System.Single, System.Private.CoreLib]].Substract()
       sub       rsp,0C8
       vmovaps   [rsp+0B0],xmm6
       vmovaps   [rsp+0A0],xmm7
       vmovaps   [rsp+90],xmm8
       vmovaps   [rsp+80],xmm9
       vmovaps   [rsp+70],xmm10
       vmovaps   [rsp+60],xmm11
       vmovaps   [rsp+50],xmm12
       vmovaps   [rsp+40],xmm13
       vmovaps   [rsp+30],xmm14
       vmovaps   [rsp+20],xmm15
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
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       vmovss    xmm4,dword ptr [r10+10]
       vmovss    xmm5,dword ptr [r10+14]
       vmovss    xmm16,dword ptr [r10+18]
       vmovss    xmm17,dword ptr [r10+1C]
       vmovss    xmm18,dword ptr [r10+20]
       vmovss    xmm19,dword ptr [r10+24]
       vmovss    xmm20,dword ptr [r10+28]
       vmovss    xmm21,dword ptr [r10+2C]
       vmovss    xmm22,dword ptr [r10+30]
       vmovss    xmm23,dword ptr [r10+34]
       vmovss    xmm24,dword ptr [r10+38]
       vmovss    xmm25,dword ptr [r10+3C]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr M00_L01
       mov       r9d,r10d
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovss    xmm26,dword ptr [r8]
       vmovss    xmm27,dword ptr [r8+4]
       vmovss    xmm28,dword ptr [r8+8]
       vmovss    xmm29,dword ptr [r8+0C]
       vmovss    xmm30,dword ptr [r8+10]
       vmovss    xmm31,dword ptr [r8+14]
       vmovss    xmm6,dword ptr [r8+18]
       vmovss    xmm7,dword ptr [r8+1C]
       vmovss    xmm8,dword ptr [r8+20]
       vmovss    xmm9,dword ptr [r8+24]
       vmovss    xmm10,dword ptr [r8+28]
       vmovss    xmm11,dword ptr [r8+2C]
       vmovss    xmm12,dword ptr [r8+30]
       vmovss    xmm13,dword ptr [r8+34]
       vmovss    xmm14,dword ptr [r8+38]
       vmovss    xmm15,dword ptr [r8+3C]
       vsubss    xmm0,xmm0,xmm26
       vsubss    xmm1,xmm1,xmm27
       vsubss    xmm2,xmm2,xmm28
       vsubss    xmm3,xmm3,xmm29
       vsubss    xmm4,xmm4,xmm30
       vsubss    xmm5,xmm5,xmm31
       vsubss    xmm16,xmm16,xmm6
       vsubss    xmm17,xmm17,xmm7
       vsubss    xmm18,xmm18,xmm8
       vsubss    xmm19,xmm19,xmm9
       vsubss    xmm20,xmm20,xmm10
       vsubss    xmm21,xmm21,xmm11
       vsubss    xmm22,xmm22,xmm12
       vsubss    xmm23,xmm23,xmm13
       vsubss    xmm24,xmm24,xmm14
       vsubss    xmm25,xmm25,xmm15
       cmp       eax,[rdx+8]
       jae       near ptr M00_L01
       lea       rax,[rdx+r11+10]
       vmovss    dword ptr [rax],xmm0
       vmovss    dword ptr [rax+4],xmm1
       vmovss    dword ptr [rax+8],xmm2
       vmovss    dword ptr [rax+0C],xmm3
       vmovss    dword ptr [rax+10],xmm4
       vmovss    dword ptr [rax+14],xmm5
       vmovss    dword ptr [rax+18],xmm16
       vmovss    dword ptr [rax+1C],xmm17
       vmovss    dword ptr [rax+20],xmm18
       vmovss    dword ptr [rax+24],xmm19
       vmovss    dword ptr [rax+28],xmm20
       vmovss    dword ptr [rax+2C],xmm21
       vmovss    dword ptr [rax+30],xmm22
       vmovss    dword ptr [rax+34],xmm23
       vmovss    dword ptr [rax+38],xmm24
       vmovss    dword ptr [rax+3C],xmm25
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+0B0]
       vmovaps   xmm7,[rsp+0A0]
       vmovaps   xmm8,[rsp+90]
       vmovaps   xmm9,[rsp+80]
       vmovaps   xmm10,[rsp+70]
       vmovaps   xmm11,[rsp+60]
       vmovaps   xmm12,[rsp+50]
       vmovaps   xmm13,[rsp+40]
       vmovaps   xmm14,[rsp+30]
       vmovaps   xmm15,[rsp+20]
       add       rsp,0C8
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 649
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4`1[[System.Single, System.Private.CoreLib]].Multiply()
       push      r14
       push      rdi
       push      rsi
       push      rbp
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
       mov       rdi,[rbx+10]
       mov       rdx,[rbx+8]
       mov       r8,rdx
       mov       ecx,[r8+8]
       cmp       esi,ecx
       jae       near ptr M00_L01
       mov       rbp,rsi
       shl       rbp,6
       lea       r8,[r8+rbp+10]
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
       lea       r14d,[rsi+1]
       cmp       r14d,ecx
       jae       near ptr M00_L01
       mov       r8d,r14d
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
       call      qword ptr [7FFF43564DE0]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovaps   xmm0,xmm15
       vmovaps   xmm1,xmm6
       call      qword ptr [7FFF43564F60]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm9,xmm0
       vmovss    xmm0,dword ptr [rsp+5C]
       vmovaps   xmm1,xmm6
       call      qword ptr [7FFF43564F60]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm12,xmm0
       vmovss    xmm0,dword ptr [rsp+58]
       vmovaps   xmm1,xmm6
       call      qword ptr [7FFF43564F60]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm13,xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+88],xmm0
       vmovss    xmm0,dword ptr [rsp+54]
       vmovaps   xmm1,xmm6
       call      qword ptr [7FFF43564F60]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovss    dword ptr [rsp+20],xmm0
       lea       rcx,[rsp+88]
       vmovaps   xmm1,xmm9
       vmovaps   xmm2,xmm12
       vmovaps   xmm3,xmm13
       call      qword ptr [7FFF43565050]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]]..ctor(Single, Single, Single, Single)
       vmovups   xmm0,[rsp+88]
       vmovups   [rsp+40],xmm0
       lea       r8,[rsp+40]
       lea       rdx,[rsp+1D0]
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFF43564DE0]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovups   xmm2,[rsp+1E0]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+1B0]
       vmovaps   xmm2,xmm7
       call      qword ptr [7FFF43565068]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       vmovups   xmm2,[rsp+1F0]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+1A0]
       vmovss    xmm2,dword ptr [rsp+74]
       call      qword ptr [7FFF43565068]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+190]
       lea       rdx,[rsp+1B0]
       lea       r8,[rsp+1A0]
       call      qword ptr [7FFF43564DE0]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovups   xmm2,[rsp+200]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+180]
       vmovss    xmm2,dword ptr [rsp+70]
       call      qword ptr [7FFF43565068]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+170]
       lea       rdx,[rsp+190]
       lea       r8,[rsp+180]
       call      qword ptr [7FFF43564DE0]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
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
       call      qword ptr [7FFF43565068]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+150]
       lea       rdx,[rsp+170]
       lea       r8,[rsp+160]
       call      qword ptr [7FFF43564DE0]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovups   xmm2,[rsp+1E0]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+140]
       vmovss    xmm2,dword ptr [rsp+68]
       call      qword ptr [7FFF43565068]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       vmovups   xmm2,[rsp+1F0]
       vmovups   [rsp+40],xmm2
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+130]
       vmovss    xmm2,dword ptr [rsp+64]
       call      qword ptr [7FFF43565068]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+120]
       lea       rdx,[rsp+140]
       lea       r8,[rsp+130]
       call      qword ptr [7FFF43564DE0]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       lea       rcx,[rsp+110]
       lea       rdx,[rsp+200]
       vmovss    xmm2,dword ptr [rsp+60]
       call      qword ptr [7FFF43565068]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       lea       rcx,[rsp+100]
       lea       rdx,[rsp+120]
       lea       r8,[rsp+110]
       call      qword ptr [7FFF43564DE0]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovaps   xmm0,xmm15
       vmovaps   xmm1,xmm14
       call      qword ptr [7FFF43564F60]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm12,xmm0
       vmovaps   xmm0,xmm6
       vmovaps   xmm1,xmm14
       call      qword ptr [7FFF43564F60]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm6,xmm0
       vmovaps   xmm0,xmm7
       vmovaps   xmm1,xmm14
       call      qword ptr [7FFF43564F60]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovaps   xmm7,xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+78],xmm0
       vmovaps   xmm0,xmm9
       vmovaps   xmm1,xmm14
       call      qword ptr [7FFF43564F60]; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmovss    dword ptr [rsp+20],xmm0
       lea       rcx,[rsp+78]
       vmovaps   xmm1,xmm12
       vmovaps   xmm2,xmm6
       vmovaps   xmm3,xmm7
       call      qword ptr [7FFF43565050]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]]..ctor(Single, Single, Single, Single)
       vmovups   xmm0,[rsp+78]
       vmovups   [rsp+0F0],xmm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu32 [rsp+0B0],zmm0
       lea       rcx,[rsp+0A0]
       lea       rdx,[rsp+100]
       lea       r8,[rsp+0F0]
       call      qword ptr [7FFF43564DE0]; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
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
       call      qword ptr [7FFF43564F48]; Silk.NET.Maths.Matrix4X4`1[[System.Single, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       cmp       esi,[rdi+8]
       jae       near ptr M00_L01
       vmovdqu32 zmm0,[rsp+0B0]
       vmovdqu32 [rdi+rbp+10],zmm0
       mov       esi,r14d
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
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1887
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       vmovss    xmm0,dword ptr [rdx]
       vaddss    xmm0,xmm0,dword ptr [r8]
       vmovss    xmm1,dword ptr [rdx+4]
       vaddss    xmm1,xmm1,dword ptr [r8+4]
       vmovss    xmm2,dword ptr [rdx+8]
       vaddss    xmm2,xmm2,dword ptr [r8+8]
       vmovss    xmm3,dword ptr [rdx+0C]
       vaddss    xmm3,xmm3,dword ptr [r8+0C]
       vmovss    dword ptr [rcx],xmm0
       vmovss    dword ptr [rcx+4],xmm1
       vmovss    dword ptr [rcx+8],xmm2
       vmovss    dword ptr [rcx+0C],xmm3
       mov       rax,rcx
       ret
; Total bytes of code 65
```
```assembly
; Silk.NET.Maths.Scalar.Multiply[[System.Single, System.Private.CoreLib]](Single, Single)
       vmulss    xmm0,xmm0,xmm1
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]]..ctor(Single, Single, Single, Single)
       vmovss    dword ptr [rcx],xmm1
       vmovss    dword ptr [rcx+4],xmm2
       vmovss    dword ptr [rcx+8],xmm3
       vmovss    xmm0,dword ptr [rsp+28]
       vmovss    dword ptr [rcx+0C],xmm0
       ret
; Total bytes of code 26
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Single, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Single>, Single)
       vmulss    xmm0,xmm2,dword ptr [rdx]
       vmulss    xmm1,xmm2,dword ptr [rdx+4]
       vmulss    xmm3,xmm2,dword ptr [rdx+8]
       vmulss    xmm2,xmm2,dword ptr [rdx+0C]
       vmovss    dword ptr [rcx],xmm0
       vmovss    dword ptr [rcx+4],xmm1
       vmovss    dword ptr [rcx+8],xmm3
       vmovss    dword ptr [rcx+0C],xmm2
       mov       rax,rcx
       ret
; Total bytes of code 42
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Single, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>, Silk.NET.Maths.Vector4D`1<Single>)
       mov       rax,[rsp+28]
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       vmovups   xmm0,[r8]
       vmovups   [rcx+10],xmm0
       vmovups   xmm0,[r9]
       vmovups   [rcx+20],xmm0
       vmovups   xmm0,[rax]
       vmovups   [rcx+30],xmm0
       ret
; Total bytes of code 43
```

