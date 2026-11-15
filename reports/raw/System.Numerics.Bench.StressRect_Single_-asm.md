## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Single, System.Private.CoreLib]].Intersects()
       xor       eax,eax
       mov       rcx,13356C01560
       mov       rcx,[rcx]
       mov       rdx,13356C01568
       mov       rdx,[rdx]
       mov       r8,133242E31B0
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
       jl        short 00000000000032AB
       ret
; Total bytes of code 124
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Single, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,19906C01560
       mov       rcx,[rcx]
       mov       rdx,19906C01568
       mov       rdx,[rdx]
       mov       r8,1A8BDD431A0
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
       jl        short 0000000000002EAB
       ret
; Total bytes of code 118
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Single, System.Private.CoreLib]].Area()
       mov       rax,27E49401560
       mov       rax,[rax]
       mov       rcx,27E49401570
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpermilps xmm1,xmm0,4E
       vsubps    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,0F5
       vmulps    xmm0,xmm1,xmm0
       vmovss    dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short 0000000000002EA2
       ret
; Total bytes of code 76
```

