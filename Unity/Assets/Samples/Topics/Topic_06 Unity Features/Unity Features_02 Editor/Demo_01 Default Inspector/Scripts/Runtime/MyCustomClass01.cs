using UnityEngine;

namespace RMC.BestPractices.Features.EditorScripting.Demo_02_CustomInspector
{
	/// <summary>
	/// SERIALIZATION
	/// 
	/// In Inspector window. The inspector window doesn’t talk to the C# api to
	/// figure out what the values of the properties of whatever it is inspecting is.
	/// It asks the object to serialize itself, and then displays the serialized data.
	///
	/// See <a href="https://blogs.unity3d.com/2014/06/24/serialization-in-unity/">blog</a>.
	/// </summary>
	public class MyCustomClass01 : MonoBehaviour
	{
		// Publics are serialized automatically. Add [NonSerialized] to force it.
		public int CurrentLevel;
		public Vector3 CurrentPosition;
		
		// Private are NOT serialized automatically. Add [SerializeField] to force it.
		private float _previousHealth;
		private Vector3 _previousPosition;
	}
}