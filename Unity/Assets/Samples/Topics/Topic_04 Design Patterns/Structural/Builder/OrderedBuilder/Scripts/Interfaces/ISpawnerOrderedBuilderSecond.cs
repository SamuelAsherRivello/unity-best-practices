using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.OrderedBuilder
{
    public interface ISpawnerOrderedBuilderSecond
    {
        /// <summary>
        /// 2. Must call this one second
        /// </summary>
        ISpawnerOrderedBuilderThird SetPosition(Vector3 transformPosition);
    }
}