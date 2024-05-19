using RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player.Interfaces;
using RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Settings;
using UnityEngine;

namespace RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player
{
    public class PlayerMover : PlayerManager, IPlayerMover
    {
        public PlayerMover(GameObject player, GameObject bulletPrefab, PlayerSettings settings) : 
            base(player, bulletPrefab, settings)
        {
        }

        public override void Update()
        {
            Move();
        }

        public void Move()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _player.transform.position -= Vector3.back * _settings.SettingsDeltaZ;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _player.transform.position += Vector3.back * _settings.SettingsDeltaZ;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _player.transform.position += Vector3.left * _settings.SettingsDeltaX;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _player.transform.position += Vector3.right * _settings.SettingsDeltaX;
            }
        }
    }
}