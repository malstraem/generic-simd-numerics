## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Double, System.Private.CoreLib]].Multiply()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr 0000000000002FA1
       mov       r11,rax
       shl       r11,5
       lea       r10,[r10+r11+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr 0000000000002FA1
       mov       r9d,r10d
       shl       r9,5
       lea       r8,[r8+r9+10]
       vmovsd    xmm4,qword ptr [r8]
       vmovsd    xmm5,qword ptr [r8+8]
       vmovsd    xmm16,qword ptr [r8+10]
       vmovsd    xmm17,qword ptr [r8+18]
       vmulsd    xmm18,xmm16,xmm1
       vmulsd    xmm19,xmm2,xmm5
       vsubsd    xmm18,xmm18,xmm19
       vmulsd    xmm19,xmm2,xmm4
       vmulsd    xmm20,xmm16,xmm0
       vsubsd    xmm19,xmm19,xmm20
       vmulsd    xmm20,xmm0,xmm5
       vmulsd    xmm21,xmm1,xmm4
       vsubsd    xmm20,xmm20,xmm21
       vmulsd    xmm21,xmm0,xmm4
       vmulsd    xmm22,xmm1,xmm5
       vaddsd    xmm21,xmm22,xmm21
       vmulsd    xmm22,xmm16,xmm2
       vaddsd    xmm21,xmm22,xmm21
       vmulsd    xmm0,xmm17,xmm0
       vmulsd    xmm4,xmm4,xmm3
       vaddsd    xmm0,xmm4,xmm0
       vaddsd    xmm0,xmm18,xmm0
       vmulsd    xmm1,xmm17,xmm1
       vmulsd    xmm4,xmm5,xmm3
       vaddsd    xmm1,xmm4,xmm1
       vaddsd    xmm1,xmm19,xmm1
       vmulsd    xmm2,xmm17,xmm2
       vmulsd    xmm4,xmm16,xmm3
       vaddsd    xmm2,xmm4,xmm2
       vaddsd    xmm2,xmm20,xmm2
       vmulsd    xmm3,xmm17,xmm3
       vsubsd    xmm3,xmm3,xmm21
       cmp       eax,[rdx+8]
       jae       short 0000000000002FA1
       lea       rax,[rdx+r11+10]
       vmovsd    qword ptr [rax],xmm0
       vmovsd    qword ptr [rax+8],xmm1
       vmovsd    qword ptr [rax+10],xmm2
       vmovsd    qword ptr [rax+18],xmm3
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000002E66
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 327
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Double, System.Private.CoreLib]].Divide()
       sub       rsp,28
       vmovsd    xmm0,qword ptr [2F58]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr 0000000000002F50
       mov       r11,rax
       shl       r11,5
       lea       r10,[r10+r11+10]
       vmovsd    xmm1,qword ptr [r10]
       vmovsd    xmm2,qword ptr [r10+8]
       vmovsd    xmm3,qword ptr [r10+10]
       vmovsd    xmm4,qword ptr [r10+18]
       lea       r10d,[rax+1]
       cmp       r10d,r9d
       jae       near ptr 0000000000002F50
       mov       r9d,r10d
       shl       r9,5
       lea       r8,[r8+r9+10]
       vmovsd    xmm5,qword ptr [r8]
       vmovsd    xmm16,qword ptr [r8+8]
       vmovsd    xmm17,qword ptr [r8+10]
       vmovsd    xmm18,qword ptr [r8+18]
       vmulsd    xmm19,xmm5,xmm5
       vmulsd    xmm20,xmm16,xmm16
       vaddsd    xmm19,xmm20,xmm19
       vmulsd    xmm20,xmm17,xmm17
       vaddsd    xmm19,xmm20,xmm19
       vmulsd    xmm20,xmm18,xmm18
       vaddsd    xmm19,xmm20,xmm19
       vdivsd    xmm19,xmm0,xmm19
       vmulsd    xmm5,xmm19,xmm5
       vxorps    xmm5,xmm5,[2F60]
       vmulsd    xmm16,xmm16,xmm19
       vxorps    xmm16,xmm16,[2F70]
       vmulsd    xmm17,xmm17,xmm19
       vxorps    xmm17,xmm17,[2F80]
       vmulsd    xmm18,xmm18,xmm19
       vmulsd    xmm19,xmm17,xmm2
       vmulsd    xmm20,xmm16,xmm3
       vsubsd    xmm19,xmm19,xmm20
       vmulsd    xmm20,xmm3,xmm5
       vmulsd    xmm21,xmm17,xmm1
       vsubsd    xmm20,xmm20,xmm21
       vmulsd    xmm21,xmm16,xmm1
       vmulsd    xmm22,xmm2,xmm5
       vsubsd    xmm21,xmm21,xmm22
       vmulsd    xmm22,xmm1,xmm5
       vmulsd    xmm23,xmm16,xmm2
       vaddsd    xmm22,xmm23,xmm22
       vmulsd    xmm23,xmm17,xmm3
       vaddsd    xmm22,xmm23,xmm22
       vmulsd    xmm1,xmm18,xmm1
       vmulsd    xmm5,xmm5,xmm4
       vaddsd    xmm1,xmm5,xmm1
       vaddsd    xmm1,xmm19,xmm1
       vmulsd    xmm2,xmm18,xmm2
       vmulsd    xmm5,xmm16,xmm4
       vaddsd    xmm2,xmm5,xmm2
       vaddsd    xmm2,xmm20,xmm2
       vmulsd    xmm3,xmm18,xmm3
       vmulsd    xmm5,xmm17,xmm4
       vaddsd    xmm3,xmm5,xmm3
       vaddsd    xmm3,xmm21,xmm3
       vmulsd    xmm4,xmm18,xmm4
       vsubsd    xmm4,xmm4,xmm22
       cmp       eax,[rdx+8]
       jae       short 0000000000002F50
       lea       rax,[rdx+r11+10]
       vmovsd    qword ptr [rax],xmm1
       vmovsd    qword ptr [rax+8],xmm2
       vmovsd    qword ptr [rax+10],xmm3
       vmovsd    qword ptr [rax+18],xmm4
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000002DAE
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 438
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Double, System.Private.CoreLib]].Conjugate()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short 00000000000024BA
       mov       r10,rax
       shl       r10,5
       lea       r8,[r8+r10+10]
       vmovsd    xmm0,qword ptr [r8]
       vmovsd    xmm1,qword ptr [r8+8]
       vmovsd    xmm2,qword ptr [r8+10]
       vmovsd    xmm3,qword ptr [r8+18]
       vxorps    xmm0,xmm0,[24C0]
       vxorps    xmm1,xmm1,[24C0]
       vxorps    xmm2,xmm2,[24C0]
       cmp       eax,[rdx+8]
       jae       short 00000000000024BA
       lea       rdx,[rdx+r10+10]
       vmovsd    qword ptr [rdx],xmm0
       vmovsd    qword ptr [rdx+8],xmm1
       vmovsd    qword ptr [rdx+10],xmm2
       vmovsd    qword ptr [rdx+18],xmm3
       inc       eax
       cmp       eax,186A0
       jl        short 0000000000002446
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 128
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressQuaternion`1[[System.Double, System.Private.CoreLib]].Inverse()
       sub       rsp,28
       vmovsd    xmm0,qword ptr [3210]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000003206
       mov       r10,rax
       shl       r10,5
       lea       r8,[r8+r10+10]
       vmovsd    xmm1,qword ptr [r8]
       vmovsd    xmm2,qword ptr [r8+8]
       vmovsd    xmm3,qword ptr [r8+10]
       vmovsd    xmm4,qword ptr [r8+18]
       vmulsd    xmm5,xmm1,xmm1
       vmulsd    xmm16,xmm2,xmm2
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm3,xmm3
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm4,xmm4
       vaddsd    xmm5,xmm16,xmm5
       vdivsd    xmm5,xmm0,xmm5
       vmulsd    xmm1,xmm1,xmm5
       vxorps    xmm1,xmm1,[3220]
       vmulsd    xmm2,xmm2,xmm5
       vxorps    xmm2,xmm2,[3230]
       vmulsd    xmm3,xmm3,xmm5
       vxorps    xmm3,xmm3,[3240]
       vmulsd    xmm4,xmm4,xmm5
       cmp       eax,[rdx+8]
       jae       short 0000000000003206
       lea       rdx,[rdx+r10+10]
       vmovsd    qword ptr [rdx],xmm1
       vmovsd    qword ptr [rdx+8],xmm2
       vmovsd    qword ptr [rdx+10],xmm3
       vmovsd    qword ptr [rdx+18],xmm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr 000000000000314E
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 204
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

