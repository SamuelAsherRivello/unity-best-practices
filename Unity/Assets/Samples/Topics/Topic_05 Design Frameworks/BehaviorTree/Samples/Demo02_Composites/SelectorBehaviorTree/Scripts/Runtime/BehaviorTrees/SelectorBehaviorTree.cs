using System.Collections.Generic;
using RMC.Core.Frameworks.BehaviorTreeFramework.BlackboardSystem;


namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
    public class SelectorBehaviorTree : BehaviorTree
    {
        /// <summary>
        /// Demo: See <see cref="Selector_AkaOr_Node"/> for expected behavior
        /// </summary>
        protected override Node CreateRootNode()
        {
            Node root = 
                new Selector_AkaOr_Node(new List<Node>
                {
                    new CountUpNode(3),
                    new CountUpNode(3),
                });

            return root;
        }
    }
}

