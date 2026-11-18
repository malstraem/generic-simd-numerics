## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.9974)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
Memory: 31,14 GB Total, 18,04 GB Available
.NET SDK 11.0.100
  [Host]     : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4
  Job-IHFIKV : .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4

Runtime=.NET 11.0  
```

| Method  | Mean     | Error   | StdDev  | Code Size |
|-------- |---------:|--------:|--------:|----------:|
| Convert | 123.7 μs | 0.25 μs | 0.19 μs |     120 B |
| Back    | 141.2 μs | 0.15 μs | 0.14 μs |     240 B |

```assembly
; System.Numerics.Bench.StressConversionMat44`2[[System.Int32, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short 0000000000005F12
       mov       r10,rax
       shl       r10,6
       lea       r8,[r8+r10+10]
       vmovups   xmm0,[r8]
       vmovups   xmm1,[r8+10]
       vmovups   xmm2,[r8+20]
       vmovups   xmm3,[r8+30]
       cmp       eax,[rdx+8]
       jae       short 0000000000005F12
       lea       rdx,[rdx+r10+10]
       vcvtdq2ps xmm0,xmm0
       vmovups   [rdx],xmm0
       vcvtdq2ps xmm0,xmm1
       vmovups   [rdx+10],xmm0
       vcvtdq2ps xmm0,xmm2
       vmovups   [rdx+20],xmm0
       vcvtdq2ps xmm0,xmm3
       vmovups   [rdx+30],xmm0
       inc       eax
       cmp       eax,186A0
       jl        short 0000000000005EA6
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 120
```

```assembly
; System.Numerics.Bench.StressConversionMat44`2[[System.Int32, System.Private.CoreLib],[System.Single, System.Private.CoreLib]].Back()
       sub       rsp,28
       vbroadcastss xmm0,dword ptr [5ED0]
       vbroadcastss xmm1,dword ptr [5ED4]
       vbroadcastss xmm2,dword ptr [5ED8]
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+8]
       mov       r8,[rcx+10]
       cmp       eax,[r8+8]
       jae       near ptr 0000000000005ECA
       mov       r10,rax
       shl       r10,6
       lea       r8,[r8+r10+10]
       vmovups   xmm3,[r8]
       vmovups   xmm4,[r8+10]
       vmovups   xmm5,[r8+20]
       vmovups   xmm16,[r8+30]
       vfixupimmps xmm3,xmm3,xmm0,0
       vcmpgeps  k1,xmm3,xmm1
       vcvttps2dq xmm3,xmm3
       vblendmps xmm3{k1},xmm3,xmm2
       vfixupimmps xmm4,xmm4,xmm0,0
       vcmpgeps  k1,xmm4,xmm1
       vcvttps2dq xmm4,xmm4
       vblendmps xmm4{k1},xmm4,xmm2
       vfixupimmps xmm5,xmm5,xmm0,0
       vcmpgeps  k1,xmm5,xmm1
       vcvttps2dq xmm5,xmm5
       vblendmps xmm5{k1},xmm5,xmm2
       vfixupimmps xmm16,xmm16,xmm0,0
       vcmpgeps  k1,xmm16,xmm1
       vcvttps2dq xmm16,xmm16
       vblendmps xmm16{k1},xmm16,xmm2
       cmp       eax,[rdx+8]
       jae       short 0000000000005ECA
       lea       rdx,[rdx+r10+10]
       vmovups   [rdx],xmm3
       vmovups   [rdx+10],xmm4
       vmovups   [rdx+20],xmm5
       vmovups   [rdx+30],xmm16
       inc       eax
       cmp       eax,186A0
       jl        near ptr 0000000000005E01
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 240
```
