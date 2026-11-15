## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].Intersects()
       xor       eax,eax
       mov       rcx,1F453001560
       mov       rcx,[rcx]
       mov       rdx,1F453001568
       mov       rdx,[rdx]
       mov       r8,1F4243E3308
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
       jl        short 000000000000338B
       ret
; Total bytes of code 122
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].Contains()
       xor       eax,eax
       mov       rcx,19DA7801560
       mov       rcx,[rcx]
       mov       rdx,19DA7801568
       mov       rdx,[rdx]
       mov       r8,19DA42E31A0
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
       jl        short 000000000000364B
       ret
; Total bytes of code 116
```

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.StressRect`1[[System.Int32, System.Private.CoreLib]].Area()
       mov       rax,1CD08401560
       mov       rax,[rax]
       mov       rcx,1CD08401570
       mov       rcx,[rcx]
       xor       edx,edx
       mov       r8d,1869F
M00_L00:
       vmovups   xmm0,[rax+rdx*4+10]
       vpermilps xmm1,xmm0,4E
       vpsubd    xmm0,xmm1,xmm0
       vpermilps xmm1,xmm0,0F5
       vpmulld   xmm0,xmm1,xmm0
       vmovd     dword ptr [rcx+rdx+10],xmm0
       add       rdx,4
       dec       r8d
       jne       short 00000000000032E2
       ret
; Total bytes of code 77
```

