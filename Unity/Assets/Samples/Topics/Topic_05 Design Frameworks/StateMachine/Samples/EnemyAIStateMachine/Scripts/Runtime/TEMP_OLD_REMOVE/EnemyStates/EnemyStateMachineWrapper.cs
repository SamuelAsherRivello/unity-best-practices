using UnityEngine;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public class EnemyStateMachineWrapper : MonoBehaviour
    {

        [SerializeField]  private Enemy enemy;
        [SerializeField] float wanderRadius = 10f;
        [SerializeField] float timeBetweenAttacks = 1f;
        CountdownTimer attackTimer;
        private StateMachine stateMachine;
        PlayerDetector playerDetector;
        protected void Start()
        {
            attackTimer = new CountdownTimer(timeBetweenAttacks);
            stateMachine = new StateMachine();

       
            var wanderState = new EnemyWanderState(enemy, enemy.Animator, enemy.NavMeshAgent, wanderRadius);
            var chaseState = new EnemyChaseState(enemy, enemy.Animator, enemy.NavMeshAgent, playerDetector.Player);
            var attackState = new EnemyAttackState(enemy, enemy.Animator, enemy.NavMeshAgent, playerDetector.Player);
            
            At(wanderState, chaseState, new FuncPredicate(() => playerDetector.CanDetectPlayer()));
            At(chaseState, wanderState, new FuncPredicate(() => !playerDetector.CanDetectPlayer()));
            At(chaseState, attackState, new FuncPredicate(() => playerDetector.CanAttackPlayer()));
            At(attackState, chaseState, new FuncPredicate(() => !playerDetector.CanAttackPlayer()));

            stateMachine.SetState(wanderState);
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