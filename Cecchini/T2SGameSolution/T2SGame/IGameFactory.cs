namespace T2SGame;
/// <summary>
/// A factory to create Game instance.
/// </summary>
public interface IGameFactory
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns>A new game based on SinglePlayer Mode</returns>
    IGame CreateSinglePlayer();

    /// <summary>
    /// 
    /// </summary>
    /// <returns>A new game based on SinglePlayer mode with companion.</returns>
    IGame CreateWithCompanion();
}