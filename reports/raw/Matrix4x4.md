## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean     | Error   | StdDev  | Code Size |
|---------- |---------:|--------:|--------:|----------:|
| Add       | 186.9 μs | 0.55 μs | 0.49 μs |     185 B |
| Subtract  | 185.2 μs | 0.36 μs | 0.32 μs |     185 B |
| Multiply  | 297.9 μs | 1.20 μs | 1.00 μs |     449 B |
| Transpose | 128.7 μs | 0.92 μs | 0.77 μs |     136 B |
| Invert    | 737.0 μs | 0.72 μs | 0.67 μs |     865 B |
| Rotation  | 235.6 μs | 0.68 μs | 0.64 μs |     352 B |
| Transform | 687.8 μs | 2.63 μs | 2.46 μs |     844 B |
| Affine    | 895.5 μs | 2.06 μs | 1.93 μs |   1,078 B |

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
       jae       near ptr 0000000000003C13
       mov       r11,rax
       shl       r11,6
       lea       r10,[r10+r11+10]
       vmovups   xmm0,[r10]
       vmovups   xmm1,[r10+10]
       vmovups   xmm2,[r10+20]
       vmovups   xmm3,[r10+30]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       short 0000000000003C13
       mov       r9d,r10d
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm16,[r8+20]
       vmovups   xmm17,[r8+30]
       vaddps    xmm0,xmm0,xmm4
       vaddps    xmm1,xmm1,xmm5
       vaddps    xmm2,xmm16,xmm2
       vaddps    xmm3,xmm17,xmm3
       cmp       eax,[rdx+8]
       jae       short 0000000000003C13
       lea       rax,[rdx+r11+10]
       vmovups   [rax],xmm0
       vmovups   [rax+10],xmm1
       vmovups   [rax+20],xmm2
       vmovups   [rax+30],xmm3
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000003B66
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 185
```

```assembly
; System.Numerics.Bench.StressMatrix4x4.Subtract()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr 0000000000004013
       mov       r11,rax
       shl       r11,6
       lea       r10,[r10+r11+10]
       vmovups   xmm0,[r10]
       vmovups   xmm1,[r10+10]
       vmovups   xmm2,[r10+20]
       vmovups   xmm3,[r10+30]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       short 0000000000004013
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
       jae       short 0000000000004013
       lea       rax,[rdx+r11+10]
       vmovups   [rax],xmm0
       vmovups   [rax+10],xmm1
       vmovups   [rax+20],xmm2
       vmovups   [rax+30],xmm3
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000003F66
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 185
```

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
       jae       near ptr 00000000000038DB
       mov       r11,rax
       shl       r11,6
       lea       r10,[r10+r11+10]
       vmovups   xmm0,[r10]
       vmovups   xmm1,[r10+10]
       vmovups   xmm2,[r10+20]
       vmovups   xmm3,[r10+30]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr 00000000000038DB
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
       vfmadd213ps xmm19,xmm5,xmm20
       vfmadd213ps xmm18,xmm16,xmm19
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd213ps xmm0,xmm17,xmm18
       vunpckhps xmm18,xmm1,xmm1
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm1
       vbroadcastss xmm19,xmm19
       vmovaps   xmm20,xmm1
       vbroadcastss xmm20,xmm20
       vmulps    xmm20,xmm20,xmm4
       vfmadd213ps xmm19,xmm5,xmm20
       vfmadd213ps xmm18,xmm16,xmm19
       vshufps   xmm1,xmm1,xmm1,0FF
       vbroadcastss xmm1,xmm1
       vfmadd213ps xmm1,xmm17,xmm18
       vunpckhps xmm18,xmm2,xmm2
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm2
       vbroadcastss xmm19,xmm19
       vmovaps   xmm20,xmm2
       vbroadcastss xmm20,xmm20
       vmulps    xmm20,xmm20,xmm4
       vfmadd213ps xmm19,xmm5,xmm20
       vfmadd213ps xmm18,xmm16,xmm19
       vshufps   xmm2,xmm2,xmm2,0FF
       vbroadcastss xmm2,xmm2
       vfmadd213ps xmm2,xmm17,xmm18
       vunpckhps xmm18,xmm3,xmm3
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm3
       vbroadcastss xmm19,xmm19
       vmovaps   xmm20,xmm3
       vbroadcastss xmm20,xmm20
       vmulps    xmm4,xmm20,xmm4
       vfmadd213ps xmm5,xmm19,xmm4
       vfmadd213ps xmm16,xmm18,xmm5
       vshufps   xmm3,xmm3,xmm3,0FF
       vbroadcastss xmm3,xmm3
       vfmadd213ps xmm3,xmm17,xmm16
       cmp       eax,[rdx+8]
       jae       short 00000000000038DB
       lea       rax,[rdx+r11+10]
       vmovups   [rax],xmm0
       vmovups   [rax+10],xmm1
       vmovups   [rax+20],xmm2
       vmovups   [rax+30],xmm3
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000003726
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 449
```

