## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Rotation()
       sub       rsp,28
       xor       eax,eax
       vbroadcastss xmm0,dword ptr [7FFF431CA970]
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,4
       vmovups   xmm1,[r8+r9+10]
       vpshufd   xmm2,xmm1,0C9
       vpshufd   xmm3,xmm1,0FF
       vpshufd   xmm4,xmm1,0D2
       vmulps    xmm2,xmm2,xmm1
       vmulps    xmm3,xmm4,xmm3
       vmulps    xmm1,xmm1,xmm1
       vaddps    xmm5,xmm2,xmm3
       vsubps    xmm4,xmm2,xmm3
       vaddps    xmm5,xmm5,xmm5
       vaddps    xmm4,xmm4,xmm4
       vpshufd   xmm2,xmm1,0C9
       vaddps    xmm1,xmm2,xmm1
       vaddps    xmm1,xmm1,xmm1
       vsubps    xmm1,xmm0,xmm1
       vmovshdup xmm3,xmm1
       vinsertps xmm2,xmm4,xmm3,0
       vmovaps   xmm3,xmm5
       vinsertps xmm2,xmm2,xmm3,10
       vunpckhps xmm3,xmm1,xmm1
       vinsertps xmm3,xmm4,xmm3,10
       vmovshdup xmm16,xmm5
       vinsertps xmm3,xmm3,xmm16,20
       vunpckhps xmm5,xmm5,xmm5
       vinsertps xmm4,xmm4,xmm5,0
       vinsertps xmm4,xmm4,xmm1,20
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm2
       vmovups   [rdx+10],xmm3
       vmovups   [rdx+20],xmm4
       vmovups   xmm1,[7FFF431CA980]
       vmovups   [rdx+30],xmm1
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 234
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Transform()
       sub       rsp,28
       xor       eax,eax
       vbroadcastss xmm0,dword ptr [7FFF431DA8C0]
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
       vpshufd   xmm16,xmm5,0C9
       vpshufd   xmm17,xmm5,0FF
       vpshufd   xmm18,xmm5,0D2
       vmulps    xmm19,xmm16,xmm16
       vmulps    xmm16,xmm16,xmm5
       vmulps    xmm17,xmm18,xmm17
       vaddps    xmm5,xmm16,xmm17
       vsubps    xmm18,xmm16,xmm17
       vpshufd   xmm5,xmm5,0D2
       vpshufd   xmm16,xmm19,0C9
       vaddps    xmm19,xmm16,xmm19
       vaddps    xmm5,xmm5,xmm5
       vaddps    xmm18,xmm18,xmm18
       vaddps    xmm19,xmm19,xmm19
       vsubps    xmm19,xmm0,xmm19
       vpshufd   xmm16,xmm1,0D2
       vpshufd   xmm17,xmm1,0C9
       vmulps    xmm20,xmm19,xmm1
       vfmadd213ps xmm17,xmm18,xmm20
       vfmadd213ps xmm16,xmm5,xmm17
       vshufps   xmm1,xmm1,xmm1,0FF
       vinsertps xmm1,xmm16,xmm1,30
       vpshufd   xmm16,xmm2,0D2
       vpshufd   xmm17,xmm2,0C9
       vmulps    xmm20,xmm19,xmm2
       vfmadd213ps xmm17,xmm18,xmm20
       vfmadd213ps xmm16,xmm5,xmm17
       vshufps   xmm2,xmm2,xmm2,0FF
       vinsertps xmm2,xmm16,xmm2,30
       vpshufd   xmm16,xmm3,0D2
       vpshufd   xmm17,xmm3,0C9
       vmulps    xmm20,xmm19,xmm3
       vfmadd213ps xmm17,xmm18,xmm20
       vfmadd213ps xmm16,xmm5,xmm17
       vshufps   xmm3,xmm3,xmm3,0FF
       vinsertps xmm3,xmm16,xmm3,30
       vpshufd   xmm16,xmm4,0D2
       vpshufd   xmm17,xmm4,0C9
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
; Total bytes of code 415
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44WithQuat`1[[System.Single, System.Private.CoreLib]].Affine()
       sub       rsp,48
       xor       eax,eax
       vbroadcastss xmm0,dword ptr [7FFF431CAB58]
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
       mov       [rsp+38],r11
       mov       r11d,[r8+r9*4+18]
       mov       [rsp+40],r11d
       mov       r8,[rcx+28]
       cmp       eax,[r8+8]
       jae       near ptr M00_L01
       mov       r11,[r8+r9*4+10]
       mov       [rsp+28],r11
       mov       r11d,[r8+r9*4+18]
       mov       [rsp+30],r11d
       vpshufd   xmm2,xmm1,0C9
       vpshufd   xmm3,xmm1,0FF
       vpshufd   xmm4,xmm1,0D2
       vmulps    xmm2,xmm2,xmm1
       vmulps    xmm3,xmm4,xmm3
       vmulps    xmm1,xmm1,xmm1
       vaddps    xmm5,xmm2,xmm3
       vsubps    xmm4,xmm2,xmm3
       vaddps    xmm5,xmm5,xmm5
       vaddps    xmm4,xmm4,xmm4
       vpshufd   xmm2,xmm1,0C9
       vaddps    xmm1,xmm2,xmm1
       vaddps    xmm1,xmm1,xmm1
       vsubps    xmm1,xmm0,xmm1
       vmovshdup xmm3,xmm1
       vinsertps xmm2,xmm4,xmm3,0
       vmovaps   xmm3,xmm5
       vinsertps xmm2,xmm2,xmm3,10
       vunpckhps xmm3,xmm1,xmm1
       vinsertps xmm3,xmm4,xmm3,10
       vmovshdup xmm16,xmm5
       vinsertps xmm3,xmm3,xmm16,20
       vunpckhps xmm5,xmm5,xmm5
       vinsertps xmm4,xmm4,xmm5,0
       vinsertps xmm4,xmm4,xmm1,20
       vmulps    xmm1,xmm2,dword bcst [rsp+38]
       vmulps    xmm2,xmm3,dword bcst [rsp+3C]
       vmulps    xmm3,xmm4,dword bcst [rsp+40]
       vmovsd    xmm4,qword ptr [rsp+28]
       vmovsd    xmm4,xmm0,xmm4
       vinsertps xmm4,xmm4,dword ptr [rsp+30],20
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm1
       vmovups   [rdx+10],xmm2
       vmovups   [rdx+20],xmm3
       vmovups   [rdx+30],xmm4
       inc       eax
       cmp       eax,186A0
       jl        near ptr M00_L00
       add       rsp,48
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 340
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

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
       vbroadcastss xmm19,xmm19
       vunpckhps xmm20,xmm0,xmm0
       vbroadcastss xmm20,xmm20
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vmulps    xmm19,xmm19,xmm5
       vfmadd213ps xmm18,xmm4,xmm19
       vmulps    xmm0,xmm0,xmm17
       vfmadd213ps xmm20,xmm16,xmm0
       vaddps    xmm0,xmm20,xmm18
       vmovaps   xmm18,xmm1
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm1
       vbroadcastss xmm19,xmm19
       vunpckhps xmm20,xmm1,xmm1
       vbroadcastss xmm20,xmm20
       vshufps   xmm1,xmm1,xmm1,0FF
       vbroadcastss xmm1,xmm1
       vmulps    xmm19,xmm19,xmm5
       vfmadd213ps xmm18,xmm4,xmm19
       vmulps    xmm1,xmm1,xmm17
       vfmadd213ps xmm20,xmm16,xmm1
       vaddps    xmm1,xmm20,xmm18
       vmovaps   xmm18,xmm2
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm2
       vbroadcastss xmm19,xmm19
       vunpckhps xmm20,xmm2,xmm2
       vbroadcastss xmm20,xmm20
       vshufps   xmm2,xmm2,xmm2,0FF
       vbroadcastss xmm2,xmm2
       vmulps    xmm19,xmm19,xmm5
       vfmadd213ps xmm18,xmm4,xmm19
       vmulps    xmm2,xmm2,xmm17
       vfmadd213ps xmm20,xmm16,xmm2
       vaddps    xmm2,xmm20,xmm18
       vmovaps   xmm18,xmm3
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm3
       vbroadcastss xmm19,xmm19
       vunpckhps xmm20,xmm3,xmm3
       vbroadcastss xmm20,xmm20
       vshufps   xmm3,xmm3,xmm3,0FF
       vbroadcastss xmm3,xmm3
       vmulps    xmm5,xmm19,xmm5
       vfmadd213ps xmm4,xmm18,xmm5
       vmulps    xmm3,xmm3,xmm17
       vfmadd213ps xmm16,xmm20,xmm3
       vaddps    xmm3,xmm16,xmm4
       cmp       eax,[rdx+8]
       jae       short M00_L01
       lea       rax,[rdx+r11+10]
       vmovups   [rax],xmm0
       vmovups   [rax+10],xmm1
       vmovups   [rax+20],xmm2
       vmovups   [rax+30],xmm3
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 473
```

