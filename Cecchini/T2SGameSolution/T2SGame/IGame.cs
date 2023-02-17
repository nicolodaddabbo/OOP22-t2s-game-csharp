namespace T2SGame;
/// <summary>
/// This interface abstracts the concepts of "Game" ("Partita" in italian).
/// </summary>
public interface IGame
{
    /// <summary>
    /// 
    /// </summary>
    /// <value>The state of the current game.</value>
    public IState State { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <value>The world of the current game.</value>
    public IWorld World { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>true if the logics of the game determs the end of the game,otherwise false.
    /// </returns>
    bool IsOver();
    
    /// <summary>
    /// Update the game based on the events and checks occoured.
    /// </summary>
    void Update();

}