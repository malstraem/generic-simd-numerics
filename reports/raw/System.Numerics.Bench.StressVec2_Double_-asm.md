## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Add()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+8],rax
       mov       [rsp+10],rax
       mov       rax,26829000358
       mov       rax,[rax]
       xor       ecx,ecx
       nop
M00_L00:
       mov       rdx,rcx
       shl       rdx,4
       lea       rdx,[rax+rdx+10]
       mov       r8,rdx
       vmovsd    xmm0,qword ptr [r8]
       vmovsd    xmm1,qword ptr [r8+8]
       inc       ecx
       mov       r8d,ecx
       shl       r8,4
       lea       r8,[rax+r8+10]
       vmovsd    xmm2,qword ptr [r8]
       vmovsd    xmm3,qword ptr [r8+8]
       vmovsd    qword ptr [rsp+28],xmm0
       vmovsd    qword ptr [rsp+30],xmm1
       vmovups   xmm0,[rsp+28]
       vmovsd    qword ptr [rsp+18],xmm2
       vmovsd    qword ptr [rsp+20],xmm3
       vaddpd    xmm0,xmm0,[rsp+18]
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vmovups   [rdx],xmm0
       cmp       ecx,1869F
       jl        short M00_L00
       add       rsp,38
       ret
; Total bytes of code 148
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Subtract()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+8],rax
       mov       [rsp+10],rax
       mov       rax,22939C00358
       mov       rax,[rax]
       xor       ecx,ecx
       nop
M00_L00:
       mov       rdx,rcx
       shl       rdx,4
       lea       rdx,[rax+rdx+10]
       mov       r8,rdx
       vmovsd    xmm0,qword ptr [r8]
       vmovsd    xmm1,qword ptr [r8+8]
       inc       ecx
       mov       r8d,ecx
       shl       r8,4
       lea       r8,[rax+r8+10]
       vmovsd    xmm2,qword ptr [r8]
       vmovsd    xmm3,qword ptr [r8+8]
       vmovsd    qword ptr [rsp+28],xmm0
       vmovsd    qword ptr [rsp+30],xmm1
       vmovups   xmm0,[rsp+28]
       vmovsd    qword ptr [rsp+18],xmm2
       vmovsd    qword ptr [rsp+20],xmm3
       vsubpd    xmm0,xmm0,[rsp+18]
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vmovups   [rdx],xmm0
       cmp       ecx,1869F
       jl        short M00_L00
       add       rsp,38
       ret
; Total bytes of code 148
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].ElementMultiply()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+8],rax
       mov       [rsp+10],rax
       mov       rax,28AD0800358
       mov       rax,[rax]
       xor       ecx,ecx
       nop
M00_L00:
       mov       rdx,rcx
       shl       rdx,4
       lea       rdx,[rax+rdx+10]
       mov       r8,rdx
       inc       ecx
       mov       r10d,ecx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovups   xmm2,[r8]
       vmovups   [rsp+28],xmm2
       vmovups   xmm2,[rsp+28]
       vmovsd    qword ptr [rsp+18],xmm0
       vmovsd    qword ptr [rsp+20],xmm1
       vmulpd    xmm0,xmm2,[rsp+18]
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vmovups   [rdx],xmm0
       cmp       ecx,1869F
       jl        short M00_L00
       add       rsp,38
       ret
; Total bytes of code 136
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].ElementDivide()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+8],rax
       mov       [rsp+10],rax
       mov       rax,17EC2800358
       mov       rax,[rax]
       xor       ecx,ecx
       nop
