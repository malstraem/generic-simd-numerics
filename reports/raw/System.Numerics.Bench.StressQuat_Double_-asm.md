## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Multiply()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       vmovups   ymm0,[7FFF431D9AE0]
       vmovups   ymm1,[7FFF431D9B00]
       vbroadcastf128 ymm2,xmmword ptr [7FFF431D9B20]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       near ptr M00_L01
       mov       rbx,rdx
       shl       rbx,5
       lea       r9,[r9+rbx+10]
       vmovsd    xmm3,qword ptr [r9]
       vmovsd    xmm4,qword ptr [r9+8]
       vmovsd    xmm5,qword ptr [r9+10]
       vmovsd    xmm16,qword ptr [r9+18]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr M00_L01
       mov       r11d,r9d
       shl       r11,5
       vmovups   ymm17,[r10+r11+10]
       vbroadcastsd ymm3,xmm3
       vbroadcastsd ymm4,xmm4
       vbroadcastsd ymm5,xmm5
       vbroadcastsd ymm16,xmm16
       vshufpd   ymm18,ymm17,ymm17,5
       vmulpd    ymm5,ymm18,ymm5
       vpermq    ymm18,ymm17,4E
       vmulpd    ymm4,ymm18,ymm4
       vpermq    ymm18,ymm17,1B
       vmulpd    ymm3,ymm18,ymm3
       vmulpd    ymm16,ymm17,ymm16
       vfmadd213pd ymm3,ymm2,ymm16
       vfmadd213pd ymm4,ymm1,ymm3
       vfmadd213pd ymm5,ymm0,ymm4
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+rbx+10],ymm5
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 251
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Divide()
       push      rbx
       sub       rsp,40
       vmovaps   [rsp+30],xmm6
       vmovaps   [rsp+20],xmm7
       mov       rax,[rcx+10]
       vmovups   ymm0,[7FFF431CAE20]
       vmovsd    xmm1,qword ptr [7FFF431CAE40]
       vmovups   ymm2,[7FFF431CAE60]
       vmovups   ymm3,[7FFF431CAE80]
       vbroadcastf128 ymm4,xmmword ptr [7FFF431CAEA0]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       near ptr M00_L01
       mov       rbx,rdx
       shl       rbx,5
       lea       r9,[r9+rbx+10]
       vmovsd    xmm5,qword ptr [r9]
       vmovsd    xmm16,qword ptr [r9+8]
       vmovsd    xmm17,qword ptr [r9+10]
       vmovsd    xmm18,qword ptr [r9+18]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       near ptr M00_L01
       mov       r11d,r9d
       shl       r11,5
       vmovups   ymm19,[r10+r11+10]
       vmulpd    ymm6,ymm19,ymm19
       vhaddpd   ymm6,ymm6,ymm6
       vperm2f128 ymm7,ymm6,ymm6,1
       vaddpd    ymm20,ymm7,ymm6
       vmulpd    ymm19,ymm0,ymm19
       vdivsd    xmm20,xmm1,xmm20
       vbroadcastsd ymm20,xmm20
       vmulpd    ymm19,ymm20,ymm19
       vbroadcastsd ymm5,xmm5
       vbroadcastsd ymm16,xmm16
       vbroadcastsd ymm17,xmm17
       vbroadcastsd ymm18,xmm18
       vshufpd   ymm20,ymm19,ymm19,5
       vmulpd    ymm17,ymm20,ymm17
       vpermq    ymm20,ymm19,4E
       vmulpd    ymm16,ymm20,ymm16
       vpermq    ymm20,ymm19,1B
       vmulpd    ymm5,ymm20,ymm5
       vmulpd    ymm18,ymm19,ymm18
       vfmadd213pd ymm5,ymm4,ymm18
       vfmadd213pd ymm16,ymm3,ymm5
       vfmadd213pd ymm17,ymm2,ymm16
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+rbx+10],ymm17
       mov       edx,r9d
       cmp       edx,1869F
       jl        near ptr M00_L00
       vzeroupper
       vmovaps   xmm6,[rsp+30]
       vmovaps   xmm7,[rsp+20]
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 347
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Conjugate()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovups   ymm0,[7FFF431B9B00]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,5
       vmulpd    ymm1,ymm0,[r10+r9+10]
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+r9+10],ymm1
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 82
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressQuat`1[[System.Double, System.Private.CoreLib]].Inverse()
       sub       rsp,28
       mov       rax,[rcx+10]
       vmovups   ymm0,[7FFF431BA760]
       vmovsd    xmm1,qword ptr [7FFF431BA780]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       cmp       edx,[r10+8]
       jae       short M00_L01
       mov       r9,rdx
       shl       r9,5
       lea       r10,[r10+r9+10]
       vmovups   ymm2,[r10]
       vmovaps   ymm3,ymm2
       vmulpd    ymm3,ymm3,ymm3
       vhaddpd   ymm3,ymm3,ymm3
       vperm2f128 ymm4,ymm3,ymm3,1
       vaddpd    ymm3,ymm4,ymm3
       vmulpd    ymm2,ymm0,ymm2
       vdivsd    xmm3,xmm1,xmm3
       vbroadcastsd ymm3,xmm3
       vmulpd    ymm2,ymm3,ymm2
       cmp       edx,[r8+8]
       jae       short M00_L01
       vmovups   [r8+r9+10],ymm2
       inc       edx
       cmp       edx,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 132
```

