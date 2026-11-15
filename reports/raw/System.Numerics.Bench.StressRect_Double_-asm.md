## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Double, System.Private.CoreLib]].Intersects()
       xor       eax,eax
       mov       rcx,21A49001560
       mov       rcx,[rcx]
       mov       rdx,21A49001568
       mov       rdx,[rdx]
       mov       r8,21A242E3210
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
       jl        short 00000000000032EB
       vzeroupper
       ret
; Total bytes of code 127
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Double, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,249C2801560
       mov       rcx,[rcx]
       mov       rdx,249C2801568
       mov       rdx,[rdx]
       mov       r8,249A42E3200
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
       jl        short 0000000000002D6B
       vzeroupper
       ret
; Total bytes of code 121
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Double, System.Private.CoreLib]].Area()
       mov       rax,17F64C01560
       mov       rax,[rax]
       mov       rcx,17F64C01570
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       vmovups   ymm0,[rax+rdx*4+10]
       vpermq    ymm1,ymm0,4E
       vsubpd    ymm0,ymm1,ymm0
       vshufpd   ymm1,ymm0,ymm0,0F
       vmulpd    ymm0,ymm1,ymm0
       vmovsd    qword ptr [rcx+rdx+10],xmm0
       add       rdx,8
       dec       r8d
       jne       short 0000000000003602
       vzeroupper
       ret
; Total bytes of code 78
```

