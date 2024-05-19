using System;
using UnityEditor;
using UnityEngine;

namespace RMC.BestPractices.Features.EditorScripting.Demo_03_CustomInspector
{
	/// <summary>
	/// Here we render a completely custom inspector.
	///
	/// NOTE: This workflow is best when you want something
	/// heavily customized. This is common.
	///
	/// NOTE: Once you commit to this, you have to maintain this
	/// with whatever changes to fields (which you add/remove) to the CustomClass.
	/// 
	/// </summary>
	[CustomEditor(typeof(MyCustomClass03))]
	public class MyCustomClass03Editor : Editor
	{
		public override void OnInspectorGUI()
		{
			// Get a reference to the object for which we're inspecting
			// * Set/get the values as you like.
			MyCustomClass03 myTarget = (MyCustomClass03)target;
			
			// Some examples of what is possible...

			// 1. Render field with custom label, and validate value as non-negative
			myTarget.CurrentLevel = EditorGUILayout.IntField("Level:", myTarget.CurrentLevel);
			myTarget.CurrentLevel = Math.Max(myTarget.CurrentLevel, 0);
			
			// 2. Render field with custom label, and validate value as non-negative
			myTarget.CurrentPosition = EditorGUILayout.Vector3Field("Position:", myTarget.CurrentPosition);
			
			// 3. Create buttons to call methods/fields on the target
			if(GUILayout.Button("Reset Position"))
			{
				myTarget.CurrentPosition = MyCustomClass03.CurrentPositionDefault;
			}
		}
	}
}