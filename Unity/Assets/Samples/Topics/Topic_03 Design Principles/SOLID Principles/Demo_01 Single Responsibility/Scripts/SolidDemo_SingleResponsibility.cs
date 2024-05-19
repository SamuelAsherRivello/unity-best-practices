using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPrinciples.SOLID.SingleResponsibilityPrinciple
{
	/// <summary>
	/// The intention of these principles is to make software designs more understandable,
	/// easier to maintain and easier to extend.
	/// As a software engineer, these 5 principles are essential to know!
	/// See <a href="https://itnext.io/solid-principles-explanation-and-examples-715b975dcad4">docs</a>.
	///
	/// NOTE: In this Scene, we show the (S)ingle Responsibility principle.
	/// 
	/// </summary>
	public class SolidDemo_SingleResponsibility : BaseDemo
	{
		[Header("Demo")]
		[SerializeField] 
		private GameObject _bulletPrefab = null;

		[SerializeField]
		private GameObject _player = null;

		private PlayerMover _playerMover;
		private PlayerBoundsChecker _playerBoundsChecker;

		protected override void Start()
		{
			// Must call base
			base.Start();

			_playerMover = new PlayerMover(_player, _bulletPrefab);
			_playerBoundsChecker = new PlayerBoundsChecker(_player, _bulletPrefab);
		}
		
		protected void Update()
		{
			_playerMover.MovePlayer();
			_playerBoundsChecker.CheckBounds();
		}
	}

	public class PlayerBoundsChecker
	{
		private Vector3 _settingsPlayerResetPosition = new Vector3(0, 0, 0);
		private float _settingsBoundsFront = -5;
		private float _settingsBoundsBack = 5;
		private float _settingsBoundsLeft = -5;
		private float _settingsBoundsRight = 5;
		
		private GameObject _player;
		private GameObject _bulletPrefab = null;
		
		public PlayerBoundsChecker(GameObject player, GameObject bulletPrefab)
		{
			_player = player;
			_bulletPrefab = bulletPrefab;
		}
		
		public void CheckBounds()
		{
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
	public class PlayerMover
	{
		private Vector3 _settingsBulletForce = new Vector3(0, 300, 0);
		
		private float _settingsDeltaX = 1;
		private float _settingsDeltaZ = 2;

		private GameObject _player = null;
		private GameObject _bulletPrefab = null;
		
		public PlayerMover(GameObject player, GameObject bulletPrefab)
		{
			_player = player;
			_bulletPrefab = bulletPrefab;
		}
		
		public void MovePlayer()
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
				GameObject bullet = GameObject.Instantiate<GameObject>(_bulletPrefab);
				bullet.transform.position = _player.transform.position + Vector3.up * 1;
				bullet.GetComponent<Rigidbody>().AddForce(_settingsBulletForce);
			}
		}
	}

}