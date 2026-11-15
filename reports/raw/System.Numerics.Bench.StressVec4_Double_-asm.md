## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Length()
       mov       rax,22813801568
       mov       rax,[rax]
       mov       rcx,22813801578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vmulpd    ymm0,ymm0,ymm0
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short 0000000000003742
       vzeroupper
       ret
; Total bytes of code 87
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,1583E801568
       mov       rcx,[rcx]
       mov       rdx,1583E801578
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
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short 0000000000003C9C
       vzeroupper
       ret
; Total bytes of code 107
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Normalize()
       mov       rax,15AA0C01568
       mov       rax,[rax]
       mov       rcx,15AA0C01570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx]
       vmulpd    ymm1,ymm0,ymm0
       vpermilpd ymm2,ymm1,5
       vaddpd    ymm1,ymm2,ymm1
       vperm2f128 ymm2,ymm1,ymm1,1
       vaddpd    ymm1,ymm2,ymm1
       vsqrtsd   xmm1,xmm1,xmm1
       vbroadcastsd ymm1,xmm1
       vdivpd    ymm0,ymm0,ymm1
       vmovups   [rcx+rdx],ymm0
       add       rdx,20
       dec       r8d
       jne       short 0000000000003665
       vzeroupper
       ret
; Total bytes of code 97
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Add()
       mov       rax,18E78001568
       mov       rax,[rax]
       mov       rcx,18E78001570
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
       jl        short 0000000000003640
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Subtract()
       mov       rax,1BEF1801568
       mov       rax,[rax]
       mov       rcx,1BEF1801570
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
       jl        short 0000000000002DA0
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Multiply()
       mov       rax,2EDF5C01568
       mov       rax,[rax]
       mov       rcx,2EDF5C01570
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
       jl        short 00000000000040C0
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Divide()
       mov       rax,2374E001568
       mov       rax,[rax]
       mov       rcx,2374E001570
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
       jl        short 0000000000002E20
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Sum()
       mov       rax,2932D801578
       mov       rax,[rax]
       mov       rcx,2932D801588
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vpermilpd ymm1,ymm0,55
       vaddpd    ymm0,ymm1,ymm0
       vextractf128 xmm1,ymm0,1
       vaddpd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short 0000000000003202
       vzeroupper
       ret
; Total bytes of code 79
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,23CBEC01568
       mov       rcx,[rcx]
       mov       rdx,23CBEC01578
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
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short 0000000000002C5C
       vzeroupper
       ret
; Total bytes of code 106
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].LengthSquared()
       mov       rax,19EBAC01568
       mov       rax,[rax]
       mov       rcx,19EBAC01578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vmulpd    ymm0,ymm0,ymm0
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short 0000000000002D62
       vzeroupper
       ret
; Total bytes of code 83
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,23AA1001568
       mov       rcx,[rcx]
       mov       rdx,23AA1001578
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
       vpermilpd ymm1,ymm0,5
       vaddpd    ymm0,ymm1,ymm0
       vperm2f128 ymm1,ymm0,ymm0,1
       vaddpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short 0000000000003D9C
       vzeroupper
       ret
; Total bytes of code 110
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Transform()
       mov       rax,22135C01568
       mov       rax,[rax]
       mov       rcx,22135C01570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   ymm0,[r10]
       vmovaps   xmm1,xmm0
       vmovaps   xmm2,xmm1
       vbroadcastsd ymm2,xmm2
       vpermilpd xmm1,xmm1,1
       vperm2f128 ymm0,ymm0,ymm0,1
       vpermilpd xmm3,xmm0,1
       vbroadcastsd ymm3,xmm3
       vbroadcastsd ymm0,xmm0
       vbroadcastsd ymm1,xmm1
       vmulpd    ymm2,ymm2,[3DA0]
       vfmadd132pd ymm1,ymm2,[3DC0]
       vfmadd132pd ymm0,ymm1,[3DE0]
       vfmadd231pd ymm0,ymm3,[3E00]
       vmovups   [rcx+rdx],ymm0
       add       rdx,20
       dec       r8d
       jne       short 0000000000003D25
       vzeroupper
       ret
; Total bytes of code 145
```

