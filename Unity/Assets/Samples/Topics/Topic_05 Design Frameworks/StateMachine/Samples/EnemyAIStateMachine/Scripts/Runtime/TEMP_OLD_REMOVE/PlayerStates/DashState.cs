using UnityEngine;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public class DashState : BaseState {
        public DashState(Player player, Animator animator) : base(player, animator) { }

        public override void OnEnter() {
            animator.CrossFade(DashHash, crossFadeDuration);
        }

        public override void FixedUpdate() {
            player.HandleMovement();
        }
    }
}