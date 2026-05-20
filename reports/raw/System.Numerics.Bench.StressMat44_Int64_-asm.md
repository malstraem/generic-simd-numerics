## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Int64, System.Private.CoreLib]].Add()
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
       vpaddq    zmm0,zmm0,zmm2
       vmovups   [rax],zmm0
       vpaddq    zmm0,zmm1,zmm3
       vmovups   [rax+40],zmm0
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Int64, System.Private.CoreLib]].Subtract()
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
       vpsubq    zmm0,zmm0,zmm2
       vmovups   [rax],zmm0
       vpsubq    zmm0,zmm1,zmm3
       vmovups   [rax+40],zmm0
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Int64, System.Private.CoreLib]].Multiply()
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
       vmovaps   ymm18,ymm0
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
       vmovaps   ymm18,ymm1
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
       vmovaps   ymm18,ymm2
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
       vmovaps   ymm18,ymm3
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
; Total bytes of code 618
```

