using RMC.BestPractices.Shared;
using UnityEditor;

namespace RMC.BestPractices.Features.EditorScripting.Demo_09_CustomWindow
{
	/// <summary>
	/// Render menu items in the top-bar Unity app menu.
	/// 
	/// You can add keyboard shortcuts too.
	/// See <a href="https://learn.unity.com/tutorial/editor-scripting#5c7f8528edbc2a002053b5f9">article</a>.
	/// 
	/// </summary>
	public class CustomMenuItem : Editor
	{
		// SHOW MENU ITEM
		[MenuItem(BestPracticesConstants.MenuItemPath + 
			"Features/EditorScripting/Demo_09_CustomWindow/Open Custom Window", priority = 0)]
		private static void OpenCustomWindow()
		{
			MyCustomEditorWindow.ShowWindow();
		}

	}
}