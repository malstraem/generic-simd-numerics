## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.10075)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Add             |  55.32 μs | 0.130 μs | 0.115 μs |      81 B |
| Subtract        |  55.16 μs | 0.204 μs | 0.191 μs |      81 B |
| Multiply        |  55.34 μs | 0.108 μs | 0.096 μs |      81 B |
| Divide          |  88.84 μs | 0.329 μs | 0.308 μs |      81 B |
| Abs             |  50.33 μs | 0.411 μs | 0.343 μs |      71 B |
| Sum             |  33.62 μs | 0.116 μs | 0.109 μs |      79 B |
| Dot             |  57.92 μs | 0.116 μs | 0.109 μs |     106 B |
| LengthSquared   |  36.10 μs | 0.100 μs | 0.084 μs |      83 B |
| DistanceSquared |  58.49 μs | 0.424 μs | 0.354 μs |     110 B |
| Transform       |  88.23 μs | 0.238 μs | 0.211 μs |     145 B |
| Length          | 166.39 μs | 2.185 μs | 1.825 μs |      87 B |
| Distance        | 163.64 μs | 0.544 μs | 0.454 μs |     107 B |
| Normalize       | 249.87 μs | 0.694 μs | 0.580 μs |      97 B |
| Sin             | 717.35 μs | 2.163 μs | 2.023 μs |     858 B |
| Cos             | 693.64 μs | 1.922 μs | 1.605 μs |     872 B |

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Add()
       mov       rax,202C9801568
       mov       rax,[rax]
       mov       rcx,202C9801570
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
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Subtract()
       mov       rax,1F593001568
       mov       rax,[rax]
       mov       rcx,1F593001570
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
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Multiply()
       mov       rax,25D9E801568
       mov       rax,[rax]
       mov       rcx,25D9E801570
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
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Divide()
       mov       rax,1ED13801568
       mov       rax,[rax]
       mov       rcx,1ED13801570
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
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 81
```

```assembly
; System.Numerics.Bench.StressSignedVec4`1[[System.Double, System.Private.CoreLib]].Abs()
       mov       rax,20C4C000BD0
       mov       rax,[rax]
       vbroadcastsd ymm0,qword ptr [7FF8CE7D9328]
       mov       rcx,20C4C000BD8
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
       xchg      ax,ax
M00_L00:
       vandpd    ymm1,ymm0,[rax+rdx]
       vmovups   [rcx+rdx],ymm1
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 71
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Sum()
       mov       rax,2518DC01568
       mov       rax,[rax]
       mov       rcx,2518DC01578
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
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 79
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,1951C801568
       mov       rcx,[rcx]
       mov       rdx,1951C801578
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
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 106
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].LengthSquared()
       mov       rax,140FF801568
       mov       rax,[rax]
       mov       rcx,140FF801578
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
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 83
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,297C2C01568
       mov       rcx,[rcx]
       mov       rdx,297C2C01578
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
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 110
```

```assembly
; System.Numerics.Bench.BaseStressVec4`1[[System.Double, System.Private.CoreLib]].Transform()
       mov       rax,14D98001568
       mov       rax,[rax]
       mov       rcx,14D98001570
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
       vmulpd    ymm2,ymm2,[7FF9C99B3AE0]
       vfmadd132pd ymm1,ymm2,[7FF9C99B3B00]
       vfmadd132pd ymm0,ymm1,[7FF9C99B3B20]
       vfmadd231pd ymm0,ymm3,[7FF9C99B3B40]
       vmovups   [rcx+rdx],ymm0
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 145
```

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Length()
       mov       rax,197DA801568
       mov       rax,[rax]
       mov       rcx,197DA801578
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
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 87
```

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,2AC7A401568
       mov       rcx,[rcx]
       mov       rdx,2AC7A401578
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
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 107
```

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Normalize()
       mov       rax,1F2D8801568
       mov       rax,[rax]
       mov       rcx,1F2D8801570
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
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 97
```

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Sin()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       mov       rdx,25C40C00BD0
       mov       rbx,[rdx]
       mov       rdx,25C40C00BD8
       mov       rsi,[rdx]
       mov       edi,10
       mov       ebp,186A0
