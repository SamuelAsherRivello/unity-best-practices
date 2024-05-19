using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPrinciples.SOLID.WithoutPrinciples
{
	/// <summary>
	/// The intention of these principles is to make software designs more understandable,
	/// easier to maintain and easier to extend.
	/// As a software engineer, these 5 principles are essential to know!
	/// See <a href="https://itnext.io/solid-principles-explanation-and-examples-715b975dcad4">docs</a>.
	///
	/// NOTE: In this Scene, we show a simple project WITHOUT SOLID principles applied.
	/// 
	/// </summary>
	public class SolidDemo_WithoutPrinciples : BaseDemo
	{
		[Header("Demo")]
		[SerializeField] 
		private GameObject _bulletPrefab = null;

		[SerializeField]
		private GameObject _player = null;

		private Vector3 _settingsBulletForce = new Vector3(0, 300, 0);
		private Vector3 _settingsPlayerResetPosition = new Vector3(0, 0, 0);
		private float _settingsDeltaX = 1;
		private float _settingsDeltaZ = 2;
		private float _settingsBoundsFront = -5;
		private float _settingsBoundsBack = 5;
		private float _settingsBoundsLeft = -5;
		private float _settingsBoundsRight = 5;

		protected void Update()
		{
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				_player.transform.position -= Vector3.back * _settingsDeltaZ;
			}
			
			if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				_player.transform.position += Vector3.back * _settingsDeltaZ;
			}
			
			if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				_player.transform.position += Vector3.left * _settingsDeltaX;
			}
			
			if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				_player.transform.position += Vector3.right * _settingsDeltaX;
			}

			if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)))
			{
				GameObject bullet = Instantiate<GameObject>(_bulletPrefab);
				bullet.transform.position = _player.transform.position + Vector3.up * 1;
				bullet.GetComponent<Rigidbody>().AddForce(_settingsBulletForce);
			}

			if (_player.transform.position.x > _settingsBoundsRight ||
			    _player.transform.position.x < _settingsBoundsLeft ||
			    _player.transform.position.z > _settingsBoundsBack ||
			    _player.transform.position.z < _settingsBoundsFront)
			{
				_player.transform.position = _settingsPlayerResetPosition;
				Debug.Log("You moved too far. Resetting :)");
			}
		}
	}
}