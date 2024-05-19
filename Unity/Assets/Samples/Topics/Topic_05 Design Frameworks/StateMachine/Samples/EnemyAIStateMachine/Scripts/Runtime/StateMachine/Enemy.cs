using System;
using RMC.Core.Frameworks.StateMachineFramework;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.StateMachineFramework.Sample
{
    public class Enemy : MonoBehaviour
    {
        //  Properties ---------------------------------------------
        public Renderer Renderer => _renderer;

        //  Fields -------------------------------------------------
        [SerializeField]
        private Renderer _renderer;
        private StateMachine _stateMachine;
        
        //  Unity Methods ------------------------------------------
        protected void Start()
        {
            // Create State Machine
            _stateMachine = new StateMachine();

            // Create States
            var enemyWaitState = new EnemyWaitState(this);
            var enemyTurnState = new EnemyTurnState(this);
            
            // Create Transitions 
            _stateMachine.AddTransition(
                enemyWaitState, 
                enemyTurnState, 
                new FuncPredicate(IsExitWait));

            
            _stateMachine.AddTransition(
                enemyTurnState, 
                enemyWaitState,
                new FuncPredicate(IsExitTurn));

            // Set Defaults
            _stateMachine.SetState(enemyWaitState);
        }

        private bool IsExitWait()
        {
            var b = Input.GetKey(KeyCode.LeftArrow);
            return b;
        }
        
        private bool IsExitTurn()
        {
            var b = Input.GetKey(KeyCode.RightArrow);
            return b;
        }

        protected void Update()
        {
            _stateMachine.Update();
        }
        
        protected void FixedUpdate()
        {
            _stateMachine.FixedUpdate();
        }

        //  Methods ------------------------------------------------

        
        //  Event Handlers ------------------------------------------

    }
}
