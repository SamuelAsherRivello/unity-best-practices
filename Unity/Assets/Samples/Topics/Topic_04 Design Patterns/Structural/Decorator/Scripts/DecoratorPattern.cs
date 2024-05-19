using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// Attach additional responsibilities to an object dynamically. 
	/// Decorators provide a flexible alternative to subclassing for extending functionality.
	/// See <a href="https://www.dofactory.com/net/decorator-design-pattern">docs</a>.
	/// </summary>
	public class DecoratorPattern : BaseDemo
	{
		[Header("Demo")]
		[SerializeField]
		private Shape _shape01 = null;

		[SerializeField]
		private Shape _shape02 = null;

		[SerializeField]
		private Shape _shape03 = null;

		[SerializeField]
		private Shape _shape04 = null;

		protected override void Start()
		{
			// Must call base
			base.Start();

			// Regular
			_shape01.DrawMe();

			// Slender
			SlenderShapeDecorator slenderShapeDecorator02 = new SlenderShapeDecorator(_shape02);
			slenderShapeDecorator02.DrawMe();

			// Tiny
			TinyShapeDecorator tinyShapeDecorator03 = new TinyShapeDecorator(_shape03);
			tinyShapeDecorator03.DrawMe();

			// Multiple Decorators
			SlenderShapeDecorator slenderShapeDecorator04 = new SlenderShapeDecorator(_shape04);
			TinyShapeDecorator tinyShapeDecorator04 = new TinyShapeDecorator(slenderShapeDecorator04);
			tinyShapeDecorator04.DrawMe();
		}
	}
}