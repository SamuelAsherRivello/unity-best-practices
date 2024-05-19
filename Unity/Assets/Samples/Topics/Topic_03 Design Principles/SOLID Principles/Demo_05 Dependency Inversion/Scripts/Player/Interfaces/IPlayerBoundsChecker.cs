namespace RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player.Interfaces
{
    public interface IPlayerBoundsChecker : IPlayerUpdate
    {
        void CheckBounds();
    }
}