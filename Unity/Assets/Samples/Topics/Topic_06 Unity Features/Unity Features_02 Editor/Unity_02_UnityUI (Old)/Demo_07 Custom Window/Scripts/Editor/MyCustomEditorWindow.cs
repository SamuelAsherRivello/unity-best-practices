using RMC.BestPractices.Shared;
using UnityEditor;
using UnityEngine;

namespace RMC.BestPractices.Features.EditorScripting.Demo_09_CustomWindow
{
	public class MyCustomEditorWindow : EditorWindow
	{
		string myString = "Hello World";
		bool groupEnabled;
		bool myBool = true;
		float myFloat = 1.23f;
    
		// Add menu item named "My Window" to the Window menu
		[MenuItem(BestPracticesConstants.MenuItemPath +
			"Features/EditorScripting/Demo_09_CustomWindow/My Window", priority = 0)]
		public static void ShowWindow()
		{
			//Show existing window instance. If one doesn't exist, make one.
			EditorWindow.GetWindow(typeof(MyCustomEditorWindow));
		}
    
		void OnGUI()
		{
			titleContent = new GUIContent("MyCustomEditorWindow")
				;
			GUILayout.Space(10);
			GUILayout.Label ("Base Settings", EditorStyles.boldLabel);
			myString = EditorGUILayout.TextField ("Text Field", myString);
        
			GUILayout.Space(10);
			groupEnabled = EditorGUILayout.BeginToggleGroup ("Optional Settings", groupEnabled);
			myBool = EditorGUILayout.Toggle ("Toggle", myBool);
			myFloat = EditorGUILayout.Slider ("Slider", myFloat, -3, 3);
			EditorGUILayout.EndToggleGroup ();
			
		}
	}
}