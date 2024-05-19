#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.CreationalPatterns.SingletonPattern.ScriptableSingletons
{
	[FilePath("RMC/MyScriptableSingleton.foo", FilePathAttribute.Location.ProjectFolder)]
	public class MyScriptableSingleton : ScriptableSingleton<MyScriptableSingleton>
	
	{
		// Public access - as getter only
		public string AppId { get { return _appId; }}
		public int Counter { get { return _counter; } }
		
		// Set via inspector
		[SerializeField]
		private string _appId = "perhaps set via inspector";
		
		// Set via method
		[SerializeField]
		[HideInInspector]
		private int _counter = 00;

		public void IncrementSomeCounter()
		{
			_counter += 1;
			Save(true);
		}

		public void Log()
		{
			Debug.Log($"MyScriptableSingleton path={GetFilePath()}");
			Debug.Log($"MyScriptableSingleton json...\n\n{JsonUtility.ToJson(this, true)}");
		}
	}

}
#endif
