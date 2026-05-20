## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Double, System.Private.CoreLib]].Length()
       mov       rax,20705000360
       mov       rax,[rax]
       mov       rcx,20705000370
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Double, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,2361D400360
       mov       rcx,[rcx]
       mov       rdx,2361D400370
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Double, System.Private.CoreLib]].Normalize()
       mov       rax,2A35B800360
       mov       rax,[rax]
       mov       rcx,2A35B800368
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Double, System.Private.CoreLib]].Add()
       mov       rax,1A75D000360
       mov       rax,[rax]
       mov       rcx,1A75D000368
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
       vaddsd    xmm2,xmm2,xmm16
       vaddsd    xmm3,xmm3,xmm17
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Double, System.Private.CoreLib]].Subtract()
       mov       rax,23306400360
       mov       rax,[rax]
       mov       rcx,23306400368
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Double, System.Private.CoreLib]].Multiply()
       mov       rax,21ABC800360
       mov       rax,[rax]
       mov       rcx,21ABC800368
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
       vmulsd    xmm2,xmm2,xmm16
       vmulsd    xmm3,xmm3,xmm17
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Double, System.Private.CoreLib]].Divide()
       mov       rax,239A4C00360
       mov       rax,[rax]
       mov       rcx,239A4C00368
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Double, System.Private.CoreLib]].Abs()
       mov       rax,2602E000360
       mov       rax,[rax]
       mov       rcx,2602E000368
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Double, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,2385C000360
       mov       rcx,[rcx]
       mov       rdx,2385C000370
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
       vmulsd    xmm1,xmm2,xmm16
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm3,xmm17
       vaddsd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 152
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Double, System.Private.CoreLib]].LengthSquared()
       mov       rax,1C20AC00360
       mov       rax,[rax]
       mov       rcx,1C20AC00370
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Double, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,23934400360
       mov       rcx,[rcx]
       mov       rdx,23934400370
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Double, System.Private.CoreLib]].Transform()
       mov       rax,22A11800360
       mov       rax,[rax]
       mov       rcx,22A11800368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       vmulsd    xmm4,xmm1,qword ptr [7FF7FD4EA308]
       vaddsd    xmm4,xmm4,xmm0
       vmulsd    xmm5,xmm2,qword ptr [7FF7FD4EA310]
       vaddsd    xmm4,xmm5,xmm4
       vmulsd    xmm5,xmm3,qword ptr [7FF7FD4EA318]
       vaddsd    xmm4,xmm5,xmm4
       vaddsd    xmm5,xmm0,xmm0
       vmulsd    xmm16,xmm1,qword ptr [7FF7FD4EA320]
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm2,qword ptr [7FF7FD4EA328]
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm3,qword ptr [7FF7FD4EA330]
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm0,qword ptr [7FF7FD4EA338]
       vmulsd    xmm17,xmm1,qword ptr [7FF7FD4EA340]
       vaddsd    xmm16,xmm17,xmm16
       vmulsd    xmm17,xmm2,qword ptr [7FF7FD4EA348]
       vaddsd    xmm16,xmm17,xmm16
       vmulsd    xmm17,xmm3,qword ptr [7FF7FD4EA350]
       vaddsd    xmm16,xmm17,xmm16
       vmulsd    xmm0,xmm0,qword ptr [7FF7FD4EA358]
       vmulsd    xmm1,xmm1,qword ptr [7FF7FD4EA360]
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm2,qword ptr [7FF7FD4EA368]
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm3,qword ptr [7FF7FD4EA370]
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

