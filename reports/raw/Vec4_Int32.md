## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```
| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             |  29.35 μs | 0.045 μs | 0.042 μs |      78 B |
| Subtract        |  29.39 μs | 0.069 μs | 0.064 μs |      78 B |
| Multiply        |  29.51 μs | 0.038 μs | 0.035 μs |      78 B |
| Divide          |  90.25 μs | 0.100 μs | 0.088 μs |     152 B |
| Sum             |  35.15 μs | 0.041 μs | 0.036 μs |      78 B |
| Dot             |  93.51 μs | 0.130 μs | 0.121 μs |      94 B |
| LengthSquared   |  78.28 μs | 0.334 μs | 0.312 μs |      71 B |
| DistanceSquared |  96.49 μs | 0.257 μs | 0.240 μs |      98 B |
| Transform       | 122.42 μs | 0.127 μs | 0.113 μs |     171 B |

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Add()
       mov       rax,26EF7C01568
       mov       rax,[rax]
       mov       rcx,26EF7C01570
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
       jl        short M00_L00
       ret
; Total bytes of code 78
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Subtract()
       mov       rax,23306801568
       mov       rax,[rax]
       mov       rcx,23306801570
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
       jl        short M00_L00
       ret
; Total bytes of code 78
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Multiply()
       mov       rax,1FBAEC01568
       mov       rax,[rax]
       mov       rcx,1FBAEC01570
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
       jl        short M00_L00
       ret
; Total bytes of code 78
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Divide()
       sub       rsp,28
       mov       rax,1CF68C01568
       mov       rax,[rax]
       mov       rcx,1CF68C01570
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
       jne       short M00_L01
       vpcmpeqd  xmm2,xmm0,[7FF9C9983E70]
       vpcmpeqd  xmm3,xmm1,[7FF9C9983E60]
       vpand     xmm2,xmm2,xmm3
       vptest    xmm2,xmm2
       jne       short M00_L02
       vcvtdq2pd ymm2,xmm0
       vcvtdq2pd ymm3,xmm1
       vdivpd    ymm0,ymm2,ymm3
       vcvttpd2dq xmm0,ymm0
       vmovups   [rcx+r8+10],xmm0
       cmp       edx,1869F
       jl        short M00_L00
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowDivideByZeroException()
       int       3
M00_L02:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowOverflowException()
       int       3
; Total bytes of code 152
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Sum()
       mov       rax,158C8C01568
       mov       rax,[rax]
       mov       rcx,158C8C01578
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
       jne       short M00_L00
       ret
; Total bytes of code 78
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,17F19801568
       mov       rcx,[rcx]
       mov       rdx,17F19801578
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
       jl        short M00_L00
       ret
; Total bytes of code 94
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].LengthSquared()
       mov       rax,1922D401568
       mov       rax,[rax]
       mov       rcx,1922D401578
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
       jne       short M00_L00
       ret
; Total bytes of code 71
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,2996B401568
       mov       rcx,[rcx]
       mov       rdx,2996B401578
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
       jl        short M00_L00
       ret
; Total bytes of code 98
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Int32, System.Private.CoreLib]].Transform()
       mov       rax,21549C01568
       mov       rax,[rax]
       mov       rcx,21549C01570
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
       vpmulld   xmm3,xmm3,[7FF9C99B3710]
       vpmulld   xmm1,xmm1,[7FF9C99B3720]
       vpaddd    xmm1,xmm1,xmm3
       vunpckhps xmm0,xmm0,xmm0
       vmovd     r10d,xmm0
       vpbroadcastd xmm0,r10d
       vpmulld   xmm0,xmm0,[7FF9C99B3730]
       vpaddd    xmm0,xmm1,xmm0
       vpermilpd xmm1,xmm2,1
       vmovd     r10d,xmm1
       vpbroadcastd xmm1,r10d
       vpmulld   xmm1,xmm1,[7FF9C99B3740]
       vpaddd    xmm0,xmm0,xmm1
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       near ptr M00_L00
       ret
; Total bytes of code 171
```
