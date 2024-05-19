using System.Collections.Generic;
using RMC.Core.Frameworks.BehaviorTreeFramework.BlackboardSystem;


namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
    public class ParallelBehaviorTree : BehaviorTree
    {
        /// <summary>
        /// Demo: See <see cref="Parallel_AkaEach_Node"/> for expected behavior
        /// </summary>
        protected override Node CreateRootNode()
        {
            Node root = 
                new Parallel_AkaEach_Node(new List<Node>
                {
                    new CountUpNode(3),
                    new CountUpNode(3),
                });

            return root;
        }
    }
}

