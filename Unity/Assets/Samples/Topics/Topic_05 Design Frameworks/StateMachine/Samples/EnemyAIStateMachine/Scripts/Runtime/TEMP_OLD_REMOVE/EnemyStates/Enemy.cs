
using UnityEngine;
using UnityEngine.AI;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public class Enemy : MonoBehaviour
    {
        public Animator Animator { get; set; }
        
        public NavMeshAgent NavMeshAgent { get; set; }
        
        public void Attack()
        {
            throw new System.NotImplementedException();
        }


    }
}