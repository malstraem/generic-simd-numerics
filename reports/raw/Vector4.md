## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.10075)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             |  30.39 μs | 0.540 μs | 0.505 μs |      78 B |
| Subtract        |  29.65 μs | 0.043 μs | 0.041 μs |      78 B |
| Multiply        |  29.69 μs | 0.035 μs | 0.031 μs |      78 B |
| Divide          |  56.71 μs | 0.076 μs | 0.071 μs |      78 B |
| Abs             |  26.01 μs | 0.020 μs | 0.015 μs |      68 B |
| Sum             |  32.23 μs | 0.074 μs | 0.070 μs |      76 B |
| Dot             |  45.82 μs | 0.085 μs | 0.079 μs |      96 B |
| LengthSquared   |  34.35 μs | 0.050 μs | 0.044 μs |      80 B |
| DistanceSquared |  56.87 μs | 0.057 μs | 0.051 μs |     100 B |
| Length          |  91.50 μs | 0.120 μs | 0.113 μs |      84 B |
| Distance        |  94.85 μs | 0.297 μs | 0.277 μs |     104 B |
| Normalize       | 151.66 μs | 0.294 μs | 0.275 μs |      89 B |
| Transform       |  65.64 μs | 0.133 μs | 0.124 μs |     129 B |
| Sin             |  546.6 μs | 0.93 μs  | 0.72 μs  |     728 B |
| Cos             |  546.8 μs | 1.50 μs  | 1.33 μs  |     728 B |

```assembly
; System.Numerics.Bench.StressVector4.Add()
       mov       rax,23B6F0015A0
       mov       rax,[rax]
       mov       rcx,23B6F0015A8
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

```assembly
; System.Numerics.Bench.StressVector4.Subtract()
       mov       rax,1EB15001568
       mov       rax,[rax]
       mov       rcx,1EB15001570
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

```assembly
; System.Numerics.Bench.StressVector4.Multiply()
       mov       rax,16930001568
       mov       rax,[rax]
       mov       rcx,16930001570
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

```assembly
; System.Numerics.Bench.StressVector4.Divide()
       mov       rax,25504401568
       mov       rax,[rax]
       mov       rcx,25504401570
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

```assembly
; System.Numerics.Bench.StressVector4.Abs()
       mov       rax,21B90C01568
       mov       rax,[rax]
       vbroadcastss xmm0,dword ptr [7FF9C99A2F24]
       mov       rcx,21B90C01570
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

```assembly
; System.Numerics.Bench.StressVector4.Sum()
       mov       rax,2270DC01568
       mov       rax,[rax]
       mov       rcx,2270DC01578
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

```assembly
; System.Numerics.Bench.StressVector4.Dot()
       xor       eax,eax
       mov       rcx,27CB6001568
       mov       rcx,[rcx]
       mov       rdx,27CB6001578
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
       jl        short M00_L00
       ret
; Total bytes of code 96
```

```assembly
; System.Numerics.Bench.StressVector4.LengthSquared()
       mov       rax,24F48801568
       mov       rax,[rax]
       mov       rcx,24F48801578
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
       jne       short M00_L00
       ret
; Total bytes of code 80
```

```assembly
; System.Numerics.Bench.StressVector4.DistanceSquared()
       xor       eax,eax
       mov       rcx,21420001568
       mov       rcx,[rcx]
       mov       rdx,21420001578
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
       jl        short M00_L00
       ret
; Total bytes of code 100
```

```assembly
; System.Numerics.Bench.StressVector4.Length()
       mov       rax,1E0D7801568
       mov       rax,[rax]
       mov       rcx,1E0D7801578
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
       jne       short M00_L00
       ret
; Total bytes of code 84
```

```assembly
; System.Numerics.Bench.StressVector4.Distance()
       xor       eax,eax
       mov       rcx,17B9B401568
       mov       rcx,[rcx]
       mov       rdx,17B9B401578
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
       jl        short M00_L00
       ret
; Total bytes of code 104
```

```assembly
; System.Numerics.Bench.StressVector4.Normalize()
       mov       rax,18BAC001568
       mov       rax,[rax]
       mov       rcx,18BAC001570
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
       jne       short M00_L00
       ret
; Total bytes of code 89
```

```assembly
; System.Numerics.Bench.StressVector4.Transform()
       mov       rax,2B23D801568
       mov       rax,[rax]
       mov       rcx,2B23D801570
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
       vmulps    xmm3,xmm3,[7FF9C9983390]
       vfmadd132ps xmm2,xmm3,[7FF9C99833A0]
       vfmadd132ps xmm1,xmm2,[7FF9C99833B0]
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd132ps xmm0,xmm1,[7FF9C99833C0]
       vmovups   [rcx+rdx],xmm0
       add       rdx,10
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 129
```

