namespace test;

[TestClass]
public class WorldTest
{
    private IWorldFactory _worldFactory = new WorldFactory();

    private void TestBasics(IWorld world)
    {
        var waveFactory = new WaveFactory();
        var wave = waveFactory.CreateBasicWave(1);
        var e = EntityFactory.CreateBaseEnemy();
        // Adding one entity
        world.AddEntity(e);
        Assert.IsTrue(world.Entities.Contains(e));
        // Removing one entity
        world.RemoveEntity(e);
        Assert.IsFalse(world.Entities.Contains(e));
        // Adding more entities
        var entities = new List<IEntity>{
                EntityFactory.CreateBaseEnemy(),
                EntityFactory.CreateBaseEnemy()};
        world.AddEntities(entities);
        entities.ForEach(entity => Assert.IsTrue(world.Entities.Contains(entity)));
        // Removing more entities
        world.RemoveEntities(entities);
        entities.ForEach(entity => Assert.IsFalse(world.Entities.Contains(entity)));
        // Getting get/set wave
        Assert.IsNull(world.CurrentWave);
        world.CurrentWave = wave;
        Assert.IsNotNull(world.CurrentWave);
    }

    [TestMethod]
    public void TestCreateWorldWithOnePlayer()
    {
        var world = _worldFactory.CreateWorldWithOnePlayer();
        TestBasics(world);
        Assert.AreEqual(1, world.Players.Count);

    }

    [TestMethod]
    public void TestCreateWorldWithCompanion()
    {
        var world = _worldFactory.CreateWorldWithPlayerAndCompanion();
        TestBasics(world);
        Assert.AreEqual(1, world.Players.Count);
        IEntity? companion = world.Entities.Find(e => e.Type == EntityType.Companion);
        Assert.IsNotNull(companion);
    }
}