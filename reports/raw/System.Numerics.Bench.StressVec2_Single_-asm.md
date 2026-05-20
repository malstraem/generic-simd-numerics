## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Single, System.Private.CoreLib]].Length()
       mov       rax,1E3C4800358
       mov       rax,[rax]
       mov       rcx,1E3C4800368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm0,xmm1
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 82
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Single, System.Private.CoreLib]].Distance()
       xor       eax,eax
       mov       rcx,201EC400358
       mov       rcx,[rcx]
       mov       rdx,201EC400368
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       inc       eax
       mov       r10d,eax
       lea       r10,[rcx+r10*8+10]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vsubss    xmm0,xmm0,xmm2
       vsubss    xmm1,xmm1,xmm3
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm0,xmm1
       vsqrtss   xmm0,xmm0,xmm0
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 107
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`1[[System.Single, System.Private.CoreLib]].Normalize()
       mov       rax,173A2400358
       mov       rax,[rax]
       mov       rcx,173A2400360
       mov       rcx,[rcx]
       mov       edx,10
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmulss    xmm2,xmm0,xmm0
       vmulss    xmm3,xmm1,xmm1
       vaddss    xmm2,xmm2,xmm3
       vsqrtss   xmm2,xmm2,xmm2
       vdivss    xmm0,xmm0,xmm2
       vdivss    xmm1,xmm1,xmm2
       lea       r10,[rcx+rdx]
       vmovss    dword ptr [r10],xmm0
       vmovss    dword ptr [r10+4],xmm1
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 101
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Single, System.Private.CoreLib]].Add()
       sub       rsp,18
       xor       eax,eax
       mov       rcx,25A9CC00358
       mov       rcx,[rcx]
       mov       rdx,25A9CC00360
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+10],r10
       inc       eax
       mov       r10d,eax
       mov       r10,[rcx+r10*8+10]
       mov       [rsp+8],r10
       vmovsd    xmm0,qword ptr [rsp+10]
       vmovsd    xmm1,qword ptr [rsp+8]
       vaddps    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rsp+10],xmm0
       mov       r10,[rsp+10]
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       add       rsp,18
       ret
; Total bytes of code 104
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Single, System.Private.CoreLib]].Subtract()
       xor       eax,eax
       mov       rcx,22870000358
       mov       rcx,[rcx]
       mov       rdx,22870000360
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       inc       eax
       mov       r10d,eax
       lea       r10,[rcx+r10*8+10]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vsubss    xmm0,xmm0,xmm2
       vsubss    xmm1,xmm1,xmm3
       lea       r8,[rdx+r8*8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 100
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Single, System.Private.CoreLib]].Multiply()
       xor       eax,eax
       mov       rcx,19516400358
       mov       rcx,[rcx]
       mov       rdx,19516400360
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       inc       eax
       mov       r10d,eax
       lea       r10,[rcx+r10*8+10]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vmulss    xmm0,xmm0,xmm2
       vmulss    xmm1,xmm1,xmm3
       lea       r8,[rdx+r8*8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 100
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Single, System.Private.CoreLib]].Divide()
       xor       eax,eax
       mov       rcx,2A33CC00358
       mov       rcx,[rcx]
       mov       rdx,2A33CC00360
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       inc       eax
       mov       r10d,eax
       lea       r10,[rcx+r10*8+10]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vdivss    xmm0,xmm0,xmm2
       vdivss    xmm1,xmm1,xmm3
       lea       r8,[rdx+r8*8+10]
       vmovss    dword ptr [r8],xmm0
       vmovss    dword ptr [r8+4],xmm1
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 100
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Single, System.Private.CoreLib]].Sum()
       mov       rax,2639A000358
       mov       rax,[rax]
       mov       rcx,2639A000368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vaddss    xmm0,xmm0,xmm1
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 70
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Single, System.Private.CoreLib]].Dot()
       xor       eax,eax
       mov       rcx,1F997800358
       mov       rcx,[rcx]
       mov       rdx,1F997800368
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       inc       eax
       mov       r9d,eax
       lea       r9,[rcx+r9*8+10]
       vmovss    xmm0,dword ptr [r9]
       vmovss    xmm1,dword ptr [r9+4]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vmulss    xmm0,xmm2,xmm0
       vmulss    xmm1,xmm3,xmm1
       vaddss    xmm0,xmm0,xmm1
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 95
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Single, System.Private.CoreLib]].LengthSquared()
       mov       rax,2A50B800358
       mov       rax,[rax]
       mov       rcx,2A50B800368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       vmovss    xmm0,dword ptr [r10]
       vmovss    xmm1,dword ptr [r10+4]
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm0,xmm1
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 78
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressBaseVec2I`1[[System.Single, System.Private.CoreLib]].DistanceSquared()
       xor       eax,eax
       mov       rcx,21A37400358
       mov       rcx,[rcx]
       mov       rdx,21A37400368
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       inc       eax
       mov       r9d,eax
       lea       r9,[rcx+r9*8+10]
       vmovss    xmm0,dword ptr [r9]
       vmovss    xmm1,dword ptr [r9+4]
       vmovss    xmm2,dword ptr [r10]
       vmovss    xmm3,dword ptr [r10+4]
       vsubss    xmm0,xmm2,xmm0
       vsubss    xmm1,xmm3,xmm1
       vmulss    xmm0,xmm0,xmm0
       vmulss    xmm1,xmm1,xmm1
       vaddss    xmm0,xmm0,xmm1
       vmovss    dword ptr [rdx+r8*4+10],xmm0
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 103
```

