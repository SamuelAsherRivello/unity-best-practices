using RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player.Interfaces;
using RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Settings;
using UnityEngine;

namespace RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player
{
    public class PlayerBoundsChecker : PlayerManager, IPlayerBoundsChecker
    {
        public PlayerBoundsChecker(GameObject player, GameObject bulletPrefab, PlayerSettings settings) : 
            base(player, bulletPrefab, settings)
        {
        }
		
        public override void Update()
        {
            CheckBounds();
        }

        public void CheckBounds()
        {
            if (_player.transform.position.x > _settings.SettingsBoundsRight ||
                _player.transform.position.x < _settings.SettingsBoundsLeft ||
                _player.transform.position.z > _settings.SettingsBoundsBack||
                _player.transform.position.z < _settings.SettingsBoundsFront)
            {
                _player.transform.position = _settings.SettingsPlayerResetPosition;
                Debug.Log("You moved too far. Resetting :)");
            }
        }
    }
}