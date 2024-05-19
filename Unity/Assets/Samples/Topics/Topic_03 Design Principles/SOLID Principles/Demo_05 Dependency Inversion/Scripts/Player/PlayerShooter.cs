using RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player.Interfaces;
using RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Settings;
using UnityEngine;

namespace RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player
{
    public class PlayerShooter : PlayerManager, IPlayerShooter
    {
        public PlayerShooter(GameObject player, GameObject bulletPrefab, PlayerSettings settings) : 
            base(player, bulletPrefab, settings)
        {
        }

        public override void Update()
        {
            if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)))
            {
                Shoot();
            }
        }

        public void Shoot()
        {
            GameObject bullet = GameObject.Instantiate<GameObject>(_bulletPrefab);
            bullet.transform.position = _player.transform.position + Vector3.up * 1;
            bullet.GetComponent<Rigidbody>().AddForce(_settings.SettingsBulletForce);
        }
    }
}