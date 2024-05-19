
using System;

namespace RMC.BestPractices.Features.EditorScripting.Demo_06_WithoutPropertyDrawer
{
	/// <summary>
	/// </summary>
	
	//This attribute is required so Unity knows you want to render this in inspectors
	[Serializable]
	
	public class CustomPosition
	{
		public float X;
		public float Y;
		public float Z;
		public float Depth;
	}
}