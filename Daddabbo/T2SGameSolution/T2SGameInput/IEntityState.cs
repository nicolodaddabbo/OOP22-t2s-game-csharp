namespace T2SGameInput
{
    /// <summary>
    /// Interface that models the state (i.e. Concurrent State Machine) of an entity.
    /// </summary>
    /// <typeparam name="I">input type</typeparam>
    public interface IEntityState<I>
    {
        /// <summary>
        /// Changes the current command of the state based on the input received.
        /// </summary>
        /// <param name="input">the input received</param>
        void NotifyInput(I input);
        /// <summary>
        /// Changes the current command of the state based on the release of the input received.
        /// </summary>
        /// <param name="input">the released input</param>
        /// <param name="releaseCommandValue">the command to execute when the input is released</param>
        void NotifyInputRelease(I input, ICommand? releaseCommandValue);
        /// <summary>
        /// Gets the current command of the entity state.
        /// </summary>
        /// <returns>current command of the entity state if present</returns>
        ICommand? GetCurrentCommand();
    }
}