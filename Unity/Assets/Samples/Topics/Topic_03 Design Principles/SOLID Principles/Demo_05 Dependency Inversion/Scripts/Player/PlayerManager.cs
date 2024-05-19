using RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player.Interfaces;
using RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Settings;
using UnityEngine;

namespace RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player
{
    public abstract class PlayerManager : IPlayerUpdate
    {
        protected GameObject _player;
        protected GameObject _bulletPrefab;
        protected PlayerSettings _settings;

        public PlayerManager(GameObject player, GameObject bulletPrefab, PlayerSettings settings)
        {
            _player = player;
            _bulletPrefab = bulletPrefab;
            _settings = settings;
        }

        public abstract void Update();
    }
}