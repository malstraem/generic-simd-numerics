## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Multiply()
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
       jae       near ptr 00000000000045D4
       mov       rbx,rdx
       shl       rbx,4
       vmovups   xmm0,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr 00000000000045D4
       mov       r11d,r9d
       shl       r11,4
       vmovups   xmm1,[r10+r11+10]
       vmovaps   xmm2,xmm0
       vbroadcastss xmm2,xmm2
       vmovshdup xmm3,xmm0
       vunpckhps xmm0,xmm0,xmm0
       vbroadcastss xmm0,xmm0
       vpermilps xmm4,xmm1,0B1
       vmulps    xmm0,xmm4,xmm0
       vmovaps   xmm4,xmm3
       vbroadcastss xmm4,xmm4
       vpermilps xmm5,xmm1,4E
       vmulps    xmm4,xmm5,xmm4
       vpermilps xmm5,xmm1,1B
       vmulps    xmm2,xmm5,xmm2
       vpermilpd xmm3,xmm3,1
       vbroadcastss xmm3,xmm3
       vmulps    xmm1,xmm3,xmm1
       vfmadd231ps xmm1,xmm2,[45E0]
       vfmadd231ps xmm1,xmm4,[45F0]
       vfmadd132ps xmm0,xmm1,[4600]
       cmp       edx,[r8+8]
       jae       short 00000000000045D4
       vmovups   [r8+rbx+10],xmm0
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr 000000000000450B
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 218
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Divide()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       vbroadcastss xmm0,dword ptr [4758]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       near ptr 0000000000004750
       mov       rbx,rdx
       shl       rbx,4
       vmovups   xmm1,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr 0000000000004750
       mov       r11d,r9d
       shl       r11,4
       vmovups   xmm2,[r10+r11+10]
       vmulps    xmm3,xmm2,xmm2
       vpermilps xmm4,xmm3,0B1
       vaddps    xmm3,xmm4,xmm3
       vpermilps xmm4,xmm3,4E
       vaddps    xmm3,xmm4,xmm3
       vmulps    xmm2,xmm2,[4760]
       vdivps    xmm2,xmm2,xmm3
       vcmpnleps xmm3,xmm3,xmm0
       vandps    xmm2,xmm3,xmm2
       vmovaps   xmm3,xmm1
       vbroadcastss xmm3,xmm3
       vmovshdup xmm4,xmm1
       vunpckhps xmm1,xmm1,xmm1
       vbroadcastss xmm1,xmm1
       vpermilps xmm5,xmm2,0B1
       vmulps    xmm1,xmm5,xmm1
       vmovaps   xmm5,xmm4
       vbroadcastss xmm5,xmm5
       vpermilps xmm16,xmm2,4E
       vmulps    xmm5,xmm16,xmm5
       vpermilps xmm16,xmm2,1B
       vmulps    xmm3,xmm16,xmm3
       vpermilpd xmm4,xmm4,1
       vbroadcastss xmm4,xmm4
       vmulps    xmm2,xmm4,xmm2
       vfmadd231ps xmm2,xmm3,[4770]
       vfmadd231ps xmm2,xmm5,[4780]
       vfmadd132ps xmm1,xmm2,[4790]
       cmp       edx,[r8+8]
       jae       short 0000000000004750
       vmovups   [r8+rbx+10],xmm1
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr 0000000000004654
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 278
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Conjugate()
       sub       rsp,28
       mov       rax,[rcx+10]
       xor       edx,edx
       nop       word ptr [rax+rax]
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short 000000000000326F
       mov       r9,rdx
       shl       r9,4
       vmovups   xmm0,[r10+r9+10]
       vmulps    xmm0,xmm0,[3280]
       cmp       edx,[r8+8]
       jae       short 000000000000326F
       vmovups   [r8+r9+10],xmm0
       inc       edx
       cmp       edx,186A0
       jl        short 0000000000003230
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 85
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Single, System.Private.CoreLib]].Inverse()
       sub       rsp,28
       mov       rax,[rcx+10]
       vbroadcastss xmm0,dword ptr [38C0]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short 00000000000038B7
       mov       r9,rdx
       shl       r9,4
       vmovups   xmm1,[r10+r9+10]
       vmulps    xmm2,xmm1,xmm1
       vpermilps xmm3,xmm2,0B1
       vaddps    xmm2,xmm3,xmm2
       vpermilps xmm3,xmm2,4E
       vaddps    xmm2,xmm3,xmm2
       cmp       edx,[r8+8]
       jae       short 00000000000038B7
       vmulps    xmm1,xmm1,[38D0]
       vdivps    xmm1,xmm1,xmm2
       vcmpnleps xmm2,xmm2,xmm0
       vandps    xmm1,xmm2,xmm1
       vmovups   [r8+r9+10],xmm1
       inc       edx
       cmp       edx,186A0
       jl        short 0000000000003853
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 125
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

