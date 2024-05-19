using UnityEngine;

namespace RMC.BestPractices.Features.UnitTesting.Calculator_01Start
{
	/// <summary>
	/// 
	/// </summary>
	[System.Serializable]
	public class Calculator
	{
		// This is an example of a SerializeField. Keep.
		[SerializeField]
		private float DefaultReturnValue = 0;
		
		public Calculator()
		{
			DefaultReturnValue = 0; 
		}
		
		public float Add (float operand01, float operand02)
		{
			return DefaultReturnValue;
		}
		
		public float Subtract (float operand01, float operand02)
		{
			return DefaultReturnValue;
		}
	}
}