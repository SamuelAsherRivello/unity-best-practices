namespace RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player.Interfaces
{
    public interface IPlayerShooter : IPlayerUpdate
    {
        void Shoot();
    }
}