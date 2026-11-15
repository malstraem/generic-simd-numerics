## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMatrix4X4`1[[System.Byte, System.Private.CoreLib]].Add()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       cmp       eax,[r10+8]
       jae       near ptr 0000000000003474
       mov       r9,rax
       shl       r9,4
       lea       r10,[r10+r9+10]
       movzx     r11d,byte ptr [r10]
       movzx     ebx,byte ptr [r10+1]
       movzx     esi,byte ptr [r10+2]
       movzx     edi,byte ptr [r10+3]
       movzx     ebp,byte ptr [r10+4]
       mov       [rsp+78],ebp
       movzx     r14d,byte ptr [r10+5]
       mov       [rsp+74],r14d
       movzx     r15d,byte ptr [r10+6]
       mov       [rsp+70],r15d
       movzx     r13d,byte ptr [r10+7]
       mov       [rsp+6C],r13d
       movzx     r12d,byte ptr [r10+8]
       mov       [rsp+68],r12d
       movzx     r12d,byte ptr [r10+9]
       mov       [rsp+64],r12d
       movzx     r12d,byte ptr [r10+0A]
       mov       [rsp+60],r12d
       movzx     r12d,byte ptr [r10+0B]
       mov       [rsp+5C],r12d
       movzx     r12d,byte ptr [r10+0C]
       mov       [rsp+58],r12d
       movzx     r12d,byte ptr [r10+0D]
       mov       [rsp+54],r12d
       movzx     r12d,byte ptr [r10+0E]
       mov       [rsp+50],r12d
       movzx     r10d,byte ptr [r10+0F]
       mov       [rsp+4C],r10d
       lea       r10d,[rax+1]
       cmp       r10d,[r8+8]
       jae       near ptr 0000000000003474
       mov       r12d,r10d
       shl       r12,4
       lea       r8,[r8+r12+10]
       movzx     r12d,byte ptr [r8]
       movzx     r13d,byte ptr [r8+1]
       movzx     r15d,byte ptr [r8+2]
       movzx     r14d,byte ptr [r8+3]
       movzx     ebp,byte ptr [r8+4]
       mov       [rsp+48],ebp
       movzx     ebp,byte ptr [r8+5]
       mov       [rsp+44],ebp
       movzx     ebp,byte ptr [r8+6]
       mov       [rsp+40],ebp
       movzx     ebp,byte ptr [r8+7]
       mov       [rsp+3C],ebp
       movzx     ebp,byte ptr [r8+8]
       mov       [rsp+38],ebp
       movzx     ebp,byte ptr [r8+9]
       mov       [rsp+34],ebp
       movzx     ebp,byte ptr [r8+0A]
       mov       [rsp+30],ebp
       movzx     ebp,byte ptr [r8+0B]
       mov       [rsp+2C],ebp
       movzx     ebp,byte ptr [r8+0C]
       mov       [rsp+28],ebp
       movzx     ebp,byte ptr [r8+0D]
       mov       [rsp+24],ebp
       movzx     ebp,byte ptr [r8+0E]
       movzx     r8d,byte ptr [r8+0F]
       add       r11d,r12d
       movzx     r11d,r11b
       add       ebx,r13d
       movzx     ebx,bl
       add       esi,r15d
       movzx     esi,sil
       add       edi,r14d
       movzx     edi,dil
       mov       [rsp+94],edi
       mov       r14d,[rsp+78]
       mov       r15d,[rsp+48]
       add       r14d,r15d
       movzx     r14d,r14b
       mov       r15d,[rsp+74]
       mov       r13d,[rsp+44]
       add       r15d,r13d
       movzx     r15d,r15b
       mov       r13d,[rsp+70]
       mov       r12d,[rsp+40]
       add       r13d,r12d
       movzx     r13d,r13b
       mov       r12d,[rsp+6C]
       mov       edi,[rsp+3C]
       add       edi,r12d
       movzx     edi,dil
       mov       [rsp+90],edi
       mov       [rsp+8C],r14d
       mov       [rsp+88],r15d
       mov       [rsp+84],r13d
       mov       r12d,[rsp+68]
       mov       edi,[rsp+38]
       add       edi,r12d
       movzx     edi,dil
       mov       r12d,[rsp+64]
       mov       r13d,[rsp+34]
       add       r13d,r12d
       movzx     r13d,r13b
       mov       r12d,[rsp+60]
       mov       r15d,[rsp+30]
       add       r15d,r12d
       movzx     r15d,r15b
       mov       r12d,[rsp+5C]
       mov       r14d,[rsp+2C]
       add       r14d,r12d
       movzx     r14d,r14b
       mov       [rsp+80],r14d
       mov       [rsp+7C],r15d
       mov       r12d,[rsp+58]
       mov       r14d,[rsp+28]
       add       r14d,r12d
       movzx     r14d,r14b
       mov       r12d,[rsp+54]
       mov       r15d,[rsp+24]
       add       r15d,r12d
       movzx     r15d,r15b
       mov       r12d,[rsp+50]
       add       ebp,r12d
       movzx     ebp,bpl
       mov       r12d,[rsp+4C]
       add       r8d,r12d
       movzx     r8d,r8b
       cmp       eax,[rdx+8]
       jae       near ptr 0000000000003474
       lea       rax,[rdx+r9+10]
       mov       [rax],r11b
       mov       [rax+1],bl
       mov       [rax+2],sil
       mov       edx,[rsp+94]
       mov       [rax+3],dl
       mov       edx,[rsp+8C]
       mov       [rax+4],dl
       mov       edx,[rsp+88]
       mov       [rax+5],dl
       mov       edx,[rsp+84]
       mov       [rax+6],dl
       mov       edx,[rsp+90]
       mov       [rax+7],dl
       mov       [rax+8],dil
       mov       [rax+9],r13b
       mov       edx,[rsp+7C]
       mov       [rax+0A],dl
       mov       edx,[rsp+80]
       mov       [rax+0B],dl
       mov       [rax+0C],r14b
       mov       [rax+0D],r15b
       mov       [rax+0E],bpl
       mov       [rax+0F],r8b
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000003195
       add       rsp,98
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
; Total bytes of code 762
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMatrix4X4`1[[System.Byte, System.Private.CoreLib]].Subtract()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       mov       r10,r8
       cmp       eax,[r10+8]
       jae       near ptr 0000000000003634
       mov       r9,rax
       shl       r9,4
       lea       r10,[r10+r9+10]
       movzx     r11d,byte ptr [r10]
       movzx     ebx,byte ptr [r10+1]
       movzx     esi,byte ptr [r10+2]
       movzx     edi,byte ptr [r10+3]
       movzx     ebp,byte ptr [r10+4]
       mov       [rsp+78],ebp
       movzx     r14d,byte ptr [r10+5]
       mov       [rsp+74],r14d
       movzx     r15d,byte ptr [r10+6]
       mov       [rsp+70],r15d
       movzx     r13d,byte ptr [r10+7]
       mov       [rsp+6C],r13d
       movzx     r12d,byte ptr [r10+8]
       mov       [rsp+68],r12d
       movzx     r12d,byte ptr [r10+9]
       mov       [rsp+64],r12d
       movzx     r12d,byte ptr [r10+0A]
       mov       [rsp+60],r12d
       movzx     r12d,byte ptr [r10+0B]
       mov       [rsp+5C],r12d
       movzx     r12d,byte ptr [r10+0C]
       mov       [rsp+58],r12d
       movzx     r12d,byte ptr [r10+0D]
       mov       [rsp+54],r12d
       movzx     r12d,byte ptr [r10+0E]
       mov       [rsp+50],r12d
       movzx     r10d,byte ptr [r10+0F]
       mov       [rsp+4C],r10d
       lea       r10d,[rax+1]
       cmp       r10d,[r8+8]
       jae       near ptr 0000000000003634
       mov       r12d,r10d
       shl       r12,4
       lea       r8,[r8+r12+10]
       movzx     r12d,byte ptr [r8]
       movzx     r13d,byte ptr [r8+1]
       movzx     r15d,byte ptr [r8+2]
       movzx     r14d,byte ptr [r8+3]
       movzx     ebp,byte ptr [r8+4]
       mov       [rsp+48],ebp
       movzx     ebp,byte ptr [r8+5]
       mov       [rsp+44],ebp
       movzx     ebp,byte ptr [r8+6]
       mov       [rsp+40],ebp
       movzx     ebp,byte ptr [r8+7]
       mov       [rsp+3C],ebp
       movzx     ebp,byte ptr [r8+8]
       mov       [rsp+38],ebp
       movzx     ebp,byte ptr [r8+9]
       mov       [rsp+34],ebp
       movzx     ebp,byte ptr [r8+0A]
       mov       [rsp+30],ebp
       movzx     ebp,byte ptr [r8+0B]
       mov       [rsp+2C],ebp
       movzx     ebp,byte ptr [r8+0C]
       mov       [rsp+28],ebp
       movzx     ebp,byte ptr [r8+0D]
       mov       [rsp+24],ebp
       movzx     ebp,byte ptr [r8+0E]
       movzx     r8d,byte ptr [r8+0F]
       sub       r11d,r12d
       movzx     r11d,r11b
       sub       ebx,r13d
       movzx     ebx,bl
       sub       esi,r15d
       movzx     esi,sil
       sub       edi,r14d
       movzx     edi,dil
       mov       [rsp+94],edi
       mov       r14d,[rsp+78]
       mov       r15d,[rsp+48]
       sub       r14d,r15d
       movzx     r14d,r14b
       mov       r15d,[rsp+74]
       mov       r13d,[rsp+44]
       sub       r15d,r13d
       movzx     r15d,r15b
       mov       r13d,[rsp+70]
       mov       r12d,[rsp+40]
       sub       r13d,r12d
       movzx     r13d,r13b
       mov       r12d,[rsp+6C]
       mov       edi,[rsp+3C]
       sub       r12d,edi
       movzx     edi,r12b
       mov       [rsp+90],edi
       mov       [rsp+8C],r14d
       mov       [rsp+88],r15d
       mov       [rsp+84],r13d
       mov       r12d,[rsp+68]
       mov       edi,[rsp+38]
       sub       r12d,edi
       movzx     edi,r12b
       mov       r12d,[rsp+64]
       mov       r13d,[rsp+34]
       sub       r12d,r13d
       movzx     r13d,r12b
       mov       r12d,[rsp+60]
       mov       r15d,[rsp+30]
       sub       r12d,r15d
       movzx     r15d,r12b
       mov       r12d,[rsp+5C]
       mov       r14d,[rsp+2C]
       sub       r12d,r14d
       movzx     r14d,r12b
       mov       [rsp+80],r14d
       mov       [rsp+7C],r15d
       mov       r12d,[rsp+58]
       mov       r14d,[rsp+28]
       sub       r12d,r14d
       movzx     r14d,r12b
       mov       r12d,[rsp+54]
       mov       r15d,[rsp+24]
       sub       r12d,r15d
       movzx     r15d,r12b
       mov       r12d,[rsp+50]
       sub       r12d,ebp
       movzx     ebp,r12b
       mov       r12d,[rsp+4C]
       sub       r12d,r8d
       movzx     r8d,r12b
       cmp       eax,[rdx+8]
       jae       near ptr 0000000000003634
       lea       rax,[rdx+r9+10]
       mov       [rax],r11b
       mov       [rax+1],bl
       mov       [rax+2],sil
       mov       edx,[rsp+94]
       mov       [rax+3],dl
       mov       edx,[rsp+8C]
       mov       [rax+4],dl
       mov       edx,[rsp+88]
       mov       [rax+5],dl
       mov       edx,[rsp+84]
       mov       [rax+6],dl
       mov       edx,[rsp+90]
       mov       [rax+7],dl
       mov       [rax+8],dil
       mov       [rax+9],r13b
       mov       edx,[rsp+7C]
       mov       [rax+0A],dl
       mov       edx,[rsp+80]
       mov       [rax+0B],dl
       mov       [rax+0C],r14b
       mov       [rax+0D],r15b
       mov       [rax+0E],bpl
       mov       [rax+0F],r8b
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000003355
       add       rsp,98
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
; Total bytes of code 762
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMatrix4X4`1[[System.Byte, System.Private.CoreLib]].Multiply()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,208
       mov       rbx,rcx
       xor       esi,esi
