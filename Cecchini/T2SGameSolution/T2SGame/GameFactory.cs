namespace T2SGame;

/// <summary>
/// A GameFactory's implementation.
/// </summary>
public class GameFactory : IGameFactory
{
    private IWorldFactory worldFactory = new WorldFactory();
    /// <inheritdoc />
    public IGame CreateSinglePlayer() => new T2SGame(new T2SState(), worldFactory.CreateWorldWithOnePlayer());

    /// <inheritdoc />
    public IGame CreateWithCompanion() => new T2SGame(new T2SState(), worldFactory.CreateWorldWithPlayerAndCompanion());
}