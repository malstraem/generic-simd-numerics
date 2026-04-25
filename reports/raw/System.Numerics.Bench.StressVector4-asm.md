## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4.Add()
       mov       rax,27E91800360
       mov       rax,[rax]
       mov       rcx,27E91800368
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
; System.Numerics.Bench.StressVector4.Subtract()
       mov       rax,11C55000360
       mov       rax,[rax]
       mov       rcx,11C55000368
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
; System.Numerics.Bench.StressVector4.MultiplyElementWise()
       mov       rax,1625CC00360
       mov       rax,[rax]
       mov       rcx,1625CC00368
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
       vmulps    xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4.DivideElementWise()
       mov       rax,1521F000360
       mov       rax,[rax]
       mov       rcx,1521F000368
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
       vdivps    xmm0,xmm0,[rax+r10+10]
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       ret
; Total bytes of code 78
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4.Abs()
       mov       rax,2427FC00360
       mov       rax,[rax]
       vbroadcastss xmm0,dword ptr [7FFF431D9D28]
       mov       rcx,2427FC00368
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
; System.Numerics.Bench.StressVector4.Sum()
       mov       rax,17D21000360
       mov       rax,[rax]
       mov       rcx,17D21000370
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
; System.Numerics.Bench.StressVector4.Dot()
       xor       eax,eax
       mov       rcx,1BDE6C00360
       mov       rcx,[rcx]
       mov       rdx,1BDE6C00370
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
; System.Numerics.Bench.StressVector4.LengthSquared()
       mov       rax,1D307400360
       mov       rax,[rax]
       mov       rcx,1D307400370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovups   xmm0,[r10]
       vdpps     xmm0,xmm0,xmm0,0FF
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 80
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4.DistanceSquared()
       xor       eax,eax
       mov       rcx,169C2000360
       mov       rcx,[rcx]
       mov       rdx,169C2000370
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
       vsubps    xmm0,xmm0,[rcx+r10+10]
       vdpps     xmm0,xmm0,xmm0,0FF
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 86
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4.Length()
       mov       rax,25D87000360
       mov       rax,[rax]
       mov       rcx,25D87000370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovups   xmm0,[r10]
       vdpps     xmm0,xmm0,xmm0,0FF
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 70
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4.Distance()
       xor       eax,eax
       mov       rcx,20DD5800360
       mov       rcx,[rcx]
       mov       rdx,20DD5800370
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
       vsubps    xmm0,xmm0,[rcx+r10+10]
       vdpps     xmm0,xmm0,xmm0,0FF
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 90
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4.Normalize()
       mov       rax,279FFC00360
       mov       rax,[rax]
       mov       rcx,279FFC00368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx]
       vdpps     xmm1,xmm0,xmm0,0FF
       vsqrtps   xmm1,xmm1
       vdivps    xmm0,xmm0,xmm1
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 71
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4.Transform()
       mov       rax,22E0FC00360
       mov       rax,[rax]
       mov       rcx,22E0FC00368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx]
       vunpckhps xmm1,xmm0,xmm0
       vbroadcastss xmm1,xmm1
       vmovshdup xmm2,xmm0
       vbroadcastss xmm2,xmm2
       vmovaps   xmm3,xmm0
       vbroadcastss xmm3,xmm3
       vmulps    xmm3,xmm3,[7FFF431A9F90]
       vfmadd231ps xmm3,xmm2,[7FFF431A9FA0]
       vfmadd231ps xmm3,xmm1,[7FFF431A9FB0]
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm3,xmm0,[7FFF431A9FC0]
       vmovups   [rcx+rdx],xmm3
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 129
```

