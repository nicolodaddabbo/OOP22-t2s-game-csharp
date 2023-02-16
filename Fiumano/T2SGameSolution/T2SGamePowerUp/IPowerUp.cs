using T2SGameSolution.codeForTestPurposes;

namespace T2SGameSolution.T2SGamePowerUp
{
    /// <summary>
    /// functional interface that represents a power up.
    /// </summary>
    public interface IPowerUp 
    {
        /// <summary>
        /// method called to obtain/gain a power up.
        /// </summary>
        /// <param name="entity">entity that receives the power up</param>
        void Obtain(IEntity entity);
    }
}