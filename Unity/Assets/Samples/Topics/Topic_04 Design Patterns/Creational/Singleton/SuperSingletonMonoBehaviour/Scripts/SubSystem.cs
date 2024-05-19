
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.CreationalPatterns.SingletonPattern.SuperSingletonMonoBehaviour
{
	/// <summary>
	///  Some examples of arbitrary systems under the SuperSingleton
	/// </summary>
	public class SubSystem
	{
		//  Properties ---------------------------------------------
		public bool IsInstantiated { get { return _isInstantiated;}}

		//  Fields -------------------------------------------------
		private bool _isInstantiated = false;

		//  Instantiation ------------------------------------------
		public void Instantiate()
		{
			if (!IsInstantiated)
			{
				_isInstantiated = true;
			}
		}
	}
	
	public class SubSystemA : SubSystem
	{
		//  Public Methods ------------------------------------------
		public void DoThing1()
		{
			Debug.Log("DoThing1!");
		}
		
		public void DoThing2()
		{
			Debug.Log("DoThing12");
		}
	}
	
	public class SubSystemB : SubSystem
	{
		//  Public Methods ------------------------------------------
		
#if UNITY_WEBGL 
		public void DoThing1()
		{
			//Blah, for WEBGL
			Debug.Log("DoThing1!");
		}
#else
		public void DoThing1()
		{
			//Blah
			Debug.Log("DoThing1!");
		}
#endif
		
		public void DoThing2()
		{
			Debug.Log("DoThing2!");
		}
	}
}

