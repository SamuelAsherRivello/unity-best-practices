using System.Collections.Generic;
using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Flyweight
{
	/// <summary>
	/// Use sharing to support large numbers of fine-grained objects efficiently.
	/// See <a href="https://www.dofactory.com/net/flyweight-design-pattern">docs</a>.
	/// </summary>
	public class FlyweightPattern : BaseDemo
	{
		[Header("Demo")]
		[SerializeField]
		private Orbiter _prefab = null;

		[SerializeField]
		private Vector3 _centerPoint = Vector3.zero;

		private List<Orbiter> _orbiterList = new List<Orbiter>();

		private float _angle = 0;
		private float _angleOffset = 0;
		private const float Radius = 1;

		protected override void Start()
		{
			// Must call base
			base.Start();

			FlyweightFactory flyweightFactory = new FlyweightFactory(_prefab.gameObject);

			_orbiterList.Add(flyweightFactory.CreateOrbiter());
			_orbiterList.Add(flyweightFactory.CreateOrbiter());
			_orbiterList.Add(flyweightFactory.CreateOrbiter());
			_orbiterList.Add(flyweightFactory.CreateOrbiter());
			_orbiterList.Add(flyweightFactory.CreateOrbiter());
			_orbiterList.Add(flyweightFactory.CreateOrbiter());

			_angleOffset = 2 * Mathf.PI / _orbiterList.Count;
		}

		protected void Update()
		{
			_angle += Time.deltaTime * 1f;

			float localAngle = _angle;
			foreach (Orbiter orbiter in _orbiterList)
			{
				float x = Mathf.Sin(localAngle) * Radius;
				float y = Mathf.Cos(localAngle) * Radius;
				float z = _centerPoint.z;

				orbiter.transform.position = _centerPoint + new Vector3(x, y, z);
				localAngle += _angleOffset;
			}
		}
	}
}