using FluentAssertions;
#if (netframework)
using Xunit;

#endif
#if (netcore)
namespace Peeveen.ClassLibrary.Test;

public class MyDemoClassTests {
	[Fact]
	public void Test1() {
		var obj = new MyDemoClass(3);
		var result = obj.Add(100,23);
		result.Should().Be(369);
	}
}
#else
namespace Peeveen.ClassLibrary.Test
{
	public class MyDemoClassTests
	{
		[Fact]
		public void Test1()
		{
			var obj = new MyDemoClass(3);
			var result = obj.Add(100, 23);
			result.Should().Be(369);
		}
	}
}
#endif