using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace RMC.BestPractices.Shared
{
	[Serializable]
	public class DemoData
	{
		public string Title = "Play Scene";
		public string Instructions = "See Unity Console Window";
	}
	
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class BaseDemo : MonoBehaviour
	{
		[Header("Base")]
		[SerializeField]
		private Common _common = null;

		[SerializeField]
		private DemoData _demoData = null;

		protected virtual void Awake()
		{
			Assert.IsNotNull(_common, $"Common is required. Assign in the Unity Editor.");
			Assert.IsNotNull(_demoData, $"DemoData is required. Assign in the Unity Editor.");
		}

		protected virtual void OnValidate()
		{
			if (Application.isPlaying)
			{
				//UI Toolkit cannot handle this, so return
				return;
			}
			SetUI();
		}
		
		protected virtual void Start()
		{
			SetUI();
		}

		private void SetUI()
		{
			if (_common?.UI?.TitleLabel == null || _common?.UI?.InstructionsLabel == null)
			{
				return;
			}
			_common.UI.TitleLabel.text = $"{this.GetType().Name}";
			_common.UI.InstructionsLabel.text = $"{_demoData.Title}\n{_demoData.Instructions}";
		}
	}
}