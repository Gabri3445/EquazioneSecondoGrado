``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-3770 CPU 3.40GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


```
|    Method |     Mean |    Error |   StdDev |  Gen 0 |  Gen 1 | Allocated |
|---------- |---------:|---------:|---------:|-------:|-------:|----------:|
| WriteFile | 469.5 μs | 13.36 μs | 38.98 μs | 2.9297 | 1.4648 |     13 KB |
