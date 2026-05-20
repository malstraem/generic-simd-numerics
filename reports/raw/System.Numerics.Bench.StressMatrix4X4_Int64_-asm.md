## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4`1[[System.Int64, System.Private.CoreLib]].Add()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,108
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       [rsp+150],rcx
       mov       r8,[rcx+8]
       mov       r10,r8
       cmp       eax,[r10+8]
       jae       near ptr M00_L01
       mov       r9,rax
       shl       r9,7
       mov       [rsp+28],r9
       lea       r10,[r10+r9+10]
       mov       r11,[r10]
       mov       rbx,[r10+8]
       mov       rsi,[r10+10]
       mov       rdi,[r10+18]
       mov       rbp,[r10+20]
       mov       [rsp+0E8],rbp
       mov       r14,[r10+28]
       mov       [rsp+0E0],r14
       mov       r15,[r10+30]
       mov       [rsp+0D8],r15
       mov       r13,[r10+38]
       mov       [rsp+0D0],r13
       mov       r12,[r10+40]
       mov       [rsp+0C8],r12
       mov       r12,[r10+48]
       mov       [rsp+0C0],r12
       mov       r12,[r10+50]
       mov       [rsp+0B8],r12
       mov       r12,[r10+58]
       mov       [rsp+0B0],r12
       mov       r12,[r10+60]
       mov       [rsp+0A8],r12
       mov       r12,[r10+68]
       mov       [rsp+0A0],r12
       mov       r12,[r10+70]
       mov       [rsp+98],r12
       mov       r10,[r10+78]
       mov       [rsp+90],r10
       lea       r10d,[rax+1]
       mov       [rsp+24],r10d
       cmp       r10d,[r8+8]
       jae       near ptr M00_L01
       mov       r12d,r10d
       shl       r12,7
       lea       r8,[r8+r12+10]
       mov       r12,[r8]
       mov       r13,[r8+8]
       mov       r15,[r8+10]
       mov       r14,[r8+18]
       mov       rbp,[r8+20]
       mov       [rsp+88],rbp
       mov       rbp,[r8+28]
       mov       [rsp+80],rbp
       mov       rbp,[r8+30]
       mov       [rsp+78],rbp
       mov       rbp,[r8+38]
       mov       [rsp+70],rbp
       mov       rbp,[r8+40]
       mov       [rsp+68],rbp
       mov       rbp,[r8+48]
       mov       [rsp+60],rbp
       mov       rbp,[r8+50]
       mov       [rsp+58],rbp
       mov       rbp,[r8+58]
       mov       [rsp+50],rbp
       mov       rbp,[r8+60]
       mov       [rsp+48],rbp
       mov       rbp,[r8+68]
       mov       [rsp+40],rbp
       mov       rbp,[r8+70]
       mov       [rsp+38],rbp
       mov       r8,[r8+78]
       mov       [rsp+30],r8
       add       r11,r12
       add       rbx,r13
       add       rsi,r15
       add       rdi,r14
       mov       [rsp+100],rdi
       mov       r14,[rsp+0E8]
       add       r14,[rsp+88]
       mov       r15,[rsp+0E0]
       add       r15,[rsp+80]
       mov       r13,[rsp+0D8]
       add       r13,[rsp+78]
       mov       r12,[rsp+0D0]
       add       r12,[rsp+70]
       mov       [rsp+0F8],r12
       mov       r12,[rsp+0C8]
       add       r12,[rsp+68]
       mov       rdi,[rsp+0C0]
       add       rdi,[rsp+60]
       mov       r8,[rsp+0B8]
       add       r8,[rsp+58]
       mov       rbp,[rsp+0B0]
       add       rbp,[rsp+50]
       mov       [rsp+0F0],rbp
       mov       rbp,[rsp+0A8]
       add       rbp,[rsp+48]
       mov       rcx,[rsp+0A0]
       add       rcx,[rsp+40]
       mov       r9,[rsp+98]
       add       r9,[rsp+38]
       mov       r10,[rsp+90]
       add       r10,[rsp+30]
       cmp       eax,[rdx+8]
       jae       near ptr M00_L01
       mov       rax,[rsp+28]
       lea       rax,[rdx+rax+10]
       mov       [rax],r11
       mov       [rax+8],rbx
       mov       [rax+10],rsi
       mov       rdx,[rsp+100]
       mov       [rax+18],rdx
       mov       [rax+20],r14
       mov       [rax+28],r15
       mov       [rax+30],r13
       mov       rdx,[rsp+0F8]
       mov       [rax+38],rdx
       mov       [rax+40],r12
       mov       [rax+48],rdi
       mov       [rax+50],r8
       mov       rdx,[rsp+0F0]
       mov       [rax+58],rdx
       mov       [rax+60],rbp
       mov       [rax+68],rcx
       mov       [rax+70],r9
       mov       [rax+78],r10
       mov       eax,[rsp+24]
       cmp       eax,1869F
       mov       rcx,[rsp+150]
       jl        near ptr M00_L00
       add       rsp,108
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
; Total bytes of code 739
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4`1[[System.Int64, System.Private.CoreLib]].Subtract()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,108
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       [rsp+150],rcx
       mov       r8,[rcx+8]
       mov       r10,r8
       cmp       eax,[r10+8]
       jae       near ptr M00_L01
       mov       r9,rax
       shl       r9,7
       mov       [rsp+28],r9
       lea       r10,[r10+r9+10]
       mov       r11,[r10]
       mov       rbx,[r10+8]
       mov       rsi,[r10+10]
       mov       rdi,[r10+18]
       mov       rbp,[r10+20]
       mov       [rsp+0E8],rbp
       mov       r14,[r10+28]
       mov       [rsp+0E0],r14
       mov       r15,[r10+30]
       mov       [rsp+0D8],r15
       mov       r13,[r10+38]
       mov       [rsp+0D0],r13
       mov       r12,[r10+40]
       mov       [rsp+0C8],r12
       mov       r12,[r10+48]
       mov       [rsp+0C0],r12
       mov       r12,[r10+50]
       mov       [rsp+0B8],r12
       mov       r12,[r10+58]
       mov       [rsp+0B0],r12
       mov       r12,[r10+60]
       mov       [rsp+0A8],r12
       mov       r12,[r10+68]
       mov       [rsp+0A0],r12
       mov       r12,[r10+70]
       mov       [rsp+98],r12
       mov       r10,[r10+78]
       mov       [rsp+90],r10
       lea       r10d,[rax+1]
       mov       [rsp+24],r10d
       cmp       r10d,[r8+8]
       jae       near ptr M00_L01
       mov       r12d,r10d
       shl       r12,7
       lea       r8,[r8+r12+10]
       mov       r12,[r8]
       mov       r13,[r8+8]
       mov       r15,[r8+10]
       mov       r14,[r8+18]
       mov       rbp,[r8+20]
       mov       [rsp+88],rbp
       mov       rbp,[r8+28]
       mov       [rsp+80],rbp
       mov       rbp,[r8+30]
       mov       [rsp+78],rbp
       mov       rbp,[r8+38]
       mov       [rsp+70],rbp
       mov       rbp,[r8+40]
       mov       [rsp+68],rbp
       mov       rbp,[r8+48]
       mov       [rsp+60],rbp
       mov       rbp,[r8+50]
       mov       [rsp+58],rbp
       mov       rbp,[r8+58]
       mov       [rsp+50],rbp
       mov       rbp,[r8+60]
       mov       [rsp+48],rbp
       mov       rbp,[r8+68]
       mov       [rsp+40],rbp
       mov       rbp,[r8+70]
       mov       [rsp+38],rbp
       mov       r8,[r8+78]
       mov       [rsp+30],r8
       sub       r11,r12
       sub       rbx,r13
       sub       rsi,r15
       sub       rdi,r14
       mov       [rsp+100],rdi
       mov       r14,[rsp+0E8]
       sub       r14,[rsp+88]
       mov       r15,[rsp+0E0]
       sub       r15,[rsp+80]
       mov       r13,[rsp+0D8]
       sub       r13,[rsp+78]
       mov       r12,[rsp+0D0]
       sub       r12,[rsp+70]
       mov       [rsp+0F8],r12
       mov       r12,[rsp+0C8]
       sub       r12,[rsp+68]
       mov       rdi,[rsp+0C0]
       sub       rdi,[rsp+60]
       mov       r8,[rsp+0B8]
       sub       r8,[rsp+58]
       mov       rbp,[rsp+0B0]
       sub       rbp,[rsp+50]
       mov       [rsp+0F0],rbp
       mov       rbp,[rsp+0A8]
       sub       rbp,[rsp+48]
       mov       rcx,[rsp+0A0]
       sub       rcx,[rsp+40]
       mov       r9,[rsp+98]
       sub       r9,[rsp+38]
       mov       r10,[rsp+90]
       sub       r10,[rsp+30]
       cmp       eax,[rdx+8]
       jae       near ptr M00_L01
       mov       rax,[rsp+28]
       lea       rax,[rdx+rax+10]
       mov       [rax],r11
       mov       [rax+8],rbx
       mov       [rax+10],rsi
       mov       rdx,[rsp+100]
       mov       [rax+18],rdx
       mov       [rax+20],r14
       mov       [rax+28],r15
       mov       [rax+30],r13
       mov       rdx,[rsp+0F8]
       mov       [rax+38],rdx
       mov       [rax+40],r12
       mov       [rax+48],rdi
       mov       [rax+50],r8
       mov       rdx,[rsp+0F0]
       mov       [rax+58],rdx
       mov       [rax+60],rbp
       mov       [rax+68],rcx
       mov       [rax+70],r9
       mov       [rax+78],r10
       mov       eax,[rsp+24]
       cmp       eax,1869F
       mov       rcx,[rsp+150]
       jl        near ptr M00_L00
       add       rsp,108
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
; Total bytes of code 739
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v4 (Job: .NET 10.0(Runtime=.NET 10.0))

```assembly
; System.Numerics.Bench.StressMatrix4X4`1[[System.Int64, System.Private.CoreLib]].Multiply()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,4E8
       mov       rbx,rcx
       xor       esi,esi
M00_L00:
       mov       rdi,[rbx+10]
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       cmp       esi,[rdx+8]
       jae       near ptr M00_L01
       mov       r8,rsi
       shl       r8,7
       vmovdqu32 zmm0,[rdx+r8+10]
       vmovdqu32 [rsp+468],zmm0
       vmovdqu32 zmm0,[rdx+r8+50]
       vmovdqu32 [rsp+4A8],zmm0
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L01
       lea       edx,[rsi+1]
       shl       rdx,7
       vmovdqu32 zmm0,[rcx+rdx+10]
       vmovdqu32 [rsp+3E8],zmm0
       vmovdqu32 zmm0,[rcx+rdx+50]
       vmovdqu32 [rsp+428],zmm0
       mov       rbp,[rsp+468]
       mov       r14,[rsp+3E8]
       mov       r15,[rsp+3F0]
       mov       r13,[rsp+3F8]
       mov       r12,[rsp+400]
       imul      r14,rbp
       imul      r15,rbp
       imul      r13,rbp
       imul      rbp,r12
       mov       r12,[rsp+470]
       mov       rax,[rsp+408]
       mov       r10,[rsp+410]
       mov       r11,[rsp+418]
       mov       r9,[rsp+420]
       imul      rax,r12
       imul      r10,r12
       imul      r11,r12
       imul      r12,r9
       add       r14,rax
       add       r15,r10
       add       r13,r11
       add       rbp,r12
       mov       r12,[rsp+478]
       mov       rax,[rsp+428]
       mov       r10,[rsp+430]
       mov       r11,[rsp+438]
       mov       r9,[rsp+440]
       imul      rax,r12
       imul      r10,r12
       imul      r11,r12
       imul      r12,r9
       add       r14,rax
       add       r15,r10
       add       r13,r11
       add       rbp,r12
       mov       rcx,[rsp+480]
       mov       rdx,[rsp+448]
       mov       r8,[rsp+450]
       mov       r9,[rsp+458]
       mov       rax,[rsp+460]
       imul      rdx,rcx
       imul      r8,rcx
       imul      r9,rcx
       imul      rcx,rax
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       mov       [rsp+20],rcx
       lea       rcx,[rsp+0A8]
       call      qword ptr [7FF7FD8A49A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]]..ctor(Int64, Int64, Int64, Int64)
       mov       rdx,[rsp+0A8]
       mov       r8,[rsp+0B0]
       mov       r9,[rsp+0B8]
       mov       rcx,[rsp+0C0]
       add       rdx,r14
       add       r8,r15
       add       r9,r13
       add       rcx,rbp
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+88],ymm0
       mov       [rsp+20],rcx
       lea       rcx,[rsp+88]
       call      qword ptr [7FF7FD8A49A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]]..ctor(Int64, Int64, Int64, Int64)
       vmovdqu   ymm0,ymmword ptr [rsp+88]
       vmovdqu   ymmword ptr [rsp+3C8],ymm0
       mov       rcx,[rsp+488]
       mov       rdx,[rsp+3E8]
       mov       r8,[rsp+3F0]
       mov       r9,[rsp+3F8]
       mov       rax,[rsp+400]
       imul      rdx,rcx
       imul      r8,rcx
       imul      r9,rcx
       imul      rcx,rax
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+68],ymm0
       mov       [rsp+20],rcx
       lea       rcx,[rsp+68]
       call      qword ptr [7FF7FD8A49A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]]..ctor(Int64, Int64, Int64, Int64)
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+3A8],ymm0
       mov       rbp,[rsp+490]
       mov       rcx,[rsp+408]
       mov       r14,[rsp+410]
       mov       r15,[rsp+418]
       mov       r13,[rsp+420]
       mov       rdx,rbp
       call      qword ptr [7FF7FD8A4618]; Silk.NET.Maths.Scalar.<Multiply>g__SByte|24_3[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       r12,rax
       mov       rcx,r14
       mov       rdx,rbp
       call      qword ptr [7FF7FD8A4558]; Silk.NET.Maths.Scalar.Multiply[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       r14,rax
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [7FF7FD8A4558]; Silk.NET.Maths.Scalar.Multiply[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       r15,rax
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+48],ymm0
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [7FF7FD8A4558]; Silk.NET.Maths.Scalar.Multiply[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       mov       rdx,r12
       mov       r8,r14
       mov       r9,r15
       call      qword ptr [7FF7FD8A49A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]]..ctor(Int64, Int64, Int64, Int64)
       vmovdqu   ymm0,ymmword ptr [rsp+48]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       lea       r8,[rsp+28]
       lea       rdx,[rsp+3A8]
       lea       rcx,[rsp+388]
       call      qword ptr [7FF7FD8A43D8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+468]
       call      qword ptr [7FF7FD8A4450]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M23()
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rsp+428]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+368]
       call      qword ptr [7FF7FD8A43A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+348]
       lea       rdx,[rsp+388]
       lea       r8,[rsp+368]
       call      qword ptr [7FF7FD8A43D8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+468]
       call      qword ptr [7FF7FD8A4468]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M24()
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rsp+448]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+328]
       call      qword ptr [7FF7FD8A43A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+308]
       lea       rdx,[rsp+348]
       lea       r8,[rsp+328]
       call      qword ptr [7FF7FD8A43D8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+468]
       call      qword ptr [7FF7FD8A4480]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M31()
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rsp+3E8]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+2E8]
       call      qword ptr [7FF7FD8A43A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+468]
       call      qword ptr [7FF7FD8A4498]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M32()
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rsp+408]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+2C8]
       call      qword ptr [7FF7FD8A43A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+2A8]
       lea       rdx,[rsp+2E8]
       lea       r8,[rsp+2C8]
       call      qword ptr [7FF7FD8A43D8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+468]
       call      qword ptr [7FF7FD8A44B0]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M33()
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rsp+428]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+288]
       call      qword ptr [7FF7FD8A43A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+268]
       lea       rdx,[rsp+2A8]
       lea       r8,[rsp+288]
       call      qword ptr [7FF7FD8A43D8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+468]
       call      qword ptr [7FF7FD8A44C8]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M34()
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rsp+448]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+248]
       call      qword ptr [7FF7FD8A43A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+228]
       lea       rdx,[rsp+268]
       lea       r8,[rsp+248]
       call      qword ptr [7FF7FD8A43D8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+468]
       call      qword ptr [7FF7FD8A44E0]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M41()
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rsp+3E8]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+208]
       call      qword ptr [7FF7FD8A43A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+468]
       call      qword ptr [7FF7FD8A44F8]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M42()
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rsp+408]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+1E8]
       call      qword ptr [7FF7FD8A43A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+1C8]
       lea       rdx,[rsp+208]
       lea       r8,[rsp+1E8]
       call      qword ptr [7FF7FD8A43D8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+468]
       call      qword ptr [7FF7FD8A4510]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M43()
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rsp+428]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+1A8]
       call      qword ptr [7FF7FD8A43A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+188]
       lea       rdx,[rsp+1C8]
       lea       r8,[rsp+1A8]
       call      qword ptr [7FF7FD8A43D8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+468]
       call      qword ptr [7FF7FD8A4528]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M44()
       mov       rdx,rax
       lea       rcx,[rsp+168]
       lea       r8,[rsp+448]
       call      qword ptr [7FF7FD8A43A8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu32 [rsp+0E8],zmm0
       vmovdqu32 [rsp+128],zmm0
       lea       rcx,[rsp+0C8]
       lea       rdx,[rsp+188]
       lea       r8,[rsp+168]
       call      qword ptr [7FF7FD8A43D8]; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       lea       rcx,[rsp+0C8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+0E8]
       lea       rdx,[rsp+3C8]
       lea       r8,[rsp+308]
       lea       r9,[rsp+228]
       call      qword ptr [7FF7FD8A4540]; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       cmp       esi,[rdi+8]
       jae       short M00_L01
       mov       rax,rsi
       shl       rax,7
       vmovdqu32 zmm0,[rsp+0E8]
       vmovdqu32 [rdi+rax+10],zmm0
       vmovdqu32 zmm0,[rsp+128]
       vmovdqu32 [rdi+rax+50],zmm0
       inc       esi
       cmp       esi,1869F
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,4E8
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
; Total bytes of code 1711
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]]..ctor(Int64, Int64, Int64, Int64)
       mov       [rcx],rdx
       mov       [rcx+8],r8
       mov       [rcx+10],r9
       mov       rax,[rsp+28]
       mov       [rcx+18],rax
       ret
; Total bytes of code 21
```
```assembly
; Silk.NET.Maths.Scalar.<Multiply>g__SByte|24_3[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       rax,rcx
       imul      rax,rdx
       ret
; Total bytes of code 8
```
```assembly
; Silk.NET.Maths.Scalar.Multiply[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       rax,rcx
       imul      rax,rdx
       ret
; Total bytes of code 8
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Addition(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       mov       rax,[rdx]
       add       rax,[r8]
       mov       r10,[rdx+8]
       add       r10,[r8+8]
       mov       r9,[rdx+10]
       add       r9,[r8+10]
       mov       rdx,[rdx+18]
       add       rdx,[r8+18]
       mov       [rcx],rax
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rdx
       mov       rax,rcx
       ret
; Total bytes of code 49
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M23()
       mov       rax,[rcx+30]
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Vector4D`1[[System.Int64, System.Private.CoreLib]].op_Multiply(Int64, Silk.NET.Maths.Vector4D`1<Int64>)
       mov       rax,rdx
       imul      rax,[r8]
       mov       r10,rdx
       imul      r10,[r8+8]
       mov       r9,rdx
       imul      r9,[r8+10]
       imul      rdx,[r8+18]
       mov       [rcx],rax
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rdx
       mov       rax,rcx
       ret
; Total bytes of code 47
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M24()
       mov       rax,[rcx+38]
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M31()
       mov       rax,[rcx+40]
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M32()
       mov       rax,[rcx+48]
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M33()
       mov       rax,[rcx+50]
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M34()
       mov       rax,[rcx+58]
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M41()
       mov       rax,[rcx+60]
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M42()
       mov       rax,[rcx+68]
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M43()
       mov       rax,[rcx+70]
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]].get_M44()
       mov       rax,[rcx+78]
       ret
; Total bytes of code 5
```
```assembly
; Silk.NET.Maths.Matrix4X4`1[[System.Int64, System.Private.CoreLib]]..ctor(Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>, Silk.NET.Maths.Vector4D`1<Int64>)
       mov       rax,[rsp+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [rcx+40],ymm0
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rcx+60],ymm0
       vzeroupper
       ret
; Total bytes of code 46
```

