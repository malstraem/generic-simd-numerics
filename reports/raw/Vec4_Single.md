## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Single, System.Private.CoreLib]].Length()
       mov       rax,1AB36001568
       mov       rax,[rax]
       mov       rcx,1AB36001578
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
       jne       short 0000000000003DC2
       ret
; Total bytes of code 84
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Single, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,1C448C01568
       mov       rcx,[rcx]
       mov       rdx,1C448C01578
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
       jl        short 000000000000301C
       ret
; Total bytes of code 104
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Single, System.Private.CoreLib]].Normalize()
       mov       rax,1EE44C01568
       mov       rax,[rax]
       mov       rcx,1EE44C01570
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
       jne       short 0000000000003845
       ret
; Total bytes of code 89
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Add()
       mov       rax,1E513401568
       mov       rax,[rax]
       mov       rcx,1E513401570
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
       jl        short 0000000000003320
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Subtract()
       mov       rax,20417001578
       mov       rax,[rax]
       mov       rcx,20417001580
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
       jl        short 00000000000030E0
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Multiply()
       mov       rax,25667801578
       mov       rax,[rax]
       mov       rcx,25667801580
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
       jl        short 0000000000002D20
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Divide()
       mov       rax,17E0D801568
       mov       rax,[rax]
       mov       rcx,17E0D801570
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
       jl        short 0000000000002EE0
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Sum()
       mov       rax,23C80001568
       mov       rax,[rax]
       mov       rcx,23C80001578
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
       jne       short 0000000000003742
       ret
; Total bytes of code 76
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,1A14C001578
       mov       rcx,[rcx]
       mov       rdx,1A14C001588
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
       vmulps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short 000000000000393C
       ret
; Total bytes of code 103
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].LengthSquared()
       mov       rax,1D24A401568
       mov       rax,[rax]
       mov       rcx,1D24A401578
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
       jne       short 0000000000002D42
       ret
; Total bytes of code 80
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,28913001568
       mov       rcx,[rcx]
       mov       rdx,28913001578
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
       vsubps    xmm0,xmm1,xmm0
       vmulps    xmm0,xmm0,xmm0
       vpermilps xmm1,xmm0,0B1
       vaddps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,4E
       vaddps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short 0000000000003D5C
       ret
; Total bytes of code 107
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Single, System.Private.CoreLib]].Transform()
       mov       rax,179B6401568
       mov       rax,[rax]
       mov       rcx,179B6401570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   xmm0,[r10]
       vmovaps   xmm1,xmm0
       vbroadcastss xmm1,xmm1
       vmovshdup xmm2,xmm0
       vpermilpd xmm3,xmm2,1
       vbroadcastss xmm3,xmm3
       vunpckhps xmm0,xmm0,xmm0
       vbroadcastss xmm0,xmm0
       vbroadcastss xmm2,xmm2
       vmulps    xmm1,xmm1,[39B0]
       vfmadd231ps xmm1,xmm2,[39C0]
       vfmadd132ps xmm0,xmm1,[39D0]
       vfmadd231ps xmm0,xmm3,[39E0]
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short 0000000000003945
       ret
; Total bytes of code 134
```

