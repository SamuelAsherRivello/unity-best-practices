using System.Collections.Generic;
using RMC.Core.Frameworks.BehaviorTreeFramework.BlackboardSystem;
using UnityEngine;


namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
    public class PlayerBehaviorTree : BehaviorTree
    {
        public Transform Transform;
        
        public Transform[] Waypoints;

        protected override Node CreateRootNode()
        {
            
            Node root = 
                new Selector_AkaOr_Node(new List<Node>
                {
             
                    //Try this first
                    new Sequence_AkaAnd_Node(new List<Node>
                    {
                        //if yes
                        new IsFoodCloseNode(Transform),
                        
                        //then also do this
                        new MoveToTransformNode(Transform),
                        
                        //then also do this
                        new EatFoodNode(Transform)
                    }),
                    
                    //If not, try this
                    new MoveToWaypointsNode(Transform, Waypoints),

                });

            return root;
        }
    }
}

