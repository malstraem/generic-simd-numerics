## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Single, System.Private.CoreLib]].Length()
       mov       rax,229BBC01578
       mov       rax,[rax]
       mov       rcx,229BBC01588
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovss    xmm0,dword ptr [r10]
       vmovaps   xmm1,xmm0
       vmovss    xmm2,dword ptr [r10+4]
       vmovaps   xmm3,xmm2
       vmovss    xmm4,dword ptr [r10+8]
       vmovaps   xmm5,xmm4
       vmovss    xmm16,dword ptr [r10+0C]
       vmovaps   xmm17,xmm16
       vmulss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,xmm2
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm5,xmm4
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm17,xmm16
       vaddss    xmm0,xmm1,xmm0
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short 00000000000036E2
       ret
; Total bytes of code 131
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Single, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,222A3C01568
       mov       rcx,[rcx]
       mov       rdx,222A3C01578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vsubss    xmm0,xmm0,xmm4
       vsubss    xmm1,xmm1,xmm5
       vsubss    xmm2,xmm2,xmm16
       vsubss    xmm3,xmm3,xmm17
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm2,xmm2
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,xmm3
       vaddss    xmm0,xmm1,xmm0
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        near ptr 0000000000002A3C
       ret
; Total bytes of code 176
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Single, System.Private.CoreLib]].Normalize()
       mov       rax,19904C01568
       mov       rax,[rax]
       mov       rcx,19904C01570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       vmulss    xmm4,xmm0,xmm0
       vmulss    xmm5,xmm1,xmm1
       vaddss    xmm4,xmm5,xmm4
       vmulss    xmm5,xmm2,xmm2
       vaddss    xmm4,xmm5,xmm4
       vmulss    xmm5,xmm3,xmm3
       vaddss    xmm4,xmm5,xmm4
       vsqrtss   xmm4,xmm4,xmm4
       vdivss    xmm0,xmm0,xmm4
       vdivss    xmm1,xmm1,xmm4
       vdivss    xmm2,xmm2,xmm4
       vdivss    xmm3,xmm3,xmm4
       lea       r10,[rcx+rdx]
       vmovss    dword ptr [r10],xmm0
       vmovss    dword ptr [r10+4],xmm1
       vmovss    dword ptr [r10+8],xmm2
       vmovss    dword ptr [r10+0C],xmm3
       add       rdx,10
       dec       r8d
       jne       short 0000000000002925
       ret
