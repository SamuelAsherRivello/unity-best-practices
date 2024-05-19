using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class Shape : MonoBehaviour, IShape
	{
		public Transform Transform { get { return transform; } }

		public void DrawMe()
		{
			
		}
	}
}