using UnityEngine;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public class PlayerStateMachineWrapper : MonoBehaviour
    {
        private StateMachine stateMachine;
        private Player player;
        protected void Start()
        {
            // State Machine
            stateMachine = new StateMachine();

            // Declare states
            var locomotionState = new LocomotionState(player, player.Animator);
            var jumpState = new JumpState(player, player.Animator);
            var dashState = new DashState(player, player.Animator);
            var attackState = new AttackState(player, player.Animator);

            // Define transitions
            At(locomotionState, jumpState, new FuncPredicate(() => player.JumpTimer));
            At(locomotionState, dashState, new FuncPredicate(() => player.DashTimer));
            At(locomotionState, attackState, new FuncPredicate(() => player.AttackTimer));
            At(attackState, locomotionState, new FuncPredicate(() => !player.AttackTimer));
            Any(locomotionState, new FuncPredicate(WillReturnToLocomotionState));

            // Set initial state
            stateMachine.SetState(locomotionState);
        }

        void At(IState from, IState to, IPredicate condition) => stateMachine.AddTransition(from, to, condition);
        void Any(IState to, IPredicate condition) => stateMachine.AddAnyTransition(to, condition);
        
        bool WillReturnToLocomotionState()
        {
            return true; // groundChecker.IsGrounded && !player.AttackTimer && !player.JumpTimer && !player.DashTimer;
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