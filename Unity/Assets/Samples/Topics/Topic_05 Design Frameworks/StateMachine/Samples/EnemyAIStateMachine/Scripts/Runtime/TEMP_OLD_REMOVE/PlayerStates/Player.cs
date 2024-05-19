using UnityEngine;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public class Player : MonoBehaviour 
    {
        public bool JumpTimer { get; set; }
        public Animator Animator { get; set; }
        public bool DashTimer { get; set; }
        public bool AttackTimer { get; set; }

        public void HandleMovement()
        {
            throw new System.NotImplementedException();
        }

        public void HandleJump()
        {
            throw new System.NotImplementedException();
        }

        public void Attack()
        {
            throw new System.NotImplementedException();
        }



    }
}