namespace T2SGameEntityPhysics
{
    /// <summary>
    /// This abstract class factorized the common code between all components
    /// subtypes.
    /// In particular, get/set entity has been factorized.
    /// </summary>
    public abstract class AbstractComponent : IComponent
    {

        /// <inheritdoc />
        public abstract void Update();

        /// <inheritdoc />
        public abstract void Receive<T>(MessageFunc<T> message);

        // Disable "non-nullable property is uninitialized" warning because an
        // AbstractComponent always has an associated entity. The entity is assigned
        // when the component is added to the entity, and can be accessed only through
        // the entity, ensuring that the property is never null.
#pragma warning disable CS8618
        /// <summary>
        /// The entity the component is linked to.
        /// </summary>
        public IEntity Entity { get; set; }

    }
}