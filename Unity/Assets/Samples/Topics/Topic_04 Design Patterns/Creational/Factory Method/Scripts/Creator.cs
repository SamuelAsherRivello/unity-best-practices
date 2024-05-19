using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.CreationalPatterns.FactoryMethodPattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public abstract class Creator
	{
		public Creator ()
		{
		}

		public abstract Product FactoryMethod();
	}
}