## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int64, System.Private.CoreLib]].Add()
       mov       rax,18C7E400360
       mov       rax,[rax]
       mov       rcx,18C7E400368
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
       vpaddq    ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int64, System.Private.CoreLib]].Subtract()
       mov       rax,26134000360
       mov       rax,[rax]
       mov       rcx,26134000368
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
       vpsubq    ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int64, System.Private.CoreLib]].Multiply()
       mov       rax,2749D400360
       mov       rax,[rax]
       mov       rcx,2749D400368
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
       vpmullq   ymm0,ymm0,[rax+r10+10]
       vmovups   [rcx+r8+10],ymm0
       cmp       edx,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 85
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int64, System.Private.CoreLib]].Divide()
       sub       rsp,0C8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rsp],zmm4
       vmovdqu32 [rsp+40],zmm4
       vmovdqu32 [rsp+80],ymm4
       mov       rax,14472800360
       mov       rcx,[rax]
       xor       r8d,r8d
M00_L00:
       mov       rax,r8
       shl       rax,5
       vmovups   ymm0,[rcx+rax+10]
       lea       r10d,[r8+1]
       mov       eax,r10d
       shl       rax,5
       vmovups   ymm1,[rcx+rax+10]
       vmovaps   ymm2,ymm0
       vmovaps   [rsp+0B0],xmm2
       vmovaps   ymm2,ymm1
       vmovaps   [rsp+0A0],xmm2
       mov       rax,[rsp+0B0]
       mov       [rsp+90],rax
       mov       rax,[rsp+0A0]
       mov       [rsp+88],rax
       mov       rax,[rsp+90]
       cqo
       idiv      qword ptr [rsp+88]
       mov       [rsp+98],rax
       mov       r9,[rsp+98]
       mov       rax,[rsp+0B8]
       mov       [rsp+78],rax
       mov       rax,[rsp+0A8]
       mov       [rsp+70],rax
       mov       rax,[rsp+78]
       cqo
       idiv      qword ptr [rsp+70]
       mov       [rsp+80],rax
       mov       rax,[rsp+80]
       mov       [rsp+60],r9
       mov       [rsp+68],rax
       vmovaps   xmm2,[rsp+60]
       vextractf128 xmm0,ymm0,1
       vmovaps   [rsp+50],xmm0
       vextractf128 xmm0,ymm1,1
       vmovaps   [rsp+40],xmm0
       mov       rax,[rsp+50]
       mov       [rsp+30],rax
       mov       rax,[rsp+40]
       mov       [rsp+28],rax
       mov       rax,[rsp+30]
       cqo
       idiv      qword ptr [rsp+28]
       mov       [rsp+38],rax
       mov       r9,[rsp+38]
       mov       rax,[rsp+58]
       mov       [rsp+18],rax
       mov       rax,[rsp+48]
       mov       [rsp+10],rax
       mov       rax,[rsp+18]
       cqo
       idiv      qword ptr [rsp+10]
       mov       [rsp+20],rax
       mov       rax,[rsp+20]
       mov       [rsp],r9
       mov       [rsp+8],rax
       mov       rax,14472800368
       mov       rax,[rax]
       shl       r8,5
       vinserti128 ymm0,ymm2,xmmword ptr [rsp],1
       vmovups   [rax+r8+10],ymm0
       mov       r8d,r10d
       cmp       r8d,1869F
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,0C8
       ret
; Total bytes of code 415
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int64, System.Private.CoreLib]].Sum()
       mov       rax,29CF0800360
       mov       rax,[rax]
       mov       rcx,29CF0800370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vmovaps   ymm1,ymm0
       vextracti128 xmm0,ymm0,1
       vpaddq    xmm0,xmm0,xmm1
       vpsrldq   xmm1,xmm0,8
       vpaddq    xmm0,xmm1,xmm0
       vmovq     r10,xmm0
       mov       [rcx+rdx+10],r10
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 86
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int64, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,24984C00360
       mov       rcx,[rcx]
       mov       rdx,24984C00370
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
       vpmullq   ymm0,ymm0,[r10]
       vmovaps   ymm1,ymm0
       vextracti128 xmm0,ymm0,1
       vpaddq    xmm0,xmm0,xmm1
       vpsrldq   xmm1,xmm0,8
       vpaddq    xmm0,xmm1,xmm0
       vmovq     r10,xmm0
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 109
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int64, System.Private.CoreLib]].LengthSquared()
       mov       rax,22996C00360
       mov       rax,[rax]
       mov       rcx,22996C00370
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vpmullq   ymm0,ymm0,ymm0
       vmovaps   ymm1,ymm0
       vextracti128 xmm0,ymm0,1
       vpaddq    xmm0,xmm0,xmm1
       vpsrldq   xmm1,xmm0,8
       vpaddq    xmm0,xmm1,xmm0
       vmovq     r10,xmm0
       mov       [rcx+rdx+10],r10
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 92
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int64, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,2013E800360
       mov       rcx,[rcx]
       mov       rdx,2013E800370
       mov       rdx,[rdx]
       nop       dword ptr [rax]
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
       vpsubq    ymm0,ymm1,ymm0
       vpmullq   ymm0,ymm0,ymm0
       vmovaps   ymm1,ymm0
       vextracti128 xmm0,ymm0,1
       vpaddq    xmm0,xmm0,xmm1
       vpsrldq   xmm1,xmm0,8
       vpaddq    xmm0,xmm1,xmm0
       vmovq     r10,xmm0
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 122
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec4I`1[[System.Int64, System.Private.CoreLib]].Transform()
       mov       rax,18E98800360
       mov       rax,[rax]
       mov       rcx,18E98800368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   ymm0,[r10]
       vmovaps   ymm1,ymm0
       vmovq     r10,xmm1
       vpbroadcastq ymm2,r10
       vpermilpd xmm1,xmm1,1
       vperm2f128 ymm0,ymm0,ymm0,1
       vmovq     r10,xmm1
       vpbroadcastq ymm1,r10
       vpmullq   ymm1,ymm1,[7FF7FD4CB420]
       vpmullq   ymm2,ymm2,[7FF7FD4CB440]
       vpaddq    ymm1,ymm2,ymm1
       vmovq     r10,xmm0
       vpbroadcastq ymm2,r10
       vpmullq   ymm2,ymm2,[7FF7FD4CB460]
       vpaddq    ymm1,ymm1,ymm2
       vpermilpd xmm0,xmm0,1
       vmovq     r10,xmm0
       vpbroadcastq ymm0,r10
       vpmullq   ymm0,ymm0,[7FF7FD4CB480]
       vpaddq    ymm0,ymm1,ymm0
       vmovups   [rcx+rdx],ymm0
       add       rdx,20
       dec       r8d
       jne       near ptr M00_L00
       vzeroupper
       ret
; Total bytes of code 186
```

