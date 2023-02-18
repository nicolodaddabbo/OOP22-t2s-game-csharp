namespace T2SGame;
using ecs;
/// <summary>
/// Rapresenting the "World" of T2S game.
/// The World is like a "container" of different entities involved in the game.
/// </summary>
public interface IWorld
{
    /// <summary>
    /// 
    /// </summary>
    /// <value>The wave of the current round</value>
    public IWave? CurrentWave { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value>The list of entities in the world</value>
    public List<IEntity> Entities { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <value>The list of entities rappresenting the "players"</value>
    public List<IEntity> Players { get; }

    /// <summary>
    /// Add the entity to the World.
    /// </summary>
    /// <param name="entity">Entity to be added to the world.</param>
    /// <returns>this.</returns>
    IWorld AddEntity(IEntity entity);

    /// <summary>
    /// Adds a List of entities in to the world.
    /// </summary>
    /// <param name="entities">the entities to add to world.</param>
    /// <returns>this.</returns>
    IWorld AddEntities(List<IEntity> entities);

    /// <summary>
    /// Remove the entity from the world.
    /// </summary>
    /// <param name="entity">Th entity to remove.</param>
    /// <returns>this.</returns>
    IWorld RemoveEntity(IEntity entity);

    /// <summary>
    ///  Removes a List of entities from the world.
    /// </summary>
    /// <param name="entities">The list of entities to remove.</param>
    /// <returns>this.</returns>
    IWorld RemoveEntities(List<IEntity> entities);

}