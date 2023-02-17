namespace T2SGame;
/// <summary>
/// This interface models a factory of World.
/// </summary>
public interface IWorldFactory
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns>A World implementation with only one player</returns>
    IWorld CreateWorldWithOnePlayer();

    /// <summary>
    /// 
    /// </summary>
    /// <returns>A World implementation with one player and one companion</returns>
    IWorld CreateWorldWithPlayerAndCompanion();
}