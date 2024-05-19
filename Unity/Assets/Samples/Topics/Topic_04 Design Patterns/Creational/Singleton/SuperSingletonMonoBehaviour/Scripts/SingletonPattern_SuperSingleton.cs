using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.CreationalPatterns.SingletonPattern.SuperSingletonMonoBehaviour
{
	/// <summary>
	/// Ensure a class has only one instance and provide a global point of access to it.
	/// See <a href="https://www.dofactory.com/net/singleton-design-pattern">docs</a>.
	/// </summary>
	public class SingletonPattern_SuperSingleton : BaseDemo
	{
		protected override void Start()
		{
			// Must call base
			base.Start();

			// This is a clean Singleton, PLUS it shows...
			// * How to omit the ".Instance"
			// * How to provide predictable life-cycle for subsystems
			// * How to handle #if UNITY_WEBGL for subsystems
			
			MySuperSingleton.SayHelloWorld();
			MySuperSingleton.SubSystemA.DoThing1();
			MySuperSingleton.SubSystemB.DoThing2();
		}
	}
}