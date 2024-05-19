using UnityEditor;
using UnityEngine;

namespace RMC.BestPractices.Features.EditorScripting.Demo_01_DefaultInspector
{
	/// <summary>
	/// Here we render the default via "DrawDefaultInspector"
	/// Then we can add custom code above/below.
	///
	/// NOTE: This workflow is best when you want 100% of the default inspector
	/// *PLUS* some other fields.
	/// 
	/// </summary>
	[CustomEditor(typeof(MyCustomClass02))]
	public class MyCustomClass02Editor : Editor
	{
		public override void OnInspectorGUI()
		{
			// FIRST: Add non editable text area
			bool enabled = GUI.enabled;
			GUI.enabled = false;
			EditorGUILayout.TextArea("Hello!");
			GUI.enabled = enabled;
			
			// Add the complete, default inspector
			DrawDefaultInspector();
			
			// LAST: Add non editable help box
			EditorGUILayout.HelpBox("This is a HelpBox.", MessageType.Info);
		}
	}
}