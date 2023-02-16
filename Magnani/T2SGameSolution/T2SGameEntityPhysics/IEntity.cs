namespace T2SGameEntityPhysics
{
    /// <summary>
    /// This interface represents the entities of the game.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// List of components of the entity.
        /// </summary>
        HashSet<IComponent> Components { get; }

        /// <summary>
        /// The type of entity.
        /// </summary>
        EntityType Type { get; }

        /// <summary>
        /// The entity position.
        /// </summary>
        Vector2D Position { get; set; }

        /// <typeparam name="T">Type of the requested component.</typeparam>
        /// <returns>The specified component if present, otherwise returns null.</returns>
        T GetComponent<T>() where T : IComponent;

        /// <summary>
        /// This method is used to add components to the entity.
        /// </summary>
        /// <param name="component">Adds specified component to the set of components of the 
        /// entity</param>
        /// <returns>This entity.</returns>
        IEntity AddComponent(IComponent component);

        /// <summary>
        /// This method is used to notify the components of the entity.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <typeparam name="T">The type of the receiver.</typeparam>
        /// <typeparam name="S">The type of the message.</typeparam>
        void NotifyComponent<T, S>(IMessageFunc<S> message) where T : IComponent;

    }
}