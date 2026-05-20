## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].IsIntersect()
       xor       eax,eax
       mov       rcx,18392000358
       mov       rcx,[rcx]
       mov       rdx,18392000360
       mov       rdx,[rdx]
       mov       r8,19349168E18
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
       vpmulld   xmm2,xmm2,xmm0
       vpmulld   xmm1,xmm0,xmm1
       vpcmpgtd  k1,xmm2,xmm1
       kortestb  k1,k1
       sete      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 122
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,1D708000358
       mov       rcx,[rcx]
       mov       rdx,1D708000360
       mov       rdx,[rdx]
       mov       r8,1E6BF178E18
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
       vpmulld   xmm1,xmm0,xmm1
       vpmulld   xmm2,xmm0,xmm2
       vpcmpgtd  k1,xmm1,xmm2
       kortestb  k1,k1
       sete      r10b
       mov       [rdx+r8+10],r10b
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 116
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].Area()
       mov       rax,1D706000358
       mov       rax,[rax]
       mov       rcx,1D706000368
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpermilps xmm1,xmm0,4E
       vpsubd    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,0B1
       vpmulld   xmm0,xmm1,xmm0
       vmovd     dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short M00_L00
       ret
; Total bytes of code 77
```

