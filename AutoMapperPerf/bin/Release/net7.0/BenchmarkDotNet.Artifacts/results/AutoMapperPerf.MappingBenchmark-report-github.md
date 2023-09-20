```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-8400 CPU 2.80GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK 7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
| Method                        | Mean      | Error    | StdDev   |
|------------------------------ |----------:|---------:|---------:|
| AutoMapperMapping             | 180.01 ns | 0.713 ns | 0.595 ns |
| StaticImplicitOperatorMapping |  21.62 ns | 0.498 ns | 1.154 ns |
