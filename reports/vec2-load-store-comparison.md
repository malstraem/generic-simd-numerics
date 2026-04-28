.NET 10.0.626.17701, X64 RyuJIT x86-64-v4, Windows 11 26200.8246, AMD Ryzen 9 7900X 4.70GHz

# Asm differences for load/store showed with cycle `Add` calling

`Vec2<T>` and `Vec3<T>` have dumb vectorized ways that slower than naive currently

## Reference `System.Numerics.Vector2`

```assembly
       xor       eax,eax
       mov       rcx,187E4800CE0
       mov       rcx,[rcx]
       mov       rdx,187E4800CE8
       mov       rdx,[rdx]
       nop       dword ptr [rax]
M00_L00:
       mov       r8d,eax
       vmovsd    xmm0,qword ptr [rcx+r8*8+10] // nice...
       inc       eax
       mov       r10d,eax
       vmovsd    xmm1,qword ptr [rcx+r10*8+10] // nice...
       vaddps    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rdx+r8*8+10],xmm0 // nice...
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 73
```

## Achieved by [this](../source/reinterpretate/Vec2{T}.DISGUSTING_CARGO_CULT.cs)

### `Vec2<float>`

```assembly
       sub       rsp,18
       xor       eax,eax
       mov       [rsp],rax
       xor       eax,eax
       mov       rcx,25A16C00CE0
       mov       rcx,[rcx]
       mov       rdx,25A16C00CE8
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+10],r10
       inc       eax
       mov       r10d,eax
       mov       r10,[rcx+r10*8+10]
       mov       [rsp+8],r10
       lea       r10,[rsp+10]
       vmovsd    xmm0,qword ptr [r10]   // expected vmovsd, but regs used a lot for addresses :(
       lea       r10,[rsp+8]
       vmovsd    xmm1,qword ptr [r10]
       vaddps    xmm0,xmm0,xmm1         // float add
       vmovsd    qword ptr [rsp],xmm0
       mov       r10,[rsp]
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       add       rsp,18
       ret
; Total bytes of code 116
```

### `Vec2<int>`

```assembly
       sub       rsp,18
       xor       eax,eax
       mov       [rsp],rax
       xor       eax,eax
       mov       rcx,1F93D800CE0
       mov       rcx,[rcx]
       mov       rdx,1F93D800CE8
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+10],r10
       inc       eax
       mov       r10d,eax
       mov       r10,[rcx+r10*8+10]
       mov       [rsp+8],r10
       lea       r10,[rsp+10]
       vmovsd    xmm0,qword ptr [r10]   // expected vmovsd, but regs used a lot for addresses :(
       lea       r10,[rsp+8]
       vmovsd    xmm1,qword ptr [r10]
       vpaddd    xmm0,xmm0,xmm1         // integer add
       vmovsd    qword ptr [rsp],xmm0
       mov       r10,[rsp]
       mov       [rdx+r8*8+10],r10
       cmp       eax,1869F
       jl        short M00_L00
       add       rsp,18
       ret
; Total bytes of code 116
```

## `Vector128.WithElement` produce simple scalar moves/insertions, achieved by [this](../source/reinterpretate/Vec2{T}.Casts.cs) :(

For `Vec3<T>` the problem is the same, cause casts [looks like](../source/reinterpretate/Vec3{T}.Casts.cs)

### `Vec2<float>`

```assembly
       xor       eax,eax
       mov       rcx,2A597400CE0
       mov       rcx,[rcx]
       vmovups   xmm0,[7FFBF2B7A810]
       mov       rdx,2A597400CE8
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       vmovss    xmm1,dword ptr [r10]
       vmovss    xmm2,dword ptr [r10+4]
       inc       eax
       mov       r10d,eax
       lea       r10,[rcx+r10*8+10]
       vmovss    xmm3,dword ptr [r10]
       vmovss    xmm4,dword ptr [r10+4]
       vinsertps xmm1,xmm0,xmm1,0
       vinsertps xmm1,xmm1,xmm2,10
       vinsertps xmm2,xmm0,xmm3,0
       vinsertps xmm2,xmm2,xmm4,10
       vaddps    xmm1,xmm2,xmm1
       vmovaps   xmm2,xmm1
       vmovshdup xmm1,xmm1
       lea       r8,[rdx+r8*8+10]
       vmovss    dword ptr [r8],xmm2
       vmovss    dword ptr [r8+4],xmm1
       cmp       eax,1869F
       jl        short M00_L00
       ret
; Total bytes of code 136
```

### `Vec2<int>`

```assembly
       push      rbx
       xor       eax,eax
       mov       rcx,22147800CE0
       mov       rcx,[rcx]
       vmovups   xmm0,[7FFBF2B6A770]
       mov       rdx,22147800CE8
       mov       rdx,[rdx]
M00_L00:
       mov       r8d,eax
       lea       r10,[rcx+r8*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       inc       eax
       mov       r11d,eax
       lea       r11,[rcx+r11*8+10]
       mov       ebx,[r11]
       mov       r11d,[r11+4]
       vpinsrd   xmm1,xmm0,r9d,0
       vpinsrd   xmm1,xmm1,r10d,1
       vpinsrd   xmm2,xmm0,ebx,0
       vpinsrd   xmm2,xmm2,r11d,1
       vpaddd    xmm1,xmm2,xmm1
       vmovd     r10d,xmm1
       vpextrd   r9d,xmm1,1
       lea       r8,[rdx+r8*8+10]
       mov       [r8],r10d
       mov       [r8+4],r9d
       cmp       eax,1869F
       jl        short M00_L00
       pop       rbx
       ret
; Total bytes of code 129
```
