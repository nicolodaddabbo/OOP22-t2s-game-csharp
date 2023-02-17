using System.Collections.Immutable;
namespace T2SGame;
using T2SGameEntityPhysics;
/// <summary>
/// Represents the WorldFactory's implementation.
/// </summary>
public class WorldFactory : IWorldFactory
{
    /// <inheritdoc />
    public IWorld CreateWorldWithOnePlayer() => CreateBasicWorld().AddEntity(EntityFactory.CreatePlayer());

    /// <inheritdoc />
    public IWorld CreateWorldWithPlayerAndCompanion() => CreateWorldWithOnePlayer().AddEntity(EntityFactory.CreateCompanion());

    private IWorld CreateBasicWorld()
    {
        var world = new T2SWorld();
        // Adding walls;
        return world.AddEntities(new List<IEntity>{
            EntityFactory.CreateWall(),
            EntityFactory.CreateWall(),
            EntityFactory.CreateWall(),
            EntityFactory.CreateWall()
        });
    }
}