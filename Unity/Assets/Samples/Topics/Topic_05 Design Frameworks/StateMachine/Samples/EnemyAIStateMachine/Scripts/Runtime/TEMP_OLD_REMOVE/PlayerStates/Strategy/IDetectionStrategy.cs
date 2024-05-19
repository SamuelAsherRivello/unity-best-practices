using RMC.Core.Frameworks.StateMachineFramework;
using UnityEngine;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public interface IDetectionStrategy 
    {
        bool Execute(Transform player, Transform detector, CountdownTimer timer);
    }
}