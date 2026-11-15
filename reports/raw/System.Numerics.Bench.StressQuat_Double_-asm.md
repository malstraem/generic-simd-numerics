## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Multiply()
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
       jae       near ptr 000000000000485A
       mov       rbx,rdx
       shl       rbx,5
       vmovups   ymm0,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr 000000000000485A
       mov       r11d,r9d
       shl       r11,5
       vmovups   ymm1,[r10+r11+10]
       vmovaps   xmm2,xmm0
       vmovaps   xmm3,xmm2
       vbroadcastsd ymm3,xmm3
       vpermilpd xmm2,xmm2,1
       vperm2f128 ymm0,ymm0,ymm0,1
       vpermilpd xmm4,xmm0,1
       vbroadcastsd ymm2,xmm2
       vbroadcastsd ymm0,xmm0
       vbroadcastsd ymm4,xmm4
       vpermq    ymm5,ymm1,1B
       vmulpd    ymm3,ymm5,ymm3
       vpermq    ymm5,ymm1,4E
       vmulpd    ymm2,ymm5,ymm2
       vshufpd   ymm5,ymm1,ymm1,5
       vmulpd    ymm0,ymm5,ymm0
       vmulpd    ymm1,ymm1,ymm4
       vfmadd132pd ymm3,ymm1,[4860]
       vfmadd132pd ymm2,ymm3,[4880]
       vfmadd132pd ymm0,ymm2,[48A0]
       cmp       edx,[r8+8]
       jae       short 000000000000485A
       vmovups   [r8+rbx+10],ymm0
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr 000000000000478B
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 224
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Divide()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       vmovsd    xmm0,qword ptr [4FC0]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       near ptr 0000000000004FB9
       mov       rbx,rdx
       shl       rbx,5
       vmovups   ymm1,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr 0000000000004FB9
       mov       r11d,r9d
       shl       r11,5
       vmovups   ymm2,[r10+r11+10]
       vmulpd    ymm3,ymm2,ymm2
       vpermilpd ymm4,ymm3,5
       vaddpd    ymm3,ymm4,ymm3
       vperm2f128 ymm4,ymm3,ymm3,1
       vaddpd    ymm3,ymm4,ymm3
       vmulpd    ymm2,ymm2,[4FE0]
       vdivsd    xmm3,xmm0,xmm3
       vbroadcastsd ymm3,xmm3
       vmulpd    ymm2,ymm3,ymm2
       vmovaps   xmm3,xmm1
       vmovaps   xmm4,xmm3
       vbroadcastsd ymm4,xmm4
       vpermilpd xmm3,xmm3,1
       vperm2f128 ymm1,ymm1,ymm1,1
       vpermilpd xmm5,xmm1,1
       vbroadcastsd ymm3,xmm3
       vbroadcastsd ymm1,xmm1
       vbroadcastsd ymm5,xmm5
       vpermq    ymm16,ymm2,1B
       vmulpd    ymm4,ymm16,ymm4
       vpermq    ymm16,ymm2,4E
       vmulpd    ymm3,ymm16,ymm3
       vshufpd   ymm16,ymm2,ymm2,5
       vmulpd    ymm1,ymm16,ymm1
       vmulpd    ymm2,ymm2,ymm5
       vfmadd132pd ymm4,ymm2,[5000]
       vfmadd132pd ymm3,ymm4,[5020]
       vfmadd132pd ymm1,ymm3,[5040]
       cmp       edx,[r8+8]
       jae       short 0000000000004FB9
       vmovups   [r8+rbx+10],ymm1
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr 0000000000004EB3
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 287
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Conjugate()
       sub       rsp,28
       mov       rax,[rcx+10]
       xor       edx,edx
       nop       word ptr [rax+rax]
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short 00000000000036B2
       mov       r9,rdx
       shl       r9,5
       vmovups   ymm0,[r10+r9+10]
       vmulpd    ymm0,ymm0,[36C0]
       cmp       edx,[r8+8]
       jae       short 00000000000036B2
       vmovups   [r8+r9+10],ymm0
       inc       edx
       cmp       edx,186A0
       jl        short 0000000000003670
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 88
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Inverse()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovsd    xmm0,qword ptr [4340]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short 0000000000004339
       mov       r9,rdx
       shl       r9,5
       vmovups   ymm1,[r10+r9+10]
       vmulpd    ymm2,ymm1,ymm1
       vpermilpd ymm3,ymm2,5
       vaddpd    ymm2,ymm3,ymm2
       vperm2f128 ymm3,ymm2,ymm2,1
       vaddpd    ymm2,ymm3,ymm2
       vmulpd    ymm1,ymm1,[4360]
       cmp       edx,[r8+8]
       jae       short 0000000000004339
       vdivsd    xmm2,xmm0,xmm2
       vbroadcastsd ymm2,xmm2
       vmulpd    ymm1,ymm2,ymm1
       vmovups   [r8+r9+10],ymm1
       inc       edx
       cmp       edx,186A0
       jl        short 00000000000042D2
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 127
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

