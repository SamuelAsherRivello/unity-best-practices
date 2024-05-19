using RMC.Core.Frameworks.BehaviorTreeFramework.BlackboardSystem;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
    public class MoveToTransformNode : Node
    {
        private Transform _transform;

        public MoveToTransformNode(Transform transform)
        {
            _transform = transform;
        }

        public override NodeState Evaluate()
        {
            Debug.Log("Move?");
            
            Transform target = Blackboard.GetValueOrNull<Transform>("target");
            if (target != null)
            {
                float moveSpeed = Blackboard.GetValue<float>("MoveSpeed");
                
                if (Vector3.Distance(_transform.position, target.position) > 0.01f)
                {
                    _transform.position = Vector3.MoveTowards
                    (
                        _transform.position, target.position,
                        moveSpeed * Time.deltaTime);
                        _transform.LookAt(target.position
                    );
                    
                    
                    // Set state and return
                    return _state = NodeState.Running;
       
                }
                else
                {
                    // Set state and return
                    return _state = NodeState.Success;
                }
            }

            // Set state and return
            return _state = NodeState.Failure;
        }

    }
}