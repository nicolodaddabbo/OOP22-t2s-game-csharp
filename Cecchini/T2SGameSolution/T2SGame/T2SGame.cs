namespace T2SGame;
using T2SGameEntityPhysics;

/// <summary>
/// This class represents a T2S Game.
/// To running a game, the instance of the class has to be hosted by the
/// GameEngine.
/// </summary>
public class T2SGame : IGame
{
    private IState _state;
    private IWorld _world;
    private IWaveFactory _waveFactory = new WaveFactory();

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
        AddWaveIfOver();
    }

    private void NextWave()
    {
        _state.IncrementRound();
        _world.CurrentWave = _waveFactory.CreateBasicWave(_state.Round);
    }

    private void AddWaveIfOver()
    {
        if (_state.IsWaveOver(_world.CurrentWave))
        {
            NextWave();
        }
    }
    
}