```assembly
; System.Numerics.Bench.StressVector4.Sin()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdx,22CD4000BC0
       mov       rbx,[rdx]
       mov       rdx,22CD4000BC8
       mov       rsi,[rdx]
       mov       edi,10
       mov       ebp,186A0
M00_L00:
       vmovups   xmm0,[rbx+rdi]
       vmovaps   [rsp+20],xmm0
       lea       rdx,[rsp+20]
       lea       rcx,[rsp+30]
       call      qword ptr [7FF8E9E7D878]; System.Runtime.Intrinsics.VectorMath.CosSingle[[System.Runtime.Intrinsics.Vector128`1[[System.Single, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Single>)
       vmovaps   xmm0,[rsp+30]
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       dec       ebp
       jne       short M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99

; System.Runtime.Intrinsics.VectorMath.CosSingle[[System.Runtime.Intrinsics.Vector128`1[[System.Single, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Single>)
       push      rbx
       sub       rsp,40
       vmovaps   [rsp+30],xmm6
       vmovaps   [rsp+20],xmm7
       mov       rbx,rcx
       vmovups   xmm0,[rdx]
       vandps    xmm6,xmm0,dword bcst [7FF8E9F46C58]
       vbroadcastss xmm0,dword ptr [7FF8E9F46C5C]
       vpcmpgtd  xmm0,xmm0,xmm6
       vpcmpeqd  xmm1,xmm1,xmm1
       vptest    xmm0,xmm1
       jb        near ptr M01_L02
       vbroadcastss xmm0,dword ptr [7FF8E9F46C60]
       vpcmpgtd  xmm0,xmm0,xmm6
       vpcmpeqd  xmm1,xmm1,xmm1
       vptest    xmm0,xmm1
       jae       near ptr M01_L04
       vcvtps2pd ymm0,xmm6
       vbroadcastsd ymm1,qword ptr [7FF8E9F46C68]
       vmovaps   ymm2,ymm1
       vfmadd231pd ymm2,ymm0,qword bcst [7FF8E9F46C70]
       vsubpd    ymm1,ymm2,ymm1
       vfmadd231pd ymm0,ymm1,qword bcst [7FF8E9F46C78]
       vmulpd    ymm3,ymm1,qword bcst [7FF8E9F46C80]
       vsubpd    ymm4,ymm0,ymm3
       vsubpd    ymm0,ymm0,ymm4
       vsubpd    ymm3,ymm0,ymm3
       vbroadcastsd ymm0,qword ptr [7FF8E9F46C88]
       vxorpd    ymm3,ymm3,ymm0
       vfmadd231pd ymm3,ymm1,qword bcst [7FF8E9F46C90]
       vsubpd    ymm4,ymm4,ymm3
       vmulpd    ymm1,ymm4,ymm4
       vmovaps   ymm3,ymm1
       vbroadcastsd ymm5,qword ptr [7FF8E9F46C98]
       vfmadd213pd ymm5,ymm3,qword bcst [7FF8E9F46CA0]
       vmulpd    ymm16,ymm3,ymm3
       vbroadcastsd ymm17,qword ptr [7FF8E9F46CA8]
       vfmadd213pd ymm17,ymm3,qword bcst [7FF8E9F46CB0]
       vfmadd231pd ymm17,ymm16,ymm5
       vmulpd    ymm3,ymm4,ymm3
       vfmadd231pd ymm4,ymm3,ymm17
       vmovaps   ymm3,ymm16
       vbroadcastsd ymm5,qword ptr [7FF8E9F46CB8]
       vfmadd213pd ymm5,ymm1,qword bcst [7FF8E9F46CC0]
       vbroadcastsd ymm17,qword ptr [7FF8E9F46CC8]
       vfmadd213pd ymm17,ymm1,qword bcst [7FF8E9F46CD0]
       vfmadd213pd ymm5,ymm16,ymm17
       vbroadcastsd ymm16,qword ptr [7FF8E9F46CD8]
       vfmadd213pd ymm1,ymm16,qword bcst [7FF8E9F46CE0]
       vfmadd213pd ymm3,ymm5,ymm1
       vbroadcastsd ymm1,qword ptr [7FF8E9F46CE8]
       vpand     ymm5,ymm1,ymm2
       vxorps    ymm16,ymm16,ymm16
       vpcmpeqq  k1,ymm16,ymm5
       vpblendmq ymm3{k1},ymm4,ymm3
       vpaddq    ymm1,ymm1,ymm2
       vpandq    ymm1,ymm1,qword bcst [7FF8E9F46CF0]
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqq  k1,ymm2,ymm1
       vxorpd    ymm0,ymm0,ymm3
       vpblendmq ymm0{k1},ymm0,ymm3
       vcvtpd2ps xmm7,ymm0
M01_L00:
       vpcmpgtd  k1,xmm6,[7FF8E9F46D00]
       vbroadcastss xmm0,dword ptr [7FF8E9F46D10]
       vpblendmd xmm0{k1},xmm0,xmm7
       vmovups   [rbx],xmm0
M01_L01:
       mov       rax,rbx
       vzeroupper
       vmovaps   xmm6,[rsp+30]
       vmovaps   xmm7,[rsp+20]
       add       rsp,40
       pop       rbx
       ret
M01_L02:
       vpcmpgtd  xmm0,xmm6,[7FF8E9F46D20]
       vptest    xmm0,xmm0
       je        short M01_L03
       vcvtps2pd ymm0,xmmword ptr [rdx]
       vmulpd    ymm0,ymm0,ymm0
       vmovaps   ymm1,ymm0
       vmulpd    ymm2,ymm1,ymm1
       vmovaps   ymm3,ymm2
       vmulpd    ymm1,ymm1,qword bcst [7FF8E9F46D30]
       vbroadcastsd ymm4,qword ptr [7FF8E9F46D38]
       vsubpd    ymm4,ymm4,ymm1
       vbroadcastsd ymm5,qword ptr [7FF8E9F46D38]
       vsubpd    ymm5,ymm5,ymm4
       vsubpd    ymm1,ymm5,ymm1
       vaddpd    ymm1,ymm1,ymm4
       vbroadcastsd ymm4,qword ptr [7FF8E9F46D40]
       vfmadd213pd ymm4,ymm0,qword bcst [7FF8E9F46D48]
       vbroadcastsd ymm5,qword ptr [7FF8E9F46D50]
       vfmadd213pd ymm0,ymm5,qword bcst [7FF8E9F46D58]
       vfmadd213pd ymm2,ymm4,ymm0
       vfmadd213pd ymm2,ymm3,ymm1
       vcvtpd2ps xmm7,ymm2
       jmp       near ptr M01_L00
M01_L03:
       vbroadcastss xmm7,dword ptr [7FF8E9F46D60]
       vmovups   xmm0,[rdx]
       vmulps    xmm0,xmm0,[rdx]
       vfmadd213ps xmm7,xmm0,dword bcst [7FF8E9F46D10]
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF8E9F16D78]; Precode of System.Runtime.Intrinsics.VectorMath.<CosSingle>g__ScalarFallback|1_1[[System.Runtime.Intrinsics.Vector128`1[[System.Single, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Single>)
       jmp       near ptr M01_L01
; Total bytes of code 629
```

```assembly
; System.Numerics.Bench.StressVector4.Cos()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdx,29416800BC0
       mov       rbx,[rdx]
       mov       rdx,29416800BC8
       mov       rsi,[rdx]
       mov       edi,10
       mov       ebp,186A0
M00_L00:
       vmovups   xmm0,[rbx+rdi]
       vmovaps   [rsp+20],xmm0
       lea       rdx,[rsp+20]
       lea       rcx,[rsp+30]
       call      qword ptr [7FF8E9E5D698]; System.Runtime.Intrinsics.VectorMath.CosSingle[[System.Runtime.Intrinsics.Vector128`1[[System.Single, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Single>)
       vmovaps   xmm0,[rsp+30]
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       dec       ebp
       jne       short M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99

; System.Runtime.Intrinsics.VectorMath.CosSingle[[System.Runtime.Intrinsics.Vector128`1[[System.Single, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Single>)
       push      rbx
       sub       rsp,40
       vmovaps   [rsp+30],xmm6
       vmovaps   [rsp+20],xmm7
       mov       rbx,rcx
       vmovups   xmm0,[rdx]
       vandps    xmm6,xmm0,dword bcst [7FF8E9F26728]
       vbroadcastss xmm0,dword ptr [7FF8E9F2672C]
       vpcmpgtd  xmm0,xmm0,xmm6
       vpcmpeqd  xmm1,xmm1,xmm1
       vptest    xmm0,xmm1
       jb        near ptr M01_L02
       vbroadcastss xmm0,dword ptr [7FF8E9F26730]
       vpcmpgtd  xmm0,xmm0,xmm6
       vpcmpeqd  xmm1,xmm1,xmm1
       vptest    xmm0,xmm1
       jae       near ptr M01_L04
       vcvtps2pd ymm0,xmm6
       vbroadcastsd ymm1,qword ptr [7FF8E9F26738]
       vmovaps   ymm2,ymm1
       vfmadd231pd ymm2,ymm0,qword bcst [7FF8E9F26740]
       vsubpd    ymm1,ymm2,ymm1
       vfmadd231pd ymm0,ymm1,qword bcst [7FF8E9F26748]
       vmulpd    ymm3,ymm1,qword bcst [7FF8E9F26750]
       vsubpd    ymm4,ymm0,ymm3
       vsubpd    ymm0,ymm0,ymm4
       vsubpd    ymm3,ymm0,ymm3
       vbroadcastsd ymm0,qword ptr [7FF8E9F26758]
       vxorpd    ymm3,ymm3,ymm0
       vfmadd231pd ymm3,ymm1,qword bcst [7FF8E9F26760]
       vsubpd    ymm4,ymm4,ymm3
       vmulpd    ymm1,ymm4,ymm4
       vmovaps   ymm3,ymm1
       vbroadcastsd ymm5,qword ptr [7FF8E9F26768]
       vfmadd213pd ymm5,ymm3,qword bcst [7FF8E9F26770]
       vmulpd    ymm16,ymm3,ymm3
       vbroadcastsd ymm17,qword ptr [7FF8E9F26778]
       vfmadd213pd ymm17,ymm3,qword bcst [7FF8E9F26780]
       vfmadd231pd ymm17,ymm16,ymm5
       vmulpd    ymm3,ymm4,ymm3
       vfmadd231pd ymm4,ymm3,ymm17
       vmovaps   ymm3,ymm16
       vbroadcastsd ymm5,qword ptr [7FF8E9F26788]
       vfmadd213pd ymm5,ymm1,qword bcst [7FF8E9F26790]
       vbroadcastsd ymm17,qword ptr [7FF8E9F26798]
       vfmadd213pd ymm17,ymm1,qword bcst [7FF8E9F267A0]
       vfmadd213pd ymm5,ymm16,ymm17
       vbroadcastsd ymm16,qword ptr [7FF8E9F267A8]
       vfmadd213pd ymm1,ymm16,qword bcst [7FF8E9F267B0]
       vfmadd213pd ymm3,ymm5,ymm1
       vbroadcastsd ymm1,qword ptr [7FF8E9F267B8]
       vpand     ymm5,ymm1,ymm2
       vxorps    ymm16,ymm16,ymm16
       vpcmpeqq  k1,ymm16,ymm5
       vpblendmq ymm3{k1},ymm4,ymm3
       vpaddq    ymm1,ymm1,ymm2
       vpandq    ymm1,ymm1,qword bcst [7FF8E9F267C0]
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqq  k1,ymm2,ymm1
       vxorpd    ymm0,ymm0,ymm3
       vpblendmq ymm0{k1},ymm0,ymm3
       vcvtpd2ps xmm7,ymm0
M01_L00:
       vpcmpgtd  k1,xmm6,[7FF8E9F267D0]
       vbroadcastss xmm0,dword ptr [7FF8E9F267E0]
       vpblendmd xmm0{k1},xmm0,xmm7
       vmovups   [rbx],xmm0
M01_L01:
       mov       rax,rbx
       vzeroupper
       vmovaps   xmm6,[rsp+30]
       vmovaps   xmm7,[rsp+20]
       add       rsp,40
       pop       rbx
       ret
M01_L02:
       vpcmpgtd  xmm0,xmm6,[7FF8E9F267F0]
       vptest    xmm0,xmm0
       je        short M01_L03
       vcvtps2pd ymm0,xmmword ptr [rdx]
       vmulpd    ymm0,ymm0,ymm0
       vmovaps   ymm1,ymm0
       vmulpd    ymm2,ymm1,ymm1
       vmovaps   ymm3,ymm2
       vmulpd    ymm1,ymm1,qword bcst [7FF8E9F26800]
       vbroadcastsd ymm4,qword ptr [7FF8E9F26808]
       vsubpd    ymm4,ymm4,ymm1
       vbroadcastsd ymm5,qword ptr [7FF8E9F26808]
       vsubpd    ymm5,ymm5,ymm4
       vsubpd    ymm1,ymm5,ymm1
       vaddpd    ymm1,ymm1,ymm4
       vbroadcastsd ymm4,qword ptr [7FF8E9F26810]
       vfmadd213pd ymm4,ymm0,qword bcst [7FF8E9F26818]
       vbroadcastsd ymm5,qword ptr [7FF8E9F26820]
       vfmadd213pd ymm0,ymm5,qword bcst [7FF8E9F26828]
       vfmadd213pd ymm2,ymm4,ymm0
       vfmadd213pd ymm2,ymm3,ymm1
       vcvtpd2ps xmm7,ymm2
       jmp       near ptr M01_L00
M01_L03:
       vbroadcastss xmm7,dword ptr [7FF8E9F26830]
       vmovups   xmm0,[rdx]
       vmulps    xmm0,xmm0,[rdx]
       vfmadd213ps xmm7,xmm0,dword bcst [7FF8E9F267E0]
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF8E9EF6FA0]; Precode of System.Runtime.Intrinsics.VectorMath.<CosSingle>g__ScalarFallback|1_1[[System.Runtime.Intrinsics.Vector128`1[[System.Single, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Single>)
       jmp       near ptr M01_L01
; Total bytes of code 629
```
