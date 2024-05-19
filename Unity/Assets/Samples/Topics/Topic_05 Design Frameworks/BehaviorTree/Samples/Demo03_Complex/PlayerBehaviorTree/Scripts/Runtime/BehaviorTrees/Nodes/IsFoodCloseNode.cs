using RMC.Core.Frameworks.BehaviorTreeFramework.BlackboardSystem;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
    public class IsFoodCloseNode : Node
    {
        private static int FoodLayerMask = 1 << 7;
        private Transform _transform;

        public IsFoodCloseNode(Transform transform)
        {
            _transform = transform;
        }

        public override NodeState Evaluate()
        {
            Debug.Log("Close?");
            
            Transform target = Blackboard.GetValueOrNull<Transform>("target");
            if (target == null)
            {
                
                float minimumFoodDistance = Blackboard.GetValue<float>("MinimumFoodDistance");
                
                Collider[] colliders = Physics.OverlapSphere(
                    _transform.position, 
                    minimumFoodDistance, 
                    FoodLayerMask);

                if (colliders.Length > 0)
                {
                    Blackboard.SetValue<Transform>("target", colliders[0].transform);
                    Debug.Log("Close enough - target now set");
                    return _state = NodeState.Success;;
                }
            }
            return _state = NodeState.Failure;;
        }

    }
}