```assembly
; System.Numerics.Bench.StressMatrix4x4.Transpose()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short 0000000000006A62
       mov       r10,rax
       shl       r10,6
       lea       r8,[r8+r10+10]
       vmovups   xmm0,[r8]
       vmovups   xmm1,[r8+10]
       vmovups   xmm2,[r8+20]
       vmovups   xmm3,[r8+30]
       vunpcklps xmm4,xmm0,xmm2
       vunpcklps xmm5,xmm1,xmm3
       vunpckhps xmm0,xmm0,xmm2
       vunpckhps xmm1,xmm1,xmm3
       vunpcklps xmm2,xmm4,xmm5
       vunpckhps xmm3,xmm4,xmm5
       vunpcklps xmm4,xmm0,xmm1
       vunpckhps xmm0,xmm0,xmm1
       cmp       eax,[rdx+8]
       jae       short 0000000000006A62
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm2
       vmovups   [rdx+10],xmm3
       vmovups   [rdx+20],xmm4
       vmovups   [rdx+30],xmm0
       inc       eax
       cmp       eax,186A0
       jl        short 00000000000069E6
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 136
```

```assembly
; System.Numerics.Bench.StressMatrix4x4.Invert()
       push      rsi
       push      rbx
       sub       rsp,68
       mov       rbx,rcx
       xor       esi,esi
M00_L00:
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       short M00_L01
       mov       rdx,rsi
       shl       rdx,6
       vmovdqu32 zmm0,[rcx+rdx+10]
       vmovdqu32 [rsp+28],zmm0
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L01
       lea       rdx,[rcx+rdx+10]
       lea       rcx,[rsp+28]
       call      qword ptr [7FFEA6DAE688]; System.Numerics.Matrix4x4.Invert(Impl ByRef, Impl ByRef)
       inc       esi
       cmp       esi,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 100

; System.Numerics.Matrix4x4.Invert(Impl ByRef, Impl ByRef)
       vmovups   xmm0,[rcx]
       vmovups   xmm1,[rcx+10]
       vmovups   xmm2,[rcx+20]
       vmovups   xmm3,[rcx+30]
       vmovhlps  xmm4,xmm1,xmm0
       vmovlhps  xmm5,xmm2,xmm3
       vmovhlps  xmm3,xmm3,xmm2
       vmovlhps  xmm1,xmm0,xmm1
       vshufps   xmm0,xmm1,xmm5,88
       vshufps   xmm1,xmm1,xmm5,0DD
       vshufps   xmm2,xmm4,xmm3,88
       vshufps   xmm3,xmm4,xmm3,0DD
       vpermilps xmm4,xmm2,50
       vpermilps xmm5,xmm3,0EE
       vpermilps xmm16,xmm0,50
       vpermilps xmm17,xmm1,0EE
       vshufps   xmm18,xmm2,xmm0,88
       vshufps   xmm19,xmm3,xmm1,0DD
       vmulps    xmm5,xmm4,xmm5
       vmulps    xmm17,xmm17,xmm16
       vmulps    xmm19,xmm18,xmm19
       vpermilps xmm4,xmm2,0EE
       vpermilps xmm16,xmm3,50
       vpermilps xmm18,xmm0,0EE
       vpermilps xmm20,xmm1,50
       vshufps   xmm21,xmm2,xmm0,0DD
       vshufps   xmm22,xmm3,xmm1,88
       vbroadcastss xmm23,dword ptr [7FFEA6E63660]
       vxorps    xmm4,xmm23,xmm4
       vfmadd231ps xmm5,xmm16,xmm4
       vxorps    xmm16,xmm23,xmm18
       vfmadd231ps xmm17,xmm20,xmm16
       vxorps    xmm20,xmm23,xmm21
       vfmadd231ps xmm19,xmm22,xmm20
       vshufps   xmm20,xmm5,xmm19,5D
       vpermilps xmm4,xmm1,49
       vshufps   xmm16,xmm20,xmm5,32
       vpermilps xmm18,xmm0,12
       vshufps   xmm20,xmm20,xmm5,99
       vshufps   xmm24,xmm17,xmm19,0FD
       vpermilps xmm21,xmm3,49
       vshufps   xmm22,xmm24,xmm17,32
       vpermilps xmm25,xmm2,12
       vshufps   xmm24,xmm24,xmm17,99
       vmulps    xmm26,xmm16,xmm4
       vmulps    xmm27,xmm20,xmm18
       vmulps    xmm28,xmm21,xmm22
       vmulps    xmm24,xmm24,xmm25
       vshufps   xmm20,xmm5,xmm19,4
       vpermilps xmm4,xmm1,9E
       vshufps   xmm16,xmm5,xmm20,93
       vpermilps xmm18,xmm0,7B
       vshufps   xmm20,xmm5,xmm20,26
       vshufps   xmm21,xmm17,xmm19,0A4
       vpermilps xmm22,xmm3,9E
       vshufps   xmm25,xmm17,xmm21,93
       vpermilps xmm29,xmm2,7B
       vshufps   xmm21,xmm17,xmm21,26
       vxorps    xmm4,xmm23,xmm4
       vfmadd231ps xmm26,xmm16,xmm4
       vxorps    xmm16,xmm23,xmm18
       vfmadd231ps xmm27,xmm20,xmm16
       vxorps    xmm18,xmm23,xmm22
       vfmadd231ps xmm28,xmm25,xmm18
       vxorps    xmm20,xmm23,xmm29
       vfmadd231ps xmm24,xmm21,xmm20
       vpermilps xmm4,xmm1,33
       vshufps   xmm22,xmm5,xmm19,4A
       vpermilps xmm16,xmm22,2C
       vpermilps xmm18,xmm0,8D
       vshufps   xmm25,xmm5,xmm19,4C
       vpermilps xmm20,xmm25,93
       vpermilps xmm22,xmm3,33
       vshufps   xmm29,xmm17,xmm19,0EA
       vpermilps xmm25,xmm29,2C
       vpermilps xmm29,xmm2,8D
       vshufps   xmm21,xmm17,xmm19,0EC
       vpermilps xmm21,xmm21,93
       vmulps    xmm4,xmm16,xmm4
       vmulps    xmm18,xmm20,xmm18
       vmulps    xmm22,xmm22,xmm25
       vmulps    xmm29,xmm21,xmm29
       vsubps    xmm1,xmm26,xmm4
       vaddps    xmm26,xmm26,xmm4
       vaddps    xmm2,xmm18,xmm27
       vsubps    xmm27,xmm27,xmm18
       vsubps    xmm3,xmm28,xmm22
       vaddps    xmm28,xmm22,xmm28
       vaddps    xmm4,xmm24,xmm29
       vsubps    xmm24,xmm24,xmm29
       vshufps   xmm26,xmm26,xmm1,0D8
       vshufps   xmm27,xmm27,xmm2,0D8
       vshufps   xmm28,xmm28,xmm3,0D8
       vshufps   xmm24,xmm24,xmm4,0D8
       vpermilps xmm26,xmm26,0D8
       vpermilps xmm27,xmm27,0D8
       vpermilps xmm28,xmm28,0D8
       vpermilps xmm24,xmm24,0D8
       vmulps    xmm0,xmm26,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vandps    xmm1,xmm0,[7FFEA6E63670]
       vmovss    xmm2,dword ptr [7FFEA6E63680]
       vucomiss  xmm2,xmm1
       jbe       short M01_L00
       vbroadcastss xmm0,dword ptr [7FFEA6E63684]
       vmovups   [rdx],xmm0
       vmovups   [rdx+10],xmm0
       vmovups   [rdx+20],xmm0
       vmovups   [rdx+30],xmm0
       xor       eax,eax
       ret
M01_L00:
       vbroadcastss xmm0,xmm0
       vbroadcastss xmm1,dword ptr [7FFEA6E63688]
       vdivps    xmm0,xmm1,xmm0
       vmulps    xmm1,xmm26,xmm0
       vmovups   [rdx],xmm1
       vmulps    xmm1,xmm27,xmm0
       vmovups   [rdx+10],xmm1
       vmulps    xmm1,xmm28,xmm0
       vmovups   [rdx+20],xmm1
       vmulps    xmm0,xmm24,xmm0
       vmovups   [rdx+30],xmm0
       mov       eax,1
       ret
; Total bytes of code 765
```

