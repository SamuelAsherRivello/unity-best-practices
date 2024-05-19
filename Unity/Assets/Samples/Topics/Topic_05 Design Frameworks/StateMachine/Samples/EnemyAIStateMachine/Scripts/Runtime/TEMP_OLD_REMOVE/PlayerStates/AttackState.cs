using UnityEngine;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public class AttackState : BaseState {
        public AttackState(Player player, Animator animator) : base(player, animator) { }

        public override void OnEnter() {
            animator.CrossFade(AttackHash, crossFadeDuration);
            player.Attack();
        }

        public override void FixedUpdate() {
            player.HandleMovement();
        }
    }
}