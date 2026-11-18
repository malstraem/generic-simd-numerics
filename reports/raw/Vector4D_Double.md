## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-nightly.20261117.686, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method          | Mean      | Error    | StdDev   | Code Size |
|---------------- |----------:|---------:|---------:|----------:|
| Length          | 164.64 μs | 0.084 μs | 0.066 μs |     131 B |
| Distance        | 167.46 μs | 0.375 μs | 0.351 μs |     176 B |
| Normalize       | 519.88 μs | 0.537 μs | 0.502 μs |     149 B |
| Add             | 114.26 μs | 0.090 μs | 0.084 μs |     163 B |
| Subtract        |  99.58 μs | 0.104 μs | 0.097 μs |     163 B |
| Multiply        |  99.65 μs | 0.103 μs | 0.097 μs |     163 B |
| Divide          | 351.08 μs | 0.747 μs | 0.698 μs |     163 B |
| Abs             | 145.19 μs | 0.328 μs | 0.307 μs |     163 B |
| Dot             |  95.16 μs | 0.180 μs | 0.168 μs |     152 B |
| LengthSquared   |  65.28 μs | 0.178 μs | 0.166 μs |     127 B |
| DistanceSquared | 113.56 μs | 0.163 μs | 0.152 μs |     172 B |
| Transform       | 186.48 μs | 0.244 μs | 0.229 μs |     296 B |

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Double, System.Private.CoreLib]].Length()
       mov       rax,1E042001568
       mov       rax,[rax]
       mov       rcx,1E042001578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovaps   xmm1,xmm0
       vmovsd    xmm2,qword ptr [r10+8]
       vmovaps   xmm3,xmm2
       vmovsd    xmm4,qword ptr [r10+10]
       vmovaps   xmm5,xmm4
       vmovsd    xmm16,qword ptr [r10+18]
       vmovaps   xmm17,xmm16
       vmulsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm3,xmm2
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm5,xmm4
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm17,xmm16
       vaddsd    xmm0,xmm1,xmm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 131
