namespace T2SGameEntityPhysics
{
    /// <summary>
    /// This interface represents the component's contract of a entity.
    /// A Component hold a particular aspect, or domain, of the entity which it
    /// belongs.
    /// This class helps to decouple all the multiple domains of a Entity from the
    /// Entity it self, delegating
    /// to the respective component to update its domain.
    /// </summary>
    public interface IComponent
    {

        /// <summary>
        /// This method updates the domain of the component of specified entity.
        /// </summary>
        void Update();

        /// <summary>
        /// Receive a message packet.
        /// </summary>
        /// <param name="message">The message to receive.</param>
        /// <typeparam name="T">The type of message.</typeparam>
        void Receive<T>(MessageFunc<T> message);

    }
}