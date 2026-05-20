## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Double, System.Private.CoreLib]].IsIntersect()
       xor       eax,eax
       mov       rcx,251DFC00358
       mov       rcx,[rcx]
       mov       rdx,251DFC00360
       mov       rdx,[rdx]
       mov       r8,251A43A8E78
       vmovups   ymm0,[r8]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,5
       vmovups   ymm1,[rcx+r9+10]
       vmovups   ymm2,[r10]
       vpermq    ymm2,ymm2,4E
       vmulpd    ymm2,ymm2,ymm0
       vmulpd    ymm1,ymm0,ymm1
       vcmplepd  ymm1,ymm2,ymm1
       vpcmpeqd  ymm2,ymm2,ymm2
       vptest    ymm1,ymm2
       setb      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 127
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Double, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,1C61C800358
       mov       rcx,[rcx]
       mov       rdx,1C61C800360
       mov       rdx,[rdx]
       mov       r8,1D5D3988E78
       vmovups   ymm0,[r8]
M00_L00:
       mov       r8d,eax
       mov       r10,r8
       shl       r10,5
       lea       r10,[rcx+r10+10]
       inc       eax
       mov       r9d,eax
       shl       r9,5
       vmovups   ymm1,[rcx+r9+10]
       vmovups   ymm2,[r10]
       vmulpd    ymm1,ymm0,ymm1
       vmulpd    ymm2,ymm0,ymm2
       vcmplepd  ymm1,ymm1,ymm2
       vpcmpeqd  ymm2,ymm2,ymm2
       vptest    ymm1,ymm2
       setb      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 121
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Double, System.Private.CoreLib]].Area()
       mov       rax,1F7E0400358
       mov       rax,[rax]
       mov       rcx,1F7E0400368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vpermq    ymm1,ymm0,4E
       vsubpd    ymm0,ymm1,ymm0
       vshufpd   ymm1,ymm0,ymm0,5
       vmulpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short M00_L00
       vzeroupper
       ret
; Total bytes of code 78
```

