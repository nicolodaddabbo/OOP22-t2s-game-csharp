namespace test;

[TestClass]
public class GameTest
{
    private IGameFactory _gameFactory = new GameFactory();
    void TestBasics(IGame game)
    {
        var w = game.World;
        Assert.IsNotNull(w);
        var s = game.State;
        Assert.IsNotNull(s);
        var players = game.World.Players;
        game.Update();
        Assert.AreEqual(1, s.Round);
        Assert.IsFalse(game.IsOver());
        game.World.RemoveEntities(players);
        game.Update();
        Assert.IsTrue(game.IsOver());

    }

    [TestMethod]
    public void TestSinglePlayer()
    {
        var game = _gameFactory.CreateSinglePlayer();
        // Check if the game contains only one player
        Assert.AreEqual(1, game.World.Players.Count);
        TestBasics(game);

    }

    [TestMethod]
    public void TestPlayerWithCompanion()
    {
        var game = _gameFactory.CreateWithCompanion();
        // Check if the game contains one player and one companion
        Assert.AreEqual(1, game.World.Players.Count);
        IEntity? companion = game.World.Entities.Find(e => e.Type == EntityType.Companion);
        Assert.IsNotNull(companion);
        TestBasics(game);
    }
}