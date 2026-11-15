## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Byte, System.Private.CoreLib]].Add()
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
       jae       near ptr 00000000000034D0
       mov       r9,rax
       shl       r9,4
       lea       r10,[r10+r9+10]
       movzx     r11d,byte ptr [r10]
       movzx     ebx,byte ptr [r10+1]
       movzx     esi,byte ptr [r10+2]
       movzx     edi,byte ptr [r10+3]
       movzx     ebp,byte ptr [r10+4]
       mov       [rsp+94],ebp
       movzx     r14d,byte ptr [r10+5]
       mov       [rsp+90],r14d
       movzx     r15d,byte ptr [r10+6]
       mov       [rsp+8C],r15d
       movzx     r13d,byte ptr [r10+7]
       mov       [rsp+88],r13d
       movzx     r12d,byte ptr [r10+8]
       mov       [rsp+84],r12d
       movzx     r12d,byte ptr [r10+9]
       mov       [rsp+80],r12d
       movzx     r12d,byte ptr [r10+0A]
       mov       [rsp+7C],r12d
       movzx     r12d,byte ptr [r10+0B]
       mov       [rsp+78],r12d
       movzx     r12d,byte ptr [r10+0C]
       mov       [rsp+74],r12d
       movzx     r12d,byte ptr [r10+0D]
       mov       [rsp+70],r12d
       movzx     r12d,byte ptr [r10+0E]
       mov       [rsp+6C],r12d
       movzx     r10d,byte ptr [r10+0F]
       mov       [rsp+68],r10d
       lea       r10d,[rax+1]
       cmp       r10d,[r8+8]
       jae       near ptr 00000000000034D0
       mov       r12d,r10d
       shl       r12,4
       lea       r8,[r8+r12+10]
       movzx     r12d,byte ptr [r8]
       movzx     r13d,byte ptr [r8+1]
       movzx     r15d,byte ptr [r8+2]
       movzx     r14d,byte ptr [r8+3]
       movzx     ebp,byte ptr [r8+4]
       mov       [rsp+64],ebp
       movzx     ebp,byte ptr [r8+5]
       mov       [rsp+60],ebp
       movzx     ebp,byte ptr [r8+6]
       mov       [rsp+5C],ebp
       movzx     ebp,byte ptr [r8+7]
       mov       [rsp+58],ebp
       movzx     ebp,byte ptr [r8+8]
       mov       [rsp+54],ebp
       movzx     ebp,byte ptr [r8+9]
       mov       [rsp+50],ebp
       movzx     ebp,byte ptr [r8+0A]
       mov       [rsp+4C],ebp
       movzx     ebp,byte ptr [r8+0B]
       mov       [rsp+48],ebp
       movzx     ebp,byte ptr [r8+0C]
       mov       [rsp+44],ebp
       movzx     ebp,byte ptr [r8+0D]
       mov       [rsp+40],ebp
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
       mov       [rsp+3C],edi
       mov       r14d,[rsp+94]
       mov       r15d,[rsp+64]
       add       r14d,r15d
       movzx     r14d,r14b
       mov       r15d,[rsp+90]
       mov       r13d,[rsp+60]
       add       r15d,r13d
       movzx     r15d,r15b
       mov       r13d,[rsp+8C]
       mov       r12d,[rsp+5C]
       add       r13d,r12d
       movzx     r13d,r13b
       mov       r12d,[rsp+88]
       mov       edi,[rsp+58]
       add       edi,r12d
       movzx     edi,dil
       mov       [rsp+38],r14d
       mov       [rsp+34],r15d
       mov       [rsp+30],r13d
       mov       [rsp+2C],edi
       mov       r12d,[rsp+84]
       mov       edi,[rsp+54]
       add       edi,r12d
       movzx     edi,dil
       mov       r12d,[rsp+80]
       mov       r13d,[rsp+50]
       add       r13d,r12d
       movzx     r13d,r13b
       mov       r12d,[rsp+7C]
       mov       r15d,[rsp+4C]
       add       r15d,r12d
       movzx     r15d,r15b
       mov       r12d,[rsp+78]
       mov       r14d,[rsp+48]
       add       r14d,r12d
       movzx     r14d,r14b
       mov       [rsp+28],r15d
       mov       [rsp+24],r14d
       mov       r12d,[rsp+74]
       mov       r14d,[rsp+44]
       add       r14d,r12d
       movzx     r14d,r14b
       mov       r12d,[rsp+70]
       mov       r15d,[rsp+40]
       add       r15d,r12d
       movzx     r15d,r15b
       mov       r12d,[rsp+6C]
       add       ebp,r12d
       movzx     ebp,bpl
       mov       r12d,[rsp+68]
       add       r8d,r12d
       movzx     r8d,r8b
       cmp       eax,[rdx+8]
       jae       short 00000000000034D0
       lea       rax,[rdx+r9+10]
       mov       [rax],r11b
       mov       [rax+1],bl
       mov       [rax+2],sil
       mov       edx,[rsp+3C]
       mov       [rax+3],dl
       mov       edx,[rsp+38]
       mov       [rax+4],dl
       mov       edx,[rsp+34]
       mov       [rax+5],dl
       mov       edx,[rsp+30]
       mov       [rax+6],dl
       mov       edx,[rsp+2C]
       mov       [rax+7],dl
       mov       [rax+8],dil
       mov       [rax+9],r13b
       mov       edx,[rsp+28]
       mov       [rax+0A],dl
       mov       edx,[rsp+24]
       mov       [rax+0B],dl
       mov       [rax+0C],r14b
       mov       [rax+0D],r15b
       mov       [rax+0E],bpl
       mov       [rax+0F],r8b
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 00000000000031F5
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
; Total bytes of code 758
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Byte, System.Private.CoreLib]].Subtract()
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
       jae       near ptr 00000000000036F0
       mov       r9,rax
       shl       r9,4
       lea       r10,[r10+r9+10]
       movzx     r11d,byte ptr [r10]
       movzx     ebx,byte ptr [r10+1]
       movzx     esi,byte ptr [r10+2]
       movzx     edi,byte ptr [r10+3]
       movzx     ebp,byte ptr [r10+4]
       mov       [rsp+94],ebp
       movzx     r14d,byte ptr [r10+5]
       mov       [rsp+90],r14d
       movzx     r15d,byte ptr [r10+6]
       mov       [rsp+8C],r15d
       movzx     r13d,byte ptr [r10+7]
       mov       [rsp+88],r13d
       movzx     r12d,byte ptr [r10+8]
       mov       [rsp+84],r12d
       movzx     r12d,byte ptr [r10+9]
       mov       [rsp+80],r12d
       movzx     r12d,byte ptr [r10+0A]
       mov       [rsp+7C],r12d
       movzx     r12d,byte ptr [r10+0B]
       mov       [rsp+78],r12d
       movzx     r12d,byte ptr [r10+0C]
       mov       [rsp+74],r12d
       movzx     r12d,byte ptr [r10+0D]
       mov       [rsp+70],r12d
       movzx     r12d,byte ptr [r10+0E]
       mov       [rsp+6C],r12d
       movzx     r10d,byte ptr [r10+0F]
       mov       [rsp+68],r10d
       lea       r10d,[rax+1]
       cmp       r10d,[r8+8]
       jae       near ptr 00000000000036F0
       mov       r12d,r10d
       shl       r12,4
       lea       r8,[r8+r12+10]
       movzx     r12d,byte ptr [r8]
       movzx     r13d,byte ptr [r8+1]
       movzx     r15d,byte ptr [r8+2]
       movzx     r14d,byte ptr [r8+3]
       movzx     ebp,byte ptr [r8+4]
       mov       [rsp+64],ebp
       movzx     ebp,byte ptr [r8+5]
       mov       [rsp+60],ebp
       movzx     ebp,byte ptr [r8+6]
       mov       [rsp+5C],ebp
       movzx     ebp,byte ptr [r8+7]
       mov       [rsp+58],ebp
       movzx     ebp,byte ptr [r8+8]
       mov       [rsp+54],ebp
       movzx     ebp,byte ptr [r8+9]
       mov       [rsp+50],ebp
       movzx     ebp,byte ptr [r8+0A]
       mov       [rsp+4C],ebp
       movzx     ebp,byte ptr [r8+0B]
       mov       [rsp+48],ebp
       movzx     ebp,byte ptr [r8+0C]
       mov       [rsp+44],ebp
       movzx     ebp,byte ptr [r8+0D]
       mov       [rsp+40],ebp
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
       mov       [rsp+3C],edi
       mov       r14d,[rsp+94]
       mov       r15d,[rsp+64]
       sub       r14d,r15d
       movzx     r14d,r14b
       mov       r15d,[rsp+90]
       mov       r13d,[rsp+60]
       sub       r15d,r13d
       movzx     r15d,r15b
       mov       r13d,[rsp+8C]
       mov       r12d,[rsp+5C]
       sub       r13d,r12d
       movzx     r13d,r13b
       mov       r12d,[rsp+88]
       mov       edi,[rsp+58]
       sub       r12d,edi
       movzx     edi,r12b
       mov       [rsp+38],r14d
       mov       [rsp+34],r15d
       mov       [rsp+30],r13d
       mov       [rsp+2C],edi
       mov       r12d,[rsp+84]
       mov       edi,[rsp+54]
       sub       r12d,edi
       movzx     edi,r12b
       mov       r12d,[rsp+80]
       mov       r13d,[rsp+50]
       sub       r12d,r13d
       movzx     r13d,r12b
       mov       r12d,[rsp+7C]
       mov       r15d,[rsp+4C]
       sub       r12d,r15d
       movzx     r15d,r12b
       mov       r12d,[rsp+78]
       mov       r14d,[rsp+48]
       sub       r12d,r14d
       movzx     r14d,r12b
       mov       [rsp+28],r15d
       mov       [rsp+24],r14d
       mov       r12d,[rsp+74]
       mov       r14d,[rsp+44]
       sub       r12d,r14d
       movzx     r14d,r12b
       mov       r12d,[rsp+70]
       mov       r15d,[rsp+40]
       sub       r12d,r15d
       movzx     r15d,r12b
       mov       r12d,[rsp+6C]
       sub       r12d,ebp
       movzx     ebp,r12b
       mov       r12d,[rsp+68]
       sub       r12d,r8d
       movzx     r8d,r12b
       cmp       eax,[rdx+8]
       jae       short 00000000000036F0
       lea       rax,[rdx+r9+10]
       mov       [rax],r11b
       mov       [rax+1],bl
       mov       [rax+2],sil
       mov       edx,[rsp+3C]
       mov       [rax+3],dl
       mov       edx,[rsp+38]
       mov       [rax+4],dl
       mov       edx,[rsp+34]
       mov       [rax+5],dl
       mov       edx,[rsp+30]
       mov       [rax+6],dl
       mov       edx,[rsp+2C]
       mov       [rax+7],dl
       mov       [rax+8],dil
       mov       [rax+9],r13b
       mov       edx,[rsp+28]
       mov       [rax+0A],dl
       mov       edx,[rsp+24]
       mov       [rax+0B],dl
       mov       [rax+0C],r14b
       mov       [rax+0D],r15b
       mov       [rax+0E],bpl
       mov       [rax+0F],r8b
       mov       eax,r10d
       cmp       eax,1869F
       jl        near ptr 0000000000003415
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
; Total bytes of code 758
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```assembly
; System.Numerics.Bench.BaseStressMat44`1[[System.Byte, System.Private.CoreLib]].Multiply()
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
       jae       near ptr 0000000000005B4E
       mov       r9,rax
       shl       r9,4
       mov       [rsp+30],r9
       lea       r10,[r10+r9+10]
       movzx     r11d,byte ptr [r10]
       movzx     ebx,byte ptr [r10+1]
       movzx     esi,byte ptr [r10+2]
       mov       [rsp+0B4],esi
       movzx     edi,byte ptr [r10+3]
       mov       [rsp+0B0],edi
       movzx     ebp,byte ptr [r10+4]
       mov       [rsp+0AC],ebp
       movzx     r14d,byte ptr [r10+5]
       mov       [rsp+0A8],r14d
       movzx     r15d,byte ptr [r10+6]
       mov       [rsp+0A4],r15d
       movzx     r13d,byte ptr [r10+7]
       mov       [rsp+0A0],r13d
       movzx     r12d,byte ptr [r10+8]
       mov       [rsp+9C],r12d
       movzx     ecx,byte ptr [r10+9]
       mov       [rsp+98],ecx
       movzx     r9d,byte ptr [r10+0A]
       mov       [rsp+94],r9d
       movzx     r8d,byte ptr [r10+0B]
       mov       [rsp+90],r8d
       movzx     r8d,byte ptr [r10+0C]
       mov       [rsp+8C],r8d
       movzx     r8d,byte ptr [r10+0D]
       mov       [rsp+88],r8d
       movzx     r8d,byte ptr [r10+0E]
       mov       [rsp+84],r8d
       movzx     r10d,byte ptr [r10+0F]
       mov       [rsp+80],r10d
       mov       r10,[rsp+20]
       lea       r8d,[rax+1]
       mov       [rsp+2C],r8d
       cmp       r8d,[r10+8]
       jae       near ptr 0000000000005B4E
       shl       r8,4
       lea       r8,[r10+r8+10]
       movzx     r10d,byte ptr [r8]
       mov       [rsp+7C],r10d
       movzx     r9d,byte ptr [r8+1]
       movzx     ecx,byte ptr [r8+2]
       movzx     r12d,byte ptr [r8+3]
       movzx     r13d,byte ptr [r8+4]
       movzx     r15d,byte ptr [r8+5]
       movzx     r14d,byte ptr [r8+6]
       movzx     ebp,byte ptr [r8+7]
       movzx     edi,byte ptr [r8+8]
       movzx     esi,byte ptr [r8+9]
       mov       [rsp+78],esi
       movzx     esi,byte ptr [r8+0A]
       mov       [rsp+74],esi
       movzx     esi,byte ptr [r8+0B]
       mov       [rsp+70],esi
       movzx     esi,byte ptr [r8+0C]
       mov       [rsp+6C],esi
       movzx     esi,byte ptr [r8+0D]
       mov       [rsp+68],esi
       movzx     esi,byte ptr [r8+0E]
       movzx     r8d,byte ptr [r8+0F]
       imul      r10d,r11d
       movzx     r10d,r10b
       mov       [rsp+1C4],r10d
       mov       r10d,r9d
       imul      r10d,r11d
       movzx     r10d,r10b
       mov       [rsp+1C0],r10d
       mov       r10d,ecx
       imul      r10d,r11d
       movzx     r10d,r10b
       mov       [rsp+1BC],r10d
       mov       r10d,[rsp+1C4]
       mov       [rsp+1B4],r10b
       mov       r10d,[rsp+1C0]
       mov       [rsp+1B0],r10b
       mov       r10d,[rsp+1BC]
       mov       [rsp+1AC],r10b
       imul      r11d,r12d
       movzx     r11d,r11b
       mov       [rsp+1A8],r11b
       mov       r11d,r13d
       imul      r11d,ebx
       movzx     r11d,r11b
       mov       r10d,r15d
       imul      r10d,ebx
       movzx     r10d,r10b
       mov       [rsp+1B8],r10d
       mov       r10d,r14d
       imul      r10d,ebx
       movzx     r10d,r10b
       mov       [rsp+1A4],r11b
       mov       r11d,[rsp+1B8]
       mov       [rsp+1A0],r10b
       imul      ebx,ebp
       movzx     ebx,bl
       mov       [rsp+19C],bl
       movzx     ebx,byte ptr [rsp+1B4]
       add       ebx,[rsp+1A4]
       movzx     ebx,bl
       movzx     r10d,byte ptr [rsp+1B0]
       add       r10d,r11d
       movzx     r10d,r10b
       movzx     r11d,byte ptr [rsp+1AC]
       add       r11d,[rsp+1A0]
       movzx     r11d,r11b
       mov       [rsp+198],bl
       mov       [rsp+194],r10b
       mov       [rsp+190],r11b
       movzx     r11d,byte ptr [rsp+1A8]
       movzx     r10d,byte ptr [rsp+19C]
       add       r10d,r11d
       movzx     r10d,r10b
       mov       [rsp+18C],r10b
       mov       r11d,[rsp+0B4]
       mov       r10d,edi
       imul      r10d,r11d
       movzx     r10d,r10b
       mov       ebx,[rsp+78]
       imul      ebx,r11d
       movzx     ebx,bl
       mov       r11d,[rsp+74]
       imul      r11d,[rsp+0B4]
       movzx     r11d,r11b
       mov       [rsp+188],bl
       mov       [rsp+184],r11b
       mov       r11d,[rsp+70]
       mov       ebx,r11d
       imul      ebx,[rsp+0B4]
       movzx     ebx,bl
       mov       [rsp+180],bl
       movzx     ebx,byte ptr [rsp+198]
       add       r10d,ebx
       movzx     r10d,r10b
       movzx     ebx,byte ptr [rsp+194]
       add       ebx,[rsp+188]
       movzx     ebx,bl
       movzx     r11d,byte ptr [rsp+190]
       add       r11d,[rsp+184]
       movzx     r11d,r11b
       mov       [rsp+17C],r10b
       mov       [rsp+178],bl
       mov       [rsp+174],r11b
       movzx     r11d,byte ptr [rsp+18C]
       movzx     ebx,byte ptr [rsp+180]
       add       r11d,ebx
       movzx     r11d,r11b
       mov       [rsp+170],r11b
       mov       ebx,[rsp+6C]
       mov       r11d,[rsp+0B0]
       mov       r10d,ebx
       imul      r10d,r11d
       movzx     r10d,r10b
       mov       ebx,[rsp+68]
       imul      ebx,r11d
       movzx     ebx,bl
       imul      r11d,esi
       movzx     r11d,r11b
       mov       [rsp+16C],r11b
       mov       r11d,r8d
       imul      r11d,[rsp+0B0]
       movzx     r11d,r11b
       mov       [rsp+168],r11b
       movzx     r11d,byte ptr [rsp+17C]
       add       r10d,r11d
       movzx     r10d,r10b
       movzx     r11d,byte ptr [rsp+178]
       add       r11d,ebx
       movzx     r11d,r11b
       movzx     ebx,byte ptr [rsp+174]
       add       ebx,[rsp+16C]
       movzx     ebx,bl
       mov       [rsp+164],r11b
       mov       [rsp+160],bl
       movzx     ebx,byte ptr [rsp+170]
       movzx     r11d,byte ptr [rsp+168]
       add       r11d,ebx
       movzx     r11d,r11b
       mov       [rsp+64],r10d
       movzx     ebx,byte ptr [rsp+164]
       mov       [rsp+60],ebx
       movzx     ebx,byte ptr [rsp+160]
       mov       [rsp+5C],ebx
       mov       [rsp+58],r11d
       mov       r11d,[rsp+7C]
       mov       ebx,[rsp+0AC]
       mov       r10d,r11d
       imul      r10d,ebx
       movzx     r10d,r10b
       mov       r11d,r9d
       imul      r11d,ebx
       movzx     r11d,r11b
       imul      ebx,ecx
       movzx     ebx,bl
       mov       [rsp+15C],r10b
       mov       [rsp+158],r11b
       mov       [rsp+154],bl
       mov       ebx,r12d
       imul      ebx,[rsp+0AC]
       movzx     ebx,bl
       mov       [rsp+150],bl
       mov       ebx,[rsp+0A8]
       mov       r11d,r13d
       imul      r11d,ebx
       movzx     r11d,r11b
       mov       r10d,r15d
       imul      r10d,ebx
       movzx     r10d,r10b
       imul      ebx,r14d
       movzx     ebx,bl
       mov       [rsp+14C],bl
       mov       ebx,ebp
       imul      ebx,[rsp+0A8]
       movzx     ebx,bl
       mov       [rsp+148],bl
       movzx     ebx,byte ptr [rsp+15C]
       add       r11d,ebx
       movzx     r11d,r11b
       movzx     ebx,byte ptr [rsp+158]
       add       r10d,ebx
       movzx     r10d,r10b
       movzx     ebx,byte ptr [rsp+154]
       add       ebx,[rsp+14C]
       movzx     ebx,bl
       mov       [rsp+144],r11b
       mov       [rsp+140],r10b
       mov       [rsp+13C],bl
       movzx     ebx,byte ptr [rsp+150]
       movzx     r10d,byte ptr [rsp+148]
       add       r10d,ebx
       movzx     r10d,r10b
       mov       [rsp+138],r10b
       mov       ebx,[rsp+0A4]
       mov       r10d,edi
       imul      r10d,ebx
       movzx     r10d,r10b
       mov       r11d,[rsp+78]
       imul      r11d,ebx
       movzx     r11d,r11b
       mov       ebx,[rsp+74]
       imul      ebx,[rsp+0A4]
       movzx     ebx,bl
       mov       [rsp+134],r11b
       mov       [rsp+130],bl
       mov       ebx,[rsp+70]
       mov       r11d,ebx
       imul      r11d,[rsp+0A4]
       movzx     r11d,r11b
       mov       [rsp+12C],r11b
       movzx     r11d,byte ptr [rsp+144]
       add       r10d,r11d
       movzx     r10d,r10b
       movzx     r11d,byte ptr [rsp+140]
       add       r11d,[rsp+134]
       movzx     r11d,r11b
       movzx     ebx,byte ptr [rsp+13C]
       add       ebx,[rsp+130]
       movzx     ebx,bl
       mov       [rsp+128],r10b
       mov       [rsp+124],r11b
       mov       [rsp+120],bl
       movzx     ebx,byte ptr [rsp+138]
       movzx     r11d,byte ptr [rsp+12C]
       add       r11d,ebx
       movzx     r11d,r11b
       mov       [rsp+11C],r11b
       mov       ebx,[rsp+6C]
       mov       r11d,[rsp+0A0]
       mov       r10d,ebx
       imul      r10d,r11d
       movzx     r10d,r10b
       mov       ebx,[rsp+68]
       imul      ebx,r11d
       movzx     ebx,bl
       imul      r11d,esi
       movzx     r11d,r11b
       mov       [rsp+118],r11b
       mov       r11d,r8d
       imul      r11d,[rsp+0A0]
       movzx     r11d,r11b
       mov       [rsp+114],r11b
       movzx     r11d,byte ptr [rsp+128]
       add       r10d,r11d
       movzx     r10d,r10b
       movzx     r11d,byte ptr [rsp+124]
       add       r11d,ebx
       movzx     r11d,r11b
       movzx     ebx,byte ptr [rsp+120]
       add       ebx,[rsp+118]
       movzx     ebx,bl
       mov       [rsp+110],r11b
       mov       [rsp+10C],bl
       movzx     ebx,byte ptr [rsp+11C]
       movzx     r11d,byte ptr [rsp+114]
       add       r11d,ebx
       movzx     r11d,r11b
       mov       [rsp+54],r10d
       movzx     ebx,byte ptr [rsp+110]
       mov       [rsp+50],ebx
       movzx     ebx,byte ptr [rsp+10C]
       mov       [rsp+4C],ebx
       mov       [rsp+48],r11d
       mov       r11d,[rsp+7C]
       mov       ebx,[rsp+9C]
       mov       r10d,r11d
       imul      r10d,ebx
       movzx     r10d,r10b
       mov       r11d,r9d
       imul      r11d,ebx
       movzx     r11d,r11b
       imul      ebx,ecx
       movzx     ebx,bl
       mov       [rsp+108],r10b
       mov       [rsp+104],r11b
       mov       [rsp+100],bl
       mov       ebx,r12d
       imul      ebx,[rsp+9C]
       movzx     ebx,bl
       mov       [rsp+0FC],bl
       mov       ebx,[rsp+98]
       mov       r11d,r13d
       imul      r11d,ebx
       movzx     r11d,r11b
       mov       r10d,r15d
       imul      r10d,ebx
       movzx     r10d,r10b
       imul      ebx,r14d
       movzx     ebx,bl
       mov       [rsp+0F8],bl
       mov       ebx,ebp
       imul      ebx,[rsp+98]
       movzx     ebx,bl
       mov       [rsp+0F4],bl
       movzx     ebx,byte ptr [rsp+108]
       add       r11d,ebx
       movzx     r11d,r11b
       movzx     ebx,byte ptr [rsp+104]
       add       r10d,ebx
       movzx     r10d,r10b
       movzx     ebx,byte ptr [rsp+100]
       add       ebx,[rsp+0F8]
       movzx     ebx,bl
       mov       [rsp+0F0],r11b
       mov       [rsp+0EC],r10b
       mov       [rsp+0E8],bl
       movzx     ebx,byte ptr [rsp+0FC]
       movzx     r10d,byte ptr [rsp+0F4]
       add       r10d,ebx
       movzx     r10d,r10b
       mov       [rsp+0E4],r10b
       mov       ebx,[rsp+94]
       mov       r10d,edi
       imul      r10d,ebx
       movzx     r10d,r10b
       mov       r11d,[rsp+78]
       imul      r11d,ebx
       movzx     r11d,r11b
       mov       ebx,[rsp+74]
       imul      ebx,[rsp+94]
       movzx     ebx,bl
       mov       [rsp+0E0],r11b
       mov       [rsp+0DC],bl
       mov       ebx,[rsp+70]
       mov       r11d,ebx
       imul      r11d,[rsp+94]
       movzx     r11d,r11b
       mov       [rsp+0D8],r11b
       movzx     r11d,byte ptr [rsp+0F0]
       add       r10d,r11d
       movzx     r10d,r10b
       movzx     r11d,byte ptr [rsp+0EC]
       add       r11d,[rsp+0E0]
       movzx     r11d,r11b
       movzx     ebx,byte ptr [rsp+0E8]
       add       ebx,[rsp+0DC]
       movzx     ebx,bl
       mov       [rsp+0D4],r10b
       mov       [rsp+0D0],r11b
       mov       [rsp+0CC],bl
       movzx     ebx,byte ptr [rsp+0E4]
       movzx     r11d,byte ptr [rsp+0D8]
       add       r11d,ebx
       movzx     r11d,r11b
       mov       [rsp+0C8],r11b
       mov       ebx,[rsp+6C]
       mov       r11d,[rsp+90]
       mov       r10d,ebx
       imul      r10d,r11d
       movzx     r10d,r10b
       mov       ebx,[rsp+68]
       imul      ebx,r11d
       movzx     ebx,bl
       imul      r11d,esi
       movzx     r11d,r11b
       mov       [rsp+0C4],r11b
       mov       r11d,r8d
       imul      r11d,[rsp+90]
       movzx     r11d,r11b
       mov       [rsp+0C0],r11b
       movzx     r11d,byte ptr [rsp+0D4]
       add       r10d,r11d
       movzx     r10d,r10b
       movzx     r11d,byte ptr [rsp+0D0]
       add       r11d,ebx
       movzx     r11d,r11b
       movzx     ebx,byte ptr [rsp+0CC]
       add       ebx,[rsp+0C4]
       movzx     ebx,bl
       mov       [rsp+0BC],r11b
       mov       [rsp+0B8],bl
       movzx     ebx,byte ptr [rsp+0C8]
       movzx     r11d,byte ptr [rsp+0C0]
       add       r11d,ebx
       movzx     r11d,r11b
       movzx     ebx,byte ptr [rsp+0BC]
       mov       [rsp+44],ebx
       movzx     ebx,byte ptr [rsp+0B8]
       mov       [rsp+40],ebx
       mov       [rsp+3C],r11d
       mov       r11d,[rsp+7C]
       mov       ebx,[rsp+8C]
       imul      r11d,ebx
       movzx     r11d,r11b
       imul      r9d,ebx
       movzx     r9d,r9b
       imul      ecx,ebx
       movzx     ecx,cl
       imul      ebx,r12d
       movzx     ebx,bl
       mov       r12d,[rsp+88]
       imul      r13d,r12d
       movzx     r13d,r13b
       imul      r15d,r12d
       movzx     r15d,r15b
       imul      r14d,r12d
       movzx     r14d,r14b
       imul      ebp,r12d
       movzx     ebp,bpl
       add       r11d,r13d
       movzx     r11d,r11b
       add       r9d,r15d
       movzx     r9d,r9b
       add       ecx,r14d
       movzx     ecx,cl
       add       ebx,ebp
       movzx     ebx,bl
       mov       ebp,[rsp+84]
       imul      edi,ebp
       movzx     edi,dil
       mov       r14d,[rsp+78]
       imul      r14d,ebp
       movzx     r14d,r14b
       mov       r15d,[rsp+74]
       imul      r15d,ebp
       movzx     r15d,r15b
       mov       r13d,[rsp+70]
       imul      ebp,r13d
       movzx     ebp,bpl
       add       r11d,edi
       movzx     r11d,r11b
       add       r9d,r14d
       movzx     r9d,r9b
       add       ecx,r15d
       movzx     ecx,cl
       add       ebx,ebp
       movzx     ebx,bl
       mov       edi,[rsp+6C]
       mov       ebp,[rsp+80]
       imul      edi,ebp
       movzx     edi,dil
       mov       r14d,[rsp+68]
       imul      r14d,ebp
       movzx     r14d,r14b
       imul      esi,ebp
       movzx     esi,sil
       imul      r8d,ebp
       movzx     r8d,r8b
       add       r11d,edi
       movzx     r11d,r11b
       add       r9d,r14d
       movzx     r9d,r9b
       add       ecx,esi
       movzx     ecx,cl
       add       r8d,ebx
       movzx     r8d,r8b
       cmp       eax,[rdx+8]
       jae       near ptr 0000000000005B4E
       mov       rax,[rsp+30]
       lea       rax,[rdx+rax+10]
       mov       edx,[rsp+64]
       mov       [rax],dl
       mov       ebx,[rsp+60]
       mov       [rax+1],bl
       mov       ebx,[rsp+5C]
       mov       [rax+2],bl
       mov       edx,[rsp+58]
       mov       [rax+3],dl
       mov       edx,[rsp+54]
       mov       [rax+4],dl
       mov       ebx,[rsp+50]
       mov       [rax+5],bl
       mov       ebx,[rsp+4C]
       mov       [rax+6],bl
       mov       edx,[rsp+48]
       mov       [rax+7],dl
       mov       [rax+8],r10b
       mov       ebx,[rsp+44]
       mov       [rax+9],bl
       mov       ebx,[rsp+40]
       mov       [rax+0A],bl
       mov       edx,[rsp+3C]
       mov       [rax+0B],dl
       mov       [rax+0C],r11b
       mov       [rax+0D],r9b
       mov       [rax+0E],cl
       mov       [rax+0F],r8b
       mov       eax,[rsp+2C]
       cmp       eax,1869F
       mov       rcx,[rsp+210]
       jl        near ptr 0000000000005075
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
; Total bytes of code 2804
```
**Method was not JITted yet.**
Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()

