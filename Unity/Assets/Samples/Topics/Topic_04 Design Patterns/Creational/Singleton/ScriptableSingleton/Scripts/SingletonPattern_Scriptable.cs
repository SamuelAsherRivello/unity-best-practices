using RMC.BestPractices.Shared;

namespace RMC.BestPractices.DesignPatterns.CreationalPatterns.SingletonPattern.ScriptableSingletons
{
	/// <summary>
	/// Ensure a class has only one instance and provide a global point of access to it.
	/// See <a href="https://www.dofactory.com/net/singleton-design-pattern">docs</a>.
	/// </summary>
	public class SingletonPattern_Scriptable : BaseDemo
	{
		//[Header("Demo")]
		
		protected override void Start()
		{
			// Must call base
			base.Start();

			// Singleton ScriptableObject
			// -- Writes to local path
			
			
#if UNITY_EDITOR
			MyScriptableSingleton.instance.Log();
			MyScriptableSingleton.instance.IncrementSomeCounter();
			MyScriptableSingleton.instance.Log();
#endif
			
			
		}
	}
}