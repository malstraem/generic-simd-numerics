## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Rotation()
       sub       rsp,28
       xor       eax,eax
       vbroadcastss xmm0,dword ptr [7FF7FD4EC8D0]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,4
       vmovups   xmm1,[r8+r9+10]
       vpermilps xmm2,xmm1,0D2
       vpermilps xmm3,xmm1,0C9
       vmulps    xmm3,xmm3,xmm1
       vpermilps xmm4,xmm1,0FF
       vmulps    xmm2,xmm4,xmm2
       vmulps    xmm1,xmm1,xmm1
       vaddps    xmm4,xmm3,xmm2
       vsubps    xmm2,xmm3,xmm2
       vaddps    xmm3,xmm4,xmm4
       vaddps    xmm2,xmm2,xmm2
       vpermilps xmm4,xmm1,0C9
       vaddps    xmm1,xmm4,xmm1
       vaddps    xmm1,xmm1,xmm1
       vsubps    xmm1,xmm0,xmm1
       vmovshdup xmm4,xmm1
       vinsertps xmm4,xmm2,xmm4,0
       vmovaps   xmm5,xmm3
       vinsertps xmm4,xmm4,xmm5,10
       vunpckhps xmm5,xmm1,xmm1
       vinsertps xmm5,xmm2,xmm5,10
       vmovshdup xmm16,xmm3
       vinsertps xmm5,xmm5,xmm16,20
       vunpckhps xmm3,xmm3,xmm3
       vinsertps xmm2,xmm2,xmm3,0
       vinsertps xmm1,xmm2,xmm1,20
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm4
       vmovups   [rdx+10],xmm5
       vmovups   [rdx+20],xmm1
       vmovups   xmm1,[7FF7FD4EC8E0]
       vmovups   [rdx+30],xmm1
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 238
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Transform()
       sub       rsp,28
       xor       eax,eax
       vbroadcastss xmm0,dword ptr [7FF7FD4CD008]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   xmm1,[r8]
       vmovups   xmm2,[r8+10]
       vmovups   xmm3,[r8+20]
       vmovups   xmm4,[r8+30]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       shl       r10,4
       vmovups   xmm5,[r8+r10+10]
       vpermilps xmm16,xmm5,0C9
       vpermilps xmm17,xmm5,0FF
       vpermilps xmm18,xmm5,0D2
       vmulps    xmm19,xmm16,xmm16
       vmulps    xmm16,xmm16,xmm5
       vmulps    xmm17,xmm18,xmm17
       vaddps    xmm5,xmm16,xmm17
       vsubps    xmm18,xmm16,xmm17
       vpermilps xmm5,xmm5,0D2
       vpermilps xmm16,xmm19,0C9
       vaddps    xmm19,xmm16,xmm19
       vaddps    xmm5,xmm5,xmm5
       vaddps    xmm18,xmm18,xmm18
       vaddps    xmm19,xmm19,xmm19
       vsubps    xmm19,xmm0,xmm19
       vpermilps xmm16,xmm1,0D2
       vpermilps xmm17,xmm1,0C9
       vmulps    xmm20,xmm19,xmm1
       vfmadd213ps xmm17,xmm18,xmm20
       vfmadd213ps xmm16,xmm5,xmm17
       vpermilps xmm17,xmm2,0D2
       vpermilps xmm20,xmm2,0C9
       vmulps    xmm21,xmm19,xmm2
       vfmadd213ps xmm20,xmm18,xmm21
       vfmadd213ps xmm17,xmm5,xmm20
       vpermilps xmm20,xmm3,0D2
       vpermilps xmm21,xmm3,0C9
       vmulps    xmm19,xmm19,xmm3
       vfmadd213ps xmm21,xmm18,xmm19
       vmovaps   xmm19,xmm20
       vfmadd213ps xmm19,xmm5,xmm21
       vshufps   xmm1,xmm1,xmm1,0FF
       vinsertps xmm1,xmm16,xmm1,30
       vshufps   xmm2,xmm2,xmm2,0FF
       vinsertps xmm2,xmm17,xmm2,30
       vshufps   xmm3,xmm3,xmm3,0FF
       vinsertps xmm3,xmm19,xmm3,30
       vpermilps xmm16,xmm4,0D2
       vpermilps xmm17,xmm4,0C9
       vmulps    xmm19,xmm19,xmm4
       vfmadd213ps xmm18,xmm17,xmm19
       vfmadd213ps xmm5,xmm16,xmm18
       vshufps   xmm4,xmm4,xmm4,0FF
       vinsertps xmm4,xmm5,xmm4,30
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rdx,[rdx+r9+10]
       vmovups   [rdx],xmm1
       vmovups   [rdx+10],xmm2
       vmovups   [rdx+20],xmm3
       vmovups   [rdx+30],xmm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 422
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Affine()
       sub       rsp,38
       xor       eax,eax
       vbroadcastss xmm0,dword ptr [7FF7FD4CD378]
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
       mov       r11,[r8+r9*4+10]
       mov       [rsp+28],r11
       mov       r11d,[r8+r9*4+18]
       mov       [rsp+30],r11d
       mov       r8,[rcx+28]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       lea       r8,[r8+r9*4+10]
       vmovss    xmm2,dword ptr [r8]
       vmovss    xmm3,dword ptr [r8+4]
       vmovss    xmm4,dword ptr [r8+8]
       vpermilps xmm5,xmm1,0D2
       vpermilps xmm16,xmm1,0C9
       vmulps    xmm16,xmm16,xmm1
       vpermilps xmm17,xmm1,0FF
       vmulps    xmm5,xmm17,xmm5
       vmulps    xmm1,xmm1,xmm1
       vaddps    xmm17,xmm16,xmm5
       vsubps    xmm5,xmm16,xmm5
       vaddps    xmm16,xmm17,xmm17
       vaddps    xmm5,xmm5,xmm5
       vpermilps xmm17,xmm1,0C9
       vaddps    xmm1,xmm17,xmm1
       vaddps    xmm1,xmm1,xmm1
       vsubps    xmm1,xmm0,xmm1
       vmovshdup xmm17,xmm1
       vinsertps xmm17,xmm5,xmm17,0
       vmovaps   xmm18,xmm16
       vinsertps xmm17,xmm17,xmm18,10
       vunpckhps xmm18,xmm1,xmm1
       vinsertps xmm18,xmm5,xmm18,10
       vmovshdup xmm19,xmm16
       vinsertps xmm18,xmm18,xmm19,20
       vunpckhps xmm16,xmm16,xmm16
       vinsertps xmm5,xmm5,xmm16,0
       vinsertps xmm1,xmm5,xmm1,20
       vmulps    xmm5,xmm17,dword bcst [rsp+28]
       vmulps    xmm16,xmm18,dword bcst [rsp+2C]
       vmulps    xmm1,xmm1,dword bcst [rsp+30]
       vinsertps xmm2,xmm0,xmm2,0
       vinsertps xmm2,xmm2,xmm3,10
       vinsertps xmm2,xmm2,xmm4,20
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm5
       vmovups   [rdx+10],xmm16
       vmovups   [rdx+20],xmm1
       vmovups   [rdx+30],xmm2
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,38
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 375
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Single, System.Private.CoreLib]].Add()
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 118
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Single, System.Private.CoreLib]].Subtract()
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 118
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Single, System.Private.CoreLib]].Multiply()
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
       vmulps    xmm18,xmm4,xmm18
       vfmadd231ps xmm18,xmm19,xmm5
       vfmadd231ps xmm18,xmm0,xmm16
       vfmadd231ps xmm18,xmm20,xmm17
       vmovaps   xmm0,xmm1
       vbroadcastss xmm0,xmm0
       vmovshdup xmm19,xmm1
       vpermilpd xmm20,xmm19,1
       vbroadcastss xmm20,xmm20
       vunpckhps xmm1,xmm1,xmm1
       vbroadcastss xmm1,xmm1
       vbroadcastss xmm19,xmm19
       vmulps    xmm0,xmm4,xmm0
       vfmadd231ps xmm0,xmm19,xmm5
       vfmadd231ps xmm0,xmm1,xmm16
       vfmadd231ps xmm0,xmm20,xmm17
       vmovaps   xmm1,xmm2
       vbroadcastss xmm1,xmm1
       vmovshdup xmm19,xmm2
       vpermilpd xmm20,xmm19,1
       vbroadcastss xmm20,xmm20
       vunpckhps xmm2,xmm2,xmm2
       vbroadcastss xmm2,xmm2
       vbroadcastss xmm19,xmm19
       vmulps    xmm1,xmm4,xmm1
       vfmadd231ps xmm1,xmm19,xmm5
       vfmadd231ps xmm1,xmm2,xmm16
       vfmadd231ps xmm1,xmm20,xmm17
       vmovaps   xmm2,xmm3
       vbroadcastss xmm2,xmm2
       vmovshdup xmm19,xmm3
       vpermilpd xmm20,xmm19,1
       vbroadcastss xmm20,xmm20
       vunpckhps xmm3,xmm3,xmm3
       vbroadcastss xmm3,xmm3
       vbroadcastss xmm19,xmm19
       vmulps    xmm2,xmm4,xmm2
       vfmadd213ps xmm5,xmm19,xmm2
       vfmadd213ps xmm16,xmm3,xmm5
       vfmadd213ps xmm17,xmm20,xmm16
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],xmm18
       vmovups   [rax+10],xmm0
       vmovups   [rax+20],xmm1
       vmovups   [rax+30],xmm17
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 438
```

