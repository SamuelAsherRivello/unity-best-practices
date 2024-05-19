
namespace RMC.BestPractices.Frameworks.StateMachineFramework.Sample
{
    public class EnemyWaitState : EnemyBaseState
    {
        //  Properties ---------------------------------------------

        //  Fields -------------------------------------------------
        
        //  Initialization -----------------------------------------
        public EnemyWaitState(Enemy enemy) : base(enemy)
        {
        }
        
        //  Methods ------------------------------------------------
        public override void OnEnter()
        {
          base.OnEnter();
          SetColor(UnityEngine.Color.white);
        }

        public override void Update()
        {
            base.Update();
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