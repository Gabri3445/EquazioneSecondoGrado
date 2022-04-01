﻿global using BenchmarkDotNet.Attributes;
global using BenchmarkDotNet.Configs;
global using BenchmarkDotNet.Diagnosers;
global using BenchmarkDotNet.Exporters;
global using BenchmarkDotNet.Jobs;
global using BenchmarkDotNet.Running;
global using BenchmarkDotNet.Validators;
using DividersBench;

var summary = BenchmarkRunner.Run(typeof(Backend));
