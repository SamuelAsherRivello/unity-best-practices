using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.OrderedBuilder
{
    public interface ISpawnerOrderedBuilderFourth
    {
        /// <summary>
        /// 4. Must call this one last
        /// </summary>
        ISpawner Build();
    }
}