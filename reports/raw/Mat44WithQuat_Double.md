## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean     | Error   | StdDev  | Code Size |
|---------- |---------:|--------:|--------:|----------:|
| Add       | 208.8 μs | 1.27 μs | 1.13 μs |     144 B |
| Subtract  | 212.7 μs | 3.70 μs | 3.46 μs |     144 B |
| Multiply  | 334.9 μs | 0.57 μs | 0.47 μs |     490 B |
| Transpose | 233.3 μs | 1.04 μs | 0.97 μs |     173 B |
| Invert    | 436.3 μs | 1.53 μs | 1.43 μs |   1,317 B |
| Rotation  | 275.9 μs | 1.27 μs | 1.18 μs |     381 B |
| Transform | 494.3 μs | 4.54 μs | 4.24 μs |     479 B |
| Affine    | 348.4 μs | 2.11 μs | 1.97 μs |     495 B |

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
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 144
```

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
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 144
```

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
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],ymm0
       vmovups   [rax+20],ymm1
       vmovups   [rax+40],ymm2
       vmovups   [rax+60],ymm17
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 490
```

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Double, System.Private.CoreLib]].Transpose()
       sub       rsp,28
       vmovups   zmm0,[7FFE955C7740]
       vmovups   zmm1,[7FFE955C7780]
       vmovups   zmm2,[7FFE955C77C0]
       vmovups   zmm3,[7FFE955C7800]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short M00_L01
       mov       r10,rax
       shl       r10,7
       lea       r8,[r8+r10+10]
       vmovups   zmm4,[r8]
       vmovups   zmm5,[r8+40]
       vpermq    zmm4,zmm0,zmm4
       vpermq    zmm5,zmm0,zmm5
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r10+10]
       vmovaps   zmm16,zmm4
       vpermt2pd zmm16,zmm1,zmm5
       vpermq    zmm16,zmm2,zmm16
       vmovups   [rdx],zmm16
       vpermt2pd zmm4,zmm3,zmm5
       vpermq    zmm4,zmm2,zmm4
       vmovups   [rdx+40],zmm4
       inc       eax
       cmp       eax,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 173
```

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Invert()
       sub       rsp,88
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       vmovaps   [rsp+40],xmm9
       vmovaps   [rsp+30],xmm10
       vmovaps   [rsp+20],xmm11
       vmovsd    xmm0,qword ptr [7FFEA6E58FC8]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+8]
       cmp       eax,[rdx+8]
       jae       near ptr M00_L03
       mov       r8,rax
       shl       r8,7
       lea       rdx,[rdx+r8+10]
       vmovsd    xmm1,qword ptr [rdx]
       vmovsd    xmm2,qword ptr [rdx+8]
       vmovsd    xmm3,qword ptr [rdx+10]
       vmovsd    xmm4,qword ptr [rdx+18]
       vmovsd    xmm5,qword ptr [rdx+20]
       vmovsd    xmm16,qword ptr [rdx+28]
       vmovsd    xmm17,qword ptr [rdx+30]
       vmovsd    xmm18,qword ptr [rdx+38]
       vmovsd    xmm19,qword ptr [rdx+40]
       vmovsd    xmm20,qword ptr [rdx+48]
       vmovsd    xmm21,qword ptr [rdx+50]
       vmovsd    xmm22,qword ptr [rdx+58]
       vmovsd    xmm23,qword ptr [rdx+60]
       vmovsd    xmm24,qword ptr [rdx+68]
       vmovsd    xmm25,qword ptr [rdx+70]
       vmovsd    xmm26,qword ptr [rdx+78]
       mov       rdx,[rcx+10]
       cmp       eax,[rdx+8]
       jae       near ptr M00_L03
       lea       rdx,[rdx+r8+10]
       vmulsd    xmm27,xmm21,xmm26
       vmulsd    xmm28,xmm22,xmm25
       vsubsd    xmm27,xmm27,xmm28
       vmulsd    xmm28,xmm20,xmm26
       vmulsd    xmm29,xmm22,xmm24
       vsubsd    xmm28,xmm28,xmm29
       vmulsd    xmm29,xmm20,xmm25
       vmulsd    xmm30,xmm21,xmm24
       vsubsd    xmm29,xmm29,xmm30
       vmulsd    xmm30,xmm19,xmm26
       vmulsd    xmm31,xmm22,xmm23
       vsubsd    xmm30,xmm30,xmm31
       vmulsd    xmm31,xmm19,xmm25
       vmulsd    xmm6,xmm21,xmm23
       vsubsd    xmm31,xmm31,xmm6
       vmulsd    xmm6,xmm19,xmm24
       vmulsd    xmm7,xmm20,xmm23
       vsubsd    xmm6,xmm6,xmm7
       vmulsd    xmm7,xmm16,xmm27
       vmulsd    xmm8,xmm17,xmm28
       vsubsd    xmm7,xmm7,xmm8
       vmulsd    xmm8,xmm18,xmm29
       vaddsd    xmm7,xmm8,xmm7
       vmovsd    qword ptr [rdx],xmm7
       vmulsd    xmm8,xmm27,xmm5
       vmulsd    xmm9,xmm17,xmm30
       vsubsd    xmm8,xmm8,xmm9
       vmulsd    xmm9,xmm18,xmm31
       vaddsd    xmm8,xmm8,xmm9
       vxorps    xmm8,xmm8,[7FFEA6E58FD0]
       vmovsd    qword ptr [rdx+20],xmm8
       vmulsd    xmm9,xmm28,xmm5
       vmulsd    xmm10,xmm16,xmm30
       vsubsd    xmm9,xmm9,xmm10
       vmulsd    xmm10,xmm18,xmm6
       vaddsd    xmm9,xmm9,xmm10
       vmovsd    qword ptr [rdx+40],xmm9
       vmulsd    xmm10,xmm29,xmm5
       vmulsd    xmm11,xmm16,xmm31
       vsubsd    xmm10,xmm10,xmm11
       vmulsd    xmm11,xmm17,xmm6
       vaddsd    xmm10,xmm10,xmm11
       vxorps    xmm10,xmm10,[7FFEA6E58FE0]
       vmovsd    qword ptr [rdx+60],xmm10
       vmulsd    xmm7,xmm1,xmm7
       vmulsd    xmm8,xmm8,xmm2
       vaddsd    xmm7,xmm8,xmm7
       vmulsd    xmm8,xmm9,xmm3
       vaddsd    xmm7,xmm8,xmm7
       vmulsd    xmm8,xmm10,xmm4
       vaddsd    xmm7,xmm8,xmm7
       vandps    xmm8,xmm7,[7FFEA6E58FF0]
       vucomisd  xmm0,xmm8
       jb        short M00_L02
