using UnityEngine;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public class LocomotionState : BaseState {
        public LocomotionState(Player player, Animator animator) : base(player, animator) { }
        
        public override void OnEnter() {
            animator.CrossFade(LocomotionHash, crossFadeDuration);
        }
        
        public override void FixedUpdate() {
            player.HandleMovement();
        }
    }
}