using UnityEngine;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        public float MoveSpeed = 2f;
        
        [SerializeField]
        public float WaitDelayInSeconds = 0.5f;

        [SerializeField]
        public float MinimumFoodDistance = 6f;

        [SerializeField]
        private Transform[] _waypoints;

        private PlayerBehaviorTree _behaviorTree;

        protected void Start()
        {
            
            //Create tree
            _behaviorTree = new PlayerBehaviorTree();
            
            //Populate blackboard data
            _behaviorTree.Blackboard.SetValue("MoveSpeed", MoveSpeed);
            _behaviorTree.Blackboard.SetValue("WaitDelayInSeconds", WaitDelayInSeconds);
            _behaviorTree.Blackboard.SetValue("MinimumFoodDistance", MinimumFoodDistance);
            
            //Populate local tree data
            _behaviorTree.Transform = transform;
            _behaviorTree.Waypoints = _waypoints;
            
            //Init
            _behaviorTree.Initialize();
        }

        protected void Update()
        {
            _behaviorTree.OnTick(Time.deltaTime);
        }
    }
}

