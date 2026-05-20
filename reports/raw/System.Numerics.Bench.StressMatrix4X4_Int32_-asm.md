## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4`1[[System.Int32, System.Private.CoreLib]].Add()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       [rsp+0F0],rcx
       mov       r8,[rcx+8]
       mov       r10,r8
       cmp       eax,[r10+8]
       jae       near ptr M00_L01
       mov       r9,rax
       shl       r9,6
       mov       [rsp+30],r9
       lea       r10,[r10+r9+10]
       mov       r11d,[r10]
       mov       ebx,[r10+4]
       mov       esi,[r10+8]
       mov       edi,[r10+0C]
       mov       ebp,[r10+10]
       mov       [rsp+98],ebp
       mov       r14d,[r10+14]
       mov       [rsp+94],r14d
       mov       r15d,[r10+18]
       mov       [rsp+90],r15d
       mov       r13d,[r10+1C]
       mov       [rsp+8C],r13d
       mov       r12d,[r10+20]
       mov       [rsp+88],r12d
       mov       r12d,[r10+24]
       mov       [rsp+84],r12d
       mov       r12d,[r10+28]
       mov       [rsp+80],r12d
       mov       r12d,[r10+2C]
       mov       [rsp+7C],r12d
       mov       r12d,[r10+30]
       mov       [rsp+78],r12d
       mov       r12d,[r10+34]
       mov       [rsp+74],r12d
       mov       r12d,[r10+38]
       mov       [rsp+70],r12d
       mov       r10d,[r10+3C]
       mov       [rsp+6C],r10d
       lea       r10d,[rax+1]
       mov       [rsp+2C],r10d
       cmp       r10d,[r8+8]
       jae       near ptr M00_L01
       mov       r12d,r10d
       shl       r12,6
       lea       r8,[r8+r12+10]
       mov       r12d,[r8]
       mov       r13d,[r8+4]
       mov       r15d,[r8+8]
       mov       r14d,[r8+0C]
       mov       ebp,[r8+10]
       mov       [rsp+68],ebp
       mov       ebp,[r8+14]
       mov       [rsp+64],ebp
       mov       ebp,[r8+18]
       mov       [rsp+60],ebp
       mov       ebp,[r8+1C]
       mov       [rsp+5C],ebp
       mov       ebp,[r8+20]
       mov       [rsp+58],ebp
       mov       ebp,[r8+24]
       mov       [rsp+54],ebp
       mov       ebp,[r8+28]
       mov       [rsp+50],ebp
       mov       ebp,[r8+2C]
       mov       [rsp+4C],ebp
       mov       ebp,[r8+30]
       mov       [rsp+48],ebp
       mov       ebp,[r8+34]
       mov       [rsp+44],ebp
       mov       ebp,[r8+38]
       mov       [rsp+40],ebp
       mov       r8d,[r8+3C]
       mov       [rsp+3C],r8d
       add       r11d,r12d
       add       ebx,r13d
       add       esi,r15d
       add       edi,r14d
       mov       [rsp+0A4],edi
       mov       r14d,[rsp+98]
       add       r14d,[rsp+68]
       mov       r15d,[rsp+94]
       add       r15d,[rsp+64]
       mov       r13d,[rsp+90]
       add       r13d,[rsp+60]
       mov       r12d,[rsp+8C]
       add       r12d,[rsp+5C]
       mov       [rsp+0A0],r12d
       mov       r12d,[rsp+88]
       add       r12d,[rsp+58]
       mov       edi,[rsp+84]
       add       edi,[rsp+54]
       mov       r8d,[rsp+80]
       add       r8d,[rsp+50]
       mov       ebp,[rsp+7C]
       add       ebp,[rsp+4C]
       mov       [rsp+9C],ebp
       mov       ebp,[rsp+78]
       add       ebp,[rsp+48]
       mov       ecx,[rsp+74]
       add       ecx,[rsp+44]
       mov       r9d,[rsp+70]
       add       r9d,[rsp+40]
       mov       r10d,[rsp+6C]
       add       r10d,[rsp+3C]
       cmp       eax,[rdx+8]
       jae       near ptr M00_L01
       mov       rax,[rsp+30]
       lea       rax,[rdx+rax+10]
       mov       [rax],r11d
       mov       [rax+4],ebx
       mov       [rax+8],esi
       mov       edx,[rsp+0A4]
       mov       [rax+0C],edx
       mov       [rax+10],r14d
       mov       [rax+14],r15d
       mov       [rax+18],r13d
       mov       edx,[rsp+0A0]
       mov       [rax+1C],edx
       mov       [rax+20],r12d
       mov       [rax+24],edi
       mov       [rax+28],r8d
       mov       edx,[rsp+9C]
       mov       [rax+2C],edx
       mov       [rax+30],ebp
       mov       [rax+34],ecx
       mov       [rax+38],r9d
       mov       [rax+3C],r10d
       mov       eax,[rsp+2C]
       cmp       eax,1869F
       mov       rcx,[rsp+0F0]
       jl        near ptr M00_L00
       add       rsp,0A8
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 664
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4`1[[System.Int32, System.Private.CoreLib]].Subtract()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       [rsp+0F0],rcx
       mov       r8,[rcx+8]
       mov       r10,r8
       cmp       eax,[r10+8]
       jae       near ptr M00_L01
       mov       r9,rax
       shl       r9,6
       mov       [rsp+30],r9
       lea       r10,[r10+r9+10]
       mov       r11d,[r10]
       mov       ebx,[r10+4]
       mov       esi,[r10+8]
       mov       edi,[r10+0C]
       mov       ebp,[r10+10]
       mov       [rsp+98],ebp
       mov       r14d,[r10+14]
       mov       [rsp+94],r14d
       mov       r15d,[r10+18]
       mov       [rsp+90],r15d
       mov       r13d,[r10+1C]
       mov       [rsp+8C],r13d
       mov       r12d,[r10+20]
       mov       [rsp+88],r12d
       mov       r12d,[r10+24]
       mov       [rsp+84],r12d
       mov       r12d,[r10+28]
       mov       [rsp+80],r12d
       mov       r12d,[r10+2C]
       mov       [rsp+7C],r12d
       mov       r12d,[r10+30]
       mov       [rsp+78],r12d
       mov       r12d,[r10+34]
       mov       [rsp+74],r12d
       mov       r12d,[r10+38]
       mov       [rsp+70],r12d
       mov       r10d,[r10+3C]
       mov       [rsp+6C],r10d
       lea       r10d,[rax+1]
       mov       [rsp+2C],r10d
       cmp       r10d,[r8+8]
       jae       near ptr M00_L01
       mov       r12d,r10d
       shl       r12,6
       lea       r8,[r8+r12+10]
       mov       r12d,[r8]
       mov       r13d,[r8+4]
       mov       r15d,[r8+8]
       mov       r14d,[r8+0C]
       mov       ebp,[r8+10]
       mov       [rsp+68],ebp
       mov       ebp,[r8+14]
       mov       [rsp+64],ebp
       mov       ebp,[r8+18]
       mov       [rsp+60],ebp
       mov       ebp,[r8+1C]
       mov       [rsp+5C],ebp
       mov       ebp,[r8+20]
       mov       [rsp+58],ebp
       mov       ebp,[r8+24]
       mov       [rsp+54],ebp
       mov       ebp,[r8+28]
       mov       [rsp+50],ebp
       mov       ebp,[r8+2C]
       mov       [rsp+4C],ebp
       mov       ebp,[r8+30]
       mov       [rsp+48],ebp
       mov       ebp,[r8+34]
       mov       [rsp+44],ebp
       mov       ebp,[r8+38]
       mov       [rsp+40],ebp
       mov       r8d,[r8+3C]
       mov       [rsp+3C],r8d
       sub       r11d,r12d
       sub       ebx,r13d
       sub       esi,r15d
       sub       edi,r14d
       mov       [rsp+0A4],edi
       mov       r14d,[rsp+98]
       sub       r14d,[rsp+68]
       mov       r15d,[rsp+94]
       sub       r15d,[rsp+64]
       mov       r13d,[rsp+90]
       sub       r13d,[rsp+60]
       mov       r12d,[rsp+8C]
       sub       r12d,[rsp+5C]
       mov       [rsp+0A0],r12d
       mov       r12d,[rsp+88]
       sub       r12d,[rsp+58]
       mov       edi,[rsp+84]
       sub       edi,[rsp+54]
       mov       r8d,[rsp+80]
       sub       r8d,[rsp+50]
       mov       ebp,[rsp+7C]
       sub       ebp,[rsp+4C]
       mov       [rsp+9C],ebp
       mov       ebp,[rsp+78]
       sub       ebp,[rsp+48]
       mov       ecx,[rsp+74]
       sub       ecx,[rsp+44]
       mov       r9d,[rsp+70]
       sub       r9d,[rsp+40]
       mov       r10d,[rsp+6C]
       sub       r10d,[rsp+3C]
       cmp       eax,[rdx+8]
       jae       near ptr M00_L01
       mov       rax,[rsp+30]
       lea       rax,[rdx+rax+10]
       mov       [rax],r11d
       mov       [rax+4],ebx
       mov       [rax+8],esi
       mov       edx,[rsp+0A4]
       mov       [rax+0C],edx
       mov       [rax+10],r14d
       mov       [rax+14],r15d
       mov       [rax+18],r13d
       mov       edx,[rsp+0A0]
       mov       [rax+1C],edx
       mov       [rax+20],r12d
       mov       [rax+24],edi
       mov       [rax+28],r8d
       mov       edx,[rsp+9C]
       mov       [rax+2C],edx
       mov       [rax+30],ebp
       mov       [rax+34],ecx
       mov       [rax+38],r9d
       mov       [rax+3C],r10d
       mov       eax,[rsp+2C]
       cmp       eax,1869F
       mov       rcx,[rsp+0F0]
       jl        near ptr M00_L00
       add       rsp,0A8
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 664
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4`1[[System.Int32, System.Private.CoreLib]].Multiply()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,278
       mov       rbx,rcx
       xor       esi,esi
