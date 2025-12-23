using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Peeveen.ClassLibrary.Benchmark;

public class Benchmark
{
	private readonly string variable = "Hi";
	[GlobalSetup]
	public void GlobalSetup()
	{
		Console.Out.WriteLine("Do global setup here ...");
		Console.Out.WriteLine(variable);
	}

	[Benchmark]
	public void MeasureSpeed()
	{
		Console.Out.WriteLine("Run some code here");
		Console.Out.WriteLine(variable);
	}

	[IterationCleanup]
	public void TidyUp()
	{
		Console.Out.WriteLine("Cleanup after each iteration here");
		Console.Out.WriteLine(variable);
	}
}