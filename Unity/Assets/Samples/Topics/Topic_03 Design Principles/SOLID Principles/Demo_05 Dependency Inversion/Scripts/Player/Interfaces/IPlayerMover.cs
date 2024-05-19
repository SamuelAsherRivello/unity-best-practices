namespace RMC.BestPractices.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player.Interfaces
{
    public interface IPlayerMover : IPlayerUpdate
    {
        void Move();
    }
}