
using UnityEngine;

namespace RMC.BestPractices.Frameworks.StateMachineFramework.Sample
{
    public class EnemyTurnState : EnemyBaseState
    {
        //  Properties ---------------------------------------------

        //  Fields -------------------------------------------------
        
        //  Initialization -----------------------------------------
        public EnemyTurnState(Enemy enemy) : base(enemy)
        {
        }
        
        
        //  Methods ------------------------------------------------
        public override void OnEnter()
        {
          base.OnEnter();
          SetColor(UnityEngine.Color.blue);
        }

        
        public override void Update()
        {
            base.Update();
            _enemy.transform.Rotate(new Vector3(1f, 4, 55) * Time.deltaTime);
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override void OnExit()
        {
            base.OnExit();
        }
        
        //  Event Handlers ------------------------------------------


  
    }
}