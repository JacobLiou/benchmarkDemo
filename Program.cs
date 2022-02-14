using BenchmarkDotNet.Running;
using benchmarkDemo;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
 var summary = BenchmarkRunner.Run<Md5VsSha256>();