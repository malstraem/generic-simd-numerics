## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMat44`1[[System.Int32, System.Private.CoreLib]].Add()
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
       vpaddd    zmm0,zmm0,[r10+r11+10]
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
; System.Numerics.Bench.StressMat44`1[[System.Int32, System.Private.CoreLib]].Subtract()
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
       vpsubd    zmm0,zmm0,[r10+r11+10]
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
; System.Numerics.Bench.StressMat44`1[[System.Int32, System.Private.CoreLib]].Multiply()
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
       vmovd     r8d,xmm0
       vpbroadcastd xmm18,r8d
       vmovshdup xmm19,xmm0
       vmovd     r8d,xmm19
       vpbroadcastd xmm20,r8d
       vpmulld   xmm20,xmm20,xmm5
       vpmulld   xmm18,xmm4,xmm18
       vpaddd    xmm18,xmm18,xmm20
       vunpckhps xmm0,xmm0,xmm0
       vmovd     r8d,xmm0
       vpbroadcastd xmm0,r8d
       vpmulld   xmm0,xmm0,xmm16
       vpaddd    xmm0,xmm18,xmm0
       vpermilpd xmm18,xmm19,1
       vmovd     r8d,xmm18
       vpbroadcastd xmm18,r8d
       vpmulld   xmm18,xmm18,xmm17
       vpaddd    xmm0,xmm0,xmm18
       vmovd     r8d,xmm1
       vpbroadcastd xmm18,r8d
       vmovshdup xmm19,xmm1
       vmovd     r8d,xmm19
       vpbroadcastd xmm20,r8d
       vpmulld   xmm20,xmm20,xmm5
       vpmulld   xmm18,xmm4,xmm18
       vpaddd    xmm18,xmm18,xmm20
       vunpckhps xmm1,xmm1,xmm1
       vmovd     r8d,xmm1
       vpbroadcastd xmm1,r8d
       vpmulld   xmm1,xmm1,xmm16
       vpaddd    xmm1,xmm18,xmm1
       vpermilpd xmm18,xmm19,1
       vmovd     r8d,xmm18
       vpbroadcastd xmm18,r8d
       vpmulld   xmm18,xmm18,xmm17
       vpaddd    xmm1,xmm1,xmm18
       vmovd     r8d,xmm2
       vpbroadcastd xmm18,r8d
       vmovshdup xmm19,xmm2
       vmovd     r8d,xmm19
       vpbroadcastd xmm20,r8d
       vpmulld   xmm20,xmm20,xmm5
       vpmulld   xmm18,xmm4,xmm18
       vpaddd    xmm18,xmm18,xmm20
       vunpckhps xmm2,xmm2,xmm2
       vmovd     r8d,xmm2
       vpbroadcastd xmm2,r8d
       vpmulld   xmm2,xmm2,xmm16
       vpaddd    xmm2,xmm18,xmm2
       vpermilpd xmm18,xmm19,1
       vmovd     r8d,xmm18
       vpbroadcastd xmm18,r8d
       vpmulld   xmm18,xmm18,xmm17
       vpaddd    xmm2,xmm2,xmm18
       vmovd     r8d,xmm3
       vpbroadcastd xmm18,r8d
       vmovshdup xmm19,xmm3
       vmovd     r8d,xmm19
       vpbroadcastd xmm20,r8d
       vpmulld   xmm5,xmm20,xmm5
       vpmulld   xmm4,xmm4,xmm18
       vpaddd    xmm4,xmm4,xmm5
       vunpckhps xmm3,xmm3,xmm3
       vmovd     r8d,xmm3
       vpbroadcastd xmm3,r8d
       vpmulld   xmm3,xmm3,xmm16
       vpaddd    xmm3,xmm4,xmm3
       vpermilpd xmm4,xmm19,1
       vmovd     r8d,xmm4
       vpbroadcastd xmm4,r8d
       vpmulld   xmm4,xmm4,xmm17
       vpaddd    xmm3,xmm3,xmm4
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
; Total bytes of code 582
```