M00_L01:
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       vzeroupper
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       vmovaps   xmm9,[rsp+40]
       vmovaps   xmm10,[rsp+30]
       vmovaps   xmm11,[rsp+20]
       add       rsp,88
       ret
M00_L02:
       vmulsd    xmm8,xmm27,xmm2
       vmulsd    xmm9,xmm28,xmm3
       vsubsd    xmm8,xmm8,xmm9
       vmulsd    xmm9,xmm29,xmm4
       vaddsd    xmm8,xmm8,xmm9
       vxorps    xmm8,xmm8,[7FFEA6E59000]
       vmovsd    qword ptr [rdx+8],xmm8
       vmulsd    xmm27,xmm27,xmm1
       vmulsd    xmm8,xmm30,xmm3
       vsubsd    xmm27,xmm27,xmm8
       vmulsd    xmm8,xmm31,xmm4
       vaddsd    xmm27,xmm27,xmm8
       vmovsd    qword ptr [rdx+28],xmm27
       vmulsd    xmm28,xmm28,xmm1
       vmulsd    xmm30,xmm30,xmm2
       vsubsd    xmm27,xmm28,xmm30
       vmulsd    xmm28,xmm4,xmm6
       vaddsd    xmm27,xmm27,xmm28
       vxorps    xmm27,xmm27,[7FFEA6E59010]
       vmovsd    qword ptr [rdx+48],xmm27
       vmulsd    xmm29,xmm29,xmm1
       vmulsd    xmm31,xmm31,xmm2
       vsubsd    xmm27,xmm29,xmm31
       vmulsd    xmm28,xmm3,xmm6
       vaddsd    xmm27,xmm27,xmm28
       vmovsd    qword ptr [rdx+68],xmm27
       vmulsd    xmm27,xmm17,xmm26
       vmulsd    xmm28,xmm18,xmm25
       vsubsd    xmm27,xmm27,xmm28
       vmulsd    xmm28,xmm16,xmm26
       vmulsd    xmm29,xmm18,xmm24
       vsubsd    xmm28,xmm28,xmm29
       vmulsd    xmm29,xmm16,xmm25
       vmulsd    xmm30,xmm17,xmm24
       vsubsd    xmm29,xmm29,xmm30
       vmulsd    xmm26,xmm26,xmm5
       vmulsd    xmm30,xmm18,xmm23
       vsubsd    xmm30,xmm26,xmm30
       vmulsd    xmm25,xmm25,xmm5
       vmulsd    xmm26,xmm17,xmm23
       vsubsd    xmm31,xmm25,xmm26
       vmulsd    xmm24,xmm24,xmm5
       vmulsd    xmm23,xmm16,xmm23
       vsubsd    xmm6,xmm24,xmm23
       vmulsd    xmm23,xmm27,xmm2
       vmulsd    xmm24,xmm28,xmm3
       vsubsd    xmm23,xmm23,xmm24
       vmulsd    xmm24,xmm29,xmm4
       vaddsd    xmm23,xmm23,xmm24
       vmovsd    qword ptr [rdx+10],xmm23
       vmulsd    xmm27,xmm27,xmm1
       vmulsd    xmm23,xmm30,xmm3
       vsubsd    xmm23,xmm27,xmm23
       vmulsd    xmm24,xmm31,xmm4
       vaddsd    xmm23,xmm23,xmm24
       vxorps    xmm23,xmm23,[7FFEA6E59020]
       vmovsd    qword ptr [rdx+30],xmm23
       vmulsd    xmm28,xmm28,xmm1
       vmulsd    xmm30,xmm30,xmm2
       vsubsd    xmm23,xmm28,xmm30
       vmulsd    xmm24,xmm4,xmm6
       vaddsd    xmm23,xmm23,xmm24
       vmovsd    qword ptr [rdx+50],xmm23
       vmulsd    xmm29,xmm29,xmm1
       vmulsd    xmm31,xmm31,xmm2
       vsubsd    xmm23,xmm29,xmm31
       vmulsd    xmm24,xmm3,xmm6
       vaddsd    xmm23,xmm23,xmm24
       vxorps    xmm23,xmm23,[7FFEA6E59030]
       vmovsd    qword ptr [rdx+70],xmm23
       vmulsd    xmm23,xmm17,xmm22
       vmulsd    xmm24,xmm18,xmm21
       vsubsd    xmm27,xmm23,xmm24
       vmulsd    xmm23,xmm16,xmm22
       vmulsd    xmm24,xmm18,xmm20
       vsubsd    xmm28,xmm23,xmm24
       vmulsd    xmm23,xmm16,xmm21
       vmulsd    xmm24,xmm17,xmm20
       vsubsd    xmm29,xmm23,xmm24
       vmulsd    xmm22,xmm22,xmm5
       vmulsd    xmm18,xmm18,xmm19
       vsubsd    xmm30,xmm22,xmm18
       vmulsd    xmm18,xmm21,xmm5
       vmulsd    xmm17,xmm17,xmm19
       vsubsd    xmm31,xmm18,xmm17
       vmulsd    xmm5,xmm20,xmm5
       vmulsd    xmm16,xmm16,xmm19
       vsubsd    xmm6,xmm5,xmm16
       vmulsd    xmm5,xmm27,xmm2
       vmulsd    xmm16,xmm28,xmm3
       vsubsd    xmm5,xmm5,xmm16
       vmulsd    xmm16,xmm29,xmm4
       vaddsd    xmm5,xmm16,xmm5
       vxorps    xmm5,xmm5,[7FFEA6E59040]
       vmovsd    qword ptr [rdx+18],xmm5
       vmulsd    xmm5,xmm27,xmm1
       vmulsd    xmm16,xmm30,xmm3
       vsubsd    xmm5,xmm5,xmm16
       vmulsd    xmm16,xmm31,xmm4
       vaddsd    xmm5,xmm16,xmm5
       vmovsd    qword ptr [rdx+38],xmm5
       vmulsd    xmm5,xmm28,xmm1
       vmulsd    xmm16,xmm30,xmm2
       vsubsd    xmm5,xmm5,xmm16
       vmulsd    xmm4,xmm4,xmm6
       vaddsd    xmm4,xmm5,xmm4
       vxorps    xmm4,xmm4,[7FFEA6E59050]
       vmovsd    qword ptr [rdx+58],xmm4
       vmulsd    xmm1,xmm29,xmm1
       vmulsd    xmm2,xmm31,xmm2
       vsubsd    xmm1,xmm1,xmm2
       vmulsd    xmm2,xmm3,xmm6
       vaddsd    xmm1,xmm1,xmm2
       vmovsd    qword ptr [rdx+78],xmm1
       vmovups   zmm1,[rdx]
       vmovups   zmm2,[rdx+40]
       vmovsd    xmm3,qword ptr [7FFEA6E59060]
       vdivsd    xmm3,xmm3,xmm7
       vbroadcastsd zmm4,xmm3
       vmulpd    zmm1,zmm4,zmm1
       vmovups   [rdx],zmm1
       vbroadcastsd zmm1,xmm3
       vmulpd    zmm1,zmm1,zmm2
       vmovups   [rdx+40],zmm1
       jmp       near ptr M00_L01