```assembly
; System.Numerics.Bench.StressMatrix4x4.Rotation()
       sub       rsp,28
       xor       eax,eax
       vmovss    xmm0,dword ptr [43A0]
       vmovss    xmm1,dword ptr [43A4]
       vmovups   xmm2,[43B0]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr 000000000000439A
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
       vmulss    xmm20,xmm16,xmm4
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
       jae       short 000000000000439A
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm4
       vmovups   [rdx+10],xmm18
       vmovups   [rdx+20],xmm3
       vmovups   [rdx+30],xmm2
       inc       eax
       cmp       eax,186A0
       jl        near ptr 000000000000425E
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 352
```

```assembly
; System.Numerics.Bench.StressMatrix4x4.Transform()
       sub       rsp,28
       vmovss    xmm0,dword ptr [47CC]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000047C6
       mov       r10,rax
       shl       r10,6
       lea       r8,[r8+r10+10]
       vmovups   xmm1,[r8]
       vmovups   xmm2,[r8+10]
       vmovups   xmm3,[r8+20]
       vmovups   xmm4,[r8+30]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000047C6
       mov       r9,rax
       shl       r9,4
       vmovups   xmm5,[r8+r9+10]
       vmovaps   xmm16,xmm5
       vaddss    xmm17,xmm16,xmm16
       vmovshdup xmm18,xmm5
       vaddss    xmm19,xmm18,xmm18
       vunpckhps xmm20,xmm5,xmm5
       vaddss    xmm21,xmm20,xmm20
       vshufps   xmm5,xmm5,xmm5,0FF
       vmulss    xmm22,xmm17,xmm5
       vmulss    xmm23,xmm19,xmm5
       vmulss    xmm5,xmm21,xmm5
       vmulss    xmm17,xmm16,xmm17
       vmulss    xmm24,xmm16,xmm21
       vmulss    xmm25,xmm18,xmm19
       vmulss    xmm18,xmm18,xmm21
       vmulss    xmm20,xmm20,xmm21
       vsubss    xmm21,xmm0,xmm25
       vsubss    xmm21,xmm21,xmm20
       vmulss    xmm16,xmm16,xmm19
       vsubss    xmm19,xmm16,xmm5
       vaddss    xmm26,xmm24,xmm23
       vaddss    xmm5,xmm16,xmm5
       vsubss    xmm16,xmm0,xmm17
       vsubss    xmm17,xmm16,xmm20
       vsubss    xmm20,xmm18,xmm22
       vsubss    xmm23,xmm24,xmm23
       vaddss    xmm18,xmm18,xmm22
       vsubss    xmm16,xmm16,xmm25
       vmovaps   xmm22,xmm1
       vmulss    xmm24,xmm22,xmm21
       vmovshdup xmm25,xmm1
       vmulss    xmm27,xmm25,xmm19
       vaddss    xmm24,xmm24,xmm27
       vunpckhps xmm27,xmm1,xmm1
       vmulss    xmm28,xmm27,xmm26
       vaddss    xmm24,xmm24,xmm28
       vmulss    xmm28,xmm22,xmm5
       vmulss    xmm29,xmm25,xmm17
       vaddss    xmm28,xmm28,xmm29
       vmulss    xmm29,xmm27,xmm20
       vaddss    xmm28,xmm28,xmm29
       vinsertps xmm24,xmm24,xmm28,10
       vmulss    xmm22,xmm22,xmm23
       vmulss    xmm25,xmm25,xmm18
       vaddss    xmm22,xmm22,xmm25
       vmulss    xmm25,xmm27,xmm16
       vaddss    xmm22,xmm22,xmm25
       vinsertps xmm22,xmm24,xmm22,20
       vshufps   xmm1,xmm1,xmm1,0FF
       vinsertps xmm1,xmm22,xmm1,30
       vmovaps   xmm22,xmm2
       vmulss    xmm24,xmm22,xmm21
       vmovshdup xmm25,xmm2
       vmulss    xmm27,xmm25,xmm19
       vaddss    xmm24,xmm24,xmm27
       vunpckhps xmm27,xmm2,xmm2
       vmulss    xmm28,xmm27,xmm26
       vaddss    xmm24,xmm24,xmm28
       vmulss    xmm28,xmm22,xmm5
       vmulss    xmm29,xmm25,xmm17
       vaddss    xmm28,xmm28,xmm29
       vmulss    xmm29,xmm27,xmm20
       vaddss    xmm28,xmm28,xmm29
       vinsertps xmm24,xmm24,xmm28,10
       vmulss    xmm22,xmm22,xmm23
       vmulss    xmm25,xmm25,xmm18
       vaddss    xmm22,xmm22,xmm25
       vmulss    xmm25,xmm27,xmm16
       vaddss    xmm22,xmm22,xmm25
       vinsertps xmm22,xmm24,xmm22,20
       vshufps   xmm2,xmm2,xmm2,0FF
       vinsertps xmm2,xmm22,xmm2,30
       vmovaps   xmm22,xmm3
       vmulss    xmm24,xmm22,xmm21
       vmovshdup xmm25,xmm3
       vmulss    xmm27,xmm25,xmm19
       vaddss    xmm24,xmm24,xmm27
       vunpckhps xmm27,xmm3,xmm3
       vmulss    xmm28,xmm27,xmm26
       vaddss    xmm24,xmm24,xmm28
       vmulss    xmm28,xmm22,xmm5
       vmulss    xmm29,xmm25,xmm17
       vaddss    xmm28,xmm28,xmm29
       vmulss    xmm29,xmm27,xmm20
       vaddss    xmm28,xmm28,xmm29
       vinsertps xmm24,xmm24,xmm28,10
       vmulss    xmm22,xmm22,xmm23
       vmulss    xmm25,xmm25,xmm18
       vaddss    xmm22,xmm22,xmm25
       vmulss    xmm25,xmm27,xmm16
       vaddss    xmm22,xmm22,xmm25
       vinsertps xmm22,xmm24,xmm22,20
       vshufps   xmm3,xmm3,xmm3,0FF
       vinsertps xmm3,xmm22,xmm3,30
       vmovaps   xmm22,xmm4
       vmulss    xmm21,xmm22,xmm21
       vmovshdup xmm24,xmm4
       vmulss    xmm19,xmm24,xmm19
       vaddss    xmm19,xmm21,xmm19
       vunpckhps xmm21,xmm4,xmm4
       vmulss    xmm25,xmm21,xmm26
       vaddss    xmm19,xmm19,xmm25
       vmulss    xmm5,xmm22,xmm5
       vmulss    xmm17,xmm24,xmm17
       vaddss    xmm5,xmm17,xmm5
       vmulss    xmm17,xmm21,xmm20
       vaddss    xmm5,xmm17,xmm5
       vinsertps xmm5,xmm19,xmm5,10
       vmulss    xmm17,xmm22,xmm23
       vmulss    xmm18,xmm24,xmm18
       vaddss    xmm17,xmm17,xmm18
       vmulss    xmm16,xmm21,xmm16
       vaddss    xmm16,xmm17,xmm16
       vinsertps xmm5,xmm5,xmm16,20
       vshufps   xmm4,xmm4,xmm4,0FF
       vinsertps xmm4,xmm5,xmm4,30
       cmp       eax,[rdx+8]
       jae       short 00000000000047C6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm1
       vmovups   [rdx+10],xmm2
       vmovups   [rdx+20],xmm3
       vmovups   [rdx+30],xmm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr 000000000000448E
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 844
```

