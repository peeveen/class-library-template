using FluentAssertions;
#if (netframework)
using Xunit;

#endif
#if (netcore)
namespace Peeveen.ClassLibrary.Test;

public class UnitTests {
	[Fact]
	public void Test1() {
		var result = true;
		result.Should().Be(true);
	}
}
#else
namespace Peeveen.ClassLibrary.Test
{
	public class UnitTests
	{
		[Fact]
		public void Test1()
		{
			var result = true;
			result.Should().Be(true);
		}
	}
}
#endif