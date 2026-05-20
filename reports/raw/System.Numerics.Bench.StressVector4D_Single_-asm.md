## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Single, System.Private.CoreLib]].Length()
       mov       rax,22091000360
       mov       rax,[rax]
       mov       rcx,22091000370
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
       jne       short M00_L00
       ret
; Total bytes of code 131
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Single, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,20068C00360
       mov       rcx,[rcx]
       mov       rdx,20068C00370
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
       jl        near ptr M00_L00
       ret
; Total bytes of code 176
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4D`1[[System.Single, System.Private.CoreLib]].Normalize()
       mov       rax,16467400360
       mov       rax,[rax]
       mov       rcx,16467400368
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
       jne       short M00_L00
       ret
; Total bytes of code 149
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Single, System.Private.CoreLib]].Add()
       mov       rax,255DBC00360
       mov       rax,[rax]
       mov       rcx,255DBC00368
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
       vaddss    xmm2,xmm2,xmm16
       vaddss    xmm3,xmm3,xmm17
       lea       r8,[rcx+r8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       vmovss    dword ptr [r8+8],xmm2
       vmovss    dword ptr [r8+0C],xmm3
       cmp       edx,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Single, System.Private.CoreLib]].Subtract()
       mov       rax,21900000360
       mov       rax,[rax]
       mov       rcx,21900000368
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
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Single, System.Private.CoreLib]].Multiply()
       mov       rax,2E42AC00360
       mov       rax,[rax]
       mov       rcx,2E42AC00368
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
       vmulss    xmm2,xmm2,xmm16
       vmulss    xmm3,xmm3,xmm17
       lea       r8,[rcx+r8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       vmovss    dword ptr [r8+8],xmm2
       vmovss    dword ptr [r8+0C],xmm3
       cmp       edx,1869F
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Single, System.Private.CoreLib]].Divide()
       mov       rax,14DEF000360
       mov       rax,[rax]
       mov       rcx,14DEF000368
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
       jl        near ptr M00_L00
       ret
; Total bytes of code 163
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Single, System.Private.CoreLib]].Abs()
       mov       rax,16695800360
       mov       rax,[rax]
       mov       rcx,16695800368
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
       jne       near ptr M00_L00
       ret
; Total bytes of code 173
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Single, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,1F7DD400360
       mov       rcx,[rcx]
       mov       rdx,1F7DD400370
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
       vmulss    xmm1,xmm2,xmm16
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,xmm17
       vaddss    xmm0,xmm1,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 152
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Single, System.Private.CoreLib]].LengthSquared()
       mov       rax,1FD49C00360
       mov       rax,[rax]
       mov       rcx,1FD49C00370
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
       jne       short M00_L00
       ret
; Total bytes of code 127
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Single, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,1F6ECC00360
       mov       rcx,[rcx]
       mov       rdx,1F6ECC00370
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
       jl        near ptr M00_L00
       ret
; Total bytes of code 172
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVector4DI`1[[System.Single, System.Private.CoreLib]].Transform()
       mov       rax,17DB1C00360
       mov       rax,[rax]
       mov       rcx,17DB1C00368
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmovss    xmm2,dword ptr [r10+8]
       vmovss    xmm3,dword ptr [r10+0C]
       vmulss    xmm4,xmm1,dword ptr [7FF7FD4CA208]
       vaddss    xmm4,xmm4,xmm0
       vmulss    xmm5,xmm2,dword ptr [7FF7FD4CA20C]
       vaddss    xmm4,xmm5,xmm4
       vmulss    xmm5,xmm3,dword ptr [7FF7FD4CA210]
       vaddss    xmm4,xmm5,xmm4
       vaddss    xmm5,xmm0,xmm0
       vmulss    xmm16,xmm1,dword ptr [7FF7FD4CA214]
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm2,dword ptr [7FF7FD4CA218]
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm3,dword ptr [7FF7FD4CA21C]
       vaddss    xmm5,xmm16,xmm5
       vmulss    xmm16,xmm0,dword ptr [7FF7FD4CA220]
       vmulss    xmm17,xmm1,dword ptr [7FF7FD4CA224]
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm17,xmm2,dword ptr [7FF7FD4CA228]
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm17,xmm3,dword ptr [7FF7FD4CA22C]
       vaddss    xmm16,xmm17,xmm16
       vmulss    xmm0,xmm0,dword ptr [7FF7FD4CA230]
       vmulss    xmm1,xmm1,dword ptr [7FF7FD4CA234]
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm2,dword ptr [7FF7FD4CA238]
       vaddss    xmm0,xmm1,xmm0
       vmulss    xmm1,xmm3,dword ptr [7FF7FD4CA23C]
       vaddss    xmm0,xmm1,xmm0
       lea       r10,[rcx+rdx]
       vmovss    dword ptr [r10],xmm4
       vmovss    dword ptr [r10+4],xmm5
       vmovss    dword ptr [r10+8],xmm16
       vmovss    dword ptr [r10+0C],xmm0
       add       rdx,10
       dec       r8d
       jne       near ptr M00_L00
       ret
; Total bytes of code 296
```

