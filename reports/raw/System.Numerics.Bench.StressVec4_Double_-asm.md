## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Length()
       mov       rax,1B9B9800360
       mov       rax,[rax]
       mov       rcx,1B9B9800370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vmulpd    ymm0,ymm0,ymm0
       vhaddpd   ymm0,ymm0,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,25A92400360
       mov       rcx,[rcx]
       mov       rdx,25A92400370
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       vmovups   ymm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,5
       vsubpd    ymm0,ymm0,[rcx+r10+10]
       vmulpd    ymm0,ymm0,ymm0
       vhaddpd   ymm0,ymm0,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 101
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Normalize()
       mov       rax,1E952000360
       mov       rax,[rax]
       mov       rcx,1E952000368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx]
       vmulpd    ymm1,ymm0,ymm0
       vhaddpd   ymm1,ymm1,ymm1
       vperm2f128 ymm2,ymm1,ymm1,1
       vaddpd    ymm1,ymm2,ymm1
       vsqrtsd   xmm1,xmm1,xmm1
       vbroadcastsd ymm1,xmm1
       vdivpd    ymm0,ymm0,ymm1
       vmovups   [rcx+rdx],ymm0
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 91
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Double, System.Private.CoreLib]].Add()
       mov       rax,2829B400360
       mov       rax,[rax]
       mov       rcx,2829B400368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,5
       vmovups   ymm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       vaddpd    ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Double, System.Private.CoreLib]].Subtract()
       mov       rax,1B73BC00360
       mov       rax,[rax]
       mov       rcx,1B73BC00368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,5
       vmovups   ymm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       vsubpd    ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Double, System.Private.CoreLib]].Multiply()
       mov       rax,1B3EB800360
       mov       rax,[rax]
       mov       rcx,1B3EB800368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,5
       vmovups   ymm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       vmulpd    ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Double, System.Private.CoreLib]].Divide()
       mov       rax,2681D000360
       mov       rax,[rax]
       mov       rcx,2681D000368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,5
       vmovups   ymm0,[rax+r8+10]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       vdivpd    ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Double, System.Private.CoreLib]].Sum()
       mov       rax,205A2800360
       mov       rax,[rax]
       mov       rcx,205A2800370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vmovaps   ymm1,ymm0
       vpermilpd xmm2,xmm1,1
       vaddpd    xmm1,xmm2,xmm1
       vextractf128 xmm0,ymm0,1
       vpermilpd xmm2,xmm0,1
       vaddpd    xmm0,xmm2,xmm0
       vaddsd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 93
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Double, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,1F90C800360
       mov       rcx,[rcx]
       mov       rdx,1F90C800370
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,5
       vmovups   ymm0,[rcx+r9+10]
       vmovups   ymm1,[r10]
       vmulpd    ymm0,ymm1,ymm0
       vhaddpd   ymm0,ymm0,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 100
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Double, System.Private.CoreLib]].LengthSquared()
       mov       rax,1DB0B400360
       mov       rax,[rax]
       mov       rcx,1DB0B400370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vmulpd    ymm0,ymm0,ymm0
       vhaddpd   ymm0,ymm0,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 77
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Double, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,23231400360
       mov       rcx,[rcx]
       mov       rdx,23231400370
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,5
       vmovups   ymm0,[rcx+r9+10]
       vmovups   ymm1,[r10]
       vsubpd    ymm0,ymm1,ymm0
       vmulpd    ymm0,ymm0,ymm0
       vhaddpd   ymm0,ymm0,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 104
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Double, System.Private.CoreLib]].Transform()
       mov       rax,25CC1C00360
       mov       rax,[rax]
       mov       rcx,25CC1C00368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   ymm0,[r10]
       vmovaps   ymm1,ymm0
       vmovaps   xmm2,xmm1
       vbroadcastsd ymm2,xmm2
       vpermilpd xmm1,xmm1,1
       vperm2f128 ymm0,ymm0,ymm0,1
       vpermilpd xmm3,xmm0,1
       vbroadcastsd ymm3,xmm3
       vbroadcastsd ymm0,xmm0
       vbroadcastsd ymm1,xmm1
       vmulpd    ymm2,ymm2,[7FF7FD4CB460]
       vfmadd231pd ymm2,ymm1,[7FF7FD4CB480]
       vfmadd231pd ymm2,ymm0,[7FF7FD4CB4A0]
       vfmadd231pd ymm2,ymm3,[7FF7FD4CB4C0]
       vmovups   [rcx+rdx],ymm2
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 145
```

