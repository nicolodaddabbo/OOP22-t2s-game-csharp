namespace T2SGame;

/// <summary>
/// This class represents a T2S Game.
/// To running a game, the instance of the class has to be hosted by the
/// GameEngine.
/// </summary>
public class T2SGame : IGame
{
    private IState _state;
    private IWorld _world;

    /// <summary>
    /// Create a T2SGame based on state and world.
    /// </summary>
    /// <param name="state">Represents the state/logics of the current game.</param>
    /// <param name="world">Represents the world where the entities of the game are placed.</param>
    public T2SGame(IState state, IWorld world)
    {
        _state = state;
        _world = world;
    }
    /// <inheritdoc />
    public IState State => _state;

    /// <inheritdoc />
    public IWorld World => _world;

    /// <inheritdoc />
    public bool IsOver() => _state.IsOver(_world.Players);

    /// <inheritdoc />
    public void Update()
    {
        // [TODO]
        _state.IncrementRound();
    }
}