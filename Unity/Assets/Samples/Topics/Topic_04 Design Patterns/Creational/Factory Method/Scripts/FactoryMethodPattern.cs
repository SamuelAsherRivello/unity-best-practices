using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.CreationalPatterns.FactoryMethodPattern
{
	/// <summary>
	/// Define an interface for creating an object, but let subclasses decide which class to instantiate. 
	/// Factory Method lets a class defer instantiation to subclasses.
	/// See <a href="https://www.dofactory.com/net/factory-method-design-pattern">docs</a>.
	/// </summary>
	public class FactoryMethodPattern : BaseDemo
	{
		//[Header("Demo")]
		
		protected override void Start()
		{
			// Must call base
			base.Start();

			CreatorA creatorA = new CreatorA();
			CreatorB creatorB = new CreatorB();

			Product product1 = creatorA.FactoryMethod();
			Product product2 = creatorB.FactoryMethod();

			Debug.Log("Product1: " + product1);
			Debug.Log("Product2: " + product2);
		}
	}
}