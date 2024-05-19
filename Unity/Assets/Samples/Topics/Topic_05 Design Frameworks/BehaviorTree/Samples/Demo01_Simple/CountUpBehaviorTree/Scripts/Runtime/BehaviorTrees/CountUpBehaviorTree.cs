
using RMC.Core.Frameworks.BehaviorTreeFramework.BlackboardSystem;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
    public class CountUpBehaviorTree : BehaviorTree
    {
        /// <summary>
        /// Demo: See <see cref="CountUpNode"/> for expected behavior
        /// </summary>
        protected override Node CreateRootNode()
        {
            Node root = new CountUpNode(3);
            return root;
        }
    }
}

