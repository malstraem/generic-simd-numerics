## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Add()
       mov       rax,267CB401568
       mov       rax,[rax]
       mov       rcx,267CB401570
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
       jl        short 0000000000002E80
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Subtract()
       mov       rax,2152F401568
       mov       rax,[rax]
       mov       rcx,2152F401570
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
       jl        short 00000000000030A0
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Multiply()
       mov       rax,1EBF5801568
       mov       rax,[rax]
       mov       rcx,1EBF5801570
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
       jl        short 00000000000029A0
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Divide()
       sub       rsp,28
       mov       rax,21525C01578
       mov       rax,[rax]
       mov       rcx,21525C01580
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
       jne       short 0000000000002E2C
       vpcmpeqd  xmm2,xmm0,[2E50]
       vpcmpeqd  xmm3,xmm1,[2E40]
       vpand     xmm2,xmm2,xmm3
       vptest    xmm2,xmm2
       jne       short 0000000000002E32
       vcvtdq2pd ymm2,xmm0
       vcvtdq2pd ymm3,xmm1
       vdivpd    ymm0,ymm2,ymm3
       vcvttpd2dq xmm0,ymm0
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short 0000000000002DC0
       add       rsp,28
       ret
M00_L01:
       call      0000000000001638
       int       3
M00_L02:
       call      0000000000001608
       int       3
; Total bytes of code 152
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowDivideByZeroException()
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowOverflowException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Sum()
       mov       rax,1FB0CC01578
       mov       rax,[rax]
       mov       rcx,1FB0CC01588
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
       jne       short 00000000000028A2
       ret
; Total bytes of code 78
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,21C7CC01568
       mov       rcx,[rcx]
       mov       rdx,21C7CC01578
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
       jl        short 000000000000285C
       ret
; Total bytes of code 94
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].LengthSquared()
       mov       rax,12C8FC01568
       mov       rax,[rax]
       mov       rcx,12C8FC01578
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
       jne       short 0000000000002982
       ret
; Total bytes of code 71
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,258F8801568
       mov       rcx,[rcx]
       mov       rdx,258F8801578
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
       jl        short 0000000000002FDC
       ret
; Total bytes of code 98
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Transform()
       mov       rax,1D3E2801578
       mov       rax,[rax]
       mov       rcx,1D3E2801580
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
       vpmulld   xmm3,xmm3,[3D10]
       vpmulld   xmm1,xmm1,[3D20]
       vpaddd    xmm1,xmm1,xmm3
       vunpckhps xmm0,xmm0,xmm0
       vmovd     r10d,xmm0
       vpbroadcastd xmm0,r10d
       vpmulld   xmm0,xmm0,[3D30]
       vpaddd    xmm0,xmm1,xmm0
       vpermilpd xmm1,xmm2,1
       vmovd     r10d,xmm1
       vpbroadcastd xmm1,r10d
       vpmulld   xmm1,xmm1,[3D40]
       vpaddd    xmm0,xmm0,xmm1
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       near ptr 0000000000003C85
       ret
; Total bytes of code 171
```

