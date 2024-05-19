using RMC.Core.Frameworks.BehaviorTreeFramework.BlackboardSystem;
using UnityEngine;
namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
    public class EatFoodNode : Node
    {
        //private static int FoodLayerMask = 1 << 7;
        private Transform _transform;

        public EatFoodNode(Transform transform)
        {
            _transform = transform;
        }

        public override NodeState Evaluate()
        {
            Debug.Log("Eat?");
            
            Transform target = Blackboard.GetValueOrNull<Transform>("target");
            if (target != null)
            {
                Blackboard.SetValue<Transform>("target", null);
                GameObject.Destroy(target.gameObject);
                
                // Set state and return
                return _state = NodeState.Success;;
            }
            
            // Set state and return
            return _state = NodeState.Failure;;
        }

    }
}
