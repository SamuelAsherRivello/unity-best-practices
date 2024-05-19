using RMC.BestPractices.DesignPatterns.CreationalPatterns.SingletonPattern.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.CreationalPatterns.SingletonPattern.SuperSingletonMonoBehaviour
{
	/// <summary>
	/// Allows to be referenced via "Instance"
	/// and dynamically created on demand.
	/// 
	/// NOTE: This is a VERY light implementation.
	/// 
	/// </summary>
	public class MySuperSingleton : SingletonMonobehavior<MySuperSingleton>
	{
		
		//  Properties -----------------------------------------------
		public static SubSystemA SubSystemA
		{
			get
			{
				if (!IsInstantiated)
				{
					return null;
				}

				return Instance._subSystemA;
			}
		
		}
		
		public static SubSystemB SubSystemB
		{
			get
			{
				if (!IsInstantiated)
				{
					return null;
				}

				return Instance._subSystemB;
			}
		
		}
		
		//  Fields -------------------------------------------------
		private SubSystemA _subSystemA = null;
		private SubSystemB _subSystemB = null;
		
		//  Parent Methods ------------------------------------------
		public override void InstantiateCompleted()
		{
			Debug.Log("InstantiateCompleted()");
			_subSystemA = new SubSystemA();
			_subSystemA.Instantiate();
			_subSystemB = new SubSystemB();
			_subSystemB.Instantiate();
		}

		//  Private Methods ------------------------------------------
		private void _SayHelloWorld()
		{
			Debug.Log("Hello World!");
		}
		
		//  Static Methods -------------------------------------------
		public static void SayHelloWorld()
		{
			//Public static wrapper for private instance functionality
			Instance._SayHelloWorld();
		}
	}
}