```

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Double, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,1F33C401568
       mov       rcx,[rcx]
       mov       rdx,1F33C401578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       inc       eax
       mov       r10d,eax
       shl       r10,5
       lea       r10,[rcx+r10+10]
       vmovsd    xmm4,qword ptr [r10]
       vmovsd    xmm5,qword ptr [r10+8]
       vmovsd    xmm16,qword ptr [r10+10]
       vmovsd    xmm17,qword ptr [r10+18]
       vsubsd    xmm0,xmm0,xmm4
       vsubsd    xmm1,xmm1,xmm5
       vsubsd    xmm2,xmm2,xmm16
       vsubsd    xmm3,xmm3,xmm17
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm1,xmm1,xmm1
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm2,xmm2
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm3,xmm3
       vaddsd    xmm0,xmm1,xmm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 176
```

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Double, System.Private.CoreLib]].Normalize()
       mov       rax,19164001568
       mov       rax,[rax]
       mov       rcx,19164001570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       vmulsd    xmm4,xmm0,xmm0
       vmulsd    xmm5,xmm1,xmm1
       vaddsd    xmm4,xmm5,xmm4
       vmulsd    xmm5,xmm2,xmm2
       vaddsd    xmm4,xmm5,xmm4
       vmulsd    xmm5,xmm3,xmm3
       vaddsd    xmm4,xmm5,xmm4
       vsqrtsd   xmm4,xmm4,xmm4
       vdivsd    xmm0,xmm0,xmm4
       vdivsd    xmm1,xmm1,xmm4
       vdivsd    xmm2,xmm2,xmm4
       vdivsd    xmm3,xmm3,xmm4
       lea       r10,[rcx+rdx]
       vmovsd    qword ptr [r10],xmm0
       vmovsd    qword ptr [r10+8],xmm1
       vmovsd    qword ptr [r10+10],xmm2
       vmovsd    qword ptr [r10+18],xmm3
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 149
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Add()
       mov       rax,25CB1C01568
       mov       rax,[rax]
       mov       rcx,25CB1C01570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,5
       lea       r10,[rax+r8+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       lea       r10,[rax+r10+10]
       vmovsd    xmm4,qword ptr [r10]
       vmovsd    xmm5,qword ptr [r10+8]
       vmovsd    xmm16,qword ptr [r10+10]
       vmovsd    xmm17,qword ptr [r10+18]
       vaddsd    xmm0,xmm0,xmm4
       vaddsd    xmm1,xmm1,xmm5
       vaddsd    xmm2,xmm16,xmm2
       vaddsd    xmm3,xmm17,xmm3
       lea       r8,[rcx+r8+10]
       vmovsd    qword ptr [r8],xmm0
       vmovsd    qword ptr [r8+8],xmm1
       vmovsd    qword ptr [r8+10],xmm2
       vmovsd    qword ptr [r8+18],xmm3
       cmp       edx,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Subtract()
       mov       rax,15E5BC01568
       mov       rax,[rax]
       mov       rcx,15E5BC01570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,5
       lea       r10,[rax+r8+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       lea       r10,[rax+r10+10]
       vmovsd    xmm4,qword ptr [r10]
       vmovsd    xmm5,qword ptr [r10+8]
       vmovsd    xmm16,qword ptr [r10+10]
       vmovsd    xmm17,qword ptr [r10+18]
       vsubsd    xmm0,xmm0,xmm4
       vsubsd    xmm1,xmm1,xmm5
       vsubsd    xmm2,xmm2,xmm16
       vsubsd    xmm3,xmm3,xmm17
       lea       r8,[rcx+r8+10]
       vmovsd    qword ptr [r8],xmm0
       vmovsd    qword ptr [r8+8],xmm1
       vmovsd    qword ptr [r8+10],xmm2
       vmovsd    qword ptr [r8+18],xmm3
       cmp       edx,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Multiply()
       mov       rax,1AC1AC01568
       mov       rax,[rax]
       mov       rcx,1AC1AC01570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,5
       lea       r10,[rax+r8+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       lea       r10,[rax+r10+10]
       vmovsd    xmm4,qword ptr [r10]
       vmovsd    xmm5,qword ptr [r10+8]
       vmovsd    xmm16,qword ptr [r10+10]
       vmovsd    xmm17,qword ptr [r10+18]
       vmulsd    xmm0,xmm0,xmm4
       vmulsd    xmm1,xmm1,xmm5
       vmulsd    xmm2,xmm16,xmm2
       vmulsd    xmm3,xmm17,xmm3
       lea       r8,[rcx+r8+10]
       vmovsd    qword ptr [r8],xmm0
       vmovsd    qword ptr [r8+8],xmm1
       vmovsd    qword ptr [r8+10],xmm2
       vmovsd    qword ptr [r8+18],xmm3
       cmp       edx,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Divide()
       mov       rax,13866401568
       mov       rax,[rax]
       mov       rcx,13866401570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,5
       lea       r10,[rax+r8+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       inc       edx
       mov       r10d,edx
       shl       r10,5
       lea       r10,[rax+r10+10]
       vmovsd    xmm4,qword ptr [r10]
       vmovsd    xmm5,qword ptr [r10+8]
       vmovsd    xmm16,qword ptr [r10+10]
       vmovsd    xmm17,qword ptr [r10+18]
       vdivsd    xmm0,xmm0,xmm4
       vdivsd    xmm1,xmm1,xmm5
       vdivsd    xmm2,xmm2,xmm16
       vdivsd    xmm3,xmm3,xmm17
       lea       r8,[rcx+r8+10]
       vmovsd    qword ptr [r8],xmm0
       vmovsd    qword ptr [r8+8],xmm1
       vmovsd    qword ptr [r8+10],xmm2
       vmovsd    qword ptr [r8+18],xmm3
       cmp       edx,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Abs()
       mov       rax,1FE52C01568
       mov       rax,[rax]
       mov       rcx,1FE52C01570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       vmovq     r10,xmm0
       mov       r9,7FFFFFFFFFFFFFFF
       and       r10,r9
       vmovq     xmm0,r10
       vmovq     r10,xmm1
       and       r10,r9
       vmovq     xmm1,r10
       vmovq     r10,xmm2
       and       r10,r9
       vmovq     xmm2,r10
       vmovq     r10,xmm3
       and       r10,r9
       vmovq     xmm3,r10
       lea       r10,[rcx+rdx]
       vmovsd    qword ptr [r10],xmm0
       vmovsd    qword ptr [r10+8],xmm1
       vmovsd    qword ptr [r10+10],xmm2
       vmovsd    qword ptr [r10+18],xmm3
       add       rdx,20
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 163
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,2620DC01568
       mov       rcx,[rcx]
       mov       rdx,2620DC01578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       inc       eax
       mov       r10d,eax
       shl       r10,5
       lea       r10,[rcx+r10+10]
       vmovsd    xmm4,qword ptr [r10]
       vmovsd    xmm5,qword ptr [r10+8]
       vmovsd    xmm16,qword ptr [r10+10]
       vmovsd    xmm17,qword ptr [r10+18]
       vmulsd    xmm0,xmm0,xmm4
       vmulsd    xmm1,xmm1,xmm5
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm16,xmm2
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm17,xmm3
       vaddsd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 152
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].LengthSquared()
       mov       rax,13F1B001568
       mov       rax,[rax]
       mov       rcx,13F1B001578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovaps   xmm1,xmm0
       vmovsd    xmm2,qword ptr [r10+8]
       vmovaps   xmm3,xmm2
       vmovsd    xmm4,qword ptr [r10+10]
       vmovaps   xmm5,xmm4
       vmovsd    xmm16,qword ptr [r10+18]
       vmovaps   xmm17,xmm16
       vmulsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm3,xmm2
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm5,xmm4
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm17,xmm16
       vaddsd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 127
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,1DE3AC01568
       mov       rcx,[rcx]
       mov       rdx,1DE3AC01578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       inc       eax
       mov       r10d,eax
       shl       r10,5
       lea       r10,[rcx+r10+10]
       vmovsd    xmm4,qword ptr [r10]
       vmovsd    xmm5,qword ptr [r10+8]
       vmovsd    xmm16,qword ptr [r10+10]
       vmovsd    xmm17,qword ptr [r10+18]
       vsubsd    xmm0,xmm0,xmm4
       vsubsd    xmm1,xmm1,xmm5
       vsubsd    xmm2,xmm2,xmm16
       vsubsd    xmm3,xmm3,xmm17
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm1,xmm1,xmm1
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm2,xmm2
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm3,xmm3
       vaddsd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 172
```

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Transform()
       mov       rax,1B5BAC01568
       mov       rax,[rax]
       mov       rcx,1B5BAC01570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       vmulsd    xmm4,xmm1,qword ptr [7FF9C99A29E8]
       vaddsd    xmm4,xmm4,xmm0
       vmulsd    xmm5,xmm2,qword ptr [7FF9C99A29F0]
       vaddsd    xmm4,xmm5,xmm4
       vmulsd    xmm5,xmm3,qword ptr [7FF9C99A29F8]
       vaddsd    xmm4,xmm5,xmm4
       vaddsd    xmm5,xmm0,xmm0
       vmulsd    xmm16,xmm1,qword ptr [7FF9C99A2A00]
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm2,qword ptr [7FF9C99A2A08]
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm3,qword ptr [7FF9C99A2A10]
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm0,qword ptr [7FF9C99A2A18]
       vmulsd    xmm17,xmm1,qword ptr [7FF9C99A2A20]
       vaddsd    xmm16,xmm17,xmm16
       vmulsd    xmm17,xmm2,qword ptr [7FF9C99A2A28]
       vaddsd    xmm16,xmm17,xmm16
       vmulsd    xmm17,xmm3,qword ptr [7FF9C99A2A30]
       vaddsd    xmm16,xmm17,xmm16
       vmulsd    xmm0,xmm0,qword ptr [7FF9C99A2A38]
       vmulsd    xmm1,xmm1,qword ptr [7FF9C99A2A40]
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm2,qword ptr [7FF9C99A2A48]
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm3,qword ptr [7FF9C99A2A50]
       vaddsd    xmm0,xmm1,xmm0
       lea       r10,[rcx+rdx]
       vmovsd    qword ptr [r10],xmm4
       vmovsd    qword ptr [r10+8],xmm5
       vmovsd    qword ptr [r10+10],xmm16
       vmovsd    qword ptr [r10+18],xmm0
       add       rdx,20
       dec       r8d
       jne       near ptr M00_L00
       ret
; Total bytes of code 296
```
