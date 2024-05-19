
namespace RMC.BestPractices.DesignPatterns.CreationalPatterns.FactoryMethodPattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public abstract class Product
	{
		public Product()
		{
		}

		public override string ToString()
		{
			return $"[{GetType().Name}]";
		}
	}
}