using T2SGame;

namespace T2SGameEntityPhysics
{
    /// <summary>
    /// This class represents an entity.
    /// </summary>
    public class Entity : IEntity
    {

        private readonly HashSet<IComponent> _components;

        /// <inheritdoc />
        public IWorld? World { get; set; }

        /// <inheritdoc />
        public EntityType Type { get; }

        /// <inheritdoc />
        public Vector2D Position { get; set; }

        /// <param name="position">The starting position of the entity.</param>
        /// <param name="type">The type of the entity.</param>
        public Entity(Vector2D position, EntityType type)
        {
            _components = new HashSet<IComponent>();
            Type = type;
            Position = position;
        }

        /// <inheritdoc />
        public HashSet<IComponent> Components => new HashSet<IComponent>(_components);

        /// <inheritdoc />
        public T? GetComponent<T>() where T : IComponent
        {
            return _components.OfType<T>().FirstOrDefault();
        }

        /// <inheritdoc />
        public IEntity AddComponent(IComponent component)
        {
            _components.Add(component);
            if (component is AbstractComponent)
            {
                ((AbstractComponent)component).Entity = this;
            }
            return this;
        }

        /// <inheritdoc />
        public void NotifyComponent<T, S>(MessageFunc<S> message) where T : IComponent
        {
            GetComponent<T>()?.Receive(message);
        }

    }
}