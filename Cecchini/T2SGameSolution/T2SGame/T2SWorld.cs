using ecs;

namespace T2SGame;

/// <summary>
/// This class is a basic implementation of World interface.
/// This implementationt allows handling differents players.
/// </summary>
public class T2SWorld : IWorld
{
    private IWave? _currentWave;
    private List<IEntity> _entities;

    /// <summary>
    /// Create a new World basic implementation.
    /// </summary>
    public T2SWorld()
    {
        _entities = new List<IEntity>();
    }

    /// <inheritdoc />
    public IWave? CurrentWave { get => _currentWave; set => _currentWave = value; }

    /// <inheritdoc />
    public List<IEntity> Entities => _entities;

    /// <inheritdoc />
    public List<IEntity> Players => _entities.FindAll(e => e.Type == EntityType.Player);

    /// <inheritdoc />
    public IWorld AddEntities(List<IEntity> entities)
    {
        entities.ForEach(e => AddEntity(e));
        return this;
    }

    /// <inheritdoc />
    public IWorld AddEntity(IEntity entity)
    {
        _entities.Add(entity);
        return this;
    }

    /// <inheritdoc />
    public IWorld RemoveEntities(List<IEntity> entities)
    {
        entities.ForEach(e => RemoveEntity(e));
        return this;
    }

    /// <inheritdoc />
    public IWorld RemoveEntity(IEntity entity)
    {
        _entities.Remove(entity);
        return this;
    }

}