## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Add()
       mov       rax,1309CC015A8
       mov       rax,[rax]
       mov       rcx,1309CC015B0
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
       jl        short 0000000000007B60
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Subtract()
       mov       rax,18A33C01568
       mov       rax,[rax]
       mov       rcx,18A33C01570
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
       jl        short 0000000000002B80
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Multiply()
       mov       rax,1F27A401568
       mov       rax,[rax]
       mov       rcx,1F27A401570
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
       jl        short 0000000000003340
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Divide()
       mov       rax,258F4C01568
       mov       rax,[rax]
       mov       rcx,258F4C01570
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
       jl        short 0000000000002BE0
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Abs()
       mov       rax,2136C401568
       mov       rax,[rax]
       vbroadcastss xmm0,dword ptr [2FE4]
       mov       rcx,2136C401570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
       xchg      ax,ax
M00_L00:
       vandps    xmm1,xmm0,[rax+rdx]
       vmovups   [rcx+rdx],xmm1
       add       rdx,10
       dec       r8d
       jne       short 0000000000002FD0
       ret
; Total bytes of code 68
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Sum()
       mov       rax,1C657C01568
       mov       rax,[rax]
       mov       rcx,1C657C01578
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
       jne       short 0000000000003182
       ret
; Total bytes of code 76
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Dot()
       xor       eax,eax
       mov       rcx,1F17A801568
       mov       rcx,[rcx]
       mov       rdx,1F17A801578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       vmovups   xmm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       vmulps    xmm0,xmm0,[rcx+r10+10]
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short 0000000000002D3C
       ret
; Total bytes of code 96
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.LengthSquared()
       mov       rax,1D2E1C01568
       mov       rax,[rax]
       mov       rcx,1D2E1C01578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short 0000000000002562
       ret
; Total bytes of code 80
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.DistanceSquared()
       xor       eax,eax
       mov       rcx,2144C001568
       mov       rcx,[rcx]
       mov       rdx,2144C001578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       vmovups   xmm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       vsubps    xmm0,xmm0,[rcx+r10+10]
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short 0000000000002F1C
       ret
; Total bytes of code 100
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Length()
       mov       rax,1CADEC01568
       mov       rax,[rax]
       mov       rcx,1CADEC01578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short 0000000000003422
       ret
; Total bytes of code 84
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Distance()
       xor       eax,eax
       mov       rcx,1E1D7001568
       mov       rcx,[rcx]
       mov       rdx,1E1D7001588
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       vmovups   xmm0,[rcx+r10+10]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       vsubps    xmm0,xmm0,[rcx+r10+10]
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short 00000000000048BC
       ret
; Total bytes of code 104
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Normalize()
       mov       rax,1CFB3401568
       mov       rax,[rax]
       mov       rcx,1CFB3401570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx]
       vmulps    xmm1,xmm0,xmm0
       vpermilps xmm2,xmm1,0B1
       vaddps    xmm1,xmm2,xmm1
       vpermilps xmm2,xmm1,4E
       vaddps    xmm1,xmm2,xmm1
       vsqrtps   xmm1,xmm1
       vdivps    xmm0,xmm0,xmm1
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short 00000000000032C5
       ret
; Total bytes of code 89
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4.Transform()
       mov       rax,236CD001568
       mov       rax,[rax]
       mov       rcx,236CD001570
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
       vmulps    xmm3,xmm3,[2F10]
       vfmadd132ps xmm2,xmm3,[2F20]
       vfmadd132ps xmm1,xmm2,[2F30]
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd132ps xmm0,xmm1,[2F40]
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short 0000000000002EA5
       ret
; Total bytes of code 129
```

