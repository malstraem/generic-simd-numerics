## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int32, System.Private.CoreLib]].Add()
       mov       rax,24419800360
       mov       rax,[rax]
       mov       rcx,24419800368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,4
       vmovups   xmm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       vpaddd    xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int32, System.Private.CoreLib]].Subtract()
       mov       rax,245B0C00360
       mov       rax,[rax]
       mov       rcx,245B0C00368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,4
       vmovups   xmm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       vpsubd    xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int32, System.Private.CoreLib]].Multiply()
       mov       rax,216E2C00360
       mov       rax,[rax]
       mov       rcx,216E2C00368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,4
       vmovups   xmm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       vpmulld   xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int32, System.Private.CoreLib]].Divide()
       sub       rsp,28
       mov       rax,16FDFC00360
       mov       rax,[rax]
       mov       rcx,16FDFC00368
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       vmovups   xmm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       vmovups   xmm1,[rax+r10+10]
       vxorpd    xmm2,xmm2,xmm2
       vpcmpeqd  xmm2,xmm2,xmm1
       vptest    xmm2,xmm2
       jne       short M00_L01
       vpcmpeqd  xmm2,xmm0,[7FF7FD4FA240]
       vpcmpeqd  xmm3,xmm1,[7FF7FD4FA250]
       vpand     xmm2,xmm2,xmm3
       vptest    xmm2,xmm2
       jne       short M00_L02
       vcvtdq2pd ymm2,xmm0
       vcvtdq2pd ymm3,xmm1
       vdivpd    ymm0,ymm2,ymm3
       vcvttpd2dq xmm0,ymm0
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_THROWDIVZERO
       int       3
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 155
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int32, System.Private.CoreLib]].Sum()
       mov       rax,264AD000360
       mov       rax,[rax]
       mov       rcx,264AD000370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpsrldq   xmm1,xmm0,8
       vpaddd    xmm0,xmm1,xmm0
       vpsrldq   xmm1,xmm0,4
       vpaddd    xmm0,xmm1,xmm0
       vmovd     r10d,xmm0
       mov       [rcx+rdx+10],r10d
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 78
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int32, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,1E659C00360
       mov       rcx,[rcx]
       mov       rdx,1E659C00370
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       vmovups   xmm0,[rcx+r9+10]
       vmovups   xmm1,[r10]
       vpmulld   xmm0,xmm1,xmm0
       vphaddd   xmm0,xmm0,xmm0
       vphaddd   xmm0,xmm0,xmm0
       vmovd     dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 94
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int32, System.Private.CoreLib]].LengthSquared()
       mov       rax,1E568400360
       mov       rax,[rax]
       mov       rcx,1E568400370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpmulld   xmm0,xmm0,xmm0
       vphaddd   xmm0,xmm0,xmm0
       vphaddd   xmm0,xmm0,xmm0
       vmovd     dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 71
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int32, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,2E857C00360
       mov       rcx,[rcx]
       mov       rdx,2E857C00370
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       vmovups   xmm0,[rcx+r9+10]
       vmovups   xmm1,[r10]
       vpsubd    xmm0,xmm1,xmm0
       vpmulld   xmm0,xmm0,xmm0
       vphaddd   xmm0,xmm0,xmm0
       vphaddd   xmm0,xmm0,xmm0
       vmovd     dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 98
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int32, System.Private.CoreLib]].Transform()
       mov       rax,14CBE400360
       mov       rax,[rax]
       mov       rcx,14CBE400368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   xmm0,[r10]
       vmovd     r10d,xmm0
       vpbroadcastd xmm1,r10d
       vmovshdup xmm2,xmm0
       vmovd     r10d,xmm2
       vpbroadcastd xmm3,r10d
       vpmulld   xmm3,xmm3,[7FF7FD4EB010]
       vpmulld   xmm1,xmm1,[7FF7FD4EB020]
       vpaddd    xmm1,xmm1,xmm3
       vunpckhps xmm0,xmm0,xmm0
       vmovd     r10d,xmm0
       vpbroadcastd xmm0,r10d
       vpmulld   xmm0,xmm0,[7FF7FD4EB030]
       vpaddd    xmm0,xmm1,xmm0
       vpermilpd xmm1,xmm2,1
       vmovd     r10d,xmm1
       vpbroadcastd xmm1,r10d
       vpmulld   xmm1,xmm1,[7FF7FD4EB040]
       vpaddd    xmm0,xmm0,xmm1
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       near ptr M00_L00
       ret
; Total bytes of code 171
```

