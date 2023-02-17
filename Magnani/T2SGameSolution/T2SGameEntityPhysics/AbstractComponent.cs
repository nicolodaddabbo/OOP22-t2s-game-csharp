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

        /// <summary>
        /// The entity the component is linked to.
        /// </summary>
        public IEntity Entity { get; set; }

    }
}