; Total bytes of code 149
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Add()
       mov       rax,205A7801568
       mov       rax,[rax]
       mov       rcx,205A7801570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vaddss    xmm0,xmm0,xmm4
       vaddss    xmm1,xmm1,xmm5
       vaddss    xmm2,xmm16,xmm2
       vaddss    xmm3,xmm17,xmm3
       lea       r8,[rcx+r8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       vmovss    dword ptr [r8+8],xmm2
       vmovss    dword ptr [r8+0C],xmm3
       cmp       edx,1869F
       jl        near ptr 0000000000002F3C
       ret
; Total bytes of code 163
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Subtract()
       mov       rax,1EFBCC01568
       mov       rax,[rax]
       mov       rcx,1EFBCC01570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vsubss    xmm0,xmm0,xmm4
       vsubss    xmm1,xmm1,xmm5
       vsubss    xmm2,xmm2,xmm16
       vsubss    xmm3,xmm3,xmm17
       lea       r8,[rcx+r8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       vmovss    dword ptr [r8+8],xmm2
       vmovss    dword ptr [r8+0C],xmm3
       cmp       edx,1869F
       jl        near ptr 0000000000002A5C
       ret
; Total bytes of code 163
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Multiply()
       mov       rax,1874A401578
       mov       rax,[rax]
       mov       rcx,1874A401580
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vmulss    xmm0,xmm0,xmm4
       vmulss    xmm1,xmm1,xmm5
       vmulss    xmm2,xmm16,xmm2
       vmulss    xmm3,xmm17,xmm3
       lea       r8,[rcx+r8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       vmovss    dword ptr [r8+8],xmm2
       vmovss    dword ptr [r8+0C],xmm3
       cmp       edx,1869F
       jl        near ptr 0000000000002FBC
       ret
; Total bytes of code 163
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Divide()
       mov       rax,1F0F9C01568
       mov       rax,[rax]
       mov       rcx,1F0F9C01570
       mov       rcx,[rcx]
       xor       edx,edx
M00_L00:
       mov       r8,rdx
       shl       r8,4
       lea       r10,[rax+r8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       edx
       mov       r10d,edx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vdivss    xmm0,xmm0,xmm4
       vdivss    xmm1,xmm1,xmm5
       vdivss    xmm2,xmm2,xmm16
       vdivss    xmm3,xmm3,xmm17
       lea       r8,[rcx+r8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       vmovss    dword ptr [r8+8],xmm2
       vmovss    dword ptr [r8+0C],xmm3
       cmp       edx,1869F
       jl        near ptr 00000000000038DC
       ret
; Total bytes of code 163
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Abs()
       mov       rax,25E36001568
       mov       rax,[rax]
       mov       rcx,25E36001570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       vmovd     r10d,xmm0
       and       r10d,7FFFFFFF
       vmovd     xmm0,r10d
       vmovd     r10d,xmm1
       and       r10d,7FFFFFFF
       vmovd     xmm1,r10d
       vmovd     r10d,xmm2
       and       r10d,7FFFFFFF
       vmovd     xmm2,r10d
       vmovd     r10d,xmm3
       and       r10d,7FFFFFFF
       vmovd     xmm3,r10d
       lea       r10,[rcx+rdx]
       vmovss    dword ptr [r10],xmm0
       vmovss    dword ptr [r10+4],xmm1
       vmovss    dword ptr [r10+8],xmm2
       vmovss    dword ptr [r10+0C],xmm3
       add       rdx,10
       dec       r8d
       jne       near ptr 0000000000002C25
       ret
; Total bytes of code 173
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,202B7401568
       mov       rcx,[rcx]
       mov       rdx,202B7401578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vmulss    xmm0,xmm0,xmm4
       vmulss    xmm1,xmm1,xmm5
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm16,xmm2
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm17,xmm3
       vaddss    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short 00000000000037BC
       ret
; Total bytes of code 152
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].LengthSquared()
       mov       rax,2AC3C001568
       mov       rax,[rax]
       mov       rcx,2AC3C001578
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*4+10]
       vmovss    xmm0,dword ptr [r10]
       vmovaps   xmm1,xmm0
       vmovss    xmm2,dword ptr [r10+4]
       vmovaps   xmm3,xmm2
       vmovss    xmm4,dword ptr [r10+8]
       vmovaps   xmm5,xmm4
       vmovss    xmm16,dword ptr [r10+0C]
       vmovaps   xmm17,xmm16
       vmulss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,xmm2
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm5,xmm4
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm17,xmm16
       vaddss    xmm0,xmm1,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short 00000000000028E2
       ret
; Total bytes of code 127
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,20C2B001568
       mov       rcx,[rcx]
       mov       rdx,20C2B001578
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovss    xmm4,dword ptr [r10]
       vmovss    xmm5,dword ptr [r10+4]
       vmovss    xmm16,dword ptr [r10+8]
       vmovss    xmm17,dword ptr [r10+0C]
       vsubss    xmm0,xmm0,xmm4
       vsubss    xmm1,xmm1,xmm5
       vsubss    xmm2,xmm2,xmm16
       vsubss    xmm3,xmm3,xmm17
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm2,xmm2
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,xmm3
       vaddss    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        near ptr 000000000000293C
       ret
; Total bytes of code 172
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressVector4D`1[[System.Single, System.Private.CoreLib]].Transform()
       mov       rax,279AFC01568
       mov       rax,[rax]
       mov       rcx,279AFC01570
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       vmulss    xmm4,xmm1,dword ptr [2AE8]
       vaddss    xmm4,xmm4,xmm0
       vmulss    xmm5,xmm2,dword ptr [2AEC]
       vaddss    xmm4,xmm5,xmm4
       vmulss    xmm5,xmm3,dword ptr [2AF0]
       vaddss    xmm4,xmm5,xmm4
       vaddss    xmm5,xmm0,xmm0
       vmulss    xmm16,xmm1,dword ptr [2AF4]
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm2,dword ptr [2AF8]
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm3,dword ptr [2AFC]
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm0,dword ptr [2B00]
       vmulss    xmm17,xmm1,dword ptr [2B04]
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm17,xmm2,dword ptr [2B08]
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm17,xmm3,dword ptr [2B0C]
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm0,xmm0,dword ptr [2B10]
       vmulss    xmm1,xmm1,dword ptr [2B14]
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm2,dword ptr [2B18]
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,dword ptr [2B1C]
       vaddss    xmm0,xmm1,xmm0
       lea       r10,[rcx+rdx]
       vmovss    dword ptr [r10],xmm4
       vmovss    dword ptr [r10+4],xmm5
       vmovss    dword ptr [r10+8],xmm16
       vmovss    dword ptr [r10+0C],xmm0
       add       rdx,10
       dec       r8d
       jne       near ptr 00000000000029E5
       ret
; Total bytes of code 296
```

