using UnityEngine;

namespace RMC.BestPractices.Shared
{
	public class Common : MonoBehaviour
	{
		public UI UI { get { return _UI; } }
		
		[SerializeField]
		private UI _UI = null;
	}
}