M00_L00:
       mov       rdx,rcx
       shl       rdx,4
       lea       rdx,[rax+rdx+10]
       mov       r8,rdx
       inc       ecx
       mov       r10d,ecx
       shl       r10,4
       lea       r10,[rax+r10+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       vmovups   xmm2,[r8]
       vmovups   [rsp+28],xmm2
       vmovups   xmm2,[rsp+28]
       vmovsd    qword ptr [rsp+18],xmm0
       vmovsd    qword ptr [rsp+20],xmm1
       vdivpd    xmm0,xmm2,[rsp+18]
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vmovups   [rdx],xmm0
       cmp       ecx,1869F
       jl        short M00_L00
       add       rsp,38
       ret
; Total bytes of code 136
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Abs()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+8],rax
       mov       [rsp+10],rax
       mov       rax,2BE99C00358
       mov       rax,[rax]
       vmovddup  xmm0,qword ptr [7FFBAF769C40]
       add       rax,10
       mov       ecx,186A0
M00_L00:
       vmovups   xmm1,[rax]
       vmovups   [rsp+18],xmm1
       vandpd    xmm1,xmm0,[rsp+18]
       vmovups   [rsp+8],xmm1
       vmovups   xmm1,[rsp+8]
       vmovups   [rax],xmm1
       add       rax,10
       dec       ecx
       jne       short M00_L00
       add       rsp,28
       ret
; Total bytes of code 91
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Sum()
       sub       rsp,18
       mov       rax,214FF400358
       mov       rax,[rax]
       mov       rcx,214FF400360
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       vmovups   xmm0,[rax+rdx*2+10]
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       add       rsp,18
       ret
; Total bytes of code 86
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Dot()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+18],rax
       mov       [rsp+20],rax
       xor       eax,eax
       mov       rcx,1661F800358
       mov       rcx,[rcx]
       mov       rdx,1661F800360
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovsd    xmm1,qword ptr [r10+8]
       inc       eax
       mov       r10d,eax
       shl       r10,4
       lea       r10,[rcx+r10+10]
       vmovsd    xmm2,qword ptr [r10]
       vmovsd    xmm3,qword ptr [r10+8]
       vmovsd    qword ptr [rsp+38],xmm0
       vmovsd    qword ptr [rsp+40],xmm1
       vmovups   xmm0,[rsp+38]
       vmovsd    qword ptr [rsp+28],xmm2
       vmovsd    qword ptr [rsp+30],xmm3
       vmulpd    xmm0,xmm0,[rsp+28]
       vmovups   [rsp+18],xmm0
       vmovups   xmm0,[rsp+18]
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,48
       ret
; Total bytes of code 188
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].LengthSquared()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+18],rax
       mov       [rsp+20],rax
       mov       rax,23C75000358
       mov       rax,[rax]
       mov       rcx,23C75000360
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovaps   xmm1,xmm0
       vmovsd    xmm2,qword ptr [r10+8]
       vmovaps   xmm3,xmm2
       vmovsd    qword ptr [rsp+38],xmm1
       vmovsd    qword ptr [rsp+40],xmm3
       vmovups   xmm1,[rsp+38]
       vmovsd    qword ptr [rsp+28],xmm0
       vmovsd    qword ptr [rsp+30],xmm2
       vmulpd    xmm0,xmm1,[rsp+28]
       vmovups   [rsp+18],xmm0
       vmovups   xmm0,[rsp+18]
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       add       rsp,48
       ret
; Total bytes of code 164
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].DistanceSquared()
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+18],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       rcx,214E8C00358
       mov       rcx,[rcx]
       mov       rdx,214E8C00360
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       lea       r9,[rcx+r9+10]
       vmovsd    xmm0,qword ptr [r9]
       vmovsd    xmm1,qword ptr [r9+8]
       vmovups   xmm2,[r10]
       vmovups   [rsp+68],xmm2
       vmovups   xmm2,[rsp+68]
       vmovsd    qword ptr [rsp+58],xmm0
       vmovsd    qword ptr [rsp+60],xmm1
       vsubpd    xmm0,xmm2,[rsp+58]
       vmovups   [rsp+48],xmm0
       vmovups   xmm0,[rsp+48]
       vmovups   [rsp+38],xmm0
       vmovups   xmm0,[rsp+38]
       vmovups   xmm1,[rsp+48]
       vmovups   [rsp+28],xmm1
       vmulpd    xmm0,xmm0,[rsp+28]
       vmovups   [rsp+18],xmm0
       vmovups   xmm0,[rsp+18]
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,78
       ret