M00_L00:
       vmovups   ymm0,[rbx+rdi]
       vmovups   [rsp+20],ymm0
       lea       rdx,[rsp+20]
       lea       rcx,[rsp+40]
       call      qword ptr [7FF8CE71DCF8]; System.Runtime.Intrinsics.VectorMath.SinDouble[[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Double>)
       vmovups   ymm0,[rsp+40]
       vmovups   [rsi+rdi],ymm0
       add       rdi,20
       dec       ebp
       jne       short M00_L00
       vzeroupper
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102

; System.Runtime.Intrinsics.VectorMath.SinDouble[[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Double>)
       sub       rsp,38
       vmovaps   [rsp+20],xmm6
       vmovaps   [rsp+10],xmm7
       vmovaps   [rsp],xmm8
       vmovups   ymm6,[rdx]
       vandpd    ymm7,ymm6,qword bcst [7FF8CE7E6C38]
       vbroadcastsd ymm0,qword ptr [7FF8CE7E6C40]
       vpcmpgtq  ymm0,ymm0,ymm7
       vpcmpeqd  ymm1,ymm1,ymm1
       vptest    ymm0,ymm1
       jb        near ptr M01_L01
       vbroadcastsd ymm0,qword ptr [7FF8CE7E6C48]
       vpcmpgtq  ymm0,ymm0,ymm7
       vpcmpeqd  ymm1,ymm1,ymm1
       vptest    ymm0,ymm1
       jae       near ptr M01_L03
       vbroadcastsd ymm0,qword ptr [7FF8CE7E6C50]
       vmovaps   ymm1,ymm0
       vfmadd231pd ymm1,ymm7,qword bcst [7FF8CE7E6C58]
       vsubpd    ymm0,ymm1,ymm0
       vmovaps   ymm2,ymm7
       vfmadd231pd ymm2,ymm0,qword bcst [7FF8CE7E6C60]
       vmulpd    ymm3,ymm0,qword bcst [7FF8CE7E6C68]
       vsubpd    ymm4,ymm2,ymm3
       vsubpd    ymm2,ymm2,ymm4
       vsubpd    ymm3,ymm2,ymm3
       vbroadcastsd ymm2,qword ptr [7FF8CE7E6C70]
       vxorpd    ymm3,ymm3,ymm2
       vfmadd231pd ymm3,ymm0,qword bcst [7FF8CE7E6C78]
       vsubpd    ymm0,ymm4,ymm3
       vsubpd    ymm4,ymm4,ymm0
       vsubpd    ymm3,ymm4,ymm3
       vmulpd    ymm4,ymm0,ymm0
       vmovaps   ymm5,ymm4
       vmulpd    ymm16,ymm0,ymm5
       vmulpd    ymm17,ymm5,ymm5
       vmovaps   ymm18,ymm17
       vbroadcastsd ymm19,qword ptr [7FF8CE7E6C80]
       vmulpd    ymm20,ymm18,ymm18
       vbroadcastsd ymm21,qword ptr [7FF8CE7E6C88]
       vfmadd213pd ymm21,ymm5,qword bcst [7FF8CE7E6C90]
       vbroadcastsd ymm22,qword ptr [7FF8CE7E6C98]
       vfmadd213pd ymm22,ymm5,qword bcst [7FF8CE7E6CA0]
       vfmadd213pd ymm18,ymm21,ymm22
       vfmadd231pd ymm18,ymm20,qword bcst [7FF8CE7E6CA8]
       vmulpd    ymm18,ymm18,ymm16
       vxorpd    ymm18,ymm18,ymm2
       vfmadd231pd ymm18,ymm19,ymm3
       vxorpd    ymm21,ymm2,ymm3
       vfmadd213pd ymm5,ymm18,ymm21
       vfmadd231pd ymm5,ymm16,qword bcst [7FF8CE7E6CB0]
       vsubpd    ymm5,ymm0,ymm5
       vmovaps   ymm16,ymm4
       vmulpd    ymm16,ymm19,ymm16
       vbroadcastsd ymm18,qword ptr [7FF8CE7E6CB8]
       vsubpd    ymm19,ymm16,ymm18
       vbroadcastsd ymm21,qword ptr [7FF8CE7E6CC0]
       vfmadd213pd ymm21,ymm4,qword bcst [7FF8CE7E6CC8]
       vbroadcastsd ymm22,qword ptr [7FF8CE7E6CD0]
       vfmadd213pd ymm22,ymm4,qword bcst [7FF8CE7E6CD8]
       vbroadcastsd ymm23,qword ptr [7FF8CE7E6CE0]
       vfmadd213pd ymm4,ymm23,qword bcst [7FF8CE7E6CE8]
       vfmadd231pd ymm4,ymm17,ymm22
       vfmadd213pd ymm20,ymm21,ymm4
       vbroadcastsd ymm4,qword ptr [7FF8CE7E6CF0]
       vpandd    ymm21,ymm4,ymm1
       vxorps    ymm22,ymm22,ymm22
       vpcmpeqq  k1,ymm22,ymm21
       vaddpd    ymm18,ymm18,ymm19
       vsubpd    ymm16,ymm18,ymm16
       vfmadd213pd ymm3,ymm0,ymm16
       vfmadd213pd ymm17,ymm20,ymm3
       vsubpd    ymm0,ymm17,ymm19
       vpblendmq ymm8{k1},ymm0,ymm5
       vpsrlq    ymm0,ymm6,3F
       vpsrlq    ymm1,ymm1,1
       vpternlogq ymm3,ymm1,ymm0,11
       vpternlogq ymm3,ymm1,ymm0,0F8
       vpand     ymm0,ymm3,ymm4
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqq  k1,ymm1,ymm0
       vxorpd    ymm8{k1},ymm2,ymm8
M01_L00:
       vpcmpgtq  k1,ymm7,[7FF8CE7E6D00]
       vpblendmq ymm0{k1},ymm6,ymm8
       vmovups   [rcx],ymm0
       mov       rax,rcx
       vzeroupper
       vmovaps   xmm6,[rsp+20]
       vmovaps   xmm7,[rsp+10]
       vmovaps   xmm8,[rsp]
       add       rsp,38
       ret
M01_L01:
       vmulpd    ymm8,ymm6,ymm6
       vmovaps   ymm0,ymm8
       vpcmpgtq  ymm1,ymm7,[7FF8CE7E6D20]
       vptest    ymm1,ymm1
       je        short M01_L02
       vmulpd    ymm0,ymm8,ymm6
       vmulpd    ymm1,ymm8,ymm8
       vbroadcastsd ymm2,qword ptr [7FF8CE7E6CA8]
       vfmadd213pd ymm2,ymm8,qword bcst [7FF8CE7E6C88]
       vmulpd    ymm3,ymm1,ymm1
       vbroadcastsd ymm4,qword ptr [7FF8CE7E6C90]
       vfmadd213pd ymm4,ymm8,qword bcst [7FF8CE7E6C98]
       vbroadcastsd ymm5,qword ptr [7FF8CE7E6CA0]
       vfmadd213pd ymm8,ymm5,qword bcst [7FF8CE7E6D40]
       vfmadd213pd ymm1,ymm4,ymm8
       vfmadd213pd ymm2,ymm3,ymm1
       vmovaps   ymm8,ymm2
       vfmadd213pd ymm8,ymm0,ymm6
       jmp       near ptr M01_L00
M01_L02:
       vmulpd    ymm8,ymm6,ymm0
       vfmadd132pd ymm8,ymm6,qword bcst [7FF8CE7E6D40]
       jmp       near ptr M01_L00
M01_L03:
       vzeroupper
       vmovaps   xmm6,[rsp+20]
       vmovaps   xmm7,[rsp+10]
       vmovaps   xmm8,[rsp]
       add       rsp,38
       jmp       qword ptr [7FF8CE7C7498]; Precode of System.Runtime.Intrinsics.VectorMath.<SinDouble>g__ScalarFallback|34_0[[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Double>)
; Total bytes of code 756
```

```assembly
; System.Numerics.Bench.StressVec4`1[[System.Double, System.Private.CoreLib]].Cos()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       mov       rdx,20558800BD0
       mov       rbx,[rdx]
       mov       rdx,20558800BD8
       mov       rsi,[rdx]
       mov       edi,10
       mov       ebp,186A0
M00_L00:
       vmovups   ymm0,[rbx+rdi]
       vmovups   [rsp+20],ymm0
       lea       rdx,[rsp+20]
       lea       rcx,[rsp+40]
       call      qword ptr [7FF8CE71DBF0]; System.Runtime.Intrinsics.VectorMath.CosDouble[[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Double>)
       vmovups   ymm0,[rsp+40]
       vmovups   [rsi+rdi],ymm0
       add       rdi,20
       dec       ebp
       jne       short M00_L00
       vzeroupper
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102

; System.Runtime.Intrinsics.VectorMath.CosDouble[[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Double>)
       sub       rsp,38
       vmovaps   [rsp+20],xmm6
       vmovaps   [rsp+10],xmm7
       vmovaps   [rsp],xmm8
       vmovups   ymm0,[rdx]
       vandpd    ymm6,ymm0,qword bcst [7FF8CE7E69C8]
       vbroadcastsd ymm0,qword ptr [7FF8CE7E69D0]
       vpcmpgtq  ymm0,ymm0,ymm6
       vpcmpeqd  ymm1,ymm1,ymm1
       vptest    ymm0,ymm1
       jb        near ptr M01_L01
       vbroadcastsd ymm0,qword ptr [7FF8CE7E69D8]
       vpcmpgtq  ymm0,ymm0,ymm6
       vpcmpeqd  ymm1,ymm1,ymm1
       vptest    ymm0,ymm1
       jae       near ptr M01_L03
       vbroadcastsd ymm0,qword ptr [7FF8CE7E69E0]
       vmovaps   ymm1,ymm0
       vfmadd231pd ymm1,ymm6,qword bcst [7FF8CE7E69E8]
       vsubpd    ymm0,ymm1,ymm0
       vmovaps   ymm2,ymm6
       vfmadd231pd ymm2,ymm0,qword bcst [7FF8CE7E69F0]
       vmulpd    ymm3,ymm0,qword bcst [7FF8CE7E69F8]
       vsubpd    ymm4,ymm2,ymm3
       vsubpd    ymm2,ymm2,ymm4
       vsubpd    ymm3,ymm2,ymm3
       vbroadcastsd ymm2,qword ptr [7FF8CE7E6A00]
       vxorpd    ymm3,ymm3,ymm2
       vfmadd231pd ymm3,ymm0,qword bcst [7FF8CE7E6A08]
       vsubpd    ymm0,ymm4,ymm3
       vsubpd    ymm4,ymm4,ymm0
       vsubpd    ymm3,ymm4,ymm3
       vmulpd    ymm4,ymm0,ymm0
       vmovaps   ymm5,ymm4
       vmulpd    ymm16,ymm0,ymm5
       vmulpd    ymm17,ymm5,ymm5
       vmovaps   ymm18,ymm17
       vbroadcastsd ymm19,qword ptr [7FF8CE7E6A10]
       vmulpd    ymm20,ymm18,ymm18
       vbroadcastsd ymm21,qword ptr [7FF8CE7E6A18]
       vfmadd213pd ymm21,ymm5,qword bcst [7FF8CE7E6A20]
       vbroadcastsd ymm22,qword ptr [7FF8CE7E6A28]
       vfmadd213pd ymm22,ymm5,qword bcst [7FF8CE7E6A30]
       vfmadd213pd ymm18,ymm21,ymm22
       vfmadd231pd ymm18,ymm20,qword bcst [7FF8CE7E6A38]
       vmulpd    ymm18,ymm18,ymm16
       vxorpd    ymm18,ymm18,ymm2
       vfmadd231pd ymm18,ymm19,ymm3
       vxorpd    ymm21,ymm2,ymm3
       vfmadd213pd ymm5,ymm18,ymm21
       vfmadd231pd ymm5,ymm16,qword bcst [7FF8CE7E6A40]
       vsubpd    ymm5,ymm0,ymm5
       vmovaps   ymm16,ymm4
       vmulpd    ymm16,ymm19,ymm16
       vbroadcastsd ymm7,qword ptr [7FF8CE7E6A48]
       vsubpd    ymm18,ymm16,ymm7
       vbroadcastsd ymm19,qword ptr [7FF8CE7E6A50]
       vfmadd213pd ymm19,ymm4,qword bcst [7FF8CE7E6A58]
       vbroadcastsd ymm21,qword ptr [7FF8CE7E6A60]
       vfmadd213pd ymm21,ymm4,qword bcst [7FF8CE7E6A68]
       vbroadcastsd ymm22,qword ptr [7FF8CE7E6A70]
       vfmadd213pd ymm4,ymm22,qword bcst [7FF8CE7E6A78]
       vfmadd231pd ymm4,ymm17,ymm21
       vfmadd213pd ymm19,ymm20,ymm4
       vaddpd    ymm4,ymm18,ymm7
       vsubpd    ymm4,ymm4,ymm16
       vfmadd213pd ymm3,ymm0,ymm4
       vfmadd213pd ymm17,ymm19,ymm3
       vsubpd    ymm0,ymm17,ymm18
       vbroadcastsd ymm3,qword ptr [7FF8CE7E6A80]
       vpand     ymm4,ymm3,ymm1
       vxorps    ymm16,ymm16,ymm16
       vpcmpeqq  k1,ymm16,ymm4
       vpblendmq ymm8{k1},ymm5,ymm0
       vpaddq    ymm0,ymm3,ymm1
       vpandq    ymm0,ymm0,qword bcst [7FF8CE7E6A88]
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqq  k1,ymm1,ymm0
       vxorpd    ymm0,ymm8,ymm2
       vpblendmq ymm8{k1},ymm0,ymm8
M01_L00:
       vpcmpgtq  k1,ymm6,[7FF8CE7E6AA0]
       vpblendmq ymm0{k1},ymm7,ymm8
       vmovups   [rcx],ymm0
       mov       rax,rcx
       vzeroupper
       vmovaps   xmm6,[rsp+20]
       vmovaps   xmm7,[rsp+10]
       vmovaps   xmm8,[rsp]
       add       rsp,38
       ret
M01_L01:
       vmovups   ymm0,[rdx]
       vmulpd    ymm8,ymm0,[rdx]
       vmovaps   ymm0,ymm8
       vpcmpgtq  ymm1,ymm6,[7FF8CE7E6AC0]
       vptest    ymm1,ymm1
       je        short M01_L02
       vmulpd    ymm1,ymm8,ymm8
       vbroadcastsd ymm2,qword ptr [7FF8CE7E6A50]
       vfmadd213pd ymm2,ymm8,qword bcst [7FF8CE7E6A58]
       vmulpd    ymm3,ymm1,ymm1
       vbroadcastsd ymm4,qword ptr [7FF8CE7E6A60]
       vfmadd213pd ymm4,ymm8,qword bcst [7FF8CE7E6A68]
       vbroadcastsd ymm5,qword ptr [7FF8CE7E6A70]
       vfmadd213pd ymm8,ymm5,qword bcst [7FF8CE7E6A78]
       vfmadd213pd ymm1,ymm4,ymm8
       vfmadd213pd ymm2,ymm3,ymm1
       vfmadd213pd ymm2,ymm0,qword bcst [7FF8CE7E6AE0]
       vbroadcastsd ymm7,qword ptr [7FF8CE7E6A48]
       vmovaps   ymm8,ymm2
       vfmadd213pd ymm8,ymm0,ymm7
       jmp       near ptr M01_L00
M01_L02:
       vbroadcastsd ymm7,qword ptr [7FF8CE7E6A48]
       vmovaps   ymm8,ymm7
       vfmadd231pd ymm8,ymm0,qword bcst [7FF8CE7E6AE0]
       jmp       near ptr M01_L00
M01_L03:
       vzeroupper
       vmovaps   xmm6,[rsp+20]
       vmovaps   xmm7,[rsp+10]
       vmovaps   xmm8,[rsp]
       add       rsp,38
       jmp       qword ptr [7FF8CE7C74E0]; Precode of System.Runtime.Intrinsics.VectorMath.<CosDouble>g__ScalarFallback|0_0[[System.Runtime.Intrinsics.Vector256`1[[System.Double, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector256`1[[System.Int64, System.Private.CoreLib]], System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Double>)
; Total bytes of code 770
```
