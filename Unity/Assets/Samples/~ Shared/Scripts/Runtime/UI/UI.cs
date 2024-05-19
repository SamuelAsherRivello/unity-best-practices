using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.BestPractices.Shared
{
	public class UI : MonoBehaviour
	{
		public Label TitleLabel { get { return _uiDocument?.rootVisualElement?.Q<Label>("TitleLabel"); } }
		public Label InstructionsLabel { get { return _uiDocument?.rootVisualElement?.Q<Label>("InstructionsLabel"); } }
		
		[SerializeField]
		private UIDocument _uiDocument = null;

	}
}