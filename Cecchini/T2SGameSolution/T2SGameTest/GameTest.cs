namespace test;

[TestClass]
public class GameTest
{
    

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
        // [TODO] Kill all players
        // ...
        game.Update();
        Assert.IsTrue(game.IsOver());

    }

    [TestMethod]
    public void TestSinglePlayer()
    {
        
    }

    [TestMethod]
    public void TestPlayerWithCompanion()
    {

    }
}