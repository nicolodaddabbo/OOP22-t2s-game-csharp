namespace T2SGameSolution.codeForTestPurposes
{
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
        void Receive<T>(IMessageFunc<T> message);
    }
}