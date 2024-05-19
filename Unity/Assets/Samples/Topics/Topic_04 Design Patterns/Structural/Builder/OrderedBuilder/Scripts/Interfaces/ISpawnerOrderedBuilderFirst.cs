using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.OrderedBuilder
{
    public interface ISpawnerOrderedBuilderFirst :
        ISpawnerOrderedBuilderSecond,
        ISpawnerOrderedBuilderThird,
        ISpawnerOrderedBuilderFourth
    {
        /// <summary>
        /// 1. Must call this one first
        /// </summary>
        ISpawnerOrderedBuilderSecond SetPrefab(GameObject prefab);
        

    }
}