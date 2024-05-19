using System.Collections.Generic;
using RMC.Core.Frameworks.BehaviorTreeFramework.BlackboardSystem;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
    public class RepeaterBehaviorTree : BehaviorTree
    {
        /// <summary>
        /// Demo: See <see cref="RepeaterNode"/> for expected behavior
        /// </summary>
        protected override Node CreateRootNode()
        {
            Node root =
                new RepeaterNode(new List<Node>()
                {
                    new CountUpNode(3),
                    new LogNode("Hello World")

                }, 3);
            return root;
        }
    }
}

