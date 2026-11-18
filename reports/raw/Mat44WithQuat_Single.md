## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

| Method    | Mean     | Error   | StdDev  | Code Size |
|---------- |---------:|--------:|--------:|----------:|
| Add       | 104.7 μs | 0.42 μs | 0.40 μs |     118 B |
| Subtract  | 104.6 μs | 0.40 μs | 0.37 μs |     118 B |
| Multiply  | 293.7 μs | 1.19 μs | 1.00 μs |     451 B |
| Transpose | 104.3 μs | 0.41 μs | 0.38 μs |      92 B |
| Rotation  | 188.0 μs | 0.68 μs | 0.63 μs |     282 B |
| Transform | 324.6 μs | 0.86 μs | 0.80 μs |     407 B |
| Affine    | 252.3 μs | 0.84 μs | 0.78 μs |     404 B |

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
       jae       short M00_L01
       mov       rbx,rdx
       shl       rbx,6
       vmovups   zmm0,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       short M00_L01
       mov       r11d,r9d
       shl       r11,6
       vaddps    zmm0,zmm0,[r10+r11+10]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+rbx+10],zmm0
       mov       edx,r9d
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 118
```

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
       jae       short M00_L01
       mov       rbx,rdx
       shl       rbx,6
       vmovups   zmm0,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       short M00_L01
       mov       r11d,r9d
       shl       r11,6
       vsubps    zmm0,zmm0,[r10+r11+10]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+rbx+10],zmm0
       mov       edx,r9d
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 118
```

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
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],xmm0
       vmovups   [rax+10],xmm1
       vmovups   [rax+20],xmm2
       vmovups   [rax+30],xmm17
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 451
```

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Single, System.Private.CoreLib]].Transpose()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovups   zmm0,[7FFE955F70C0]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,6
       vpermd    zmm1,zmm0,[r10+r9+10]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+r9+10],zmm1
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 92
```

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Rotation()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       xor       eax,eax
       mov       rdx,1B9242C8650
