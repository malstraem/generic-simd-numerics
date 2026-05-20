## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.Add()
       xor       eax,eax
       mov       rcx,28728C00358
       mov       rcx,[rcx]
       mov       rdx,28728C00360
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       vmovsd    xmm0,qword ptr [rcx+r8*8+10]
       inc       eax
       mov       r10d,eax
       vmovsd    xmm1,qword ptr [rcx+r10*8+10]
       vaddps    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 73
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.Subtract()
       xor       eax,eax
       mov       rcx,22749000358
       mov       rcx,[rcx]
       mov       rdx,22749000360
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       vmovsd    xmm0,qword ptr [rcx+r8*8+10]
       inc       eax
       mov       r10d,eax
       vmovsd    xmm1,qword ptr [rcx+r10*8+10]
       vsubps    xmm0,xmm0,xmm1
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 73
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.MultiplyElementWise()
       xor       eax,eax
       mov       rcx,19825800358
       mov       rcx,[rcx]
       mov       rdx,19825800360
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       vmovsd    xmm0,qword ptr [rcx+r8*8+10]
       inc       eax
       mov       r10d,eax
       vmovsd    xmm1,qword ptr [rcx+r10*8+10]
       vmulps    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 73
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.DivideElementWise()
       xor       eax,eax
       mov       rcx,1C0B0000358
       mov       rcx,[rcx]
       mov       rdx,1C0B0000360
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       vmovsd    xmm0,qword ptr [rcx+r8*8+10]
       inc       eax
       mov       r10d,eax
       vmovsd    xmm1,qword ptr [rcx+r10*8+10]
       vdivps    xmm0,xmm0,xmm1
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 73
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.Abs()
       mov       rax,198D6800358
       mov       rax,[rax]
       vbroadcastss xmm0,dword ptr [7FFAC53596C8]
       mov       rcx,198D6800360
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
       xchg      ax,ax
M00_L00:
       vmovsd    xmm1,qword ptr [rax+rdx]
       vandps    xmm1,xmm1,xmm0
       vmovsd    qword ptr [rcx+rdx],xmm1
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 72
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.Sum()
       mov       rax,27185800358
       mov       rax,[rax]
       mov       rcx,27185800368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovsd    xmm0,qword ptr [rax+rdx*2+10]
       vinsertps xmm0,xmm0,xmm0,3C
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 82
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.Dot()
       xor       eax,eax
       mov       rcx,282C5C00358
       mov       rcx,[rcx]
       mov       rdx,282C5C00368
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       vmovsd    xmm0,qword ptr [rcx+r8*8+10]
       vinsertps xmm0,xmm0,xmm0,3C
       inc       eax
       mov       r10d,eax
       vmovsd    xmm1,qword ptr [rcx+r10*8+10]
       vinsertps xmm1,xmm1,xmm1,3C
       vdpps     xmm0,xmm0,xmm1,0FF
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 87
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.LengthSquared()
       mov       rax,227D2400358
       mov       rax,[rax]
       mov       rcx,227D2400368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       vmovsd    xmm0,qword ptr [r10]
       vinsertps xmm0,xmm0,xmm0,3C
       vdpps     xmm0,xmm0,xmm0,0FF
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 72
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.DistanceSquared()
       xor       eax,eax
       mov       rcx,24180000358
       mov       rcx,[rcx]
       mov       rdx,24180000368
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       vmovsd    xmm0,qword ptr [rcx+r8*8+10]
       inc       eax
       mov       r10d,eax
       vmovsd    xmm1,qword ptr [rcx+r10*8+10]
       vsubps    xmm0,xmm0,xmm1
       vinsertps xmm0,xmm0,xmm0,3C
       vdpps     xmm0,xmm0,xmm0,0FF
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 85
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.Length()
       mov       rax,26E25400358
       mov       rax,[rax]
       mov       rcx,26E25400368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       vmovsd    xmm0,qword ptr [r10]
       vinsertps xmm0,xmm0,xmm0,3C
       vdpps     xmm0,xmm0,xmm0,0FF
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 76
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.Distance()
       xor       eax,eax
       mov       rcx,29CD0800358
       mov       rcx,[rcx]
       mov       rdx,29CD0800368
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       vmovsd    xmm0,qword ptr [rcx+r8*8+10]
       inc       eax
       mov       r10d,eax
       vmovsd    xmm1,qword ptr [rcx+r10*8+10]
       vsubps    xmm0,xmm0,xmm1
       vinsertps xmm0,xmm0,xmm0,3C
       vdpps     xmm0,xmm0,xmm0,0FF
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 89
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector2.Normalize()
       mov       rax,280C9400358
       mov       rax,[rax]
       mov       rcx,280C9400360
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       vmovsd    xmm0,qword ptr [rax+rdx]
       vinsertps xmm1,xmm0,xmm0,3C
       vdpps     xmm1,xmm1,xmm1,0FF
       vsqrtss   xmm1,xmm1,xmm1
       vbroadcastss xmm1,xmm1
       vdivps    xmm0,xmm0,xmm1
       vmovsd    qword ptr [rcx+rdx],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 82
```

