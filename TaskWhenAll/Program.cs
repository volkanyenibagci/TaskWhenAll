// See https://aka.ms/new-console-template for more information
using TaskWhenAll;

Console.WriteLine("TASKWHENALL!");
var sw = new System.Diagnostics.Stopwatch();
sw.Start();
await new FirstAsync().FirstMethodAsync();
await new SecondAsync().SecondMethodAsync();
sw.Stop();
Console.WriteLine($"Elapsed time: {sw.ElapsedMilliseconds}ms");




//var sw = new System.Diagnostics.Stopwatch();
//sw.Start();
//await Task.WhenAll(new FirstAsync().FirstMethodAsync(), new SecondAsync().SecondMethodAsync());
//sw.Stop();
//Console.WriteLine($"Elapsed time: {sw.ElapsedMilliseconds}ms");

