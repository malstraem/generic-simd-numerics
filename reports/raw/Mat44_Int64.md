## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method    | Mean     | Error   | StdDev  | Code Size |
|---------- |---------:|--------:|--------:|----------:|
| Add       | 266.8 μs | 1.84 μs | 1.53 μs |     144 B |
| Subtract  | 272.1 μs | 2.04 μs | 1.90 μs |     144 B |
| Multiply  | 554.7 μs | 7.48 μs | 7.00 μs |     618 B |
| Transpose | 242.1 μs | 4.79 μs | 4.48 μs |     173 B |

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Int64, System.Private.CoreLib]].Add()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       short 000000000000350A
       mov       r11,rax
       shl       r11,7
       lea       r10,[r10+r11+10]
       vmovups   zmm0,[r10]
       vmovups   zmm1,[r10+40]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       short 000000000000350A
       mov       r9d,r10d
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   zmm2,[r8]
       vmovups   zmm3,[r8+40]
       cmp       eax,[rdx+8]
       jae       short 000000000000350A
       lea       rax,[rdx+r11+10]
       vpaddq    zmm0,zmm0,zmm2
       vmovups   [rax],zmm0
       vpaddq    zmm0,zmm1,zmm3
       vmovups   [rax+40],zmm0
       mov       eax,r10d
       cmp       eax,1869F
       jl        short 0000000000003486
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 144
```

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Int64, System.Private.CoreLib]].Subtract()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       short 000000000000358A
       mov       r11,rax
       shl       r11,7
       lea       r10,[r10+r11+10]
       vmovups   zmm0,[r10]
       vmovups   zmm1,[r10+40]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       short 000000000000358A
       mov       r9d,r10d
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   zmm2,[r8]
       vmovups   zmm3,[r8+40]
       cmp       eax,[rdx+8]
       jae       short 000000000000358A
       lea       rax,[rdx+r11+10]
       vpsubq    zmm0,zmm0,zmm2
       vmovups   [rax],zmm0
       vpsubq    zmm0,zmm1,zmm3
       vmovups   [rax+40],zmm0
       mov       eax,r10d
       cmp       eax,1869F
       jl        short 0000000000003506
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 144
```

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Int64, System.Private.CoreLib]].Multiply()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr 0000000000005224
       mov       r11,rax
       shl       r11,7
       lea       r10,[r10+r11+10]
       vmovups   ymm0,[r10]
       vmovups   ymm1,[r10+20]
       vmovups   ymm2,[r10+40]
       vmovups   ymm3,[r10+60]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr 0000000000005224
       mov       r9d,r10d
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   ymm4,[r8]
       vmovups   ymm5,[r8+20]
       vmovups   ymm16,[r8+40]
       vmovups   ymm17,[r8+60]
       vmovaps   xmm18,xmm0
       vmovq     r8,xmm18
       vpbroadcastq ymm19,r8
       vpermilpd xmm18,xmm18,1
       vperm2f128 ymm0,ymm0,ymm0,1
       vmovq     r8,xmm18
       vpbroadcastq ymm18,r8
       vpmullq   ymm18,ymm18,ymm5
       vpmullq   ymm19,ymm4,ymm19
       vpaddq    ymm18,ymm19,ymm18
       vmovq     r8,xmm0
       vpbroadcastq ymm19,r8
       vpmullq   ymm19,ymm19,ymm16
       vpaddq    ymm18,ymm18,ymm19
       vpermilpd xmm0,xmm0,1
       vmovq     r8,xmm0
       vpbroadcastq ymm0,r8
       vpmullq   ymm0,ymm0,ymm17
       vpaddq    ymm0,ymm18,ymm0
       vmovaps   xmm18,xmm1
       vmovq     r8,xmm18
       vpbroadcastq ymm19,r8
       vpermilpd xmm18,xmm18,1
       vperm2f128 ymm1,ymm1,ymm1,1
       vmovq     r8,xmm18
       vpbroadcastq ymm18,r8
       vpmullq   ymm18,ymm18,ymm5
       vpmullq   ymm19,ymm4,ymm19
       vpaddq    ymm18,ymm19,ymm18
       vmovq     r8,xmm1
       vpbroadcastq ymm19,r8
       vpmullq   ymm19,ymm19,ymm16
       vpaddq    ymm18,ymm18,ymm19
       vpermilpd xmm1,xmm1,1
       vmovq     r8,xmm1
       vpbroadcastq ymm1,r8
       vpmullq   ymm1,ymm1,ymm17
       vpaddq    ymm1,ymm18,ymm1
       vmovaps   xmm18,xmm2
       vmovq     r8,xmm18
       vpbroadcastq ymm19,r8
       vpermilpd xmm18,xmm18,1
       vperm2f128 ymm2,ymm2,ymm2,1
       vmovq     r8,xmm18
       vpbroadcastq ymm18,r8
       vpmullq   ymm18,ymm18,ymm5
       vpmullq   ymm19,ymm4,ymm19
       vpaddq    ymm18,ymm19,ymm18
       vmovq     r8,xmm2
       vpbroadcastq ymm19,r8
       vpmullq   ymm19,ymm19,ymm16
       vpaddq    ymm18,ymm18,ymm19
       vpermilpd xmm2,xmm2,1
       vmovq     r8,xmm2
       vpbroadcastq ymm2,r8
       vpmullq   ymm2,ymm2,ymm17
       vpaddq    ymm2,ymm18,ymm2
       vmovaps   xmm18,xmm3
       vmovq     r8,xmm18
       vpbroadcastq ymm19,r8
       vpermilpd xmm18,xmm18,1
       vperm2f128 ymm3,ymm3,ymm3,1
       vmovq     r8,xmm18
       vpbroadcastq ymm18,r8
       vpmullq   ymm5,ymm18,ymm5
       vpmullq   ymm4,ymm4,ymm19
       vpaddq    ymm4,ymm4,ymm5
       vmovq     r8,xmm3
       vpbroadcastq ymm5,r8
       vpmullq   ymm5,ymm5,ymm16
       vpaddq    ymm4,ymm4,ymm5
       vpermilpd xmm3,xmm3,1
       vmovq     r8,xmm3
       vpbroadcastq ymm3,r8
       vpmullq   ymm3,ymm3,ymm17
       vpaddq    ymm3,ymm4,ymm3
       cmp       eax,[rdx+8]
       jae       short 0000000000005224
       lea       rax,[rdx+r11+10]
       vmovups   [rax],ymm0
       vmovups   [rax+20],ymm1
       vmovups   [rax+40],ymm2
       vmovups   [rax+60],ymm3
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000004FC6
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 618
```

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Int64, System.Private.CoreLib]].Transpose()
       sub       rsp,28
       vmovups   zmm0,[7FFEC1457AC0]
       vmovups   zmm1,[7FFEC1457B00]
       vmovups   zmm2,[7FFEC1457B40]
       vmovups   zmm3,[7FFEC1457B80]
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
       vpermt2q  zmm16,zmm1,zmm5
       vpermq    zmm16,zmm2,zmm16
       vmovups   [rdx],zmm16
       vpermt2q  zmm4,zmm3,zmm5
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