M00_L00:
       mov       r8,[rcx+10]
       mov       r10,[rcx+18]
       cmp       eax,[r10+8]
       jae       near ptr M00_L01
       mov       r9d,eax
       mov       r11,r9
       shl       r11,4
       vmovups   xmm0,[r10+r11+10]
       vpshufd   xmm1,xmm0,0D2
       vpshufd   xmm2,xmm0,0C9
       vmulps    xmm2,xmm2,xmm0
       vpshufd   xmm3,xmm0,0FF
       vmulps    xmm1,xmm3,xmm1
       vmulps    xmm0,xmm0,xmm0
       vaddps    xmm3,xmm2,xmm1
       vsubps    xmm1,xmm2,xmm1
       vaddps    xmm2,xmm3,xmm3
       vaddps    xmm1,xmm1,xmm1
       vpshufd   xmm3,xmm0,0C9
       vaddps    xmm0,xmm3,xmm0
       vaddps    xmm0,xmm0,xmm0
       vbroadcastss xmm3,dword ptr [7FFE95607E1C]
       vsubps    xmm0,xmm3,xmm0
       vmovshdup xmm3,xmm0
       vinsertps xmm3,xmm1,xmm3,0
       vmovaps   xmm4,xmm2
       vinsertps xmm3,xmm3,xmm4,10
       vunpckhps xmm4,xmm0,xmm0
       vinsertps xmm4,xmm1,xmm4,10
       vmovshdup xmm5,xmm2
       vinsertps xmm4,xmm4,xmm5,20
       vunpckhps xmm2,xmm2,xmm2
       vinsertps xmm1,xmm1,xmm2,0
       vinsertps xmm0,xmm1,xmm0,20
       vmovups   xmm1,[rdx]
       vmovups   [rsp+58],xmm1
       vmovups   xmm1,[rsp+58]
       cmp       eax,[r8+8]
       jae       short M00_L01
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   [r8],xmm3
       vmovups   [r8+10],xmm4
       vmovups   [r8+20],xmm0
       vmovups   [r8+30],xmm1
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,68
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 282
```

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Transform()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   xmm0,[r8]
       vmovups   xmm1,[r8+10]
       vmovups   xmm2,[r8+20]
       vmovups   xmm3,[r8+30]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       shl       r10,4
       vmovups   xmm4,[r8+r10+10]
       vpshufd   xmm5,xmm4,0C9
       vpshufd   xmm16,xmm4,0FF
       vpshufd   xmm17,xmm4,0D2
       vmulps    xmm18,xmm5,xmm5
       vmulps    xmm5,xmm5,xmm4
       vmulps    xmm16,xmm17,xmm16
       vaddps    xmm4,xmm16,xmm5
       vsubps    xmm17,xmm5,xmm16
       vpshufd   xmm4,xmm4,0D2
       vpshufd   xmm5,xmm18,0C9
       vaddps    xmm18,xmm18,xmm5
       vaddps    xmm4,xmm4,xmm4
       vaddps    xmm17,xmm17,xmm17
       vaddps    xmm18,xmm18,xmm18
       vbroadcastss xmm16,dword ptr [7FFE956189F8]
       vsubps    xmm18,xmm16,xmm18
       vpshufd   xmm5,xmm0,0D2
       vpshufd   xmm16,xmm0,0C9
       vmulps    xmm19,xmm18,xmm0
       vfmadd213ps xmm16,xmm17,xmm19
       vfmadd213ps xmm5,xmm4,xmm16
       vpshufd   xmm16,xmm1,0D2
       vpshufd   xmm19,xmm1,0C9
       vmulps    xmm20,xmm18,xmm1
       vfmadd213ps xmm19,xmm17,xmm20
       vfmadd213ps xmm16,xmm4,xmm19
       vpshufd   xmm19,xmm2,0D2
       vpshufd   xmm20,xmm2,0C9
       vmulps    xmm18,xmm18,xmm2
       vfmadd231ps xmm18,xmm17,xmm20
       vfmadd231ps xmm18,xmm4,xmm19
       vshufps   xmm0,xmm0,xmm0,0FF
       vinsertps xmm0,xmm5,xmm0,30
       vshufps   xmm1,xmm1,xmm1,0FF
       vinsertps xmm1,xmm16,xmm1,30
       vshufps   xmm2,xmm2,xmm2,0FF
       vinsertps xmm2,xmm18,xmm2,30
       vpshufd   xmm5,xmm3,0D2
       vpshufd   xmm16,xmm3,0C9
       vmulps    xmm18,xmm18,xmm3
       vfmadd231ps xmm18,xmm17,xmm16
       vfmadd213ps xmm4,xmm5,xmm18
       vshufps   xmm3,xmm3,xmm3,0FF
       vinsertps xmm3,xmm4,xmm3,30
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r9+10]
       vmovups   [rdx],xmm0
       vmovups   [rdx+10],xmm1
       vmovups   [rdx+20],xmm2
       vmovups   [rdx+30],xmm3
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 407
```

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Affine()
       sub       rsp,28
       xor       eax,eax
       vmovss    xmm0,dword ptr [7FFE95618374]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,4
       vmovups   xmm1,[r8+r9+10]
       mov       r8,[rcx+20]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       lea       r9,[r10+r10*2]
       lea       r8,[r8+r9*4+10]
       vmovss    xmm2,dword ptr [r8]
       vmovss    xmm3,dword ptr [r8+4]
       vmovss    xmm4,dword ptr [r8+8]
       mov       r8,[rcx+28]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       lea       r8,[r8+r9*4+10]
       vmovss    xmm5,dword ptr [r8]
       vmovss    xmm16,dword ptr [r8+4]
       vmovss    xmm17,dword ptr [r8+8]
       vpshufd   xmm18,xmm1,0D2
       vpshufd   xmm19,xmm1,0C9
       vmulps    xmm19,xmm19,xmm1
       vpshufd   xmm20,xmm1,0FF
       vmulps    xmm18,xmm20,xmm18
       vmulps    xmm1,xmm1,xmm1
       vaddps    xmm20,xmm19,xmm18
       vsubps    xmm18,xmm19,xmm18
       vaddps    xmm19,xmm20,xmm20
       vaddps    xmm18,xmm18,xmm18
       vpshufd   xmm20,xmm1,0C9
       vaddps    xmm1,xmm20,xmm1
       vaddps    xmm1,xmm1,xmm1
       vbroadcastss xmm20,dword ptr [7FFE95618374]
       vsubps    xmm1,xmm20,xmm1
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
       vmulps    xmm20,xmm20,xmm2
       vbroadcastss xmm2,xmm3
       vmulps    xmm21,xmm21,xmm2
       vbroadcastss xmm2,xmm4
       vmulps    xmm1,xmm2,xmm1
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm20
       vmovups   [rdx+10],xmm21
       vmovups   [rdx+20],xmm1
       vmovss    dword ptr [rdx+30],xmm5
       vmovss    dword ptr [rdx+34],xmm16
       vmovss    dword ptr [rdx+38],xmm17
       vmovss    dword ptr [rdx+3C],xmm0
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 404
```