M00_L00:
       mov       rdi,[rbx+10]
       mov       [rsp+250],rbx
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       cmp       esi,[rdx+8]
       jae       near ptr 000000000000566D
       mov       r8,rsi
       shl       r8,4
       lea       rdx,[rdx+r8+10]
       movzx     r8d,byte ptr [rdx]
       movzx     r9d,byte ptr [rdx+1]
       movzx     eax,byte ptr [rdx+2]
       mov       [rsp+94],eax
       movzx     r10d,byte ptr [rdx+3]
       mov       [rsp+90],r10d
       movzx     r11d,byte ptr [rdx+4]
       mov       [rsp+8C],r11d
       movzx     ebp,byte ptr [rdx+5]
       mov       [rsp+88],ebp
       movzx     r14d,byte ptr [rdx+6]
       mov       [rsp+84],r14d
       movzx     r15d,byte ptr [rdx+7]
       mov       [rsp+80],r15d
       movzx     r13d,byte ptr [rdx+8]
       mov       [rsp+7C],r13d
       movzx     r12d,byte ptr [rdx+9]
       mov       [rsp+78],r12d
       movzx     r12d,byte ptr [rdx+0A]
       mov       [rsp+74],r12d
       movzx     r12d,byte ptr [rdx+0B]
       mov       [rsp+70],r12d
       movzx     r13d,byte ptr [rdx+0C]
       mov       [rsp+6C],r13d
       movzx     r13d,byte ptr [rdx+0D]
       mov       [rsp+68],r13d
       movzx     r13d,byte ptr [rdx+0E]
       mov       [rsp+64],r13d
       movzx     edx,byte ptr [rdx+0F]
       mov       [rsp+60],edx
       lea       r13d,[rsi+1]
       cmp       r13d,[rcx+8]
       jae       near ptr 000000000000566D
       lea       r13d,[rsi+1]
       shl       r13,4
       lea       rcx,[rcx+r13+10]
       movzx     r13d,byte ptr [rcx]
       mov       [rsp+5C],r13d
       movzx     r15d,byte ptr [rcx+1]
       movzx     edx,byte ptr [rcx+2]
       mov       [rsp+58],edx
       movzx     ebx,byte ptr [rcx+3]
       movzx     r12d,byte ptr [rcx+4]
       movzx     r14d,byte ptr [rcx+5]
       movzx     ebp,byte ptr [rcx+6]
       movzx     r11d,byte ptr [rcx+7]
       mov       [rsp+54],r11d
       movzx     r10d,byte ptr [rcx+8]
       mov       [rsp+50],r10d
       movzx     eax,byte ptr [rcx+9]
       mov       [rsp+4C],eax
       movzx     eax,byte ptr [rcx+0A]
       mov       [rsp+48],eax
       movzx     eax,byte ptr [rcx+0B]
       mov       [rsp+44],eax
       movzx     eax,byte ptr [rcx+0C]
       mov       [rsp+40],eax
       movzx     eax,byte ptr [rcx+0D]
       mov       [rsp+3C],eax
       movzx     eax,byte ptr [rcx+0E]
       mov       [rsp+38],eax
       movzx     ecx,byte ptr [rcx+0F]
       mov       [rsp+34],ecx
       imul      r13d,r8d
       movzx     r13d,r13b
       mov       [rsp+174],r13d
       mov       r13d,r15d
       imul      r13d,r8d
       movzx     r13d,r13b
       mov       [rsp+170],r13d
       mov       r13d,edx
       imul      r13d,r8d
       movzx     r13d,r13b
       imul      r8d,ebx
       movzx     r8d,r8b
       mov       [rsp+16C],r8d
       mov       r8d,[rsp+174]
       mov       [rsp+168],r8d
       mov       r8d,[rsp+170]
       mov       [rsp+164],r8d
       mov       [rsp+160],r13d
       mov       r13d,r12d
       imul      r13d,r9d
       movzx     r13d,r13b
       mov       r8d,r14d
       imul      r8d,r9d
       movzx     r8d,r8b
       mov       [rsp+15C],r8d
       mov       r8d,ebp
       imul      r8d,r9d
       movzx     r8d,r8b
       imul      r9d,r11d
       movzx     r9d,r9b
       mov       [rsp+158],r9d
       mov       r9d,[rsp+15C]
       mov       [rsp+154],r8d
       mov       r8d,[rsp+168]
       add       r8d,r13d
       movzx     r8d,r8b
       mov       r13d,[rsp+164]
       add       r9d,r13d
       movzx     r9d,r9b
       mov       [rsp+150],r9d
       mov       r13d,[rsp+160]
       mov       r9d,[rsp+154]
       add       r9d,r13d
       movzx     r9d,r9b
       mov       [rsp+14C],r9d
       mov       r13d,[rsp+16C]
       mov       r9d,[rsp+158]
       add       r9d,r13d
       movzx     r9d,r9b
       mov       [rsp+148],r9d
       mov       [rsp+144],r8d
       mov       r13d,[rsp+150]
       mov       [rsp+140],r13d
       mov       r9d,[rsp+14C]
       mov       [rsp+13C],r9d
       mov       r9d,[rsp+94]
       mov       r13d,r10d
       imul      r13d,r9d
       movzx     r13d,r13b
       mov       r8d,[rsp+4C]
       imul      r8d,r9d
       movzx     r8d,r8b
       mov       r9d,[rsp+48]
       imul      r9d,[rsp+94]
       movzx     r9d,r9b
       mov       [rsp+138],r9d
       mov       r9d,[rsp+44]
       imul      r9d,[rsp+94]
       movzx     r9d,r9b
       mov       [rsp+134],r9d
       mov       r9d,[rsp+138]
       mov       [rsp+130],r9d
       mov       r9d,[rsp+144]
       add       r9d,r13d
       movzx     r9d,r9b
       mov       r13d,[rsp+140]
       add       r8d,r13d
       movzx     r8d,r8b
       mov       [rsp+12C],r8d
       mov       r13d,[rsp+13C]
       mov       r8d,[rsp+130]
       add       r8d,r13d
       movzx     r8d,r8b
       mov       [rsp+128],r8d
       mov       r13d,[rsp+148]
       mov       r8d,[rsp+134]
       add       r8d,r13d
       movzx     r8d,r8b
       mov       [rsp+124],r8d
       mov       [rsp+120],r9d
       mov       r13d,[rsp+12C]
       mov       [rsp+11C],r13d
       mov       r8d,[rsp+128]
       mov       [rsp+118],r8d
       mov       r8d,[rsp+40]
       mov       r13d,[rsp+90]
       mov       r9d,r8d
       imul      r9d,r13d
       movzx     r9d,r9b
       mov       r8d,[rsp+3C]
       imul      r8d,r13d
       movzx     r8d,r8b
       imul      r13d,eax
       movzx     r13d,r13b
       mov       [rsp+114],r13d
       mov       r13d,ecx
       imul      r13d,[rsp+90]
       movzx     r13d,r13b
       mov       [rsp+110],r13d
       mov       r13d,[rsp+114]
       mov       [rsp+10C],r13d
       mov       r13d,[rsp+120]
       add       r9d,r13d
       movzx     r13d,r9b
       mov       r9d,[rsp+11C]
       add       r8d,r9d
       movzx     r9d,r8b
       mov       [rsp+108],r9d
       mov       r8d,[rsp+118]
       mov       r9d,[rsp+10C]
       add       r8d,r9d
       movzx     r9d,r8b
       mov       [rsp+104],r9d
       mov       r8d,[rsp+124]
       mov       r9d,[rsp+110]
       add       r8d,r9d
       movzx     r9d,r8b
       mov       [rsp+100],r9d
       mov       [rsp+0FC],r13d
       mov       r8d,[rsp+108]
       mov       [rsp+0F8],r8d
       mov       r13d,[rsp+104]
       mov       [rsp+0F4],r13d
       mov       r13d,[rsp+5C]
       mov       r9d,[rsp+8C]
       mov       r8d,r13d
       imul      r8d,r9d
       movzx     r8d,r8b
       mov       r13d,r15d
       imul      r13d,r9d
       movzx     r13d,r13b
       imul      r9d,edx
       movzx     r9d,r9b
       mov       [rsp+0F0],r9d
       mov       r9d,ebx
       imul      r9d,[rsp+8C]
       movzx     r9d,r9b
       mov       [rsp+0EC],r9d
       mov       [rsp+0E8],r8d
       mov       [rsp+0E4],r13d
       mov       r9d,[rsp+0F0]
       mov       [rsp+0E0],r9d
       mov       r9d,[rsp+88]
       mov       r13d,r12d
       imul      r13d,r9d
       movzx     r13d,r13b
       mov       r8d,r14d
       imul      r8d,r9d
       movzx     r8d,r8b
       imul      r9d,ebp
       movzx     r9d,r9b
       mov       [rsp+0DC],r9d
       mov       r9d,r11d
       imul      r9d,[rsp+88]
       movzx     r9d,r9b
       mov       [rsp+0D8],r9d
       mov       r9d,[rsp+0DC]
       mov       [rsp+0D4],r9d
       mov       r9d,[rsp+0E8]
       add       r9d,r13d
       movzx     r9d,r9b
       mov       r13d,[rsp+0E4]
       add       r8d,r13d
       movzx     r8d,r8b
       mov       [rsp+0D0],r8d
       mov       r13d,[rsp+0E0]
       mov       r8d,[rsp+0D4]
       add       r8d,r13d
       movzx     r8d,r8b
       mov       [rsp+0CC],r8d
       mov       r13d,[rsp+0EC]
       mov       r8d,[rsp+0D8]
       add       r8d,r13d
       movzx     r8d,r8b
       xor       r13d,r13d
       mov       [rsp+0C0],r13d
       mov       [rsp+20],r8d
       lea       rcx,[rsp+0C0]
       mov       edx,r9d
       mov       r8d,[rsp+0D0]
       mov       r9d,[rsp+0CC]
       call      qword ptr [7BA0]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte, Byte, Byte, Byte)
       mov       ecx,[rsp+0C0]
       mov       [rsp+200],ecx
       mov       ecx,[rsp+50]
       mov       edx,[rsp+84]
       call      qword ptr [4708]; Silk.NET.Maths.Scalar.Multiply[[System.Byte, System.Private.CoreLib]](Byte, Byte)
       mov       r13d,eax
       mov       ecx,[rsp+4C]
       mov       edx,[rsp+84]
       call      qword ptr [4708]; Silk.NET.Maths.Scalar.Multiply[[System.Byte, System.Private.CoreLib]](Byte, Byte)
       mov       [rsp+0BC],eax
       mov       ecx,[rsp+48]
       mov       edx,[rsp+84]
       call      qword ptr [4708]; Silk.NET.Maths.Scalar.Multiply[[System.Byte, System.Private.CoreLib]](Byte, Byte)
       mov       [rsp+0B8],eax
       xor       ecx,ecx
       mov       [rsp+0B0],ecx
       mov       ecx,[rsp+44]
       mov       edx,[rsp+84]
       call      qword ptr [4708]; Silk.NET.Maths.Scalar.Multiply[[System.Byte, System.Private.CoreLib]](Byte, Byte)
       mov       [rsp+20],eax
       lea       rcx,[rsp+0B0]
       mov       edx,r13d
       mov       r8d,[rsp+0BC]
       mov       r9d,[rsp+0B8]
       call      qword ptr [7BA0]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte, Byte, Byte, Byte)
       mov       ecx,[rsp+200]
       mov       edx,[rsp+0B0]
       call      qword ptr [4588]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       mov       [rsp+1F8],eax
       mov       r13d,[rsp+3C]
       mov       ecx,r13d
       shl       ecx,8
       mov       eax,[rsp+40]
       or        ecx,eax
       mov       r8d,[rsp+38]
       mov       edx,r8d
       shl       edx,10
       or        ecx,edx
       mov       r10d,[rsp+34]
       mov       edx,r10d
       shl       edx,18
       or        ecx,edx
       mov       edx,[rsp+80]
       call      qword ptr [7F78]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Byte>, Byte)
       mov       [rsp+1F0],eax
       mov       ecx,[rsp+1F8]
       mov       edx,[rsp+1F0]
       call      qword ptr [4588]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       mov       [rsp+1E8],eax
       mov       ecx,r15d
       shl       ecx,8
       mov       eax,[rsp+5C]
       or        ecx,eax
       mov       r8d,[rsp+58]
       mov       edx,r8d
       shl       edx,10
       or        ecx,edx
       mov       edx,ebx
       shl       edx,18
       or        ecx,edx
       mov       edx,[rsp+7C]
       call      qword ptr [7F78]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Byte>, Byte)
       mov       [rsp+1E0],eax
       mov       ecx,r14d
       shl       ecx,8
       or        ecx,r12d
       mov       edx,ebp
       shl       edx,10
       or        ecx,edx
       mov       eax,[rsp+54]
       mov       edx,eax
       shl       edx,18
       or        ecx,edx
       mov       edx,[rsp+78]
       call      qword ptr [7F78]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Byte>, Byte)
       mov       [rsp+1D8],eax
       mov       ecx,[rsp+1E0]
       mov       edx,[rsp+1D8]
       call      qword ptr [4588]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       mov       [rsp+1D0],eax
       mov       ecx,[rsp+4C]
       mov       edx,ecx
       shl       edx,8
       mov       eax,[rsp+50]
       or        edx,eax
       mov       r8d,[rsp+48]
       mov       r10d,r8d
       shl       r10d,10
       or        r10d,edx
       mov       r9d,[rsp+44]
       mov       edx,r9d
       shl       edx,18
       mov       ecx,r10d
       or        ecx,edx
       mov       edx,[rsp+74]
       call      qword ptr [7F78]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Byte>, Byte)
       mov       [rsp+1C8],eax
       mov       ecx,[rsp+1D0]
       mov       edx,[rsp+1C8]
       call      qword ptr [4588]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       mov       [rsp+1C0],eax
       mov       ecx,[rsp+40]
       mov       edx,[rsp+70]
       call      qword ptr [4708]; Silk.NET.Maths.Scalar.Multiply[[System.Byte, System.Private.CoreLib]](Byte, Byte)
       mov       [rsp+0AC],eax
       mov       ecx,r13d
       mov       edx,[rsp+70]
       call      qword ptr [4708]; Silk.NET.Maths.Scalar.Multiply[[System.Byte, System.Private.CoreLib]](Byte, Byte)
       mov       [rsp+0A8],eax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+70]
       call      qword ptr [4708]; Silk.NET.Maths.Scalar.Multiply[[System.Byte, System.Private.CoreLib]](Byte, Byte)
       mov       [rsp+0A4],eax
       xor       ecx,ecx
       mov       [rsp+98],ecx
       mov       ecx,[rsp+34]
       mov       edx,[rsp+70]
       call      qword ptr [4708]; Silk.NET.Maths.Scalar.Multiply[[System.Byte, System.Private.CoreLib]](Byte, Byte)
       mov       [rsp+20],eax
       lea       rcx,[rsp+98]
       mov       edx,[rsp+0AC]
       mov       r8d,[rsp+0A8]
       mov       r9d,[rsp+0A4]
       call      qword ptr [7BA0]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte, Byte, Byte, Byte)
       mov       ecx,[rsp+1C0]
       mov       edx,[rsp+98]
       call      qword ptr [4588]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       mov       [rsp+1B8],eax
       shl       r15d,8
       mov       ecx,[rsp+5C]
       or        ecx,r15d
       mov       r15d,[rsp+58]
       shl       r15d,10
       or        ecx,r15d
       shl       ebx,18
       or        ecx,ebx
       mov       edx,[rsp+6C]
       call      qword ptr [7F78]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Byte>, Byte)
       mov       [rsp+1B0],eax
       shl       r14d,8
       or        r14d,r12d
       shl       ebp,10
       mov       ecx,r14d
       or        ecx,ebp
       mov       ebx,[rsp+54]
       shl       ebx,18
       or        ecx,ebx
       mov       edx,[rsp+68]
       call      qword ptr [7F78]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Byte>, Byte)
       mov       [rsp+1A8],eax
       mov       ecx,[rsp+1B0]
       mov       edx,[rsp+1A8]
       call      qword ptr [4588]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       mov       [rsp+1A0],eax
       mov       ebx,[rsp+4C]
       shl       ebx,8
       mov       ebp,[rsp+50]
       or        ebx,ebp
       mov       ebp,[rsp+48]
       shl       ebp,10
       mov       ecx,ebx
       or        ecx,ebp
       mov       ebx,[rsp+44]
       shl       ebx,18
       or        ecx,ebx
       mov       edx,[rsp+64]
       call      qword ptr [7F78]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Byte>, Byte)
       mov       [rsp+198],eax
       mov       ecx,[rsp+1A0]
       mov       edx,[rsp+198]
       call      qword ptr [4588]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       mov       [rsp+190],eax
       shl       r13d,8
       mov       ebx,[rsp+40]
       or        ebx,r13d
       mov       ebp,[rsp+38]
       shl       ebp,10
       mov       ecx,ebx
       or        ecx,ebp
       mov       ebx,[rsp+34]
       shl       ebx,18
       or        ecx,ebx
       mov       edx,[rsp+60]
       call      qword ptr [7F78]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Byte>, Byte)
       mov       [rsp+188],eax
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+178],xmm0
       mov       ecx,[rsp+190]
       mov       edx,[rsp+188]
       call      qword ptr [4588]; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       mov       [rsp+20],eax
       mov       ebx,[rsp+0F8]
       shl       ebx,8
       mov       r13d,[rsp+0FC]
       or        ebx,r13d
       mov       r13d,[rsp+0F4]
       shl       r13d,10
       mov       edx,ebx
       or        edx,r13d
       mov       ebx,[rsp+100]
       shl       ebx,18
       or        edx,ebx
       lea       rcx,[rsp+178]
       mov       r8d,[rsp+1E8]
       mov       r9d,[rsp+1B8]
       call      qword ptr [46F0]; Silk.NET.Maths.Matrix4X4`1[[System.Byte, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       cmp       esi,[rdi+8]
       jae       short 000000000000566D
       mov       rax,rsi
       shl       rax,4
       vmovups   xmm0,[rsp+178]
       vmovups   [rdi+rax+10],xmm0
       inc       esi
       cmp       esi,1869F
       mov       rbx,[rsp+250]
       jl        near ptr 0000000000004C98
       add       rsp,208
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
; Total bytes of code 2547
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte, Byte, Byte, Byte)
       movzx     eax,dl
       movzx     edx,r8b
       movzx     r8d,r9b
       movzx     r10d,byte ptr [rsp+28]
       mov       [rcx],al
       mov       [rcx+1],dl
       mov       [rcx+2],r8b
       mov       [rcx+3],r10b
       ret
; Total bytes of code 31
```
```assembly
; Silk.NET.Maths.Scalar.Multiply[[System.Byte, System.Private.CoreLib]](Byte, Byte)
       imul      ecx,edx
       movzx     eax,cl
       ret
; Total bytes of code 7
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       push      rbx
       movzx     eax,cl
       mov       r8,rcx
       shr       r8,8
       movzx     r8d,r8b
       mov       r10,rcx
       shr       r10,10
       movzx     r10d,r10b
       shr       rcx,18
       movzx     ecx,cl
       movzx     r9d,dl
       mov       r11,rdx
       shr       r11,8
       movzx     r11d,r11b
       mov       rbx,rdx
       shr       rbx,10
       movzx     ebx,bl
       shr       rdx,18
       movzx     edx,dl
       add       eax,r9d
       movzx     eax,al
       add       r8d,r11d
       movzx     r8d,r8b
       add       r10d,ebx
       movzx     r10d,r10b
       add       ecx,edx
       movzx     ecx,cl
       shl       r8d,8
       or        eax,r8d
       shl       r10d,10
       or        eax,r10d
       shl       ecx,18
       or        eax,ecx
       pop       rbx
       ret
; Total bytes of code 111
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Byte, System.Private.CoreLib]].op_Multiply(Silk.NET.Maths.Vector4D`1<Byte>, Byte)
       movzx     eax,cl
       mov       r8,rcx
       shr       r8,8
       movzx     r8d,r8b
       mov       r10,rcx
       shr       r10,10
       movzx     r10d,r10b
       shr       rcx,18
       movzx     ecx,cl
       movzx     edx,dl
       imul      eax,edx
       movzx     eax,al
       imul      r8d,edx
       movzx     r8d,r8b
       imul      r10d,edx
       movzx     r10d,r10b
       imul      ecx,edx
       movzx     ecx,cl
       shl       r8d,8
       or        eax,r8d
       shl       r10d,10
       or        eax,r10d
       shl       ecx,18
       or        eax,ecx
       ret
; Total bytes of code 83
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Byte, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>, Silk.NET.Maths.Vector4D`1<Byte>)
       mov       [rcx],edx
       mov       [rcx+4],r8d
       mov       [rcx+8],r9d
       mov       eax,[rsp+28]
       mov       [rcx+0C],eax
       ret
; Total bytes of code 18
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

