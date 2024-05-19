using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.OrderedBuilder
{
    public interface ISpawnerOrderedBuilderThird
    {
        /// <summary>
        /// 3. Must call this one third
        /// </summary>
        ISpawnerOrderedBuilderFourth SetRotation(Quaternion rotation);

    }
}