namespace T2SGame;

/// <summary>
/// A GameFactory's implementation.
/// </summary>
public class GameFactory : IGameFactory
{
    private readonly IWorldFactory _worldFactory = new WorldFactory();
    /// <inheritdoc />
    public IGame CreateSinglePlayer() => new T2SGame(new T2SState(), _worldFactory.CreateWorldWithOnePlayer());

    /// <inheritdoc />
    public IGame CreateWithCompanion() => new T2SGame(new T2SState(), _worldFactory.CreateWorldWithPlayerAndCompanion());
}