```assembly
; System.Numerics.Bench.StressMatrix4x4.Affine()
       sub       rsp,28
       xor       eax,eax
       vmovss    xmm0,dword ptr [41D8]
       vmovss    xmm1,dword ptr [41DC]
       vmovups   xmm2,[41E0]
       vbroadcastss xmm3,dword ptr [41DC]
       vmovups   xmm4,[41F0]
       vmovsd    xmm5,qword ptr [4200]
       vmovss    xmm16,dword ptr [41DC]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000041D0
       mov       r10d,eax
       mov       r9,r10
       shl       r9,4
       vmovups   xmm17,[r8+r9+10]
       vmovaps   xmm18,xmm17
       vmulss    xmm19,xmm18,xmm18
       vmovshdup xmm20,xmm17
       vmulss    xmm21,xmm20,xmm20
       vunpckhps xmm22,xmm17,xmm17
       vmulss    xmm23,xmm22,xmm22
       vmulss    xmm24,xmm18,xmm20
       vshufps   xmm17,xmm17,xmm17,0FF
       vmulss    xmm25,xmm22,xmm17
       vmulss    xmm26,xmm18,xmm22
       vmulss    xmm27,xmm20,xmm17
       vmulss    xmm20,xmm20,xmm22
       vmulss    xmm17,xmm18,xmm17
       vaddss    xmm18,xmm21,xmm23
       vmulss    xmm18,xmm18,xmm0
       vsubss    xmm18,xmm1,xmm18
       vaddss    xmm22,xmm24,xmm25
       vmulss    xmm22,xmm22,xmm0
       vinsertps xmm18,xmm18,xmm22,10
       vsubss    xmm22,xmm26,xmm27
       vmulss    xmm22,xmm22,xmm0
       vinsertps xmm18,xmm18,xmm22,28
       vsubss    xmm22,xmm24,xmm25
       vmulss    xmm22,xmm22,xmm0
       vaddss    xmm23,xmm23,xmm19
       vmulss    xmm23,xmm23,xmm0
       vsubss    xmm23,xmm1,xmm23
       vinsertps xmm22,xmm22,xmm23,10
       vaddss    xmm23,xmm20,xmm17
       vmulss    xmm23,xmm23,xmm0
       vinsertps xmm22,xmm22,xmm23,28
       vaddss    xmm23,xmm26,xmm27
       vmulss    xmm23,xmm23,xmm0
       vsubss    xmm17,xmm20,xmm17
       vmulss    xmm17,xmm17,xmm0
       vinsertps xmm17,xmm23,xmm17,10
       vaddss    xmm19,xmm21,xmm19
       vmulss    xmm19,xmm19,xmm0
       vsubss    xmm19,xmm1,xmm19
       vinsertps xmm17,xmm17,xmm19,28
       mov       r8,[rcx+20]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000041D0
       lea       r9,[r10+r10*2]
       vmovsd    xmm19,qword ptr [r8+r9*4+10]
       vinsertps xmm19,xmm19,dword ptr [r8+r9*4+18],28
       vmovaps   xmm20,xmm19
       vinsertps xmm20,xmm20,xmm20,3E
       vmovshdup xmm21,xmm19
       vinsertps xmm21,xmm21,xmm21,1D
       vunpckhps xmm19,xmm19,xmm19
       vinsertps xmm19,xmm19,xmm19,2B
       vunpckhps xmm23,xmm18,xmm18
       vbroadcastss xmm23,xmm23
       vmovshdup xmm24,xmm18
       vbroadcastss xmm24,xmm24
       vmovaps   xmm25,xmm18
       vbroadcastss xmm25,xmm25
       vmulps    xmm25,xmm25,xmm20
       vfmadd213ps xmm24,xmm21,xmm25
       vfmadd213ps xmm23,xmm19,xmm24
       vshufps   xmm18,xmm18,xmm18,0FF
       vbroadcastss xmm18,xmm18
       vfmadd213ps xmm18,xmm2,xmm23
       vunpckhps xmm23,xmm22,xmm22
       vbroadcastss xmm23,xmm23
       vmovshdup xmm24,xmm22
       vbroadcastss xmm24,xmm24
       vmovaps   xmm25,xmm22
       vbroadcastss xmm25,xmm25
       vmulps    xmm25,xmm25,xmm20
       vfmadd213ps xmm24,xmm21,xmm25
       vfmadd213ps xmm23,xmm19,xmm24
       vshufps   xmm22,xmm22,xmm22,0FF
       vbroadcastss xmm22,xmm22
       vfmadd213ps xmm22,xmm2,xmm23
       vunpckhps xmm23,xmm17,xmm17
       vbroadcastss xmm23,xmm23
       vmovshdup xmm24,xmm17
       vbroadcastss xmm24,xmm24
       vmovaps   xmm25,xmm17
       vbroadcastss xmm25,xmm25
       vmulps    xmm25,xmm25,xmm20
       vfmadd213ps xmm24,xmm21,xmm25
       vfmadd213ps xmm23,xmm19,xmm24
       vshufps   xmm17,xmm17,xmm17,0FF
       vbroadcastss xmm17,xmm17
       vfmadd213ps xmm17,xmm2,xmm23
       vxorps    xmm23,xmm23,xmm23
       vxorps    xmm24,xmm24,xmm24
       vxorps    xmm25,xmm25,xmm25
       vmulps    xmm20,xmm25,xmm20
       vfmadd213ps xmm21,xmm24,xmm20
       vfmadd213ps xmm19,xmm23,xmm21
       vfmadd231ps xmm19,xmm3,xmm2
       mov       r8,[rcx+28]
       cmp       eax,[r8+8]
       jae       near ptr 00000000000041D0
       vmovsd    xmm20,qword ptr [r8+r9*4+10]
       vinsertps xmm20,xmm20,dword ptr [r8+r9*4+18],28
       vinsertps xmm20,xmm20,xmm1,30
       vunpckhps xmm21,xmm18,xmm18
       vbroadcastss xmm21,xmm21
       vmovshdup xmm23,xmm18
       vbroadcastss xmm23,xmm23
       vmovaps   xmm24,xmm18
       vbroadcastss xmm24,xmm24
       vmulps    xmm24,xmm24,xmm16
       vfmadd213ps xmm23,xmm5,xmm24
       vfmadd213ps xmm21,xmm4,xmm23
       vshufps   xmm18,xmm18,xmm18,0FF
       vbroadcastss xmm18,xmm18
       vfmadd213ps xmm18,xmm20,xmm21
       vunpckhps xmm21,xmm22,xmm22
       vbroadcastss xmm21,xmm21
       vmovshdup xmm23,xmm22
       vbroadcastss xmm23,xmm23
       vmovaps   xmm24,xmm22
       vbroadcastss xmm24,xmm24
       vmulps    xmm24,xmm24,xmm16
       vfmadd213ps xmm23,xmm5,xmm24
       vfmadd213ps xmm21,xmm4,xmm23
       vshufps   xmm22,xmm22,xmm22,0FF
       vbroadcastss xmm22,xmm22
       vfmadd231ps xmm21,xmm22,xmm20
       vunpckhps xmm22,xmm17,xmm17
       vbroadcastss xmm22,xmm22
       vmovshdup xmm23,xmm17
       vbroadcastss xmm23,xmm23
       vmovaps   xmm24,xmm17
       vbroadcastss xmm24,xmm24
       vmulps    xmm24,xmm24,xmm16
       vfmadd213ps xmm23,xmm5,xmm24
       vfmadd213ps xmm22,xmm4,xmm23
       vshufps   xmm17,xmm17,xmm17,0FF
       vbroadcastss xmm17,xmm17
       vfmadd213ps xmm17,xmm20,xmm22
       vunpckhps xmm22,xmm19,xmm19
       vbroadcastss xmm22,xmm22
       vmovshdup xmm23,xmm19
       vbroadcastss xmm23,xmm23
       vmovaps   xmm24,xmm19
       vbroadcastss xmm24,xmm24
       vmulps    xmm24,xmm24,xmm16
       vfmadd213ps xmm23,xmm5,xmm24
       vfmadd213ps xmm22,xmm4,xmm23
       vshufps   xmm19,xmm19,xmm19,0FF
       vbroadcastss xmm19,xmm19
       vfmadd213ps xmm19,xmm20,xmm22
       cmp       eax,[rdx+8]
       jae       short 00000000000041D0
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm18
       vmovups   [rdx+10],xmm21
       vmovups   [rdx+20],xmm17
       vmovups   [rdx+30],xmm19
       inc       eax
       cmp       eax,186A0
       jl        near ptr 0000000000003DE1
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 1078
```