; Total bytes of code 234
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Length()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+18],rax
       mov       [rsp+20],rax
       mov       rax,2597E400358
       mov       rax,[rax]
       mov       rcx,2597E400360
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,186A0
M00_L00:
       lea       r10,[rax+rdx*2+10]
       vmovsd    xmm0,qword ptr [r10]
       vmovaps   xmm1,xmm0
       vmovsd    xmm2,qword ptr [r10+8]
       vmovaps   xmm3,xmm2
       vmovsd    qword ptr [rsp+38],xmm1
       vmovsd    qword ptr [rsp+40],xmm3
       vmovups   xmm1,[rsp+38]
       vmovsd    qword ptr [rsp+28],xmm0
       vmovsd    qword ptr [rsp+30],xmm2
       vmulpd    xmm0,xmm1,[rsp+28]
       vmovups   [rsp+18],xmm0
       vmovups   xmm0,[rsp+18]
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       add       rsp,48
       ret
; Total bytes of code 168
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Distance()
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+18],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       xor       eax,eax
       mov       rcx,23D8E400358
       mov       rcx,[rcx]
       mov       rdx,23D8E400360
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       lea       r9,[rcx+r9+10]
       vmovsd    xmm0,qword ptr [r9]
       vmovsd    xmm1,qword ptr [r9+8]
       vmovups   xmm2,[r10]
       vmovups   [rsp+68],xmm2
       vmovups   xmm2,[rsp+68]
       vmovsd    qword ptr [rsp+58],xmm0
       vmovsd    qword ptr [rsp+60],xmm1
       vsubpd    xmm0,xmm2,[rsp+58]
       vmovups   [rsp+48],xmm0
       vmovups   xmm0,[rsp+48]
       vmovups   [rsp+38],xmm0
       vmovups   xmm0,[rsp+38]
       vmovups   xmm1,[rsp+48]
       vmovups   [rsp+28],xmm1
       vmulpd    xmm0,xmm0,[rsp+28]
       vmovups   [rsp+18],xmm0
       vmovups   xmm0,[rsp+18]
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vpermilpd xmm1,xmm0,1
       vaddpd    xmm0,xmm1,xmm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0
       cmp       eax,1869F
       jl        near ptr M00_L00
       add       rsp,78
       ret
; Total bytes of code 238
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressVec2`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Normalize()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+10],ymm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rax,21F37800358
       mov       rax,[rax]
       add       rax,10
       mov       ecx,186A0
M00_L00:
       mov       rdx,rax
       vmovsd    xmm0,qword ptr [rdx]
       vmovaps   xmm1,xmm0
       vmovsd    xmm2,qword ptr [rdx+8]
       vmovaps   xmm3,xmm2
       vmovaps   xmm4,xmm0
       vmovaps   xmm5,xmm2
       vmovsd    qword ptr [rsp+58],xmm4
       vmovsd    qword ptr [rsp+60],xmm5
       vmovups   xmm4,[rsp+58]
       vmovsd    qword ptr [rsp+48],xmm0
       vmovsd    qword ptr [rsp+50],xmm2
       vmulpd    xmm0,xmm4,[rsp+48]
       vmovups   [rsp+38],xmm0
       vmovups   xmm0,[rsp+38]
       vmovups   [rsp+28],xmm0
       vmovups   xmm0,[rsp+28]
       vpermilpd xmm2,xmm0,1
       vaddpd    xmm0,xmm2,xmm0
       vsqrtsd   xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsp+18],xmm1
       vmovsd    qword ptr [rsp+20],xmm3
       vmovups   xmm1,[rsp+18]
       vmovddup  xmm0,xmm0
       vdivpd    xmm0,xmm1,xmm0
       vmovups   [rsp+8],xmm0
       vmovups   xmm0,[rsp+8]
       vmovups   [rax],xmm0
       add       rax,10
       dec       ecx
       jne       near ptr M00_L00
       add       rsp,68
       ret
; Total bytes of code 215
```

