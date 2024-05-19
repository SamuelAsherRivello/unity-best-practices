using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.Features.UnitTesting.Calculator_02Complete
{
	/// <summary>
	/// 
	/// </summary>
	public class CalculatorDemo : BaseDemo
	{
		public Calculator Calculator { get { return _calculator; } }

		[Header("Demo")]
		[SerializeField] 
		private Calculator _calculator = null;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_calculator = new Calculator();
			Debug.Log("02 calculator.Add(10, 5) = " + _calculator.Add(10, 5));
			Debug.Log("02 calculator.Subtract(9, 4) = " + _calculator.Subtract(9, 4));
		}
	}
}