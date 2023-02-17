namespace T2SGame;
using T2SGameEntityPhysics;
/// <summary>
/// Rapresent the state and the logics of a Game.
/// </summary>
public interface IState
{
    /// <summary>
    /// 
    /// </summary>
    /// <value>The number of the current round.</value>
    public int Round { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entities">the list of players which are playing the Game.</param>
    /// <returns>true if logics determines the end of the game, otherwise false.</returns>
    bool IsOver(List<IEntity> entities);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="wave">the wave which the status has to check if empty or not.
    /// This wave to be checked should be the wave linked to the current round,
    /// contained in the World.
    /// </param>
    /// <returns>true if there aren't survived enemies, otherwise false.</returns>
    bool IsWaveOver(IWave? wave);

    /// <summary>
    ///  Increment the number of round.
    /// </summary>
    void IncrementRound();


}