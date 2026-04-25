## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Add()
       mov       rax,20278000360
       mov       rax,[rax]
       mov       rcx,20278000368
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
       vaddps    xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Substract()
       mov       rax,164FBC00360
       mov       rax,[rax]
       mov       rcx,164FBC00368
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
       vsubps    xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].MultiplyElementWise()
       mov       rax,17385000360
       mov       rax,[rax]
       mov       rcx,17385000368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       inc       edx
       mov       r9d,edx
       shl       r9,4
       vmovups   xmm0,[rax+r9+10]
       vmulps    xmm0,xmm0,[r10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 81
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].DivideElementWise()
       mov       rax,22ECF800360
       mov       rax,[rax]
       mov       rcx,22ECF800368
       mov       rcx,[rcx]
       xor       edx,edx
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       inc       edx
       mov       r9d,edx
       shl       r9,4
       vmovups   xmm0,[rax+r9+10]
       vmovups   xmm1,[r10]
       vdivps    xmm0,xmm1,xmm0
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 85
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Abs()
       mov       rax,236B9800360
       mov       rax,[rax]
       vbroadcastss xmm0,dword ptr [7FFF431A9DE8]
       mov       rcx,236B9800368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
       xchg      ax,ax
M00_L00:
       vandps    xmm1,xmm0,[rax+rdx]
       vmovups   [rcx+rdx],xmm1
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 68
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Sum()
       mov       rax,1ABDE000360
       mov       rax,[rax]
       mov       rcx,1ABDE000370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 76
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,2F28F400360
       mov       rcx,[rcx]
       mov       rdx,2F28F400370
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       vmovups   xmm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       vdpps     xmm0,xmm0,[rcx+r10+10],0FF
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 81
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].LengthSquared()
       mov       rax,26A1F400360
       mov       rax,[rax]
       mov       rcx,26A1F400370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovups   xmm0,[r10]
       vmovaps   xmm1,xmm0
       vdpps     xmm0,xmm1,xmm0,0FF
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 70
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,28319800360
       mov       rcx,[rcx]
       mov       rdx,28319800370
       mov       rdx,[rdx]
       nop       dword ptr [rax]
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
       vsubps    xmm0,xmm1,xmm0
       vdpps     xmm0,xmm0,xmm0,0FF
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 93
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Length()
       mov       rax,1C372400360
       mov       rax,[rax]
       mov       rcx,1C372400370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovups   xmm0,[r10]
       vmovaps   xmm1,xmm0
       vdpps     xmm0,xmm1,xmm0,0FF
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 74
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,16C37400360
       mov       rcx,[rcx]
       mov       rdx,16C37400370
       mov       rdx,[rdx]
       nop       dword ptr [rax]
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
       vsubps    xmm0,xmm1,xmm0
       vdpps     xmm0,xmm0,xmm0,0FF
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 97
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Normalize()
       mov       rax,15F59C00360
       mov       rax,[rax]
       mov       rcx,15F59C00368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   xmm0,[r10]
       vdpps     xmm1,xmm0,xmm0,0FF
       vsqrtps   xmm1,xmm1
       vdivps    xmm0,xmm0,xmm1
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 75
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4`2[[System.Single, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Transform()
       mov       rax,20598000360
       mov       rax,[rax]
       mov       rcx,20598000368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   xmm0,[7FFF431BA420]
       vmovups   xmm1,[7FFF431BA430]
       vbroadcastss xmm2,dword ptr [r10]
       vmulps    xmm2,xmm2,[7FFF431BA440]
       vfmadd132ps xmm1,xmm2,dword bcst [r10+4]
       vfmadd132ps xmm0,xmm1,dword bcst [r10+8]
       vmovups   xmm1,[7FFF431BA450]
       vfmadd231ps xmm0,xmm1,dword bcst [r10+0C]
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 114
```

