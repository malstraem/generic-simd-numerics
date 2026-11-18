## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```
| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             |  54.97 μs | 0.085 μs | 0.079 μs |      81 B |
| Subtract        |  54.92 μs | 0.076 μs | 0.071 μs |      81 B |
| Multiply        |  80.37 μs | 0.115 μs | 0.102 μs |      85 B |
| Divide          | 989.35 μs | 2.328 μs | 2.178 μs |     415 B |
| Sum             |  36.42 μs | 0.037 μs | 0.034 μs |      82 B |
| Dot             |  57.63 μs | 0.052 μs | 0.047 μs |     105 B |
| LengthSquared   |  49.09 μs | 0.698 μs | 0.545 μs |      88 B |
| DistanceSquared |  65.79 μs | 0.269 μs | 0.239 μs |     114 B |
| Transform       | 127.45 μs | 0.299 μs | 0.280 μs |     186 B |

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int64, System.Private.CoreLib]].Add()
       mov       rax,1D7CCC01568
       mov       rax,[rax]
       mov       rcx,1D7CCC01570
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

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int64, System.Private.CoreLib]].Subtract()
       mov       rax,20E45801568
       mov       rax,[rax]
       mov       rcx,20E45801570
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

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int64, System.Private.CoreLib]].Multiply()
       mov       rax,28FA7401568
       mov       rax,[rax]
       mov       rcx,28FA7401570
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

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int64, System.Private.CoreLib]].Divide()
       sub       rsp,0C8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rsp],zmm4
       vmovdqu32 [rsp+40],zmm4
       vmovdqu32 [rsp+80],ymm4
       mov       rax,26D13401568
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
       vmovaps   xmm2,xmm0
       vmovaps   [rsp+0B0],xmm2
       vmovaps   xmm2,xmm1
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
       mov       rax,26D13401570
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

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int64, System.Private.CoreLib]].Sum()
       mov       rax,25722801568
       mov       rax,[rax]
       mov       rcx,25722801578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vextracti128 xmm1,ymm0,1
       vpaddq    xmm0,xmm1,xmm0
       vpsrldq   xmm1,xmm0,8
       vpaddq    xmm0,xmm1,xmm0
       vmovq     r10,xmm0
       mov       [rcx+rdx+10],r10
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 82
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int64, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,1D5AC801568
       mov       rcx,[rcx]
       mov       rdx,1D5AC801578
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
       vextracti128 xmm1,ymm0,1
       vpaddq    xmm0,xmm1,xmm0
       vpsrldq   xmm1,xmm0,8
       vpaddq    xmm0,xmm1,xmm0
       vmovq     r10,xmm0
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 105
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int64, System.Private.CoreLib]].LengthSquared()
       mov       rax,1851B401568
       mov       rax,[rax]
       mov       rcx,1851B401578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vpmullq   ymm0,ymm0,ymm0
       vextracti128 xmm1,ymm0,1
       vpaddq    xmm0,xmm1,xmm0
       vpsrldq   xmm1,xmm0,8
       vpaddq    xmm0,xmm1,xmm0
       vmovq     r10,xmm0
       mov       [rcx+rdx+10],r10
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 88
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int64, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,271FD801568
       mov       rcx,[rcx]
       mov       rdx,271FD801578
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
       vpsubq    ymm0,ymm1,ymm0
       vpmullq   ymm0,ymm0,ymm0
       vextracti128 xmm1,ymm0,1
       vpaddq    xmm0,xmm1,xmm0
       vpsrldq   xmm1,xmm0,8
       vpaddq    xmm0,xmm1,xmm0
       vmovq     r10,xmm0
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 114
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int64, System.Private.CoreLib]].Transform()
       mov       rax,1361F401568
       mov       rax,[rax]
       mov       rcx,1361F401570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovups   ymm0,[r10]
       vmovaps   xmm1,xmm0
       vmovq     r10,xmm1
       vpbroadcastq ymm2,r10
       vpermilpd xmm1,xmm1,1
       vperm2f128 ymm0,ymm0,ymm0,1
       vmovq     r10,xmm1
       vpbroadcastq ymm1,r10
       vpmullq   ymm1,ymm1,[7FF9C99B4560]
       vpmullq   ymm2,ymm2,[7FF9C99B4580]
       vpaddq    ymm1,ymm2,ymm1
       vmovq     r10,xmm0
       vpbroadcastq ymm2,r10
       vpmullq   ymm2,ymm2,[7FF9C99B45A0]
       vpaddq    ymm1,ymm1,ymm2
       vpermilpd xmm0,xmm0,1
       vmovq     r10,xmm0
       vpbroadcastq ymm0,r10
       vpmullq   ymm0,ymm0,[7FF9C99B45C0]
       vpaddq    ymm0,ymm1,ymm0
       vmovups   [rcx+rdx],ymm0
       add       rdx,20
       dec       r8d
       jne       near ptr M00_L00
       vzeroupper
       ret
; Total bytes of code 186
```
