using RMC.Core.Frameworks.StateMachineFramework;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.StateMachineFramework.Sample
{
    public class EnemyBaseState : IState
    {
        //  Properties ---------------------------------------------

        //  Fields -------------------------------------------------
        protected Enemy _enemy;
        
        //  Initialization -----------------------------------------
        public EnemyBaseState(Enemy enemy)
        {
            _enemy = enemy;
        }

        //  Methods ------------------------------------------------
        public virtual void OnEnter()
        {
            Debug.Log($"{this.GetType().Name} {nameof(OnEnter)}");
        }

        public virtual void Update()
        {
        }

        public virtual void FixedUpdate()
        {
        }

        public virtual void OnExit()
        {
            Debug.Log($"{this.GetType().Name} {nameof(OnExit)}");
        }
        
        protected void SetColor(Color color)
        {
            _enemy.Renderer.material.SetColor("_Color", color);
        }
        
   
            
        //  Event Handlers ------------------------------------------


    }
}