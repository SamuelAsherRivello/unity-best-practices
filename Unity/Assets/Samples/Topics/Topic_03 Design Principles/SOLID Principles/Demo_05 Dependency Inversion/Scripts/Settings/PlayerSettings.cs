using UnityEngine;

namespace RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Settings
{
    public class PlayerSettings
    {
        public readonly float SettingsDeltaX = 1;
        public readonly float SettingsDeltaZ = 2;
        public readonly Vector3 SettingsPlayerResetPosition = new Vector3(0, 0, 0);
        public readonly float SettingsBoundsFront = -5;
        public readonly float SettingsBoundsBack = 5;
        public readonly float SettingsBoundsLeft = -5;
        public readonly float SettingsBoundsRight = 5;
        public readonly Vector3 SettingsBulletForce = new Vector3(0, 300, 0);
    }
}