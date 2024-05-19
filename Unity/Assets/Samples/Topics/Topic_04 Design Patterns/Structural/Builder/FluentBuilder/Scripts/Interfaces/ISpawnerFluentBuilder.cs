using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.FluentBuilder
{
    public interface ISpawnerFluentBuilder
    {
        ISpawnerFluentBuilder SetPrefab(GameObject prefab);
        ISpawnerFluentBuilder SetPosition(Vector3 position);
        ISpawnerFluentBuilder SetRotation(Quaternion rotation);
        ISpawner Build();
    }
}