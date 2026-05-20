## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Single, System.Private.CoreLib]].IsIntersect()
       xor       eax,eax
       mov       rcx,1E0C6C00358
       mov       rcx,[rcx]
       mov       rdx,1E0C6C00360
       mov       rdx,[rdx]
       mov       r8,1E0A42D8E18
       vmovups   xmm0,[r8]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       vmovups   xmm1,[rcx+r9+10]
       vmovups   xmm2,[r10]
       vpermilps xmm2,xmm2,4E
       vmulps    xmm2,xmm2,xmm0
       vmulps    xmm1,xmm0,xmm1
       vcmpleps  xmm1,xmm2,xmm1
       vpcmpeqd  xmm2,xmm2,xmm2
       vptest    xmm1,xmm2
       setb      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 124
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Single, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,16103800358
       mov       rcx,[rcx]
       mov       rdx,16103800360
       mov       rdx,[rdx]
       mov       r8,170BA858E18
       vmovups   xmm0,[r8]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,4
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,4
       vmovups   xmm1,[rcx+r9+10]
       vmovups   xmm2,[r10]
       vmulps    xmm1,xmm0,xmm1
       vmulps    xmm2,xmm0,xmm2
       vcmpleps  xmm1,xmm1,xmm2
       vpcmpeqd  xmm2,xmm2,xmm2
       vptest    xmm1,xmm2
       setb      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 118
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Single, System.Private.CoreLib]].Area()
       mov       rax,18D8E400358
       mov       rax,[rax]
       mov       rcx,18D8E400368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpermilps xmm1,xmm0,4E
       vsubps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,0B1
       vmulps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 76
```

