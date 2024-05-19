using System;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class MovementSystem 
	{
		public MovementSystem ()
		{
		}

		public void MoveUp(GameObject player)
		{
			player.transform.position += Vector3.up;
		}

		public void MoveDown(GameObject player)
		{
			player.transform.position += Vector3.down;
		}

		public void MoveLeft(GameObject player)
		{
			player.transform.position += Vector3.left;
		}

		public void MoveRight(GameObject player)
		{
			player.transform.position += Vector3.right;
		}
	}
}