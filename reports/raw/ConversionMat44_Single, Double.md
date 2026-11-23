## .NET 11.0.0 (11.0.0, 11.0.26.53018), X64 RyuJIT x86-64-v4 (Job: Job-IHFIKV(Runtime=.NET 11.0))

```
BenchmarkDotNet v0.16.0-preview.2, Windows 11 (10.0.26300.10075)
AMD Ryzen 9 7900X 4.69GHz, 1 CPU, 24 logical and 12 physical cores
```

| Method  | Mean     | Error   | StdDev  | Code Size |
|-------- |---------:|--------:|--------:|----------:|
| Convert | 176.6 μs | 0.44 μs | 0.41 μs |     108 B |
| Back    | 158.2 μs | 0.17 μs | 0.16 μs |     106 B |

```assembly
; System.Numerics.Bench.StressConversionMat44`2[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Convert()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+10]
       mov       r8,[rcx+8]
       cmp       eax,[r8+8]
       jae       short M00_L01
       mov       r10d,eax
       mov       r9,r10
       shl       r9,6
       lea       r8,[r8+r9+10]
       vmovups   ymm0,[r8]
       vmovups   ymm1,[r8+20]
       cmp       eax,[rdx+8]
       jae       short M00_L01
       shl       r10,7
       lea       rdx,[rdx+r10+10]
       vcvtps2pd zmm0,ymm0
       vmovups   [rdx],zmm0
       vcvtps2pd zmm0,ymm1
       vmovups   [rdx+40],zmm0
       inc       eax
       cmp       eax,186A0
       jl        short M00_L00
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 108
```

```assembly
; System.Numerics.Bench.StressConversionMat44`2[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]].Back()
       sub       rsp,28
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+8]
       mov       r8,[rcx+10]
       cmp       eax,[r8+8]
       jae       short 0000000000006204
       mov       r10d,eax
       mov       r9,r10
       shl       r9,7
       lea       r8,[r8+r9+10]
       vmovups   zmm0,[r8]
       vmovups   zmm1,[r8+40]
       cmp       eax,[rdx+8]
       jae       short 0000000000006204
       shl       r10,6
       lea       rdx,[rdx+r10+10]
       vcvtpd2ps ymm0,zmm0
       vmovups   [rdx],ymm0
       vcvtpd2ps ymm0,zmm1
       vmovups   [rdx+20],ymm0
       inc       eax
       cmp       eax,186A0
       jl        short 00000000000061A6
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       call      0000000000001620
       int       3
; Total bytes of code 106
```
