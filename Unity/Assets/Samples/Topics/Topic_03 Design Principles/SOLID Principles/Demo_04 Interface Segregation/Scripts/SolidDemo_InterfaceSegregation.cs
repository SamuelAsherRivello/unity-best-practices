using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPrinciples.SOLID.InterfaceSegregationPrinciple
{
	/// <summary>
	/// The intention of these principles is to make software designs more understandable,
	/// easier to maintain and easier to extend.
	/// As a software engineer, these 5 principles are essential to know!
	/// See <a href="https://itnext.io/solid-principles-explanation-and-examples-715b975dcad4">docs</a>.
	///
	/// NOTE: In this Scene, we show the (I)nterface Segregation principle.
	/// 
	/// </summary>
	public class SolidDemo_InterfaceSegregation : BaseDemo
	{
		[Header("Demo")]
		[SerializeField] 
		private GameObject _bulletPrefab = null;

		[SerializeField]
		private GameObject _player = null;

		[SerializeField]
		private IPlayerMover _playerMover;
		
		private IPlayerBoundsChecker _playerBoundsChecker;
		private IPlayerShooter _playerShooter;

		protected override void Start()
		{
			// Must call base
			base.Start();

			_playerMover = new PlayerMover(_player, _bulletPrefab);
			_playerBoundsChecker = new PlayerBoundsChecker(_player, _bulletPrefab);
			_playerShooter = new PlayerShooter(_player, _bulletPrefab);
		}

		protected void Update()
		{
			_playerMover.Move();
			_playerBoundsChecker.Update();
			_playerShooter.Update();
		}
	}

	public interface IPlayerUpdate
	{
		void Update();
	}

	public abstract class PlayerManager : UnityEngine.Object ,IPlayerUpdate
	{
		protected GameObject _player;
		protected GameObject _bulletPrefab = null;

		public PlayerManager(GameObject player, GameObject bulletPrefab)
		{
			_player = player;
			_bulletPrefab = bulletPrefab;
		}

		public abstract void Update();
	}

	
	
	
	
	
	
	
	
	
	
	
	
	
	public interface IPlayerBoundsChecker : IPlayerUpdate
	{
		void CheckBounds();
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	

	public class PlayerBoundsChecker : PlayerManager, IPlayerBoundsChecker
	{
		private readonly Vector3 _settingsPlayerResetPosition = new Vector3(0, 0, 0);
		private readonly float _settingsBoundsFront = -5;
		private readonly float _settingsBoundsBack = 5;
		private readonly float _settingsBoundsLeft = -5;
		private readonly float _settingsBoundsRight = 5;
		
		public PlayerBoundsChecker(GameObject player, GameObject bulletPrefab) : 
			base(player, bulletPrefab)
		{
		}
		
		public override void Update()
		{
			CheckBounds();
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

	public interface IPlayerMover : IPlayerUpdate
	{
		void Move();
	}

	[System.Serializable]
	public class PlayerMover : PlayerManager, IPlayerMover
	{
		private readonly float _settingsDeltaX = 1;
		private readonly float _settingsDeltaZ = 2;
		
		public PlayerMover(GameObject player, GameObject bulletPrefab) : base(player, bulletPrefab)
		{
		}

		public override void Update()
		{
			Move();
		}

		public void Move()
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
		}
	}

	public interface IPlayerShooter : IPlayerUpdate
	{
		void Shoot();
	}

	public class PlayerShooter : PlayerManager, IPlayerShooter
	{
		private readonly Vector3 _settingsBulletForce = new Vector3(0, 300, 0);

		public PlayerShooter(GameObject player, GameObject bulletPrefab) : base(player, bulletPrefab)
		{
		}

		public override void Update()
		{
			if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)))
			{
				Shoot();
			}
		}

		public void Shoot()
		{
			GameObject bullet = GameObject.Instantiate<GameObject>(_bulletPrefab);
			bullet.transform.position = _player.transform.position + Vector3.up * 1;
			bullet.GetComponent<Rigidbody>().AddForce(_settingsBulletForce);
		}
	}
}