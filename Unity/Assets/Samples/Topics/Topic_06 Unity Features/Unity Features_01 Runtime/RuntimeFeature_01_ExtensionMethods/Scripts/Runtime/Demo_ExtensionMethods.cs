using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.Features.EditorScripting.Demo_01_ExtensionMethods
{
	/// <summary>
	/// Want to 'add methods' to a class WITHOUT editing it? Use Extension methods.
	///
	/// NOTE: This is especially useful to add methods to (uneditable) Unity classes like Transform.
	/// 
	/// </summary>
	public class Demo_ExtensionMethods : BaseDemo
	{
		//[Header("Demo")]
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			transform.position = new Vector3(10, 11, 12);
			
			Debug.Log("Before: " + transform.position);
			
			transform.ResetPositionXYZ();
			
			Debug.Log("After: " + transform.position);
			
		}
	}
}