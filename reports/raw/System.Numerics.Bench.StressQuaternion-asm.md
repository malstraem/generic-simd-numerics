## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuaternion.Multiply()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       vmovups   xmm0,[2D00]
       vmovddup  xmm1,qword ptr [2D10]
       vmovups   xmm2,[2D20]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       near ptr 0000000000002CED
       mov       rbx,rdx
       shl       rbx,4
       vmovups   xmm3,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr 0000000000002CED
       mov       r11d,r9d
       shl       r11,4
       vmovups   xmm4,[r10+r11+10]
       vpermilps xmm5,xmm4,4E
       vmovshdup xmm16,xmm3
       vbroadcastss xmm16,xmm16
       vmulps    xmm5,xmm16,xmm5
       vpermilps xmm16,xmm4,1B
       vmovaps   xmm17,xmm3
       vbroadcastss xmm17,xmm17
       vmulps    xmm16,xmm17,xmm16
       vshufps   xmm17,xmm3,xmm3,0FF
       vbroadcastss xmm17,xmm17
       vmulps    xmm17,xmm17,xmm4
       vfmadd213ps xmm16,xmm1,xmm17
       vfmadd213ps xmm5,xmm0,xmm16
       cmp       edx,[r8+8]
       jae       short 0000000000002CED
       vpermilps xmm4,xmm4,0B1
       vunpckhps xmm3,xmm3,xmm3
       vbroadcastss xmm3,xmm3
       vmulps    xmm3,xmm3,xmm4
       vfmadd213ps xmm3,xmm2,xmm5
       vmovups   [r8+rbx+10],xmm3
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr 0000000000002C23
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 243
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuaternion.Divide()
       push      rbx
       sub       rsp,30
       vmovaps   [rsp+20],xmm6
       mov       rax,[rcx+10]
       vmovups   xmm0,[2CF0]
       vbroadcastss xmm1,dword ptr [2D00]
       vmovups   xmm2,[2D10]
       vmovddup  xmm3,qword ptr [2D20]
       vmovups   xmm4,[2D30]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       near ptr 0000000000002CE7
       mov       rbx,rdx
       shl       rbx,4
       vmovups   xmm5,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr 0000000000002CE7
       mov       r11d,r9d
       shl       r11,4
       vmovups   xmm16,[r10+r11+10]
       vmulps    xmm17,xmm16,xmm16
       vpermilps xmm18,xmm17,0B1
       vaddps    xmm17,xmm18,xmm17
       vpermilps xmm18,xmm17,4E
       vaddps    xmm6,xmm18,xmm17
       vmulps    xmm16,xmm16,xmm0
       vdivps    xmm16,xmm16,xmm6
       vcmpnleps xmm6,xmm6,xmm1
       vandps    xmm16,xmm16,xmm6
       vpermilps xmm17,xmm16,4E
       vmovshdup xmm18,xmm5
       vbroadcastss xmm18,xmm18
       vmulps    xmm17,xmm18,xmm17
       vpermilps xmm18,xmm16,1B
       vmovaps   xmm19,xmm5
       vbroadcastss xmm19,xmm19
       vmulps    xmm18,xmm19,xmm18
       vshufps   xmm19,xmm5,xmm5,0FF
       vbroadcastss xmm19,xmm19
       vmulps    xmm19,xmm19,xmm16
       vfmadd213ps xmm18,xmm3,xmm19
       vfmadd213ps xmm17,xmm2,xmm18
       cmp       edx,[r8+8]
       jae       short 0000000000002CE7
       vpermilps xmm16,xmm16,0B1
       vunpckhps xmm5,xmm5,xmm5
       vbroadcastss xmm5,xmm5
       vmulps    xmm5,xmm16,xmm5
       vfmadd213ps xmm5,xmm4,xmm17
       vmovups   [r8+rbx+10],xmm5
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr 0000000000002BDA
       vmovaps   xmm6,[rsp+20]
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 333
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuaternion.Conjugate()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovups   xmm0,[2770]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short 0000000000002769
       mov       r9,rdx
       shl       r9,4
       vmulps    xmm1,xmm0,[r10+r9+10]
       cmp       edx,[r8+8]
       jae       short 0000000000002769
       vmovups   [r8+r9+10],xmm1
       inc       edx
       cmp       edx,186A0
       jl        short 0000000000002732
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 79
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuaternion.Inverse()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovups   xmm0,[2030]
       vbroadcastss xmm1,dword ptr [2040]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short 000000000000201B
       mov       r9,rdx
       shl       r9,4
       vmovups   xmm2,[r10+r9+10]
       vmulps    xmm3,xmm2,xmm2
       vpermilps xmm4,xmm3,0B1
       vaddps    xmm3,xmm4,xmm3
       vpermilps xmm4,xmm3,4E
       vaddps    xmm3,xmm4,xmm3
       cmp       edx,[r8+8]
       jae       short 000000000000201B
       vmulps    xmm2,xmm0,xmm2
       vdivps    xmm2,xmm2,xmm3
       vcmpnleps xmm3,xmm3,xmm1
       vandps    xmm2,xmm3,xmm2
       vmovups   [r8+r9+10],xmm2
       inc       edx
       cmp       edx,186A0
       jl        short 0000000000001FBB
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 129
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

