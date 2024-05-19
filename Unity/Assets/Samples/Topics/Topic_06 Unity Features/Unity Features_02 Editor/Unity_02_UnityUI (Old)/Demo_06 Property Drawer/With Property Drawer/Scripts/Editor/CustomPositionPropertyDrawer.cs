using UnityEditor;
using UnityEngine;

namespace RMC.BestPractices.Features.EditorScripting.Demo_07_PropertyDrawer
{
	/// <summary>
	/// </summary>
	
	[CustomPropertyDrawer(typeof(CustomPosition))]
	public class CustomPositionPropertyDrawer : PropertyDrawer
	{
		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			// We render 1-line tall. Default
			return base.GetPropertyHeight(property, label);
			
			// Want 3 lines tall?
			//return EditorGUIUtility.singleLineHeight * 3;
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			// Using BeginProperty / EndProperty on the parent property means that
			// prefab override logic works on the entire property.
			EditorGUI.BeginProperty(position, label, property);

			// Draw label
			position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

			int hElementCount = 5;
			position.width = position.width/hElementCount;
			position.height = EditorGUIUtility.singleLineHeight;
			float gap = position.width;

			// Draw fields - GUIContent.none means NO labels
			EditorGUI.PropertyField(position, property.FindPropertyRelative("X"), new GUIContent("", "X"));
			position.x += gap;
			EditorGUI.PropertyField(position, property.FindPropertyRelative("Y"), new GUIContent("", "Y"));
			position.x += gap;
			EditorGUI.PropertyField(position, property.FindPropertyRelative("Z"), new GUIContent("", "Z"));
			position.x += gap;
			EditorGUI.PropertyField(position, property.FindPropertyRelative("Depth"), new GUIContent("", "Depth"));
			position.x += gap;
			
			if (GUI.Button(position, "R"))
			{
				property.FindPropertyRelative("X").floatValue = 0;
				property.FindPropertyRelative("Y").floatValue = 0;
				property.FindPropertyRelative("Z").floatValue = 0;
				property.FindPropertyRelative("Depth").floatValue = 0;
			}
			
			EditorGUI.EndProperty();
		}
	}
}