
using UnityEngine;

//This hides a harmless warning from the console.
#pragma warning disable 0414
namespace RMC.BestPractices.Features.UnitTesting.Calculator_02Complete
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
			return operand01 + operand02;
		}
		
		public float Subtract (float operand01, float operand02)
		{
			return operand01 - operand02;
		}
	}
}