M00_L03:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 1317
```

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Rotation()
       sub       rsp,0A8
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rsp+30],zmm4
       vmovdqu32 [rsp+60],zmm4
       mov       [rsp+0A0],rax
       xor       eax,eax
       mov       rdx,19AA42C8748
M00_L00:
       mov       r8,[rcx+10]
       mov       r10,[rcx+18]
       cmp       eax,[r10+8]
       jae       near ptr M00_L01
       mov       r9d,eax
       mov       r11,r9
       shl       r11,5
       vmovups   ymm0,[r10+r11+10]
       vpermq    ymm1,ymm0,0D2
       vpermq    ymm2,ymm0,0C9
       vmulpd    ymm2,ymm2,ymm0
       vpermq    ymm3,ymm0,0FF
       vmulpd    ymm1,ymm3,ymm1
       vmulpd    ymm0,ymm0,ymm0
       vaddpd    ymm3,ymm2,ymm1
       vsubpd    ymm1,ymm2,ymm1
       vaddpd    ymm2,ymm3,ymm3
       vaddpd    ymm1,ymm1,ymm1
       vpermq    ymm3,ymm0,0C9
       vaddpd    ymm0,ymm3,ymm0
       vaddpd    ymm0,ymm0,ymm0
       vbroadcastsd ymm3,qword ptr [7FFE955F8340]
       vsubpd    ymm0,ymm3,ymm0
       vmovaps   xmm3,xmm0
       vmovaps   xmm4,xmm1
       vunpckhpd xmm3,xmm3,xmm3
       vmovsd    xmm3,xmm4,xmm3
       vinsertf128 ymm3,ymm1,xmm3,0
       vmovaps   xmm4,xmm3
       vmovaps   ymm5,ymm2
       vunpcklpd xmm4,xmm4,xmm5
       vinsertf128 ymm3,ymm3,xmm4,0
       vextractf128 xmm4,ymm0,1
       vmovaps   xmm5,xmm1
       vunpcklpd xmm4,xmm5,xmm4
       vinsertf128 ymm4,ymm1,xmm4,0
       vmovaps   xmm5,xmm2
       vextractf32x4 xmm16,ymm4,1
       vunpckhpd xmm5,xmm5,xmm5
       vmovsd    xmm5,xmm16,xmm5
       vinsertf128 ymm4,ymm4,xmm5,1
       vextractf128 xmm2,ymm2,1
       vmovaps   xmm5,xmm1
       vmovsd    xmm2,xmm5,xmm2
       vinsertf128 ymm1,ymm1,xmm2,0
       vextractf128 xmm2,ymm1,1
       vmovsd    xmm0,xmm2,xmm0
       vinsertf128 ymm0,ymm1,xmm0,1
       vmovdqu   ymm1,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+88],ymm1
       vmovups   ymm1,[rsp+88]
       cmp       eax,[r8+8]
       jae       short M00_L01
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   [r8],ymm3
       vmovups   [r8+20],ymm4
       vmovups   [r8+40],ymm0
       vmovups   [r8+60],ymm1
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,0A8
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 381
```

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Transform()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   ymm0,[r8]
       vmovups   ymm1,[r8+20]
       vmovups   ymm2,[r8+40]
       vmovups   ymm3,[r8+60]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       shl       r10,5
       vmovups   ymm4,[r8+r10+10]
       vpermq    ymm5,ymm4,0C9
       vpermq    ymm16,ymm4,0FF
       vpermq    ymm17,ymm4,0D2
       vmulpd    ymm18,ymm5,ymm5
       vmulpd    ymm5,ymm5,ymm4
       vmulpd    ymm16,ymm17,ymm16
       vaddpd    ymm4,ymm16,ymm5
       vsubpd    ymm17,ymm5,ymm16
       vpermq    ymm4,ymm4,0D2
       vpermq    ymm5,ymm18,0C9
       vaddpd    ymm18,ymm18,ymm5
       vaddpd    ymm4,ymm4,ymm4
       vaddpd    ymm17,ymm17,ymm17
       vaddpd    ymm18,ymm18,ymm18
       vbroadcastsd ymm16,qword ptr [7FFE95619300]
       vsubpd    ymm18,ymm16,ymm18
       vpermq    ymm5,ymm0,0D2
       vpermq    ymm16,ymm0,0C9
       vmulpd    ymm19,ymm18,ymm0
       vfmadd213pd ymm16,ymm17,ymm19
       vfmadd213pd ymm5,ymm4,ymm16
       vpermq    ymm16,ymm1,0D2
       vpermq    ymm19,ymm1,0C9
       vmulpd    ymm20,ymm18,ymm1
       vfmadd213pd ymm19,ymm17,ymm20
       vfmadd213pd ymm16,ymm4,ymm19
       vpermq    ymm19,ymm2,0D2
       vpermq    ymm20,ymm2,0C9
       vmulpd    ymm18,ymm18,ymm2
       vfmadd231pd ymm18,ymm17,ymm20
       vfmadd231pd ymm18,ymm4,ymm19
       vextractf128 xmm0,ymm0,1
       vextractf32x4 xmm19,ymm5,1
       vunpckhpd xmm0,xmm0,xmm0
       vunpcklpd xmm0,xmm19,xmm0
       vinsertf128 ymm0,ymm5,xmm0,1
       vextractf128 xmm1,ymm1,1
       vextractf32x4 xmm5,ymm16,1
       vunpckhpd xmm1,xmm1,xmm1
       vunpcklpd xmm1,xmm5,xmm1
       vinsertf32x4 ymm1,ymm16,xmm1,1
       vextractf128 xmm2,ymm2,1
       vextractf32x4 xmm5,ymm18,1
       vunpckhpd xmm2,xmm2,xmm2
       vunpcklpd xmm2,xmm5,xmm2
       vinsertf32x4 ymm2,ymm18,xmm2,1
       vpermq    ymm5,ymm3,0D2
       vpermq    ymm16,ymm3,0C9
       vmulpd    ymm18,ymm18,ymm3
       vfmadd231pd ymm18,ymm17,ymm16
       vfmadd213pd ymm4,ymm5,ymm18
       vextractf128 xmm3,ymm3,1
       vextractf128 xmm5,ymm4,1
       vunpckhpd xmm3,xmm3,xmm3
       vunpcklpd xmm3,xmm5,xmm3
       vinsertf128 ymm3,ymm4,xmm3,1
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r9+10]
       vmovups   [rdx],ymm0
       vmovups   [rdx+20],ymm1
       vmovups   [rdx+40],ymm2
       vmovups   [rdx+60],ymm3
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 479
```

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Double, System.Private.CoreLib]].Affine()
       sub       rsp,28
       xor       eax,eax
       vmovsd    xmm0,qword ptr [7FFE95618D10]
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
       lea       r8,[r8+r9*8+10]
       vmovsd    xmm2,qword ptr [r8]
       vmovsd    xmm3,qword ptr [r8+8]
       vmovsd    xmm4,qword ptr [r8+10]
       mov       r8,[rcx+28]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
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
       vbroadcastsd ymm20,qword ptr [7FFE95618D10]
       vsubpd    ymm1,ymm20,ymm1
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
       vmulpd    ymm20,ymm20,ymm2
       vbroadcastsd ymm2,xmm3
       vmulpd    ymm21,ymm21,ymm2
       vbroadcastsd ymm2,xmm4
       vmulpd    ymm1,ymm2,ymm1
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,7
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],ymm20
       vmovups   [rdx+20],ymm21
       vmovups   [rdx+40],ymm1
       vmovsd    qword ptr [rdx+60],xmm5
       vmovsd    qword ptr [rdx+68],xmm16
       vmovsd    qword ptr [rdx+70],xmm17
       vmovsd    qword ptr [rdx+78],xmm0
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 495
```
