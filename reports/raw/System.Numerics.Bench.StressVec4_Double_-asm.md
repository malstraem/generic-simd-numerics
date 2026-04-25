## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Add()
       mov       rax,222FB000360
       mov       rax,[rax]
       mov       rcx,222FB000368
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Substract()
       mov       rax,1F189000360
       mov       rax,[rax]
       mov       rcx,1F189000368
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].MultiplyElementWise()
       mov       rax,2143CC00360
       mov       rax,[rax]
       mov       rcx,2143CC00368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,5
       lea       r10,[rax+r8+10]
       inc       edx
       mov       r9d,edx
       shl       r9,5
       vmovups   ymm0,[rax+r9+10]
       vmulpd    ymm0,ymm0,[r10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 84
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].DivideElementWise()
       mov       rax,19D55000360
       mov       rax,[rax]
       mov       rcx,19D55000368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,5
       lea       r10,[rax+r8+10]
       inc       edx
       mov       r9d,edx
       shl       r9,5
       vmovups   ymm0,[rax+r9+10]
       vmovups   ymm1,[r10]
       vdivpd    ymm0,ymm1,ymm0
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 88
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Abs()
       mov       rax,252CAC00360
       mov       rax,[rax]
       vbroadcastsd ymm0,qword ptr [7FFF431B9FE8]
       mov       rcx,252CAC00368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
       xchg      ax,ax
M00_L00:
       vandpd    ymm1,ymm0,[rax+rdx]
       vmovups   [rcx+rdx],ymm1
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 71
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Sum()
       mov       rax,2CCF7000360
       mov       rax,[rax]
       mov       rcx,2CCF7000370
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,25CB2C00360
       mov       rcx,[rcx]
       mov       rdx,25CB2C00370
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       vmovups   ymm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,5
       vmulpd    ymm0,ymm0,[rcx+r10+10]
       vhaddpd   ymm0,ymm0,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 97
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].LengthSquared()
       mov       rax,192A4C00360
       mov       rax,[rax]
       mov       rcx,192A4C00370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovups   ymm0,[r10]
       vmovaps   ymm1,ymm0
       vmulpd    ymm0,ymm1,ymm0
       vhaddpd   ymm0,ymm0,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 85
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,2888AC00360
       mov       rcx,[rcx]
       mov       rdx,2888AC00370
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Length()
       mov       rax,156D2800360
       mov       rax,[rax]
       mov       rcx,156D2800370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovups   ymm0,[r10]
       vmovaps   ymm1,ymm0
       vmulpd    ymm0,ymm1,ymm0
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
; Total bytes of code 89
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,22B2FC00360
       mov       rcx,[rcx]
       mov       rdx,22B2FC00370
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
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 108
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Normalize()
       mov       rax,24697400360
       mov       rax,[rax]
       mov       rcx,24697400368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   ymm0,[r10]
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
; Total bytes of code 95
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Transform()
       mov       rax,177B2000360
       mov       rax,[rax]
       mov       rcx,177B2000368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   ymm0,[7FFF431CA720]
       vmovups   ymm1,[7FFF431CA740]
       vbroadcastsd ymm2,qword ptr [r10]
       vmulpd    ymm2,ymm2,[7FFF431CA760]
       vfmadd132pd ymm1,ymm2,qword bcst [r10+8]
       vfmadd132pd ymm0,ymm1,qword bcst [r10+10]
       vmovups   ymm1,[7FFF431CA780]
       vfmadd231pd ymm0,ymm1,qword bcst [r10+18]
       vmovups   [rcx+rdx],ymm0
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 117
```

