## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Double, System.Private.CoreLib]].Length()
       mov       rax,218AB001568
       mov       rax,[rax]
       mov       rcx,218AB001578
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
       jne       short 0000000000002AC2
       ret
; Total bytes of code 131
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Double, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,261B9401578
       mov       rcx,[rcx]
       mov       rdx,261B9401588
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
       jl        near ptr 0000000000002F5C
       ret
; Total bytes of code 176
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Double, System.Private.CoreLib]].Normalize()
       mov       rax,2412AC01568
       mov       rax,[rax]
       mov       rcx,2412AC01570
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
       jne       short 00000000000032E5
       ret
; Total bytes of code 149
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Add()
       mov       rax,143CFC01568
       mov       rax,[rax]
       mov       rcx,143CFC01570
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
       jl        near ptr 0000000000002F7C
       ret
; Total bytes of code 163
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Subtract()
       mov       rax,2A9DC801568
       mov       rax,[rax]
       mov       rcx,2A9DC801570
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
       jl        near ptr 0000000000002ABC
       ret
; Total bytes of code 163
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Multiply()
       mov       rax,158F8C01568
       mov       rax,[rax]
       mov       rcx,158F8C01570
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
       jl        near ptr 0000000000002BBC
       ret
; Total bytes of code 163
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Divide()
       mov       rax,25541C01568
       mov       rax,[rax]
       mov       rcx,25541C01570
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
       jl        near ptr 0000000000002A7C
       ret
; Total bytes of code 163
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Abs()
       mov       rax,1DA4B401568
       mov       rax,[rax]
       mov       rcx,1DA4B401570
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
       mov       r9,0FFFFFFFFFFFF
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
       jne       short 00000000000028E5
       ret
; Total bytes of code 163
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,1AFBD001568
       mov       rcx,[rcx]
       mov       rdx,1AFBD001578
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
       jl        short 000000000000295C
       ret
; Total bytes of code 152
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].LengthSquared()
       mov       rax,26F60801568
       mov       rax,[rax]
       mov       rcx,26F60801578
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
       jne       short 0000000000002FC2
       ret
; Total bytes of code 127
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,211E0C01568
       mov       rcx,[rcx]
       mov       rdx,211E0C01578
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
       jl        near ptr 0000000000002EFC
       ret
; Total bytes of code 172
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Double, System.Private.CoreLib]].Transform()
       mov       rax,17B31C01578
       mov       rax,[rax]
       mov       rcx,17B31C01580
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovsd    xmm2,qword ptr [r10+10]
       vmovsd    xmm3,qword ptr [r10+18]
       vmulsd    xmm4,xmm1,qword ptr [2FE8]
       vaddsd    xmm4,xmm4,xmm0
       vmulsd    xmm5,xmm2,qword ptr [2FF0]
       vaddsd    xmm4,xmm5,xmm4
       vmulsd    xmm5,xmm3,qword ptr [2FF8]
       vaddsd    xmm4,xmm5,xmm4
       vaddsd    xmm5,xmm0,xmm0
       vmulsd    xmm16,xmm1,qword ptr [3000]
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm2,qword ptr [3008]
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm3,qword ptr [3010]
       vaddsd    xmm5,xmm16,xmm5
       vmulsd    xmm16,xmm0,qword ptr [3018]
       vmulsd    xmm17,xmm1,qword ptr [3020]
       vaddsd    xmm16,xmm17,xmm16
       vmulsd    xmm17,xmm2,qword ptr [3028]
       vaddsd    xmm16,xmm17,xmm16
       vmulsd    xmm17,xmm3,qword ptr [3030]
       vaddsd    xmm16,xmm17,xmm16
       vmulsd    xmm0,xmm0,qword ptr [3038]
       vmulsd    xmm1,xmm1,qword ptr [3040]
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm2,qword ptr [3048]
       vaddsd    xmm0,xmm1,xmm0
       vmulsd    xmm1,xmm3,qword ptr [3050]
       vaddsd    xmm0,xmm1,xmm0
       lea       r10,[rcx+rdx]
       vmovsd    qword ptr [r10],xmm4
       vmovsd    qword ptr [r10+8],xmm5
       vmovsd    qword ptr [r10+10],xmm16
       vmovsd    qword ptr [r10+18],xmm0
       add       rdx,20
       dec       r8d
       jne       near ptr 0000000000002EE5
       ret
; Total bytes of code 296
```

