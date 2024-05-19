using RMC.Core.Frameworks.BehaviorTreeFramework.BlackboardSystem;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
    public class MoveToWaypointsNode : Node
    {
        private Transform _transform;
        private Transform[] _waypoints;

        private int _currentWaypointIndex = 0;

        private float _waitCounter = 0f;
        private bool _waiting = false;

        public MoveToWaypointsNode(Transform transform, Transform[] waypoints)
        {
            _transform = transform;
            _waypoints = waypoints;
        }

        
        public override NodeState Evaluate()
        {
            if (_waiting)
            {
                _waitCounter += Time.deltaTime;
                float waitDelayInSeconds = Blackboard.GetValue<float>("WaitDelayInSeconds");
                
                if (_waitCounter >= waitDelayInSeconds)
                {
                    _waiting = false;
                }
            }
            else
            {
                Transform wp = _waypoints[_currentWaypointIndex];
                if (Vector3.Distance(_transform.position, wp.position) < 0.01f)
                {
                    _transform.position = wp.position;
                    _waitCounter = 0f;
                    _waiting = true;

                    _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Length;
                }
                else
                {
                    float moveSpeed = Blackboard.GetValue<float>("MoveSpeed");
                    
                    _transform.position =
                        Vector3.MoveTowards(
                            _transform.position, 
                            wp.position, moveSpeed * Time.deltaTime);
                    _transform.LookAt(wp.position);
                }
            }

            // Set state and return
            return _state = NodeState.Running;;
        }

    }
}
