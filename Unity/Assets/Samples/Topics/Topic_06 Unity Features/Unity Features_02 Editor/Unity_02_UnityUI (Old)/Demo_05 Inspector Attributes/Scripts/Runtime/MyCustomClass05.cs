using UnityEngine;

namespace RMC.BestPractices.Features.EditorScripting.Demo_05_InspectorAttributes
{
	/// <summary>
	/// </summary>
	public class MyCustomClass05 : MonoBehaviour
	{
		[Header("Main Fields")]
		
		[Range(0,10)]
		public int CurrentLevel;
		
		[Header("Other Fields")]
		
		public Vector3 CurrentPosition;
		
	}
}