#if (netcore)
namespace Peeveen.ClassLibrary;

/// <summary>
/// This is a class.
/// </summary>
public class MyDemoClass {
	private readonly int _multiplier;

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="multiplier">Multiplier</param>
	public MyDemoClass(int multiplier) {
		_multiplier=multiplier;
	}
	/// <summary>
	/// Adds two numbers.
	/// </summary>
	/// <param name="x">First number</param>
	/// <param name="y">Second number</param>
	/// <returns>The two numbers added together, multiplied by the multiplier.</returns>
	public int Add(int x, int y) => (x + y) * _multiplier;
}
#else
namespace Peeveen.ClassLibrary
{
	/// <summary>
	/// This is a class.
	/// </summary>
	public class MyDemoClass
	{
		private readonly int _multiplier;

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="multiplier">Multiplier</param>
		public MyDemoClass(int multiplier)
		{
			_multiplier = multiplier;
		}

		/// <summary>
		/// Adds two numbers.
		/// </summary>
		/// <param name="x">First number</param>
		/// <param name="y">Second number</param>
		/// <returns>The two numbers added together, multiplied by the multiplier.</returns>
		public int Add(int x, int y) => (x + y) * _multiplier;
	}
}

#endif