M00_L00:
       mov       rdi,[rbx+10]
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       cmp       esi,[rdx+8]
       jae       near ptr M00_L01
       mov       r8,rsi
       shl       r8,6
       vmovdqu32 zmm0,[rdx+r8+10]
       vmovdqu32 [rsp+238],zmm0
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L01
       lea       edx,[rsi+1]
       shl       rdx,6
       vmovdqu32 zmm0,[rcx+rdx+10]
       vmovdqu32 [rsp+1F8],zmm0
       mov       ecx,[rsp+238]
       mov       edx,[rsp+1F8]
       mov       r8d,[rsp+1FC]
       mov       r9d,[rsp+200]
       mov       eax,[rsp+204]
       imul      edx,ecx
       imul      r8d,ecx
       imul      r9d,ecx
       imul      ecx,eax
       mov       eax,[rsp+23C]
       mov       r10d,[rsp+208]
       mov       r11d,[rsp+20C]
       mov       ebp,[rsp+210]
       mov       r14d,[rsp+214]
       imul      r10d,eax
       imul      r11d,eax
       imul      ebp,eax
       imul      eax,r14d
       add       edx,r10d
       add       r8d,r11d
       add       r9d,ebp
       add       ecx,eax
       mov       eax,[rsp+240]
       mov       r10d,[rsp+218]
       mov       r11d,[rsp+21C]
       mov       ebp,[rsp+220]
       mov       r14d,[rsp+224]
       imul      r10d,eax
       imul      r11d,eax
       imul      ebp,eax
       imul      eax,r14d
       add       edx,r10d
       add       r8d,r11d
       add       r9d,ebp
       add       ecx,eax
       mov       eax,[rsp+244]
       mov       r10d,[rsp+228]
       mov       r11d,[rsp+22C]
       mov       ebp,[rsp+230]
       mov       r14d,[rsp+234]
       imul      r10d,eax
       imul      r11d,eax
       imul      ebp,eax
       imul      eax,r14d
       add       edx,r10d
       add       r8d,r11d
       add       r9d,ebp
       add       ecx,eax
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+68],xmm0
       mov       [rsp+20],ecx
       lea       rcx,[rsp+68]
       call      qword ptr [7FF7FD8848B8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32, Int32, Int32, Int32)
       vmovups   xmm0,[rsp+68]
       vmovups   [rsp+1E8],xmm0
       mov       ecx,[rsp+248]
       mov       edx,[rsp+1F8]
       mov       r8d,[rsp+1FC]
       mov       r9d,[rsp+200]
       mov       eax,[rsp+204]
       imul      edx,ecx
       imul      r8d,ecx
       imul      r9d,ecx
       imul      ecx,eax
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+58],xmm0
       mov       [rsp+20],ecx
       lea       rcx,[rsp+58]
       call      qword ptr [7FF7FD8848B8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32, Int32, Int32, Int32)
       mov       ebp,[rsp+58]
       mov       r14d,[rsp+5C]
       mov       r15d,[rsp+60]
       mov       r13d,[rsp+64]
       mov       ecx,[rsp+24C]
       mov       edx,[rsp+208]
       mov       r8d,[rsp+20C]
       mov       r9d,[rsp+210]
       mov       eax,[rsp+214]
       imul      edx,ecx
       imul      r8d,ecx
       imul      r9d,ecx
       imul      ecx,eax
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+48],xmm0
       mov       [rsp+20],ecx
       lea       rcx,[rsp+48]
       call      qword ptr [7FF7FD8848B8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32, Int32, Int32, Int32)
       mov       r12d,[rsp+48]
       mov       eax,[rsp+4C]
       mov       r8d,[rsp+50]
       mov       edx,[rsp+54]
       add       ebp,r12d
       add       r14d,eax
       add       r15d,r8d
       mov       ecx,r13d
       call      qword ptr [7FF7FD884720]; Silk.NET.Maths.Scalar.<Add>g__Float|22_0[[System.Int32, System.Private.CoreLib]](Int32, Int32)
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+38],xmm0
       mov       [rsp+20],eax
       lea       rcx,[rsp+38]
       mov       edx,ebp
       mov       r8d,r14d
       mov       r9d,r15d
       call      qword ptr [7FF7FD8848B8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32, Int32, Int32, Int32)
       vmovups   xmm0,[rsp+38]
       vmovups   [rsp+1D8],xmm0
       lea       rcx,[rsp+238]
       call      qword ptr [7FF7FD884420]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M23()
       mov       edx,eax
       vmovups   xmm0,[rsp+218]
       vmovups   [rsp+28],xmm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+1C8]
       call      qword ptr [7FF7FD884378]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+1B8]
       lea       rdx,[rsp+1D8]
       lea       r8,[rsp+1C8]
       call      qword ptr [7FF7FD8843A8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+238]
       call      qword ptr [7FF7FD884438]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M24()
       mov       edx,eax
       vmovups   xmm0,[rsp+228]
       vmovups   [rsp+28],xmm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+1A8]
       call      qword ptr [7FF7FD884378]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+198]
       lea       rdx,[rsp+1B8]
       lea       r8,[rsp+1A8]
       call      qword ptr [7FF7FD8843A8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+238]
       call      qword ptr [7FF7FD884450]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M31()
       mov       edx,eax
       vmovups   xmm0,[rsp+1F8]
       vmovups   [rsp+28],xmm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+188]
       call      qword ptr [7FF7FD884378]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+238]
       call      qword ptr [7FF7FD884468]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M32()
       mov       edx,eax
       vmovups   xmm0,[rsp+208]
       vmovups   [rsp+28],xmm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+178]
       call      qword ptr [7FF7FD884378]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+168]
       lea       rdx,[rsp+188]
       lea       r8,[rsp+178]
       call      qword ptr [7FF7FD8843A8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+238]
       call      qword ptr [7FF7FD884480]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M33()
       mov       edx,eax
       vmovups   xmm0,[rsp+218]
       vmovups   [rsp+28],xmm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+158]
       call      qword ptr [7FF7FD884378]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+148]
       lea       rdx,[rsp+168]
       lea       r8,[rsp+158]
       call      qword ptr [7FF7FD8843A8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+238]
       call      qword ptr [7FF7FD884498]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M34()
       mov       edx,eax
       vmovups   xmm0,[rsp+228]
       vmovups   [rsp+28],xmm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+138]
       call      qword ptr [7FF7FD884378]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+128]
       lea       rdx,[rsp+148]
       lea       r8,[rsp+138]
       call      qword ptr [7FF7FD8843A8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+238]
       call      qword ptr [7FF7FD8844B0]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M41()
       mov       edx,eax
       vmovups   xmm0,[rsp+1F8]
       vmovups   [rsp+28],xmm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+118]
       call      qword ptr [7FF7FD884378]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+238]
       call      qword ptr [7FF7FD8844C8]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M42()
       mov       edx,eax
       vmovups   xmm0,[rsp+208]
       vmovups   [rsp+28],xmm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+108]
       call      qword ptr [7FF7FD884378]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+0F8]
       lea       rdx,[rsp+118]
       lea       r8,[rsp+108]
       call      qword ptr [7FF7FD8843A8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+238]
       call      qword ptr [7FF7FD8844E0]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M43()
       mov       edx,eax
       vmovups   xmm0,[rsp+218]
       vmovups   [rsp+28],xmm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+0E8]
       call      qword ptr [7FF7FD884378]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+0D8]
       lea       rdx,[rsp+0F8]
       lea       r8,[rsp+0E8]
       call      qword ptr [7FF7FD8843A8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+238]
       call      qword ptr [7FF7FD8844F8]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M44()
       mov       edx,eax
       lea       rcx,[rsp+0C8]
       lea       r8,[rsp+228]
       call      qword ptr [7FF7FD884378]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu32 [rsp+88],zmm0
       lea       rcx,[rsp+78]
       lea       rdx,[rsp+0D8]
       lea       r8,[rsp+0C8]
       call      qword ptr [7FF7FD8843A8]; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       lea       rcx,[rsp+78]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+88]
       lea       rdx,[rsp+1E8]
       lea       r8,[rsp+198]
       lea       r9,[rsp+128]
       call      qword ptr [7FF7FD884510]; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       cmp       esi,[rdi+8]
       jae       short M00_L01
       mov       rax,rsi
       shl       rax,6
       vmovdqu32 zmm0,[rsp+88]
       vmovdqu32 [rdi+rax+10],zmm0
       inc       esi
       cmp       esi,1869F
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,278
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1517
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32, Int32, Int32, Int32)
       mov       [rcx],edx
       mov       [rcx+4],r8d
       mov       [rcx+8],r9d
       mov       eax,[rsp+28]
       mov       [rcx+0C],eax
       ret
