## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Int16, System.Private.CoreLib]].Add()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       short 00000000000033A4
       mov       rbx,rdx
       shl       rbx,5
       vmovups   ymm0,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       short 00000000000033A4
       mov       r11d,r9d
       shl       r11,5
       vpaddw    ymm0,ymm0,[r10+r11+10]
       cmp       edx,[r8+8]
       jae       short 00000000000033A4
       vmovups   [r8+rbx+10],ymm0
       mov       edx,r9d
       cmp       edx,1869F
       jl        short 000000000000334B
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 106
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Int16, System.Private.CoreLib]].Subtract()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       xor       edx,edx
M00_L00:
       mov       r8,rax
       mov       r10,[rcx+8]
       mov       r9,r10
       mov       r11d,[r9+8]
       cmp       edx,r11d
       jae       short 00000000000030E4
       mov       rbx,rdx
       shl       rbx,5
       vmovups   ymm0,[r9+rbx+10]
       lea       r9d,[rdx+1]
       cmp       r9d,r11d
       jae       short 00000000000030E4
       mov       r11d,r9d
       shl       r11,5
       vpsubw    ymm0,ymm0,[r10+r11+10]
       cmp       edx,[r8+8]
       jae       short 00000000000030E4
       vmovups   [r8+rbx+10],ymm0
       mov       edx,r9d
       cmp       edx,1869F
       jl        short 000000000000308B
       vzeroupper
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 106
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Int16, System.Private.CoreLib]].Multiply()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1C8
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       [rsp+210],rcx
       mov       r8,[rcx+8]
       mov       [rsp+20],r8
       mov       r10,r8
       cmp       eax,[r10+8]
       jae       near ptr 000000000000603A
       mov       r9,rax
       shl       r9,5
       mov       [rsp+30],r9
       lea       r10,[r10+r9+10]
       movsx     r11,word ptr [r10]
       movsx     rbx,word ptr [r10+2]
       movsx     rsi,word ptr [r10+4]
       mov       [rsp+0B4],esi
       movsx     rdi,word ptr [r10+6]
       mov       [rsp+0B0],edi
       movsx     rbp,word ptr [r10+8]
       mov       [rsp+0AC],ebp
       movsx     r14,word ptr [r10+0A]
       mov       [rsp+0A8],r14d
       movsx     r15,word ptr [r10+0C]
       mov       [rsp+0A4],r15d
       movsx     r13,word ptr [r10+0E]
       mov       [rsp+0A0],r13d
       movsx     r12,word ptr [r10+10]
       mov       [rsp+9C],r12d
       movsx     rcx,word ptr [r10+12]
       mov       [rsp+98],ecx
       movsx     r9,word ptr [r10+14]
       mov       [rsp+94],r9d
       movsx     r8,word ptr [r10+16]
       mov       [rsp+90],r8d
       movsx     r8,word ptr [r10+18]
       mov       [rsp+8C],r8d
       movsx     r8,word ptr [r10+1A]
       mov       [rsp+88],r8d
       movsx     r8,word ptr [r10+1C]
       mov       [rsp+84],r8d
       movsx     r10,word ptr [r10+1E]
       mov       [rsp+80],r10d
       mov       r10,[rsp+20]
       lea       r8d,[rax+1]
       mov       [rsp+2C],r8d
       cmp       r8d,[r10+8]
       jae       near ptr 000000000000603A
       shl       r8,5
       lea       r8,[r10+r8+10]
       movsx     r10,word ptr [r8]
       mov       [rsp+7C],r10d
       movsx     r9,word ptr [r8+2]
       movsx     rcx,word ptr [r8+4]
       movsx     r12,word ptr [r8+6]
       movsx     r13,word ptr [r8+8]
       movsx     r15,word ptr [r8+0A]
       movsx     r14,word ptr [r8+0C]
       movsx     rbp,word ptr [r8+0E]
       movsx     rdi,word ptr [r8+10]
       movsx     rsi,word ptr [r8+12]
       mov       [rsp+78],esi
       movsx     rsi,word ptr [r8+14]
       mov       [rsp+74],esi
       movsx     rsi,word ptr [r8+16]
       mov       [rsp+70],esi
       movsx     rsi,word ptr [r8+18]
       mov       [rsp+6C],esi
       movsx     rsi,word ptr [r8+1A]
       mov       [rsp+68],esi
       movsx     rsi,word ptr [r8+1C]
       movsx     r8,word ptr [r8+1E]
       imul      r10d,r11d
       movsx     r10,r10w
       mov       [rsp+1C4],r10d
       mov       r10d,r9d
       imul      r10d,r11d
       movsx     r10,r10w
       mov       [rsp+1C0],r10d
       mov       r10d,ecx
       imul      r10d,r11d
       movsx     r10,r10w
       mov       [rsp+1BC],r10d
       mov       r10d,[rsp+1C4]
       mov       [rsp+1B4],r10w
       mov       r10d,[rsp+1C0]
       mov       [rsp+1B0],r10w
       mov       r10d,[rsp+1BC]
       mov       [rsp+1AC],r10w
       imul      r11d,r12d
       movsx     r11,r11w
       mov       [rsp+1A8],r11w
       mov       r11d,r13d
       imul      r11d,ebx
       movsx     r11,r11w
       mov       r10d,r15d
       imul      r10d,ebx
       movsx     r10,r10w
       mov       [rsp+1B8],r10d
       mov       r10d,r14d
       imul      r10d,ebx
       movsx     r10,r10w
       mov       [rsp+1A4],r11w
       mov       r11d,[rsp+1B8]
       mov       [rsp+1A0],r10w
       imul      ebx,ebp
       movsx     rbx,bx
       mov       [rsp+19C],bx
       movsx     rbx,word ptr [rsp+1B4]
       add       ebx,[rsp+1A4]
       movsx     rbx,bx
       movsx     r10,word ptr [rsp+1B0]
       add       r10d,r11d
       movsx     r10,r10w
       movsx     r11,word ptr [rsp+1AC]
       add       r11d,[rsp+1A0]
       movsx     r11,r11w
       mov       [rsp+198],bx
       mov       [rsp+194],r10w
       mov       [rsp+190],r11w
       movsx     r11,word ptr [rsp+1A8]
       movsx     r10,word ptr [rsp+19C]
       add       r10d,r11d
       movsx     r10,r10w
       mov       [rsp+18C],r10w
       mov       r11d,[rsp+0B4]
       mov       r10d,edi
       imul      r10d,r11d
       movsx     r10,r10w
       mov       ebx,[rsp+78]
       imul      ebx,r11d
       movsx     rbx,bx
       mov       r11d,[rsp+74]
       imul      r11d,[rsp+0B4]
       movsx     r11,r11w
       mov       [rsp+188],bx
       mov       [rsp+184],r11w
       mov       r11d,[rsp+70]
       mov       ebx,r11d
       imul      ebx,[rsp+0B4]
       movsx     rbx,bx
       mov       [rsp+180],bx
       movsx     rbx,word ptr [rsp+198]
       add       r10d,ebx
       movsx     r10,r10w
       movsx     rbx,word ptr [rsp+194]
       add       ebx,[rsp+188]
       movsx     rbx,bx
       movsx     r11,word ptr [rsp+190]
       add       r11d,[rsp+184]
       movsx     r11,r11w
       mov       [rsp+17C],r10w
       mov       [rsp+178],bx
       mov       [rsp+174],r11w
       movsx     r11,word ptr [rsp+18C]
       movsx     rbx,word ptr [rsp+180]
       add       r11d,ebx
       movsx     r11,r11w
       mov       [rsp+170],r11w
       mov       ebx,[rsp+6C]
       mov       r11d,[rsp+0B0]
       mov       r10d,ebx
       imul      r10d,r11d
       movsx     r10,r10w
       mov       ebx,[rsp+68]
       imul      ebx,r11d
       movsx     rbx,bx
       imul      r11d,esi
       movsx     r11,r11w
       mov       [rsp+16C],r11w
       mov       r11d,r8d
       imul      r11d,[rsp+0B0]
       movsx     r11,r11w
       mov       [rsp+168],r11w
       movsx     r11,word ptr [rsp+17C]
       add       r10d,r11d
       movsx     r10,r10w
       movsx     r11,word ptr [rsp+178]
       add       r11d,ebx
       movsx     r11,r11w
       movsx     rbx,word ptr [rsp+174]
       add       ebx,[rsp+16C]
       movsx     rbx,bx
       mov       [rsp+164],r11w
       mov       [rsp+160],bx
       movsx     rbx,word ptr [rsp+170]
       movsx     r11,word ptr [rsp+168]
       add       r11d,ebx
       movsx     r11,r11w
       mov       [rsp+64],r10d
       movsx     rbx,word ptr [rsp+164]
       mov       [rsp+60],ebx
       movsx     rbx,word ptr [rsp+160]
       mov       [rsp+5C],ebx
       mov       [rsp+58],r11d
       mov       r11d,[rsp+7C]
       mov       ebx,[rsp+0AC]
       mov       r10d,r11d
       imul      r10d,ebx
       movsx     r10,r10w
       mov       r11d,r9d
       imul      r11d,ebx
       movsx     r11,r11w
       imul      ebx,ecx
       movsx     rbx,bx
       mov       [rsp+15C],r10w
       mov       [rsp+158],r11w
       mov       [rsp+154],bx
       mov       ebx,r12d
       imul      ebx,[rsp+0AC]
       movsx     rbx,bx
       mov       [rsp+150],bx
       mov       ebx,[rsp+0A8]
       mov       r11d,r13d
       imul      r11d,ebx
       movsx     r11,r11w
       mov       r10d,r15d
       imul      r10d,ebx
       movsx     r10,r10w
       imul      ebx,r14d
       movsx     rbx,bx
       mov       [rsp+14C],bx
       mov       ebx,ebp
       imul      ebx,[rsp+0A8]
       movsx     rbx,bx
       mov       [rsp+148],bx
       movsx     rbx,word ptr [rsp+15C]
       add       r11d,ebx
       movsx     r11,r11w
       movsx     rbx,word ptr [rsp+158]
       add       r10d,ebx
       movsx     r10,r10w
       movsx     rbx,word ptr [rsp+154]
       add       ebx,[rsp+14C]
       movsx     rbx,bx
       mov       [rsp+144],r11w
       mov       [rsp+140],r10w
       mov       [rsp+13C],bx
       movsx     rbx,word ptr [rsp+150]
       movsx     r10,word ptr [rsp+148]
       add       r10d,ebx
       movsx     r10,r10w
       mov       [rsp+138],r10w
       mov       ebx,[rsp+0A4]
       mov       r10d,edi
       imul      r10d,ebx
       movsx     r10,r10w
       mov       r11d,[rsp+78]
       imul      r11d,ebx
       movsx     r11,r11w
       mov       ebx,[rsp+74]
       imul      ebx,[rsp+0A4]
       movsx     rbx,bx
       mov       [rsp+134],r11w
       mov       [rsp+130],bx
       mov       ebx,[rsp+70]
       mov       r11d,ebx
       imul      r11d,[rsp+0A4]
       movsx     r11,r11w
       mov       [rsp+12C],r11w
       movsx     r11,word ptr [rsp+144]
       add       r10d,r11d
       movsx     r10,r10w
       movsx     r11,word ptr [rsp+140]
       add       r11d,[rsp+134]
       movsx     r11,r11w
       movsx     rbx,word ptr [rsp+13C]
       add       ebx,[rsp+130]
       movsx     rbx,bx
       mov       [rsp+128],r10w
       mov       [rsp+124],r11w
       mov       [rsp+120],bx
       movsx     rbx,word ptr [rsp+138]
       movsx     r11,word ptr [rsp+12C]
       add       r11d,ebx
       movsx     r11,r11w
       mov       [rsp+11C],r11w
       mov       ebx,[rsp+6C]
       mov       r11d,[rsp+0A0]
       mov       r10d,ebx
       imul      r10d,r11d
       movsx     r10,r10w
       mov       ebx,[rsp+68]
       imul      ebx,r11d
       movsx     rbx,bx
       imul      r11d,esi
       movsx     r11,r11w
       mov       [rsp+118],r11w
       mov       r11d,r8d
       imul      r11d,[rsp+0A0]
       movsx     r11,r11w
       mov       [rsp+114],r11w
       movsx     r11,word ptr [rsp+128]
       add       r10d,r11d
       movsx     r10,r10w
       movsx     r11,word ptr [rsp+124]
       add       r11d,ebx
       movsx     r11,r11w
       movsx     rbx,word ptr [rsp+120]
       add       ebx,[rsp+118]
       movsx     rbx,bx
       mov       [rsp+110],r11w
       mov       [rsp+10C],bx
       movsx     rbx,word ptr [rsp+11C]
       movsx     r11,word ptr [rsp+114]
       add       r11d,ebx
       movsx     r11,r11w
       mov       [rsp+54],r10d
       movsx     rbx,word ptr [rsp+110]
       mov       [rsp+50],ebx
       movsx     rbx,word ptr [rsp+10C]
       mov       [rsp+4C],ebx
       mov       [rsp+48],r11d
       mov       r11d,[rsp+7C]
       mov       ebx,[rsp+9C]
       mov       r10d,r11d
       imul      r10d,ebx
       movsx     r10,r10w
       mov       r11d,r9d
       imul      r11d,ebx
       movsx     r11,r11w
       imul      ebx,ecx
       movsx     rbx,bx
       mov       [rsp+108],r10w
       mov       [rsp+104],r11w
       mov       [rsp+100],bx
       mov       ebx,r12d
       imul      ebx,[rsp+9C]
       movsx     rbx,bx
       mov       [rsp+0FC],bx
       mov       ebx,[rsp+98]
       mov       r11d,r13d
       imul      r11d,ebx
       movsx     r11,r11w
       mov       r10d,r15d
       imul      r10d,ebx
       movsx     r10,r10w
       imul      ebx,r14d
       movsx     rbx,bx
       mov       [rsp+0F8],bx
       mov       ebx,ebp
       imul      ebx,[rsp+98]
       movsx     rbx,bx
       mov       [rsp+0F4],bx
       movsx     rbx,word ptr [rsp+108]
       add       r11d,ebx
       movsx     r11,r11w
       movsx     rbx,word ptr [rsp+104]
       add       r10d,ebx
       movsx     r10,r10w
       movsx     rbx,word ptr [rsp+100]
       add       ebx,[rsp+0F8]
       movsx     rbx,bx
       mov       [rsp+0F0],r11w
       mov       [rsp+0EC],r10w
       mov       [rsp+0E8],bx
       movsx     rbx,word ptr [rsp+0FC]
       movsx     r10,word ptr [rsp+0F4]
       add       r10d,ebx
       movsx     r10,r10w
       mov       [rsp+0E4],r10w
       mov       ebx,[rsp+94]
       mov       r10d,edi
       imul      r10d,ebx
       movsx     r10,r10w
       mov       r11d,[rsp+78]
       imul      r11d,ebx
       movsx     r11,r11w
       mov       ebx,[rsp+74]
       imul      ebx,[rsp+94]
       movsx     rbx,bx
       mov       [rsp+0E0],r11w
       mov       [rsp+0DC],bx
       mov       ebx,[rsp+70]
       mov       r11d,ebx
       imul      r11d,[rsp+94]
       movsx     r11,r11w
       mov       [rsp+0D8],r11w
       movsx     r11,word ptr [rsp+0F0]
       add       r10d,r11d
       movsx     r10,r10w
       movsx     r11,word ptr [rsp+0EC]
       add       r11d,[rsp+0E0]
       movsx     r11,r11w
       movsx     rbx,word ptr [rsp+0E8]
       add       ebx,[rsp+0DC]
       movsx     rbx,bx
       mov       [rsp+0D4],r10w
       mov       [rsp+0D0],r11w
       mov       [rsp+0CC],bx
       movsx     rbx,word ptr [rsp+0E4]
       movsx     r11,word ptr [rsp+0D8]
       add       r11d,ebx
       movsx     r11,r11w
       mov       [rsp+0C8],r11w
       mov       ebx,[rsp+6C]
       mov       r11d,[rsp+90]
       mov       r10d,ebx
       imul      r10d,r11d
       movsx     r10,r10w
       mov       ebx,[rsp+68]
       imul      ebx,r11d
       movsx     rbx,bx
       imul      r11d,esi
       movsx     r11,r11w
       mov       [rsp+0C4],r11w
       mov       r11d,r8d
       imul      r11d,[rsp+90]
       movsx     r11,r11w
       mov       [rsp+0C0],r11w
       movsx     r11,word ptr [rsp+0D4]
       add       r10d,r11d
       movsx     r10,r10w
       movsx     r11,word ptr [rsp+0D0]
       add       r11d,ebx
       movsx     r11,r11w
       movsx     rbx,word ptr [rsp+0CC]
       add       ebx,[rsp+0C4]
       movsx     rbx,bx
       mov       [rsp+0BC],r11w
       mov       [rsp+0B8],bx
       movsx     rbx,word ptr [rsp+0C8]
       movsx     r11,word ptr [rsp+0C0]
       add       r11d,ebx
       movsx     r11,r11w
       movsx     rbx,word ptr [rsp+0BC]
       mov       [rsp+44],ebx
       movsx     rbx,word ptr [rsp+0B8]
       mov       [rsp+40],ebx
       mov       [rsp+3C],r11d
       mov       r11d,[rsp+7C]
       mov       ebx,[rsp+8C]
       imul      r11d,ebx
       movsx     r11,r11w
       imul      r9d,ebx
       movsx     r9,r9w
       imul      ecx,ebx
       movsx     rcx,cx
       imul      ebx,r12d
       movsx     rbx,bx
       mov       r12d,[rsp+88]
       imul      r13d,r12d
       movsx     r13,r13w
       imul      r15d,r12d
       movsx     r15,r15w
       imul      r14d,r12d
       movsx     r14,r14w
       imul      ebp,r12d
       movsx     rbp,bp
       add       r11d,r13d
       movsx     r11,r11w
       add       r9d,r15d
       movsx     r9,r9w
       add       ecx,r14d
       movsx     rcx,cx
       add       ebx,ebp
       movsx     rbx,bx
       mov       ebp,[rsp+84]
       imul      edi,ebp
       movsx     rdi,di
       mov       r14d,[rsp+78]
       imul      r14d,ebp
       movsx     r14,r14w
       mov       r15d,[rsp+74]
       imul      r15d,ebp
       movsx     r15,r15w
       mov       r13d,[rsp+70]
       imul      ebp,r13d
       movsx     rbp,bp
       add       r11d,edi
       movsx     r11,r11w
       add       r9d,r14d
       movsx     r9,r9w
       add       ecx,r15d
       movsx     rcx,cx
       add       ebx,ebp
       movsx     rbx,bx
       mov       edi,[rsp+6C]
       mov       ebp,[rsp+80]
       imul      edi,ebp
       movsx     rdi,di
       mov       r14d,[rsp+68]
       imul      r14d,ebp
       movsx     r14,r14w
       imul      esi,ebp
       movsx     rsi,si
       imul      r8d,ebp
       movsx     r8,r8w
       add       r11d,edi
       movsx     r11,r11w
       add       r9d,r14d
       movsx     r9,r9w
       add       ecx,esi
       movsx     rcx,cx
       add       r8d,ebx
       movsx     r8,r8w
       cmp       eax,[rdx+8]
       jae       near ptr 000000000000603A
       mov       rax,[rsp+30]
       lea       rax,[rdx+rax+10]
       mov       edx,[rsp+64]
       mov       [rax],dx
       mov       ebx,[rsp+60]
       mov       [rax+2],bx
       mov       ebx,[rsp+5C]
       mov       [rax+4],bx
       mov       edx,[rsp+58]
       mov       [rax+6],dx
       mov       edx,[rsp+54]
       mov       [rax+8],dx
       mov       ebx,[rsp+50]
       mov       [rax+0A],bx
       mov       ebx,[rsp+4C]
       mov       [rax+0C],bx
       mov       edx,[rsp+48]
       mov       [rax+0E],dx
       mov       [rax+10],r10w
       mov       ebx,[rsp+44]
       mov       [rax+12],bx
       mov       ebx,[rsp+40]
       mov       [rax+14],bx
       mov       edx,[rsp+3C]
       mov       [rax+16],dx
       mov       [rax+18],r11w
       mov       [rax+1A],r9w
       mov       [rax+1C],cx
       mov       [rax+1E],r8w
       mov       eax,[rsp+2C]
       cmp       eax,1869F
       mov       rcx,[rsp+210]
       jl        near ptr 00000000000054D5
       add       rsp,1C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 2944
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