; Total bytes of code 18
```
```assembly
; Silk.NET.Maths.Scalar.<Add>g__Float|22_0[[System.Int32, System.Private.CoreLib]](Int32, Int32)
       lea       eax,[rcx+rdx]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M23()
       mov       eax,[rcx+18]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Multiply(Int32, Silk.NET.Maths.Vector4D`1<Int32>)
       mov       eax,edx
       imul      eax,[r8]
       mov       r10d,edx
       imul      r10d,[r8+4]
       mov       r9d,edx
       imul      r9d,[r8+8]
       imul      edx,[r8+0C]
       mov       [rcx],eax
       mov       [rcx+4],r10d
       mov       [rcx+8],r9d
       mov       [rcx+0C],edx
       mov       rax,rcx
       ret
; Total bytes of code 44
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Int32, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       mov       eax,[rdx]
       add       eax,[r8]
       mov       r10d,[rdx+4]
       add       r10d,[r8+4]
       mov       r9d,[rdx+8]
       add       r9d,[r8+8]
       mov       edx,[rdx+0C]
       add       edx,[r8+0C]
       mov       [rcx],eax
       mov       [rcx+4],r10d
       mov       [rcx+8],r9d
       mov       [rcx+0C],edx
       mov       rax,rcx
       ret
; Total bytes of code 45
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M24()
       mov       eax,[rcx+1C]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M31()
       mov       eax,[rcx+20]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M32()
       mov       eax,[rcx+24]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M33()
       mov       eax,[rcx+28]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M34()
       mov       eax,[rcx+2C]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M41()
       mov       eax,[rcx+30]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M42()
       mov       eax,[rcx+34]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M43()
       mov       eax,[rcx+38]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]].get_M44()
       mov       eax,[rcx+3C]
       ret
; Total bytes of code 4
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int32, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>, Silk.NET.Maths.Vector4D`1<Int32>)
       mov       rax,[rsp+28]
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       vmovups   xmm0,[r8]
       vmovups   [rcx+10],xmm0
       vmovups   xmm0,[r9]
       vmovups   [rcx+20],xmm0
       vmovups   xmm0,[rax]
       vmovups   [rcx+30],xmm0
       ret
; Total bytes of code 43
```

